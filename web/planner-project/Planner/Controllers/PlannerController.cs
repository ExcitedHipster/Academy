using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using Planner.Models;
using Planner.Services.Interfaces;

namespace Planner.Controllers
{
    public class PlannerController : Controller
    {
        private readonly IPlannerService _plannerService;
        private readonly NLog.ILogger _logger;
        public PlannerController(IPlannerService plannerService)
        {
            _plannerService = plannerService;
            _logger = LogManager.GetCurrentClassLogger();
        }

        // GET: Planner
        public ActionResult Index()
        {
            _logger.Info("Plan Index invoked");
            var plans = _plannerService.GetPlans();
            return View(plans);
        }
        // GET: Planner/Create
        public ActionResult Create()
        {
            _logger.Info("Plan Create Invoked");

            return View();
        }


        // POST: Planner/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventPlanning plan)
        {
            try
            {
                if (plan.EndTime.Subtract(plan.StartTime).Minutes<0)
                {
                    _logger.Warn("Start Date Time should be less than End date Time");
                    plan.IsValid = "Start Date Time should be less than End date Time";
                }
                else plan.IsValid = "";
                    _plannerService.AddPlan(plan);

                    return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error while creating plan");
                return View();
            }
        }



        // GET: Planner/Edit/5
        public ActionResult Edit(int id)
        {
            _logger.Info("Plan Edit Invoked");
            var plan = _plannerService.GetPlans().SingleOrDefault(x => x.Id == id);
            return View(plan);
        }


        // POST: Planner/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EventPlanning plan)
        {
            try
            {
                _plannerService.UpdatePlan(plan);
                _logger.Info("Plan Update Invoked");

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error while Updating plan");
                return View();
            }
        }


        // GET: Planner/Delete/5
        public ActionResult Delete(int id)

        {
            _plannerService.DeletePlan(id);
            _logger.Info("Plan Delete Invoked");

            return RedirectToAction("Index");
        }



        // POST: Planner/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _logger.Info("Plan deleted");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FuturePlans()
        {
            return View();
        }
        public ActionResult FuturePlansResult(DateTime date)
        {
            var plans = _plannerService.GetPlans();
            var eventPlan = new List<EventPlanning>();

            foreach (var item in plans)
            {
                if (item.StartTime.ToString("dd:MM:yyyy") == date.ToString("dd:MM:yyyy") && item.EndTime.ToString("dd:MM:yyyy") == date.ToString("dd:MM:yyyy"))
                {

                    eventPlan.Add(item);
                }

            }
            _logger.Info("Events were shown");
            return View(eventPlan);
        }
        public ActionResult Logout()
        {
            Url.ActionContext.HttpContext.Response.Cookies.Delete("_token");
            _logger.Info("User logged out, Token was deleted");
            return RedirectToAction("Index");

        }
    }
}