using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practice.Models;

namespace practice.Services {
    public interface IGameService {
        IEnumerable<Game> GetGames();
        void SaveGame(Game game);
    }
}
