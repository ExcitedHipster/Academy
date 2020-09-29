using Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Services.Interfaces
{
    public interface IPlannerService  
    { 
        IEnumerable<EventPlanning> GetPlans();
        void AddPlan(EventPlanning plan);
        void UpdatePlan(EventPlanning plan);
        void DeletePlan(int id);
    }
}
