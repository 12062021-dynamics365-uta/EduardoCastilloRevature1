using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyModels
{
    public class Flavor
    {
        int flavorId;
        string  flavorName;

        public int FlavorId
        {
            get { return flavorId; }
            set { flavorId = value; }
        }
        public string FlavorName
        {
            get { return flavorName; }
            set { flavorName = value; }
        }

    }
}
