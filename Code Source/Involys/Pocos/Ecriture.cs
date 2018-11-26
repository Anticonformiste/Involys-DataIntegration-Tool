using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Involys.Pocos
{
    public class Ecriture
    {
        public int Cle { get; set; }
        public int Numero { get; set; }
        public string Condition { get; set; }
        public List<ColumnEcriture> Colonnes { get; set; }
    }
}
