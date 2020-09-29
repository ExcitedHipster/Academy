using Planner.Models;
using Planner.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Services.Implementations
{
    public class PlannerService : IPlannerService
    {
        private readonly IRepository<EventPlanning> _plannerRepository;
        public PlannerService(IRepository<EventPlanning> eventRepository)
        {
            _plannerRepository = eventRepository;
        }
        public IEnumerable<EventPlanning> GetPlans()
        {
            return _plannerRepository.GetAll();
        }

        public void AddPlan(EventPlanning plan)
        {
            _plannerRepository.Add(plan);
        }

        public void DeletePlan(int id)
        {
            _plannerRepository.Delete(id);
        }


        public void UpdatePlan(EventPlanning plan)
        {
            _plannerRepository.Update(plan);
        }
    }
}
