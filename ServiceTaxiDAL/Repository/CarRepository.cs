using ServiceTaxiDAL.Interfaces;
using System.Collections.Generic;
using ServiceTaxi.Models;
using System.Data.SqlClient;
using ServiceTaxi.States;

namespace ServiceTaxiDAL.Repository
{
    public class CarRepository : ICarRepository
    {
        public static string ConnectionString = "Server=OLEKSA; Database=ServiceTaxi; Integrated Security=True;";

        public bool AddCar(string manufacter, string model, long registerNumber, string workCity, ClassOfCars classOfCars)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "INSERT INTO[dbo].[Car]([classOfCar],[manufacter], [model], [registerNumber], [workCity]) VALUES " +
                "('"+ classOfCars.ToString() + "', '" + manufacter +"', '"+ model + "', '"+ registerNumber + "', '"+ workCity + "')";
              
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = Query;
            sqlCommand.Connection = con;

            sqlCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool DeleteCarByID(int Id)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string Query = "Delete [dbo].[Car] WHERE idCar='" + Id + "'";
            SqlCommand sqlCommand = new SqlCommand(Query,con);
            sqlCommand.ExecuteNonQuery();

            con.Close();
            return true;
        }

        public List<Car> GetAllCarByWorkCity(string workCity)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT [idCar],[manufacter],[model],[registerNumber],[workCity],[classOfCar] FROM [Car] WHERE workCity = '"+workCity+"'", con);
            SqlDataReader sqlData = command.ExecuteReader();

            List<Car> car = new List<Car>();

            while (sqlData.Read())
            {
                car.Add(new Car()
                {
                    ID = sqlData.GetInt32(sqlData.GetOrdinal("idCar")),
                    Manufacter = sqlData.GetString(sqlData.GetOrdinal("manufacter")),
                    Model = sqlData.GetString(sqlData.GetOrdinal("model")),
                    RegisterNumber = sqlData.GetInt32(sqlData.GetOrdinal("registerNumber")),
                    WorkCity = sqlData.GetString(sqlData.GetOrdinal("workCity")),
                    //ClassOfCars = ???
                });
            }

            con.Close();
            return car;
        }

        public bool UpdateCarByID(int id, string manufacter, string model, long registerNumber, string workCity, ClassOfCars classOfCars)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "UPDATE [Car] SET " +
                "[manufacter] = '" + manufacter + "', " +
                "[model] = '" + model + "'," +
                "[registerNumber] = '" + registerNumber + "', " +
                "[workCity] = '" + workCity + "', " +
                "[classOfCar] = '" + classOfCars.ToString() + "'" +
                "WHERE idCar = '"+id+"' ";

            SqlCommand sqlCommand = new SqlCommand(Query,con);
            sqlCommand.ExecuteNonQuery();



            con.Close();
            return true;
        }
    }
}
