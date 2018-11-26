using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Configuration;

namespace Involys.Utility.Exportation
{
    public abstract class DataExporter
    {
        //Prérequis
        protected DataTable tbl;
        protected string filename;
        //Header
        protected bool date = false, colsName = false;
        protected string nomEvent;
        //Footer
        protected bool count = false;
        protected List<int> sum, avg;//Les indices des colonnes à traités

        //Methodes prédéfini
        public void SetPrerequisites(DataTable dt, string name, bool dateInName = false)
        {
            tbl = dt; filename = name;
            if (dateInName)
                filename += "_" + DateTime.Now.ToShortDateString()
                                  .Replace('/', '-').Replace('\\', '-');
        }

        public void SetHeader(bool dateP = false, string nomEventP = null, bool colsNameP = false)
        {
            date = dateP; nomEvent = nomEventP; colsName = colsNameP;
        }

        public void SetFooter(bool countP = false, List<int> sumP = null, List<int> avgP = null)
        {
            count = countP; sum = sumP; avg = avgP;
        }

        //Exporter
        public abstract void Exporter(string separateur="");
    }
}
