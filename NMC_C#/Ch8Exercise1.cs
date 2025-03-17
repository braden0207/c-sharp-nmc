
namespace Chapter8Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string club = string.Empty;
            double cost = 0;
            int players = 0;
            club = changeClub(club);
            changeCost(cost);
            changePlayers(ref players);
            printEvent(club, cost, players);
        }
        private static void changePlayers(ref int players)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("How many players are in the tournement?");
            players = int.Parse(Console.ReadLine());
            return;
        }
        private static void changeCost(double cost)
        {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"What is the cost per player?");
                cost = double.Parse(Console.ReadLine());
                return cost;
        }
        private static string changeClub(string club)
        {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What type of club is holding the competition?");
                club = Console.ReadLine();
                return club;
        }
        private static void printEvent(string club, double cost, int players)
        {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"=========================================================");
                Console.WriteLine($"Welcome to the {club} club");
                Console.WriteLine($"The cost to join today's competition is {cost:C}");
                Console.WriteLine($"The number of players is {players}");
                Console.WriteLine($"=========================================================");
        }
    }
}

 //Fix the changeCost() method by returning the cost as shown in the example above. Adjust the method call as shown
// below:
 
// cost = changeCost(cost);
 
// 4. Run the program. You should notice that the club and cost show the new values.
 
// 5. To fix the number of players, we are going pass the variable Call by Reference instead of Call by Value. Call by Reference
// passes the actual value instead of a copy. Any change the method makes are retained, so nothing has to be returned from
// the method.
// Modify the changePlayers() method by adding the keyword ref or out before int players in the parameter list. Example:
// private static void changePlayers(ref int players)
// Modify the method call by adding ref or out before the variable in the argument list. Example: changePlayers(ref players);

// 6. Run the program. You should notice that all values are retained and print correctly.

