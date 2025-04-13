using System;

class Ch10Ex2BankExceptionHandling
{
    static void Main()
    {
        double beginningBalance = 1000.00;
        double deposit, withdrawal, endingBalance = 0;

        try
        {
            Console.Write("Enter deposit amount: ");
            deposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            withdrawal = Convert.ToDouble(Console.ReadLine());

            endingBalance = beginningBalance + deposit - withdrawal;

            if (endingBalance == 0)
                throw new ArithmeticException("Ending balance is zero.");
            else if (endingBalance < 0)
                throw new ArithmeticException("Ending balance is negative.");
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine($"Arithmetic error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"\n--- Account Summary ---");
            Console.WriteLine($"Beginning Balance: ${beginningBalance:F2}");
            Console.WriteLine($"Deposit: ${deposit:F2}");
            Console.WriteLine($"Withdrawal: ${withdrawal:F2}");
            Console.WriteLine($"Ending Balance: ${endingBalance:F2}");
            Console.WriteLine("------------------------");
        }
    }
}
