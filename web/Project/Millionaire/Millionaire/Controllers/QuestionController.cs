using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Millionaire.Models;
using Millionaire.Services.Interfaces;
using NLog;

namespace Millionaire.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly ILogger _logger;
        // GET: Question

        public QuestionController(IQuestionService questionService) {
            _questionService = questionService;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public ActionResult Index()
        {
            _logger.Info("Question Management Invoked");
            var question = _questionService.GetQuestion();
            return View(question);
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            _logger.Info("Question Details Invoked");
            var question = _questionService.GetQuestion().ToList();
            return View(question[id-1]);
        }

        // GET: Question/Create
       

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            _logger.Info("Question Edit Invoked");
            var question = _questionService.GetQuestion().SingleOrDefault(x => x.Id == id);
            return View(question);
        }

        // POST: Question/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Question question)
        {
            try
            {
                _logger.Info("Question Update Invoked");
                _questionService.UpdateQuestion(question);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex) {
                _logger.Error(ex, "Error while Editing Question");
                return View();
            }
        }

      
    }
}