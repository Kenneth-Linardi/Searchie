using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Searchie
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            helpTb.Text = "\tWelcome to Searchie"+ 
                Environment.NewLine + "Searchie is an lightweight application that searches user inputted keywords to Google " +
                "for a specified URL and displays the search result positions if it's within the first 100 results!" +
                Environment.NewLine +
                Environment.NewLine + "Step 1: Enter your keyword you want to search on Google." +
                Environment.NewLine + "Step 2: Enter the URL you want to check." +
                Environment.NewLine + "Step 3: Click the search button.";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
