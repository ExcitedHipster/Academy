using CarRentals.Helper;
using CarRentals.Models;
using CarRentals.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> Repository)
        {
            _repository = Repository;
        }
        public void Add(User user)
        {
            user.Password = Sha1Helper.HashPassword(user.Password + Constants.Salt);
            _repository.Add(user);
        }


        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }


    }
}
