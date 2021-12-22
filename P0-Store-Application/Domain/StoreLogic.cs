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

        public StoreLogic()
        {
            access = new DataAccess();






        }

        public Customer SignIn(string name, string lastName)
        {
            string[] fullName = access.FindCustomer(name, lastName);
            return new Customer(fullName[0], fullName[1]);
        }

        public void SignUp(string name, string lastName)
        {
            access.AddCustomer(name, lastName);
        }
    }
}
