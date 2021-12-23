using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace Storage
{
    public class DataAccess
    {
        string str;
        SqlConnection con;

        public DataAccess()
        {
            str = "Data source = EDUARDMDPWS\\SQLEXPRESS;initial Catalog=PO-Store-Data; integrated security = true";
            con = new SqlConnection(str);
        }

        public void AddCustomer(Customer c)
        {
            string querystring = "INSERT INTO Customers (Name, LastName) VALUES ('" + c.Name + "', '" + c.LastName + "');";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Customer FindCustomer(Customer c)
        {
            Customer customer = null;

            string querystring = "SELECT * FROM Customers WHERE Name = '" + c.Name + "' AND + LastName = '" + c.LastName + "';";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                customer.CustomerID = (int)dr[0];
                customer.Name = dr[1].ToString();
                customer.LastName = dr[2].ToString();
            }
            return customer;
        }

        public List<Purchases> CustomerPurchases(int customerID)
        {
            // return List of past purchsases of that customer
            string sql = "SELECT Purchases.PurchasesID, Purchases.ProductName, Orders.OrderID, Orders.OrderedDate, Orders.StoreName FROM Orders INNER JOIN Purchases ON Purchases.OrderID = Orders.OrderID AND Orders.OrderID = " + customerID + ";";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            List<Purchases> purchases = new List<Purchases>();
            while (dr.Read())
            {
                Purchases purchu = new Purchases()
                {
                    PurchasesID = (int)dr[0],
                    ProductName = dr[1].ToString(),
                    OrderID = (int)dr[2],
                    OrderedDate = (DateTime)dr[3],
                    StoreName = dr[4].ToString()
                };
                purchases.Add(purchu);
            }
            return purchases;
        }

    }
}
