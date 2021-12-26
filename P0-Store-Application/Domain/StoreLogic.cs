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

        public StoreLogic()
        {
            access = new DataAccess();
            shoppingCart = new List<Product>();

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

        // Store actions ****************************************************
        public void PastSales()
        {
            access.PastOrders(store);
        }

        public List<Product> ViewAvailableProducts(Store s)
        {
            return access.AvailableProducts(s);
        }

        public List<Purchases> ViewPastStorePurchases()
        {
            return access.PastPurchases(store);
        }

        public void AddProduct(string name, double price, string description)
        {
            Product product = new Product(name,price,description);
            access.AddProduct(product);
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
