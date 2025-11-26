using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Repository
{
    public class RoomDescriptionRepository
    {
            private string CONNECTIONSTRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelReservationdb;Integrated Security=True;TrustServerCertificate=True";

            public List<RoomDescription> GetAllRooms()
            {
                List<RoomDescription> rooms = new List<RoomDescription>();

                string query = "SELECT RoomTypeID, RoomTypeName, Description, PricePerNight, MaxOccupancy FROM RoomTypes";

                using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        RoomDescription room = new RoomDescription
                        {
                            RoomTypeID = Convert.ToInt32(reader["RoomTypeID"]),
                            RoomTypeName = reader["RoomTypeName"].ToString(),
                            Description = reader["Description"].ToString(),
                            PricePerNight = Convert.ToDecimal(reader["PricePerNight"]),
                            MaxOccupancy = Convert.ToInt32(reader["MaxOccupancy"])
                        };
                        rooms.Add(room);
                    }

                    reader.Close();
                }

                return rooms;
            }
    }
}



