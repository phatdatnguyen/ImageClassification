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
    public partial class ConvertToGrayscaleDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private Grayscale grayscale = new Grayscale(0.2989, 0.5870, 0.1141);

        // Property
        public Grayscale Grayscale { get { return grayscale; } }

        // Constructor
        public ConvertToGrayscaleDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            afterImage = grayscale.Apply(beforeImage);
            afterPictureBox.Image = afterImage;
        }

        // Method
        public string GetDescription()
        {
            return "0.2989 * R + 0.5870 * G + 0.1141 * B";
        }
    }
}
