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
            this.openPDFInNewTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitToPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.FileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
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
            this.shapeContainer1.Size = new System.Drawing.Size(1000, 700);
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
            this.HeaderRectangleShape.Size = new System.Drawing.Size(1000, 44);
            // 
            // FileContextMenuStrip
            // 
            this.FileContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FileContextMenuStrip.Depth = 0;
            this.FileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPDFToolStripMenuItem,
            this.openPDFInNewTabToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.splitToPagesToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
            this.FileContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileContextMenuStrip.Name = "FileContextMenuStrip";
            this.FileContextMenuStrip.Size = new System.Drawing.Size(186, 132);
            // 
            // openPDFToolStripMenuItem
            // 
            this.openPDFToolStripMenuItem.Name = "openPDFToolStripMenuItem";
            this.openPDFToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openPDFToolStripMenuItem.Text = "Open PDF";
            // 
            // openPDFInNewTabToolStripMenuItem
            // 
            this.openPDFInNewTabToolStripMenuItem.Name = "openPDFInNewTabToolStripMenuItem";
            this.openPDFInNewTabToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openPDFInNewTabToolStripMenuItem.Text = "Open PDF in new tab";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // splitToPagesToolStripMenuItem
            // 
            this.splitToPagesToolStripMenuItem.Name = "splitToPagesToolStripMenuItem";
            this.splitToPagesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.splitToPagesToolStripMenuItem.Text = "Split to pages";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // CloseFlatButton
            // 
            this.CloseFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFlatButton.AutoSize = true;
            this.CloseFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseFlatButton.Depth = 0;
            this.CloseFlatButton.Icon = null;
            this.CloseFlatButton.Location = new System.Drawing.Point(934, 4);
            this.CloseFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseFlatButton.Name = "CloseFlatButton";
            this.CloseFlatButton.Primary = false;
            this.CloseFlatButton.Size = new System.Drawing.Size(63, 36);
            this.CloseFlatButton.TabIndex = 39;
            this.CloseFlatButton.Text = "Close";
            this.CloseFlatButton.UseVisualStyleBackColor = true;
            this.CloseFlatButton.Click += new System.EventHandler(this.CloseFlatButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.BackColor = System.Drawing.Color.DimGray;
            this.FileNameLabel.ContextMenuStrip = this.FileContextMenuStrip;
            this.FileNameLabel.Depth = 0;
            this.FileNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FileNameLabel.Location = new System.Drawing.Point(3, 12);
            this.FileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(98, 19);
            this.FileNameLabel.TabIndex = 40;
            this.FileNameLabel.Text = "FileName.pdf";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer.Location = new System.Drawing.Point(0, 44);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.ShowToolbar = false;
            this.pdfViewer.Size = new System.Drawing.Size(1000, 656);
            this.pdfViewer.TabIndex = 42;
            // 
            // PdfDocumentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.FileContextMenuStrip;
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.CloseFlatButton);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PdfDocumentUserControl";
            this.Size = new System.Drawing.Size(1000, 700);
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
        private MaterialSkin.Controls.MaterialFlatButton CloseFlatButton;
        private MaterialSkin.Controls.MaterialLabel FileNameLabel;
        private MaterialSkin.Controls.MaterialContextMenuStrip FileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitToPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPDFInNewTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private PdfiumViewer.PdfViewer pdfViewer;
    }
}
