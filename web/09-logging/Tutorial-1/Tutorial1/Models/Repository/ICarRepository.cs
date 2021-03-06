﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial1.Models.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        void AddCar(Car car);
    }
}
