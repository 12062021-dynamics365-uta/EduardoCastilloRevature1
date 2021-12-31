using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human2 : Human
    {
        string eyeColor;
        int age;
        int weight;

        public int Weight 
        {
            get { return weight;  }
            set
            { 
                if(value > -1 && value < 401)
                     weight = value; 
                else
                    weight = 0;
            }
        }

        public Human2(): base()
        {

        }

        public Human2(string fName, string lName) : base(fName, lName)
        {
        }

        public Human2(string fName, string lName, string EyeColor, int Age) : base(fName, lName)
        {
            eyeColor = EyeColor;
            age = Age;
        }

        public Human2(string fName, string lName, string EyeColor) : base(fName, lName)
        {
            eyeColor = EyeColor;
        }

        public Human2(string fName, string lName, int Age) : base(fName, lName)
        {
            age = Age;
        }

        public string AboutMe2()
        {
            string sentence = $"My name is {firstName} {lastName}.";
            if (age != 0)
                sentence += $" My age is {age}.";
            if (eyeColor != null)
                sentence += $" My eye color is {eyeColor}.";
            return sentence;
        }
    }
}