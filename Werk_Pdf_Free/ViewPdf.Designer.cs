namespace Werk_Pdf_Free
{
    partial class ViewPdf
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
            this.HeaderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PdfDocumentsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.NoneTabePage = new System.Windows.Forms.TabPage();
            this.PdfDocumentsTabControl.SuspendLayout();
            this.SuspendLayout();
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
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.Location = new System.Drawing.Point(3, 11);
            this.HeaderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(109, 19);
            this.HeaderLabel.TabIndex = 39;
            this.HeaderLabel.Text = "View PDF Files";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PdfDocumentsTabControl
            // 
            this.PdfDocumentsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PdfDocumentsTabControl.Controls.Add(this.NoneTabePage);
            this.PdfDocumentsTabControl.Depth = 0;
            this.PdfDocumentsTabControl.Location = new System.Drawing.Point(3, 84);
            this.PdfDocumentsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.PdfDocumentsTabControl.Name = "PdfDocumentsTabControl";
            this.PdfDocumentsTabControl.SelectedIndex = 0;
            this.PdfDocumentsTabControl.Size = new System.Drawing.Size(714, 273);
            this.PdfDocumentsTabControl.TabIndex = 40;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.PdfDocumentsTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 41);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(720, 37);
            this.materialTabSelector1.TabIndex = 41;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // NoneTabePage
            // 
            this.NoneTabePage.Location = new System.Drawing.Point(4, 22);
            this.NoneTabePage.Name = "NoneTabePage";
            this.NoneTabePage.Padding = new System.Windows.Forms.Padding(3);
            this.NoneTabePage.Size = new System.Drawing.Size(706, 247);
            this.NoneTabePage.TabIndex = 1;
            this.NoneTabePage.Text = "None";
            this.NoneTabePage.UseVisualStyleBackColor = true;
            // 
            // ViewPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.PdfDocumentsTabControl);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ViewPdf";
            this.Size = new System.Drawing.Size(720, 360);
            this.Load += new System.EventHandler(this.ViewPdf_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragOver);
            this.DragLeave += new System.EventHandler(this.SplitPdf_DragLeave);
            this.PdfDocumentsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape HeaderRectangleShape;
        private MaterialSkin.Controls.MaterialLabel HeaderLabel;
        private MaterialSkin.Controls.MaterialTabControl PdfDocumentsTabControl;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage NoneTabePage;
    }
}
