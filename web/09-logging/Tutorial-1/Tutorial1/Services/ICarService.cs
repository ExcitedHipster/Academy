using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial1.Models;

namespace Tutorial1.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetTop3Cars();
        void AddCar(Car car);
    }
}
