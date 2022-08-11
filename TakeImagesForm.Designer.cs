namespace ImageClassification
{
    partial class TakeImagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.videoDeviceLabel = new System.Windows.Forms.Label();
            this.videoDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.numberOfImagesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfImagesLabel = new System.Windows.Forms.Label();
            this.imagingSpeedLabel = new System.Windows.Forms.Label();
            this.imagingSpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.imagingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfImagesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagingSpeedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // videoDeviceLabel
            // 
            this.videoDeviceLabel.AutoSize = true;
            this.videoDeviceLabel.Location = new System.Drawing.Point(12, 15);
            this.videoDeviceLabel.Name = "videoDeviceLabel";
            this.videoDeviceLabel.Size = new System.Drawing.Size(69, 13);
            this.videoDeviceLabel.TabIndex = 0;
            this.videoDeviceLabel.Text = "Video device";
            // 
            // videoDeviceComboBox
            // 
            this.videoDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoDeviceComboBox.FormattingEnabled = true;
            this.videoDeviceComboBox.Location = new System.Drawing.Point(87, 12);
            this.videoDeviceComboBox.Name = "videoDeviceComboBox";
            this.videoDeviceComboBox.Size = new System.Drawing.Size(200, 21);
            this.videoDeviceComboBox.TabIndex = 0;
            this.videoDeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.videoDeviceComboBox_SelectedIndexChanged);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(0, 39);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(384, 318);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(246, 386);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(312, 386);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // numberOfImagesNumericUpDown
            // 
            this.numberOfImagesNumericUpDown.Location = new System.Drawing.Point(180, 389);
            this.numberOfImagesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfImagesNumericUpDown.Name = "numberOfImagesNumericUpDown";
            this.numberOfImagesNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.numberOfImagesNumericUpDown.TabIndex = 2;
            this.numberOfImagesNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numberOfImagesLabel
            // 
            this.numberOfImagesLabel.AutoSize = true;
            this.numberOfImagesLabel.Location = new System.Drawing.Point(40, 391);
            this.numberOfImagesLabel.Name = "numberOfImagesLabel";
            this.numberOfImagesLabel.Size = new System.Drawing.Size(134, 13);
            this.numberOfImagesLabel.TabIndex = 0;
            this.numberOfImagesLabel.Text = "Number of images (images)";
            // 
            // imagingSpeedLabel
            // 
            this.imagingSpeedLabel.AutoSize = true;
            this.imagingSpeedLabel.Location = new System.Drawing.Point(51, 365);
            this.imagingSpeedLabel.Name = "imagingSpeedLabel";
            this.imagingSpeedLabel.Size = new System.Drawing.Size(123, 13);
            this.imagingSpeedLabel.TabIndex = 0;
            this.imagingSpeedLabel.Text = "Imaging speed (image/s)";
            // 
            // imagingSpeedNumericUpDown
            // 
            this.imagingSpeedNumericUpDown.Location = new System.Drawing.Point(180, 363);
            this.imagingSpeedNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.imagingSpeedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imagingSpeedNumericUpDown.Name = "imagingSpeedNumericUpDown";
            this.imagingSpeedNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.imagingSpeedNumericUpDown.TabIndex = 1;
            this.imagingSpeedNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // imagingTimer
            // 
            this.imagingTimer.Tick += new System.EventHandler(this.imagingTimer_Tick);
            // 
            // TakeImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.Controls.Add(this.imagingSpeedLabel);
            this.Controls.Add(this.imagingSpeedNumericUpDown);
            this.Controls.Add(this.numberOfImagesLabel);
            this.Controls.Add(this.numberOfImagesNumericUpDown);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.videoDeviceComboBox);
            this.Controls.Add(this.videoDeviceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TakeImagesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Images";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TakeImagesForm_FormClosing);
            this.Load += new System.EventHandler(this.TakeImagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfImagesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagingSpeedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label videoDeviceLabel;
        private System.Windows.Forms.ComboBox videoDeviceComboBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown numberOfImagesNumericUpDown;
        private System.Windows.Forms.Label numberOfImagesLabel;
        private System.Windows.Forms.Label imagingSpeedLabel;
        private System.Windows.Forms.NumericUpDown imagingSpeedNumericUpDown;
        private System.Windows.Forms.Timer imagingTimer;
    }
}