using System;

namespace HomeWork4_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new GenericList<int>();
            var total = 0;


            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(20));
            }

            int min;
            int max = min = list.Head.Data;
            list.ForEach(Console.WriteLine);

            list.ForEach(d => total += d);
            Console.WriteLine($"和为{total}");
            list.ForEach(d =>
            {
                if (min > d)
                {
                    min = d;
                }
            });
            Console.WriteLine($"最小值为{min}");
            list.ForEach(d =>
            {
                if (max < d)
                {
                    max = d;
                }
            });
            Console.WriteLine($"最大值为{max}");
        }
    }
}