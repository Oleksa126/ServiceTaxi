using ServiceTaxi.States;


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
