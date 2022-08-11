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
    public partial class CropDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private Crop crop = null;

        private bool formLoaded = false;

        // Property
        public Crop Crop { get { return crop; } }

        // Constructor
        public CropDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            int width = image.Width;
            int height = image.Height;

            xNumericUpDown.Maximum = width - 1;
            yNumericUpDown.Maximum = height - 1;

            widthNumericUpDown.Maximum = width;
            widthNumericUpDown.Value = width;
            heightNumericUpDown.Maximum = height;
            heightNumericUpDown.Value = height;

            crop = new Crop(new Rectangle(0, 0, width, height));
            afterImage = crop.Apply(beforeImage);
            afterPictureBox.Image = afterImage;

            formLoaded = true;
        }

        // Methods
        public string GetDescription()
        {
            return "x = " + xNumericUpDown.Value.ToString() + ", y = " + yNumericUpDown.Value.ToString() + ", width = " + widthNumericUpDown.Value.ToString() + ", height = " + heightNumericUpDown.Value.ToString();
        }

        private void cropSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            if (sender == xNumericUpDown || sender == yNumericUpDown)
            {
                widthNumericUpDown.Maximum = beforeImage.Width - xNumericUpDown.Value;
                heightNumericUpDown.Maximum = beforeImage.Height - yNumericUpDown.Value;
            }

            int x = (int)xNumericUpDown.Value;
            int y = (int)yNumericUpDown.Value;
            int width = (int)widthNumericUpDown.Value;
            int height = (int)heightNumericUpDown.Value;

            crop = new Crop(new Rectangle(x, y, width, height));
            afterImage = crop.Apply(beforeImage);
            afterPictureBox.Image = afterImage;
        }
    }
}
