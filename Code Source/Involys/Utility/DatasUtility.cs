using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

using Involys.DataAccess.Connectors;
using Involys.Pocos;

namespace Involys.Utility
{
    public static class DatasUtility
    {
        public static int AddParameterWithValue(DbCommand command, string parameterName, object parameterValue)
        {
            try
            {
                var parameter = command.CreateParameter();
                parameter.ParameterName = parameterName;
                parameter.Value = parameterValue;
                command.Parameters.Add(parameter);
                return 0;
            }
            catch (Exception)
            {return 1;}
        }

        public static DbConnector GetConenctorByProvider(string provider)
        {
            DbConnector connector=null;
            switch (provider.ToLower())
            {
                case "mssqlserver":
                    connector = new MSSQLConnecctor(new ConnectionHelper());
                    break;
                case "oracle":
                    connector = new OracleConnector(new ConnectionHelper());
                    break;
            }
            return connector;
        }

        public static string GetFileTriggerValue(string tableTmp, string evenenement)
        {
            string result = Properties.Resources.trigger;
            //Remplacer les chaines à remplacer
            if (result.Contains("$NmtempTable"))
                result = result.Replace("$NmtempTable", tableTmp);
            if (result.Contains("$tblSortie"))
                result = result.Replace("$tblSortie", evenenement);
            result = result.Replace(@"'", @"''");
            return result;
        }

        public static string GetFileCheckTrValue(string tableTmp, string evenenement)
        {
            string result = Properties.Resources.checkTrigger;
            //Remplacer les chaines à remplacer
            if (result.Contains("$NmtempTable"))
                result = result.Replace("$NmtempTable", tableTmp);
            if (result.Contains("$tblSortie"))
                result = result.Replace("$tblSortie", evenenement);
            result = result.Replace(@"'", @"''");
            return result;
        }
    }
}
