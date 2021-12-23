using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
   
   must be able to purchase 1 or more products
   must be able to view current cart
   must be able to checkout
   must be able to cancel a purchase
 */

namespace Models
{
    public class Customer
    {       
        int customerID;
        string name;
        string lastName;

        //Properties ************************
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }        



        //Constructors ***********************
        public Customer()
        {
             
        }

        public Customer(string Name, string LastName)
        {
            name = Name;
            lastName = LastName;
        }

    }
}
