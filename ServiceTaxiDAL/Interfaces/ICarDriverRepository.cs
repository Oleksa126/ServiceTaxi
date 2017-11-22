using ServiceTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxiDAL.Interfaces
{
    public interface ICarDriverRepository
    {
        bool CreateCarDriver(CarDrive carDrive);
        CarDrive GetCarDriver(int id);
        bool UpdateCarDriver(CarDrive carDrive);
        bool AddFeedback(Feedback feedback);

    }
}
