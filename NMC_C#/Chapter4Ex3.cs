using System;
namespace Chapter4Ex3
{
     internal class Program
     {
          static void Main(string[] args)
          {
               // The program should do the following:
               // • Welcome the customer
               Console.WriteLine("Welcome to our ice cream shop!");
               // • Determine how many ice cream cones the customer is going to purchase.
               Console.WriteLine("How many cones are you purchasing today?");
               int coneAmount = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("What size cone do you want?");
               string? coneSize= Console.ReadLine();

               int flavors = 0;
               double Price = 0;

               switch (coneSize)
               {
                    case "small":
                         flavors = 1;
                         Price = 2.50;
                         break;

                    case "medium":
                         flavors = 2;
                         Price = 3.00;
                         break;
                    default:
                         flavors = 3;
                         Price = 3.50;
                         break;
               }
               for (int flavorCount = 0; flavorCount< flavors; flavorCount++)
               {
                    Console.WriteLine("What is your first flavor?");
                    string? flavorString = Console.ReadLine();
                    Console.WriteLine("What is your second flavor?");
                    flavorString = Console.ReadLine();
                    Console.WriteLine("What is your third flavor?");
                    flavorString = Console.ReadLine();

               }
               Double totalPrice = Price;
               Console.WriteLine($"Thank you for your purchase, your total is: ${totalPrice}");
               // • For each ice cream cone the customer purchases, you need to know:
               // o The size of the cone
               // o The flavor (or flavors) of ice cream
               // • You should total the cost of the cones and let the customer know how much to
               // pay. The amount should be formatted with 2 decimal places.

               // You are writing code for an ice cream shop. The shop sells 3 different size cones: small,
               // medium and large. Small cones get 1 scoop of ice-cream. Medium cones can have 2
               // scoops with 2 different flavors. Large cones can have 3 scoops with 3 different flavors.
               // The cost of a small cone is 2.50. The cost of a medium cone is 3.00. The cost of a large
               // cone is 3.50

               // This program is similar to Programming Example 1 For Loops, Exercise #2. You will need to
               // create a For loop to create all the cones the customer wants. Inside the for loop, you will
               // ask for the size of the cone. You should use a switch statement to check the size and then
               // ask for the flavor or flavors of ice cream AND to add the dollar amount to a total. The For
               // Loop example includes prompting the user for the price and quantity, in addition to adding
               // to a total. It doesn’t include a switch statement (you will need to look at chapter 3 for
               // information on that).


               //------Sample output------//
               // Welcome to our ice cream shop!
               // How many cones are you purchasing today?
               // 2
               // What size cone do you want?
               // large
               // What is your first flavor?
               // chocolate chip
               // What is your second flavor?
               // chocolate
               // What is your third flavor?
               // cookie dough
               // Cone # 1 is done.
               // What size cone do you want?
               // medium
               // What is your first flavor?
               // cinnamon
               // What is your second flavor?
               // vanilla
               // Cone # 2 is done.
               // Thank you for your purchase, your total is: $6.50
          }
     }
}

