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
            /*
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
            */

            // Printing statement based on favorite school subject
            Console.WriteLine("Enter the number beside your favorite school subject!");
            Console.WriteLine("1 Math \n" + "2 English \n" + "3 History \n" + "4 Science \n" + "5 PE \n");
            int favSubj = int.Parse(Console.ReadLine());

            switch(favSubj)
            {
                case 1:
                    Console.WriteLine("You math nerd!");
                    break;
                case 2:
                    Console.WriteLine("So you like English?");
                    break;
                case 3:
                    Console.WriteLine("You history buff!");
                    break;
                case 4:
                    Console.WriteLine("You science wizz!");
                    break;
                case 5:
                    Console.WriteLine("So you workout?");
                    break;
                default:
                    Console.WriteLine("Not a fan of school, huh?");
                    break;
            }

        }
    }
}
