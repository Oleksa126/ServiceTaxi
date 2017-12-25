using System;

namespace ServiceTaxi.Models
{
    public class Feedback
    {
       public int ID { get;  set; }
       public String feedback { get; set; }


        public override string ToString()
        {
            return feedback;
        }
    }
}
