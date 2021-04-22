using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HomeWork9_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var crawler = new Crawler("www.bilibili.com", 100);

            var listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 10000);
            listener.Start();

            using (var client = listener.AcceptTcpClient())
            {
                Console.WriteLine($"建立连接");
                using (var stream = client.GetStream())
                {
                    string message;
                    do
                    {
                        var bytes = new byte[1024];
                        var length = stream.Read(bytes, 0, 1024);
                        message = Encoding.UTF8.GetString(bytes, 0, length);
                        Console.WriteLine(message);
                    } while (!string.Equals(message, "q", StringComparison.Ordinal));
                }
            }

            listener.Stop();
        }
    }
}