using System;
using System.Collections;

namespace Chapter6ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string title = "To Do List";
            const string week = "est. 2025";
            int menu;
            ArrayList newActivity = new ArrayList() { };
            ArrayList todoList = new ArrayList() { "Cook", 1.0, "Homework", 1.2, "Work", 6.0, "Studying", 0.5};

            printActivityHeading(title, week);
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1. Print All by index\n2. Add \n3. Delete \n4. Delete All\n5. Quit");
            menu = int.Parse(Console.ReadLine());

            while (menu != 5)
            {
                if (menu == 1)
                {
                    printActivityHeading(title, week);
                    printActivity(todoList);
                }
                else if (menu == 2)
                {
                    printActivityHeading(title, week);
                    newActivity = addActivity();
                    todoList.AddRange(newActivity);
                }
                else if (menu == 3)
                {
                    printActivityHeading(title, week);
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
                    printActivityHeading(title, week);
                    todoList.Clear();
                    Console.WriteLine("It is all gone!");
                }
                else
                    Console.WriteLine("You made an invalid selection, please try again!");

                printActivityHeading(title, week);
                Console.WriteLine("1. Print by index\n2. Add \n3. Delete \n4. Delete All\n5. Quit");
                menu = int.Parse(Console.ReadLine());
            }
        }
        static void printActivityHeading(string act, string time)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"  {act}        {time}");
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
