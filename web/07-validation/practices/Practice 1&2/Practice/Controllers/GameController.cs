using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using practice.Models;
using practice.Services;

namespace practice.Controllers {
    public class GameController : Controller {

        private readonly IGameService _gamesService;

        public GameController(IGameService gamesService) {
            _gamesService = gamesService;
        }

        public IActionResult Index() {
            var game = _gamesService.GetGames();
            return View(game);
        }

        [HttpGet]
        public IActionResult Created() {
            return View();
        }

        [HttpGet]
        public IActionResult CreatedMVC() {
            return View();
        }

        [HttpPost]
        public IActionResult Created(Game newGame) {
            if (ModelState.IsValid) {
                _gamesService.SaveGame(newGame);
                var games = _gamesService.GetGames();
                return View("Index", games);
            }
            return View();
        }
    }
}