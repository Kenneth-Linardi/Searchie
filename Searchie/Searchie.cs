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
            urlTb.ForeColor = SystemColors.GrayText;
            urlTb.Text = "https://www.";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keywords = keywordTb.Text;
            string url = urlTb.Text;
            try
            {
                //Checks for valid user inputs
                if (CheckUrl(url) && keywords != null)
                {
                    List<int> searchResults = new List<int>();

                    //Replaces spaces with "+" for URL usage
                    string nospaceKeyword = keywords.Replace(" ", "+");
                    searchResults = myService.search(nospaceKeyword, url);
                    string messageBoxStr = "";

                    //Determines whether the value in searchResults is a sentinel value or not.
                    if (searchResults[0] > 0)
                    {
                        messageBoxStr = String.Format("The URL ({0}) has come up {1} time(s) in the first 100 results.", url, searchResults.Count);
                        messageBoxStr += "\nIn position(s):";
                        foreach (int position in searchResults)
                        {
                            messageBoxStr += " " + position;
                        }
                        MessageBox.Show(messageBoxStr, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (searchResults[0] < 0)
                    {
                        MessageBox.Show(messageBoxStr, "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    errorMsgLbl.Text = "Invalid URL or Keywords";
                    errorMsgLbl.ForeColor = Color.Red;
                }
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /*
         * Autofills the textbox with a hint text 
         */
        private void urlTb_Leave(object sender, EventArgs e)
        {
            urlTb.ForeColor = SystemColors.GrayText;
            if (!urlTb.Text.Contains("https://www."))
            {
                urlTb.Text = "https://www.";
            }
        }

        /*
         * Sets a visual indication when the textbox is in focus.
         */
        private void urlTb_Enter(object sender, EventArgs e)
        {
            urlTb.ForeColor = Color.Black;
        }
    }
}
