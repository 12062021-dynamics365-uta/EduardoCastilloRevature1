using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;
using Models;

namespace Domain
{
    public class StoreLogic
    {
        DataAccess access;
        List<Product> shoppingCart;
        Customer customer;
        Store store;

        public List<Product> ShoppingCart
        {
            get { return shoppingCart; }
        }
        public Store Store
        {
            get { return store; }
            set { store = value; }
        }

        public StoreLogic()
        {
            access = new DataAccess();
            shoppingCart = new List<Product>();

        }


        public bool ValidateAdm(string password)
        {
            if (password == "123")
                return true;
            else
                return false;
        }




        // Customer actions ****************************************************
        public bool SignIn(Customer c, string password)
        {
            customer = access.FindCustomer(c);
            if(customer == null)
                return false;
            else
            {
                if (customer.Password == password)
                    return true;
                else
                    return false;
            }           
        }
        public Customer FindCustomer(Customer c)
        {
            customer = access.FindCustomer(c);
            return customer;
        }
        public Customer SignUp(Customer c)
        {
            access.AddCustomer(c);
            customer = access.FindCustomer(c);
            return customer;
        }
        public List<Purchases> ViewPastPurchases()
        {
            return access.CustomerPurchases(customer.CustomerID);
        }      
        public void MakePurchase(Order o)
        {
            int id = access.AddOrder(o);
            for (int i = 0; i < shoppingCart.Count;i++)
            {
                Purchases purchase = new Purchases(shoppingCart[i].Name, id);
                access.AddPurchase(purchase);
            }           
        }        
        public void CancelPurchase(Purchases p)
        {
            access.CancelPurchase(p);
        }      
        public object ReviewOrder()
        {
            try
            {
                if (shoppingCart.Count > 50)
                    throw new OrderQuantityLimitException();

                Order order = new Order(customer,store,ShoppingCart);

                if(order.TotalCost>500)
                    throw new OrderTotalCostLimitException();
                return order;
            }
            catch (OrderQuantityLimitException ex)
            {
                return ex;
            }
            catch(OrderTotalCostLimitException ex)
            {
                return ex;
            }
        }
        public bool AddProductToCart(Product product)
        {
            ShoppingCart.Add(product);
            return true;
        }

        public Product FindProduct(string productName)
        {
            Product product = new Product();
            product.Name = productName;
            return access.FindProduct(product);
        }

        public List<Order> PastSales(Customer c)
        {
            return access.PastOrders(c);
        }

        // Store actions ****************************************************
        public List<Order> PastSales(Store e)
        {
            return access.PastOrders(e);
        }

        public List<Product> ViewAvailableProducts(Store s)
        {
            return access.AvailableProducts(s);
        }

        public List<Product> ViewAvailableProducts()
        {
            return access.AvailableProducts();
        }

        public List<Purchases> ViewPastStorePurchases(Store e)
        {
            return access.PastPurchases(e);
        }

        public void AddProduct(string name, decimal price, string description)
        {
            Product product = new Product(name,price,description);
            access.AddProduct(product);
        }
        public void AddInventory(Inventory y)
        {
            access.AddInventory(y);
        }
        public void EditProductDescription(Product p, string newDescription)
        {
            access.EditProduct(p, newDescription);
        }
        public void EditProductPrice(Product p, double newPrice)
        {
            access.EditProduct(p, newPrice);
        }
        public void DeleteProduct(Product p)
        {
            access.DeleteProduct(p);
        }

        
    }
}
