using System;

namespace Assignment2.Tasks
{
    public static class PrintMatrixSum
    {
        public static void Execute()
        {
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;

            // Calculate sum of matrix elements
            foreach (int num in matrix)
            {
                sum += num;
            }

            // Print sum of matrix
            Console.WriteLine($"Sum of 3x3 Matrix: {sum}");
            Console.WriteLine();
        }
    }
}
