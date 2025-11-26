using System.Data;
using System.Data.SqlClient;
using EventDriven.Project.Model;
using Microsoft.Win32.SafeHandles;

namespace EventDriven.Project.Repository
{
    public class UserRepository
    {
        private string CONNECTIONSTRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelReservationdb;Integrated Security=True;TrustServerCertificate=True";

        public User ValidateUser(string Username, string Password)
        {
            try
            {
                User matchingUser = new User();
                using (SqlConnection Hotel = new SqlConnection(CONNECTIONSTRING))
                {
                    Hotel.Open();
                    string query = "SELECT * FROM dbo.[User] WHERE Username = @username AND Password = @password";
                    using (SqlCommand command = new SqlCommand(query, Hotel))
                    {
                        command.Parameters.AddWithValue("@username", Username);
                        command.Parameters.AddWithValue("@password", Password);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        {
                            if (table.Rows.Count >= 1)
                            {
                                matchingUser = new User
                                {
                                    Id = Convert.ToInt32(table.Rows[0]["Id"]),
                                    Role = table.Rows[0]["Role"].ToString(),
                                    Username = Username,
                                    Password = Password,

                                };
                                return matchingUser;


                            }

                        }
                    }
                }
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return null;

        }
    }
}


