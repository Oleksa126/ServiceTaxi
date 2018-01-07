using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ServiceTaxi.Repository;
using ServiceTaxi.Models;
using System.Data.SqlClient;
using ServiceTaxiDAL.Repository;

namespace ServiceTaxiDAL
{
    public class Program
    {
        public static string ConnectionString = "Server=OLEKSA; Database=DBServiceTaxi; Integrated Security=True;";
        static void Main(string[] args)
        {

            CarRepository repository = new CarRepository();
            //repository.AddCar("BMW","X5",4589,"Тлумач", ServiceTaxi.States.ClassOfCars.Middle);

            //var user = repository.GetAllCarByWorkCity("Тлумач");

            //for (int i = 0; i < user.Count; i++)
            //{
            //    System.Console.WriteLine(user[i].ToString());
            //}

            //repository.DeleteCarByID(3);

            repository.UpdateCarByID(1,"BMW", "X5", 4589, "Тлумач", ServiceTaxi.States.ClassOfCars.Middle);

            Console.ReadKey();

        }
    }
}
