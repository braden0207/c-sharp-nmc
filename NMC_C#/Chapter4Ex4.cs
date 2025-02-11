using System;

namespace Chapter4Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char keepPlaying = 'y';
            Random random = new Random(); // Create a single Random object

            while (keepPlaying == 'y')
            {
                int player1Total = 0;
                int player2Total = 0;

                // Player 1 (computer) rolls the dice 28 times
                for (int count = 0; count < 28; count++)
                {
                    int roll = random.Next(1, 7); // Generate a random number between 1 and 6
                    player1Total += roll;
                }

                // Display the value player2 needs to beat
                Console.WriteLine($"Player 1 (Computer) total: {player1Total}");

                bool player2Playing = true;
                while (player2Playing)
                {
                    int roll = random.Next(1, 7); // Generate a random number between 1 and 6
                    player2Total += roll;

                    // Display Player 2's total
                    Console.WriteLine($"Player 2 total: {player2Total}");

                    // Ask if they want to continue or quit
                    Console.WriteLine("Do you want to roll again? (y to continue, n to stop)");
                    char quit = char.Parse(Console.ReadLine().ToLower());

                    if (quit == 'n')
                    {
                        player2Playing = false;
                    }
                }

                // Determine the winner
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

                // Ask if the user wants to play again
                Console.WriteLine("Do you want to play again? (y to continue, n to quit)");
                keepPlaying = char.Parse(Console.ReadLine().ToLower());
            }
        }
    }
}

