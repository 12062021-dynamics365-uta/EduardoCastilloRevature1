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

            string input = "";

            while (input != "3")
            {
                do
                {
                    Console.WriteLine("Press 1 for new Customer, 2 for sign in or 3 for exit");
                    input = Console.ReadLine();
                } while ((input != "1") && (input != "2") && (input != "3"));

                if (input == "3")
                    break;

                Customer customer = new Customer();
                Console.WriteLine("Enter name");
                customer.Name = Console.ReadLine();
                Console.WriteLine("Enter last name");
                customer.LastName = Console.ReadLine();

                if (input == "1")
                {
                    Customer c = SL.FindCustomer(customer);
                    while(c != null)
                    {
                        Console.WriteLine("Shopper " + c.Name + " " + c.LastName + " already exists, type another name or enter 2 for more options.");
                        Console.WriteLine("Enter name");
                        input = Console.ReadLine();
                        if (input == "2")
                            break;
                        else
                            customer.Name = input;
                        Console.WriteLine("Enter last name");
                        customer.LastName = Console.ReadLine();
                        c = SL.FindCustomer(customer);
                    }
                    if(input != "2")
                    {
                        Console.WriteLine("Enter your password to log in next time");
                        customer.Password = Console.ReadLine();
                        while(customer.Password.Length < 2)
                        {
                            Console.WriteLine("Password too short, try a longer one\nPassword:");
                            customer.Password = Console.ReadLine();
                        }
                        SL.SignUp(customer);
                        Console.WriteLine("Hello " + customer.Name + ", enter a store number to see available products.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Password:");
                    input = Console.ReadLine();
                    while(SL.SignIn(customer, input) != true)
                    {
                        Console.WriteLine("Wrong password, please try again or enter 2 for more options.\nPassword:");
                        input = Console.ReadLine();
                        if (input == "2")
                            break;
                    }
                    if(input != "2")
                    {
                        customer.Password = input;
                        Console.WriteLine("Hello " + customer.Name + ", welcome back! \nEnter a store number to see available products.");
                        break;
                    }
                    
                }
            }





            

            

            
        }//EndMain
    }
}
