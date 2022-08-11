namespace ImageClassification
{
    partial class MainForm
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
            this.mainTaskPanel = new System.Windows.Forms.Panel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chooseModelPanel = new System.Windows.Forms.Panel();
            this.chooseModelButton = new System.Windows.Forms.Button();
            this.modelLabel = new System.Windows.Forms.Label();
            this.imagesPanel = new System.Windows.Forms.Panel();
            this.imagesLabel = new System.Windows.Forms.Label();
            this.preprocessingPanel = new System.Windows.Forms.Panel();
            this.processButton = new System.Windows.Forms.Button();
            this.preprocessingLabel = new System.Windows.Forms.Label();
            this.processingStepsPanel = new System.Windows.Forms.Panel();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.imageComboBox = new System.Windows.Forms.ComboBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.processingPictureBox = new System.Windows.Forms.PictureBox();
            this.processingStepsGroupBox = new System.Windows.Forms.GroupBox();
            this.processingStepsListView = new System.Windows.Forms.ListView();
            this.ProcessingStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteStepButton = new System.Windows.Forms.Button();
            this.addStepButton = new System.Windows.Forms.Button();
            this.projectionPanel = new System.Windows.Forms.Panel();
            this.projectionLabel = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.imagesGroupBox = new System.Windows.Forms.GroupBox();
            this.trainingImagesListView = new System.Windows.Forms.ListView();
            this.Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trainingImagePictureBox = new System.Windows.Forms.PictureBox();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.takeImagesButton = new System.Windows.Forms.Button();
            this.classesGroupBox = new System.Windows.Forms.GroupBox();
            this.classesListView = new System.Windows.Forms.ListView();
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteClassButton = new System.Windows.Forms.Button();
            this.addClassButton = new System.Windows.Forms.Button();
            this.modelPanel = new System.Windows.Forms.Panel();
            this.trainingPanel = new System.Windows.Forms.Panel();
            this.trainButton = new System.Windows.Forms.Button();
            this.trainingLabel = new System.Windows.Forms.Label();
            this.trainPanel = new System.Windows.Forms.Panel();
            this.predictionPanel = new System.Windows.Forms.Panel();
            this.predictionGroupBox = new System.Windows.Forms.GroupBox();
            this.predictButton = new System.Windows.Forms.Button();
            this.predictionListView = new System.Windows.Forms.ListView();
            this.Image1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Class1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.predictionPictureBox = new System.Windows.Forms.PictureBox();
            this.predictionDeleteButton = new System.Windows.Forms.Button();
            this.predictionTakeImagesButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mainTaskPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.chooseModelPanel.SuspendLayout();
            this.imagesPanel.SuspendLayout();
            this.preprocessingPanel.SuspendLayout();
            this.processingStepsPanel.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processingPictureBox)).BeginInit();
            this.processingStepsGroupBox.SuspendLayout();
            this.projectionPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.imagesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingImagePictureBox)).BeginInit();
            this.classesGroupBox.SuspendLayout();
            this.trainingPanel.SuspendLayout();
            this.trainPanel.SuspendLayout();
            this.predictionPanel.SuspendLayout();
            this.predictionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predictionPictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTaskPanel
            // 
            this.mainTaskPanel.AutoScroll = true;
            this.mainTaskPanel.AutoSize = true;
            this.mainTaskPanel.Controls.Add(this.mainTableLayoutPanel);
            this.mainTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTaskPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTaskPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainTaskPanel.Name = "mainTaskPanel";
            this.mainTaskPanel.Size = new System.Drawing.Size(784, 515);
            this.mainTaskPanel.TabIndex = 3;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.AutoSize = true;
            this.mainTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.chooseModelPanel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.imagesPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.preprocessingPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.processingStepsPanel, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.projectionPanel, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.dataPanel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.modelPanel, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.trainingPanel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.trainPanel, 1, 3);
            this.mainTableLayoutPanel.Controls.Add(this.predictionPanel, 1, 4);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(767, 1078);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // chooseModelPanel
            // 
            this.chooseModelPanel.Controls.Add(this.chooseModelButton);
            this.chooseModelPanel.Controls.Add(this.modelLabel);
            this.chooseModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseModelPanel.Location = new System.Drawing.Point(7, 513);
            this.chooseModelPanel.Margin = new System.Windows.Forms.Padding(4);
            this.chooseModelPanel.Name = "chooseModelPanel";
            this.chooseModelPanel.Size = new System.Drawing.Size(162, 242);
            this.chooseModelPanel.TabIndex = 4;
            // 
            // chooseModelButton
            // 
            this.chooseModelButton.Enabled = false;
            this.chooseModelButton.Location = new System.Drawing.Point(21, 113);
            this.chooseModelButton.Margin = new System.Windows.Forms.Padding(4);
            this.chooseModelButton.Name = "chooseModelButton";
            this.chooseModelButton.Size = new System.Drawing.Size(120, 23);
            this.chooseModelButton.TabIndex = 0;
            this.chooseModelButton.Text = "Choose model...";
            this.chooseModelButton.UseVisualStyleBackColor = true;
            this.chooseModelButton.Click += new System.EventHandler(this.chooseModelButton_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(12, 11);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(57, 20);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "Model";
            // 
            // imagesPanel
            // 
            this.imagesPanel.Controls.Add(this.imagesLabel);
            this.imagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesPanel.Location = new System.Drawing.Point(7, 7);
            this.imagesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.imagesPanel.Name = "imagesPanel";
            this.imagesPanel.Size = new System.Drawing.Size(162, 242);
            this.imagesPanel.TabIndex = 0;
            // 
            // imagesLabel
            // 
            this.imagesLabel.AutoSize = true;
            this.imagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesLabel.Location = new System.Drawing.Point(12, 7);
            this.imagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imagesLabel.Name = "imagesLabel";
            this.imagesLabel.Size = new System.Drawing.Size(68, 20);
            this.imagesLabel.TabIndex = 0;
            this.imagesLabel.Text = "Images";
            // 
            // preprocessingPanel
            // 
            this.preprocessingPanel.Controls.Add(this.processButton);
            this.preprocessingPanel.Controls.Add(this.preprocessingLabel);
            this.preprocessingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preprocessingPanel.Location = new System.Drawing.Point(7, 260);
            this.preprocessingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.preprocessingPanel.Name = "preprocessingPanel";
            this.preprocessingPanel.Size = new System.Drawing.Size(162, 242);
            this.preprocessingPanel.TabIndex = 2;
            // 
            // processButton
            // 
            this.processButton.Enabled = false;
            this.processButton.Location = new System.Drawing.Point(21, 125);
            this.processButton.Margin = new System.Windows.Forms.Padding(4);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(120, 23);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "Process images";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // preprocessingLabel
            // 
            this.preprocessingLabel.AutoSize = true;
            this.preprocessingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preprocessingLabel.Location = new System.Drawing.Point(12, 11);
            this.preprocessingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preprocessingLabel.Name = "preprocessingLabel";
            this.preprocessingLabel.Size = new System.Drawing.Size(123, 20);
            this.preprocessingLabel.TabIndex = 0;
            this.preprocessingLabel.Text = "Preprocessing";
            // 
            // processingStepsPanel
            // 
            this.processingStepsPanel.Controls.Add(this.previewGroupBox);
            this.processingStepsPanel.Controls.Add(this.processingStepsGroupBox);
            this.processingStepsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processingStepsPanel.Location = new System.Drawing.Point(180, 260);
            this.processingStepsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.processingStepsPanel.Name = "processingStepsPanel";
            this.processingStepsPanel.Size = new System.Drawing.Size(580, 242);
            this.processingStepsPanel.TabIndex = 3;
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Controls.Add(this.imageComboBox);
            this.previewGroupBox.Controls.Add(this.classComboBox);
            this.previewGroupBox.Controls.Add(this.processingPictureBox);
            this.previewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewGroupBox.Location = new System.Drawing.Point(312, 0);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(268, 242);
            this.previewGroupBox.TabIndex = 1;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // imageComboBox
            // 
            this.imageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageComboBox.Enabled = false;
            this.imageComboBox.FormattingEnabled = true;
            this.imageComboBox.Location = new System.Drawing.Point(133, 20);
            this.imageComboBox.Name = "imageComboBox";
            this.imageComboBox.Size = new System.Drawing.Size(121, 21);
            this.imageComboBox.TabIndex = 1;
            this.imageComboBox.SelectedIndexChanged += new System.EventHandler(this.imageComboBox_SelectedIndexChanged);
            // 
            // classComboBox
            // 
            this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComboBox.Enabled = false;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(6, 20);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 21);
            this.classComboBox.TabIndex = 0;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // processingPictureBox
            // 
            this.processingPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.processingPictureBox.Location = new System.Drawing.Point(3, 46);
            this.processingPictureBox.Name = "processingPictureBox";
            this.processingPictureBox.Size = new System.Drawing.Size(262, 193);
            this.processingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processingPictureBox.TabIndex = 9;
            this.processingPictureBox.TabStop = false;
            // 
            // processingStepsGroupBox
            // 
            this.processingStepsGroupBox.Controls.Add(this.processingStepsListView);
            this.processingStepsGroupBox.Controls.Add(this.deleteStepButton);
            this.processingStepsGroupBox.Controls.Add(this.addStepButton);
            this.processingStepsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.processingStepsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.processingStepsGroupBox.Name = "processingStepsGroupBox";
            this.processingStepsGroupBox.Size = new System.Drawing.Size(312, 242);
            this.processingStepsGroupBox.TabIndex = 0;
            this.processingStepsGroupBox.TabStop = false;
            this.processingStepsGroupBox.Text = "Processing steps";
            // 
            // processingStepsListView
            // 
            this.processingStepsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessingStep,
            this.Description});
            this.processingStepsListView.FullRowSelect = true;
            this.processingStepsListView.HideSelection = false;
            this.processingStepsListView.Location = new System.Drawing.Point(6, 46);
            this.processingStepsListView.Margin = new System.Windows.Forms.Padding(2);
            this.processingStepsListView.Name = "processingStepsListView";
            this.processingStepsListView.Size = new System.Drawing.Size(301, 196);
            this.processingStepsListView.TabIndex = 2;
            this.processingStepsListView.UseCompatibleStateImageBehavior = false;
            this.processingStepsListView.View = System.Windows.Forms.View.Details;
            this.processingStepsListView.SelectedIndexChanged += new System.EventHandler(this.processingStepListView_SelectedIndexChanged);
            this.processingStepsListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processingStepListView_KeyUp);
            this.processingStepsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.processingStepListView_MouseDoubleClick);
            // 
            // ProcessingStep
            // 
            this.ProcessingStep.Text = "Processing step";
            this.ProcessingStep.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 160;
            // 
            // deleteStepButton
            // 
            this.deleteStepButton.Enabled = false;
            this.deleteStepButton.Location = new System.Drawing.Point(87, 18);
            this.deleteStepButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteStepButton.Name = "deleteStepButton";
            this.deleteStepButton.Size = new System.Drawing.Size(60, 23);
            this.deleteStepButton.TabIndex = 1;
            this.deleteStepButton.Text = "Delete";
            this.deleteStepButton.UseVisualStyleBackColor = true;
            this.deleteStepButton.Click += new System.EventHandler(this.deleteStepButton_Click);
            // 
            // addStepButton
            // 
            this.addStepButton.Enabled = false;
            this.addStepButton.Location = new System.Drawing.Point(6, 18);
            this.addStepButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStepButton.Name = "addStepButton";
            this.addStepButton.Size = new System.Drawing.Size(75, 23);
            this.addStepButton.TabIndex = 0;
            this.addStepButton.Text = "Add step...";
            this.addStepButton.UseVisualStyleBackColor = true;
            this.addStepButton.Click += new System.EventHandler(this.addStepButton_Click);
            // 
            // projectionPanel
            // 
            this.projectionPanel.Controls.Add(this.projectionLabel);
            this.projectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectionPanel.Location = new System.Drawing.Point(7, 829);
            this.projectionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.projectionPanel.Name = "projectionPanel";
            this.projectionPanel.Size = new System.Drawing.Size(162, 242);
            this.projectionPanel.TabIndex = 8;
            // 
            // projectionLabel
            // 
            this.projectionLabel.AutoSize = true;
            this.projectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectionLabel.Location = new System.Drawing.Point(12, 10);
            this.projectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectionLabel.Name = "projectionLabel";
            this.projectionLabel.Size = new System.Drawing.Size(136, 20);
            this.projectionLabel.TabIndex = 0;
            this.projectionLabel.Text = "Make prediction";
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.imagesGroupBox);
            this.dataPanel.Controls.Add(this.classesGroupBox);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(179, 5);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(582, 246);
            this.dataPanel.TabIndex = 1;
            // 
            // imagesGroupBox
            // 
            this.imagesGroupBox.Controls.Add(this.trainingImagesListView);
            this.imagesGroupBox.Controls.Add(this.trainingImagePictureBox);
            this.imagesGroupBox.Controls.Add(this.deleteImageButton);
            this.imagesGroupBox.Controls.Add(this.takeImagesButton);
            this.imagesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesGroupBox.Location = new System.Drawing.Point(140, 0);
            this.imagesGroupBox.Name = "imagesGroupBox";
            this.imagesGroupBox.Size = new System.Drawing.Size(442, 246);
            this.imagesGroupBox.TabIndex = 1;
            this.imagesGroupBox.TabStop = false;
            this.imagesGroupBox.Text = "Images";
            // 
            // trainingImagesListView
            // 
            this.trainingImagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Image});
            this.trainingImagesListView.FullRowSelect = true;
            this.trainingImagesListView.HideSelection = false;
            this.trainingImagesListView.Location = new System.Drawing.Point(6, 46);
            this.trainingImagesListView.Margin = new System.Windows.Forms.Padding(2);
            this.trainingImagesListView.Name = "trainingImagesListView";
            this.trainingImagesListView.Size = new System.Drawing.Size(167, 196);
            this.trainingImagesListView.TabIndex = 2;
            this.trainingImagesListView.UseCompatibleStateImageBehavior = false;
            this.trainingImagesListView.View = System.Windows.Forms.View.Details;
            this.trainingImagesListView.SelectedIndexChanged += new System.EventHandler(this.trainingImagesListView_SelectedIndexChanged);
            this.trainingImagesListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trainingImagesListBox_KeyUp);
            // 
            // Image
            // 
            this.Image.Text = "Image";
            this.Image.Width = 130;
            // 
            // trainingImagePictureBox
            // 
            this.trainingImagePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.trainingImagePictureBox.Location = new System.Drawing.Point(179, 16);
            this.trainingImagePictureBox.Name = "trainingImagePictureBox";
            this.trainingImagePictureBox.Size = new System.Drawing.Size(260, 227);
            this.trainingImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trainingImagePictureBox.TabIndex = 8;
            this.trainingImagePictureBox.TabStop = false;
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.Enabled = false;
            this.deleteImageButton.Location = new System.Drawing.Point(112, 18);
            this.deleteImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(60, 23);
            this.deleteImageButton.TabIndex = 1;
            this.deleteImageButton.Text = "Delete";
            this.deleteImageButton.UseVisualStyleBackColor = true;
            this.deleteImageButton.Click += new System.EventHandler(this.deleteImageButton_Click);
            // 
            // takeImagesButton
            // 
            this.takeImagesButton.Enabled = false;
            this.takeImagesButton.Location = new System.Drawing.Point(6, 18);
            this.takeImagesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.takeImagesButton.Name = "takeImagesButton";
            this.takeImagesButton.Size = new System.Drawing.Size(100, 23);
            this.takeImagesButton.TabIndex = 0;
            this.takeImagesButton.Text = "Take images...";
            this.takeImagesButton.UseVisualStyleBackColor = true;
            this.takeImagesButton.Click += new System.EventHandler(this.takeImagesButton_Click);
            // 
            // classesGroupBox
            // 
            this.classesGroupBox.Controls.Add(this.classesListView);
            this.classesGroupBox.Controls.Add(this.deleteClassButton);
            this.classesGroupBox.Controls.Add(this.addClassButton);
            this.classesGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.classesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.classesGroupBox.Name = "classesGroupBox";
            this.classesGroupBox.Size = new System.Drawing.Size(140, 246);
            this.classesGroupBox.TabIndex = 0;
            this.classesGroupBox.TabStop = false;
            this.classesGroupBox.Text = "Classes";
            // 
            // classesListView
            // 
            this.classesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Class});
            this.classesListView.FullRowSelect = true;
            this.classesListView.HideSelection = false;
            this.classesListView.Location = new System.Drawing.Point(6, 46);
            this.classesListView.Margin = new System.Windows.Forms.Padding(2);
            this.classesListView.Name = "classesListView";
            this.classesListView.Size = new System.Drawing.Size(127, 196);
            this.classesListView.TabIndex = 2;
            this.classesListView.UseCompatibleStateImageBehavior = false;
            this.classesListView.View = System.Windows.Forms.View.Details;
            this.classesListView.SelectedIndexChanged += new System.EventHandler(this.classesListView_SelectedIndexChanged);
            this.classesListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.classesListBox_KeyUp);
            this.classesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.classesListView_MouseDoubleClick);
            // 
            // Class
            // 
            this.Class.Text = "Class";
            this.Class.Width = 90;
            // 
            // deleteClassButton
            // 
            this.deleteClassButton.Enabled = false;
            this.deleteClassButton.Location = new System.Drawing.Point(72, 18);
            this.deleteClassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteClassButton.Name = "deleteClassButton";
            this.deleteClassButton.Size = new System.Drawing.Size(60, 23);
            this.deleteClassButton.TabIndex = 1;
            this.deleteClassButton.Text = "Delete";
            this.deleteClassButton.UseVisualStyleBackColor = true;
            this.deleteClassButton.Click += new System.EventHandler(this.deleteClassButton_Click);
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(6, 18);
            this.addClassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(60, 23);
            this.addClassButton.TabIndex = 0;
            this.addClassButton.Text = "Add";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // modelPanel
            // 
            this.modelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelPanel.Location = new System.Drawing.Point(179, 512);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Size = new System.Drawing.Size(582, 244);
            this.modelPanel.TabIndex = 5;
            this.modelPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.trainingPanel_ControlAdded);
            // 
            // trainingPanel
            // 
            this.trainingPanel.Controls.Add(this.trainingLabel);
            this.trainingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingPanel.Location = new System.Drawing.Point(6, 765);
            this.trainingPanel.Name = "trainingPanel";
            this.trainingPanel.Size = new System.Drawing.Size(164, 54);
            this.trainingPanel.TabIndex = 6;
            // 
            // trainButton
            // 
            this.trainButton.Enabled = false;
            this.trainButton.Location = new System.Drawing.Point(242, 14);
            this.trainButton.Margin = new System.Windows.Forms.Padding(4);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(120, 23);
            this.trainButton.TabIndex = 1;
            this.trainButton.Text = "Train model";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // trainingLabel
            // 
            this.trainingLabel.AutoSize = true;
            this.trainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingLabel.Location = new System.Drawing.Point(13, 14);
            this.trainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trainingLabel.Name = "trainingLabel";
            this.trainingLabel.Size = new System.Drawing.Size(73, 20);
            this.trainingLabel.TabIndex = 1;
            this.trainingLabel.Text = "Training";
            // 
            // trainPanel
            // 
            this.trainPanel.Controls.Add(this.trainButton);
            this.trainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainPanel.Location = new System.Drawing.Point(179, 765);
            this.trainPanel.Name = "trainPanel";
            this.trainPanel.Size = new System.Drawing.Size(582, 54);
            this.trainPanel.TabIndex = 7;
            // 
            // predictionPanel
            // 
            this.predictionPanel.Controls.Add(this.predictionGroupBox);
            this.predictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictionPanel.Location = new System.Drawing.Point(179, 828);
            this.predictionPanel.Name = "predictionPanel";
            this.predictionPanel.Size = new System.Drawing.Size(582, 244);
            this.predictionPanel.TabIndex = 9;
            // 
            // predictionGroupBox
            // 
            this.predictionGroupBox.Controls.Add(this.predictButton);
            this.predictionGroupBox.Controls.Add(this.predictionListView);
            this.predictionGroupBox.Controls.Add(this.predictionPictureBox);
            this.predictionGroupBox.Controls.Add(this.predictionDeleteButton);
            this.predictionGroupBox.Controls.Add(this.predictionTakeImagesButton);
            this.predictionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictionGroupBox.Location = new System.Drawing.Point(0, 0);
            this.predictionGroupBox.Name = "predictionGroupBox";
            this.predictionGroupBox.Size = new System.Drawing.Size(582, 244);
            this.predictionGroupBox.TabIndex = 0;
            this.predictionGroupBox.TabStop = false;
            this.predictionGroupBox.Text = "Prediction";
            // 
            // predictButton
            // 
            this.predictButton.Enabled = false;
            this.predictButton.Location = new System.Drawing.Point(178, 19);
            this.predictButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(60, 23);
            this.predictButton.TabIndex = 2;
            this.predictButton.Text = "Predict";
            this.predictButton.UseVisualStyleBackColor = true;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // predictionListView
            // 
            this.predictionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Image1,
            this.Class1});
            this.predictionListView.FullRowSelect = true;
            this.predictionListView.HideSelection = false;
            this.predictionListView.Location = new System.Drawing.Point(6, 46);
            this.predictionListView.Margin = new System.Windows.Forms.Padding(2);
            this.predictionListView.Name = "predictionListView";
            this.predictionListView.Size = new System.Drawing.Size(302, 196);
            this.predictionListView.TabIndex = 3;
            this.predictionListView.UseCompatibleStateImageBehavior = false;
            this.predictionListView.View = System.Windows.Forms.View.Details;
            this.predictionListView.SelectedIndexChanged += new System.EventHandler(this.predictionListView_SelectedIndexChanged);
            this.predictionListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.predictionListView_KeyUp);
            // 
            // Image1
            // 
            this.Image1.Text = "Image";
            this.Image1.Width = 130;
            // 
            // Class1
            // 
            this.Class1.Text = "Class (predicted)";
            this.Class1.Width = 140;
            // 
            // predictionPictureBox
            // 
            this.predictionPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.predictionPictureBox.Location = new System.Drawing.Point(313, 16);
            this.predictionPictureBox.Name = "predictionPictureBox";
            this.predictionPictureBox.Size = new System.Drawing.Size(266, 225);
            this.predictionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.predictionPictureBox.TabIndex = 8;
            this.predictionPictureBox.TabStop = false;
            // 
            // predictionDeleteButton
            // 
            this.predictionDeleteButton.Enabled = false;
            this.predictionDeleteButton.Location = new System.Drawing.Point(112, 18);
            this.predictionDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.predictionDeleteButton.Name = "predictionDeleteButton";
            this.predictionDeleteButton.Size = new System.Drawing.Size(60, 23);
            this.predictionDeleteButton.TabIndex = 1;
            this.predictionDeleteButton.Text = "Delete";
            this.predictionDeleteButton.UseVisualStyleBackColor = true;
            this.predictionDeleteButton.Click += new System.EventHandler(this.predictionDeleteButton_Click);
            // 
            // predictionTakeImagesButton
            // 
            this.predictionTakeImagesButton.Enabled = false;
            this.predictionTakeImagesButton.Location = new System.Drawing.Point(6, 18);
            this.predictionTakeImagesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.predictionTakeImagesButton.Name = "predictionTakeImagesButton";
            this.predictionTakeImagesButton.Size = new System.Drawing.Size(100, 23);
            this.predictionTakeImagesButton.TabIndex = 0;
            this.predictionTakeImagesButton.Text = "Take images...";
            this.predictionTakeImagesButton.UseVisualStyleBackColor = true;
            this.predictionTakeImagesButton.Click += new System.EventHandler(this.predictionTakeImagesButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.Text = "Status:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTaskPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 597);
            this.Name = "MainForm";
            this.Text = "Image Classification";
            this.mainTaskPanel.ResumeLayout(false);
            this.mainTaskPanel.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.chooseModelPanel.ResumeLayout(false);
            this.chooseModelPanel.PerformLayout();
            this.imagesPanel.ResumeLayout(false);
            this.imagesPanel.PerformLayout();
            this.preprocessingPanel.ResumeLayout(false);
            this.preprocessingPanel.PerformLayout();
            this.processingStepsPanel.ResumeLayout(false);
            this.previewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processingPictureBox)).EndInit();
            this.processingStepsGroupBox.ResumeLayout(false);
            this.projectionPanel.ResumeLayout(false);
            this.projectionPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.imagesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingImagePictureBox)).EndInit();
            this.classesGroupBox.ResumeLayout(false);
            this.trainingPanel.ResumeLayout(false);
            this.trainingPanel.PerformLayout();
            this.trainPanel.ResumeLayout(false);
            this.predictionPanel.ResumeLayout(false);
            this.predictionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.predictionPictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainTaskPanel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel chooseModelPanel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Panel imagesPanel;
        private System.Windows.Forms.Label imagesLabel;
        private System.Windows.Forms.Panel preprocessingPanel;
        private System.Windows.Forms.Label preprocessingLabel;
        private System.Windows.Forms.Panel processingStepsPanel;
        private System.Windows.Forms.Panel projectionPanel;
        private System.Windows.Forms.Label projectionLabel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.GroupBox imagesGroupBox;
        private System.Windows.Forms.PictureBox trainingImagePictureBox;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.Button takeImagesButton;
        private System.Windows.Forms.GroupBox classesGroupBox;
        private System.Windows.Forms.Button deleteClassButton;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Panel modelPanel;
        private System.Windows.Forms.Panel trainingPanel;
        private System.Windows.Forms.Panel trainPanel;
        private System.Windows.Forms.Panel predictionPanel;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button chooseModelButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ListView trainingImagesListView;
        private System.Windows.Forms.ListView classesListView;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader Image;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.GroupBox processingStepsGroupBox;
        private System.Windows.Forms.ListView processingStepsListView;
        private System.Windows.Forms.ColumnHeader ProcessingStep;
        private System.Windows.Forms.Button deleteStepButton;
        private System.Windows.Forms.Button addStepButton;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.ComboBox imageComboBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.PictureBox processingPictureBox;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.GroupBox predictionGroupBox;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.ListView predictionListView;
        private System.Windows.Forms.ColumnHeader Image1;
        private System.Windows.Forms.ColumnHeader Class1;
        private System.Windows.Forms.PictureBox predictionPictureBox;
        private System.Windows.Forms.Button predictionDeleteButton;
        private System.Windows.Forms.Button predictionTakeImagesButton;
        private System.Windows.Forms.Label trainingLabel;
    }
}

