using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Involys.DataAccess.Connectors;
using Involys.Pocos;
using Involys.Utility;

namespace Involys.DataAccess.Services
{
    public class ServiceDesVues:ServiceMetier
    {
        public List<string> GetAllBySystem(ConnexionSysteme sys)
        {
            var liste = new List<string>();
            try
            {
                //construire le Connector
                if (sys.ServerType.Equals("MSSQLSERVER"))
                {
                    Connector = new MSSQLConnecctor(sys.CnxHelper);
                }
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT name FROM sys.views";
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(dr[0].ToString());
                }
                cnx.Close();
            }
            catch (Exception)
            {}
            return liste;
        }

        public List<string> GetViewFields(string view)
        {
            var liste = new List<string>();
            try
            {
                var cnx = Connector.GetConnection();
                var cmd = cnx.CreateCommand();
                cmd.CommandText = "SELECT COLUMN_NAME FROM information_schema.columns WHERE table_name=@view";
                DatasUtility.AddParameterWithValue(cmd, "@view", view);
                cnx.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(dr[0].ToString());
                }
                cnx.Close();
            }
            catch (Exception)
            {}
            return liste;
        }
    }
}
