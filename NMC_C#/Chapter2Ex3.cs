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
            Console.WriteLine("What is the Name of the bank in the song? ");
            string? bandName = Console.ReadLine();

            //---Prompt user to input Character
            Console.WriteLine('What is the genre of music: P for pop, R for rock, M for heavy metal, A for alternative, C for country, J for jazz');

            //---Convert to Char
            char bandChar = Convert.ToChar(Console.Read());
            Console.ReadLine();

            //---Song Listened Time
            Console.WriteLine("How many times have you listened to this song in the past week? ");
            int timesListened = int.Parse(Console.ReadLine());

            //---Displaying output
            Console.WriteLine($"You have been listening to {songName} by {bandName}. The song genre is {bandChar} and you have listened to the song approximately {timesListened} times this week.");

        }
    }
}
