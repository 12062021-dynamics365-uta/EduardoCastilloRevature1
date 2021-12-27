using System;
using System.Collections.Generic;
using Domain;
using Models;

namespace Client
{
    internal class Program
    {
        static StoreLogic SL = new StoreLogic();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WebShopping!\n");          

            string input = "";

            while (input != "3")
            {
                Console.WriteLine("Our Stores: ");
                Console.WriteLine("1. PCMart           2. BestBytes");
                Console.WriteLine("3. HomeLaptops      4. PhoneDepot\n");
                do
                {
                    Console.WriteLine("Enter 1 for new Customer, 2 for sign in and 3 for exit\n4 for Adm.");
                    input = Console.ReadLine();
                } while ((input != "1") && (input != "2") && (input != "3") && (input != "4"));

                if (input == "3")
                    break;

                Customer customer = new Customer();
                if (input != "4")
                {                   
                    Console.WriteLine("Enter name");
                    customer.Name = Console.ReadLine();
                    Console.WriteLine("Enter last name");
                    customer.LastName = Console.ReadLine();
                }

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
                                              
                        StartShopping(customer);

                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                }
                else if(input == "2")
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
                        StartShopping(SL.Customer);

                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                    
                }
                else
                {
                    string exit = " ";
                    do
                    {
                        string pass = "";
                        do
                        {
                            Console.WriteLine("Enter Administrator password or 'c' to cancel:");
                            pass = Console.ReadLine();
                            
                        }while(SL.ValidateAdm(pass) != true && pass != "c");

                        if (pass == "c")
                            break;

                        Console.WriteLine("Administrator session\n");
                        string admInput = "";
                        while ((admInput != "0") && (admInput != "1") && (admInput != "2") && (admInput != "3") && (admInput != "4") && (admInput != "all"))
                        {
                            Console.WriteLine("1. PCMart           2. BestBytes");
                            Console.WriteLine("3. HomeLaptops      4. PhoneDepot\n");
                            Console.WriteLine("Enter store number for see store's sales, or enter 'all' for see all sales");
                            Console.WriteLine("Enter 0 for manage product inventory");
                            admInput = Console.ReadLine();
                        }
                        switch (admInput)
                        {
                            case "0":
                                Inventory();
                                break;
                            case "1":
                                StoreSales("PCMart");
                                break;
                            case "2":
                                StoreSales("BestBytes");
                                break;
                            case "3":
                                StoreSales("HomeLaptops");
                                break;
                            case "4":
                                StoreSales("PhoneDepot");
                                break;
                            default:
                                StoreSales();
                                break;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Enter 'exit' for exit Administrator session or anything else to stay inside");
                        exit = Console.ReadLine();
                    } while (exit != "exit");
                    

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }

            }

        }//EndMain


        public static void StoreSales(string name)
        {
            Store s = new Store(name);
            List<Order> orders = SL.PastSales(s);
            Console.WriteLine(" ");
            Console.WriteLine($"{name} Sales:");
            foreach (Order o in orders)
            {                
                Console.WriteLine($"Customer name: {o.Customer.Name} {o.Customer.LastName}  Date: {o.Date}  OrderID: {o.Id}  Total: ${o.TotalCost}");
            }

            Console.WriteLine("");
            List<Purchases> purchases = SL.ViewPastStorePurchases(s);
            Console.WriteLine($"{name} Sold Products:");
            foreach(Purchases p in purchases)
            {
                Console.WriteLine($"Product: {p.ProductName}  Date: {p.OrderedDate}  OrderID: {p.OrderID}");
            }
        }

        public static void StoreSales()
        {
            StoreSales("PCMart");
            StoreSales("BestBytes");
            StoreSales("HomeLaptops");
            StoreSales("PhoneDepot");
        }

        public static void Inventory()
        {
            List<Product> products = SL.ViewAvailableProducts();
            foreach (Product p in products)
            {
                Console.WriteLine($"Product Name: {p.Name}  Price: ${p.Price}  Description: {p.Description}");
            } 
            
            string input = " ";
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("For add a new product enter 1, for delete a product enter 2 and for edit a product enter 3");
                input = Console.ReadLine();
            } while ((input != "1") && (input != "2") && (input != "3"));
            switch (input)
            {
                case "1":
                    NewProduct();
                    Console.WriteLine("Product Added");
                    break;
               case "2":
                    DeleteProduct();
                    Console.WriteLine("Product deleted");
                    break ;
               case "3":
                    EditProduct();
                    Console.WriteLine("Product edited");
                    break ;
            }
        }

        public static void NewProduct()
        {
            Product p = new Product();
            Console.WriteLine("Enter new product name:");
            p.Name = Console.ReadLine();
            Console.WriteLine("Enter price:");
            p.Price = decimal.Parse( Console.ReadLine());
            Console.WriteLine("Enter a descripcion");
            p.Description = Console.ReadLine();
            SL.AddProduct(p.Name,p.Price,p.Description);           
            string number = "";
            do
            {
                Console.WriteLine("Enter a store location number");
                number = Console.ReadLine();
            } while ((number != "1") && (number != "2") && (number != "3") && (number != "4"));
            string storeName = "";
            switch (number)
            {
                case "1":
                    storeName = "PCMart";
                    break;
                case "2":
                    storeName = "BestBytes";
                    break;
                case "3":
                    storeName = "HomeLaptops";
                    break;
                case "4":
                    storeName = "PhoneDepot";
                    break;

            }
            Inventory inventory = new Inventory(p.Name, storeName);
            SL.AddInventory(inventory);

        }

        public static void EditProduct()
        {
            Console.WriteLine("Enter name of the product to edit");
            Product product = new Product();
            product.Name = Console.ReadLine();
            while (SL.FindProduct(product.Name) == null)
            {
                Console.WriteLine("This product has not been found. Write a product name to edit");
                product.Name = Console.ReadLine();
            }

            string input = "";
            do
            {
                Console.WriteLine("Enter 1 for change price or 2 for change description");
                input = Console.ReadLine();
            } while ((input != "1") && (input != "2"));
            if(input == "1")
            {
                Console.WriteLine("Enter new price:");
                double price = Double.Parse( Console.ReadLine());
                SL.EditProductPrice(product, price);
            }
            else
            {
                Console.WriteLine("Enter new description:");
                SL.EditProductDescription(product, Console.ReadLine());
            }
        }

        public static void DeleteProduct()
        {
            Console.WriteLine("Enter name of the product to delete");           
            Product product = new Product();
            product.Name = Console.ReadLine();

            while (SL.FindProduct(product.Name) == null)
            {
                Console.WriteLine("This product has not been found. Write a product name to delete");
                product.Name = Console.ReadLine();
            }
            SL.DeleteProduct(product);
        }      

        public static void StartShopping(Customer customer)
        {
            bool exit = false;
            do
            {
                string number = "";
                do
                {
                    Console.WriteLine("Hello " + customer.Name + ", enter a store number to see available products.");
                    number = Console.ReadLine();
                } while ((number != "1") && (number != "2") && (number != "3") && (number != "4"));

                string storeName = "";
                switch (number)
                {
                    case "1":
                        storeName = "PCMart";
                        break;
                    case "2":
                        storeName = "BestBytes";
                        break;
                    case "3":
                        storeName = "HomeLaptops";
                        break;
                    case "4":
                        storeName = "PhoneDepot";
                        break;

                }

                SL.Store = new Store(storeName);
                List<Product> products = SL.ViewAvailableProducts(SL.Store);
                foreach (Product p in products)
                {
                    Console.WriteLine($"Product Name: {p.Name}  Price: ${p.Price}  Description: {p.Description}");
                }
                Console.WriteLine(" ");

                Product product = new Product();
                Console.WriteLine("Write the name of the product to add it to the cart. \n" +
                       "Or Type 1 for change store, 2 for a view of past purchases, 3 to view past product sales, or 'exit' to exit");
                string input = Console.ReadLine();

                product = SL.FindProduct(input);
                while ((input != "1") && (input != "2") && (input != "3") && (input != "exit") && (product == null))
                {
                    Console.WriteLine("This product has not been found.\n");
                    Console.WriteLine("Write the name of the product to add it to the cart. \n" +
                        "Or Type 1 for change store, 2 for a view of past purchases, 3 to view past product sales, or 'exit' to exit \n");
                    input = Console.ReadLine();
                    product = SL.FindProduct(input);
                }

                switch (input)
                {
                    case "1":
                        Console.WriteLine(" ");
                        break;
                    case "2":
                        CustomerPastPurchases(customer);
                        break;
                    case "3":
                        ViewPastPurchases(SL.Store);
                        break;
                    case "exit":
                        exit=true;
                        break;
                    default:
                        BuyProducts(product);
                        break;
                }
            } while (exit == false);
            



        }

        public static void CustomerPastPurchases(Customer c)
        {
           List<Purchases> purchases = SL.ViewPastPurchases();
            Console.WriteLine("Past purchases: ");
            foreach (Purchases p in purchases)
            {
                Console.WriteLine($"Product: {p.ProductName}  Date: {p.OrderedDate}  OrderID: {p.OrderID}  Store: {p.StoreName}");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Past orders: ");
            List<Order> orders = SL.PastSales(c);
            foreach (Order o in orders)
            {
                Console.WriteLine($"Date: {o.Date}  OrderID: {o.Id}  Total: ${o.TotalCost}");
            }
            Console.WriteLine(" ");
        }

        public static void ViewPastPurchases(Store store)
        {
            List<Purchases> purchases = SL.ViewPastStorePurchases(store);
            Console.WriteLine("Sales: ");
            foreach (Purchases p in purchases)
            {
                Console.WriteLine($"Product: {p.ProductName}  Date: {p.OrderedDate} ");
            }
            Console.WriteLine(" ");
        }

        public static void BuyProducts(Product p)
        {           
            SL.AddProductToCart(p);
            Console.WriteLine("Added \n");
            Console.WriteLine("Enter 1 for view cart or anything else to continue shopping.\n");
            if(Console.ReadLine() == "1")
            {
                Console.WriteLine("Shopping Cart");
                foreach (Product product in SL.ShoppingCart)
                {                  
                    Console.WriteLine($"Product Name: {product.Name}  Price: ${product.Price}  Description: {product.Description}");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Enter 2 for checkout or anything else to continue shopping.");
                if (Console.ReadLine() == "2")
                {
                    Order order;
                    try
                    {
                        order = (Order)SL.ReviewOrder();
                        Console.WriteLine("Order:");
                        Console.WriteLine($"Store: {order.Store.StoreName}  Date: {order.Date}  Total: ${order.TotalCost} \n");
                        Console.WriteLine("Enter 'y' to place order or 'n' to cancel");
                        string decision = Console.ReadLine();
                        if(decision == "y")
                        {
                            SL.MakePurchase(order);
                            Console.WriteLine("Placed order \n");
                        }
                        else if(decision == "n")
                        {
                            SL.ShoppingCart.Clear();
                            Console.WriteLine("Order has been canceled");
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
