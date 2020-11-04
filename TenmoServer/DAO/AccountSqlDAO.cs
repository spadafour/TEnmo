using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.DAO
{
    public class AccountSqlDAO : IAccountDAO
    {
        private readonly string ConnectionString;

        public AccountSqlDAO(string dbConnectionString)
        {
            ConnectionString = dbConnectionString;
        }

        public decimal GetBalance(int userId)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    decimal acctBalance = 0;
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select balance from accounts where user_id = @userId");
                    cmd.Parameters.AddWithValue("@userId", userId);
                    acctBalance = Convert.ToDecimal(cmd.ExecuteScalar());
                    return acctBalance;
                }
            }
            catch (Exception e) //SQL Exception???
            {
                throw e;
            }        
        }
    }
}
