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
    public partial class GaussianSharpenDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private GaussianSharpen gaussianSharpen = null;

        private bool formLoaded = false;

        // Property
        public GaussianSharpen GaussianSharpen { get { return gaussianSharpen; } }

        // Constructor
        public GaussianSharpenDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            gaussianSharpen = new GaussianSharpen((double)sigmaNumericUpDown.Value, (int)kernelSizeNumericUpDown.Value);
            afterImage = gaussianSharpen.Apply(beforeImage);
            afterPictureBox.Image = afterImage;

            formLoaded = true;
        }

        // Methods
        public string GetDescription()
        {
            return "sigma: " + sigmaNumericUpDown.Value.ToString() + "\nkernel size: " + kernelSizeNumericUpDown.Value.ToString() + "×" + kernelSizeNumericUpDown.Value.ToString();
        }

        private void kernelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            gaussianSharpen = new GaussianSharpen((double)sigmaNumericUpDown.Value, (int)kernelSizeNumericUpDown.Value);
            afterImage = gaussianSharpen.Apply(beforeImage);
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
