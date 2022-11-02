namespace Supermarket
{
    partial class FormSupermarket
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
            this.BtnAnalysis = new System.Windows.Forms.Button();
            this.TxtText = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAnalysis
            // 
            this.BtnAnalysis.Location = new System.Drawing.Point(261, 12);
            this.BtnAnalysis.Name = "BtnAnalysis";
            this.BtnAnalysis.Size = new System.Drawing.Size(265, 59);
            this.BtnAnalysis.TabIndex = 0;
            this.BtnAnalysis.Text = "Supermarket Analysis";
            this.BtnAnalysis.UseVisualStyleBackColor = true;
            this.BtnAnalysis.Click += new System.EventHandler(this.BtnAnalysis_Click);
            // 
            // TxtText
            // 
            this.TxtText.Location = new System.Drawing.Point(21, 77);
            this.TxtText.Multiline = true;
            this.TxtText.Name = "TxtText";
            this.TxtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtText.Size = new System.Drawing.Size(767, 269);
            this.TxtText.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(329, 371);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(143, 42);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormSupermarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtText);
            this.Controls.Add(this.BtnAnalysis);
            this.Name = "FormSupermarket";
            this.Text = "Supermarket";
            this.Load += new System.EventHandler(this.FormSupermarket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnalysis;
        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.Button BtnClose;
    }
}

