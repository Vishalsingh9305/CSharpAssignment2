using System;

namespace Assignment2.Tasks
{
    public static class PrintMaxElement
    {
        public static void Execute()
        {
            int[] array = { 10, 5, 20, 8, 15 }; // Predefined array
            int max = array[0];

            // Find maximum element in array
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            // Print maximum element
            Console.WriteLine($"Maximum Element in Array: {max}");
            Console.WriteLine();
        }
    }
}
