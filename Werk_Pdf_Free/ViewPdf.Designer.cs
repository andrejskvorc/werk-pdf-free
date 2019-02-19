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
            this.panel = new System.Windows.Forms.Panel();
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
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Location = new System.Drawing.Point(0, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(720, 320);
            this.panel.TabIndex = 40;
            // 
            // ViewPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ViewPdf";
            this.Size = new System.Drawing.Size(720, 360);
            this.Load += new System.EventHandler(this.ViewPdf_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SplitPdf_DragOver);
            this.DragLeave += new System.EventHandler(this.SplitPdf_DragLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape HeaderRectangleShape;
        private MaterialSkin.Controls.MaterialLabel HeaderLabel;
        private System.Windows.Forms.Panel panel;
    }
}
