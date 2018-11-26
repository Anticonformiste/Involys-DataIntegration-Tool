using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Involys.Pocos
{
    public class Condition
    {
        public int Ref_Util { get; set; }
        public int Code_Fils { get; set; }
        public string Libelle { get; set; }
        public int Code_Pere { get; set; }
        public string Type { get; set; }
        public string Selection { get; set; }
        public int Niveau { get; set; }
        public string Requete { get; set; }
        public string Valeur { get; set; }
        public string TableTmp { get; set; }
        public int NumEcriture { get; set; }
        public string Cle { get; set; }
        public string Form { get; set; }
        public int CodeTable { get; set; }

        public List<Condition> Children { get; set; }
    }
}
