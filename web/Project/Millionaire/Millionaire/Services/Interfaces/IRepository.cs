using Millionaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Interfaces {
    public interface IRepository<T> {
        IEnumerable<T> GetAll();
       
        void Update(T item);
        void Add(T item);
        void Save();
    }
}
