using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Inventory
    {
        int inventoryID;
        string productName;
        string storeName;

        public Inventory(int id,string ProductName, string StoreName)
        {
            inventoryID = id;
            productName = ProductName;
            storeName = StoreName;
        }
    }
}
