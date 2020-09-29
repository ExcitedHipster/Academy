using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_2.Model;

namespace Tutorial_2.Services
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetBrands();
    }
}
