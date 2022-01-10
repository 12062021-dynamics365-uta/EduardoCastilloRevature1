using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public interface ISweetnSaltyDbAccessClass
    {
        Task<SqlDataReader> PostFlavor(string flavorname);
        Task<SqlDataReader> PostPerson(string fname, string lname);
        Task<SqlDataReader> FindPerson(string fname, string lname);
        void LikeFlavor(int personId, int flavorId);
        Task<SqlDataReader> FindFlavor(string flavor);
        Task<SqlDataReader> FindPerson(int personId);
        Task<SqlDataReader> FindPersonFlavors(int personId);
        Task<SqlDataReader> GetFlavors();
    }
}
