namespace Werk_Pdf_Free
{
    partial class PdfDocumentUserControl
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.HeaderRectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.FileContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.openPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitToPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.PageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PageSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ZoomSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ZoomLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SaveFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.OpenPdfFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SearchFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.BookmarksFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ZoomInFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.RotateRightFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.PrevFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.RotateLeftFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NextFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.FitBestFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.FitHeightFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.FitWidthFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ZoomOutFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.PrintFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.FileContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.HeaderRectangleShape});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 700);
            this.shapeContainer1.TabIndex = 38;
            this.shapeContainer1.TabStop = false;
            // 
            // HeaderRectangleShape
            // 
            this.HeaderRectangleShape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderRectangleShape.BorderColor = System.Drawing.Color.DimGray;
            this.HeaderRectangleShape.ContextMenuStrip = this.FileContextMenuStrip;
            this.HeaderRectangleShape.FillColor = System.Drawing.Color.DimGray;
            this.HeaderRectangleShape.FillGradientColor = System.Drawing.Color.Transparent;
            this.HeaderRectangleShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HeaderRectangleShape.Location = new System.Drawing.Point(0, 0);
            this.HeaderRectangleShape.Name = "HeaderRectangleShape";
            this.HeaderRectangleShape.Size = new System.Drawing.Size(900, 44);
            // 
            // FileContextMenuStrip
            // 
            this.FileContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileContextMenuStrip.Depth = 0;
            this.FileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPDFToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.splitToPagesToolStripMenuItem});
            this.FileContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileContextMenuStrip.Name = "FileContextMenuStrip";
            this.FileContextMenuStrip.Size = new System.Drawing.Size(146, 82);
            // 
            // openPDFToolStripMenuItem
            // 
            this.openPDFToolStripMenuItem.Name = "openPDFToolStripMenuItem";
            this.openPDFToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openPDFToolStripMenuItem.Text = "Open PDF";
            this.openPDFToolStripMenuItem.Click += new System.EventHandler(this.OpenPDFToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // splitToPagesToolStripMenuItem
            // 
            this.splitToPagesToolStripMenuItem.Name = "splitToPagesToolStripMenuItem";
            this.splitToPagesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.splitToPagesToolStripMenuItem.Text = "Split to pages";
            // 
            // pdfViewer
            // 
            this.pdfViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer.Location = new System.Drawing.Point(0, 45);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.ShowToolbar = false;
            this.pdfViewer.Size = new System.Drawing.Size(900, 651);
            this.pdfViewer.TabIndex = 42;
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.BackColor = System.Drawing.Color.DimGray;
            this.PageLabel.Depth = 0;
            this.PageLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PageLabel.Location = new System.Drawing.Point(140, 12);
            this.PageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(46, 19);
            this.PageLabel.TabIndex = 45;
            this.PageLabel.Text = "Page:";
            this.PageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PageSingleLineTextField
            // 
            this.PageSingleLineTextField.Depth = 0;
            this.PageSingleLineTextField.Hint = "";
            this.PageSingleLineTextField.Location = new System.Drawing.Point(192, 12);
            this.PageSingleLineTextField.MaxLength = 32767;
            this.PageSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PageSingleLineTextField.Name = "PageSingleLineTextField";
            this.PageSingleLineTextField.PasswordChar = '\0';
            this.PageSingleLineTextField.SelectedText = "";
            this.PageSingleLineTextField.SelectionLength = 0;
            this.PageSingleLineTextField.SelectionStart = 0;
            this.PageSingleLineTextField.Size = new System.Drawing.Size(75, 23);
            this.PageSingleLineTextField.TabIndex = 46;
            this.PageSingleLineTextField.TabStop = false;
            this.PageSingleLineTextField.UseSystemPasswordChar = false;
            this.PageSingleLineTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PageSingleLineTextField_KeyDown);
            // 
            // ZoomSingleLineTextField
            // 
            this.ZoomSingleLineTextField.Depth = 0;
            this.ZoomSingleLineTextField.Hint = "";
            this.ZoomSingleLineTextField.Location = new System.Drawing.Point(418, 12);
            this.ZoomSingleLineTextField.MaxLength = 32767;
            this.ZoomSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZoomSingleLineTextField.Name = "ZoomSingleLineTextField";
            this.ZoomSingleLineTextField.PasswordChar = '\0';
            this.ZoomSingleLineTextField.SelectedText = "";
            this.ZoomSingleLineTextField.SelectionLength = 0;
            this.ZoomSingleLineTextField.SelectionStart = 0;
            this.ZoomSingleLineTextField.Size = new System.Drawing.Size(75, 23);
            this.ZoomSingleLineTextField.TabIndex = 50;
            this.ZoomSingleLineTextField.TabStop = false;
            this.ZoomSingleLineTextField.UseSystemPasswordChar = false;
            this.ZoomSingleLineTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZoomSingleLineTextField_KeyDown);
            // 
            // ZoomLabel
            // 
            this.ZoomLabel.AutoSize = true;
            this.ZoomLabel.BackColor = System.Drawing.Color.DimGray;
            this.ZoomLabel.Depth = 0;
            this.ZoomLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ZoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ZoomLabel.Location = new System.Drawing.Point(366, 12);
            this.ZoomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZoomLabel.Name = "ZoomLabel";
            this.ZoomLabel.Size = new System.Drawing.Size(53, 19);
            this.ZoomLabel.TabIndex = 49;
            this.ZoomLabel.Text = "Zoom:";
            this.ZoomLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaveFlatButton
            // 
            this.SaveFlatButton.AutoSize = true;
            this.SaveFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveFlatButton.Depth = 0;
            this.SaveFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_save_as_48;
            this.SaveFlatButton.Location = new System.Drawing.Point(48, 4);
            this.SaveFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveFlatButton.Name = "SaveFlatButton";
            this.SaveFlatButton.Primary = false;
            this.SaveFlatButton.Size = new System.Drawing.Size(44, 36);
            this.SaveFlatButton.TabIndex = 59;
            this.SaveFlatButton.UseVisualStyleBackColor = true;
            this.SaveFlatButton.Click += new System.EventHandler(this.SaveFlatButton_Click);
            // 
            // OpenPdfFlatButton
            // 
            this.OpenPdfFlatButton.AutoSize = true;
            this.OpenPdfFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenPdfFlatButton.Depth = 0;
            this.OpenPdfFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_pdf_48;
            this.OpenPdfFlatButton.Location = new System.Drawing.Point(4, 4);
            this.OpenPdfFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenPdfFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenPdfFlatButton.Name = "OpenPdfFlatButton";
            this.OpenPdfFlatButton.Primary = false;
            this.OpenPdfFlatButton.Size = new System.Drawing.Size(44, 36);
            this.OpenPdfFlatButton.TabIndex = 44;
            this.OpenPdfFlatButton.UseVisualStyleBackColor = true;
            this.OpenPdfFlatButton.Click += new System.EventHandler(this.OpenPdfFlatButton_Click);
            // 
            // SearchFlatButton
            // 
            this.SearchFlatButton.AutoSize = true;
            this.SearchFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchFlatButton.Depth = 0;
            this.SearchFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_view_48;
            this.SearchFlatButton.Location = new System.Drawing.Point(808, 4);
            this.SearchFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchFlatButton.Name = "SearchFlatButton";
            this.SearchFlatButton.Primary = false;
            this.SearchFlatButton.Size = new System.Drawing.Size(44, 36);
            this.SearchFlatButton.TabIndex = 43;
            this.SearchFlatButton.UseVisualStyleBackColor = true;
            this.SearchFlatButton.Click += new System.EventHandler(this.SearchFlatButton_Click);
            // 
            // BookmarksFlatButton
            // 
            this.BookmarksFlatButton.AutoSize = true;
            this.BookmarksFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BookmarksFlatButton.Depth = 0;
            this.BookmarksFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_bookmark_48;
            this.BookmarksFlatButton.Location = new System.Drawing.Point(852, 4);
            this.BookmarksFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BookmarksFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BookmarksFlatButton.Name = "BookmarksFlatButton";
            this.BookmarksFlatButton.Primary = false;
            this.BookmarksFlatButton.Size = new System.Drawing.Size(44, 36);
            this.BookmarksFlatButton.TabIndex = 58;
            this.BookmarksFlatButton.UseVisualStyleBackColor = true;
            this.BookmarksFlatButton.Click += new System.EventHandler(this.BookmarksFlatButton_Click);
            // 
            // ZoomInFlatButton
            // 
            this.ZoomInFlatButton.AutoSize = true;
            this.ZoomInFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ZoomInFlatButton.Depth = 0;
            this.ZoomInFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_zoom_in_48;
            this.ZoomInFlatButton.Location = new System.Drawing.Point(500, 4);
            this.ZoomInFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ZoomInFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZoomInFlatButton.Name = "ZoomInFlatButton";
            this.ZoomInFlatButton.Primary = false;
            this.ZoomInFlatButton.Size = new System.Drawing.Size(44, 36);
            this.ZoomInFlatButton.TabIndex = 51;
            this.ZoomInFlatButton.UseVisualStyleBackColor = true;
            this.ZoomInFlatButton.Click += new System.EventHandler(this.ZoomInFlatButton_Click);
            // 
            // RotateRightFlatButton
            // 
            this.RotateRightFlatButton.AutoSize = true;
            this.RotateRightFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RotateRightFlatButton.Depth = 0;
            this.RotateRightFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_rotate_right_48;
            this.RotateRightFlatButton.Location = new System.Drawing.Point(764, 4);
            this.RotateRightFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RotateRightFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RotateRightFlatButton.Name = "RotateRightFlatButton";
            this.RotateRightFlatButton.Primary = false;
            this.RotateRightFlatButton.Size = new System.Drawing.Size(44, 36);
            this.RotateRightFlatButton.TabIndex = 57;
            this.RotateRightFlatButton.UseVisualStyleBackColor = true;
            this.RotateRightFlatButton.Click += new System.EventHandler(this.RotateRightFlatButton_Click);
            // 
            // PrevFlatButton
            // 
            this.PrevFlatButton.AutoSize = true;
            this.PrevFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrevFlatButton.Depth = 0;
            this.PrevFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_prev_48;
            this.PrevFlatButton.Location = new System.Drawing.Point(274, 4);
            this.PrevFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PrevFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrevFlatButton.Name = "PrevFlatButton";
            this.PrevFlatButton.Primary = false;
            this.PrevFlatButton.Size = new System.Drawing.Size(44, 36);
            this.PrevFlatButton.TabIndex = 47;
            this.PrevFlatButton.UseVisualStyleBackColor = true;
            this.PrevFlatButton.Click += new System.EventHandler(this.PrevFlatButton_Click);
            // 
            // RotateLeftFlatButton
            // 
            this.RotateLeftFlatButton.AutoSize = true;
            this.RotateLeftFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RotateLeftFlatButton.Depth = 0;
            this.RotateLeftFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_rotate_left_48;
            this.RotateLeftFlatButton.Location = new System.Drawing.Point(720, 4);
            this.RotateLeftFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RotateLeftFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RotateLeftFlatButton.Name = "RotateLeftFlatButton";
            this.RotateLeftFlatButton.Primary = false;
            this.RotateLeftFlatButton.Size = new System.Drawing.Size(44, 36);
            this.RotateLeftFlatButton.TabIndex = 56;
            this.RotateLeftFlatButton.UseVisualStyleBackColor = true;
            this.RotateLeftFlatButton.Click += new System.EventHandler(this.RotateLeftFlatButton_Click);
            // 
            // NextFlatButton
            // 
            this.NextFlatButton.AutoSize = true;
            this.NextFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NextFlatButton.Depth = 0;
            this.NextFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_next_48;
            this.NextFlatButton.Location = new System.Drawing.Point(318, 4);
            this.NextFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NextFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NextFlatButton.Name = "NextFlatButton";
            this.NextFlatButton.Primary = false;
            this.NextFlatButton.Size = new System.Drawing.Size(44, 36);
            this.NextFlatButton.TabIndex = 48;
            this.NextFlatButton.UseVisualStyleBackColor = true;
            this.NextFlatButton.Click += new System.EventHandler(this.NextFlatButton_Click);
            // 
            // FitBestFlatButton
            // 
            this.FitBestFlatButton.AutoSize = true;
            this.FitBestFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FitBestFlatButton.Depth = 0;
            this.FitBestFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_fit_best_48;
            this.FitBestFlatButton.Location = new System.Drawing.Point(676, 4);
            this.FitBestFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FitBestFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FitBestFlatButton.Name = "FitBestFlatButton";
            this.FitBestFlatButton.Primary = false;
            this.FitBestFlatButton.Size = new System.Drawing.Size(44, 36);
            this.FitBestFlatButton.TabIndex = 55;
            this.FitBestFlatButton.UseVisualStyleBackColor = true;
            this.FitBestFlatButton.Click += new System.EventHandler(this.FitBestFlatButton_Click);
            // 
            // FitHeightFlatButton
            // 
            this.FitHeightFlatButton.AutoSize = true;
            this.FitHeightFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FitHeightFlatButton.Depth = 0;
            this.FitHeightFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_fit_vertical_48;
            this.FitHeightFlatButton.Location = new System.Drawing.Point(632, 4);
            this.FitHeightFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FitHeightFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FitHeightFlatButton.Name = "FitHeightFlatButton";
            this.FitHeightFlatButton.Primary = false;
            this.FitHeightFlatButton.Size = new System.Drawing.Size(44, 36);
            this.FitHeightFlatButton.TabIndex = 54;
            this.FitHeightFlatButton.UseVisualStyleBackColor = true;
            this.FitHeightFlatButton.Click += new System.EventHandler(this.FitHeightFlatButton_Click);
            // 
            // FitWidthFlatButton
            // 
            this.FitWidthFlatButton.AutoSize = true;
            this.FitWidthFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FitWidthFlatButton.Depth = 0;
            this.FitWidthFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_fit_horizontal_48;
            this.FitWidthFlatButton.Location = new System.Drawing.Point(588, 4);
            this.FitWidthFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FitWidthFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FitWidthFlatButton.Name = "FitWidthFlatButton";
            this.FitWidthFlatButton.Primary = false;
            this.FitWidthFlatButton.Size = new System.Drawing.Size(44, 36);
            this.FitWidthFlatButton.TabIndex = 53;
            this.FitWidthFlatButton.UseVisualStyleBackColor = true;
            this.FitWidthFlatButton.Click += new System.EventHandler(this.FitWidthFlatButton_Click);
            // 
            // ZoomOutFlatButton
            // 
            this.ZoomOutFlatButton.AutoSize = true;
            this.ZoomOutFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ZoomOutFlatButton.Depth = 0;
            this.ZoomOutFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_zoom_out_48;
            this.ZoomOutFlatButton.Location = new System.Drawing.Point(544, 4);
            this.ZoomOutFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ZoomOutFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZoomOutFlatButton.Name = "ZoomOutFlatButton";
            this.ZoomOutFlatButton.Primary = false;
            this.ZoomOutFlatButton.Size = new System.Drawing.Size(44, 36);
            this.ZoomOutFlatButton.TabIndex = 52;
            this.ZoomOutFlatButton.UseVisualStyleBackColor = true;
            this.ZoomOutFlatButton.Click += new System.EventHandler(this.ZoomOutFlatButton_Click);
            // 
            // PrintFlatButton
            // 
            this.PrintFlatButton.AutoSize = true;
            this.PrintFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrintFlatButton.Depth = 0;
            this.PrintFlatButton.Icon = global::Werk_Pdf_Free.Properties.Resources.icons8_print_48;
            this.PrintFlatButton.Location = new System.Drawing.Point(92, 4);
            this.PrintFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PrintFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrintFlatButton.Name = "PrintFlatButton";
            this.PrintFlatButton.Primary = false;
            this.PrintFlatButton.Size = new System.Drawing.Size(44, 36);
            this.PrintFlatButton.TabIndex = 60;
            this.PrintFlatButton.UseVisualStyleBackColor = true;
            this.PrintFlatButton.Click += new System.EventHandler(this.PrintFlatButton_Click);
            // 
            // PdfDocumentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.FileContextMenuStrip;
            this.Controls.Add(this.PrintFlatButton);
            this.Controls.Add(this.SaveFlatButton);
            this.Controls.Add(this.OpenPdfFlatButton);
            this.Controls.Add(this.PageSingleLineTextField);
            this.Controls.Add(this.ZoomOutFlatButton);
            this.Controls.Add(this.FitWidthFlatButton);
            this.Controls.Add(this.ZoomSingleLineTextField);
            this.Controls.Add(this.SearchFlatButton);
            this.Controls.Add(this.FitHeightFlatButton);
            this.Controls.Add(this.BookmarksFlatButton);
            this.Controls.Add(this.ZoomLabel);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.FitBestFlatButton);
            this.Controls.Add(this.ZoomInFlatButton);
            this.Controls.Add(this.NextFlatButton);
            this.Controls.Add(this.RotateLeftFlatButton);
            this.Controls.Add(this.RotateRightFlatButton);
            this.Controls.Add(this.PrevFlatButton);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(900, 0);
            this.Name = "PdfDocumentUserControl";
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.PdfDocumentUserControl_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PdfDocumentUserControl_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PdfDocumentUserControl_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.PdfDocumentUserControl_DragOver);
            this.DragLeave += new System.EventHandler(this.PdfDocumentUserControl_DragLeave);
            this.FileContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape HeaderRectangleShape;
        private MaterialSkin.Controls.MaterialContextMenuStrip FileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitToPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private PdfiumViewer.PdfViewer pdfViewer;
        private MaterialSkin.Controls.MaterialFlatButton SearchFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton OpenPdfFlatButton;
        private MaterialSkin.Controls.MaterialLabel PageLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField PageSingleLineTextField;
        private MaterialSkin.Controls.MaterialFlatButton PrevFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton NextFlatButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField ZoomSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel ZoomLabel;
        private MaterialSkin.Controls.MaterialFlatButton ZoomInFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton ZoomOutFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton FitWidthFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton FitHeightFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton FitBestFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton RotateLeftFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton RotateRightFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton BookmarksFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton SaveFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton PrintFlatButton;
    }
}
