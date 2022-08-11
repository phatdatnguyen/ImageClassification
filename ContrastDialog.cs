using Accord;
using Accord.Imaging;
using Accord.Imaging.Filters;
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
    public partial class ContrastDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private LevelsLinear levelsLinear = null;

        private bool formLoaded = false;

        // Property
        public LevelsLinear LevelsLinear { get { return levelsLinear; } }

        // Constructor
        public ContrastDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            levelsLinear = new LevelsLinear()
            {
                InRed = new IntRange(0, 255),
                InGreen = new IntRange(0, 255),
                InBlue = new IntRange(0, 255)
            };
            afterImage = levelsLinear.Apply(beforeImage);
            afterPictureBox.Image = afterImage;

            formLoaded = true;
        }

        // Methods
        public string GetDescription()
        {
            return "adjust amount = " + lowerLimitNumericUpDown.Value.ToString();
        }

        private void limitNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            if (sender == lowerLimitNumericUpDown && upperLimitNumericUpDown.Value <= lowerLimitNumericUpDown.Value)
                upperLimitNumericUpDown.Value = lowerLimitNumericUpDown.Value + 1;
            if (sender == upperLimitNumericUpDown && lowerLimitNumericUpDown.Value >= upperLimitNumericUpDown.Value)
                lowerLimitNumericUpDown.Value = upperLimitNumericUpDown.Value - 1;

            if (allChannelsRadioButton.Checked)
            {
                levelsLinear.InRed = new IntRange((int)lowerLimitNumericUpDown.Value,(int)upperLimitNumericUpDown.Value);
                levelsLinear.InGreen = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
                levelsLinear.InBlue = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
            }
            else if (redChannelRadioButton.Checked)
            {
                levelsLinear.InRed = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
                levelsLinear.InGreen = new IntRange(0, 255);
                levelsLinear.InBlue = new IntRange(0, 255);
            }
            else if (greenChannelRadioButton.Checked)
            {
                levelsLinear.InRed = new IntRange(0, 255);
                levelsLinear.InGreen = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
                levelsLinear.InBlue = new IntRange(0, 255);
            }
            else
            {
                levelsLinear.InRed = new IntRange(0, 255);
                levelsLinear.InGreen = new IntRange(0, 255);
                levelsLinear.InBlue = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
            }
            afterImage = levelsLinear.Apply(beforeImage);
            afterPictureBox.Image = afterImage;
        }

        private void applyToRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            if (allChannelsRadioButton.Checked)
            {
                levelsLinear.InRed = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
                levelsLinear.InGreen = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
                levelsLinear.InBlue = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
            }
            else if (redChannelRadioButton.Checked)
            {
                levelsLinear.InRed = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
                levelsLinear.InGreen = new IntRange(0, 255);
                levelsLinear.InBlue = new IntRange(0, 255);
            }
            else if (greenChannelRadioButton.Checked)
            {
                levelsLinear.InRed = new IntRange(0, 255);
                levelsLinear.InGreen = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
                levelsLinear.InBlue = new IntRange(0, 255);
            }
            else
            {
                levelsLinear.InRed = new IntRange(0, 255);
                levelsLinear.InGreen = new IntRange(0, 255);
                levelsLinear.InBlue = new IntRange((int)lowerLimitNumericUpDown.Value, (int)upperLimitNumericUpDown.Value);
            }
            afterImage = levelsLinear.Apply(beforeImage);
            afterPictureBox.Image = afterImage;
        }

        private void beforeShowHistogramsButton_Click(object sender, EventArgs e)
        {
            HistogramsDialog histogramsDialog = new HistogramsDialog(beforeImage);
            histogramsDialog.Show(this);
        }

        private void afterShowHistogramsButton_Click(object sender, EventArgs e)
        {
            HistogramsDialog histogramsDialog = new HistogramsDialog(afterImage);
            histogramsDialog.Show(this);
        }
    }
}
