using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Purchases
    {
        int purchasesID;
        string productName;
        int orderID;

        DateTime orderedDate;
        string storeName;



        public int PurchasesID
        {
            get { return purchasesID; } 
            set { purchasesID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }              
        }
        public DateTime OrderedDate
        {
            get { return orderedDate; }
            set { orderedDate = value; }
        }
        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }
    }
}
