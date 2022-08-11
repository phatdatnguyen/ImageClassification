using Accord;
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
    public partial class SVMLearningControl : UserControl
    {
        // Field
        private double[][] inputColumns = null;

        // Property
        public double[][] InputColumns
        {
            set
            {
                inputColumns = value;
            }
        }

        // Constructor
        public SVMLearningControl()
        {
            InitializeComponent();
        }

        // Methods
        public IKernel CreateKernel()
        {
            if (gaussianKernelRadioButton.Checked)
                return new Gaussian((double)gaussianSigmaNumericUpDown.Value);
            else if (polynomialKernelRadioButton.Checked)
            {
                if (polynomialDegreeNumericUpDown.Value == 1)
                    return new Linear((double)polynomialConstantNumericUpDown.Value);
                return new Polynomial((int)polynomialDegreeNumericUpDown.Value, (double)polynomialConstantNumericUpDown.Value);
            }
            else if (laplacianKernelRadioButton.Checked)
                return new Laplacian((double)laplacianSigmaNumericUpDown.Value);
            else // sigmoidKernelRadioButton.Checked
                return new Sigmoid((double)sigmoidAlphaNumericUpDown.Value, (double)sigmoidConstantNumericUpDown.Value);
        }

        private void complexityEstimateButton_Click(object sender, EventArgs e)
        {
            if (inputColumns == null)
                return;

            IKernel kernel = CreateKernel();
            ComplexityNumericUpDown.Value = (decimal)kernel.EstimateComplexity(inputColumns);
        }

        private void gaussianEstimateButton_Click(object sender, EventArgs e)
        {
            if (inputColumns == null)
                return;

            Gaussian gaussian = Gaussian.Estimate(inputColumns, inputColumns.Length);
            gaussianSigmaNumericUpDown.Value = (decimal)gaussian.Sigma;
        }

        private void laplacianEstimateButton_Click(object sender, EventArgs e)
        {
            if (inputColumns == null)
                return;

            Laplacian laplacian = Laplacian.Estimate(inputColumns, inputColumns.Length, out DoubleRange range);
            laplacianSigmaNumericUpDown.Value = (decimal)laplacian.Sigma;
        }

        private void sigmoidEstimateButton_Click(object sender, EventArgs e)
        {
            if (inputColumns == null)
                return;

            Sigmoid sigmoid = Sigmoid.Estimate(inputColumns, inputColumns.Length, out DoubleRange range);

            if (sigmoid.Alpha < (double)Decimal.MaxValue && sigmoid.Alpha > (double)Decimal.MinValue)
                sigmoidAlphaNumericUpDown.Value = (decimal)sigmoid.Alpha;

            if (sigmoid.Constant < (double)Decimal.MaxValue && sigmoid.Constant > (double)Decimal.MinValue)
                sigmoidConstantNumericUpDown.Value = (decimal)sigmoid.Constant;
        }
    }
}
