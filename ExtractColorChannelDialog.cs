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
    public partial class ExtractColorChannelDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private ExtractChannel extractChannel = null;

        private bool formLoaded = false;

        // Property
        public ExtractChannel ExtractChannel { get { return extractChannel; } }

        // Constructor
        public ExtractColorChannelDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            extractChannel = new ExtractChannel(RGB.R);
            afterImage = extractChannel.Apply(beforeImage);
            afterPictureBox.Image = afterImage;

            formLoaded = true;
        }

        // Methods
        private void colorChannelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            if (redRadioButton.Checked)
                extractChannel = new ExtractChannel(RGB.R);
            else if (greenRadioButton.Checked)
                extractChannel = new ExtractChannel(RGB.G);
            else
                extractChannel = new ExtractChannel(RGB.B);

            afterImage = extractChannel.Apply(beforeImage);
            afterPictureBox.Image = afterImage;
        }

        public string GetDescription()
        {
            if (redRadioButton.Checked)
                return "Channel: red";
            else if (greenRadioButton.Checked)
                return "Channel: green";
            else
                return "Channel: blue";
        }
    }
}
