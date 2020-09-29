using CarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        void Add(User user);
    }
}
