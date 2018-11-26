using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Involys.Pocos
{
    public class Parametre:ICloneable
    {
        public Parametre()
        {
            Ordre = -1;
        }
        
        public string Champs { get; set; }
        public string Type { get; set; }
        public int Taille { get; set; }
        public string NomFonctionnel { get; set; }
        public int Comptabiliser { get; set; }
        public int Critere { get; set; }
        public int Developper { get; set; }
        public int Date { get; set; }
        public int Cle { get; set; }
        public int DatMaj { get; set; }
        public int Impression { get; set; }
        //Caché les 3 attributs
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public Evenement Evenement { get; set; }
        [Browsable(false)]
        public int Ordre { get; set; }

        public object Clone()
        {
            return (Parametre)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return Champs;
        }
    }
}
