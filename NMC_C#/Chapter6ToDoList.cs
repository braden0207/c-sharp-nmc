using System;
using System.Collections;

namespace Chapter6ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string title = "To Do List";
            const string year = " est. 2010";
            int menu;
            ArrayList newEmp = new ArrayList() { };
            ArrayList todoList = new ArrayList() { "Cook", 1.0, "Homework", 1.2, "Work", 6.0, "Studying", 0.5};

            printCompanyHeading(title, year);
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1. Print All by index\n2. Add \n3. Delete \n4. Delete All\n5. Quit");
            menu = int.Parse(Console.ReadLine());

            while (menu != 5)
            {
                if (menu == 1)
                {
                    printCompanyHeading(title, year);
                    printActivity(todoList);
                }
                else if (menu == 2)
                {
                    printCompanyHeading(title, year);
                    newEmp = addActivity();
                    todoList.AddRange(newEmp);
                }
                else if (menu == 3)
                {
                    printCompanyHeading(title, year);
                    Console.Write("Enter the index# of the activity you want removed\n(the activity and hours will be erased): ");
                    int indexNumber = int.Parse(Console.ReadLine());
                    for (int count = 0; count < 3; count++)
                    {
                        todoList.RemoveAt(indexNumber);
                    }
                    Console.WriteLine("The values have been deleted");

                }
                else if (menu == 4)
                {
                    printCompanyHeading(title, year);
                    todoList.Clear();
                    Console.WriteLine("It is all gone!");
                }
                else
                    Console.WriteLine("You made an invalid selection, please try again!");

                printCompanyHeading(title, year);
                Console.WriteLine("1. Print by index\n2. Add \n3. Delete \n4. Delete All\n5. Quit");
                menu = int.Parse(Console.ReadLine());
            }
        }
        static void printCompanyHeading(string comp, string yr)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"  {comp}        {yr}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            return;
        }
        static void printActivity(ArrayList emp)
        {
            int index = 0;
            Console.WriteLine("Values by Index#");
            Console.WriteLine("==============================");
            foreach (var e in emp)
            {
                Console.WriteLine(index + ". " + e.ToString());
                index++;
            }
            Console.WriteLine("==============================");
            Console.WriteLine();

            return;
        }
        static ArrayList addActivity()
        {
            Console.Write("How many employees do you wish to add? ");
            int number = int.Parse(Console.ReadLine());
            ArrayList newActivity = new ArrayList { };
            for (int i = 0; i < number; i++)
            {
                Console.Write("Activity name? ");
                newActivity.Add(Console.ReadLine());
                Console.Write("How long do you want to do it for? (Hours) ");
                newActivity.Add(int.Parse(Console.ReadLine()));

            }
            return newActivity;
        }

    }
}
