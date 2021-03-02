﻿using System;

namespace HomeWork2_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var bools = SieveOfEratosthenes();
            for (var i = 2; i <101; i++)
            {
                if (bools[i])
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool[] SieveOfEratosthenes()
        {
            bool[] isPrime = new bool[110];
            for (var i = 0; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            isPrime[0] = false;
            isPrime[1] = false;
            for (int i = 2; i < 101; i++)
            {
                for (int j = i + 1; j < 101; j++)
                {
                    if (j % i == 0)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            return isPrime;
        }
    }
}