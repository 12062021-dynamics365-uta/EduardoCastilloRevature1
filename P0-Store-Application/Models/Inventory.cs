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

        public int InventoryID
        {
            get { return inventoryID; }
            set { inventoryID = value; }
        }
        public string ProductName
        {
            get { return productName; }
        }
        public string StoreName
        {
            get { return storeName; }
        }

        public Inventory(string ProductName, string StoreName)
        {
            productName = ProductName;
            storeName = StoreName;
        }
    }
}
