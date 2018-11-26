using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Involys.Pocos
{
    //Une classe qui stocke des information d'authentification à une base précise dans un serveur.
    public class ConnectionHelper
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
