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
        public Customer SignIn(Customer c)
        {
            customer = access.FindCustomer(c);
            return customer;
        }
        public void SignUp(Customer c)
        {
            access.AddCustomer(c);
            customer = access.FindCustomer(c);
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

        public bool AddProduct(Product product)
        {
            ShoppingCart.Add(product);
            return true;
        }
    }
}
