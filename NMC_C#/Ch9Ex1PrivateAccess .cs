using System;



class MembershipRoster
{
    private int _Id;
    private string _FirstName;
    private string _LastName;
    private string _CellNumber;
    private string _Email;
    private double _YearlyDues;


    // -- Default Constructor -- //
    public MembershipRoster()
    {
        _Id = 0;
        _FirstName = "";
        _LastName = "";
        _CellNumber = "";
        _Email = "";
        _YearlyDues = 0.0;
    }


    // -- Parameterized Constructor -- //
    public MembershipRoster(int id, string firstName, string lastName, string cellNumber, string email, double yearlyDues)
    {
        _Id = id;
        _FirstName = firstName;
        _LastName = lastName;
        _CellNumber = cellNumber;
        _Email = email;
        _YearlyDues = yearlyDues;
    }


    // -- Get and Set methods -- //
    public int GetId() { return _Id; }
    public void SetId(int id) { _Id = id; }
    
    public string GetFirstName() { return _FirstName; }
    public void SetFirstName(string firstName) { _FirstName = firstName; }
    
    public string GetLastName() { return _LastName; }
    public void SetLastName(string lastName) { _LastName = lastName; }
    
    public string GetCellNumber() { return _CellNumber; }
    public void SetCellNumber(string cellNumber) { _CellNumber = cellNumber; }
    
    public string GetEmail() { return _Email; }
    public void SetEmail(string email) { _Email = email; }
    
    public double GetYearlyDues() { return _YearlyDues; }
    public void SetYearlyDues(double yearlyDues) { _YearlyDues = yearlyDues; }
    
    // -- Print method -- //
    public void Print()
    {
        Console.WriteLine($"ID: {_Id}\nName: {_FirstName} {_LastName}\nCell: {_CellNumber}\nEmail: {_Email}\nYearly Dues: ${_YearlyDues}");
    }


    // -- Validation Method -- //
    public static string ValidateInput(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(input));
        return input;
    }


    public static double ValidateDoubleInput(string prompt)
    {
        double value;
        do
        {
            Console.Write(prompt);
        } while (!double.TryParse(Console.ReadLine(), out value) || value < 0);
        return value;
    }
}


class Program
{
    static void Main()
    {
        // -- Creating object using default constructor -- //
        MembershipRoster member1 = new MembershipRoster();
        member1.SetId(1);
        member1.SetFirstName("John");
        member1.SetLastName("Doe");
        member1.SetCellNumber("123-456-7890");
        member1.SetEmail("john.doe@example.com");
        member1.SetYearlyDues(50.0);


        // -- Displaying data using Get methods -- //
        Console.WriteLine("Member 1 Details:");
        Console.WriteLine($"ID: {member1.GetId()}, Name: {member1.GetFirstName()} {member1.GetLastName()}, Cell: {member1.GetCellNumber()}, Email: {member1.GetEmail()}, Yearly Dues: ${member1.GetYearlyDues()}");


        // -- Creating object using parameterized constructor -- //
        MembershipRoster member2 = new MembershipRoster(2, "Jane", "Smith", "987-654-3210", "jane.smith@example.com", 75.0);


        // -- Displaying data using Print method -- //
        Console.WriteLine("\nMember 2 Details:");
        member2.Print();
    }
}
