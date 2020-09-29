using CarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Services.Implementation
{
    public class CarRepository : IRepository<Car>
    {
        private List<Car> _cars = new List<Car>
        {
            new Car {ID=1,Name="BMW M3",MaxSpeed=320,Mileage=1003},
            new Car {ID=2,Name="Golf",MaxSpeed=300,Mileage=432},
            new Car {ID=3,Name="Cheery Amulet",MaxSpeed=90,Mileage=0},
        };
        public void Add(Car item)
        {
            var maxId = _cars.Select(x => x.ID).Max();
            item.ID = ++maxId;
            _cars.Add(item);
        }

        public void Delete(int id)
        {
            var car = _cars.SingleOrDefault(x => x.ID == id);
            _cars.Remove(car);
        }

        public IEnumerable<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car item)
        {
            var car = _cars.SingleOrDefault(x => x.ID == item.ID);

            var index = _cars.IndexOf(car);

            _cars[index].Name = item.Name;
            _cars[index].MaxSpeed = item.MaxSpeed;
            _cars[index].Mileage = item.Mileage;



        }
    }
}
