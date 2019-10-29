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
            this.urlLbl = new System.Windows.Forms.Label();
            this.keywordTb = new System.Windows.Forms.TextBox();
            this.urlTb = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.errorMsgLbl = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
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
            // urlLbl
            // 
            this.urlLbl.AutoSize = true;
            this.urlLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urlLbl.Location = new System.Drawing.Point(84, 113);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(42, 21);
            this.urlLbl.TabIndex = 2;
            this.urlLbl.Text = "URL:";
            // 
            // keywordTb
            // 
            this.keywordTb.Location = new System.Drawing.Point(128, 82);
            this.keywordTb.Name = "keywordTb";
            this.keywordTb.Size = new System.Drawing.Size(134, 23);
            this.keywordTb.TabIndex = 3;
            // 
            // urlTb
            // 
            this.urlTb.Location = new System.Drawing.Point(128, 111);
            this.urlTb.Name = "urlTb";
            this.urlTb.Size = new System.Drawing.Size(134, 23);
            this.urlTb.TabIndex = 4;
            this.urlTb.Enter += new System.EventHandler(this.urlTb_Enter);
            this.urlTb.Leave += new System.EventHandler(this.urlTb_Leave);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(69, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(153, 47);
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
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(277, 4);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(22, 23);
            this.helpBtn.TabIndex = 7;
            this.helpBtn.Text = "?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // Searchie
            // 
            this.ClientSize = new System.Drawing.Size(301, 227);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.errorMsgLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.urlTb);
            this.Controls.Add(this.keywordTb);
            this.Controls.Add(this.urlLbl);
            this.Controls.Add(this.keywordLbl);
            this.Controls.Add(this.searchBtn);
            this.Name = "Searchie";
            this.Text = "Searchie";

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label keywordLbl;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.TextBox keywordTb;
        private System.Windows.Forms.TextBox urlTb;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label errorMsgLbl;
        private System.Windows.Forms.Button helpBtn;
    }
}

