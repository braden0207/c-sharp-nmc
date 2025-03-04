using System;
namespace Chapter6BucketList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visits = new List<string> { "Greece", "Maine", "Vinland", "Japan" };
            string? location=String.Empty;
            string[] nameArr;
            int? menu=0;

            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1. Print sorted list\n2. Add to List\n3. Delete List\n4. Quit");
            menu = int.Parse(Console.ReadLine());
            while (menu != 4)
            {
                if (menu == 1)
                {
                    printList(visits);
                }
                else if (menu == 2)
                {
                    nameArr = addList();
                    visits.AddRange(nameArr);
                }
                else if (menu == 3)
                {
                    Console.Write("Enter the location you want removed from the list: ");
                    location = Console.ReadLine();
                    if (visits.Contains(location))
                    {
                        visits.Remove(location);
                        Console.WriteLine("The location has been deleted");
                    }
                    else
                        Console.WriteLine("Sorry, that location does not exist, please try again");
                }
                Console.WriteLine("1. Print sorted list\n2. Add to List\n3. Delete List\n4. Quit");
                menu = int.Parse(Console.ReadLine());
            }


        }
        static void printList(List<string> mem)
        {
            mem.Sort();
            foreach (string s in mem)
                Console.WriteLine(s);
            return;
        }
        static string[] addList()
        {
            Console.Write("How many places do you wish to add? ");
            int number = int.Parse(Console.ReadLine());
            string[] newlocations = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("location name? ");
                newlocations[i] = Console.ReadLine();

            }
            return newlocations;
        }
    }
}
