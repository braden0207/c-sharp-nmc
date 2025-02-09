using System;
     public class Program
     {
          public static void Main()
          {
               double price = 0;
               int i = 1;
               //convert to while loop
               while(i <= 5)
               {
                    Console.WriteLine($"Enter the price of item# {i}");
                    price += double.Parse(Console.ReadLine());
                    i++;
               }
               Console.WriteLine($"Your total for {i-1} items is: ${price}");
               //convert to do...while loop
               price = 0;
               i = 1;
               do
               {
                    Console.WriteLine($"Enter the price of item# {i}");
                    price += double.Parse(Console.ReadLine());
                    i++;
               } while (i <= 5);
               Console.WriteLine($"Your total for {i-1} items is: ${price}");
          }
     }
