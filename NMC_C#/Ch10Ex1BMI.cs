using System;
using System.Reflection;

class BMICalculator
{
    public static void Main()
    {
        int height, weight;
        Console.Write("Enter your height in inches (to the nearest whole number): ");
        while (!int.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Please enter a valid height");
        }
        Console.Write("Enter your weight to the nearest whole number: ");
        while (!int.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Please enter a valid weight: ");
        }
        // create try block
        if (height < 24 || height > 100)
        {
            height = 65;
            Console.WriteLine("Height is out of range, a default of 65 has been used.");
        }
        if (weight < 80 || weight > 700)
        {
            weight = 150;
            Console.WriteLine("Weight is out of range, a default of 150 has been used");
        }
        // end try block
        // create catch block
        decimal bmi = (weight * 703) / (height * height);
        Console.WriteLine($"Your BMI is: {Math.Floor(bmi)}");
        Console.WriteLine("For healthy adults BMI values between 18.5-24.9 indicate a healthy weight");

    }
}
