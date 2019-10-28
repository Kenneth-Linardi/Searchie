using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Searchie
{
    public partial class Searchie : Form
    {
        httpService myService;
        public Searchie(httpService httpService)
        {
            InitializeComponent();
            myService = httpService;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keywords = keywordTb.Text;
            string url = uriTb.Text;

            if (CheckUrl(url) && keywords != null)
            {
                List<int> searchResults = new List<int>();
                string nospaceKeyword = keywords.Replace(" ", "+");
                searchResults = myService.search(nospaceKeyword, url);
                string messageBoxStr = String.Format("The URL ({0}) has come up {1} times in the first 100 results.", url,searchResults.Count);
                if (searchResults[0] >= 0)
                {
                    if (searchResults[0] > 0)
                    {
                        messageBoxStr += "\nIn positions:";
                        foreach (int position in searchResults)
                        {
                            messageBoxStr += " " + position;
                        }
                    }
                    MessageBox.Show(messageBoxStr, "Search Results", MessageBoxButtons.OK);
                } else if (searchResults[0] < 0)
                {
                    switch (searchResults[0])
                    {
                        case -1:
                            messageBoxStr = "Web Exception! Please make sure you have a stable internet connection";
                            break;
                        case -2:
                            messageBoxStr = "IO Exception! Stream Reader cannot process stream due to an I/O error";
                            break;
                        case -3:
                            messageBoxStr = "Out Of Memory Exception! Stream Reader cannot process stream due to an OutOfMemory error";
                            break;
                    }
                    MessageBox.Show(messageBoxStr, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } else
            {
                errorMsgLbl.Text = "Invalid URL or Keywords";
                errorMsgLbl.ForeColor = Color.Red;
            }
        }

        public bool CheckUrl(string uri)
        {
            Uri outUri;
            return (Uri.TryCreate(uri, UriKind.Absolute, out outUri));
        }
         

    }
}
