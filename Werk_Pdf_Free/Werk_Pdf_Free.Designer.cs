namespace Werk_Pdf_Free
{
    partial class Werk_Pdf_Free
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
            this.PdfSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MergePdfFilesFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.ExitFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SettingsFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.PdfSplitContainer)).BeginInit();
            this.PdfSplitContainer.Panel1.SuspendLayout();
            this.PdfSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PdfSplitContainer
            // 
            this.PdfSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PdfSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PdfSplitContainer.Location = new System.Drawing.Point(0, 64);
            this.PdfSplitContainer.Name = "PdfSplitContainer";
            // 
            // PdfSplitContainer.Panel1
            // 
            this.PdfSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.PdfSplitContainer.Size = new System.Drawing.Size(820, 418);
            this.PdfSplitContainer.SplitterDistance = 137;
            this.PdfSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SettingsFlatButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MergePdfFilesFlatButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialFlatButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExitFlatButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(137, 418);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MergePdfFilesFlatButton
            // 
            this.MergePdfFilesFlatButton.AutoSize = true;
            this.MergePdfFilesFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MergePdfFilesFlatButton.Depth = 0;
            this.MergePdfFilesFlatButton.Icon = null;
            this.MergePdfFilesFlatButton.Location = new System.Drawing.Point(4, 42);
            this.MergePdfFilesFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MergePdfFilesFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MergePdfFilesFlatButton.Name = "MergePdfFilesFlatButton";
            this.MergePdfFilesFlatButton.Primary = false;
            this.MergePdfFilesFlatButton.Size = new System.Drawing.Size(129, 24);
            this.MergePdfFilesFlatButton.TabIndex = 0;
            this.MergePdfFilesFlatButton.Text = "Merge PDF files";
            this.MergePdfFilesFlatButton.UseVisualStyleBackColor = true;
            this.MergePdfFilesFlatButton.Click += new System.EventHandler(this.MergePdfFilesFlatButton_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(129, 24);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Auto split Pdf";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.SplitPdfControlFlatButton_Click);
            // 
            // ExitFlatButton
            // 
            this.ExitFlatButton.AutoSize = true;
            this.ExitFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitFlatButton.Depth = 0;
            this.ExitFlatButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitFlatButton.Icon = null;
            this.ExitFlatButton.Location = new System.Drawing.Point(4, 388);
            this.ExitFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitFlatButton.Name = "ExitFlatButton";
            this.ExitFlatButton.Primary = false;
            this.ExitFlatButton.Size = new System.Drawing.Size(129, 24);
            this.ExitFlatButton.TabIndex = 0;
            this.ExitFlatButton.Text = "Exit";
            this.ExitFlatButton.UseVisualStyleBackColor = true;
            this.ExitFlatButton.Click += new System.EventHandler(this.ExitFlatButton_Click);
            // 
            // SettingsFlatButton
            // 
            this.SettingsFlatButton.AutoSize = true;
            this.SettingsFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsFlatButton.Depth = 0;
            this.SettingsFlatButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsFlatButton.Icon = null;
            this.SettingsFlatButton.Location = new System.Drawing.Point(4, 352);
            this.SettingsFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SettingsFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsFlatButton.Name = "SettingsFlatButton";
            this.SettingsFlatButton.Primary = false;
            this.SettingsFlatButton.Size = new System.Drawing.Size(129, 24);
            this.SettingsFlatButton.TabIndex = 0;
            this.SettingsFlatButton.Text = "Settings";
            this.SettingsFlatButton.UseVisualStyleBackColor = true;
            this.SettingsFlatButton.Click += new System.EventHandler(this.SettingsFlatButton_Click);
            // 
            // Werk_Pdf_Free
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.PdfSplitContainer);
            this.MaximizeBox = false;
            this.Name = "Werk_Pdf_Free";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Werk Pdf Free";
            this.Load += new System.EventHandler(this.Werk_Pdf_Free_Load);
            this.PdfSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PdfSplitContainer)).EndInit();
            this.PdfSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer PdfSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialFlatButton ExitFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton MergePdfFilesFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton SettingsFlatButton;
    }
}