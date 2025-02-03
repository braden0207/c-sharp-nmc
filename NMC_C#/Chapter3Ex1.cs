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
      //variables
       double pin = double.Parse(Console.ReadLine());
       double discount = 0;

       //---discount of pin---
       if (pin > 5000)
        Console.WriteLine("You get 20% a discount!");
        discount = 0.80;
       else if (pin > 1000)
        Console.WriteLine("You get a 15% discount!");
        discount = 0.85;
        else if (pin > 100)
        Console.WriteLine("You get 10% a discount!");
        discount = 0.90;
       else
        Console.WriteLine("You get a 5% discount!");
        discount = 0.95;

      //spent amount
      Console.Write("Please enter the amount you spent: ");
      double spent = double.Parse(Console.ReadLine());
      
      //double totalcost = spent-(spent * //discount);
     //Console.Write($"The total cost of your amount spent is {totalcost}");
    }
  }
}

//You are writing a program that will calculate a discount for shoppers based upon the
//pin number they enter. Create a new C# console application and name it Chapter3Ex1.
//2. The program should do the following:
//a) Welcome the user to the frequent shopper discount program
//b) Prompt the user for their 4 digit pin
//c) Read in the pin and use a nested if…else to determine the discount. The rules are as
//follows:
//pin numbers > 5000 receive a 20% discount
//pin numbers > 1000 receive a 15% discount
//pin numbers > 100 receive a 10% discount
//everyone else with a pin receives a 5% discount
//d) Prompt the user for the amount they spent
//e) Read in the amount spent and store the value.
//f) Calculate the total cost = amount spent – ( amount spent * discount)
//g) Write out the customer’s total cost using formatted output.
//g) Write out the customer’s total cost using formatted output.
//e) Read in the amount spent and store the value.
//f) Calculate the total cost = amount spent – ( amount spent * discount)
//g) Write out the customer’s total cost using formatted output.
