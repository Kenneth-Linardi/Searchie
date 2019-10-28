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

            //Checks for valid user inputs
            if (CheckUrl(url) && keywords != null)
            {
                List<int> searchResults = new List<int>();

                //Replaces spaces with "+" for URL usage
                string nospaceKeyword = keywords.Replace(" ", "+");
                searchResults = myService.search(nospaceKeyword, url);
                string messageBoxStr = "";

                //Determines whether the value in searchResults is a sentinel value or not.
                if (searchResults[0] >= 0)
                {
                    if (searchResults[0] > 0)
                    {
                        messageBoxStr = String.Format("The URL ({0}) has come up {1} time(s) in the first 100 results.", url, searchResults.Count);
                        messageBoxStr += "\nIn position(s):";
                        foreach (int position in searchResults)
                        {
                            messageBoxStr += " " + position;
                        }
                    } else
                    {
                        messageBoxStr = String.Format("The URL ({0}) has come up 0 times in the first 100 results.", url);
                    }
                    MessageBox.Show(messageBoxStr, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /*
         * CheckUrl uses .NETs Uri.TryCreate method to return a boolean value if the URL is valid or not.
         */
        public bool CheckUrl(string url)
        {
            Uri outUri;
            return (Uri.TryCreate(url, UriKind.Absolute, out outUri) && outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }

        /*
         * Triggered when helpBtn is clicked, the helpForm will show without closing the Searchie Form.
         */
        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
