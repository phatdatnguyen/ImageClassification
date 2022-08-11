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
    public partial class EdgesDetectionDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private Edges edges = new Edges();

        // Property
        public Edges Edges { get { return edges; } }

        // Constructor
        public EdgesDetectionDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            afterImage = edges.Apply(beforeImage);
            afterPictureBox.Image = afterImage;
        }

        // Method
        public string GetDescription()
        {
            return "";
        }
    }
}
