using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /**
                YOUR CODE HERE.
            **/
            string name = GetName();
            Console.WriteLine(" ");
            Console.WriteLine( GreetFriend(name));

            double x = GetNumber();
            double y = GetNumber();
            int action = GetAction();

            Console.WriteLine("result:");
            DoAction(x, y, action);

        }

        public static string GetName()
        {
            Console.WriteLine("Hello there, please, type your name");
            return Console.ReadLine();
        }

        public static string GreetFriend(string name)
        {
            return $"Hello, {name}. You are my friend.";
        }

        public static double GetNumber()
        {
            double num = 0;
            string number;
            do
            {
                Console.WriteLine("Enter a number");
                number = Console.ReadLine();


            } while (!Double.TryParse(number, out num));

            return num;
        }

        public static int GetAction()
        {
            string action;
            do
            {
                Console.WriteLine("Enter a number action. 1)add, 2)subtract, 3)multiply, or 4)divide");
                action = Console.ReadLine();

            }while (action != "1" && action != "2" && action != "3" && action != "4");
            
            return int.Parse(action);
        }

        public static double DoAction(double x, double y, int action)
        {
            if (action != 1 && action != 2 && action != 3 && action != 4)
                throw new FormatException();

            double result = 0;
            switch (action)
            {
                case 1:
                    result = x + y;
                    break;
                case 2:
                    result = y - x;
                    break;
                case 3:
                    result = x * y;
                    break;
                case 4:
                    try
                    {
                        result = x / y;
                    }
                    catch
                    {

                    }
                    break;
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
