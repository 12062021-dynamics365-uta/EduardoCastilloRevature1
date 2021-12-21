using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * must be able to view past purchases
   must be able to view available store locations
   must be able to purchase 1 or more products
   must be able to view current cart
   must be able to checkout
   must be able to cancel a purchase
 */

namespace Domain
{
    public class Customer
    {
        List<Product> shoppingCart;
        string name;
        string lastName;

        public string Name
        {
            get { return name; }
        }
        public string LastName
        {
            get { return lastName; }
        }

        public Customer(string Name, string LastName)
        {
            name = Name;
            lastName = LastName;
        }

        public List<Product> ShoppingCart
        {
            get { return shoppingCart; }
        }

        public void ViewPastPurchases()
        {

        }

        public void ViewAvailableStores()
        {

        }

        public void MakePurchase()
        {

        }

        public void CancelPurchase()
        {

        }

        public void AddProduct(Product product)
        {
            ShoppingCart.Add(product);
        }
    }
}
