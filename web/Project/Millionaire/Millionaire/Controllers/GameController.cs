using Microsoft.AspNetCore.Mvc;
using Millionaire.Models;
using Millionaire.Services.Implementations;
using Millionaire.Services.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Controllers {
    public class GameController : Controller {

        private readonly IQuestionService _questionService;
        private readonly ILogger _logger;
        public static Tip CurrentTips = new Tip { FiftyFifty = true, Friend = true, Audience = true };
        public static Tip TipsIndicator = new Tip { FiftyFifty = false, Friend = false, Audience = false };
        public static int id = 1, ind = 1;
        public static History _History = new History();
        public GameController(IQuestionService questionService) {
            _questionService = questionService;
            _logger = LogManager.GetCurrentClassLogger();
        }


        public IActionResult Game() {


            _logger.Info("Game Invoked");
            var question = _questionService.GetQuestion().SingleOrDefault(x => x.Id == id);

            if (id <= 6)
            {
                if (id > 3) question.TakeMoney = "TakeMoney";

                id++;

                if (ind == 1) QuestionRepository.Randomize(question);

                TipsImplementation.GetTip(question);
            }

            id--;

            return View(question);
        }

        public IActionResult Lost() {
            return View(_History);
        }

        // POST: Question/Edit/5

        public IActionResult CheckAnswer(Answer IsRightA) {
            try {
                ind = 1;
                id++;
                _logger.Info("Set Invoked");
                if (IsRightA.IsRight == false) return RedirectToAction(nameof(Lost));
                else if (id <= 6) return RedirectToAction(nameof(Game));
                else return RedirectToAction(nameof(TakeMoneyView));
            }
            catch (Exception ex) {
                _logger.Error(ex, "Error while Editing Question");
                return View();
            }
        }
        public IActionResult TipAction(Tip tip)
        {
            try
            {
                _logger.Info(" tip Invoked");

                ind = 0;
                if (tip.FiftyFifty && CurrentTips.FiftyFifty)
                {
                    CurrentTips.FiftyFifty = false;
                    TipsIndicator.FiftyFifty = true;
                }

                if (tip.Audience && CurrentTips.Audience)
                {
                    CurrentTips.Audience = false;
                    TipsIndicator.Audience = true;
                }

                if (tip.Friend && CurrentTips.Friend)
                {
                    CurrentTips.Friend = false;
                    TipsIndicator.Friend = true;
                }
                return RedirectToAction(nameof(Game));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error while Editing Question");
                return View();
            }
        }

        public IActionResult HistoryView(History history)
        {

            _logger.Info(" History Invoked");
            _History = history;

            if (_History.ReturnLostPage + _History.ReturnWonPage != "") _History.ReturnGamePage = "";

            return View(_History);
        }
        public IActionResult TakeMoneyView()
        {
            _logger.Info(" TakeMoney Invoked");
            _History = new History {
                CorrectAnswers = id - 1,
                Money = _History.moneyList[id - 2],
                StartDate = DateTime.Now,
            };
                
            return View(_History);
        }

        
    }
}
