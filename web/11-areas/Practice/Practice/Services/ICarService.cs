using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetTop3Cars();
        void AddCar(Car car);
    }
}
