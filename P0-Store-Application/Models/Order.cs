using System;
using System.Collections.Generic;


namespace Models
{
    public class Order
    {
        List<Product> products;

        int id;
        Customer customer;
        Store store;
        DateTime date;
        decimal totalCost;


         //Properties ************************
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Customer Customer
        {
            get { return customer; }
        }
        public Store Store
        {
            get { return store; }
        }
        public DateTime Date
        {
            get { return date; }
        }
        public decimal TotalCost
        {
            get { return totalCost; }
        }
        public List<Product> Products
        {
            get { return products; }
        }



        //Constructors  **************************************
       public Order(Customer c, Store s, List<Product> p)
       {
            customer = c;
            store = s;
            date = DateTime.Now;
            products = p;
            totalCost = GetTotalCost(p);
        }
      
        public Order(int orderID, Customer c,Store s, DateTime orderedDate, decimal total)
        {
            id = orderID;
            customer = c;
            store=s;
            date = orderedDate;
            totalCost = total;
        }



        //Methods  **********************************************
        private decimal GetTotalCost(List<Product> prods)
        {
            decimal totalcost = 0;
            for(int i = 0; i < prods.Count; i++)
            {
                totalcost += prods[i].Price;
            }
            return totalcost;
        }
        
    }
}
