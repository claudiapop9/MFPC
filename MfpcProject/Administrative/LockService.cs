using MfpcProject.Models;
using Microsoft.Data.SqlClient;

namespace MfpcProject.Administrative
{
    public class LockService
    {
        private string connectionString = "Server=(localdb)\\mssqllocaldb;Database=MFPC-Project-Transactions;Trusted_Connection=True;MultipleActiveResultSets=true";
        private readonly SqlConnection connection;
        public LockService()
        {
            connection = new SqlConnection(connectionString);
        }

        public bool ExistsTable()
        {
            connection.Open();
            return true;
        }
    }
}
