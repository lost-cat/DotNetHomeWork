namespace HomeWork2_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
        public static bool IsToeplitzMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (var j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1]) continue;
                    return false;
                }
            }

            return true;

        }
    }
}