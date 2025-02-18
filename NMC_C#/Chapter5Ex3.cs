namespace adventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 20;
            int lives = 2;
            int magic = 20;
            int number = 0;
            int round = 0;
            Random n = new Random();
            Console.WriteLine("You have entered the magical land of the Hawk Owls");
            Console.WriteLine("You are following a path through a forest to get to your village");
            Console.WriteLine("You begin your journey with full health, magic and lives");
            Console.WriteLine("The game will end after 10 rounds or when you run out of lives, magic, or health\n");
            printHealth(health);
            printLives(lives);
            printMagic(magic);

            string direction = String.Empty;
            while (lives > 0 && magic > 0 && health > 0 && round < 10)
            {
                round++;
                direction = crossroads();
                switch (direction)
                {
                    case "left":
                        number = n.Next(1, 6);
                        break;
                    case "right":
                        number = n.Next(5, 12);
                        break;
                    case "through":
                        number = n.Next(8, 15);
                        break;
                }
                switch (number)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("You encountered a troll lurking under a bridge and had to pay 5 units of magic to safely cross the bridge.");
                        magic -= 5;
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("You fought against an evil wizard and lost 1 life, 5 units of health, and 5 units of magic.");
                        health -= 5;
                        lives -= 1;
                        magic -= 5;
                        break;
                    case 5:
                    case 6:
                        Console.WriteLine("A fairy accused you of stealing her dust. You lost 2 units of magic, and 2 units of health");
                        magic -= 2;
                        health -= 2;
                        break;
                    case 7:
                        Console.WriteLine("You found a baby unicorn lost in the woods and helped it find the way home.  The unicorn's mother gifted you " +
                            "1 unit of life, 6 units of magic, and 10 units of health");
                        health += 10;
                        lives += 1;
                        magic += 6;
                        break;
                    case 8:
                        Console.WriteLine("You stumbled upon buried treasure in the forest and decided to leave it undisturbed. The ghost of a pirate " +
                            "granted you 10 units of magic for your noble deed");
                        magic += 10;
                        break;
                    case 9:
                        Console.WriteLine("You helped 2 young children escape a nasty witch.  Hansel and Gretel gifted you  1 unit of life for helping them.");
                        lives += 1;
                        break;
                    case 10:
                        Console.WriteLine("You helped a leprechaun across a raging river and were gifted 10 units of health");
                        health += 10;
                        break;
                    default:
                        Console.WriteLine("You have fallen into a bog and cannot get out.  A traveler helps you for a mere 3 units of health and 3 units of magic.");
                        health -= 3;
                        magic -= 3;
                        break;
                }

                printRound(round);
                printHealth(health);
                printLives(lives);
                printMagic(magic);
            }
            if (lives > 0 && magic > 0 && health > 0)
            {
                Console.WriteLine($"===========================================================================");
                Console.WriteLine("    Congratulations - you made it to your village and won the game!");
                Console.WriteLine($"===========================================================================");
            }
            else
            {
                Console.WriteLine($"===========================================================================");
                Console.WriteLine("        Unfortunately, you did not make it to your village in time.");
                Console.WriteLine($"===========================================================================");
            }
        }

        static void printRound(int r)
        {
            Console.WriteLine($"----------------------------Round {r}------------------------------");
        }

        static void printHealth(int h)
        {
            Console.WriteLine($"Health={h}");
        }
        static void printMagic(int m)
        {
            Console.WriteLine($"Magic={m}");
        }
        static void printLives(int l)
        {
            Console.WriteLine($"Lives={l}");
        }
        static string crossroads()
        {
            Console.WriteLine("You have encountered a crossroad with an obstacle in front of you.\n" +
                "Which direction would you like to go? (L = left, R=right, T=through )");
            char direction = char.Parse(Console.ReadLine());
            string changeDirection = String.Empty;
            switch (direction)
            {
                case 'L':
                case 'l':
                    changeDirection = "left";
                    break;
                case 'R':
                case 'r':
                    changeDirection = "right";
                    break;
                case 'T':
                case 't':
                    changeDirection = "through";
                    break;
                default:
                    changeDirection = "left";
                    Console.WriteLine("You selected an invalid direction, so you will be going to the left");
                    break;
            }
            
            return changeDirection;
        }
    }
}
