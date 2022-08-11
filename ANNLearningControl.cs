﻿using Accord;
using Accord.Math;
using Accord.Math.Random;
using Accord.Neuro;
using Accord.Neuro.Learning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageClassification
{
    public partial class ANNLearningControl : UserControl
    {
        // Fields
        private double[][] inputColumns = null;
        private int[] classIndexColumn = null;
        private int[] classIndexes = null;
        private int[][] outputIntegerColumns;

        private bool useRegularization = false;
        private bool useNguyenWidrow = false;
        private bool useSameWeights = false;
        private double learningRate = 0.1;
        private int maxIteration = 1000;

        private IActivationFunction activationFunction = null;
        private ActivationNetwork ann = null;
        private LearningMethod learningMethod;

        private Thread workerThread = null;
        private int iteration = 0;
        private double error = 0;
        private TimeSpan elapsed = TimeSpan.Zero;
        private volatile bool needToStop = false;
        private double tolerance = 0;
        private bool isConverged = false;

        // Events
        public delegate void TrainingStartedEventHandler(EventArgs e);
        public event TrainingStartedEventHandler TrainingStarted;

        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelConverged;
        
        // Delegate
        private delegate void EnableCallback(bool enable);

        // Enum
        private enum LearningMethod
        {
            LevenbergMarquardt, Backpropagation, ResilientBackpropagation, ParallelResilientBackpropagation
        }

        // Properties
        public double[][] InputColumns
        {
            set
            {
                inputColumns = value;

                startButton.Enabled = true;
            }
        }

        public int[] ClassIndexColumn
        {
            set
            {
                classIndexColumn = value;

                classIndexes = classIndexColumn.Distinct().OrderBy(i => i).ToArray<int>();
                outputIntegerColumns = new int[classIndexColumn.Length][];
                for (int rowIndex = 0; rowIndex < classIndexColumn.Length; rowIndex++)
                {
                    outputIntegerColumns[rowIndex] = new int[classIndexes.Length];
                    for (int columnIndex = 0; columnIndex < classIndexes.Length; columnIndex++)
                        if (classIndexColumn[rowIndex] == classIndexes[columnIndex])
                            outputIntegerColumns[rowIndex][columnIndex] = 1;
                        else
                            outputIntegerColumns[rowIndex][columnIndex] = -1;
                }
            }
        }

        public bool IsConverged { get { return isConverged; } }

        // Constructor
        public ANNLearningControl()
        {
            InitializeComponent();

            networkStructureDataGridView.Rows.Add(new string[] { "Hidden 1", "10" });
            activationFunctionComboBox.SelectedIndex = 2;
            learningMethodComboBox.SelectedIndex = 0;
        }

        // Methods
        private void addLayerButton_Click(object sender, EventArgs e)
        {
            int currentNumberOfLayers = networkStructureDataGridView.Rows.Count;
            networkStructureDataGridView.Rows.Add(new string[] { "Hidden " + (currentNumberOfLayers + 1).ToString(), "3" });
        }

        private void deleteLayerButton_Click(object sender, EventArgs e)
        {
            if (networkStructureDataGridView.Rows.Count == 0)
                return;

            networkStructureDataGridView.Rows.RemoveAt(networkStructureDataGridView.Rows.Count - 1);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            isConverged = false;
            TrainingStarted(EventArgs.Empty);

            useRegularization = bayesianRegularizationCheckBox.Checked;
            useNguyenWidrow = nguyenWidrowCheckBox.Checked;
            useSameWeights = sameWeightsCheckBox.Checked;
            learningRate = (double)learningRateNumericUpDown.Value;
            tolerance = (double)toleranceNumericUpDown.Value;
            maxIteration = (int)maxIterationNumericUpDown.Value;
            activationFunction = CreateActivationFunction();

            //Create multi-layer neural network
            int numberOfInputs = inputColumns[0].Length;
            int[] layers = new int[networkStructureDataGridView.Rows.Count + 1]; // hidden layers + output layer
            try
            {
                for (int layerIndex = 0; layerIndex < networkStructureDataGridView.Rows.Count; layerIndex++)  // hidden layer
                    layers[layerIndex] = Convert.ToInt32(networkStructureDataGridView.Rows[layerIndex].Cells[1].Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            layers[layers.Length - 1] = classIndexes.Length; // output layer
            ann = new ActivationNetwork(activationFunction, numberOfInputs, layers);

            if (useNguyenWidrow)
            {
                if (useSameWeights)
                    Generator.Seed = 1;

                NguyenWidrow initializer = new NguyenWidrow(ann);
                initializer.Randomize();
            }

            switch (learningMethodComboBox.SelectedItem.ToString())
            {
                case "Levenberg-Marquardt":
                    learningMethod = LearningMethod.LevenbergMarquardt;
                    break;
                case "Backpropagation":
                    learningMethod = LearningMethod.Backpropagation;
                    break;
                case "Resilient Backpropagation":
                    learningMethod = LearningMethod.ResilientBackpropagation;
                    break;
                case "Parallel Resilient Backpropagation":
                    learningMethod = LearningMethod.ParallelResilientBackpropagation;
                    break;
            }

            EnableControls(false);

            //Run worker thread
            workerThreadTimer.Start();
            needToStop = false;
            workerThread = new Thread(new ThreadStart(SearchSolution));
            workerThread.Start();
        }

        private void SearchSolution() // On worker thread
        {
            int numberOfEntries = inputColumns.Length;

            try
            {
                //Create learner
                object annLearning = null;
                switch (learningMethod)
                {
                    case LearningMethod.LevenbergMarquardt:
                        annLearning = new LevenbergMarquardtLearning(ann, useRegularization)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.Backpropagation:
                        annLearning = new BackPropagationLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.ResilientBackpropagation:
                        annLearning = new ResilientBackpropagationLearning(ann)
                        {
                            LearningRate = learningRate
                        };
                        break;
                    case LearningMethod.ParallelResilientBackpropagation:
                        annLearning = new ParallelResilientBackpropagationLearning(ann);
                        break;
                }

                //Iterations
                iteration = 1;
                Stopwatch stopwatch = Stopwatch.StartNew();

                //Loop
                while (!needToStop)
                {
                    //Run epoch of learning procedure
                    switch (learningMethod)
                    {
                        case LearningMethod.LevenbergMarquardt:
                            error = ((LevenbergMarquardtLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.Backpropagation:
                            error = ((BackPropagationLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.ResilientBackpropagation:
                            error = ((ResilientBackpropagationLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                        case LearningMethod.ParallelResilientBackpropagation:
                            error = ((ParallelResilientBackpropagationLearning)annLearning).RunEpoch(inputColumns, outputIntegerColumns.ToDouble()) / numberOfEntries;
                            break;
                    }

                    //Increase current iteration
                    iteration++;
                    elapsed = stopwatch.Elapsed;
                    UpdateStatus();

                    //Check if model converged
                    if (iteration > maxIteration)
                    {
                        if (error <= tolerance)
                            isConverged = true;

                        break;
                    }
                }

                stopwatch.Stop();
                EnableControls(true);
            }
            catch
            {
                isConverged = false;
                EnableControls(true);
            }
        }

        private IActivationFunction CreateActivationFunction()
        {
            switch (activationFunctionComboBox.SelectedItem.ToString())
            {
                case "Bipolar Sigmoid":
                    return new BipolarSigmoidFunction((double)alphaNumericUpDown.Value);
                case "Sigmoid":
                    return new SigmoidFunction((double)alphaNumericUpDown.Value);
                case "Linear":
                    return new LinearFunction(new DoubleRange((double)lowerLimitNumericUpDown.Value, (double)upperLimitNumericUpDown.Value));
                case "Rectified Linear":
                    return new RectifiedLinearFunction();
                case "Threshold":
                    return new ThresholdFunction();
                case "Identity":
                    return new IdentityFunction();
                default:
                    throw new Exception("No function selected!");
            }
        }

        private void EnableControls(bool enable)
        {
            if (InvokeRequired)
            {
                EnableCallback d = new EnableCallback(EnableControls);
                Invoke(d, new object[] { enable });
            }
            else
            {
                startButton.Enabled = enable;
                stopButton.Enabled = !enable;
            }
        }

        private void UpdateStatus()
        {
            if (!iterationTextBox.InvokeRequired)
            {
                iterationTextBox.Text = iteration.ToString();
                errorTextBox.Text = error.ToString("N10");
                elapsedTextBox.Text = elapsed.ToString();
            }
            else
            {
                iterationTextBox.BeginInvoke(new Action(UpdateStatus));
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            needToStop = true;
            while (!workerThread.Join(100))
                Application.DoEvents();
            workerThread = null;

            if (error <= tolerance)
                isConverged = true;
        }

        private void workerThreadTimer_Tick(object sender, EventArgs e)
        {
            if (isConverged)
            {
                ModelConverged(new ModelTrainedEventArgs() { Model = ann });

                workerThreadTimer.Stop();
            }
        }

    }
}
