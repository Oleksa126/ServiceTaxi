using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxi.Models
{
    public class User : Profile
    {
        public int ID { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendFormat(" First Name  - {0} \n", FirstName);
            str.AppendFormat(" LastName  - {0} \n", LastName);
            str.AppendFormat(" Phone Number - {0} \n", PhoneNumber);
            str.AppendFormat(" Country - {0} \n", Country);

            return str.ToString();
        }

    }
}
