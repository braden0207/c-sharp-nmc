using System;

namespace Chapter5Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- greet user--//
            Console.WriteLine("Hello, I'm here to help you with math problems");
            int input = Menu();

            while (input != '3')
            {
                if (input == '1')
                {
                    Addition();
                }
                else if (input == '2')
                {
                    Subtraction();
                }

                input = Menu();
            }
        }
        //--make menu--//
        static int Menu()
        {
            Console.WriteLine("Please make a selection from our menu.");
            Console.WriteLine("1 for addition\n2 for subtraction\n3 to quit");
            int input = Console.Read();
            Console.ReadLine(); // removes newline from queue
            return Convert.ToChar(input);
        }
        //--make addition to use--//
        static void Addition()
        {
            Random rnd = new Random();
            int n1 = rnd.Next(1, 100);
            int n2 = rnd.Next(1, 100);
            int correctAns = n1 + n2;
            Console.Write($"The sum of {n1} + {n2} = ");
            int answer = int.Parse(Console.ReadLine());
            
            //--while answer wrong--//
            while (answer != correctAns)
            {
                Console.WriteLine("Oops, incorrect! Try again.");
                Console.Write($"The sum of {n1} + {n2} = ");
                answer = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Great answer!");
        }
        
        //--make subtraction to use--//
        static void Subtraction()
        {
            Random rnd = new Random();
            int n1 = rnd.Next(1, 100);
            int n2 = rnd.Next(1, 100);
            int correctAns = n1 - n2;
            Console.Write($"The result of {n1} - {n2} = ");
            int answer = int.Parse(Console.ReadLine());
            
            //--while answer wrong--//
            while (answer != correctAns)
            {
                Console.WriteLine("Wrong answer, please try again.");
                Console.Write($"The result of {n1} - {n2} = ");
                answer = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fabulous!");
        }
    }
}
