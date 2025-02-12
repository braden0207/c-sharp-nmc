using System;

namespace Chapter4Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //--Create a single Random object--//
            char keepPlaying = 'y';
            Random random = new Random();

            while (keepPlaying == 'y')
            {
                int player1Total = 0;
                int player2Total = 0;

                //--Player 1/computer rolls the dice 27 times--//
                for (int count = 0; count < 27; count++)
                {
                    // make a random number between 1 and 6--//
                    int roll = random.Next(1, 7); 
                    player1Total += roll;
                }

                //--Display the value you needs to beat--//
                Console.WriteLine($"Player 1 (Computer) total: {player1Total}");

                bool player2Playing = true;
                while (player2Playing)
                {
                    //--Generate a random number between 1 and 6--//
                    int roll = random.Next(1, 7); 
                    player2Total += roll;

                    //--Display Player 2's total--//
                    Console.WriteLine($"your total is: {player2Total},Do you want to roll again? (y to continue, n to stop)");
                    char quit = char.Parse(Console.ReadLine().ToLower());
                    //--if they quit--//
                    if (quit == 'n')
                    {
                        player2Playing = false;
                    }
                }

                //--Determine the winner--//
                //used if/else but could use Switch?
                if (player1Total > 100 && player2Total > 100)
                {
                    Console.WriteLine("Both players went over 100. It's a tie!");
                }
                else if (player1Total > 100 && player2Total <= 100)
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else if (player2Total > 100 && player1Total <= 100)
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else if (player1Total < player2Total)
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else if (player1Total > player2Total)
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                //--Ask user to play again--//
                Console.WriteLine("Do you want to play again? (y to continue, n to quit)");
                keepPlaying = char.Parse(Console.ReadLine().ToLower());
            }
        }
    }
}
