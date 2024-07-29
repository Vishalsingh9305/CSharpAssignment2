using System;

namespace Assignment2.Tasks
{
    public static class PrintSumAndAverageOfArray
    {
        public static void Execute()
        {
            int[] array = { 5, 10, 15, 20, 25 }; // Predefined array
            int sum = 0;

            // Calculate sum of elements
            foreach (int number in array)
            {
                sum += number;
            }

            // Calculate average of elements (cast one operand to double to get a double result)
            double average = (double)sum / array.Length;

            // Print sum and average with appropriate formatting
            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine($"Average of elements: {average:F2}"); // F2 ensures two decimal places
            Console.WriteLine();
        }
    }
}
