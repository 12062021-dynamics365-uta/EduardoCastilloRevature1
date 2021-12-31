using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human person = new Human("Rick", "Deckard");
            Human person2 = new Human("Sean", "Young");

            Console.WriteLine(person.AboutMe());
            Console.WriteLine(person2.AboutMe());

            Console.WriteLine(" ");

            Human2 jedi = new Human2("Luke", "Skywalker", "Blue");
            Human2 queen = new Human2("Padme", "Amidala", 14);
            Human2 master = new Human2("Obi-wan", "Kenobi", "Green", 47);

            Console.WriteLine(jedi.AboutMe2());
            Console.WriteLine(queen.AboutMe2());
            Console.WriteLine(master.AboutMe2());

            jedi.Weight = 150;
            Console.WriteLine(jedi.Weight);
            jedi.Weight = 450;
            Console.WriteLine(jedi.Weight);
        }
    }
}
