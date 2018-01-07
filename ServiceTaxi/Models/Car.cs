using ServiceTaxi.States;
using System.Text;

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

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendFormat(" Manufacter - {0} \n", Manufacter);
            str.AppendFormat(" Model  - {0} \n", Model);
            str.AppendFormat("RegisterNumber - {0} \n", RegisterNumber);
            str.AppendFormat(" WorkCity - {0} \n", WorkCity);

            return str.ToString();
        }
        //public Point CarPoint { get; set; } //розташування машини
    }
}
