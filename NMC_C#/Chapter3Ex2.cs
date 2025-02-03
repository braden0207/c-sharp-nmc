namespace hoursCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Constant variables---//
            const double discountPrice = 5.00;
            bool lateShift = false;
            bool earlyShift = false;
            int hours = 40;
            double pay = 50.00;
            double salary = 0.0;


            //--Entering data--//
                Console.Write("Do you work mornings? (type y if it is true, otherwise press any key).\n");
                char? Morning = char.Parse(Console.ReadLine());
                
            //--If Statements--//
                //--Early or Late--//
                if (Morning == 'y' || Morning == 'Y')
                {
                    earlyShift = true;
                }
                else
                {
                    lateShift = true;
                }
                //--If Shift--//
                if (earlyShift)
                {
                    salary = hours * pay;
                }
                else 
                {
                    salary = hours * pay + 500;
                }
                //--Display--//
            Console.WriteLine($"You worked: {hours} hours and received ${salary:0.00} Gross pay");
        }
    }      
}
