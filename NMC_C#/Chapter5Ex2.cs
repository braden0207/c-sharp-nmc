using System;
namespace pirateGame
{
 internal class Program
 {
 static void Main(string[] args)
 {
 bool piratesTurn = true;
 bool winner = false;
 Random rand = new Random();
 int call, toss;
 int numFlips = 0;
 int myScore = 0;
 int pirateScore = 0;
 while (numFlips < 25 && !winner)
 {

 }
 if (pirateScore > myScore)
 // display a message about walking the plank
 else if (pirateScore == myScore)
 // display a message about being thrown in the hoosegow
 else
 // display a message about receiving a treasure map
 }
 static string GetCoinFace(int coinNumber)
 {
 }
 }
}
