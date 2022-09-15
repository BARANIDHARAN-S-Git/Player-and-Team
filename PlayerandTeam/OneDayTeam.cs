using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerandTeam
{
    class OneDayTeam:ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public int count = 0;

        private int _capacity;

        public int capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        public OneDayTeam()
        {
            capacity = 11;
        }
        public void Add(Player player)
        {
            if (count < capacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player Added Successfully");
                Console.WriteLine(" ");
                count++;
                


            }
            else
            {
                Console.WriteLine("Sorry,Player is not able to add because the maximum limit to add Player is 11,you have exceeded the Limit");
                Console.WriteLine(" ");
            }


        }

        public void Remove(int PlayerId)
        {
            var rem = oneDayTeam.Find(a => a.PlayerId==PlayerId);
            if (rem!=null)
            {
                oneDayTeam.Remove(rem);
                Console.WriteLine("Player Removed Successfully");
                Console.WriteLine(" ");
                count--;
                
               
            }
            else
            {
                Console.WriteLine($"Player is not found for ur given playerId{PlayerId}");
                Console.WriteLine(" ");

            }





        }
       public Player GetPlayerById(int PlayerId)
        {
            var getid = oneDayTeam.Find(a => a.PlayerId == PlayerId);
            if(getid!=null)
            {
                Console.WriteLine("Player Found");
                Console.WriteLine(" ");
                return getid;
                
            }
            else
            {
                Console.WriteLine($"player details  not found for your given player Id:{PlayerId}");
                Console.WriteLine(" ");
                return null;
            }


        }

        public Player GetPlayerByName(string PlayerName)
        {

            var getname = oneDayTeam.Find(a => a.PlayerName==PlayerName);
            if (getname != null)
            {
                Console.WriteLine("Player Found");
                Console.WriteLine(" ");
                return getname;

            }
         
            else
            {
                Console.WriteLine($"player details  not found for your given player Name:{PlayerName}");
                Console.WriteLine(" ");
                return null;
                
            }

        }

        public List<Player> GetAllPlayers()
        {

            return oneDayTeam;
        }
    }
}
