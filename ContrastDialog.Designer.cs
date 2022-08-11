namespace ImageClassification
{
    partial class ContrastDialog
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
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.previewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.afterShowHistogramsButton = new System.Windows.Forms.Button();
            this.beforePictureBox = new System.Windows.Forms.PictureBox();
            this.afterPictureBox = new System.Windows.Forms.PictureBox();
            this.beforeLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.beforeShowHistogramsButton = new System.Windows.Forms.Button();
            this.contrastGroupBox = new System.Windows.Forms.GroupBox();
            this.upperLimitLabel = new System.Windows.Forms.Label();
            this.upperLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowerLimitLabel = new System.Windows.Forms.Label();
            this.lowerLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyToGroupBox = new System.Windows.Forms.GroupBox();
            this.redChannelRadioButton = new System.Windows.Forms.RadioButton();
            this.blueChannelRadioButton = new System.Windows.Forms.RadioButton();
            this.greenChannelRadioButton = new System.Windows.Forms.RadioButton();
            this.allChannelsRadioButton = new System.Windows.Forms.RadioButton();
            this.previewGroupBox.SuspendLayout();
            this.previewTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).BeginInit();
            this.contrastGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitNumericUpDown)).BeginInit();
            this.applyToGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Controls.Add(this.previewTableLayoutPanel);
            this.previewGroupBox.Location = new System.Drawing.Point(0, 101);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(496, 261);
            this.previewGroupBox.TabIndex = 2;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // previewTableLayoutPanel
            // 
            this.previewTableLayoutPanel.ColumnCount = 2;
            this.previewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.previewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.previewTableLayoutPanel.Controls.Add(this.afterShowHistogramsButton, 1, 2);
            this.previewTableLayoutPanel.Controls.Add(this.beforePictureBox, 0, 1);
            this.previewTableLayoutPanel.Controls.Add(this.afterPictureBox, 1, 1);
            this.previewTableLayoutPanel.Controls.Add(this.beforeLabel, 0, 0);
            this.previewTableLayoutPanel.Controls.Add(this.afterLabel, 1, 0);
            this.previewTableLayoutPanel.Controls.Add(this.beforeShowHistogramsButton, 0, 2);
            this.previewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.previewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.previewTableLayoutPanel.Name = "previewTableLayoutPanel";
            this.previewTableLayoutPanel.RowCount = 3;
            this.previewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.previewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.previewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.previewTableLayoutPanel.Size = new System.Drawing.Size(490, 242);
            this.previewTableLayoutPanel.TabIndex = 10;
            // 
            // afterShowHistogramsButton
            // 
            this.afterShowHistogramsButton.Location = new System.Drawing.Point(248, 213);
            this.afterShowHistogramsButton.Name = "afterShowHistogramsButton";
            this.afterShowHistogramsButton.Size = new System.Drawing.Size(120, 23);
            this.afterShowHistogramsButton.TabIndex = 1;
            this.afterShowHistogramsButton.Text = "Show histograms...";
            this.afterShowHistogramsButton.UseVisualStyleBackColor = true;
            this.afterShowHistogramsButton.Click += new System.EventHandler(this.afterShowHistogramsButton_Click);
            // 
            // beforePictureBox
            // 
            this.beforePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beforePictureBox.Location = new System.Drawing.Point(3, 35);
            this.beforePictureBox.Name = "beforePictureBox";
            this.beforePictureBox.Size = new System.Drawing.Size(239, 172);
            this.beforePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beforePictureBox.TabIndex = 9;
            this.beforePictureBox.TabStop = false;
            // 
            // afterPictureBox
            // 
            this.afterPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterPictureBox.Location = new System.Drawing.Point(248, 35);
            this.afterPictureBox.Name = "afterPictureBox";
            this.afterPictureBox.Size = new System.Drawing.Size(239, 172);
            this.afterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.afterPictureBox.TabIndex = 10;
            this.afterPictureBox.TabStop = false;
            // 
            // beforeLabel
            // 
            this.beforeLabel.AutoSize = true;
            this.beforeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beforeLabel.Location = new System.Drawing.Point(2, 0);
            this.beforeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.beforeLabel.Name = "beforeLabel";
            this.beforeLabel.Size = new System.Drawing.Size(241, 32);
            this.beforeLabel.TabIndex = 0;
            this.beforeLabel.Text = "Before";
            this.beforeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterLabel.Location = new System.Drawing.Point(247, 0);
            this.afterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(241, 32);
            this.afterLabel.TabIndex = 1;
            this.afterLabel.Text = "After";
            this.afterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beforeShowHistogramsButton
            // 
            this.beforeShowHistogramsButton.Location = new System.Drawing.Point(3, 213);
            this.beforeShowHistogramsButton.Name = "beforeShowHistogramsButton";
            this.beforeShowHistogramsButton.Size = new System.Drawing.Size(120, 23);
            this.beforeShowHistogramsButton.TabIndex = 0;
            this.beforeShowHistogramsButton.Text = "Show histograms...";
            this.beforeShowHistogramsButton.UseVisualStyleBackColor = true;
            this.beforeShowHistogramsButton.Click += new System.EventHandler(this.beforeShowHistogramsButton_Click);
            // 
            // contrastGroupBox
            // 
            this.contrastGroupBox.Controls.Add(this.upperLimitLabel);
            this.contrastGroupBox.Controls.Add(this.upperLimitNumericUpDown);
            this.contrastGroupBox.Controls.Add(this.lowerLimitLabel);
            this.contrastGroupBox.Controls.Add(this.lowerLimitNumericUpDown);
            this.contrastGroupBox.Location = new System.Drawing.Point(0, 0);
            this.contrastGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.contrastGroupBox.Name = "contrastGroupBox";
            this.contrastGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.contrastGroupBox.Size = new System.Drawing.Size(185, 96);
            this.contrastGroupBox.TabIndex = 0;
            this.contrastGroupBox.TabStop = false;
            this.contrastGroupBox.Text = "Constrast";
            // 
            // upperLimitLabel
            // 
            this.upperLimitLabel.AutoSize = true;
            this.upperLimitLabel.Location = new System.Drawing.Point(19, 56);
            this.upperLimitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upperLimitLabel.Name = "upperLimitLabel";
            this.upperLimitLabel.Size = new System.Drawing.Size(56, 13);
            this.upperLimitLabel.TabIndex = 0;
            this.upperLimitLabel.Text = "Upper limit";
            // 
            // upperLimitNumericUpDown
            // 
            this.upperLimitNumericUpDown.Location = new System.Drawing.Point(79, 54);
            this.upperLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.upperLimitNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upperLimitNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upperLimitNumericUpDown.Name = "upperLimitNumericUpDown";
            this.upperLimitNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.upperLimitNumericUpDown.TabIndex = 1;
            this.upperLimitNumericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upperLimitNumericUpDown.ValueChanged += new System.EventHandler(this.limitNumericUpDown_ValueChanged);
            // 
            // lowerLimitLabel
            // 
            this.lowerLimitLabel.AutoSize = true;
            this.lowerLimitLabel.Location = new System.Drawing.Point(19, 32);
            this.lowerLimitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lowerLimitLabel.Name = "lowerLimitLabel";
            this.lowerLimitLabel.Size = new System.Drawing.Size(56, 13);
            this.lowerLimitLabel.TabIndex = 0;
            this.lowerLimitLabel.Text = "Lower limit";
            // 
            // lowerLimitNumericUpDown
            // 
            this.lowerLimitNumericUpDown.Location = new System.Drawing.Point(79, 30);
            this.lowerLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.lowerLimitNumericUpDown.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.lowerLimitNumericUpDown.Name = "lowerLimitNumericUpDown";
            this.lowerLimitNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.lowerLimitNumericUpDown.TabIndex = 0;
            this.lowerLimitNumericUpDown.ValueChanged += new System.EventHandler(this.limitNumericUpDown_ValueChanged);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(368, 367);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(429, 367);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyToGroupBox
            // 
            this.applyToGroupBox.Controls.Add(this.redChannelRadioButton);
            this.applyToGroupBox.Controls.Add(this.blueChannelRadioButton);
            this.applyToGroupBox.Controls.Add(this.greenChannelRadioButton);
            this.applyToGroupBox.Controls.Add(this.allChannelsRadioButton);
            this.applyToGroupBox.Location = new System.Drawing.Point(189, 0);
            this.applyToGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.applyToGroupBox.Name = "applyToGroupBox";
            this.applyToGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.applyToGroupBox.Size = new System.Drawing.Size(304, 96);
            this.applyToGroupBox.TabIndex = 1;
            this.applyToGroupBox.TabStop = false;
            this.applyToGroupBox.Text = "Apply to";
            // 
            // redChannelRadioButton
            // 
            this.redChannelRadioButton.AutoSize = true;
            this.redChannelRadioButton.Location = new System.Drawing.Point(12, 56);
            this.redChannelRadioButton.Name = "redChannelRadioButton";
            this.redChannelRadioButton.Size = new System.Drawing.Size(86, 17);
            this.redChannelRadioButton.TabIndex = 1;
            this.redChannelRadioButton.Text = "Red channel";
            this.redChannelRadioButton.UseVisualStyleBackColor = true;
            this.redChannelRadioButton.CheckedChanged += new System.EventHandler(this.applyToRadioButton_CheckedChanged);
            // 
            // blueChannelRadioButton
            // 
            this.blueChannelRadioButton.AutoSize = true;
            this.blueChannelRadioButton.Location = new System.Drawing.Point(205, 56);
            this.blueChannelRadioButton.Name = "blueChannelRadioButton";
            this.blueChannelRadioButton.Size = new System.Drawing.Size(87, 17);
            this.blueChannelRadioButton.TabIndex = 3;
            this.blueChannelRadioButton.Text = "Blue channel";
            this.blueChannelRadioButton.UseVisualStyleBackColor = true;
            this.blueChannelRadioButton.CheckedChanged += new System.EventHandler(this.applyToRadioButton_CheckedChanged);
            // 
            // greenChannelRadioButton
            // 
            this.greenChannelRadioButton.AutoSize = true;
            this.greenChannelRadioButton.Location = new System.Drawing.Point(104, 56);
            this.greenChannelRadioButton.Name = "greenChannelRadioButton";
            this.greenChannelRadioButton.Size = new System.Drawing.Size(95, 17);
            this.greenChannelRadioButton.TabIndex = 2;
            this.greenChannelRadioButton.Text = "Green channel";
            this.greenChannelRadioButton.UseVisualStyleBackColor = true;
            this.greenChannelRadioButton.CheckedChanged += new System.EventHandler(this.applyToRadioButton_CheckedChanged);
            // 
            // allChannelsRadioButton
            // 
            this.allChannelsRadioButton.AutoSize = true;
            this.allChannelsRadioButton.Checked = true;
            this.allChannelsRadioButton.Location = new System.Drawing.Point(12, 30);
            this.allChannelsRadioButton.Name = "allChannelsRadioButton";
            this.allChannelsRadioButton.Size = new System.Drawing.Size(82, 17);
            this.allChannelsRadioButton.TabIndex = 0;
            this.allChannelsRadioButton.TabStop = true;
            this.allChannelsRadioButton.Text = "All channels";
            this.allChannelsRadioButton.UseVisualStyleBackColor = true;
            this.allChannelsRadioButton.CheckedChanged += new System.EventHandler(this.applyToRadioButton_CheckedChanged);
            // 
            // ContrastDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(496, 401);
            this.Controls.Add(this.applyToGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.contrastGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContrastDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adjust Contrast";
            this.previewGroupBox.ResumeLayout(false);
            this.previewTableLayoutPanel.ResumeLayout(false);
            this.previewTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).EndInit();
            this.contrastGroupBox.ResumeLayout(false);
            this.contrastGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitNumericUpDown)).EndInit();
            this.applyToGroupBox.ResumeLayout(false);
            this.applyToGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.TableLayoutPanel previewTableLayoutPanel;
        private System.Windows.Forms.PictureBox beforePictureBox;
        private System.Windows.Forms.PictureBox afterPictureBox;
        private System.Windows.Forms.Label beforeLabel;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.GroupBox contrastGroupBox;
        private System.Windows.Forms.Label lowerLimitLabel;
        private System.Windows.Forms.NumericUpDown lowerLimitNumericUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button afterShowHistogramsButton;
        private System.Windows.Forms.Button beforeShowHistogramsButton;
        private System.Windows.Forms.GroupBox applyToGroupBox;
        private System.Windows.Forms.RadioButton redChannelRadioButton;
        private System.Windows.Forms.RadioButton blueChannelRadioButton;
        private System.Windows.Forms.RadioButton greenChannelRadioButton;
        private System.Windows.Forms.RadioButton allChannelsRadioButton;
        private System.Windows.Forms.Label upperLimitLabel;
        private System.Windows.Forms.NumericUpDown upperLimitNumericUpDown;
    }
}