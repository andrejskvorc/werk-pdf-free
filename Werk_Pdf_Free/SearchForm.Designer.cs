namespace Werk_Pdf_Free
{
    partial class SearchForm
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
            this._findNext = new MaterialSkin.Controls.MaterialFlatButton();
            this.FindLabel = new MaterialSkin.Controls.MaterialLabel();
            this._find = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this._matchCase = new MaterialSkin.Controls.MaterialCheckBox();
            this._matchWholeWord = new MaterialSkin.Controls.MaterialCheckBox();
            this._highlightAll = new MaterialSkin.Controls.MaterialCheckBox();
            this._findPrevious = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // _findNext
            // 
            this._findNext.AutoSize = true;
            this._findNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._findNext.Depth = 0;
            this._findNext.Icon = null;
            this._findNext.Location = new System.Drawing.Point(320, 205);
            this._findNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._findNext.MouseState = MaterialSkin.MouseState.HOVER;
            this._findNext.Name = "_findNext";
            this._findNext.Primary = false;
            this._findNext.Size = new System.Drawing.Size(89, 36);
            this._findNext.TabIndex = 13;
            this._findNext.Text = "Find next";
            this._findNext.UseVisualStyleBackColor = true;
            this._findNext.Click += new System.EventHandler(this._findNext_Click);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Depth = 0;
            this.FindLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FindLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FindLabel.Location = new System.Drawing.Point(8, 76);
            this.FindLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(41, 19);
            this.FindLabel.TabIndex = 14;
            this.FindLabel.Text = "Find:";
            this.FindLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _find
            // 
            this._find.Depth = 0;
            this._find.Hint = "";
            this._find.Location = new System.Drawing.Point(55, 76);
            this._find.MaxLength = 32767;
            this._find.MouseState = MaterialSkin.MouseState.HOVER;
            this._find.Name = "_find";
            this._find.PasswordChar = '\0';
            this._find.SelectedText = "";
            this._find.SelectionLength = 0;
            this._find.SelectionStart = 0;
            this._find.Size = new System.Drawing.Size(354, 23);
            this._find.TabIndex = 15;
            this._find.TabStop = false;
            this._find.UseSystemPasswordChar = false;
            this._find.TextChanged += new System.EventHandler(this._find_TextChanged);
            // 
            // _matchCase
            // 
            this._matchCase.AutoSize = true;
            this._matchCase.Depth = 0;
            this._matchCase.Font = new System.Drawing.Font("Roboto", 10F);
            this._matchCase.Location = new System.Drawing.Point(55, 101);
            this._matchCase.Margin = new System.Windows.Forms.Padding(0);
            this._matchCase.MouseLocation = new System.Drawing.Point(-1, -1);
            this._matchCase.MouseState = MaterialSkin.MouseState.HOVER;
            this._matchCase.Name = "_matchCase";
            this._matchCase.Ripple = true;
            this._matchCase.Size = new System.Drawing.Size(103, 30);
            this._matchCase.TabIndex = 16;
            this._matchCase.Text = "Match Case";
            this._matchCase.UseVisualStyleBackColor = true;
            this._matchCase.CheckedChanged += new System.EventHandler(this._matchCase_CheckedChanged);
            // 
            // _matchWholeWord
            // 
            this._matchWholeWord.AutoSize = true;
            this._matchWholeWord.Depth = 0;
            this._matchWholeWord.Font = new System.Drawing.Font("Roboto", 10F);
            this._matchWholeWord.Location = new System.Drawing.Point(55, 131);
            this._matchWholeWord.Margin = new System.Windows.Forms.Padding(0);
            this._matchWholeWord.MouseLocation = new System.Drawing.Point(-1, -1);
            this._matchWholeWord.MouseState = MaterialSkin.MouseState.HOVER;
            this._matchWholeWord.Name = "_matchWholeWord";
            this._matchWholeWord.Ripple = true;
            this._matchWholeWord.Size = new System.Drawing.Size(143, 30);
            this._matchWholeWord.TabIndex = 17;
            this._matchWholeWord.Text = "Match whole word";
            this._matchWholeWord.UseVisualStyleBackColor = true;
            this._matchWholeWord.CheckedChanged += new System.EventHandler(this._matchWholeWord_CheckedChanged);
            // 
            // _highlightAll
            // 
            this._highlightAll.AutoSize = true;
            this._highlightAll.Depth = 0;
            this._highlightAll.Font = new System.Drawing.Font("Roboto", 10F);
            this._highlightAll.Location = new System.Drawing.Point(55, 161);
            this._highlightAll.Margin = new System.Windows.Forms.Padding(0);
            this._highlightAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this._highlightAll.MouseState = MaterialSkin.MouseState.HOVER;
            this._highlightAll.Name = "_highlightAll";
            this._highlightAll.Ripple = true;
            this._highlightAll.Size = new System.Drawing.Size(160, 30);
            this._highlightAll.TabIndex = 18;
            this._highlightAll.Text = "Highlight all matches";
            this._highlightAll.UseVisualStyleBackColor = true;
            this._highlightAll.CheckedChanged += new System.EventHandler(this._highlightAll_CheckedChanged);
            // 
            // _findPrevious
            // 
            this._findPrevious.AutoSize = true;
            this._findPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._findPrevious.Depth = 0;
            this._findPrevious.Icon = null;
            this._findPrevious.Location = new System.Drawing.Point(193, 205);
            this._findPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._findPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this._findPrevious.Name = "_findPrevious";
            this._findPrevious.Primary = false;
            this._findPrevious.Size = new System.Drawing.Size(119, 36);
            this._findPrevious.TabIndex = 19;
            this._findPrevious.Text = "Find previous";
            this._findPrevious.UseVisualStyleBackColor = true;
            this._findPrevious.Click += new System.EventHandler(this._findPrevious_Click);
            // 
            // SearchForm
            // 
            this.AcceptButton = this._findNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 253);
            this.Controls.Add(this._findPrevious);
            this.Controls.Add(this._highlightAll);
            this.Controls.Add(this._matchWholeWord);
            this.Controls.Add(this._matchCase);
            this.Controls.Add(this._find);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this._findNext);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton _findNext;
        private MaterialSkin.Controls.MaterialLabel FindLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField _find;
        private MaterialSkin.Controls.MaterialCheckBox _matchCase;
        private MaterialSkin.Controls.MaterialCheckBox _matchWholeWord;
        private MaterialSkin.Controls.MaterialCheckBox _highlightAll;
        private MaterialSkin.Controls.MaterialFlatButton _findPrevious;
    }
}