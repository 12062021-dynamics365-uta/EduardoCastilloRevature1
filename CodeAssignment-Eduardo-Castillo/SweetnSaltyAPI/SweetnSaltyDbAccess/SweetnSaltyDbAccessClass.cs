using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        private readonly string str = "Data source = EDUARDMDPWS\\SQLEXPRESS;initial Catalog=SweetnSaltyDB; integrated security = true; MultipleActiveResultSets=True";
        private readonly SqlConnection _con;

        //constructor
        public SweetnSaltyDbAccessClass()
        {
            this._con = new SqlConnection(this.str);
            _con.Open();
        }

        public async Task<SqlDataReader> PostFlavor(string flavorname)
        {
            string sql = $"INSERT INTO Flavor VALUES (@flavorname);";
            using (SqlCommand cmd = new SqlCommand(sql, this._con))
            {
                cmd.Parameters.AddWithValue("@flavorname", flavorname);

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrieveFlavor = "SELECT TOP 1 * FROM Flavor ORDER BY FlavorId DESC;";
                    using (SqlCommand cmd1 = new SqlCommand(retrieveFlavor, this._con))
                    {
                        SqlDataReader dr = await cmd1.ExecuteReaderAsync();
                        return dr;
                    }                   
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.PostFlavor {ex.Message}");
                    return null;
                }
            }
        }

        public async Task<SqlDataReader> PostPerson(string fname, string lname)
        {
            string sql = $"INSERT INTO Person VALUES (@fname, @lname)";
            using (SqlCommand cmd = new SqlCommand(sql, this._con))
            {
                cmd.Parameters.AddWithValue("@fname",fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrievePerson = "SELECT TOP 1 * FROM Person ORDER BY PersonId DESC;";
                    using (SqlCommand cmd1 = new SqlCommand(retrievePerson, this._con))
                    {
                        SqlDataReader dr = await cmd1.ExecuteReaderAsync();
                        return dr;
                    }
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.PostPerson {ex.Message}");
                    return null;
                }
            }
        }

        public async Task<SqlDataReader> FindPerson(string fname, string lname)
        {
            string sql = $"SELECT * FROM Person WHERE Fname = @fname AND Lname = @lname;";
            using (SqlCommand cmd = new SqlCommand(sql, this._con))
            {
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                try
                {
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return dr;
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.FindPerson {ex.Message}");
                    return null;
                }
            }

        }

        public async Task<SqlDataReader> FindPerson(int personId)
        {
            string sql = $"SELECT * FROM Person WHERE PersonId = @personId;";
            using (SqlCommand cmd = new SqlCommand(sql, this._con))
            {
                cmd.Parameters.AddWithValue("@personId", personId); 
                try
                {
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return dr;
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.FindPerson {ex.Message}");
                    return null;
                }
            }

        }

        public async void LikeFlavor(int personId, int flavorId)
        {
            string sql = $"INSERT INTO PersonFlavorJunction VALUES (@personId, @flavorId);";
            using (SqlCommand cmd = new SqlCommand(sql, this._con))
            {
                cmd.Parameters.AddWithValue("@personId", personId);
                cmd.Parameters.AddWithValue("@flavorId", flavorId);
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.LikeFlavor {ex.Message}");
                }
            }

        }


        public async Task<SqlDataReader> FindFlavor(string flavor)
        {
            string sql = $"SELECT * FROM Flavor WHERE FlavorName = @flavor;";
            using (SqlCommand cmd = new SqlCommand(sql, this._con))
            {
                cmd.Parameters.AddWithValue("@flavor", flavor);
                try
                {
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return dr;
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.FindFlavor {ex.Message}");
                    return null;
                }
            }
        }

        public async Task<SqlDataReader> FindPersonFlavors(int personId)
        {
            string sql = $"SELECT Flavor.FlavorId, Flavor.FlavorName FROM Flavor JOIN PersonFlavorJunction " +
                $"ON Flavor.FlavorId = PersonFlavorJunction.FlavorId AND PersonFlavorJunction.PersonId = @personId;";
            using (SqlCommand cmd = new SqlCommand(sql, this._con))
            {
                cmd.Parameters.AddWithValue("@personId", personId);
                try
                {
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return dr;
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.FindPersonFlavors {ex.Message}");
                    return null;
                }
            }
        }

        public async Task<SqlDataReader> GetFlavors()
        {
            string sql = $"SELECT * FROM Flavor;";
            using (SqlCommand cmd = new SqlCommand(sql, this._con))
            {
                try
                {
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return dr;
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.GetFlavors {ex.Message}");
                    return null;
                }
            }
        }

    }
}
