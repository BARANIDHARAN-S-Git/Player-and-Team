using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerandTeam
{
    public  class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam o = new OneDayTeam();
          
            bool loop = false;
            
            do
            {
                
                Console.WriteLine("Enter any option shown in the Menu : ");
                Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3:Get Player By Id 4:Get player by Name  5:Get All Players");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Player p = new Player();
                        Console.Write("Enter Player Id : ");
                        p.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name : ");
                        p.PlayerName = Console.ReadLine();
                        Console.Write("Enter Player Age : ");
                        p.PlayerAge = Convert.ToInt32(Console.ReadLine());
                        o.Add(p);
                        break;
                    case 2:
                        Console.WriteLine("Enter player Id to Remove");
                        int a = Convert.ToInt32(Console.ReadLine());
                        o.Remove(a);
                        break;
                    case 3:
                        Player p1 = new Player();
                        Console.WriteLine("Enter the player Id to know the player Details");
                        int b = Convert.ToInt32(Console.ReadLine());

                        p1 = o.GetPlayerById(b);
                        Console.WriteLine("Player Id : "+p1.PlayerId);
                        Console.WriteLine("Player Name : "+p1.PlayerName);
                        Console.WriteLine("Player Age : "+p1.PlayerAge);
                        Console.WriteLine(" ");
                        break;
                    case 4:
                        Player p2 = new Player();
                        Console.WriteLine("Enter the player Name to know the player Details");
                        string b1 = Console.ReadLine();

                        p2 = o.GetPlayerByName(b1);
                        Console.WriteLine(p2.PlayerAge);
                        Console.WriteLine(p2.PlayerName);
                        Console.WriteLine(p2.PlayerAge);
                        Console.WriteLine(" ");
                        break;
                    case 5:
                       List<Player> list = new List<Player>();
                        list=o.GetAllPlayers();
                        foreach (var item in list)
                        {
                            Console.WriteLine("Player Id : "+item.PlayerId);
                            Console.WriteLine("Player Name : "+item.PlayerName);
                            Console.WriteLine("Player Age : "+item.PlayerAge);
                            Console.WriteLine(" ");

                        }
                        break;
                    default:
                        Console.WriteLine("Incoorect option ");
                        
                        break;
                }


                        Console.WriteLine("Do yo want to continue yes/no ?");
                        string s = Console.ReadLine();
                        if (s == "yes"||s=="YES")
                        {
                            loop = false;
                        }
                        else if(s== "no"||s=="NO")
                        {
                            loop = true;
                        }
                else
                {
                    Console.WriteLine("Invalid Input");
                    loop = true;
                }
            } while (!loop);


            Console.WriteLine("Thanlyou,Loop ended");


            Console.ReadLine();
        }
    }
}
