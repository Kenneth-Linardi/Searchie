namespace Searchie
{
    partial class Searchie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBtn = new System.Windows.Forms.Button();
            this.keywordLbl = new System.Windows.Forms.Label();
            this.uriLbl = new System.Windows.Forms.Label();
            this.keywordTb = new System.Windows.Forms.TextBox();
            this.uriTb = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.errorMsgLbl = new System.Windows.Forms.Label();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(109, 171);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(82, 31);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // keywordLbl
            // 
            this.keywordLbl.AutoSize = true;
            this.keywordLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keywordLbl.Location = new System.Drawing.Point(48, 80);
            this.keywordLbl.Name = "keywordLbl";
            this.keywordLbl.Size = new System.Drawing.Size(74, 21);
            this.keywordLbl.TabIndex = 1;
            this.keywordLbl.Text = "Keyword:";
            // 
            // uriLbl
            // 
            this.uriLbl.AutoSize = true;
            this.uriLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uriLbl.Location = new System.Drawing.Point(84, 113);
            this.uriLbl.Name = "uriLbl";
            this.uriLbl.Size = new System.Drawing.Size(38, 21);
            this.uriLbl.TabIndex = 2;
            this.uriLbl.Text = "URI:";
            // 
            // keywordTb
            // 
            this.keywordTb.Location = new System.Drawing.Point(128, 82);
            this.keywordTb.Name = "keywordTb";
            this.keywordTb.Size = new System.Drawing.Size(134, 23);
            this.keywordTb.TabIndex = 3;
            // 
            // uriTb
            // 
            this.uriTb.Location = new System.Drawing.Point(128, 111);
            this.uriTb.Name = "uriTb";
            this.uriTb.Size = new System.Drawing.Size(134, 23);
            this.uriTb.TabIndex = 4;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(94, 20);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(124, 35);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Text = "Searchie";
            // 
            // errorMsgLbl
            // 
            this.errorMsgLbl.AutoSize = true;
            this.errorMsgLbl.Location = new System.Drawing.Point(84, 147);
            this.errorMsgLbl.Name = "errorMsgLbl";
            this.errorMsgLbl.Size = new System.Drawing.Size(0, 15);
            this.errorMsgLbl.TabIndex = 6;
            // 
            // Searchie
            // 
            this.ClientSize = new System.Drawing.Size(301, 227);
            this.Controls.Add(this.errorMsgLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.uriTb);
            this.Controls.Add(this.keywordTb);
            this.Controls.Add(this.uriLbl);
            this.Controls.Add(this.keywordLbl);
            this.Controls.Add(this.searchBtn);
            this.Name = "Searchie";
            this.Text = "Searchie";

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label keywordLbl;
        private System.Windows.Forms.Label uriLbl;
        private System.Windows.Forms.TextBox keywordTb;
        private System.Windows.Forms.TextBox uriTb;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label errorMsgLbl;
    }
}

