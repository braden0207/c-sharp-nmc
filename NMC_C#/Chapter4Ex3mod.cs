using System;

namespace Chapter4Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-- Welcome the customer --//
            Console.WriteLine("Welcome to our ice cream shop!");

            //-- Get the number of cones --//
            Console.WriteLine("How many cones are you purchasing today?");
            int coneAmount = int.Parse(Console.ReadLine());

            //-- Arrays for cone size, flavors, and prices
            char[] coneSize = new char[coneAmount];
            string[] flavors = new string[coneAmount];
            double[] prices = new double[coneAmount];

            double grandTotal = 0;

            //-- Process each cone --//
            for (int i = 0; i < coneAmount; i++)
            {
                Console.WriteLine("What size cone do you want?");
                Console.WriteLine("s = small, m = medium, l = large");

                coneSize[i] = char.ToLower(char.Parse(Console.ReadLine()));

                // Validate cone size --//
                while (coneSize[i] != 's' && coneSize[i] != 'm' && coneSize[i] != 'l')
                {
                    Console.WriteLine("The size must be s, m, or l. Please try again!");
                    coneSize[i] = char.ToLower(char.Parse(Console.ReadLine()));
                }

                // Determine price and get flavors
                switch (coneSize[i])
                {
                    case 's':
                        Console.WriteLine("What flavor would you like?");
                        flavors[i] = Console.ReadLine();
                        prices[i] = 2.50;
                        break;

                    case 'm':
                        flavors[i] = "";
                        for (int n = 0; n < 2; n++)
                        {
                            Console.Write($"Enter flavor number {n + 1}: ");
                            flavors[i] += Console.ReadLine() + (n == 0 ? "\n" : "");
                        }
                        prices[i] = 3.00;
                        break;

                    case 'l':
                        flavors[i] = "";
                        for (int n = 0; n < 3; n++)
                        {
                            Console.Write($"Enter flavor number {n + 1}: ");
                            flavors[i] += Console.ReadLine() + (n < 2 ? "\n" : "");
                        }
                        prices[i] = 3.50;
                        break;
                }

                //-- say cone is done --//
                Console.WriteLine($"Cone #{i + 1} is done.");
                grandTotal += prices[i];
            }

            //-- Print there order --//
            Console.WriteLine("Order Summary:");
            for (int i = 0; i < coneAmount; i++)
            {
                string size = coneSize[i] == 's' ? "small" : coneSize[i] == 'm' ? "medium" : "large";
                Console.WriteLine($"------------------Cone #{i + 1}--------------------");
                Console.WriteLine($"Size: {size}");
                Console.WriteLine($"Flavor: \n{flavors[i]}");
                Console.WriteLine($"Price: {prices[i]:C}");
            }

            //-- print total price --//
            Console.WriteLine($"--------------------------------------------");
            Console.WriteLine($"Thank you for your purchase, your total is: {grandTotal:C}");
        }
    }
}
