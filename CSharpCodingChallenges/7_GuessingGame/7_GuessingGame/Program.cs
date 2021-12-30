using System;
using System.Collections.Generic;

namespace _7_GuessingGameChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("This is the guessing number game");
                Console.WriteLine("You will have 10 opportunities for guess the secret number, lets start");
                int secretNumber = GetRandomNumber();
                string record = "";
                int x = 0;
                for(int i = 0; i<10; i++)
                {
                    int userNumber = GetUsersGuess();
                    record = record + userNumber + ", ";                 
                    Console.WriteLine(record);
                    Console.WriteLine(" ");

                    x = CompareNums(secretNumber, userNumber);
                    if (x == -1)
                        Console.WriteLine("Your guess is higher than the secret number");
                    if(x == 1)
                        Console.WriteLine("Your guess is lower than the secret number");
                    if (x == 0)
                    {
                        Console.WriteLine($"{secretNumber} is the number, you have win!");
                        break;
                    }                       
                }
                if (x != 0)
                    Console.WriteLine("Game over :(\n");

            }while (PlayGameAgain());
        }

        /// <summary>
        /// This method returns a randomly chosen number between 1 and 100, inclusive.
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1,101);
        }

        /// <summary>
        /// This method gets input from the user, 
        /// verifies that the input is valid and 
        /// returns an int.
        /// </summary>
        /// <returns></returns>
        public static int GetUsersGuess()
        {
            int input;
            string s;
            do
            {
                Console.WriteLine("Guess the number. Enter a number between 0 and 100");
                s = Console.ReadLine();
                input = int.Parse(s);

            }while (input < 0 && input > 100);
            return input;
        }

        /// <summary>
        /// This method will has two int parameters.
        /// It will:
        /// 1) compare the first number to the second number
        /// 2) return -1 if the first number is less than the second number
        /// 3) return 0 if the numbers are equal
        /// 4) return 1 if the first number is greater than the second number
        /// </summary>
        /// <param name="randomNum"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public static int CompareNums(int randomNum, int guess)
        {
            if(randomNum < guess)
                return -1;
            else if(randomNum == guess)
                return 0;
            else
                return 1;
        }

        /// <summary>
        /// This method offers the user the chance to play again. 
        /// It returns true if they want to play again and false if they do not.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool PlayGameAgain()
        {
            Console.WriteLine("Play again? Enter 'y' for yes, or 'n' for exit");
            string s = Console.ReadLine();
            if(s == "n")
                return false;
            else
                return true;
        }
    }
}
