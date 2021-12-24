using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * must be able to view past sales
   must be able to view sales by store location
   [stretch goal] must be able to manage product inventory (add, edit, delete any product)
*/

namespace Models
{
    public class Store
    {
        string storeName;
        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }




        public void PastSales()
        {

        }

        public void AddProduct()
        {

        }
        public void EditProduct()
        {

        }
        public void DeleteProduct()
        {

        }
    }
}
