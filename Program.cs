using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // User guessing favorite number
            var r = new Random();
            var favNum = r.Next(1, 1000);
            bool rightAnswer = false;

            do
            {
                Console.WriteLine("Guess my favorite number.");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput < favNum)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else if (userInput > favNum)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else
                {
                    Console.WriteLine($"Correct! My favorite number is {favNum}");
                    rightAnswer = true;
                }
            } while (rightAnswer == false);


        }
    }
}
