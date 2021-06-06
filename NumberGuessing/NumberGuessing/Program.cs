using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int nRandom = r.Next(0, 100);
            bool IsNumGuessed = false;

            while(IsNumGuessed == false)
            {
                Console.WriteLine("Guess the number between 0-100");

                Console.Write("Your guess: ");
                string sGuessedNum = Console.ReadLine();
                int nGuessedNum;

                if(string.IsNullOrEmpty(sGuessedNum) == true)
                {
                    Console.WriteLine("Please guess a number.");
                }
                else if(int.TryParse(sGuessedNum, out nGuessedNum) == false)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                else if(nGuessedNum == nRandom)
                {
                    Console.WriteLine("Bravo!!!! You guessed just write.");
                    IsNumGuessed = true;
                }
                else if(nGuessedNum > nRandom)
                {
                    Console.WriteLine("Guessed number is too high. Come down a bit.");
                }
                else if(nGuessedNum < nRandom)
                {
                    Console.WriteLine("Guessed number is too low. Come up a bit.");
                }
                else
                {
                    Console.WriteLine("Oops. Please guess once again.");
                }
            }

            Console.ReadKey();
        }
    }
}
