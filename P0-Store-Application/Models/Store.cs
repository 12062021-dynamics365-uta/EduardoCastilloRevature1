using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Store
    {
        string storeName;
        public string StoreName
        {
            get { return storeName; }
        }

        public Store(string name)
        {
            storeName = name;
        }

    }
}
