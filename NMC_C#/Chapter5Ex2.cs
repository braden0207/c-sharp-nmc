using System;

namespace pirateGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-- make bool variables --//
            bool piratesTurn = true, winner = false;
            Random rand = new Random();
            //-- make int variables --//
            int call, toss, numFlips = 0, myScore = 0, pirateScore = 0;

            while (numFlips < 25 && !winner)
            {
                toss = rand.Next(1, 3);

                if (piratesTurn)
                {
                    call = rand.Next(1, 3);
                    if (call == toss) pirateScore += 5;
                    else pirateScore -= 1;

                    piratesTurn = false;
                    Console.WriteLine($"Pirates guess = {GetCoinFace(call)}. Toss = {GetCoinFace(toss)}");
                    Console.WriteLine($"Pirates Score = {pirateScore}");
                }
                else
                {
                    call = rand.Next(1, 3);
                    if (call == toss) myScore += 4;
                    else myScore -= 2;

                    piratesTurn = true;
                    Console.WriteLine($"My guess = {GetCoinFace(call)}. Toss = {GetCoinFace(toss)}");
                    Console.WriteLine($"My Score = {myScore}");
                }

                if (pirateScore >= 50 || myScore >= 50)
                    winner = true;

                numFlips++;
            }

            Console.WriteLine("Game Over!");
            if (pirateScore > myScore)
                Console.WriteLine($"Pirates win! You scored {myScore}, Pirates scored {pirateScore}. Walk the plank!");
            else if (pirateScore == myScore)
                Console.WriteLine($"It's a tie! Both scored {myScore}. Off to the hoosegow!");
            else
                Console.WriteLine($"You win! You scored {myScore}, Pirates scored {pirateScore}. Here's your treasure map!");
        }

        static string GetCoinFace(int coinNumber)
        {
            return coinNumber == 1 ? "Heads" : "Tails";
        }
    }
}
