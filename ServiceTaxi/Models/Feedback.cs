using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxi.Models
{
    public class Feedback
    {
        int id;
        String feedback;


        public Feedback(String _feedback) {
            feedback = _feedback;
        }
    }
}
