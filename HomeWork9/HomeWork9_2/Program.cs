using System;
using System.Net.Sockets;
using System.Text;

namespace HomeWork9_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var client = new TcpClient("127.0.0.1", 11000))
            {
                Console.WriteLine($"连接成功输入信息:");
                using (var stream = client.GetStream())
                {
                    string message;
                    do
                    {
                        message = Console.ReadLine();
                        var bytes = Encoding.UTF8.GetBytes(message ?? string.Empty);
                        stream.Write(bytes, 0, bytes.Length);
                    } while (message != "q");
                }
            }
        }
    }
}