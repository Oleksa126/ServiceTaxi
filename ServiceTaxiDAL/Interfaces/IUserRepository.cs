using ServiceTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxiDAL.Interfaces
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        User GetUser(int id);
        bool UpdateUser(User user);
        bool AddFeedback(Feedback feedback);
    }
}
