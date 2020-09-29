using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_2.Model;

namespace Tutorial_2.Services
{
    class BrandService:IBrandService
    {
        public IEnumerable<Brand> GetBrands()
        {
            return new List<Brand>
            {
                new Brand("MARVEL"),
                new Brand("DC"),
                new Brand("Disney"),
            };
        }
    }
}
