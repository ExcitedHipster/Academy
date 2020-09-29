using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Models;

namespace Tutorial_1.Services {
    public interface IGameService {
        IEnumerable<Game> GetGames();
        void SaveGame(Game game);
    }
}
