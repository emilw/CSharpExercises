using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_7.BaseballPlayer
{
    interface IPlayerRepository
    {
        IList<BaseballPlayer.Player> GetAllPlayers();
        IList<BaseballPlayer.Player> GetPlayersBySearchParameters(string lastName, decimal battingAverageFrom, decimal battingAverageTo);
    }
}
