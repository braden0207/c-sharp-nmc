using System;
namespace PieceRatePay
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user to enter a whole number for the hours worked
            Console.Writeline("Enter a whole number for the hours worked: ");
            // create an integer variable named hours and set it equal to the value you read in from the console
            int hours = Console.ReadLine();
            // prompt the user to enter a number for the salary - this number may include decimal places
            Console.Writeline("Enter a number for the salary: ");
            // create a double variable named salary and set it equal to the value you read in from the console
            // calculate the workers hourly rate by dividing the salary by the hours worked and store the value
            // in a variable called averageHourlyPay (because you are dividing a double value by an integer, the data
            // type for the averageHourlyPay should be double)
            // using string interpolation to print the following phrase (numbers should be formatted to display 2 decimal places)
            // "You worked {hours} hours and were paid a salary of {salary}, your average hourly pay is {averageHourlyPay}”);
        } 
    }
}
