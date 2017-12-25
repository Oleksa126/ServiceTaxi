using ServiceTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceTaxi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User { Country = "Ukraine", FirstName = "Oleksa", ID = 0, LastName = "Bazavlyak", PhoneNumber = "0959214751", Gender = States.Gender.Male };
            var user2 = new User { Country = "Ukraine", FirstName = "Nazar", ID = 1, LastName = "Voychak", PhoneNumber = "09592148561", Gender = States.Gender.Male };

            var car1 = new Car { WorkCity = "Ivano-Frankivsk", ClassOfCars = States.ClassOfCars.Vip, ID = 0, Manufacter = "BMW", Model = "X5", RegisterNumber = 5555 };
            var car2 = new Car { WorkCity = "Ivano-Frankivsk", ClassOfCars = States.ClassOfCars.Middle, ID = 1, Manufacter = "GAS", Model = "Volga 24", RegisterNumber = 2581 };

            var carDriver1 = new CarDrive { FirstName = "Ivan", LastName = "Pupkin", City = "Ivano-Frankivsk", Gender = States.Gender.Male, ID = 0, PhoneNumber = "0858454454", Adress = "Ivano-Frankivsk, Dovha 15" };

            var Users = new List<User> { user1, user2 };
            var Cars = new List<Car> { car1, car2 };
            var carDrivers = new List<CarDrive> { carDriver1 };

            var order1 = new Order { CarDriverID = 0, CarID = 0, UserID = 0, PointOfUser = new Point {Latitude = 5.54f , Longitude= 4.5f}, PointOfOrder = new Point { Latitude = 8.95f, Longitude = 7.65f } };

        }
    }
}
