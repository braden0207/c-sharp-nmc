namespace ItsMyParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user to enter their name
            Console.WriteLine("Please enter your name:");
            // create a string variable called myName and set it equal to the value you read in from the console
            string myName = Console.ReadLine();
            // prompt the user to enter their birthday
            Console.WriteLine("Please enter your birthday:");
            // create a string variable named myBirthday and set it equal to the value you read in from the console
            string myBirthday = Console.ReadLine();
            // prompt the user to enter their favorite kind of cake
            Console.WriteLine("Please enter your favoirite kind of cake:");
            // create a string variable named cake and set it equal to the value you read in from the console
            string cake = Console.ReadLine();
            // prompt the user to enter their ideal location for a birthday party 
            Console.WriteLine("Please enter your ideal location for a birday party:");
            // create a string variable named venue and set it equal to the value you read in from the console
            string venue = Console.ReadLine();
            // prompt the user to enter the number of guests they are inviting to the party
            Console.WriteLine("Please enter the number of guests you are inviting to the party");
            // create an integer variable named guests and set it equal to the value you read in from the console
            int guests = int.Parse(Console.ReadLine());
            // using string interpolation, print the following information
            // "{myName} has a birthday on {myBirthday}. There will be a party at {venue} with {guests} people."
            // "Save room for the {cake} cake!"
            Console.WriteLine($"{myName} has a birthday on {myBirthday}. There will be a party at {venue} with {guests} people.");
        }
    }
} 
