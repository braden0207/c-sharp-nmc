using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 20, lives = 2, magic = 20, round = 0;
            Random rand = new Random();

            Console.WriteLine("You have entered the magical land of the Hawk Owls.");
            Console.WriteLine("You must navigate obstacles and survive 10 rounds.");

            while (lives > 0 && magic > 0 && health > 0 && round < 10)
            {
                round++;
                Console.WriteLine($"\nRound {round}");
                PrintStats(health, lives, magic);

                string choice = GetChoice();
                int eventCode = rand.Next(1, 11);

                switch (eventCode)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("A troll demands 5 magic to cross a bridge.");
                        magic -= 5;
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("An evil wizard attacks! Lose 1 life, 5 health, and 5 magic.");
                        health -= 5; lives -= 1; magic -= 5;
                        break;
                    case 5:
                    case 6:
                        Console.WriteLine("A fairy accuses you of stealing dust! Lose 2 magic and 2 health.");
                        magic -= 2; health -= 2;
                        break;
                    case 7:
                        Console.WriteLine("You rescue a unicorn. Gain 1 life, 6 magic, and 10 health.");
                        health += 10; lives += 1; magic += 6;
                        break;
                    case 8:
                        Console.WriteLine("A pirate ghost gifts you 10 magic for your noble deed.");
                        magic += 10;
                        break;
                    case 9:
                        Console.WriteLine("You save Hansel and Gretel. Gain 1 life.");
                        lives += 1;
                        break;
                    case 10:
                        Console.WriteLine("You help a leprechaun and gain 10 health.");
                        health += 10;
                        break;
                    default:
                        Console.WriteLine("You fall into a bog! Lose 3 health and 3 magic.");
                        health -= 3; magic -= 3;
                        break;
                }
            }

            Console.WriteLine("\nGame Over!");
            if (lives > 0 && magic > 0 && health > 0)
                Console.WriteLine("Congratulations! You survived and won the game.");
            else
                Console.WriteLine("You did not make it to your destination in time.");
        }

        static void PrintStats(int health, int lives, int magic)
        {
            Console.WriteLine($"Health: {health}, Lives: {lives}, Magic: {magic}");
        }

        static string GetChoice()
        {
            Console.WriteLine("Choose a path: left, right, or through.");
            return Console.ReadLine().ToLower();
        }
    }
}
