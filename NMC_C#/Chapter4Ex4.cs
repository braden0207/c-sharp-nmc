// You will create a game that simulates rolling dice using the random number generator. It is
// kind of like Blackjack, but you want to reach 100 without going over the amount. (The
// random number code is similar to Random Number Programming Example 3, but instead
// of accumulating the number of each dice that is rolled, you will be adding the number
// rolled into a total).
// 1. Create a new project named Chapter4Ex2
// 2. The game will have 2 players, player1 will be the computer and player2 will be the
// person executing the program. The first player to reach 100 without going over wins.
// 3. Roll the dice for player1 (the computer) 28 times. Total up the dice rolls and display
// the computer’s total value to player2 so they know what value they need to beat.
// HINT: You will need to create a random object and use the Next() method to retrieve
// a value between 1 and 6. Random Numbers Programming Example 3 shows you
// how to do this. Because you know how many times you need to “roll” the dice, you
// should use a For loop for player1 to total the dice rolls.
// 4. Roll the dice for player2 and ask if they want to stop or continue. Continue adding
// the dice value to the total until the player wants to stop. You can use a while loop or
// a do…while loop for this. The while loop logic you need to use is similar to the
// example code on page 23.
// 5. To determine who wins, use the following logic:
// if player1 is greater than 100 and player2 is greater than 100, the match is a tie
// else if player1 is greater than 100 and player2 is less than or equal to 100, player2 wins.
// else If player2 is greater than 100 and player1 is less than or equal to 100, player1 wins.
// else If player1 < player2, then player2 wins
// else If player1 is greater than playyer2, then player1 wins
// else the match is a tie
// Make sure you display a message indicating the results (who wins or if the result is a
// tie).
// 6. After you determine a winner, ask if the user would like to play again. (HINT: This
// requires placing all the code into a while or do…while loop)
// 7. There is more than one way to complete the exercise correctly. If you are unsure of
// where to begin, the following algorithm should help you. The algorithm illustrates
// one way of completing the exercise correctly.
// Declare the random number object, an integer for player1 totals, an integer for player2 totals, and a
// Boolean variable set to true indicating they want to play
// Create a loop that tests the Boolean variable (as long as it is true, they will play)
// Set the player1 total and the player2 total to zero.
// Create a for loop for player1 that totals the roll of each dice and loops 28 times
// Display player 1’s total
// Create a new Boolean variable for player2 and set it to true. This variable will be tested to
// see if the player wants to continue rolling the dice.
// Create a loop that tests player2’s Boolean variable. You will stay in the loop as long as that
// variable is true
// Display player2’s total and ask if they want to stop or continue
// Retrieve their answer and set the player2 boolean variable to false if they want to
// quit. If they don’t want to quit, then retrieve another random dice roll and add it to
// player 2’s total.
// Once player 2 quits, display the total for player2
// Use the nested if…else logic in step 5 to determine a winner
// Ask the user if they want to play again or quit. If they indicate they want to keep playing, set the Boolean
// play variable to true, otherwise set it to false

//To see an example of the program running, watch: https://youtu.be/h_bge155VK8
using System;
namespace Chapter4Ex4
{
     internal class Program
     {
          static void Main(string[] args)
          {
             char keepPlaying = 'y';
             while (keepPlaying == 'y')
             {
               int player1Total = 0;
               int player2Total = 0;

               for (int count = 0; count < 28; count++)
               {
                    Random value = Random.Next(1,7); //use random object to call next(1,7)
                    player1Total += Value;
               }
               //display the calue player2 needs to beat

               char quit = 'n';
               while(quit == 'n')
               {
                    //use random object to call next(1,7)
                    player2Total += Value;
                    //display player 2's total
                    //ask if they want to contine or quit
                    quit = char.Parse(Console.ReadLine());
               }
               //nested if....else


               Console.WriteLine("Do you want to play again? (y to continue)");
               keepPlaying = char.Parse(Console.ReadLine());
             }
          }
     }
}
