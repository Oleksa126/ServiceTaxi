using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxi.Models
{
    public class CarDrive :Profile
    {
        public int ID { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
    }
}
