namespace Werk_Pdf_Free
{
    partial class SplitPdf
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveDirectoryCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.FileTextSpliterSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FileTextSpliterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PageNumbersCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.Message2Label = new MaterialSkin.Controls.MaterialLabel();
            this.SplitFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.Message1Label = new MaterialSkin.Controls.MaterialLabel();
            this.OutputFileNameSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.OutputFileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.OutputFileNameSufixSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.OutputFileNameSufixLabel = new MaterialSkin.Controls.MaterialLabel();
            this.OutputNameSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.OutputNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.OutputFileNamePrefixSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.OutputFilePrefixLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LoadFileFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.InputFileNameSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.InputFileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.HeaderRectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.HeaderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ClearFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // SaveDirectoryCheckBox
            // 
            this.SaveDirectoryCheckBox.AutoSize = true;
            this.SaveDirectoryCheckBox.Checked = true;
            this.SaveDirectoryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveDirectoryCheckBox.Depth = 0;
            this.SaveDirectoryCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.SaveDirectoryCheckBox.Location = new System.Drawing.Point(140, 257);
            this.SaveDirectoryCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.SaveDirectoryCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SaveDirectoryCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveDirectoryCheckBox.Name = "SaveDirectoryCheckBox";
            this.SaveDirectoryCheckBox.Ripple = true;
            this.SaveDirectoryCheckBox.Size = new System.Drawing.Size(282, 30);
            this.SaveDirectoryCheckBox.TabIndex = 37;
            this.SaveDirectoryCheckBox.Text = "Save splited files to directory of input file";
            this.SaveDirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // FileTextSpliterSingleLineTextField
            // 
            this.FileTextSpliterSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTextSpliterSingleLineTextField.Depth = 0;
            this.FileTextSpliterSingleLineTextField.Hint = "";
            this.FileTextSpliterSingleLineTextField.Location = new System.Drawing.Point(604, 105);
            this.FileTextSpliterSingleLineTextField.MaxLength = 32767;
            this.FileTextSpliterSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileTextSpliterSingleLineTextField.Name = "FileTextSpliterSingleLineTextField";
            this.FileTextSpliterSingleLineTextField.PasswordChar = '\0';
            this.FileTextSpliterSingleLineTextField.SelectedText = "";
            this.FileTextSpliterSingleLineTextField.SelectionLength = 0;
            this.FileTextSpliterSingleLineTextField.SelectionStart = 0;
            this.FileTextSpliterSingleLineTextField.Size = new System.Drawing.Size(19, 23);
            this.FileTextSpliterSingleLineTextField.TabIndex = 36;
            this.FileTextSpliterSingleLineTextField.TabStop = false;
            this.FileTextSpliterSingleLineTextField.Text = "_";
            this.FileTextSpliterSingleLineTextField.UseSystemPasswordChar = false;
            this.FileTextSpliterSingleLineTextField.TextChanged += new System.EventHandler(this.FileTextSpliterSingleLineTextField_TextChanged);
            // 
            // FileTextSpliterLabel
            // 
            this.FileTextSpliterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTextSpliterLabel.AutoSize = true;
            this.FileTextSpliterLabel.Depth = 0;
            this.FileTextSpliterLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FileTextSpliterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FileTextSpliterLabel.Location = new System.Drawing.Point(486, 107);
            this.FileTextSpliterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileTextSpliterLabel.Name = "FileTextSpliterLabel";
            this.FileTextSpliterLabel.Size = new System.Drawing.Size(112, 19);
            this.FileTextSpliterLabel.TabIndex = 35;
            this.FileTextSpliterLabel.Text = "File text spliter:";
            this.FileTextSpliterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PageNumbersCheckBox
            // 
            this.PageNumbersCheckBox.AutoSize = true;
            this.PageNumbersCheckBox.Checked = true;
            this.PageNumbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PageNumbersCheckBox.Depth = 0;
            this.PageNumbersCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.PageNumbersCheckBox.Location = new System.Drawing.Point(140, 227);
            this.PageNumbersCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.PageNumbersCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PageNumbersCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PageNumbersCheckBox.Name = "PageNumbersCheckBox";
            this.PageNumbersCheckBox.Ripple = true;
            this.PageNumbersCheckBox.Size = new System.Drawing.Size(305, 30);
            this.PageNumbersCheckBox.TabIndex = 34;
            this.PageNumbersCheckBox.Text = "Add page numbers at the end eg. page 1 of 6";
            this.PageNumbersCheckBox.UseVisualStyleBackColor = true;
            this.PageNumbersCheckBox.CheckedChanged += new System.EventHandler(this.PageNumbersCheckBox_CheckedChanged);
            // 
            // Message2Label
            // 
            this.Message2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Message2Label.AutoSize = true;
            this.Message2Label.Depth = 0;
            this.Message2Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.Message2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Message2Label.Location = new System.Drawing.Point(21, 299);
            this.Message2Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Message2Label.Name = "Message2Label";
            this.Message2Label.Size = new System.Drawing.Size(359, 19);
            this.Message2Label.TabIndex = 33;
            this.Message2Label.Text = "Default save location is My Documents\\SplitedPDFs";
            // 
            // SplitFlatButton
            // 
            this.SplitFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitFlatButton.AutoSize = true;
            this.SplitFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SplitFlatButton.Depth = 0;
            this.SplitFlatButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitFlatButton.Icon = null;
            this.SplitFlatButton.Location = new System.Drawing.Point(630, 194);
            this.SplitFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SplitFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SplitFlatButton.Name = "SplitFlatButton";
            this.SplitFlatButton.Primary = false;
            this.SplitFlatButton.Size = new System.Drawing.Size(58, 36);
            this.SplitFlatButton.TabIndex = 31;
            this.SplitFlatButton.Text = "Split";
            this.SplitFlatButton.UseVisualStyleBackColor = true;
            this.SplitFlatButton.Click += new System.EventHandler(this.SplitFlatButton_Click);
            // 
            // Message1Label
            // 
            this.Message1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Message1Label.AutoSize = true;
            this.Message1Label.Depth = 0;
            this.Message1Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.Message1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Message1Label.Location = new System.Drawing.Point(21, 320);
            this.Message1Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Message1Label.Name = "Message1Label";
            this.Message1Label.Size = new System.Drawing.Size(686, 19);
            this.Message1Label.TabIndex = 30;
            this.Message1Label.Text = "Drag and drop from Microsoft Outlook, Desktop or Filemanager ONE (1) FILE or use " +
    "\"Load file\" button";
            // 
            // OutputFileNameSingleLineTextField
            // 
            this.OutputFileNameSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFileNameSingleLineTextField.Depth = 0;
            this.OutputFileNameSingleLineTextField.Enabled = false;
            this.OutputFileNameSingleLineTextField.Hint = "";
            this.OutputFileNameSingleLineTextField.Location = new System.Drawing.Point(140, 201);
            this.OutputFileNameSingleLineTextField.MaxLength = 32767;
            this.OutputFileNameSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.OutputFileNameSingleLineTextField.Name = "OutputFileNameSingleLineTextField";
            this.OutputFileNameSingleLineTextField.PasswordChar = '\0';
            this.OutputFileNameSingleLineTextField.SelectedText = "";
            this.OutputFileNameSingleLineTextField.SelectionLength = 0;
            this.OutputFileNameSingleLineTextField.SelectionStart = 0;
            this.OutputFileNameSingleLineTextField.Size = new System.Drawing.Size(483, 23);
            this.OutputFileNameSingleLineTextField.TabIndex = 29;
            this.OutputFileNameSingleLineTextField.TabStop = false;
            this.OutputFileNameSingleLineTextField.UseSystemPasswordChar = false;
            // 
            // OutputFileNameLabel
            // 
            this.OutputFileNameLabel.AutoSize = true;
            this.OutputFileNameLabel.Depth = 0;
            this.OutputFileNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.OutputFileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutputFileNameLabel.Location = new System.Drawing.Point(27, 201);
            this.OutputFileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OutputFileNameLabel.Name = "OutputFileNameLabel";
            this.OutputFileNameLabel.Size = new System.Drawing.Size(106, 19);
            this.OutputFileNameLabel.TabIndex = 28;
            this.OutputFileNameLabel.Text = "Out. file name:";
            this.OutputFileNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OutputFileNameSufixSingleLineTextField
            // 
            this.OutputFileNameSufixSingleLineTextField.Depth = 0;
            this.OutputFileNameSufixSingleLineTextField.Hint = "";
            this.OutputFileNameSufixSingleLineTextField.Location = new System.Drawing.Point(140, 169);
            this.OutputFileNameSufixSingleLineTextField.MaxLength = 32767;
            this.OutputFileNameSufixSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.OutputFileNameSufixSingleLineTextField.Name = "OutputFileNameSufixSingleLineTextField";
            this.OutputFileNameSufixSingleLineTextField.PasswordChar = '\0';
            this.OutputFileNameSufixSingleLineTextField.SelectedText = "";
            this.OutputFileNameSufixSingleLineTextField.SelectionLength = 0;
            this.OutputFileNameSufixSingleLineTextField.SelectionStart = 0;
            this.OutputFileNameSufixSingleLineTextField.Size = new System.Drawing.Size(187, 23);
            this.OutputFileNameSufixSingleLineTextField.TabIndex = 27;
            this.OutputFileNameSufixSingleLineTextField.TabStop = false;
            this.OutputFileNameSufixSingleLineTextField.UseSystemPasswordChar = false;
            this.OutputFileNameSufixSingleLineTextField.TextChanged += new System.EventHandler(this.OutputFileNameSufixSingleLineTextField_TextChanged);
            // 
            // OutputFileNameSufixLabel
            // 
            this.OutputFileNameSufixLabel.AutoSize = true;
            this.OutputFileNameSufixLabel.Depth = 0;
            this.OutputFileNameSufixLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.OutputFileNameSufixLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutputFileNameSufixLabel.Location = new System.Drawing.Point(32, 169);
            this.OutputFileNameSufixLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OutputFileNameSufixLabel.Name = "OutputFileNameSufixLabel";
            this.OutputFileNameSufixLabel.Size = new System.Drawing.Size(101, 19);
            this.OutputFileNameSufixLabel.TabIndex = 26;
            this.OutputFileNameSufixLabel.Text = "Out. file sufix:";
            this.OutputFileNameSufixLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OutputNameSingleLineTextField
            // 
            this.OutputNameSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputNameSingleLineTextField.Depth = 0;
            this.OutputNameSingleLineTextField.Hint = "";
            this.OutputNameSingleLineTextField.Location = new System.Drawing.Point(140, 138);
            this.OutputNameSingleLineTextField.MaxLength = 32767;
            this.OutputNameSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.OutputNameSingleLineTextField.Name = "OutputNameSingleLineTextField";
            this.OutputNameSingleLineTextField.PasswordChar = '\0';
            this.OutputNameSingleLineTextField.SelectedText = "";
            this.OutputNameSingleLineTextField.SelectionLength = 0;
            this.OutputNameSingleLineTextField.SelectionStart = 0;
            this.OutputNameSingleLineTextField.Size = new System.Drawing.Size(483, 23);
            this.OutputNameSingleLineTextField.TabIndex = 25;
            this.OutputNameSingleLineTextField.TabStop = false;
            this.OutputNameSingleLineTextField.UseSystemPasswordChar = false;
            this.OutputNameSingleLineTextField.TextChanged += new System.EventHandler(this.OutputNameSingleLineTextField_TextChanged);
            // 
            // OutputNameLabel
            // 
            this.OutputNameLabel.AutoSize = true;
            this.OutputNameLabel.Depth = 0;
            this.OutputNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.OutputNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutputNameLabel.Location = new System.Drawing.Point(53, 138);
            this.OutputNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OutputNameLabel.Name = "OutputNameLabel";
            this.OutputNameLabel.Size = new System.Drawing.Size(81, 19);
            this.OutputNameLabel.TabIndex = 24;
            this.OutputNameLabel.Text = "Out. name:";
            this.OutputNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OutputFileNamePrefixSingleLineTextField
            // 
            this.OutputFileNamePrefixSingleLineTextField.Depth = 0;
            this.OutputFileNamePrefixSingleLineTextField.Hint = "";
            this.OutputFileNamePrefixSingleLineTextField.Location = new System.Drawing.Point(140, 107);
            this.OutputFileNamePrefixSingleLineTextField.MaxLength = 32767;
            this.OutputFileNamePrefixSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.OutputFileNamePrefixSingleLineTextField.Name = "OutputFileNamePrefixSingleLineTextField";
            this.OutputFileNamePrefixSingleLineTextField.PasswordChar = '\0';
            this.OutputFileNamePrefixSingleLineTextField.SelectedText = "";
            this.OutputFileNamePrefixSingleLineTextField.SelectionLength = 0;
            this.OutputFileNamePrefixSingleLineTextField.SelectionStart = 0;
            this.OutputFileNamePrefixSingleLineTextField.Size = new System.Drawing.Size(187, 23);
            this.OutputFileNamePrefixSingleLineTextField.TabIndex = 23;
            this.OutputFileNamePrefixSingleLineTextField.TabStop = false;
            this.OutputFileNamePrefixSingleLineTextField.UseSystemPasswordChar = false;
            this.OutputFileNamePrefixSingleLineTextField.TextChanged += new System.EventHandler(this.OutputFileNamePrefixSingleLineTextField_TextChanged);
            // 
            // OutputFilePrefixLabel
            // 
            this.OutputFilePrefixLabel.AutoSize = true;
            this.OutputFilePrefixLabel.Depth = 0;
            this.OutputFilePrefixLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.OutputFilePrefixLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OutputFilePrefixLabel.Location = new System.Drawing.Point(27, 107);
            this.OutputFilePrefixLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OutputFilePrefixLabel.Name = "OutputFilePrefixLabel";
            this.OutputFilePrefixLabel.Size = new System.Drawing.Size(106, 19);
            this.OutputFilePrefixLabel.TabIndex = 22;
            this.OutputFilePrefixLabel.Text = "Out. file prefix:";
            this.OutputFilePrefixLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LoadFileFlatButton
            // 
            this.LoadFileFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFileFlatButton.AutoSize = true;
            this.LoadFileFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadFileFlatButton.Depth = 0;
            this.LoadFileFlatButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFileFlatButton.Icon = null;
            this.LoadFileFlatButton.Location = new System.Drawing.Point(630, 69);
            this.LoadFileFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadFileFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadFileFlatButton.Name = "LoadFileFlatButton";
            this.LoadFileFlatButton.Primary = false;
            this.LoadFileFlatButton.Size = new System.Drawing.Size(86, 36);
            this.LoadFileFlatButton.TabIndex = 21;
            this.LoadFileFlatButton.Text = "Load file";
            this.LoadFileFlatButton.UseVisualStyleBackColor = true;
            this.LoadFileFlatButton.Click += new System.EventHandler(this.LoadFileFlatButton_Click);
            // 
            // InputFileNameSingleLineTextField
            // 
            this.InputFileNameSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFileNameSingleLineTextField.Depth = 0;
            this.InputFileNameSingleLineTextField.Enabled = false;
            this.InputFileNameSingleLineTextField.Hint = "";
            this.InputFileNameSingleLineTextField.Location = new System.Drawing.Point(140, 76);
            this.InputFileNameSingleLineTextField.MaxLength = 32767;
            this.InputFileNameSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputFileNameSingleLineTextField.Name = "InputFileNameSingleLineTextField";
            this.InputFileNameSingleLineTextField.PasswordChar = '\0';
            this.InputFileNameSingleLineTextField.SelectedText = "";
            this.InputFileNameSingleLineTextField.SelectionLength = 0;
            this.InputFileNameSingleLineTextField.SelectionStart = 0;
            this.InputFileNameSingleLineTextField.Size = new System.Drawing.Size(483, 23);
            this.InputFileNameSingleLineTextField.TabIndex = 20;
            this.InputFileNameSingleLineTextField.TabStop = false;
            this.InputFileNameSingleLineTextField.UseSystemPasswordChar = false;
            // 
            // InputFileNameLabel
            // 
            this.InputFileNameLabel.AutoSize = true;
            this.InputFileNameLabel.Depth = 0;
            this.InputFileNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.InputFileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InputFileNameLabel.Location = new System.Drawing.Point(21, 76);
            this.InputFileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputFileNameLabel.Name = "InputFileNameLabel";
            this.InputFileNameLabel.Size = new System.Drawing.Size(112, 19);
            this.InputFileNameLabel.TabIndex = 19;
            this.InputFileNameLabel.Text = "Input file name:";
            this.InputFileNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.HeaderRectangleShape});
            this.shapeContainer1.Size = new System.Drawing.Size(720, 360);
            this.shapeContainer1.TabIndex = 38;
            this.shapeContainer1.TabStop = false;
            // 
            // HeaderRectangleShape
            // 
            this.HeaderRectangleShape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderRectangleShape.BorderColor = System.Drawing.Color.DimGray;
            this.HeaderRectangleShape.FillColor = System.Drawing.Color.DimGray;
            this.HeaderRectangleShape.FillGradientColor = System.Drawing.Color.Transparent;
            this.HeaderRectangleShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HeaderRectangleShape.Location = new System.Drawing.Point(0, 0);
            this.HeaderRectangleShape.Name = "HeaderRectangleShape";
            this.HeaderRectangleShape.Size = new System.Drawing.Size(720, 40);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.DimGray;
            this.HeaderLabel.Depth = 0;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(3, 11);
            this.HeaderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(259, 19);
            this.HeaderLabel.TabIndex = 39;
            this.HeaderLabel.Text = "Split PDF pages to separate  PDF-s";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClearFlatButton
            // 
            this.ClearFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearFlatButton.AutoSize = true;
            this.ClearFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearFlatButton.Depth = 0;
            this.ClearFlatButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFlatButton.Icon = null;
            this.ClearFlatButton.Location = new System.Drawing.Point(630, 242);
            this.ClearFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClearFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClearFlatButton.Name = "ClearFlatButton";
            this.ClearFlatButton.Primary = false;
            this.ClearFlatButton.Size = new System.Drawing.Size(63, 36);
            this.ClearFlatButton.TabIndex = 40;
            this.ClearFlatButton.Text = "Clear";
            this.ClearFlatButton.UseVisualStyleBackColor = true;
            this.ClearFlatButton.Click += new System.EventHandler(this.ClearFlatButton_Click);
            // 
            // SplitPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearFlatButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.SaveDirectoryCheckBox);
            this.Controls.Add(this.FileTextSpliterSingleLineTextField);
            this.Controls.Add(this.FileTextSpliterLabel);
            this.Controls.Add(this.PageNumbersCheckBox);
            this.Controls.Add(this.Message2Label);
            this.Controls.Add(this.SplitFlatButton);
            this.Controls.Add(this.Message1Label);
            this.Controls.Add(this.OutputFileNameSingleLineTextField);
            this.Controls.Add(this.OutputFileNameLabel);
            this.Controls.Add(this.OutputFileNameSufixSingleLineTextField);
            this.Controls.Add(this.OutputFileNameSufixLabel);
            this.Controls.Add(this.OutputNameSingleLineTextField);
            this.Controls.Add(this.OutputNameLabel);
            this.Controls.Add(this.OutputFileNamePrefixSingleLineTextField);
            this.Controls.Add(this.OutputFilePrefixLabel);
            this.Controls.Add(this.LoadFileFlatButton);
            this.Controls.Add(this.InputFileNameSingleLineTextField);
            this.Controls.Add(this.InputFileNameLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "SplitPdf";
            this.Size = new System.Drawing.Size(720, 360);
            this.Load += new System.EventHandler(this.SplitPdf_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragOver);
            this.DragLeave += new System.EventHandler(this.SplitPdf_DragLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox SaveDirectoryCheckBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField FileTextSpliterSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel FileTextSpliterLabel;
        private MaterialSkin.Controls.MaterialCheckBox PageNumbersCheckBox;
        private MaterialSkin.Controls.MaterialLabel Message2Label;
        private MaterialSkin.Controls.MaterialFlatButton SplitFlatButton;
        private MaterialSkin.Controls.MaterialLabel Message1Label;
        private MaterialSkin.Controls.MaterialSingleLineTextField OutputFileNameSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel OutputFileNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField OutputFileNameSufixSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel OutputFileNameSufixLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField OutputNameSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel OutputNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField OutputFileNamePrefixSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel OutputFilePrefixLabel;
        private MaterialSkin.Controls.MaterialFlatButton LoadFileFlatButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField InputFileNameSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel InputFileNameLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape HeaderRectangleShape;
        private MaterialSkin.Controls.MaterialLabel HeaderLabel;
        private MaterialSkin.Controls.MaterialFlatButton ClearFlatButton;
    }
}
