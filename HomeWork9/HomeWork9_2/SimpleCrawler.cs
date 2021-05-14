using System;
using System.Collections;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork9_2
{
    internal class SimpleCrawler
    {
        //下载队列
        private readonly ConcurrentQueue<string> queue = new ConcurrentQueue<string>();

        //已下载的urls
        private readonly BlockingCollection<string> downloadedUrls = new BlockingCollection<string>();
        private readonly string startUrl;
        private int count;

        public SimpleCrawler(string url)
        {
            startUrl = url;

            queue.Enqueue(startUrl);
        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");

            
            while (count <= 10 && !queue.IsEmpty)
            {
                queue.TryDequeue(out var url);


                if (url == null) break;
                Console.WriteLine("爬行" + url + "页面!");
                var task = DownLoad(url); // 下载
                count++;
                var html = task.Result;
                
                downloadedUrls.Add(url);
                Parse(html); //解析,并加入新的链接
            }

            Console.WriteLine("爬行结束");
        }

        private async Task<string> DownLoad(string url)
        {
            try
            {
                var webClient = new WebClient {Encoding = Encoding.UTF8};
                var str = await webClient.DownloadStringTaskAsync(url);
                var fileName = count.ToString();
                
                File.WriteAllText(fileName, str, Encoding.UTF8);
                return str;
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

                
                if (!downloadedUrls.Contains(strRef))
                {
                    queue.Enqueue(strRef);
                }
            }
        }
    }
}