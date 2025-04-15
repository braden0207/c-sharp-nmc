using System;

class Ch10Ex1BMI
{
    static void Main()
    {
        double height = 0, weight = 0, bmi = 0;

        try
        {
            Console.Write("Enter height in inches: ");
            height = Convert.ToDouble(Console.ReadLine());

            if (height < 24 || height > 100)
            {
                height = 65;
                Console.WriteLine("Height must be between 24 and 100 inches, default set to 65 inches.");
            }

            Console.Write("Enter weight in pounds: ");
            weight = Convert.ToDouble(Console.ReadLine());

            if (weight < 80 || weight > 700)
            {
                weight = 150;
                Console.WriteLine("Weight must be between 80 and 700 pounds, default set to 150 pounds.");
            }
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
