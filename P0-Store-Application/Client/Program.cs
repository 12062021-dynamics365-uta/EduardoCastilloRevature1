using System;
using Domain;
using Models;

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

            Customer customer = new Customer();
            Console.WriteLine("Enter name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter last name");
            customer.LastName = Console.ReadLine();

            if (input == "1")
            {
                Customer c = SL.SignIn(customer);
                if (c != null)
                {
                    SL.SignUp(customer);
                    Console.WriteLine("Hello " + customer.Name + ", enter a store number to see available products.");
                }
                else
                {
                    Console.WriteLine("Hello " + customer.Name + ", welcome back! \nEnter a store number to see available products.");
                }
            }
            else
            {
                SL.SignIn(customer);
                Console.WriteLine("Hello " + customer.Name + ", welcome back! \nEnter a store number to see available products.");

            }
        }//EndMain
    }
}
