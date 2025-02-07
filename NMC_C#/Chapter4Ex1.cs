using System;
public class Program
{
 public static void Main()
 {
//You will be copying a program and converting a for loop into a while loop, and converting
//another for loop into a do…while loop.
 double price = 0;
 int i;
 for (i = 1; i <= 5; i++)
 {
 Console.WriteLine($"Enter the price of item# {i}");
 price += double.Parse(Console.ReadLine());
 }
 Console.WriteLine($"Your total for {i-1} items is: ${price}");
 price = 0;
 //convert to while loop
 for (i = 1; i <= 5; i++)
 {
 Console.WriteLine($"Enter the price of item# {i}");
 price += double.Parse(Console.ReadLine());
 }
 Console.WriteLine($"Your total for {i-1} items is: ${price}");
 price = 0;
 //convert to do...while loop
 for (i = 1; i <= 5; i++)
 {
 Console.WriteLine($"Enter the price of item# {i}");
 price += double.Parse(Console.ReadLine());
 }
 Console.WriteLine($"Your total for {i-1} items is: ${price}");
 }
}

//Convert the loop below each comment to a while loop and do… while loop. The
// procedure for converting for loops to while loops is on page 24. Do…while loops are
// discussed on page 25 (the conversion process is similar).
// 4. Once you have modified the program and it runs correctly, follow your instructor’s
// directions for submitting the assignment.
