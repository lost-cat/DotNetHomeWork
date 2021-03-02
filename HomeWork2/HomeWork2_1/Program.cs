﻿using System;
using System.Linq;


namespace HomeWork2_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] data = new int[20];
            int count;
            GetData(data, out count);
            int[] primeFactors = GetPrimeFactors(data, count);
            var ints = primeFactors.Distinct().ToArray();
            foreach (var i in ints)
            {
                if (i==0)
                {
                    continue;
                }
                Console.WriteLine($"素数因子为{i}");
            }
        }


        public static void GetData(int[] arr, out int index)
        {
            index = 0;
            while (true)
            {
                Console.WriteLine("请输入数据，如果不想输入，请输入0");
                var s = Console.ReadLine();
                var data = int.Parse(s ?? string.Empty);
                if (data == 0)
                {
                    break;
                }

                arr[index++] = data;
            }
        }

        private static int[] GetPrimeFactors(int[] data, in int count)
        {
            int i;
            int index;
            index = 0;
            int[] result = new int[20];
            for (int j = 0; j < count; j++)
            {
                for (i = 1; i <= data[j]; i++)
                {
                    if (data[j] % i == 0)
                    {
                        var isPrime = IsPrime(i);
                        if (isPrime)
                        {
                            result[index] = i;
                            index++;
                        }
                    }
                }
            }

            return result;
        }


        private static bool IsPrime(int num)
        {
            if (num == 1)
            {
                return false;
            }

            int k = (int) Math.Sqrt(num);
            int i;
            for (i = 2; i <= k; i++)
            {
                if (num % i == 0)
                {
                    break;
                }
            }

            if (i > k)
            {
                return true;
            }

            return false;
        }
    }
}