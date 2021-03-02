using System;

namespace ConsoleApp1
{
    class Program
    {
        
        
        
        
        static void Main(string[] args)
        {
            double a, b;
            string s;
                                  
            while (true)
            {
                
                Console.WriteLine("请输入要计算的第一个数据");
                s = Console.ReadLine();
                a = double.Parse(s ?? string.Empty);
                Console.WriteLine("请输入要计算的第二个数据");
                s = Console.ReadLine();
                b = double.Parse(s ?? string.Empty);
                Console.WriteLine("请输入操作符");
                s = Console.ReadLine();
                switch (s)
                {
                    case "+":
                        Console.WriteLine($"结果为{a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"结果为{a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"结果为{a * b}");
                        break;
                    case "/":
                        Console.WriteLine($"结果为{a / b}");
                        break;
                }
            }
        }
    }
}