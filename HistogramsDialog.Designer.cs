namespace ImageClassification
{
    partial class HistogramsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistogramsDialog));
            this.histogramsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.redChannelGroupBox = new System.Windows.Forms.GroupBox();
            this.greenChannelGroupBox = new System.Windows.Forms.GroupBox();
            this.blueChannelGroupBox = new System.Windows.Forms.GroupBox();
            this.grayscaleGroupBox = new System.Windows.Forms.GroupBox();
            this.redChannelHistogramView = new Accord.Controls.HistogramView();
            this.greenChannelHistogramView = new Accord.Controls.HistogramView();
            this.blueChannelHistogramView = new Accord.Controls.HistogramView();
            this.grayscaleHistogramView = new Accord.Controls.HistogramView();
            this.histogramsTableLayoutPanel.SuspendLayout();
            this.redChannelGroupBox.SuspendLayout();
            this.greenChannelGroupBox.SuspendLayout();
            this.blueChannelGroupBox.SuspendLayout();
            this.grayscaleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // histogramsTableLayoutPanel
            // 
            this.histogramsTableLayoutPanel.ColumnCount = 2;
            this.histogramsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.histogramsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.histogramsTableLayoutPanel.Controls.Add(this.greenChannelGroupBox, 1, 0);
            this.histogramsTableLayoutPanel.Controls.Add(this.blueChannelGroupBox, 0, 1);
            this.histogramsTableLayoutPanel.Controls.Add(this.grayscaleGroupBox, 1, 1);
            this.histogramsTableLayoutPanel.Controls.Add(this.redChannelGroupBox, 0, 0);
            this.histogramsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogramsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.histogramsTableLayoutPanel.Name = "histogramsTableLayoutPanel";
            this.histogramsTableLayoutPanel.RowCount = 2;
            this.histogramsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.histogramsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.histogramsTableLayoutPanel.Size = new System.Drawing.Size(784, 561);
            this.histogramsTableLayoutPanel.TabIndex = 0;
            // 
            // redChannelGroupBox
            // 
            this.redChannelGroupBox.Controls.Add(this.redChannelHistogramView);
            this.redChannelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redChannelGroupBox.Location = new System.Drawing.Point(3, 3);
            this.redChannelGroupBox.Name = "redChannelGroupBox";
            this.redChannelGroupBox.Size = new System.Drawing.Size(386, 274);
            this.redChannelGroupBox.TabIndex = 0;
            this.redChannelGroupBox.TabStop = false;
            this.redChannelGroupBox.Text = "Red channel";
            // 
            // greenChannelGroupBox
            // 
            this.greenChannelGroupBox.Controls.Add(this.greenChannelHistogramView);
            this.greenChannelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenChannelGroupBox.Location = new System.Drawing.Point(395, 3);
            this.greenChannelGroupBox.Name = "greenChannelGroupBox";
            this.greenChannelGroupBox.Size = new System.Drawing.Size(386, 274);
            this.greenChannelGroupBox.TabIndex = 1;
            this.greenChannelGroupBox.TabStop = false;
            this.greenChannelGroupBox.Text = "Green channel";
            // 
            // blueChannelGroupBox
            // 
            this.blueChannelGroupBox.Controls.Add(this.blueChannelHistogramView);
            this.blueChannelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueChannelGroupBox.Location = new System.Drawing.Point(3, 283);
            this.blueChannelGroupBox.Name = "blueChannelGroupBox";
            this.blueChannelGroupBox.Size = new System.Drawing.Size(386, 275);
            this.blueChannelGroupBox.TabIndex = 1;
            this.blueChannelGroupBox.TabStop = false;
            this.blueChannelGroupBox.Text = "Blue channel";
            // 
            // grayscaleGroupBox
            // 
            this.grayscaleGroupBox.Controls.Add(this.grayscaleHistogramView);
            this.grayscaleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayscaleGroupBox.Location = new System.Drawing.Point(395, 283);
            this.grayscaleGroupBox.Name = "grayscaleGroupBox";
            this.grayscaleGroupBox.Size = new System.Drawing.Size(386, 275);
            this.grayscaleGroupBox.TabIndex = 1;
            this.grayscaleGroupBox.TabStop = false;
            this.grayscaleGroupBox.Text = "Grayscale";
            // 
            // redChannelHistogramView
            // 
            this.redChannelHistogramView.BinWidth = null;
            this.redChannelHistogramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redChannelHistogramView.Histogram = ((Accord.Statistics.Visualizations.Histogram)(resources.GetObject("redChannelHistogramView.Histogram")));
            this.redChannelHistogramView.Location = new System.Drawing.Point(3, 16);
            this.redChannelHistogramView.Name = "redChannelHistogramView";
            this.redChannelHistogramView.NumberOfBins = null;
            this.redChannelHistogramView.Size = new System.Drawing.Size(380, 255);
            this.redChannelHistogramView.TabIndex = 0;
            // 
            // greenChannelHistogramView
            // 
            this.greenChannelHistogramView.BinWidth = null;
            this.greenChannelHistogramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenChannelHistogramView.Histogram = ((Accord.Statistics.Visualizations.Histogram)(resources.GetObject("greenChannelHistogramView.Histogram")));
            this.greenChannelHistogramView.Location = new System.Drawing.Point(3, 16);
            this.greenChannelHistogramView.Name = "greenChannelHistogramView";
            this.greenChannelHistogramView.NumberOfBins = null;
            this.greenChannelHistogramView.Size = new System.Drawing.Size(380, 255);
            this.greenChannelHistogramView.TabIndex = 1;
            // 
            // blueChannelHistogramView
            // 
            this.blueChannelHistogramView.BinWidth = null;
            this.blueChannelHistogramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueChannelHistogramView.Histogram = ((Accord.Statistics.Visualizations.Histogram)(resources.GetObject("blueChannelHistogramView.Histogram")));
            this.blueChannelHistogramView.Location = new System.Drawing.Point(3, 16);
            this.blueChannelHistogramView.Name = "blueChannelHistogramView";
            this.blueChannelHistogramView.NumberOfBins = null;
            this.blueChannelHistogramView.Size = new System.Drawing.Size(380, 256);
            this.blueChannelHistogramView.TabIndex = 1;
            // 
            // grayscaleHistogramView
            // 
            this.grayscaleHistogramView.BinWidth = null;
            this.grayscaleHistogramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayscaleHistogramView.Histogram = ((Accord.Statistics.Visualizations.Histogram)(resources.GetObject("grayscaleHistogramView.Histogram")));
            this.grayscaleHistogramView.Location = new System.Drawing.Point(3, 16);
            this.grayscaleHistogramView.Name = "grayscaleHistogramView";
            this.grayscaleHistogramView.NumberOfBins = null;
            this.grayscaleHistogramView.Size = new System.Drawing.Size(380, 256);
            this.grayscaleHistogramView.TabIndex = 1;
            // 
            // HistogramsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.histogramsTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "HistogramsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Histograms";
            this.histogramsTableLayoutPanel.ResumeLayout(false);
            this.redChannelGroupBox.ResumeLayout(false);
            this.greenChannelGroupBox.ResumeLayout(false);
            this.blueChannelGroupBox.ResumeLayout(false);
            this.grayscaleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel histogramsTableLayoutPanel;
        private System.Windows.Forms.GroupBox greenChannelGroupBox;
        private Accord.Controls.HistogramView greenChannelHistogramView;
        private System.Windows.Forms.GroupBox blueChannelGroupBox;
        private Accord.Controls.HistogramView blueChannelHistogramView;
        private System.Windows.Forms.GroupBox grayscaleGroupBox;
        private Accord.Controls.HistogramView grayscaleHistogramView;
        private System.Windows.Forms.GroupBox redChannelGroupBox;
        private Accord.Controls.HistogramView redChannelHistogramView;
    }
}