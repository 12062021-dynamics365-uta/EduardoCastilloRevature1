using System;

namespace Rock_Paper_Scissors_Demo1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello. Welcome to Rock-Paper-Scissors Game!");


			/**homework - 
			 * 1. get a random number for the computer
			 * 2. compare who won the round
			 * 3. refactor the code to have a best of three game
			 * 4. print out the winner, and how many games were won by each (and ties)
			 * 5. and exit the program.
			 * 
			 * 
			 * 
			 * 
			**/

			Random randNum = new Random();

			int userWon = 0;
			int computerWon = 0;			

			//three games
			for (int i=0; i < 3; i++)
            {
				int convertedNumber = Validate(); //Take user input
				int computerNumber = randNum.Next(1, 4); //inclusive of the first(lower) value and exclusive of hte second(upper) value.
				string computerAttempt = Translate(computerNumber);
				string userAttempt = Translate(convertedNumber);
				Console.WriteLine("User: " + userAttempt + "   VS   Computer: " + computerAttempt);				
				switch (userAttempt + computerAttempt)
                {
					case "ROCKPAPER":
						computerWon++;
						Console.WriteLine("Round winner: Computer");
						break;
					case "ROCKSCISSORS":
						userWon++;
						Console.WriteLine("Round winner: User");
						break;
					case "PAPERSCISSORS":
						computerWon++;
						Console.WriteLine("Round winner: Computer");
						break;
					case "PAPERROCK":
						userWon++;
						Console.WriteLine("Round winner: User");
						break;
					case "SCISSORSROCK":
						computerWon++;
						Console.WriteLine("Round winner: Computer");
						break;
					case "SCISSORSPAPER":
						userWon++;
						Console.WriteLine("Round winner: User");
						break;
					default:
						i--;
						Console.WriteLine("Round not valid");//manage match as PAPER and PAPER
						break;
				}
			}

			Console.WriteLine("User won: " + userWon + "     Computer won: " + computerWon);
			Console.WriteLine(" ");
			if (userWon > computerWon)
				Console.WriteLine("Unbeatable Champion: User");
			else
				Console.WriteLine("Unbeatable Champion: Computer");
		}


		//Translate 1, 2 and 3 in ROCK, PAPER and SCISSORS
		static string Translate(int number)
        {
			string word;
            switch (number)
            {
				case 1:
					word = "ROCK";
					break;
				case 2:
					word = "PAPER";
					break;
				case 3:
					word = "SCISSORS";
					break;
				default:
					word = "";
					break;
			}
			return word;		
		}


		//Validate user input
		static int Validate()
        {
			int convertedNumber = -1;
			bool conversionBool = false;
			do
			{
				Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
				string userInput = Console.ReadLine();

				//this version of TryParse() takes a string and the second argument is an out variable that is instantiated in that moment.
				conversionBool = Int32.TryParse(userInput, out convertedNumber);
				if (!conversionBool || convertedNumber < 1 || convertedNumber > 3)
				{
					Console.WriteLine("Hey, buddy... that wasn't a 1 or 2 or 3!");
				}

			} while (!(convertedNumber > 0 && convertedNumber < 4));

			return convertedNumber;
		}

		
	}
}
