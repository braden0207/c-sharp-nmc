using System;
namespace FunWithMath
{
    class MathMethodExample
    {
        // Main Method
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Magic");
            int input = getMenu();
            while (input != 7)
            {
            //Generate random numbers
            Random rnd = new Random();
            int n1 = rnd.Next(1, 100);
            int n2 = rnd.Next(1, 100);
            switch (input)
            {
            case 1:
            double highest = Math.Max(n1, n2);
            Console.WriteLine($"The first number is: {n1} and the second is {n2}");
            Console.WriteLine($"The largest number is: {highest}");
            break;
            case 2:
            Console.WriteLine($"The first number is: {n1} and the second is {n2}");
            double lowest = Math.Min(n1, n2);
            Console.WriteLine($"The lowest number is: {lowest}");
            break;

            case 3:
             double num1 = rnd.NextDouble();
            double num2 = rnd.NextDouble();
            Console.WriteLine($"The first number is: {num1} and the second is {num2}");
            Console.WriteLine($"The value {num1} rounded to the second decimal place is:" +
             $" {Math.Round(num1, 2)}");
             Console.WriteLine($"The value {num2} rounded to the second decimal place is:" +
             $" {Math.Round(num2, 2)}");
             break;
             case 4:
             Console.WriteLine($"The first number is: {n1} and the second is {n2}");
            Console.WriteLine($"The value {n1} raised to the 2nd power is {Math.Pow(n1, 2)}");
            Console.WriteLine($"The value {n2} raised to the 3rd power is {Math.Pow(n2, 3)}");
            break;
             case 5:
             Int32 remainder, dividend = n1, divisor = 2;
            bool success;
            Math.DivRem(dividend, divisor, out remainder);
            if (remainder == 0)
             Console.WriteLine($"The number, {n1}, is even");
             else
             Console.WriteLine($"The number, {n1}, is odd");
             break;
             default:
             Console.WriteLine($"The first number is: {n1} and the second is {n2}");
            Console.WriteLine($"The square root of {n1} is {Math.Sqrt(n1)}");
            Console.WriteLine($"The square root of {n2} is {Math.Sqrt(n2)}");
            break;
             }// end switch
             input = getMenu();
             } // end loop
        }// end main method
