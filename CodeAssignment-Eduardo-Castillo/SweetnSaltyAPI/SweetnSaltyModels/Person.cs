using System;
using System.Collections.Generic;

namespace SweetnSaltyModels
{
    public class Person
    {
        int personId;
        string fname, lname;
        List<Flavor> flavors = new List<Flavor>();

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            set { lname = value; }
            get { return lname; }
        }
        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }
        public List<Flavor> Flavors
        {
            get { return flavors; }
            set { flavors = value; }
        }

        public void LikeAFlavor(Flavor f)
        {
             flavors.Add(f);
        }
    }
}
