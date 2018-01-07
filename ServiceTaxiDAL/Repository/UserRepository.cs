using ServiceTaxi.Models;
using ServiceTaxiDAL.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ServiceTaxiDAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public static string ConnectionString = "Server=OLEKSA; Database=ServiceTaxi; Integrated Security=True;";


        public bool AddFeedback(Feedback feedback)
        {
            
            return true;
        }

        public bool AddUser(User user)
        {
           
            return true;
        }

        public User GetUser(int id)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT [idCar],[Manufacter],[Model],[RegisterNumber],[WorkCity],[ClassOfCar] FROM [Car] WHERE idUser = '" + id + "'", con);
            SqlDataReader sqlData = command.ExecuteReader();

            User user = new User() {
                ID = sqlData.GetInt32(sqlData.GetOrdinal("idUser")),
                FirstName = sqlData.GetString(sqlData.GetOrdinal("firstName")),
                LastName = sqlData.GetString(sqlData.GetOrdinal("lastName")),
                PhoneNumber = sqlData.GetString(sqlData.GetOrdinal("phoneNumber")),
                Country = sqlData.GetString(sqlData.GetOrdinal("country"))
            };

            con.Close();
            return user;
        }

        public bool UpdateUser(User user)
        {
            return true;
        }
    }
}
