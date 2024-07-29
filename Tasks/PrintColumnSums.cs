using System;

namespace Assignment2.Tasks
{
    public static class PrintColumnSums
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

            // Calculate column sums
            int[] columnSums = new int[cols];
            for (int c = 0; c < cols; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    columnSums[c] += matrix[r, c];
                }
            }

            // Print column sums
            Console.WriteLine("Column Sums:");
            for (int c = 0; c < cols; c++)
            {
                Console.WriteLine($"Column {c + 1}: {columnSums[c]}");
            }
            Console.WriteLine();
        }
    }
}
