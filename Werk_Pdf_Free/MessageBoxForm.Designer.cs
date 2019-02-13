namespace Werk_Pdf_Free
{
    partial class MessageBoxForm
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
            this.OkFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.Message1Label = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OkFlatButton
            // 
            this.OkFlatButton.AutoSize = true;
            this.OkFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OkFlatButton.Depth = 0;
            this.OkFlatButton.Icon = null;
            this.OkFlatButton.Location = new System.Drawing.Point(481, 150);
            this.OkFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkFlatButton.Name = "OkFlatButton";
            this.OkFlatButton.Primary = false;
            this.OkFlatButton.Size = new System.Drawing.Size(39, 36);
            this.OkFlatButton.TabIndex = 13;
            this.OkFlatButton.Text = "Ok";
            this.OkFlatButton.UseVisualStyleBackColor = true;
            this.OkFlatButton.Click += new System.EventHandler(this.ExitFlatButton_Click);
            // 
            // Message1Label
            // 
            this.Message1Label.AutoSize = true;
            this.Message1Label.Depth = 0;
            this.Message1Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.Message1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Message1Label.Location = new System.Drawing.Point(100, 101);
            this.Message1Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Message1Label.Name = "Message1Label";
            this.Message1Label.Size = new System.Drawing.Size(409, 19);
            this.Message1Label.TabIndex = 11;
            this.Message1Label.Text = "\"Error: Only one file is allowed for Drag and Drop operation!\"";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Werk_Pdf_Free.Properties.Resources.icons8_close_window_48;
            this.panel1.Location = new System.Drawing.Point(33, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 50);
            this.panel1.TabIndex = 14;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 201);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OkFlatButton);
            this.Controls.Add(this.Message1Label);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton OkFlatButton;
        private MaterialSkin.Controls.MaterialLabel Message1Label;
        private System.Windows.Forms.Panel panel1;
    }
}