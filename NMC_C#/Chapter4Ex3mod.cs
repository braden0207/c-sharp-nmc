// You will be modifying Chapter4 Exercise 3, the ice cream shop, to store the cone size, flavor, and price in
// arrays instead of variables. The cone size should be stored in a string or character array (you decide if you
// want to enter ‘s’ or “small”, ‘m’ or “medium”, or ‘l’ or “large”. The cone price should be stored in a double
// array. The ice cream flavors, should be stored in a string array (for 2 and 3 scoop cones, you will be
// separating flavors using a space or a newline escape sequence). Once the cones have been “made”, you
// will loop through the arrays, print a summary of the order, and display the total amount the customer
// should pay.

Here are the modifications you need to make to your program:
  // 1. After you prompt the user to enter the number of ice cream cones you need to make, use that
  // number as the size of each array. Create the character or string cone size array, the string flavor array,
  // and the double price array.
  // Example:
  //  Console.WriteLine("How many cones are you purchasing today?");
  //  int number = int.Parse(Console.ReadLine());
  //  char[] coneSize = new char[number];

  // 2. Remove the variables that currently exist for cone size, flavor 1, flavor 2 , and flavor 3.

  // 3. Keep the for loop that processes each cone ordered. The variable initialized in the for loop will be the
  // index into your arrays.
  // int i;
  // for (i=0; i<number;i++)
  // The variable i, will be used to store values into each of the arrays – make sure it is initialized to zero.
  
  // 4. Within the for loop you should be checking for the size cone they would like. You need to change the
  // variable you are storing the cone size in to use the array.
  // Old Code:
  // Console.WriteLine($"What size cone do you want?");
  // coneSize = Console.ReadLine();
  // New Code with some value checking:
  // Console.WriteLine($"What size cone do you want?");
  // Console.WriteLine($”s = small, m = medium, l = large”);
  // coneSize[i] = char.ToLower(char.Parse(Console.ReadLine()));
  // while(coneSize[i] != ‘s’ && coneSize[i]!=’m’ && coneSize[i]!=’l’)
  // {
  //  Console.WriteLine(“The size must be s, m, or l\nPlease try again!”);
  //  coneSize[i] = char.ToLower(char.Parse(Console.ReadLine()));
  // }

  // 5. Change the switch variable to use the coneSize array instead of the variable
  // Old Code: switch(coneSize)
  // New Code: switch(coneSize[i])
  // a) For a small cone, prompt for the ice cream flavor and put the string directly into the flavor array.
  // Then place the price directly into the price array
  // Old Code:
  //  case “small”:
  //  Console.WriteLine("What flavor would you like?");
  //  Flavor1 = Console.ReadLine();
  //  grandTotal+= 2.50;
  //  break;
  // New Code:
  //  case 's':
  //  Console.WriteLine("What flavor would you like?");
  //  flavor[i] = Console.ReadLine();
  //  price[i] = 2.50;
  //  break;
  // b) For the medium and large cone, the processing will be similar, but you will need to add the second
  // and/or third flavor of ice cream to the existing string (you cannot put them into new elements
  // within the array, they all need to be stored in the same element - each cone has 1 element to work
  // with.)
  // There are a couple of different ways you can code this; the most efficient method is shown below
  // (the example is for 2 cones, you would do something similar for 3):
  //  case 'm':
  //  for(int n=0; n<2; n++)
  //  {
  //  Console.Write($"Enter flavor number {n+1} ");
  //  flavor[i] += “\n”+Console.ReadLine();
  //  }
  //  price[i] = 3.00;
  //  break;
  // You should notice a newline escape has been added to the flavor before each string is read from
  // the console. This will keep each flavor separate, and it will display each on a new line when you
  // print out the results. You could also just add a space here to separate the flavors.

  
  // 6. After the cone entry loop has processed, you will need to use another for loop to print out the results.
  // Inside that for loop, you can total up the price of each cone and store it in a grand total (See output
  // example on the next page).
  
  // 7. After the summary, print out the total amount the customer owes.
  
  // 8. Both the price of each cone and the grand total should be printed with a dollar sign and 2 decimals,
  // so you should use formatted output.
  // You can use String.Format to format the output, or you can use a shortcut:
  // Console.WriteLine($"Thank you for your purchase, your total is: {grandTotal:C}");

  // 9. Follow instructions for submitting your work.


  
// Sample Output
// Welcome to our ice cream shop!
// How many cones are you purchasing today?
// 3
// What size cone do you want?
// s = small, m = medium, l = large
// l
// Enter flavor number 1: chocolate chip
// Enter flavor number 2: pistachio
// Enter flavor number 3: vanilla
// Cone # 1 is done.
// What size cone do you want?
// s = small, m = medium, l = large
// m
// Enter flavor number 1: fudge
// Enter flavor number 2: caramel fudge
// Cone # 2 is done.
// What size cone do you want?
// s = small, m = medium, l = large
// s
// What flavor would you like?
// vanilla
// Cone # 3 is done.
// ------------------Cone #1 Order Summary--------------------
// Size: large
// Flavor:
// chocolate chip
// pistachio
// vanilla
// Price: $3.50
// ------------------Cone #2 Order Summary--------------------
// Size: medium
// Flavor:
// fudge
// caramel fudge
// Price: $3.00
// ------------------Cone #3 Order Summary--------------------
// Size: small
// Flavor: vanilla
// Price: $2.50
// --------------------------------------------------------------------
// Thank you for your purchase, your total is: $9.00
