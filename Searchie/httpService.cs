using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Searchie
{
    public class httpService
    {
        private int maxResults = 100;
        List<string> responseList;
        List<int> searchPositions;

        public httpService()
        {
            responseList = new List<string>();
            searchPositions = new List<int>();
        }

        public List<int> search(string keyword, string url)
        {
            //classID of the HTML document which contains URLs
            string classID = "BNeawe UPmit AP7Wnd";
            responseList = new List<string>();
            searchPositions = new List<int>();
            try
            {
                //Parameterised number of results and keywords
                string searchStr = String.Format("https://google.com.au/search?num={0}&q={1}", maxResults, keyword);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(searchStr);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                using (StreamReader responseReader = new StreamReader(responseStream))
                {
                    var content = responseReader.ReadToEnd();
                    string[] responseLines = content.Split("<div class=");
                    foreach (var s in responseLines)
                    {
                        //Adds the split line if it has matching classID
                        if (s.Contains(classID))
                        {
                            responseList.Add(s);
                        }
                    }

                }

                for (int i = 0; i < responseList.Count; i++)
                {
                    //Adds the position of the search if responseList[i] contains the URL
                    if (responseList[i].Contains(url))
                    {
                        searchPositions.Add(i);
                    }
                }

                if (searchPositions.Count == 0)
                {
                    searchPositions.Add(-1);
                }

            }//Exceptions captured using sentinel values 
            catch (Exception exception)
            {
                throw exception;
            }

            return searchPositions;

        }

    }
}
