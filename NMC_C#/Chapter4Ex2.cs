namespace Chapter4Ex2
{
 internal class Program
 {
 static void Main(string[] args)
 {
// 2. Copy the code below into your program. There are 4 lines of code with errors. Only
//   1 of the errors will be flagged as an error before the program is run. The other 3
// errors are runtime errors which result in the program running, but not running
// correctly. Pay particular attention to arithmetic operators, logical operators, and
// data types.
//    3. Once you have modified the program and corrected the errors, follow your
// instructor’s directions for submitting the assignment.
 Console.WriteLine("...Welcome to Test your Math...");
 Console.WriteLine("Enter Q to quit, or anything to continue");
 string? go = Console.ReadLine();
 Random rand = new Random();
 int num1 = 0, num2 = 0;
 while (go == "q" || go=="Q" )
 {
 num1 = rand.Next(1, 100);
 num2 = rand.Next(1, 100);
 Console.WriteLine("What is {num1} + {num2}?");
 int answer = int.Parse(Console.ReadLine());
 while (answer != (num1 + num2))
 {
 Console.WriteLine("That is incorrect, please try again!");
 answer = char.Parse(Console.ReadLine());
 }
 Console.WriteLine("Great job!");
 Console.WriteLine("Enter Q to quit, or anything to continue");
 go = char.Parse(Console.ReadLine());
 }
 Console.WriteLine("Thanks for playing!");
 }
 }
}
