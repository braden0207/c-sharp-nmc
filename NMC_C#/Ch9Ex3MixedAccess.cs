using System;

namespace Ch9Ex3MixedAccess
{
    class Game
    {
        // Public Fields
        public string Title;
        public string Platform;

        // Private Fields
        private int _ReleaseYear;
        private double _Cost;

        // Default Constructor
        public Game()
        {
            Title = "Unknown";
            Platform = "Unknown";
            _ReleaseYear = 0;
            _Cost = 0.0;
        }

        // Parameterized Constructor
        public Game(string title, string platform, int releaseYear, double cost)
        {
            Title = title;
            Platform = platform;
            SetReleaseYear(releaseYear);  // Calls Set() method to validate
            SetCost(cost);                // Calls Set() method to validate
        }

        // Get Methods
        public int GetReleaseYear()
        {
            return _ReleaseYear;
        }

        public double GetCost()
        {
            return _Cost;
        }

        // Set Methods with Validation
        public void SetReleaseYear(int releaseYear)
        {
            if (releaseYear > 1990)
            {
                _ReleaseYear = releaseYear;
            }
            else
            {
                Console.WriteLine("The release year must be after 1990.");
            }
        }

        public void SetCost(double cost)
        {
            if (cost >= 10 && cost <= 200)
            {
                _Cost = cost;
            }
            else
            {
                Console.WriteLine("The cost must be between $10 and $200.");
            }
        }

        // Method to Print Game Info
        public void Print()
        {
            Console.WriteLine($"Title: {Title}, Platform: {Platform}, Year: {_ReleaseYear}, Cost: ${_Cost}");
        }
    }
}





        static void Main(string[] args)
        {
            Console.WriteLine("How many games would you like to enter?");
            string? strCount = Console.ReadLine();
            int count;

            // Input validation for the number of games
            while (!int.TryParse(strCount, out count) || count <= 0)
            {
                Console.WriteLine("Please enter a whole number greater than zero");
                strCount = Console.ReadLine();
            }

            // Create an array of Game objects
            Game[] myGame = new Game[count];

            // Instantiate each element in the array
            for (int i = 0; i < count; i++)
            {
                myGame[i] = new Game();
            }

            int gamesAdded = 0;
            char menuChoice;

            // Menu loop
            do
            {
                menuChoice = Menu();

                if (menuChoice == 'A')  // Add Game
                {
                    if (gamesAdded < count)
                    {
                        AddGame(mygame, ref gamesAdded);
                    }
                    else
                    {
                        Console.WriteLine("The maximum number of game entries has been reached.");
                    }
                }
                else if (menuChoice == 'P')  // Print Games
                {
                    if (gamesAdded == 0)
                    {
                        Console.WriteLine("No games to display. Please add some games first.");
                    }
                    else
                    {
                        for (int i = 0; i < gamesAdded; i++)
                        {
                            myGame[i].Print();
                        }
                    }
                }

            } while (menuChoice != 'Q'); // Exit if 'Q' is chosen
        }

        // Menu Method
        public static char Menu()
        {
            char choice;
            Console.WriteLine("\nEnter an option: ");
            Console.WriteLine("A - Add a Game");
            Console.WriteLine("P - Print all games");
            Console.WriteLine("Q - Quit");
            string? value = Console.ReadLine();

            while (!char.TryParse(value, out choice) || (choice != 'A' && choice != 'P' && choice != 'Q'))
            {
                Console.WriteLine("Please enter an A, P, or Q");
                value = Console.ReadLine();
            }

            return char.ToUpper(choice); // Converts the input to uppercase
        }

        // AddGame Method
        private static void AddGame(Game[] myGame, ref int gamesAdded)
        {
            string title, platform;
            int releaseYear;
            double cost;

            // Validate and gather game title
            Console.Write("Enter the game title: ");
            title = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title cannot be empty or just spaces. Please enter a valid title.");
                title = Console.ReadLine();
            }

            // Validate and gather platform
            Console.Write("Enter the platform: ");
            platform = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(platform))
            {
                Console.WriteLine("Platform cannot be empty or just spaces. Please enter a valid platform.");
                platform = Console.ReadLine();
            }

            // Validate and gather release year
            Console.Write("Enter the release year: ");
            string? tempValue = Console.ReadLine();
            int tempYear;
            while (!int.TryParse(tempValue, out tempYear) || tempYear <= 1990)
            {
                Console.WriteLine("The year must be a number and greater than 1990.");
                tempValue = Console.ReadLine();
            }

            // Set the release year using the Set method
            myGame[gamesAdded].SetReleaseYear(tempYear);

            // Validate and gather cost
            Console.Write("Enter the cost of the game: ");
            string? costValue = Console.ReadLine();
            double tempCost;
            while (!double.TryParse(costValue, out tempCost) || tempCost < 10 || tempCost > 200)
            {
                Console.WriteLine("Cost must be a valid number between $10 and $200.");
                costValue = Console.ReadLine();
            }

            // Set the cost using the Set method
            myGame[gamesAdded].SetCost(tempCost);

            // Set the title and platform directly (no validation needed for these public fields)
            myGame[gamesAdded].Title = title;
            myGame[gamesAdded].Platform = platform;

            // Increment the count of games added
            gamesAdded++;
        }
    }
}

