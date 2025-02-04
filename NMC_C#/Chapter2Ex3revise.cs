namespace myMusic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Song they like
            Console.WriteLine("What is the name of a song you like to listen to? ");
            string? songName = Console.ReadLine();

            //---Band of song
            Console.WriteLine("What is the Name of the band in the song? ");
            string? bandName = Console.ReadLine();

            //---Prompt user to input Character
            Console.WriteLine("What is the genre of music: P for pop, R for rock, M for heavy metal, A for alternative, C for country, J for jazz");
            //---Convert to Char
            char bandChar = Convert.ToChar(Console.Read());
            Console.ReadLine();
            //covert switch
            string fullgenre;
            switch (char.ToUpper(bandChar))
            {
                case 'P':
                    fullgenre = "pop";
                    break;
                case 'p':
                     fullgenre = "pop";
                     break;
                case 'r':
                     fullgenre = "rock";
                     break;
                case 'R':
                     fullgenre = "rock";
                     break;
                case 'm':
                     fullgenre = "metal";
                     break;
                case 'M':
                     fullgenre = "metal";
                     break;
                case 'a':
                     fullgenre = "alternative";
                     break;
                case 'A':
                     fullgenre = "alternative";
                     break;
                case 'c':
                     fullgenre = "country";
                     break;
                case 'C':
                     fullgenre = "country";
                     break;
                case 'j':
                     fullgenre = "jazz";
                     break;
                case 'J':
                     fullgenre = "jazz";
                     break;
                default:
                    fullgenre = "unknown";
                    break;
            }

            //---Song Listened Time
            Console.WriteLine("How many times have you listened to this song in the past week? ");
            int timesListened = Convert.ToInt32((Console.ReadLine()));

            //---Displaying output
            Console.WriteLine($"You have been listening to {songName} by {bandName}. The song genre is {fullgenre} and you have listened to the song approximately {timesListened} times this week.");
        }
    }
}
