using System;
namespace myGrade
{
 internal class Program
 {
 static void Main(string[] args)
 {
 Console.Write("Enter your test score: ");
 double score = double.Parse(Console.ReadLine());
 if (score >= 90)
 Console.WriteLine("A");
 else if (score >= 80)
 Console.WriteLine("B");
 else if (score >= 70)
 Console.WriteLine("C");
 else if (score >= 60)
 Console.WriteLine("D");
 else
 Console.WriteLine("Please see tutoring");
 }
 }
}

//The program should do the following:
//a) Welcome the trainees to the conference center.
//b) Prompt the trainee to enter their trainee number
//c) Read in the number and use a nested if…else to determine the training location. The
//rules are as follows:
//numbers > 500 go to training room 7A
//numbers > 300 go to the main ballroom
//numbers > 200 go to the gymnasium
//numbers > 100 go to the training room 6A
//everyone else should go to training room 2B

