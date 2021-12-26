using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Customer
    {       
        int customerID;
        string name;
        string lastName;
        string password;

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
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        //Constructors ***********************
        public Customer()
        {
             
        }

        public Customer(string Name, string LastName, string Password)
        {
            name = Name;
            lastName = LastName;
            password = Password;
        }

    }
}
