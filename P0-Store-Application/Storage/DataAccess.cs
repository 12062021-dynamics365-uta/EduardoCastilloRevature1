using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Storage
{
    public class DataAccess
    {
        string str = "Data source = EDUARDMDPWS\\SQLEXPRESS;initial Catalog=PO-Store-Data; integrated security = true";

        public void AddCustomer(string name, string lastName)
        {
            SqlConnection con = new SqlConnection(str);
            string querystring = "INSERT INTO Customers (Name, LastName) VALUES ('" + name + "', '" + lastName + "');";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string[] FindCustomer(string name, string lastName)
        {
            string[] fullName = new string[2];

            SqlConnection con = new SqlConnection(str);
            string querystring = "SELECT Name, LastName FROM Customers WHERE Name = '" + name + "' AND + LastName = '" + lastName + "';";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fullName[0] = dr[0].ToString();
                fullName[1] = dr[1].ToString();
            }
            return fullName;
        }

    }
}
