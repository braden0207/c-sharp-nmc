From ocdespaces 

using System;

class Ch7PasswordValidation
{
    static void Main()
    {
        bool validPassword = false;

        while (!validPassword)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Password Rules:");
            Console.WriteLine("1. Must be at least 12 characters long");
            Console.WriteLine("2. Must include at least 6 letters");
            Console.WriteLine("3. Must include at least 1 capital letter");
            Console.WriteLine("4. Must include at least 1 number");
            Console.WriteLine("5. Must include at least 1 symbol ($, ->, -<, =, +=, *=, /=, -=, ||, ~)");
            Console.WriteLine("6. Cannot include any spaces");
            Console.ResetColor();

            Console.Write("\nEnter a new password: ");
            string password = Console.ReadLine();

            // Validate if password is null, empty, or contains spaces
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Password cannot be empty or contain spaces.");
                Console.ResetColor();
                continue;
            }

            if (password.Length < 12)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: The password must be at least 12 characters long.");
                Console.ResetColor();
                continue;
            }

            // Initialize counters
            int letterCount = 0, capitalCount = 0, numberCount = 0, symbolCount = 0;

            // Define valid symbols
            string symbols = "$->-<=+=*=/=-=||~";

            // Check each character
            foreach (char c in password)
            {
                if (char.IsLetter(c)) letterCount++;
                if (char.IsUpper(c)) capitalCount++;
                if (char.IsDigit(c)) numberCount++;
                if (symbols.Contains(c)) symbolCount++;
            }

            // Validate password rules
            if (letterCount < 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: The password must include at least 6 letters.");
                Console.ResetColor();
                continue;
            }
            if (capitalCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: The password must include at least 1 capital letter.");
                Console.ResetColor();
                continue;
            }
            if (numberCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: The password must include at least 1 number.");
                Console.ResetColor();
                continue;
            }
            if (symbolCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: The password must include at least 1 symbol.");
                Console.ResetColor();
                continue;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Password is valid!");
            Console.ResetColor();

            // Verification step
            Console.Write("Re-enter password for verification: ");
            string verifyPassword = Console.ReadLine();

            if (password == verifyPassword)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password has been successfully changed.");
                Console.ResetColor();
                validPassword = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Password verification does not match. Try again.");
                Console.ResetColor();
            }
        }
    }
}
