namespace Chapter5Ex1
{
 class Program
 {
 private static void Main(string[] args)
 {
 Console.WriteLine("Hello, I'm here to help you with math problems");
 Console.WriteLine("Please make a selection from our menu.");
 Console.WriteLine("1 for addition\n2 for subtraction\n3 to quit");
 int input = Console.Read();
 Console.ReadLine(); // removes newline from queue
 input = Convert.ToChar(input);
 int n1, n2, correctAns, answer;
 Random rnd = new Random();
 while (input != '3')
 {
 n1 = rnd.Next(1, 100);
 n2 = rnd.Next(1, 100);
 if (input == '1')
 {
 correctAns = n1 + n2;
Console.Write($"The sum of {n1}+{n2}= ");
answer = int.Parse(Console.ReadLine());
while (answer != correctAns)
 {
 Console.WriteLine("Oooops, that was incorrect, please try again");
Console.Write($"The sum of {n1}+{n2}= ");
answer = int.Parse(Console.ReadLine());
 }
Console.WriteLine("Great answer!");
 }
 else
{
 correctAns = n1 - n2;
 Console.Write($"The result of {n1}-{n2}= ");
 answer = int.Parse(Console.ReadLine());
while (answer != correctAns)
{
 Console.WriteLine("Wrong answer, please try again");
Console.Write($"The result of {n1}-{n2}= ");
answer = int.Parse(Console.ReadLine());
 }
Console.WriteLine("Fabulous!");
 }
 Console.WriteLine("Please make a selection from our menu.");
 Console.WriteLine("1 for addition\n2 for subtraction\n3 to quit");
 input = Console.Read();
 Console.ReadLine(); // removes newline from queue
 input = Convert.ToChar(input);
 }
 }
 // add menu method here
 // add addition method here
 // add subtraction method here
 }
}
