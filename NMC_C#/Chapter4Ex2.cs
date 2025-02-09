namespace Chapter4Ex2
{
     internal class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("...Welcome to Test your Math...");
               Console.WriteLine("Enter Q to quit, or anything to continue");
               string? go = Console.ReadLine();
               Random rand = new Random();
               int num1 = 0, num2 = 0;
               //--corrected == to !=--//
               //--switched && instead ||--//
               while (go != "q" && go!="Q" )
               {
                    num1 = rand.Next(1, 100);
                    num2 = rand.Next(1, 100);
                    //--added $--//
                    Console.WriteLine($"What is {num1} + {num2}?");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    while (answer != (num1 + num2))
                    {
                         Console.WriteLine("That is incorrect, please try again!");
                         //--switched to int--//
                         answer = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Great job!");
                    Console.WriteLine("Enter Q to quit, or anything to continue");
                    go = (Console.ReadLine());
               }
               Console.WriteLine("Thanks for playing!");
          }
     }
}
