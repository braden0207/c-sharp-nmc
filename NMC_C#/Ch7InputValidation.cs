using System;
namespace Ch7InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> members = new List<string> { "Mickey", "Minnie", "Donald", "Daisy" };
            string? name=String.Empty;
            string[] nameArr;
            int menu;

            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1. Print sorted list\n2. Add to List\n3. Delete List\n4. Quit");
            string stringMenu = Console.ReadLine();
            while(!int.TryParse(stringMenu, out menu))
            [
                //3 minutes and 67 seconds in 
                Console.WriteLine("The number you input was not valid, Please try again. Enter a number between 1-4");
                stringMenu = Console.ReadLine();
              ]
              
            //menu = int.Parse(Console.ReadLine());
            while (menu != 4)
            {
                if (menu == 1)
                {
                    printList(members);
                }
                else if (menu == 2)
                {
                    nameArr = addList();
                    members.AddRange(nameArr);
                }
                else if (menu == 3)
                {
                    Console.Write("Enter the name of the person you want removed from the list: ");
                    name = Console.ReadLine();
                    if (members.Contains(name))
                    {
                        members.Remove(name);
                        Console.WriteLine("The name has been deleted");
                    }
                    else
                        Console.WriteLine("Sorry, that name does not exist, please try again");
                }
                else
                    Console.WriteLine("You made an invalid selection from the menu, please try again");

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
            Console.Write("How many members do you wish to add? ");
            int number = int.Parse(Console.ReadLine());
            string[] newMembers = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Member name? ");
                newMembers[i] = Console.ReadLine();

            }
            return newMembers;
        }
    }
}
