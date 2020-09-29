using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Model;
using Tutorial_1.Services.Interfaces;

namespace Tutorial_1.Services.Implementation
{
    public class PositionService : IPositionService
    {
        public IEnumerable<Position> GetPositions()
        {
            return new List<Position> 
            { 
                new Position{Name="Director",Salary=2000},
                new Position{Name="Manager",Salary=1100},
                new Position{Name="Seller",Salary=600},
            };
        }
    }
}
