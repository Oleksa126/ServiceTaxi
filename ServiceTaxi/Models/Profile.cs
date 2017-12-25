using ServiceTaxi.States;
using System.Collections.Generic;


namespace ServiceTaxi.Models
{
    public class Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<Feedback> Feedback { get; set; } = new List<Feedback>();
    }
}

