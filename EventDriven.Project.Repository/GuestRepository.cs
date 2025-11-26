using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;
using Microsoft.Win32.SafeHandles;

namespace EventDriven.Project.Repository
{
    public class GuestRepository
    {
        private string CONNECTIONSTRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelReservationdb;Integrated Security=True;TrustServerCertificate=True";
        public void AddGuest(Guest guest)
        {
            var query = "INSERT INTO [dbo].[Guest] (FirstName, LastName, MiddleInitial, DateOfBirth, Sex, ContactNumber, Email, Address, EmergencyContact) VALUES (@FirstName, @LastName, @MiddleInitial, @DateOfBirth, @Sex, @ContactNumber, @Email, @Address, @EmergencyContact)";
            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", guest.FirstName);
                        command.Parameters.AddWithValue("@LastName", guest.LastName);
                        command.Parameters.AddWithValue("@MiddleInitial", guest.MiddleInitial);
                        command.Parameters.AddWithValue("@DateOfBirth", guest.DateOfBirth);
                        command.Parameters.AddWithValue("@Sex", guest.Sex);
                        command.Parameters.AddWithValue("@ContactNumber", guest.ContactNumber);
                        command.Parameters.AddWithValue("@Email", guest.Email);
                        command.Parameters.AddWithValue("@Address", guest.Address);
                        command.Parameters.AddWithValue("@EmergencyContact", guest.EmergencyContact);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured: " + ex.Message);
                }
            }
        }

        public List<Guest> GetAll()
        {
            var query = "SELECT * FROM [dbo].[Guest]";

            var list = new List<Guest>();
            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var guest = new Guest
                                    {
                                        GuestID = reader.GetInt32(reader.GetOrdinal("GuestID")),
                                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                        MiddleInitial = reader.GetString(reader.GetOrdinal("MiddleInitial"))[0],
                                        DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                        Sex = reader.GetString(reader.GetOrdinal("Sex"))[0],
                                        ContactNumber = reader.GetString(reader.GetOrdinal("ContactNumber")),
                                        Email = reader.GetString(reader.GetOrdinal("Email")),
                                        Address = reader.GetString(reader.GetOrdinal("Address")),
                                        EmergencyContact = reader.GetString(reader.GetOrdinal("EmergencyContact"))
                                    };
                                    list.Add(guest);
                                }
                            }
                            else
                            {
                                throw new Exception("No data found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured: " + ex.Message);
                }
            }
            return list;
        }
        public void Delete(int GuestId)
        {
            var query = "DELETE FROM [dbo].[Guest] WHERE GuestID = @GuestID";
            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GuestID", GuestId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No guest found with the specified ID. ");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured: " + ex.Message);
                }
            }
        }
        public List<Guest> SearchGuest(string name)
        {
            List<Guest> guests = new List<Guest>();
            var query = "SELECT * FROM [dbo].[Guest] WHERE FirstName LIKE @Name OR LastName LIKE @Name";

            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add wildcards for partial matching
                        command.Parameters.AddWithValue("@Name", "%" + name + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var guest = new Guest
                                {
                                    GuestID = reader.GetInt32(reader.GetOrdinal("GuestID")),
                                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                    MiddleInitial = reader.GetString(reader.GetOrdinal("MiddleInitial"))[0],
                                    DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    Sex = reader.GetString(reader.GetOrdinal("Sex"))[0],
                                    ContactNumber = reader.GetString(reader.GetOrdinal("ContactNumber")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    EmergencyContact = reader.GetString(reader.GetOrdinal("EmergencyContact"))
                                };
                                guests.Add(guest);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured: " + ex.Message);
                }
            }
            return guests;
        }

        public void UpdateGuest(Guest guest)
        {
            var query = @"UPDATE [dbo].[Guest] 
                  SET FirstName = @FirstName,
                      LastName = @LastName,
                      MiddleInitial = @MiddleInitial,
                      DateOfBirth = @DateOfBirth,
                      Sex = @Sex,
                      ContactNumber = @ContactNumber,
                      Email = @Email,
                      Address = @Address,
                      EmergencyContact = @EmergencyContact
                  WHERE GuestID = @GuestID";

            using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GuestID", guest.GuestID);
                        command.Parameters.AddWithValue("@FirstName", guest.FirstName);
                        command.Parameters.AddWithValue("@LastName", guest.LastName);
                        command.Parameters.AddWithValue("@MiddleInitial", guest.MiddleInitial);
                        command.Parameters.AddWithValue("@DateOfBirth", guest.DateOfBirth);
                        command.Parameters.AddWithValue("@Sex", guest.Sex);
                        command.Parameters.AddWithValue("@ContactNumber", guest.ContactNumber);
                        command.Parameters.AddWithValue("@Email", guest.Email);
                        command.Parameters.AddWithValue("@Address", guest.Address);
                        command.Parameters.AddWithValue("@EmergencyContact", guest.EmergencyContact);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No guest found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while updating the guest: " + ex.Message);
                }
            }
        }

    }
}

