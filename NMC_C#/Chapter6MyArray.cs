// using System;
// namespace MembersOnly
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("How many items would you like to enter?");
//             int size = int.Parse(Console.ReadLine());
//             string[] members = new string[size];
//             double[] dues = new double[size];
//             for (int i = 0; i < size; i++)
//             {
//                 Console.WriteLine("Enter the member name: ");
//                 members[i] = Console.ReadLine();
//                 Console.WriteLine("Enter the dues: ");
//                 dues[i] = double.Parse(Console.ReadLine());
//             }
//             for(int i=0; i<size; i++)
//             {
//                 Console.WriteLine($"Member: {members[i]}  Dues: {dues[i]:C}");
//             }

//         }
//     }
// }
// 1. you will create a similar program in this assignment
// 2. Create a program similar to the example and call it Chapter6MyArrays. Create 2 different types of
// arrays that contain related data (for example, names and salaries, or athletes and teams, or family
// members and gifts etc. ) You select the arrays and data types.
// 3. Allow the user to enter how many items they want to add.
// 4. Create a loop and add items to each array.
// 5. After the arrays have been created, print out the values stored in each array.
// 6. Follow instructions for submitting your work.
