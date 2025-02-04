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
            int number = Convert.ToInt32(Console.ReadLine());

            //---If Number---//
            if (number > 500)
            Console.WriteLine("Proceed to training room 7A");
            else if (number > 300)
            Console.WriteLine("Proceed to the main ballroom");
            else if (number > 200)
            Console.WriteLine("Proceed to the gymnasium");
            else if (number > 100)
            Console.WriteLine("Proceed to training room 6A");
            else
            Console.WriteLine("Proceed to training room 2B");
            //-Lunch-//
            Console.WriteLine("Lunch will be served from 11:30 to 1:00pm");
            Console.Write("Please select your preferred cuisine: 1 = Italian, 2 = Vegan, 3 = Chinese, 4 = French, 5 = Chef\'s Surprise");
            int cuisine = Convert.ToInt32(Console.ReadLine());

            switch (cuisine)
            {
                    case 1:
                        Console.WriteLine("Italian lunch is in Courtyard A");
                        break;
                    case 2:
                        Console.WriteLine("Vegan lunch is in Courtyard B");
                        break;
                    case 3:
                        Console.WriteLine("Chinese lunch is in Courtyard C");
                        break;
                    case 4:
                        Console.WriteLine("French lunch is in the Upper Deck");
                        break;
                    default:
                        Console.WriteLine("Chef’s Surprise is in the Tower Restaurant");
                        break;
            }

        }
    }
}
