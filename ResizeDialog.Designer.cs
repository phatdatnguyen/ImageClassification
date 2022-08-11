namespace ImageClassification
{
    partial class ResizeDialog
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
            this.beforePictureBox = new System.Windows.Forms.PictureBox();
            this.afterPictureBox = new System.Windows.Forms.PictureBox();
            this.beforeLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.newSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.previewGroupBox.SuspendLayout();
            this.previewTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).BeginInit();
            this.newSizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Controls.Add(this.previewTableLayoutPanel);
            this.previewGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.previewGroupBox.Location = new System.Drawing.Point(0, 51);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(496, 237);
            this.previewGroupBox.TabIndex = 1;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // previewTableLayoutPanel
            // 
            this.previewTableLayoutPanel.ColumnCount = 2;
            this.previewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.previewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.previewTableLayoutPanel.Controls.Add(this.beforePictureBox, 0, 1);
            this.previewTableLayoutPanel.Controls.Add(this.afterPictureBox, 1, 1);
            this.previewTableLayoutPanel.Controls.Add(this.beforeLabel, 0, 0);
            this.previewTableLayoutPanel.Controls.Add(this.afterLabel, 1, 0);
            this.previewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.previewTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.previewTableLayoutPanel.Name = "previewTableLayoutPanel";
            this.previewTableLayoutPanel.RowCount = 2;
            this.previewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.previewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.previewTableLayoutPanel.Size = new System.Drawing.Size(490, 218);
            this.previewTableLayoutPanel.TabIndex = 10;
            // 
            // beforePictureBox
            // 
            this.beforePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beforePictureBox.Location = new System.Drawing.Point(3, 35);
            this.beforePictureBox.Name = "beforePictureBox";
            this.beforePictureBox.Size = new System.Drawing.Size(239, 180);
            this.beforePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beforePictureBox.TabIndex = 9;
            this.beforePictureBox.TabStop = false;
            // 
            // afterPictureBox
            // 
            this.afterPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterPictureBox.Location = new System.Drawing.Point(248, 35);
            this.afterPictureBox.Name = "afterPictureBox";
            this.afterPictureBox.Size = new System.Drawing.Size(239, 180);
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
            // newSizeGroupBox
            // 
            this.newSizeGroupBox.Controls.Add(this.heightLabel);
            this.newSizeGroupBox.Controls.Add(this.widthLabel);
            this.newSizeGroupBox.Controls.Add(this.heightNumericUpDown);
            this.newSizeGroupBox.Controls.Add(this.widthNumericUpDown);
            this.newSizeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.newSizeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.newSizeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.newSizeGroupBox.Name = "newSizeGroupBox";
            this.newSizeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.newSizeGroupBox.Size = new System.Drawing.Size(496, 51);
            this.newSizeGroupBox.TabIndex = 0;
            this.newSizeGroupBox.TabStop = false;
            this.newSizeGroupBox.Text = "New size";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(252, 19);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(91, 19);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width";
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(294, 17);
            this.heightNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.heightNumericUpDown.TabIndex = 1;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNumericUpDown.ValueChanged += new System.EventHandler(this.imageSizeNumericUpDown_ValueChanged);
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(130, 17);
            this.widthNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.widthNumericUpDown.TabIndex = 0;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumericUpDown.ValueChanged += new System.EventHandler(this.imageSizeNumericUpDown_ValueChanged);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(368, 293);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(429, 293);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ResizeDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(496, 327);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.newSizeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize";
            this.previewGroupBox.ResumeLayout(false);
            this.previewTableLayoutPanel.ResumeLayout(false);
            this.previewTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).EndInit();
            this.newSizeGroupBox.ResumeLayout(false);
            this.newSizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.TableLayoutPanel previewTableLayoutPanel;
        private System.Windows.Forms.PictureBox beforePictureBox;
        private System.Windows.Forms.PictureBox afterPictureBox;
        private System.Windows.Forms.Label beforeLabel;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.GroupBox newSizeGroupBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}