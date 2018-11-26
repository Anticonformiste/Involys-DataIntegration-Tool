using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Involys.Pocos
{
    public class Evenement
    {
        public int Code { get; set; }
        public string Libelle { get; set; }
        public ConnexionSysteme System { get; set; }

        public override string ToString()
        {
            return Code.ToString();
        }
    }
}
