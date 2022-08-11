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
    public partial class HistogramsDialog : Form
    {
        // Constructor
        public HistogramsDialog(Bitmap image)
        {
            InitializeComponent();

            ImageStatistics imageStatistics = new ImageStatistics(image);
            redChannelHistogramView.Histogram = imageStatistics.Red;
            greenChannelHistogramView.Histogram = imageStatistics.Green;
            blueChannelHistogramView.Histogram = imageStatistics.Blue;

            Grayscale grayscale = new Grayscale(0.2989, 0.5870, 0.1141);
            Bitmap grayscaleImage = grayscale.Apply(image);
            ImageStatistics grayscaleImageStatistics = new ImageStatistics(image);
            grayscaleHistogramView.Histogram = grayscaleImageStatistics.Red;
        }
    }
}
