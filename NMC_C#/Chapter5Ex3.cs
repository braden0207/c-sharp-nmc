namespace gameofLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 100, energy = 100, satisfaction = 50, number = 0, days = 0;

            Random n = new Random();
            Console.WriteLine("You have just got a new desk job and are going through the days.");
            Console.WriteLine("How long will you be able to stay at the job without quitting?");
            Console.WriteLine("You begin your day with plenty of time, energy and satisfaction");
            Console.WriteLine("The game will end after 10 days or when you run out of time, energy or satisfaction");
            printHealth(time);
            printLives(energy);
            printMagic(satisfaction);

            string direction = String.Empty;
            while (energy > 0 && satisfaction > 0 && time > 0 && days < 10)
            {
                days++;
                direction = crossroads();
                switch (direction)
                {
                    case "keep working":
                        number = n.Next(1, 6);
                        break;
                    case "take a break":
                        number = n.Next(5, 12);
                        break;
                    case "drink some coffee":
                        number = n.Next(8, 15);
                        break;
                }
                switch (number)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("You turned in a project at work and your boss didnt like it! (-10 satisfaction)");
                        satisfaction -= 10;
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("You had to do overtime at work because one of your coworkers called in!(- 5 time, -10 energy, -10 satisfaction)");
                        time -= 50;
                        energy -= 10;
                        satisfaction -= 10;
                        break;
                    case 5:
                    case 6:
                        Console.WriteLine("You spilt coffee on your computer and didnt save what you were working on! (-20 satisfaction, -30 time)");
                        satisfaction -= 20;
                        time -= 30;
                        break;
                    case 7:
                       Console.WriteLine("Your boss let everyone get to work 3 hours later because of the weather!(+10 time, + 20 energy, +30 satisfaction)");
                        time += 10;
                        energy += 20;
                        satisfaction += 30;
                        break;
                    case 8:
                        Console.WriteLine("You finished a project that you put a lot of work into!(+10 satisfaction)");
                        satisfaction += 10;
                        break;
                    case 9:
                        Console.WriteLine("You drink a energy drink(+30 energy)");
                        energy += 30;
                        break;
                    case 10:
                        Console.WriteLine("Jeff your coworker helped you finish half your work because he was so nice!(+25 time)");
                        time += 25;
                        break;
                    default:
                        Console.WriteLine("You stubbed your toe and had to go to the walk-in(-40 time, -5 satisfaction)");
                        time -= 40;
                        satisfaction -= 5;
                        break;
                }

                printRound(days);
                printHealth(time);
                printLives(energy);
                printMagic(satisfaction);
            }
            if (energy > 0 && satisfaction > 0 && time > 0)
            {
                Console.WriteLine($"===========================================================================");
                Console.WriteLine("    Congratulations - You survived long enough to get a promotion!");
                Console.WriteLine($"===========================================================================");
            }
            else
            {
                Console.WriteLine($"===========================================================================");
                Console.WriteLine("    You coun't take it anymore and quit your job!");
                Console.WriteLine($"===========================================================================");
            }
        }

        static void printRound(int r)
        {
            Console.WriteLine($"----------------------------day {r}------------------------------");
        }

        static void printHealth(int h)
        {
            Console.WriteLine($"time= {h} minutes");
        }
        static void printMagic(int m)
        {
            Console.WriteLine($"satisfaction = {m}%");
        }
        static void printLives(int l)
        {
            Console.WriteLine($"energy= {l}%");
        }
        static string crossroads()
        {
            Console.WriteLine("The next hour has passed at your job.\n" +
                "How would you like to continue? (K = keep working, B = Break, C = Drink some Coffee");
            char direction = char.Parse(Console.ReadLine());
            string changeDirection = String.Empty;
            switch (direction)
            {
                case 'K':
                case 'k':
                    changeDirection = "keep working";
                    break;
                case 'B':
                case 'b':
                    changeDirection = "take a break";
                    break;
                case 'c':
                case 'C':
                    changeDirection = "drink some coffee";
                    break;
                default:
                    changeDirection = "keep working";
                    Console.WriteLine("You selected an invalid direction, so you will be staying at work.");
                    break;
            }
            
            return changeDirection;
        }
    }
}
