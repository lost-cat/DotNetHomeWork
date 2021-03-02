namespace HomeWork2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public static double GetMax(double[] arr)
        {
            double max = arr[0];
            foreach (var t in arr)
            {
                if (t > max)
                {
                    max = t;
                }
            }

            return max;
        }

        public static double GetMin(double[] arr)
        {
            double min = arr[0];
            foreach (var d in arr)
            {
                if (d < min)
                {
                    min = d;
                }
            }

            return min;
        }

        public static double GetAverage(double[] arr)
        {
            return GetTotal(arr) / arr.Length;
        }

        public static double GetTotal(double[] arr)
        {
            double total = 0;
            foreach (var d in arr)
            {
                total += d;
            }

            return total;
        }
    }
}