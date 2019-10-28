namespace Searchie
{
    partial class HelpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.helpTb = new System.Windows.Forms.TextBox();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Help";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(101, 276);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(47, 15);
            this.authorLbl.TabIndex = 2;
            this.authorLbl.Text = "Author:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(154, 276);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(90, 15);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Kenneth Linardi";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(129, 304);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // helpTb
            // 
            this.helpTb.Location = new System.Drawing.Point(38, 90);
            this.helpTb.Multiline = true;
            this.helpTb.Name = "helpTb";
            this.helpTb.ReadOnly = true;
            this.helpTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.helpTb.Size = new System.Drawing.Size(294, 170);
            this.helpTb.TabIndex = 5;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 352);
            this.Controls.Add(this.helpTb);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.label1);
            this.Name = "HelpForm";
            this.Text = "Searchie [Help]";
            this.Load += new System.EventHandler(this.HelpForm_Load);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox helpTb;
    }
}