using System;

namespace Ch10Ex3ExceptionHandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many items would you like to enter?");
                int size = int.Parse(Console.ReadLine()); // May throw FormatException

                string[] members = new string[size];
                double[] dues = new double[size];

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Enter the member name: ");
                    members[i] = Console.ReadLine();

                    Console.WriteLine("Enter the dues: ");
                    dues[i] = double.Parse(Console.ReadLine()); // May throw FormatException
                }

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Member: {members[i]}  Dues: {dues[i]:C}");
                }
            }
            catch (FormatException ex)
            {
                // Handle invalid input (e.g., entering text instead of numbers)
                Console.WriteLine($"Input error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                // Always display this message, regardless of whether an exception occurred
                Console.WriteLine("Have a great day!");
            }
        }
    }
}
