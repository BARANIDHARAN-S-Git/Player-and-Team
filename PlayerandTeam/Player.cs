using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerandTeam
{
    public class Player
    {
        private int _PlayerId;

        public int PlayerId
        {
            get { return _PlayerId; }
            set { _PlayerId = value; }
        }

        private string _PlayerName;

        public string PlayerName
        {
            get { return _PlayerName; }
            set { _PlayerName = value; }
        }

        private int _PlayerAge;
        
        public int PlayerAge
        {
            get { return _PlayerAge; }
            set { _PlayerAge = value; }
        }

    }
}
