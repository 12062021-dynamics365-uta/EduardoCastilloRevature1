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
        public Customer SignIn(Customer customer)
        {
            return customer;
        }
        public void SignUp(Customer customer)
        {
            access.AddCustomer(customer);
        }
        public List<Purchases> ViewPastPurchases(Customer c)
        {
            return access.CustomerPurchases(c.CustomerID);
        }      

        public void MakePurchase()
        {

        }

        public void CancelPurchase()
        {

        }

        //Methods
        public void AddProduct(Product product)
        {
            ShoppingCart.Add(product);
        }
    }
}
