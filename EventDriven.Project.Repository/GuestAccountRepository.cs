using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Repository
{
    public class GuestAccountRepository
    {
        private string CONNECTIONSTRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelReservationdb;Integrated Security=True;TrustServerCertificate=True";
        public void DeleteClient(int clientId)
        {
            string storedProcedure = "dbo.DeleteClientAccount";

            using(SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                SqlCommand cmd = new SqlCommand(storedProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@ClientId", clientId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
