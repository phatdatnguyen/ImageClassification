using Accord.Imaging.Filters;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Neuro;
using Accord.Statistics.Kernels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageClassification
{
    public partial class MainForm : Form
    {
        // Fields
        private Dictionary<string, List<Bitmap>> classes = new Dictionary<string, List<Bitmap>>();
        private Dictionary<string, List<Bitmap>> processedImages = new Dictionary<string, List<Bitmap>>();

        private bool isDeletingListViewItem = false;

        private double[][] trainingInputColumns = null;
        private int[] trainingClassIndexColumn = null;

        private List<Tuple<string, object>> processingSteps = new List<Tuple<string, object>>();
        private int processedTrainingDataSize = 0;

        private List<Bitmap> predictionImages = new List<Bitmap>();
        private List<Bitmap> processedPredictionImages = new List<Bitmap>();
        private int[] predictedClassIndexColumn = null;

        private object classifier = null;
        private bool modelTrained = false;

        // Events
        public delegate void TrainingImagesChangedEventHandler(EventArgs e);
        public event TrainingImagesChangedEventHandler TrainingImagesChanged;

        public delegate void ProcessingStepsChangedEventHandler(EventArgs e);
        public event ProcessingStepsChangedEventHandler ProcessingStepsChanged;

        public delegate void ModelTrainedEventHandler(ModelTrainedEventArgs e);
        public event ModelTrainedEventHandler ModelTrained;

        public delegate void PredictionImagesChangedEventHandler(EventArgs e);
        public event PredictionImagesChangedEventHandler PredictionImagesChanged;

        // Constructor
        public MainForm()
        {
            InitializeComponent();

            TrainingImagesChanged += OnTrainingImagesChanged;
            ProcessingStepsChanged += OnProcessingStepsChanged;
            ModelTrained += OnModelTrained;
            PredictionImagesChanged += OnPredictionImagesChanged;
        }

        // Load images
        private void addClassButton_Click(object sender, EventArgs e)
        {
            ClassFormDialog classFormDialog = new ClassFormDialog();
            if (classFormDialog.ShowDialog(this) == DialogResult.Cancel)
                return;

            bool duplicated = false;
            foreach (ListViewItem item in classesListView.Items)
                if (item.Text == classFormDialog.ClassLabel)
                    duplicated = true;

            if (classFormDialog.ClassLabel == "")
                return;

            if (duplicated)
            {
                MessageBox.Show(this, "Class label was used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            classes.Add(classFormDialog.ClassLabel, new List<Bitmap>());
            ListViewItem newItem = new ListViewItem(classFormDialog.ClassLabel);
            foreach (ListViewItem selectedItem in classesListView.SelectedItems)
                selectedItem.Selected = false;
            classesListView.Items.Add(newItem);
            newItem.Selected = true;

            TrainingImagesChanged(EventArgs.Empty);
        }

        private void classesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classesListView.SelectedItems.Count == 0)
            {
                deleteClassButton.Enabled = false;
                takeImagesButton.Enabled = false;
                return;
            }

            if (isDeletingListViewItem)
                return;

            deleteClassButton.Enabled = true;
            takeImagesButton.Enabled = true;

            trainingImagesListView.Items.Clear();
            trainingImagePictureBox.Image = null;
            List<Bitmap> imageList = classes[classesListView.SelectedItems[0].Text];
            for (int i = 0; i < imageList.Count; i++)
                trainingImagesListView.Items.Add("Image " + (i + 1).ToString());
        }

        private void classesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (classesListView.SelectedItems.Count == 0)
                return;

            ClassFormDialog classFormDialog = new ClassFormDialog(classesListView.SelectedItems[0].Text);
            if (classFormDialog.ShowDialog(this) != DialogResult.OK)
                return;

            if (classFormDialog.ClassLabel == "")
            {
                MessageBox.Show(this, "Class label cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool duplicated = false;
            foreach (ListViewItem item in classesListView.Items)
                if (item.Text == classFormDialog.ClassLabel)
                    duplicated = true;

            if (duplicated)
            {
                MessageBox.Show(this, "Class label was used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Bitmap> imageList = classes[classesListView.SelectedItems[0].Text];
            classes.Remove(classesListView.SelectedItems[0].Text);
            classes.Add(classFormDialog.ClassLabel, imageList);
            classesListView.SelectedItems[0].Text = classFormDialog.ClassLabel;

            TrainingImagesChanged(EventArgs.Empty);
        }

        private void deleteClassButton_Click(object sender, EventArgs e)
        {
            if (classesListView.SelectedItems.Count == 0)
                return;

            isDeletingListViewItem = true;
            foreach (ListViewItem item in classesListView.SelectedItems)
            {
                classes.Remove(item.Text);
                classesListView.Items.Remove(item);
            }
            isDeletingListViewItem = false;

            trainingImagesListView.Items.Clear();
            trainingImagePictureBox.Image = null;

            TrainingImagesChanged(EventArgs.Empty);
        }

        private void classesListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteClassButton_Click(deleteClassButton, EventArgs.Empty);
        }

        private void takeImagesButton_Click(object sender, EventArgs e)
        {
            TakeImagesForm takeImagesForm = new TakeImagesForm();
            takeImagesForm.ImageTaken += OnImageTaken;
            takeImagesForm.ShowDialog(this);
        }

        private void OnImageTaken(ImageTakenEventArgs e)
        {
            classes[classesListView.SelectedItems[0].Text].Add(e.Image);

            int imageIndex = trainingImagesListView.Items.Count;
            ListViewItem item = new ListViewItem("Image " + (imageIndex + 1).ToString());
            trainingImagesListView.Items.Add(item);
            foreach (ListViewItem selectedItem in trainingImagesListView.SelectedItems)
                selectedItem.Selected = false;
            item.Selected = true;

            TrainingImagesChanged(EventArgs.Empty);
        }

        private void trainingImagesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trainingImagesListView.SelectedItems.Count == 0 || isDeletingListViewItem)
                return;

            deleteImageButton.Enabled = true;
            trainingImagePictureBox.Image = classes[classesListView.SelectedItems[0].Text][trainingImagesListView.SelectedIndices[0]];
        }

        private void deleteImageButton_Click(object sender, EventArgs e)
        {
            if (trainingImagesListView.SelectedItems.Count == 0)
                return;

            isDeletingListViewItem = true;
            foreach (ListViewItem item in trainingImagesListView.SelectedItems)
            {
                List<Bitmap> imageList = classes[classesListView.SelectedItems[0].Text];
                imageList.RemoveAt(item.Index);
                trainingImagesListView.Items.Remove(item);
            }
            isDeletingListViewItem = false;

            trainingImagePictureBox.Image = null;
            foreach (ListViewItem item in trainingImagesListView.Items)
                item.Text = "Image " + (item.Index + 1).ToString();

            TrainingImagesChanged(EventArgs.Empty);
        }

        private void trainingImagesListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteImageButton_Click(deleteImageButton, EventArgs.Empty);
        }

        private void OnTrainingImagesChanged(EventArgs e)
        {
            if (classes.Count == 0)
            {
                processButton.Enabled = false;
                addStepButton.Enabled = false;
                classComboBox.Items.Clear();
                classComboBox.Enabled = false;
                imageComboBox.Items.Clear();
                imageComboBox.Enabled = false;

                return;
            }

            addClassButton.Enabled = classes.Count <= 5;

            processButton.Enabled = true;
            addStepButton.Enabled = true;
            classComboBox.Items.Clear();
            classComboBox.Enabled = true;
            imageComboBox.Items.Clear();
            imageComboBox.Enabled = true;

            foreach (KeyValuePair<string, List<Bitmap>> _class in classes)
                classComboBox.Items.Add(_class.Key);
            classComboBox.SelectedIndex = 0;
        }
        
        // Preprocessing
        private void addStepButton_Click(object sender, EventArgs e)
        {
            if (processingPictureBox.Image == null)
            {
                MessageBox.Show(this, "Please choose an image for preview!", "Choose image", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            ChooseProcessingStepDialog chooseProcessingStepDialog = new ChooseProcessingStepDialog();
            if (chooseProcessingStepDialog.ShowDialog() != DialogResult.OK)
                return;

            mainTableLayoutPanel.RowStyles[1].Height = 250f;

            ListViewItem item = null;
            Bitmap currentImage = classes.ElementAt(classComboBox.SelectedIndex).Value[imageComboBox.SelectedIndex];
            switch (chooseProcessingStepDialog.ProcessingStepComboBox.SelectedIndex)
            {
                case 0:
                    CropDialog cropDialog = new CropDialog(ProcessImage(currentImage));
                    if (cropDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Crop", cropDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Crop", cropDialog.Crop));
                    processingStepsListView.Items.Add(item);

                    break;
                case 1:
                    ResizeDialog resizeDialog = new ResizeDialog(ProcessImage(currentImage));
                    if (resizeDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Resize", resizeDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Resize", resizeDialog.ResizeBilinear));
                    processingStepsListView.Items.Add(item);

                    break;
                case 2:
                    ExtractColorChannelDialog extractColorChannelDialog = new ExtractColorChannelDialog(ProcessImage(currentImage));
                    if (extractColorChannelDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Extract channel", extractColorChannelDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Extract channel", extractColorChannelDialog.ExtractChannel));
                    processingStepsListView.Items.Add(item);

                    break;
                case 3:
                    ConvertToGrayscaleDialog convertToGrayscaleDialog = new ConvertToGrayscaleDialog(ProcessImage(currentImage));
                    if (convertToGrayscaleDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Grayscale", convertToGrayscaleDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Grayscale", convertToGrayscaleDialog.Grayscale));
                    processingStepsListView.Items.Add(item);

                    break;
                case 4:
                    BrightnessDialog brightnessDialog = new BrightnessDialog(ProcessImage(currentImage));
                    if (brightnessDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Brightness", brightnessDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Brightness", brightnessDialog.BrightnessCorrection));
                    processingStepsListView.Items.Add(item);

                    break;
                case 5:
                    ContrastDialog contrastDialog = new ContrastDialog(ProcessImage(currentImage));
                    if (contrastDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Contrast", contrastDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Contrast", contrastDialog.LevelsLinear));
                    processingStepsListView.Items.Add(item);

                    break;
                case 6:
                    BoxBlurDialog boxBlurDialog = new BoxBlurDialog(ProcessImage(currentImage));
                    if (boxBlurDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Box blur", boxBlurDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Box blur", boxBlurDialog.FastBoxBlur));
                    processingStepsListView.Items.Add(item);

                    break;
                case 7:
                    GaussianBlurDialog gaussianBlurDialog = new GaussianBlurDialog(ProcessImage(currentImage));
                    if (gaussianBlurDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Gaussian blur", gaussianBlurDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Gaussian blur", gaussianBlurDialog.GaussianBlur));
                    processingStepsListView.Items.Add(item);

                    break;
                case 8:
                    SharpenDialog sharpenDialog = new SharpenDialog(ProcessImage(currentImage));
                    if (sharpenDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Sharpen", sharpenDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Sharpen", sharpenDialog.Sharpen));
                    processingStepsListView.Items.Add(item);

                    break;
                case 9:
                    GaussianSharpenDialog gaussianSharpenDialog = new GaussianSharpenDialog(ProcessImage(currentImage));
                    if (gaussianSharpenDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Gaussian sharpen", gaussianSharpenDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Gaussian sharpen", gaussianSharpenDialog.GaussianSharpen));
                    processingStepsListView.Items.Add(item);

                    break;
                case 10:
                    EdgesDetectionDialog edgesDetectionDialog = new EdgesDetectionDialog(ProcessImage(currentImage));
                    if (edgesDetectionDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    item = new ListViewItem("Edges detection", edgesDetectionDialog.GetDescription());
                    processingSteps.Add(new Tuple<string, object>("Edges detection", edgesDetectionDialog.Edges));
                    processingStepsListView.Items.Add(item);

                    break;
            }

            ProcessingStepsChanged(EventArgs.Empty);
        }

        private void processingStepListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void processingStepListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteStepButton_Click(object sender, EventArgs e)
        {
            if (processingStepsListView.SelectedItems.Count == 0)
                return;

            isDeletingListViewItem = true;
            foreach (ListViewItem item in processingStepsListView.SelectedItems)
            {
                processingSteps.RemoveAt(item.Index);
                processingStepsListView.Items.Remove(item);
            }
            isDeletingListViewItem = false;

            processingPictureBox.Image = null;

            ProcessingStepsChanged(EventArgs.Empty);
        }

        private void processingStepListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteStepButton_Click(deleteStepButton, EventArgs.Empty);
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Status: Processing...";
            Cursor = Cursors.WaitCursor;

            try
            {
                processedImages = new Dictionary<string, List<Bitmap>>();

                foreach (KeyValuePair<string, List<Bitmap>> _class in classes)
                {
                    processedImages.Add(_class.Key, new List<Bitmap>());

                    for (int i = 0; i < _class.Value.Count; i++)
                    {
                        Bitmap processedImage = ProcessImage(_class.Value[i]);
                        processedTrainingDataSize += processedImage.Width * processedImage.Height;
                        processedImages[_class.Key].Add(processedImage);
                    }
                        
                }

                PrepareTrainingData();

                statusLabel.Text = "Status: Processing complete.";
                chooseModelButton.Enabled = true;
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Status:";
                Cursor = Cursors.Default;
            }
        }

        private Bitmap ProcessImage(Bitmap image)
        {
            foreach (Tuple<string, object> processingStep in processingSteps)
            {
                switch (processingStep.Item1)
                {
                    case "Resize":
                        ResizeBilinear resizeBilinear = (ResizeBilinear)processingStep.Item2;
                        
                        return resizeBilinear.Apply(image);
                    case "Crop":
                        Crop crop = (Crop)processingStep.Item2;

                        return crop.Apply(image);
                    case "Extract channel":
                        ExtractChannel extractChannel = (ExtractChannel)processingStep.Item2;

                        return extractChannel.Apply(image);
                    case "Grayscale":
                        Grayscale grayscale = (Grayscale)processingStep.Item2;

                        return grayscale.Apply(image);
                    case "Brightness":
                        BrightnessCorrection brightnessCorrection = (BrightnessCorrection)processingStep.Item2;

                        return brightnessCorrection.Apply(image);
                    case "Contrast":
                        LevelsLinear levelsLinear = (LevelsLinear)processingStep.Item2;

                        return levelsLinear.Apply(image);
                    case "Box blur":
                        FastBoxBlur fastBoxBlur = (FastBoxBlur)processingStep.Item2;

                        return fastBoxBlur.Apply(image);
                    case "Gaussian blur":
                        GaussianBlur gaussianBlur = (GaussianBlur)processingStep.Item2;

                        return gaussianBlur.Apply(image);
                    case "Sharpen":
                        Sharpen sharpen = (Sharpen)processingStep.Item2;

                        return sharpen.Apply(image);
                    case "Gaussian sharpen":
                        GaussianSharpen gaussianSharpen = (GaussianSharpen)processingStep.Item2;

                        return gaussianSharpen.Apply(image);
                    case "Edges detection":
                        Edges edges = (Edges)processingStep.Item2;

                        return edges.Apply(image);
                }
            }

            return image;
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classComboBox.SelectedIndex == -1)
            {
                imageComboBox.Items.Clear();
                return;
            }

            imageComboBox.Items.Clear();
            if (classes.ElementAt(classComboBox.SelectedIndex).Value.Count == 0)
                return;

            int imageIndex = 0;
            foreach (Bitmap image in classes.ElementAt(classComboBox.SelectedIndex).Value)
            {
                imageComboBox.Items.Add("Image " + (imageIndex + 1).ToString());
                imageIndex++;
            }
            imageComboBox.SelectedIndex = 0;
        }

        private void imageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageComboBox.SelectedIndex == -1)
            {
                processingPictureBox.Image = null;
                return;
            }

            Bitmap image = classes.ElementAt(classComboBox.SelectedIndex).Value[imageComboBox.SelectedIndex];
            processingPictureBox.Image = ProcessImage(image);
        }

        private void OnProcessingStepsChanged(EventArgs e)
        {
            if (processingSteps.Count == 0)
            {
                deleteStepButton.Enabled = false;

                return;
            }

            addStepButton.Enabled = processingSteps.Count <= 10;

            deleteStepButton.Enabled = true;

            if (classComboBox.SelectedIndex != - 1 && imageComboBox.SelectedIndex != -1)
            {
                Bitmap image = classes.ElementAt(classComboBox.SelectedIndex).Value[imageComboBox.SelectedIndex];
                processingPictureBox.Image = ProcessImage(image);
            }
        }

        // Training
        private void PrepareTrainingData()
        {
            if (processedImages.Count <= 1)
                throw new Exception("Training data must contain more than 1 class!");

            int numberOfImages = 0;
            foreach (var _class in processedImages)
                numberOfImages += _class.Value.Count;
            trainingInputColumns = new double[numberOfImages][];
            trainingClassIndexColumn = new int[numberOfImages];

            int rowIndex = 0;
            for (int classIndex = 0; classIndex < processedImages.Count; classIndex++)
            {
                List<Bitmap> imageList = processedImages.ElementAt(classIndex).Value;
                for (int imageIndex = 0; imageIndex < imageList.Count; imageIndex++)
                {
                    trainingInputColumns[rowIndex] = ExtractFeature(imageList[imageIndex]);
                    trainingClassIndexColumn[rowIndex] = classIndex;
                    rowIndex++;
                }
            }
        }

        private void chooseModelButton_Click(object sender, EventArgs e)
        {
            ChooseModelDialog chooseModelDialog = new ChooseModelDialog();
            if (chooseModelDialog.ShowDialog() != DialogResult.OK)
                return;

            trainButton.Enabled = true;
            modelPanel.Controls.Clear();
            mainTableLayoutPanel.RowStyles[2].Height = 100f;
            trainPanel.BackColor = SystemColors.Control;

            switch (chooseModelDialog.ModelComboBox.SelectedIndex)
            {
                case 0:
                    SVMLearningControl svmLearningControl = new SVMLearningControl();
                    modelPanel.Controls.Add(svmLearningControl);

                    if (trainingInputColumns != null)
                        svmLearningControl.InputColumns = trainingInputColumns;

                    break;
                case 1:
                    ANNLearningControl annLearningControl = new ANNLearningControl();
                    modelPanel.Controls.Add(annLearningControl);

                    if (trainingInputColumns != null)
                    {
                        annLearningControl.InputColumns = trainingInputColumns;
                        annLearningControl.ClassIndexColumn = trainingClassIndexColumn;
                    }
                    annLearningControl.TrainingStarted += OnANNTrainingStarted;
                    annLearningControl.ModelConverged += OnANNConverged;
                    trainButton.Enabled = false;

                    break;
            }

            modelPanel.Controls[0].Left = (modelPanel.Width - modelPanel.Controls[0].Width) / 2;
            mainTableLayoutPanel.RowStyles[2].Height = modelPanel.Controls[0].Height + 10;
            chooseModelButton.Text = "Change model...";

            modelTrained = false;
            classifier = null;

            /*testMulticlassClassificationControl.Visible = false;
            testMulticlassClassificationControl.Reset();
            predictClassificationControl.Visible = false;
            predictClassificationControl.Reset();*/
        }

        private void trainingPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            trainButton.Enabled = true;
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            if (modelPanel.Controls.Count == 0)
            {
                MessageBox.Show(this, "You have to choose a model!", "Choose model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Bitmap firstImage = processedImages.ElementAt(0).Value[0];
            if (firstImage.Width > 200 || firstImage.Height > 200)
            {
                MessageBox.Show(this, "Image size is too large for training!", "Resize images", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (processedTrainingDataSize > 10000000)
            {
                MessageBox.Show(this, "Training data is too large!", "Reduce training data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            statusLabel.Text = "Status: Training...";
            Cursor = Cursors.WaitCursor;

            try
            {
                object classifier = null;

                if (modelPanel.Controls[0].GetType() == typeof(SVMLearningControl))
                {
                    SVMLearningControl svmLearningControl = (SVMLearningControl)modelPanel.Controls[0];
                    svmLearningControl.InputColumns = trainingInputColumns;
                    object multiclassSVMLearning = null;
                    IKernel kernel = svmLearningControl.CreateKernel();
                    if (svmLearningControl.SequentialMinimalOptimizationRadioButton.Checked)
                    {
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<IKernel>()
                        {
                            Learner = (p) => new SequentialMinimalOptimization<IKernel>()
                            {
                                Complexity = Convert.ToDouble(svmLearningControl.ComplexityNumericUpDown.Value),
                                Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                                PositiveWeight = Convert.ToDouble(svmLearningControl.PositiveWeightNumericUpDown.Value),
                                NegativeWeight = Convert.ToDouble(svmLearningControl.NegativeWeightNumericUpDown.Value),
                                Kernel = kernel
                            }
                        };
                        classifier = ((MulticlassSupportVectorLearning<IKernel>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmLearningControl.LeastSquaresRadioButton.Checked)
                    {
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<IKernel<double[]>, double[]>()
                        {
                            Learner = (p) => new LeastSquaresLearning()
                            {
                                Complexity = Convert.ToDouble(svmLearningControl.ComplexityNumericUpDown.Value),
                                Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                                PositiveWeight = Convert.ToDouble(svmLearningControl.PositiveWeightNumericUpDown.Value),
                                NegativeWeight = Convert.ToDouble(svmLearningControl.NegativeWeightNumericUpDown.Value),
                                Kernel = kernel
                            }
                        };
                        classifier = ((MulticlassSupportVectorLearning<IKernel<double[]>, double[]>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmLearningControl.LinearCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Coordinate Descent method can only use linear kernel!");
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<Linear>()
                        {
                            Learner = (p) => new LinearCoordinateDescent()
                            {
                                Complexity = Convert.ToDouble(svmLearningControl.ComplexityNumericUpDown.Value),
                                Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                                PositiveWeight = Convert.ToDouble(svmLearningControl.PositiveWeightNumericUpDown.Value),
                                NegativeWeight = Convert.ToDouble(svmLearningControl.NegativeWeightNumericUpDown.Value),
                                Kernel = (Linear)kernel
                            }
                        };
                        classifier = ((MulticlassSupportVectorLearning<Linear>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmLearningControl.LinearDualCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Dual Coordinate Descent method can only use linear kernel!");
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<Linear>()
                        {
                            Learner = (p) => new LinearDualCoordinateDescent()
                            {
                                Complexity = Convert.ToDouble(svmLearningControl.ComplexityNumericUpDown.Value),
                                Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                                PositiveWeight = Convert.ToDouble(svmLearningControl.PositiveWeightNumericUpDown.Value),
                                NegativeWeight = Convert.ToDouble(svmLearningControl.NegativeWeightNumericUpDown.Value),
                                Kernel = (Linear)kernel
                            }
                        };
                        classifier = ((MulticlassSupportVectorLearning<Linear>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmLearningControl.LinearNewtonRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Linear Newton method can only use linear kernel!");
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<Linear>()
                        {
                            Learner = (p) => new LinearNewtonMethod()
                            {
                                Complexity = Convert.ToDouble(svmLearningControl.ComplexityNumericUpDown.Value),
                                Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                                PositiveWeight = Convert.ToDouble(svmLearningControl.PositiveWeightNumericUpDown.Value),
                                NegativeWeight = Convert.ToDouble(svmLearningControl.NegativeWeightNumericUpDown.Value),
                                Kernel = (Linear)kernel
                            }
                        };
                        classifier = ((MulticlassSupportVectorLearning<Linear>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmLearningControl.ProbabilisticCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Coordinate Descent method can only use linear kernel!");
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<Linear>()
                        {
                            Learner = (p) => new ProbabilisticCoordinateDescent()
                            {
                                Complexity = Convert.ToDouble(svmLearningControl.ComplexityNumericUpDown.Value),
                                Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                                PositiveWeight = Convert.ToDouble(svmLearningControl.PositiveWeightNumericUpDown.Value),
                                NegativeWeight = Convert.ToDouble(svmLearningControl.NegativeWeightNumericUpDown.Value),
                                Kernel = (Linear)kernel
                            }
                        };
                        classifier = ((MulticlassSupportVectorLearning<Linear>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmLearningControl.ProbabilisticDualCoordinateDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Dual Coordinate Descent method can only use linear kernel!");
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<Linear>()
                        {
                            Learner = (p) => new ProbabilisticDualCoordinateDescent()
                            {
                                Complexity = Convert.ToDouble(svmLearningControl.ComplexityNumericUpDown.Value),
                                Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                                PositiveWeight = Convert.ToDouble(svmLearningControl.PositiveWeightNumericUpDown.Value),
                                NegativeWeight = Convert.ToDouble(svmLearningControl.NegativeWeightNumericUpDown.Value),
                                Kernel = (Linear)kernel
                            }
                        };
                        classifier = ((MulticlassSupportVectorLearning<Linear>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmLearningControl.ProbabilisticNewtonRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Probabilistic Newton method can only use linear kernel!");
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<Linear>()
                        {
                            Learner = (p) => new ProbabilisticNewtonMethod()
                            {
                                Complexity = Convert.ToDouble(svmLearningControl.ComplexityNumericUpDown.Value),
                                Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                                PositiveWeight = Convert.ToDouble(svmLearningControl.PositiveWeightNumericUpDown.Value),
                                NegativeWeight = Convert.ToDouble(svmLearningControl.NegativeWeightNumericUpDown.Value),
                                Kernel = (Linear)kernel
                            }
                        };
                        classifier = ((MulticlassSupportVectorLearning<Linear>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else if (svmLearningControl.StochasticGradientDescentRadioButton.Checked)
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Stochastic Gradient Descent method can only use linear kernel!");
                        StochasticGradientDescent stochasticGradientDescent = new StochasticGradientDescent()
                        {
                            Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<Linear>()
                        {
                            Learner = (p) => stochasticGradientDescent
                        };
                        classifier = ((MulticlassSupportVectorLearning<Linear>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                    else // svmLearningControl.StochasticGradientDescentRadioButton.Checked
                    {
                        if (kernel.GetType() != typeof(Linear))
                            throw new Exception("Averaged Stochastic Gradient Descent method can only use linear kernel!");
                        AveragedStochasticGradientDescent averagedStochasticGradientDescent = new AveragedStochasticGradientDescent()
                        {
                            Tolerance = Convert.ToDouble(svmLearningControl.ToleranceNumericUpDown.Value),
                            Kernel = (Linear)kernel
                        };
                        multiclassSVMLearning = new MulticlassSupportVectorLearning<Linear>()
                        {
                            Learner = (p) => averagedStochasticGradientDescent
                        };
                        classifier = ((MulticlassSupportVectorLearning<Linear>)multiclassSVMLearning).Learn(trainingInputColumns, trainingClassIndexColumn);
                    }
                }

                ModelTrained(new ModelTrainedEventArgs() { Model = classifier });
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Status:";
                Cursor = Cursors.Default;
            }
        }

        public double[] ExtractFeature(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            double[] features = new double[width * height];

            int rowIndex = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    features[rowIndex] = 0.2989 * pixel.R + 0.5870 * pixel.G + 0.1141 * pixel.B;
                    rowIndex++;
                }
            }

            return features;
        }

        private void OnModelTrained(ModelTrainedEventArgs e)
        {
            classifier = e.Model;

            trainPanel.BackColor = Color.LightGreen;

            predictionTakeImagesButton.Enabled = true;

            modelTrained = true;
            statusLabel.Text = "Status: Model trained.";
            Cursor = Cursors.Default;
        }

        private void OnANNTrainingStarted(EventArgs e)
        {
            classifier = null;
            trainPanel.BackColor = SystemColors.Control;
        }

        private void OnANNConverged(ModelTrainedEventArgs e)
        {
            ModelTrained(new ModelTrainedEventArgs() { Model = e.Model });
        }

        // Prediction
        private void predictionTakeImagesButton_Click(object sender, EventArgs e)
        {
            TakeImagesForm takeImagesForm = new TakeImagesForm();
            takeImagesForm.ImageTaken += OnPredictionImageTaken;
            takeImagesForm.ShowDialog(this);
        }

        private void OnPredictionImageTaken(ImageTakenEventArgs e)
        {
            predictionImages.Add(e.Image);

            int imageIndex = predictionListView.Items.Count;
            ListViewItem item = new ListViewItem(new string[] { "Image " + (imageIndex + 1).ToString(), "(...)" });
            predictionListView.Items.Add(item);
            foreach (ListViewItem selectedItem in predictionListView.SelectedItems)
                selectedItem.Selected = false;
            item.Selected = true;

            PredictionImagesChanged(EventArgs.Empty);
        }

        private void predictionDeleteButton_Click(object sender, EventArgs e)
        {
            if (predictionListView.SelectedItems.Count == 0)
                return;

            isDeletingListViewItem = true;
            foreach (ListViewItem item in predictionListView.SelectedItems)
            {
                predictionImages.RemoveAt(item.Index);
                predictionListView.Items.Remove(item);
            }
            isDeletingListViewItem = false;

            predictionPictureBox.Image = null;
            foreach (ListViewItem item in predictionListView.Items)
                item.SubItems[0].Text = "Image " + (item.Index + 1).ToString();

            PredictionImagesChanged(EventArgs.Empty);
        }

        private void predictionListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                predictionDeleteButton_Click(predictionDeleteButton, EventArgs.Empty);
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Status: Making prediction";
            Cursor = Cursors.Default;

            try
            {
                processedPredictionImages = new List<Bitmap>();
                predictedClassIndexColumn = new int[predictionImages.Count];

                for (int i = 0; i < predictionImages.Count; i++)
                {
                    // preprocessing
                    processedPredictionImages.Add(ProcessImage(predictionImages[i]));

                    // Extract features
                    double[] inputs = ExtractFeature(processedPredictionImages[i]);

                    // predict
                    if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<Linear>))
                    {
                        MulticlassSupportVectorMachine<Linear> svm = (MulticlassSupportVectorMachine<Linear>)classifier;
                        predictedClassIndexColumn[i] = svm.Decide(inputs);
                    }
                    else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel>))
                    {
                        MulticlassSupportVectorMachine<IKernel> svm = (MulticlassSupportVectorMachine<IKernel>)classifier;
                        predictedClassIndexColumn[i] = svm.Decide(inputs);
                    }
                    else if (classifier.GetType() == typeof(MulticlassSupportVectorMachine<IKernel<double[]>, double[]>))
                    {
                        MulticlassSupportVectorMachine<IKernel<double[]>, double[]> svm = (MulticlassSupportVectorMachine<IKernel<double[]>, double[]>)classifier;
                        predictedClassIndexColumn[i] = svm.Decide(inputs);
                    }

                    // update result
                    predictionListView.Items[i].SubItems[1].Text = classes.ElementAt(predictedClassIndexColumn[i]).Key;
                }

                statusLabel.Text = "Status: Prediction made.";
                Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Status:";
                Cursor = Cursors.Default;
            }
        }

        private void predictionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (predictionListView.SelectedItems.Count == 0 || isDeletingListViewItem)
                return;

            predictionDeleteButton.Enabled = true;
            predictionPictureBox.Image = predictionImages[predictionListView.SelectedIndices[0]];
        }

        private void OnPredictionImagesChanged(EventArgs e)
        {
            if (predictionImages.Count == 0)
            {
                predictionDeleteButton.Enabled = false;
                predictButton.Enabled = false;

                return;
            }

            predictionDeleteButton.Enabled = true;
            predictButton.Enabled = true;
        }
    }
}
