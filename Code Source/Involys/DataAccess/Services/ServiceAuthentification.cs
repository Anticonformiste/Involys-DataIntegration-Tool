using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

using Involys.DataAccess.Connectors;
using Involys.Utility;


namespace Involys.DataAccess.Services
{
    public class ServiceAuthentification:ServiceMetier
    {
        public int Authenticate(string username, string password)
        {
            try
            {
                DbCommand cmd = Connector.GetConnection().CreateCommand();
                cmd.CommandText = "select id from [Authentication] where username=@user AND mdp=@mdp";
                DatasUtility.AddParameterWithValue(cmd, "@user", username);
                DatasUtility.AddParameterWithValue(cmd, "@mdp", password);
                Connector.GetConnection().Open();
                int res = (int)cmd.ExecuteScalar();
                Connector.GetConnection().Close();
                return 0;
            }
            catch (Exception)
            { return 1; }
        }
    }
}
