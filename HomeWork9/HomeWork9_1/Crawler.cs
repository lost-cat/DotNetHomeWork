using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork9_1
{
    public class Crawler
    {
        private int count;
        private Hashtable urls = new Hashtable();

        public Crawler(string startUrl, int count)
        {
            urls.Add(startUrl, false);
            this.count = count;
        }

        private void Crawl()
        {
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool) urls[url])
                    {
                        continue;
                    }

                    current = url;
                }

                if (current == null || count > 1000)
                {
                    break;
                }

                Console.WriteLine("爬行" + current + "页面");
                var html = DownLoad(current);
                urls[current] = true;
                count++;
                Parse(html);
            }

            Console.WriteLine("爬行结束");
        }

        private string DownLoad(string url)
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                var html = client.DownloadString(url);
                var fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }

        private void Parse(string html)
        {
            var strRef = @"(href|HREF)[]*=[]*[""'][^""#>]+[""']";
            var matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\'', '#', ' ', '>');
                if (strRef.Length == 0)
                {
                    continue;
                }

                if (urls[strRef] == null)
                {
                    urls[strRef] = false;
                }
            }
        }
    }
}