using System;

class Ch7MathMethods
{
    static void Main()
    {
        int n1, num2;

        // Input validation
        Console.Write("Enter first integer: ");
        while (!int.TryParse(Console.ReadLine(), out n1))
        {
            Console.Write("Invalid input. Enter a valid integer: ");
        }

        Console.Write("Enter second integer: ");
        while (!int.TryParse(Console.ReadLine(), out n2))
        {
            Console.Write("Invalid input. Enter a valid integer: ");
        }

        // max and min
        Console.WriteLine($"The Larger number is: {Math.Max(n1, n2)}");
        Console.WriteLine($"The Smaller number is: {Math.Min(n1, n2)}");

        // raised to power
        Console.WriteLine($"{n1} raised to the power of {n2}: {Math.Pow(n1, n2)}");
        Console.WriteLine($"{n2} raised to the power of {n1}: {Math.Pow(n2, n1)}");

        // Math.Sqrt()
        Console.WriteLine($"Square root of {n1}: {Math.Sqrt(n1)}");
        Console.WriteLine($"Square root of {n2}: {Math.Sqrt(n2)}");

        // Division and remainder calculation
        if (n2 > 0)
        {
            Console.WriteLine($"{n1} / {n2} = {n1/n2} with remainder of {n1%n2}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero or a negative number.");
        }
    }
}
