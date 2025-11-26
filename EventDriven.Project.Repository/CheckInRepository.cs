using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;
using System.Data.SqlClient;

namespace EventDriven.Project.Repository
{
    public class CheckInRepository
    {
        //For creating a connection database to visual studio
        private string CONNECTIONSTRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelReservationdb;Integrated Security=True;TrustServerCertificate=True";

        public void ConfirmCheckIn(int reservationId)
        {
            var query = "UPDATE [dbo].[CheckIn] SET Status = 'CheckedIn' WHERE ReservationID = @ReservationID";

            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", reservationId);
                        int rows = command.ExecuteNonQuery();

                        if (rows == 0)
                            throw new Exception("NO Reservation found.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured while confirming Check-In" + ex.Message);
                }
            }
        }

        public List<CheckIn> GetAll()
        {
            var checkin = new List<CheckIn>();
            var query = @"SELECT r.ReservationID, r.GuestID, r.RoomID, r.CheckInDate, r.CheckOutDate, r.Status, g.FirstName, g.LastName, rm.RoomNumber
                FROM [dbo].[Reservations] r
                INNER JOIN [dbo].[Guest] g ON r.GuestID = g.GuestID
                INNER JOIN [dbo].[Rooms] rm ON r.RoomID = rm.RoomID
                WHERE r.Status = 'Confirmed'";

            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var checkins = new CheckIn
                            {
                                GuestFullName = reader.GetString(reader.GetOrdinal("FirstName")) + " " + reader.GetString(reader.GetOrdinal("LastName")),
                                RoomNumber = reader.GetString(reader.GetOrdinal("RoomNumber")),
                                ReservationID = reader.GetInt32(reader.GetOrdinal("ReservationID")),
                                GuestID = reader.GetInt32(reader.GetOrdinal("GuestID")),
                                RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                                CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                                CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                                Status = reader.GetString(reader.GetOrdinal("Status")),
                            };
                            checkin.Add(checkins);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while loading confirmed reservations: " + ex.Message);
                }
            }
            return checkin;
        }

        public void AddCheckIn(CheckIn checkIn)
        {
            var query = @"INSERT INTO [dbo].[Reservations]
                  (GuestID, RoomID, CheckInDate, CheckOutDate, Status)
                  VALUES (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @Status)";

            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GuestID", checkIn.GuestID);
                        command.Parameters.AddWithValue("@RoomID", checkIn.RoomID);
                        command.Parameters.AddWithValue("@CheckInDate", checkIn.CheckInDate);
                        command.Parameters.AddWithValue("@CheckOutDate", checkIn.CheckOutDate);
                        command.Parameters.AddWithValue("@Status", checkIn.Status);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding this to the Check-In List: " + ex.Message);
                }
            }
        }

        public List<CheckIn> SearchCheckInList(string name)
        {
            var reservations = new List<CheckIn>();
            string query = @"SELECT r.ReservationID, r.GuestID, r.RoomID, r.CheckInDate, r.CheckOutDate, r.Status,
                      g.FirstName, g.LastName
               FROM Reservations r
               INNER JOIN Guest g ON r.GuestID = g.GuestID
               WHERE r.Status = 'Confirmed' AND 
                     (g.FirstName LIKE @Name OR g.LastName LIKE @Name)";

            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", "%" + name + "%");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(new CheckIn
                            {  
                                GuestFullName = reader.GetString(reader.GetOrdinal("FirstName")),
                                RoomNumber = reader.GetString(reader.GetOrdinal("LastName")),
                                ReservationID = reader.GetInt32(reader.GetOrdinal("ReservationID")),
                                GuestID = reader.GetInt32(reader.GetOrdinal("GuestID")),
                                RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                                CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                                CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                                Status = reader.GetString(reader.GetOrdinal("Status")), 
                            });
                        }
                    }
                }
            }

            return reservations;
        }

        public void RemoveCheckIn(int reservationId)
        {
            var query = "DELETE FROM [dbo].[Reservations] WHERE ReservationID = @ReservationID";

            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", reservationId);
                        int rows = command.ExecuteNonQuery();

                        if (rows == 0)
                            throw new Exception("No reservation found to delete.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while deleting the check-in record: " + ex.Message);
                }
            }
        }
    }
}