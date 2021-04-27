using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork9_2
{
    class SimpleCrawler
    {
        private readonly Hashtable urls = new Hashtable();
        private readonly string startUrl;
        private int count;
        
        public SimpleCrawler(string url)
        {
            startUrl = url;
            urls.Add(startUrl, false);
        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool) urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                var html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html); //解析,并加入新的链接
            }

            Console.WriteLine("爬行结束");
        }

        private string DownLoad(string url)
        {
            try
            {
                var webClient = new WebClient {Encoding = Encoding.UTF8};
                var html = webClient.DownloadString(url);
                var fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            var strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(jsp|html|aspx)[""']";
            var matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (!strRef.StartsWith(startUrl))
                {
                    continue;
                }

                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}