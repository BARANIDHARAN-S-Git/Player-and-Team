using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerandTeam
{
  public  interface ITeam
    {
        void Add(Player player);

        void Remove(int Id);

        Player GetPlayerById(int PlayerId);

        Player GetPlayerByName(string PlayerName);

       List<Player> GetAllPlayers();
    }
}
