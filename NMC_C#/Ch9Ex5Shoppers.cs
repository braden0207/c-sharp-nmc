using System;
using System.Collections.Generic;

namespace Shoppers
{
    class ShoppingClub
    {
        // private fields
        private string _Name;
        private int _Age;
        private bool _AgeRestriction = false;

        // Get methods for private fields
        public string GetName()
        {
            return _Name;
        }
        public int GetAge()
        {
            return _Age;
        }
        public bool GetAgeRestriction()
        {
            return _AgeRestriction;
        }

        // Set methods for private fields
        public void SetName(string Name)
        {
            _Name = Name;
        }
        public void SetAge(int Age)
        {
            _Age = Age;
            if (Age < 21)
                _AgeRestriction = true;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            ShoppingClub shopper1 = new ShoppingClub();
            ShoppingClub shopper2 = new ShoppingClub();
            ShoppingClub shopper3 = new ShoppingClub();

            Console.Write("Name: ");
            shopper1.SetName(Console.ReadLine());
            Console.Write("Age: ");
            shopper1.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("Name: ");
            shopper2.SetName(Console.ReadLine());
            Console.Write("Age: ");
            shopper2.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("Name: ");
            shopper3.SetName(Console.ReadLine());
            Console.Write("Age: ");
            shopper3.SetAge(int.Parse(Console.ReadLine()));

            Console.WriteLine("Here's your shopping group");

            Console.WriteLine($"Name: {shopper1.GetName()}  Age: {shopper1.GetAge()}");
            if (shopper1.GetAgeRestriction())
                Console.WriteLine("This shopper cannot purchase alcohol!");

            Console.WriteLine($"Name: {shopper2.GetName()}  Age: {shopper2.GetAge()}");
            if (shopper2.GetAgeRestriction())
                Console.WriteLine("This shopper cannot purchase alcohol!");

            Console.WriteLine($"Name: {shopper3.GetName()}  Age: {shopper3.GetAge()}");
            if (shopper3.GetAgeRestriction())
                Console.WriteLine("This shopper cannot purchase alcohol!");

        }
    }
}
