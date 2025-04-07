using System;
namespace Ch9Ex6RiceKrispies
{
 class Breakfast
 {
 static void Main(string[] args)
 {
 Snap.talk();
 Crackle.talk();
 Pop.talk();
 Console.Write(" Rice Krispies");
 Console.WriteLine();
 }
 }
 public class Snap
 {
 public static void talk()
 {
 Console.Write("Snap ");
 }
 }
 public class Crackle
 {
 public static void talk()
 {
 Console.Write("Crackle ");
 }
 }
 public class Pop
 {
 public static void talk()
 {
 Console.Write("Pop ");
 }
 }
}
