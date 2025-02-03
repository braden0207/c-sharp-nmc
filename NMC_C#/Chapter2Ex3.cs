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
            Console.WriteLine("What is the genre of music: P for pop, R for rock, M for heavy metal, A for alternative, C for country, J for jazz");
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

//The original output looks like the example below:
//You have been listening to Unstoppable by Sia.
//The song genre is P and you have listened to the song approximately 20 times this week.
//Your new output will look like the following:
//You have been listening to Unstoppable by Sia.
//The song genre is Pop and you have listened to the song approximately 20 times this
//week.
//2. To make this change, create a new string variable called fullGenre. Then create a switch
statement and check the genre variable. Your case statements should check for the
//different genre letters and then they should store the full genre name in the new
//variable.
//Example:
// case ‘p’:
// case ‘P’:
// fullGenre = “pop”;
// break;
//3. Modify the WriteLine statement to print the full genre instead of the shortened version.
//4. Once your program runs correctly, submit the assignment as directed by your
//instructor.
