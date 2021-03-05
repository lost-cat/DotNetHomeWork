using System.Linq;

namespace HomeWork2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public static double GetMax(double[] arr)
        {
            return arr.Max();
        }

        public static double GetMin(double[] arr)
        {
            return arr.Min();
        }

        public static double GetAverage(double[] arr)
        {
            return GetTotal(arr) / arr.Length;
        }

        public static double GetTotal(double[] arr)
        {
            return arr.Sum();
        }
    }
}