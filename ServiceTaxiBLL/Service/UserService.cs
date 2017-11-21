using ServiceTaxiBLL.Interfaces;
using System;
using ServiceTaxi.Models;
using ServiceTaxiDAL.Interfaces;
//using Microsoft.AspNet.Identity;

namespace ServiceTaxi.ServiceTaxiBLL.Service
{
    public class UserService : IUserServise
    {
      
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CreateUser(User user)
        {
            var result = _userRepository.CreateUser(user);
            return true;
        }

        public User GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }

        public bool UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
            return true;
        }
    }
}
