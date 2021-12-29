using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            *
            * implement the required code here and within the methods below.
            *
            */

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine($"Hello {ConcatNames(name,lastName)}, Write a sentence");
            string input = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine($"The upper case version: {StringToUpper(input)}");
            Console.WriteLine($"The lower case version: {StringToLower(input)}");
            Console.WriteLine($"The trimed version: {StringTrim(input)}");
            Console.WriteLine(" ");
            Console.WriteLine("Now lets take a word from the sentence, enter the number position of the first letter");
            int startIndex = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Enter the length");
            int legth = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The word: {StringSubstring(input,startIndex,legth)}");
            Console.WriteLine(" ");
            Console.WriteLine("Find a letter in the sentence. Enter a letter to find its position");
            char letter = (char)Console.Read();
            Console.WriteLine(" ");
            Console.WriteLine($"The letter {letter} appears first at {SearchChar(input,letter)}th position");
        }

        /// <summary>
        /// This method has one string parameter and will: 
        /// 1) change the string to all upper case and 
        /// 2) return the new string.
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>
        public static string StringToUpper(string usersString)
        {
            return usersString.ToUpper();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) change the string to all lower case,
        /// 2) return the new string into the 'lowerCaseString' variable
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>       
        public static string StringToLower(string usersString)
        {
            return usersString.ToLower();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) trim the whitespace from before and after the string, and
        /// 2) return the new string.
        /// HINT: When getting input from the user (you are the user), try inputting "   a string with whitespace   " to see how the whitespace is trimmed.
        /// </summary>
        /// <param name="usersStringWithWhiteSpace"></param>
        /// <returns></returns>
        public static string StringTrim(string usersStringWithWhiteSpace)
        {
            return usersStringWithWhiteSpace.Trim();
            //Remove the white spaces at the begining and at the end of the string
        }

        /// <summary>
        /// This method has three parameters, one string and two integers. It will:
        /// 1) get the substring based on the first integer element and the length 
        /// of the substring desired.
        /// 2) return the substring.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="firstElement"></param>
        /// <param name="lastElement"></param>
        /// <returns></returns>
        public static string StringSubstring(string x, int firstElement, int lengthOfSubsring)
        {
            return x.Substring(firstElement, lengthOfSubsring);
            //FirstElement is the index where it will start to count, and lengthOfSubsring is the number to count after the starting index 
        }

        /// <summary>
        /// This method has two parameters, one string and one char. It will:
        /// 1) search the string parameter for first occurrance of the char parameter and
        /// 2) return the index of the char.
        /// HINT: Think about how StringTrim() (above) would be useful in this situation
        /// when getting the char from the user. 
        /// </summary>
        /// <param name="userInputString"></param>
        /// <param name="charUserWants"></param>
        /// <returns></returns>
        public static int SearchChar(string userInputString, char charUserWants)
        {
            return userInputString.IndexOf(charUserWants);
            //returns the index where the char appears for first time
        }

        /// <summary>
        /// This method has two string parameters. It will:
        /// 1) concatenate the two strings with a space between them.
        /// 2) return the new string.
        /// HINT: You will need to get the users first and last name in the 
        /// main method and send them as arguments.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public static string ConcatNames(string fName, string lName)
        {
            return fName + " " + lName;
        }
    }//end of program
}
