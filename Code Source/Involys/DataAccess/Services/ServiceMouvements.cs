using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Involys.Pocos;

namespace Involys.DataAccess.Services
{
    public class ServiceMouvements:ServiceMetier
    {
        public DataTable GetAll(string evenement)
        {
            var sql = string.Format("select * from Mvt_{0}", evenement);
            return Connector.ExecuteQuery(sql);
        }

        public DataTable GetSomeFields(string evenement, List<Parametre> fields)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select ");
            foreach (var item in fields)
            {
                if (fields.IndexOf(item) > 0)
                    sb.Append(",");
                sb.Append(item.Champs);
            }
            var sql = string.Format("{0} from Mvt_{1}", sb.ToString(), evenement);
            return Connector.ExecuteQuery(sql);
        }
    }
}
