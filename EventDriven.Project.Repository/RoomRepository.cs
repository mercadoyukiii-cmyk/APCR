using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Repository
{
    public class RoomRepository
    {
        private string CONNECTIONSTRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelReservationdb;Integrated Security=True;TrustServerCertificate=True";

        public int GetTotalRooms()
        {
            var query = "SELECT COUNT(*) FROM [dbo].[Rooms]";
            int totalRooms = 0;
            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        totalRooms = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while retrieving total rooms: " + ex.Message);
                }
            }
            return totalRooms;
        }

        public int GetOccupiedRooms()
        {
            var query = "SELECT COUNT(*) FROM [dbo].[Rooms]";
            int occupiedRooms = 0;
            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        occupiedRooms = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }
            return occupiedRooms;
        }
        public List<Room> GetRooms()
        {
            var query = "SELECT RoomID, RoomNumber, RoomTypeID, RoomCapacity FROM [dbo].[Rooms] WHERE Status = 'Available'";
            List<Room> rooms = new List<Room>();
            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Room room = new Room
                                {
                                    RoomID = reader.GetInt32(0),
                                    RoomNumber = reader.GetString(1),
                                    RoomTypeID = reader.GetInt32(2),
                                    RoomCapacity = reader.GetInt32(3),
                                };
                                rooms.Add(room);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error Occured: " + ex.Message);
                }
                return rooms;
            }
        }
    }
}

