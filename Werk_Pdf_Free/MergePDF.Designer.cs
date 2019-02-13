namespace Werk_Pdf_Free
{
    partial class MergePDF
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
            this.HeaderRectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.HeaderBackContainer = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.HeaderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MergePdfContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pleaseLoadPDFFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LoadFilesFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.FileNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilesListView = new MaterialListViewEx();
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MergePdfContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            // shapeContainer1
            // 
            this.HeaderBackContainer.Location = new System.Drawing.Point(0, 0);
            this.HeaderBackContainer.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderBackContainer.Name = "shapeContainer1";
            this.HeaderBackContainer.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.HeaderRectangleShape});
            this.HeaderBackContainer.Size = new System.Drawing.Size(720, 360);
            this.HeaderBackContainer.TabIndex = 0;
            this.HeaderBackContainer.TabStop = false;
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
            this.HeaderLabel.Size = new System.Drawing.Size(115, 19);
            this.HeaderLabel.TabIndex = 40;
            this.HeaderLabel.Text = "Merge PDF files";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MergePdfContextMenuStrip
            // 
            this.MergePdfContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MergePdfContextMenuStrip.Depth = 0;
            this.MergePdfContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.pleaseLoadPDFFilesToolStripMenuItem});
            this.MergePdfContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.MergePdfContextMenuStrip.Name = "MergePdfContextMenuStrip";
            this.MergePdfContextMenuStrip.Size = new System.Drawing.Size(182, 92);
            this.MergePdfContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MergePdfContextMenuStrip_Opening);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            this.moveUpToolStripMenuItem.Visible = false;
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.MoveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.moveDownToolStripMenuItem.Text = "Move Down";
            this.moveDownToolStripMenuItem.Visible = false;
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.MoveDownToolStripMenuItem_Click);
            // 
            // pleaseLoadPDFFilesToolStripMenuItem
            // 
            this.pleaseLoadPDFFilesToolStripMenuItem.Name = "pleaseLoadPDFFilesToolStripMenuItem";
            this.pleaseLoadPDFFilesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pleaseLoadPDFFilesToolStripMenuItem.Text = "Please load PDF files";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 48);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 42;
            this.materialLabel1.Text = "Files to merge";
            // 
            // LoadFilesFlatButton
            // 
            this.LoadFilesFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFilesFlatButton.AutoSize = true;
            this.LoadFilesFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadFilesFlatButton.Depth = 0;
            this.LoadFilesFlatButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFilesFlatButton.Icon = null;
            this.LoadFilesFlatButton.Location = new System.Drawing.Point(397, 70);
            this.LoadFilesFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadFilesFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadFilesFlatButton.Name = "LoadFilesFlatButton";
            this.LoadFilesFlatButton.Primary = false;
            this.LoadFilesFlatButton.Size = new System.Drawing.Size(94, 36);
            this.LoadFilesFlatButton.TabIndex = 43;
            this.LoadFilesFlatButton.Text = "Load files";
            this.LoadFilesFlatButton.UseVisualStyleBackColor = true;
            this.LoadFilesFlatButton.Click += new System.EventHandler(this.LoadFilesFlatButton_Click);
            // 
            // FileNameColumnHeader
            // 
            this.FileNameColumnHeader.Text = "File name";
            this.FileNameColumnHeader.Width = 241;
            // 
            // FilesListView
            // 
            this.FilesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader});
            this.FilesListView.ContextMenuStrip = this.MergePdfContextMenuStrip;
            this.FilesListView.Depth = 0;
            this.FilesListView.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.FilesListView.FullRowSelect = true;
            this.FilesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FilesListView.LineAfter = -1;
            this.FilesListView.LineBefore = -1;
            this.FilesListView.Location = new System.Drawing.Point(12, 77);
            this.FilesListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FilesListView.MouseState = MaterialSkin.MouseState.OUT;
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.OwnerDraw = true;
            this.FilesListView.Size = new System.Drawing.Size(367, 272);
            this.FilesListView.TabIndex = 44;
            this.FilesListView.UseCompatibleStateImageBehavior = false;
            this.FilesListView.View = System.Windows.Forms.View.Details;
            this.FilesListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FilesListView_MouseDown);
            this.FilesListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FilesListView_MouseMove);
            this.FilesListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FilesListView_MouseUp);
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "Files";
            this.NameColumnHeader.Width = 100;
            // 
            // MergePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilesListView);
            this.Controls.Add(this.LoadFilesFlatButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.HeaderBackContainer);
            this.Name = "MergePDF";
            this.Size = new System.Drawing.Size(720, 360);
            this.Load += new System.EventHandler(this.MergePDF_Load);
            this.MergePdfContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape HeaderRectangleShape;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer HeaderBackContainer;
        private MaterialSkin.Controls.MaterialLabel HeaderLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton LoadFilesFlatButton;
        private MaterialSkin.Controls.MaterialContextMenuStrip MergePdfContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pleaseLoadPDFFilesToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader FileNameColumnHeader;
        private MaterialListViewEx FilesListView;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
    }
}
