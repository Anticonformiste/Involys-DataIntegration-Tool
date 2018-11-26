using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Involys.Pocos;
using Involys.Utility;
using System.Data;

namespace Involys.DataAccess.Connectors
{
    public class OracleConnector:DbConnector
    {
        /*Constructeur*/
        public OracleConnector(ConnectionHelper helper)
            : base(helper)
        {}

        /*Methodes*/
        public override string GetChaineConnection()
        {
            throw new NotImplementedException();
        }

        public override System.Data.Common.DbConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetServerDatabases()
        {
            throw new NotImplementedException();
        }

        public override string CreateSelectQuery(List<Pocos.Parametre> output, List<Pocos.Parametre> input, string viewEvent)
        {
            throw new NotImplementedException();
        }

        public override string MakeCreateTableQuery(List<Pocos.Parametre> output, string tableTmp)
        {
            throw new NotImplementedException();
        }

        public override string CreateInsertIntoTmpQuery(List<Pocos.Parametre> output, string tableTmp)
        {
            throw new NotImplementedException();
        }

        public override string CreateTriggerQuery(string tableTmp, string evenenement)
        {
            throw new NotImplementedException();
        }

        public override string CreateSPHeader(List<Pocos.Parametre> input, string nomSP)
        {
            throw new NotImplementedException();
        }

        public override string CreateStoredProcedureQuery(Pocos.ConnexionSysteme sysAmont, params object[] args)
        {
            throw new NotImplementedException();
        }

        public override int ExecuteNonQuery(string sqlQuery)
        {
            throw new NotImplementedException();
        }

        public override DataTable ExecuteQuery(string sqlQuery)
        {
            throw new NotImplementedException();
        }
    }
}
