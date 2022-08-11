namespace ImageClassification
{
    partial class ChooseProcessingStepDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.ProcessingStepComboBox = new System.Windows.Forms.ComboBox();
            this.processingStepLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(196, 45);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(113, 45);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // ProcessingStepComboBox
            // 
            this.ProcessingStepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcessingStepComboBox.FormattingEnabled = true;
            this.ProcessingStepComboBox.Items.AddRange(new object[] {
            "Crop",
            "Resize",
            "Extract color channel",
            "Convert to grayscale",
            "Brightness",
            "Contrast",
            "Box blur",
            "Gaussian blur",
            "Sharpen",
            "Gaussian sharpen",
            "Edges detection"});
            this.ProcessingStepComboBox.Location = new System.Drawing.Point(103, 13);
            this.ProcessingStepComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessingStepComboBox.Name = "ProcessingStepComboBox";
            this.ProcessingStepComboBox.Size = new System.Drawing.Size(168, 21);
            this.ProcessingStepComboBox.TabIndex = 3;
            // 
            // processingStepLabel
            // 
            this.processingStepLabel.AutoSize = true;
            this.processingStepLabel.Location = new System.Drawing.Point(13, 16);
            this.processingStepLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processingStepLabel.Name = "processingStepLabel";
            this.processingStepLabel.Size = new System.Drawing.Size(82, 13);
            this.processingStepLabel.TabIndex = 4;
            this.processingStepLabel.Text = "Processing step";
            // 
            // ChooseProcessingStepDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ProcessingStepComboBox);
            this.Controls.Add(this.processingStepLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseProcessingStepDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Processing Step";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        public System.Windows.Forms.ComboBox ProcessingStepComboBox;
        private System.Windows.Forms.Label processingStepLabel;
    }
}