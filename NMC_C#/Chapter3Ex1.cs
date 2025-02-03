using System;
namespace calcDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---welcome and prompt---
            Console.Write("Welcome to the frequent shopper discount program!");
            Console.Write("Please enter your 4 digit PIN: ");
            double pin = double.Parse(Console.ReadLine());

            double discount = 0;

            //---spent amount---
            Console.Write("How much did you spend today?: ");
            double spent = double.Parse(Console.ReadLine());

            //---discount of pin---
            if (pin > 5000)
            {
                Console.WriteLine("You get 20% a discount!");
                discount = 0.80;
            }
            else if (pin > 1000)
            {
                Console.WriteLine("You get a 15% discount!");
                discount = 0.85;
            }
            else if (pin > 100)
            {
                Console.WriteLine("You get 10% a discount!");
                discount = 0.90;
            }
            else
            {
                Console.WriteLine("You get a 5% discount!");
                discount = 0.95;
            }

            double totalcost = (spent * discount);
            Console.WriteLine($"Your total cost is {totalcost:C}!");
        }
    }
}
