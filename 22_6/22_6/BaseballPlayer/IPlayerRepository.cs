using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_6.BaseballPlayer
{
    interface IPlayerRepository
    {
        IList<BaseballPlayer.Player> GetPlayersByLastName(string lastName);
        IList<BaseballPlayer.Player> GetAllPlayers();
    }
}
