using System;

namespace Assignment2.Tasks
{
    public static class PrintRowSums
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

            // Calculate row sums
            int[] rowSums = new int[rows];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    rowSums[r] += matrix[r, c];
                }
            }

            // Print row sums
            Console.WriteLine("Row Sums:");
            for (int r = 0; r < rows; r++)
            {
                Console.WriteLine($"Row {r + 1}: {rowSums[r]}");
            }
            Console.WriteLine();
        }
    }
}
