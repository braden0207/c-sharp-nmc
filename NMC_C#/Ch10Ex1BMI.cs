using System;
using System.IO; // Required for InvalidDataException

class Ch10Ex1BMI
{
    static void Main()
    {
        double height = 0, weight = 0, bmi = 0;

        try
        {
            // Prompt for height
            Console.Write("Enter height in inches: ");
            height = Convert.ToDouble(Console.ReadLine());

            // Check height range and use default value if out of range
            if (height < 24 || height > 100)
            {
                Console.WriteLine("Height must be between 24 and 100 inches. Default set to 65 inches.");
                height = 65; // Default value
                throw new InvalidDataException("Height was out of range.");
            }

            // Prompt for weight
            Console.Write("Enter weight in pounds: ");
            weight = Convert.ToDouble(Console.ReadLine());

            // Check weight range and use default value if out of range
            if (weight < 80 || weight > 700)
            {
                Console.WriteLine("Weight must be between 80 and 700 pounds. Default set to 150 pounds.");
                weight = 150; // Default value
                throw new InvalidDataException("Weight was out of range.");
            }
        }
        catch (InvalidDataException ex)
        {
            // Handle InvalidDataException
            Console.WriteLine($"Data error: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handle any other unexpected exceptions
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            // Always calculate and display BMI if height and weight are valid
            if (height > 0 && weight > 0)
            {
                bmi = (weight * 703) / (height * height);
                Console.WriteLine($"Your BMI is: {bmi:F2}");
            }
            Console.WriteLine("Program complete.");
        }
    }
}
