using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Repository
{
    public interface IDataRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);

        User Add(User user);

        bool Delete(int id);
    }
}
