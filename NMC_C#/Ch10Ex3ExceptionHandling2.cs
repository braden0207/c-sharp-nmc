using System;
using System.IO;

namespace Ch10Ex3ExceptionHandling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // --Welcome and Prompt--  // 
                Console.WriteLine("Welcome to the frequent shopper discount program!");
                Console.Write("Please enter your 4-digit PIN: ");
                double pin = double.Parse(Console.ReadLine()); // May throw FormatException or OverflowException

                // -- Default Value -- //
                double discount = 0;

                // --Spent Amount -- //
                Console.Write("How much did you spend today?: ");
                double spent = double.Parse(Console.ReadLine()); // May throw FormatException

                // -- Validate Spent Amount -- // 
                if (spent <= 0)
                {
                    throw new InvalidDataException("You cannot receive a discount if you haven't spent any money!");
                }

                // --Discount of Pin-- //
                if (pin > 5000)
                {
                    Console.WriteLine("You get a 20% discount!");
                    discount = 0.80;
                }
                else if (pin > 1000)
                {
                    Console.WriteLine("You get a 15% discount!");
                    discount = 0.85;
                }
                else if (pin > 100)
                {
                    Console.WriteLine("You get a 10% discount!");
                    discount = 0.90;
                }
                else
                {
                    throw new Exception("You entered an invalid PIN."); // For PINs less than 100
                }

                // -- Calculate Total Cost -- // 
                double totalCost = spent * discount;
                Console.WriteLine($"Your total cost is {totalCost:C}!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input error: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Overflow error: {ex.Message}");
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine($"Data error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Have a great day or fun shopping!");
            }
        }
    }
}
