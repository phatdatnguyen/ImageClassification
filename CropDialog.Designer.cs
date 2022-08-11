namespace ImageClassification
{
    partial class CropDialog
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
            this.cropGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xNumericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.cropGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Controls.Add(this.previewTableLayoutPanel);
            this.previewGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.previewGroupBox.Location = new System.Drawing.Point(0, 78);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(496, 241);
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
            this.previewTableLayoutPanel.Size = new System.Drawing.Size(490, 222);
            this.previewTableLayoutPanel.TabIndex = 10;
            // 
            // beforePictureBox
            // 
            this.beforePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beforePictureBox.Location = new System.Drawing.Point(3, 35);
            this.beforePictureBox.Name = "beforePictureBox";
            this.beforePictureBox.Size = new System.Drawing.Size(239, 184);
            this.beforePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beforePictureBox.TabIndex = 9;
            this.beforePictureBox.TabStop = false;
            // 
            // afterPictureBox
            // 
            this.afterPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterPictureBox.Location = new System.Drawing.Point(248, 35);
            this.afterPictureBox.Name = "afterPictureBox";
            this.afterPictureBox.Size = new System.Drawing.Size(239, 184);
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
            // cropGroupBox
            // 
            this.cropGroupBox.Controls.Add(this.label1);
            this.cropGroupBox.Controls.Add(this.xLabel);
            this.cropGroupBox.Controls.Add(this.yNumericUpDown);
            this.cropGroupBox.Controls.Add(this.xNumericUpDown);
            this.cropGroupBox.Controls.Add(this.heightLabel);
            this.cropGroupBox.Controls.Add(this.widthLabel);
            this.cropGroupBox.Controls.Add(this.heightNumericUpDown);
            this.cropGroupBox.Controls.Add(this.widthNumericUpDown);
            this.cropGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cropGroupBox.Location = new System.Drawing.Point(0, 0);
            this.cropGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.cropGroupBox.Name = "cropGroupBox";
            this.cropGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.cropGroupBox.Size = new System.Drawing.Size(496, 78);
            this.cropGroupBox.TabIndex = 0;
            this.cropGroupBox.TabStop = false;
            this.cropGroupBox.Text = "Crop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(118, 22);
            this.xLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(12, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "x";
            // 
            // yNumericUpDown
            // 
            this.yNumericUpDown.Location = new System.Drawing.Point(298, 20);
            this.yNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.yNumericUpDown.Name = "yNumericUpDown";
            this.yNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.yNumericUpDown.TabIndex = 1;
            this.yNumericUpDown.ValueChanged += new System.EventHandler(this.cropSizeNumericUpDown_ValueChanged);
            // 
            // xNumericUpDown
            // 
            this.xNumericUpDown.Location = new System.Drawing.Point(134, 20);
            this.xNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.xNumericUpDown.Name = "xNumericUpDown";
            this.xNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.xNumericUpDown.TabIndex = 0;
            this.xNumericUpDown.ValueChanged += new System.EventHandler(this.cropSizeNumericUpDown_ValueChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(256, 46);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(95, 46);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width";
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(298, 44);
            this.heightNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.heightNumericUpDown.TabIndex = 3;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNumericUpDown.ValueChanged += new System.EventHandler(this.cropSizeNumericUpDown_ValueChanged);
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(134, 44);
            this.widthNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.widthNumericUpDown.TabIndex = 2;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNumericUpDown.ValueChanged += new System.EventHandler(this.cropSizeNumericUpDown_ValueChanged);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(370, 324);
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
            this.cancelButton.Location = new System.Drawing.Point(430, 324);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(56, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CropDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(496, 356);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.cropGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CropDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crop";
            this.previewGroupBox.ResumeLayout(false);
            this.previewTableLayoutPanel.ResumeLayout(false);
            this.previewTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).EndInit();
            this.cropGroupBox.ResumeLayout(false);
            this.cropGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).EndInit();
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
        private System.Windows.Forms.GroupBox cropGroupBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
    }
}