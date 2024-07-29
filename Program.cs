using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Print Sum and Average of Elements of an Array");
                Console.WriteLine("2. Display Sum of a 3x3 Matrix");
                Console.WriteLine("3. Find the Maximum Element of an Integer Array");
                Console.WriteLine("4. Print Column-wise Sum of Elements of a 2D Array");
                Console.WriteLine("5. Print Row-wise Sum of Elements of a 2D Array");
                Console.WriteLine("0. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting program...");
                        return;
                    case 1:
                        Tasks.PrintSumAndAverageOfArray.Execute();
                        break;
                    case 2:
                        Tasks.PrintMatrixSum.Execute();
                        break;
                    case 3:
                        Tasks.PrintMaxElement.Execute();
                        break;
                    case 4:
                        Tasks.PrintColumnSums.Execute();
                        break;
                    case 5:
                        Tasks.PrintRowSums.Execute();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 to 5.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // Clears console for next iteration
            }
        }
    }
}
