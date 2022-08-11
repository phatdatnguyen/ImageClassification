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
    public partial class BoxBlurDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private FastBoxBlur fastBoxBlur = null;

        private bool formLoaded = false;

        // Property
        public FastBoxBlur FastBoxBlur { get { return fastBoxBlur; } }

        // Constructor
        public BoxBlurDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            fastBoxBlur = new FastBoxBlur((byte)kernelSizeNumericUpDown.Value, (byte)kernelSizeNumericUpDown.Value);
            afterImage = fastBoxBlur.Apply(beforeImage);
            afterPictureBox.Image = afterImage;

            formLoaded = true;
        }

        // Methods
        public string GetDescription()
        {
            return "kernel size: " + kernelSizeNumericUpDown.Value.ToString() + "×" + kernelSizeNumericUpDown.Value.ToString();
        }

        private void kernelSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            fastBoxBlur = new FastBoxBlur((byte)kernelSizeNumericUpDown.Value, (byte)kernelSizeNumericUpDown.Value);
            afterImage = fastBoxBlur.Apply(beforeImage);
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
