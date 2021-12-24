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
            con.Close();
            return customer;
        }
        public Customer FindCustomer(int id)
        {
            Customer c = null;
            string sql = $"SELECT * FROM Customers WHERE CustomerID = {id};";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c.CustomerID = id;
                c.Name = dr[1].ToString();
                c.LastName = dr[2].ToString();
            }
            con.Close();
            return c;
        }

        public List<Purchases> CustomerPurchases(int customerID)
        {
            // return List of past purchsases of that customer
            string sql = "SELECT Purchases.PurchasesID, Purchases.ProductName, Orders.OrderID, Orders.OrderedDate, Orders.StoreName " +
                "FROM Orders INNER JOIN Purchases ON Purchases.OrderID = Orders.OrderID AND Orders.OrderID = " + customerID + ";";
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

        public int AddOrder(Order o)
        {
            string sql = $"INSERT INTO Orders (CustomerID, StoreName, OrderedDate,Total) " +
                $"VALUES ({o.Customer.CustomerID}, '{o.Store.StoreName}','{o.Date}',{o.TotalCost});";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return GetOrderID(o);
        }

        public void AddPurchase(Purchases p)
        {
            string sql = $"INSERT INTO Purchases (ProductName, OrderID) VALUES ('{p.ProductName}','{p.OrderID}')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private int GetOrderID(Order o)
        {
            int id = -1;
            string sql = $"SELECT OrderID FROM Orders " +
                $"WHERE CustomerID = {o.Customer.CustomerID} AND StoreName = '{o.Store.StoreName}' AND OrderedDate = '{o.Date}' AND Total = {o.TotalCost};";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = (int)dr[0];
            }
            con.Close();
            return id;
        }

        private double GetProductPrice(string productName)
        {
            double price = 0;
            string sql = $"SELECT Price FROM Products WHERE ProductName = '{productName}';";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                price = (int)dr[0];
            }
            con.Close();
            return price;
        }

        public void CancelPurchase(Purchases p)
        {
            double price = GetProductPrice(p.ProductName);
            string sql = $"UPDATE Orders SET Total = Total - {price} WHERE OrderID = {p.OrderID};";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            string sql2 = $"DELETE FROM Purchases WHERE PurchasesID = {p.PurchasesID};";
            con.Open();
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }



        // Store ****************************************************
        public List<Order> PastOrders(Store s)
        {
            string sql = $"SELECT * FROM Orders WHERE StoreName = '{s.StoreName}';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            List<Order> orders = new List<Order>();
            while(dr.Read())
            {
                Customer customer = FindCustomer((int)dr[1]);
                Store store = FindStore(dr[2].ToString());
                Order order = new Order( (int)dr[0], customer, store, (DateTime)dr[3], (double)dr[4]); 
                orders.Add(order);
            }
            return orders;
        }

        public List<Purchases> PastPurchases(Store s)
        {
            string sql = $"SELECT Purchases.PurchasesID, Purchases.ProductName, Purchases.OrderID FROM Purchases INNER JOIN Orders ON" +
                $" Purchases.OrderID = Orders.OrderID AND Orders.StoreName = '{s.StoreName}';";

            List<Purchases> purchases = new List<Purchases>();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
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

        private Store FindStore(string name)
        {
            Store store = null;
            string sql = $"SELECT * FROM Stores WHERE StoreName = '{name}';";
           
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                store = new Store(dr[0].ToString());
            }
            con.Close();
            return store;
        }

        public List<Product> AvailableProducts(Store store)
        {
            List<Product> products = new List<Product>();      
            string sql = $"SELECT Products.ProductName, Products.Price, Products.Description FROM Products INNER JOIN Inventory ON" +
                $" Products.ProductName = Inventory.ProductName AND Inventory.StoreName = '{store.StoreName}';";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Product product = new Product()
                {
                    Name = dr[0].ToString(),
                    Price = (double)dr[1],
                    Description = dr[2].ToString()

                };
                products.Add(product);
            }
            return products;
        }

        public void AddProduct(Product p)
        {
            string sql = $"INSERT INTO Products (ProductName, Price, Description) VALUES ('{p.Name}',{p.Price},'{p.Description}'; ";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteProduct(Product p)
        {
            string sql = $"DELETE FROM Products WHERE ProductName = {p.Name};";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EditProduct(Product p, string description)
        {
            string sql = $"UPDATE Products SET Description = '{description}' WHERE ProductName = '{p.Name}';";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EditProduct(Product p, double price)
        {
            string sql = $"UPDATE Products SET Price = {price} WHERE ProductName = '{p.Name}';";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
