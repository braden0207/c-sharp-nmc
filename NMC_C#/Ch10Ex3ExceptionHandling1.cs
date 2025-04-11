using System;
namespace MembersOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many items would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            string[] students = new string[size];
            double[] scores = new double[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the students name: ");
                students[i] = Console.ReadLine();
                Console.WriteLine("Enter the test scores: ");
                scores[i] = double.Parse(Console.ReadLine());
            }
            for(int i=0; i<size; i++)
            {
                Console.WriteLine($"Student: {students[i]} | Math Score: {scores[i]:0.00}%");
            }

        }
    }
}
