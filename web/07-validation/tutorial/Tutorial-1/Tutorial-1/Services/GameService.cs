using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Models;

namespace Tutorial_1.Services {
    public class GameService : IGameService {

        private List<Game> _games = new List<Game> {
            new Game{Name="PUBG", Price=0, Genre="Survival", ReleaseDate=new DateTime(2017,3,23),Rating="B"},
            new Game{Name="Minecraft", Price=30, Genre="Survival", ReleaseDate=DateTime.Now.AddDays(-500),Rating="C"},
            new Game{Name="Snake", Price=123, Genre="Snake", ReleaseDate=DateTime.Now.AddDays(-8000),Rating="A"},
        };

        public IEnumerable<Game> GetGames() {
            return _games;
        }

        public void SaveGame(Game game) {
            _games.Add(game);
        }
    }
}
