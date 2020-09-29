using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Planner.Models;

namespace Planner.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        void Add(User user);
    }
}
