using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human
    {
        protected string lastName = "Smyth";
        protected string firstName = "Pat";

        public Human()
        {

        }

        public Human(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;           
        }

        public string AboutMe()
        {
            return $"My name is {firstName} {lastName}.";
        }
    }//end of class
}//end of namespace