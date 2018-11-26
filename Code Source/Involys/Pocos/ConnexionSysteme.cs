using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Involys.Pocos
{
    public class ConnexionSysteme
    {
        public ConnexionSysteme()
        {
            CnxHelper = new ConnectionHelper();
        }
        public int Code { get; set; }
        public string Libelle { get; set; }
        public string ServerType { get; set; }
        public ConnectionHelper CnxHelper { get; set; }
    }
}
