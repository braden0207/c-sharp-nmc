using System;
namespace calcDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---welcome and prompt---
            Console.Write("Welcome to the frequent shopper discount program!");
            Console.Write("Please enter your 4 digit pin: ");
            double pin = double.Parse(Console.ReadLine());

            double discount = 0;

            //---spent amount---
            Console.Write("Please enter the amount you spent: ");
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

            double totalcost = spent - (spent * discount);
            Console.WriteLine($"The total cost of your amount spent is {totalcost:C}");
        }
    }
}
