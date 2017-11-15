using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxi.Models
{
    public class Order
    {
        public int CarID { get; set; }
        public int CarDriverID { get; set; }
        public int UserID { get; set; }
        public Point PointOfUser { get; set; }
        public Point PointOfOrder { get; set; }
    }
}
