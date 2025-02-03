using System;
namespace trainLocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Welcome---//
            Console.WriteLine("Welcome to the Conference Center!");
            //--Prompt--//
            Console.Write("Please enter your trainee number to receive the location of your first session: ");
            int numbers = Convert.ToInt32(Console.ReadLine());

            //---If Number---//
            if (numbers > 500)
            Console.WriteLine("Proceed to training room 7A");
            else if (numbers > 300)
            Console.WriteLine("Proceed to the main ballroom");
            else if (numbers > 200)
            Console.WriteLine("Proceed to the gymnasium");
            else if (numbers > 100)
            Console.WriteLine("Proceed to training room 6A");
            else
            Console.WriteLine("Proceed to training room 2B");
            //-Lunch-//
            Console.WriteLine('Lunch will be served from 11:30 to 1:00pm');
            Console.Write('Please select your preferred cuisine: 1 = Italian, 2 = Vegan, 3 = Chinese, 4 = French, 5 = Chef\'s Surprise');
            




        }
    }
}
