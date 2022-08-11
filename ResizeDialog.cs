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
    public partial class ResizeDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private ResizeBilinear resizeBilinear = null;

        private bool formLoaded = false;

        // Property
        public ResizeBilinear ResizeBilinear { get { return resizeBilinear; } }

        // Constructor
        public ResizeDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            int width = image.Width;
            int height = image.Height;
            widthNumericUpDown.Maximum = width;
            widthNumericUpDown.Value = width;
            heightNumericUpDown.Maximum = height;
            heightNumericUpDown.Value = height;

            resizeBilinear = new ResizeBilinear(width, height);
            afterImage = resizeBilinear.Apply(beforeImage);
            afterPictureBox.Image = afterImage;

            formLoaded = true;
        }

        // Methods
        public string GetDescription()
        {
            return "width = " + widthNumericUpDown.Value.ToString() + ", height = " + heightNumericUpDown.Value.ToString();
        }

        private void imageSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            int width = (int)widthNumericUpDown.Value;
            int height = (int)heightNumericUpDown.Value;

            resizeBilinear = new ResizeBilinear(width, height);
            afterImage = resizeBilinear.Apply(beforeImage);
            afterPictureBox.Image = afterImage;
        }
    }
}
