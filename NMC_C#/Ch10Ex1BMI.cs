using System;
using System.IO;

class Ch10Ex1BMI
{
    static void Main()
    {
        double height = 0, weight = 0, bmi = 0;

        try
        {
            Console.Write("Enter height in inches: ");
            height = Convert.ToDouble(Console.ReadLine());

            if (height < 12 || height > 96)
                throw new InvalidDataException("Height must be between 12 and 96 inches.");

            Console.Write("Enter weight in pounds: ");
            weight = Convert.ToDouble(Console.ReadLine());

            if (weight < 1 || weight > 777)
                throw new InvalidDataException("Weight must be between 1 and 777 pounds.");
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine($"Data error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            if (height > 0 && weight > 0)
            {
                bmi = (weight * 703) / (height * height);
                Console.WriteLine($"Your BMI is: {bmi:F2}");
            }
            Console.WriteLine("Program complete.");
        }
    }
}
