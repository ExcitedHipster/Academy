using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial1.Models.Repository
{
    public class CarRepository : ICarRepository
    {
        private List<Car> _cars = new List<Car>()
        {
            new Car{Name = "Porsche", MaxSpeed = 384},
            new Car{Name = "Toyota Prius", MaxSpeed = 300},
            new Car{Name = "Mercedes", MaxSpeed = 260}
        };

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _cars;
        }
    }
}
