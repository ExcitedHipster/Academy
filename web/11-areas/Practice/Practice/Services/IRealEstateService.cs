using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public interface IRealEstateService
    {
        IEnumerable<Property> GetTop3Properties();
        void AddProperty(Property property);
    }
}
