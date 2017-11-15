using ServiceTaxi.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxi.Models
{
    public class Car 
    {
        public int ID { get; set; }
        public string Manufacter { get; set; }
        public string Model { get; set; }
        public long RegisterNumber { get; set; }
        public string WorkCity { get; set; }

        public ClassOfCars ClassOfCars { get; set; }
        public Point CarPoint { get; set; }
    }
}
