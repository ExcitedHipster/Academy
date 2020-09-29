using Planner.Models;
using Planner.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Services.Implementations
{
    public class PlannerRepository : IRepository<EventPlanning>
    {
        private List<EventPlanning> _EventPlannings = new List<EventPlanning>
        {
            new EventPlanning { Id=1, Name="Gigi", Description="Doing homework", StartTime=new DateTime(2020,05,10,01,00,00), EndTime=new DateTime(2020,05,10,04,00,00) },
            new EventPlanning { Id=2, Name="Nika", Description="Working out", StartTime=new DateTime(2019,06,10,10,00,00), EndTime=new DateTime(2019,06,10,12,00,00) },
            new EventPlanning { Id=3, Name="Saba", Description="Playing chess", StartTime=new DateTime(2017,12,09,11,00,00), EndTime=new DateTime(2017,12,9,11,30,00) },
        };
        public void Add(EventPlanning item)
        {
            try
            {
                var maxId = _EventPlannings.Select(x => x.Id).Max();
                item.Id = ++maxId;
            }
            catch (Exception)
            {
                item.Id = 0;

            }
            
            _EventPlannings.Add(item);
        }

        public void Delete(int id)
        {
            var plan = _EventPlannings.SingleOrDefault(x => x.Id == id);
            _EventPlannings.Remove(plan);

        }

        public IEnumerable<EventPlanning> GetAll()
        {
            return _EventPlannings;
        }

        public void Update(EventPlanning item)
        {
            var plan = _EventPlannings.SingleOrDefault(x => x.Id == item.Id);

            var index = _EventPlannings.IndexOf(plan);

            _EventPlannings[index] = item;
        }

    }
}
