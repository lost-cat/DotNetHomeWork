﻿using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HomeWork9_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SimpleCrawler crawler = new SimpleCrawler(@"https://blog.csdn.net");
            new Thread(crawler.Crawl).Start();

        }
    }
}