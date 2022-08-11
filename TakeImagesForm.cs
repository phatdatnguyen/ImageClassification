using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace ImageClassification
{
    public partial class TakeImagesForm : Form
    {
        // Fields
        FilterInfoCollection filterInfoCollection = null;
        VideoCaptureDevice VideoCaptureDevice = null;
        Bitmap currentFrame = null;
        int imageIndex = 0;

        // Event
        public delegate void ImageTakenEventHandler(ImageTakenEventArgs e);
        public event ImageTakenEventHandler ImageTaken;

        // Constructor
        public TakeImagesForm()
        {
            InitializeComponent();
        }

        // Methods
        private void TakeImagesForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (filterInfoCollection.Count == 0)
                return;
            
            foreach (FilterInfo filterInfo in filterInfoCollection)
                videoDeviceComboBox.Items.Add(filterInfo.Name);

            videoDeviceComboBox.SelectedIndex = 0;

            VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[videoDeviceComboBox.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();

            startButton.Enabled = true;
        }

        private void videoDeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDeviceComboBox.SelectedIndex == -1)
                return;

            if (VideoCaptureDevice != null && VideoCaptureDevice.IsRunning)
                VideoCaptureDevice.Stop();

            VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[videoDeviceComboBox.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            currentFrame = (Bitmap)eventArgs.Frame.Clone();
            imagePictureBox.Image = currentFrame;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            imagingTimer.Interval = (int)(100f / (float)imagingSpeedNumericUpDown.Value);

            imageIndex = 0;
            imagingTimer.Start();

            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            imagingTimer.Stop();

            imageIndex = 0;
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void imagingTimer_Tick(object sender, EventArgs e)
        {
            if (imageIndex >= (int)numberOfImagesNumericUpDown.Value)
            {
                imagingTimer.Stop();

                startButton.Enabled = true;
                stopButton.Enabled = false;
                return;
            }    

            ImageTaken(new ImageTakenEventArgs() { Image = currentFrame });
            imageIndex++;
        }

        private void TakeImagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoCaptureDevice != null && VideoCaptureDevice.IsRunning)
                VideoCaptureDevice.Stop();
            imagingTimer.Stop();
        }
    }
}
