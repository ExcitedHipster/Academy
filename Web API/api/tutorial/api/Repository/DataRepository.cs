using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Newtonsoft.Json;

namespace api.Repository
{
    public class DataRepository : IDataRepository
    {

        private List<User> _users;
        private const string filename = "MOCK_DATA.json";
        public DataRepository()
        {
            _users = GetData();
        }

        private List<User> GetData()
        {
            var file = File.ReadAllText(filename);

            return JsonConvert.DeserializeObject<List<User>>(file);
        }

        public User GetUser(int id)
        {
            return _users.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public User Add(User user)
        {
            var maxId = _users.Max(x => x.Id);
            user.Id = maxId+1;
            _users.Add(user);

            saveChanges();

            return user;
        }

        public bool Delete(int id)
        {
            var result = false;

            try
            {
                var userToDelete = _users.SingleOrDefault(x => x.Id == id);
                _users.Remove(userToDelete);

                saveChanges();
                result = true;
            }
            catch(Exception ex)
            {

            }
            return result;
        }

        private void saveChanges()
        {
            string json = JsonConvert.SerializeObject(_users);

            File.WriteAllText(filename, json);
        }
    }
}
