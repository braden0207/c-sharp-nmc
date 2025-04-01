using System;

namespace Ch9Ex2PublicAccess
{
    class Member
    {
        // -- Public fields (as per instructions) -- //
        public string FirstName;
        public string LastName;
        public int Age;
        public string Email;

        // -- Default constructor -- //
        public Member()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            Age = 0;
            Email = "Unknown";
        }

        // -- Parameterized constructor -- //
        public Member(string firstName, string lastName, int age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }

        // -- Method to display class data -- //
        public void Print()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}, Email: {Email}");
        }

        // -- Static method to accept input and assign values to an object -- //
        public static void AddDataToObject(Member member)
        {
            // -- Get user input for the fields -- //
            Console.Write("Enter First Name: ");
            member.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            member.LastName = Console.ReadLine();

            // -- Validate Age input -- //
            bool validAge = false;
            while (!validAge)
            {
                Console.Write("Enter Age: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    member.Age = age;
                    validAge = true;
                }
                else
                {
                    Console.WriteLine("Invalid age. Please enter a valid number.");
                }
            }

            // -- Validate Email input -- //
            bool validEmail = false;
            while (!validEmail)
            {
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                if (email.Contains("@"))
                {
                    member.Email = email;
                    validEmail = true;
                }
                else
                {
                    Console.WriteLine("Invalid email format. Please enter a valid email.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // -- Object 1: Use the default constructor and static method to add data -- //
            Member member1 = new Member();
            Member.AddDataToObject(member1);
            member1.Print();

            // -- Object 2: Use the default constructor and directly assign values -- //
            Member member2 = new Member();
            member2.FirstName = "Betty";
            member2.LastName = "Johnson";
            member2.Age = 30;
            member2.Email = "betty.johnson@example.com";
            Console.WriteLine("Object 2 (direct assignment):");
            Console.WriteLine($"Name: {member2.FirstName} {member2.LastName}, Age: {member2.Age}, Email: {member2.Email}");

            // -- Object 3: Use the parameterized constructor to create the object -- //
            Member member3 = new Member("Alice", "Smith", 28, "alice.smith@example.com");
            Console.WriteLine("Object 3 (parameterized constructor):");
            member3.Print();
        }
    }
}
