using ServiceTaxi.Models;
using ServiceTaxi.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxiDAL.Interfaces
{
    public interface ICarRepository
    {
        bool AddCar(string manufacter, string model, long registerNumber, string workCity, ClassOfCars classOfCars );
        List<Car> GetAllCarByWorkCity(string workCity);
        bool DeleteCarByID(int Id);
        bool UpdateCarByID(int id, string manufacter, string model, long registerNumber, string workCity, ClassOfCars classOfCars);
    }
}
