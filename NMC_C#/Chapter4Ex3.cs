using System;

namespace Chapter4Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--Welcome the customer
            Console.WriteLine("Welcome to our ice cream shop!");

            //--cones the customer is going to purchase.
            Console.WriteLine("How many cones are you purchasing today?");
            int coneAmount = Convert.ToInt32(Console.ReadLine());

            //variable
            double totalPrice = 0;

            //-- for loop to know:
            //--size of the cone
            //--flavor (or flavors) of ice cream
            for (int coneNumber = 1; coneNumber <= coneAmount; coneNumber++)
            {
                Console.WriteLine($"What size cone do you want for Cone #{coneNumber}?");

                string? coneSize = Console.ReadLine();

                int flavors = 0;
                double price = 0;

                //--cone size switch
                switch (coneSize?.ToLower())
                {
                    case "small":
                        flavors = 1;
                        price = 2.50;
                        break;

                    case "medium":
                        flavors = 2;
                        price = 3.00;
                        break;

                    default:
                    flavors = 3;
                        price = 3.50;
                        break;
                }

                //--Ask for flavors by amount of scoops
                for (int flavorCount = 1; flavorCount <= flavors; flavorCount++)//--flavor count 1 so print #1 instead #0
                {
                    Console.WriteLine($"What is your flavor #{flavorCount}?");
                    string? flavorString = Console.ReadLine();
                }

                //--Cone is done
                Console.WriteLine($"Cone #{coneNumber} is done.");

                //--get total price
                totalPrice += price;
            }

            //--total display
            Console.WriteLine($"Thank you for your purchase, your total is: ${totalPrice:F2}");
        }
    }
}
