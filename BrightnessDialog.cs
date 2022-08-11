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
    public partial class BrightnessDialog : Form
    {
        // Fields
        private Bitmap beforeImage = null;
        private Bitmap afterImage = null;
        private BrightnessCorrection brightnessCorrection = null;

        private bool formLoaded = false;

        // Property
        public BrightnessCorrection BrightnessCorrection { get { return brightnessCorrection; } }

        // Constructor
        public BrightnessDialog(Bitmap image)
        {
            InitializeComponent();

            beforeImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);
            beforePictureBox.Image = image;

            brightnessCorrection = new BrightnessCorrection(0);
            afterImage = brightnessCorrection.Apply(beforeImage);
            afterPictureBox.Image = afterImage;

            formLoaded = true;
        }

        // Methods
        public string GetDescription()
        {
            return "adjust amount = " + adjustAmountNumericUpDown.Value.ToString();
        }

        private void adjustAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!formLoaded)
                return;

            brightnessCorrection = new BrightnessCorrection((int)adjustAmountNumericUpDown.Value);
            afterImage = brightnessCorrection.Apply(beforeImage);
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
