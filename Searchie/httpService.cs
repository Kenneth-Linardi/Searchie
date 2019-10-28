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
            string classID = "BNeawe UPmit AP7Wnd";
            try
            {
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
                        if (s.Contains(classID))
                        {
                            responseList.Add(s);
                        }
                    }

                }

                for (int i = 0; i < responseList.Count; i++)
                {
                    if (responseList[i].Contains(url))
                    {
                        searchPositions.Add(i);
                    }
                }

            } catch (WebException)
            {
                searchPositions.Add(-1);
            } catch (IOException)
            {
                searchPositions.Add(-2);
            } catch (OutOfMemoryException)
            {
                searchPositions.Add(-3);
            }

            return searchPositions;

        }

    }
}
