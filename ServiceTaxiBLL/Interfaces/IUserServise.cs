using ServiceTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTaxiBLL.Interfaces
{
    public interface IUserServise
    {
        bool CreateUser(User user);
        User GetUser(int id);
        bool UpdateUser(User user);
        bool AddFeedback(Feedback feedback);

    }
}
