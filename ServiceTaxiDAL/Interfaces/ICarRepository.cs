using ServiceTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxiDAL.Interfaces
{
    public interface ICarRepository
    {
        bool AddCar();
        Car GetCar();
        bool UpdateCar();
    }
}
