using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Exceptions
    {

    }

    internal class OrderQuantityLimitException : Exception
    {
        public override string Message
        {
            get
            {
                return "OrderQuantityLimitException: The maximum number of products per order is 50";
            }
        }
    }

    internal class OrderTotalCostLimitException : Exception
    {
        public override string Message
        {
            get
            {
                return "OrderTotalCostLimitException: The maximum total cost per order is $500";
            }
        }
    }
}

