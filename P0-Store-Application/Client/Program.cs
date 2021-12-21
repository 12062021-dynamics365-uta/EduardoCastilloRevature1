using System;
using Domain;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreLogic SL = new StoreLogic();
            Console.WriteLine("Welcome to WebShopping!\n");
            Console.WriteLine("Our Stores: ");
            Console.WriteLine("1. PCMart           2. BestBytes");
            Console.WriteLine("3. HomeLaptops      4. PhoneDepot\n");

            string input;
            do
            {
                Console.WriteLine("Press 1 for new Customer or 2 for sing in");
                input = Console.ReadLine();
            } while ((input != "1") && (input != "2"));

            Console.WriteLine("Enter name");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string customerLastName = Console.ReadLine();

            if (input == "1")
            {
                Customer c = SL.SignIn(customerName, customerLastName);
                if (c != null)
                {
                    SL.SignUp(customerName, customerLastName);
                    Console.WriteLine("Hello " + customerName + ", enter a store number to see available products.");
                }
                else
                {
                    Console.WriteLine("Hello " + customerName + ", welcome back! \nEnter a store number to see available products.");
                }
            }
            else
            {
                SL.SignIn(customerName, customerLastName);
                Console.WriteLine("Hello " + customerName + ", welcome back! \nEnter a store number to see available products.");

            }
        }//EndMain
    }
}
