using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNum = r.Next(1, 1000);

            Console.WriteLine("Guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput == favNum)
            {
                Console.WriteLine("You got it!");
                Console.WriteLine($"My favorite number is {favNum}.");
            }
            else if(userInput < favNum)
            {
                Console.WriteLine("Your guess is too low.");
                Console.WriteLine($"My favorite number is {favNum}.");
            }
            else
            {
                Console.WriteLine("Your guess is too high.");
                Console.WriteLine($"My favorite number is {favNum}.");
            }
        }
    }
}
