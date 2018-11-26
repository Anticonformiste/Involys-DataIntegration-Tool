using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

using Involys.Pocos;
using System.Data;

namespace Involys.DataAccess.Connectors
{
    public abstract class DbConnector
    {
        /*Attrubuts*/
        protected string cnxString;
        protected DbConnection cnx;
        public ConnectionHelper cnxHelper;
        /*Constructeur*/
        public DbConnector(ConnectionHelper helper)
        {
            cnxHelper = helper;
            GetChaineConnection();
        }
        /*Methodes*/
        public abstract string GetChaineConnection();
        public abstract DbConnection GetConnection();
        public abstract List<string> GetServerDatabases();
        #region To Review Code
        /*Query Binders*/
        public abstract string CreateSelectQuery(List<Parametre> output, List<Parametre> input, string viewEvent);
        public abstract string MakeCreateTableQuery(List<Parametre> output, string tableTmp);
        public abstract string CreateInsertIntoTmpQuery(List<Parametre> output, string tableTmp);
        public abstract string CreateTriggerQuery(string tableTmp, string evenenement);
        public abstract string CreateSPHeader(List<Parametre> input, string nomSP);
        /// <summary>
        ///<para>1 List(sum_moy) output =>args[0]</para>
        ///<para>2 List(sum_moy) input =>args[1]</para>
        ///<para>3 string nomStoredProcedure =>args[2]</para>
        ///<para>4 string nom_table_temporaire =>args[3]</para>
        ///<para>5 string Nom_Evenemnt =>args[4]</para>
        ///<para>6 string viewName =>args[5]</para>
        /// </summary>
        /// <param name="connectToSystem">un connector pour se connecter à la BD du system</param>
        /// <param name="args">les argument needed par connector's methodes</param>
        /// <returns>string</returns>
        public abstract string CreateStoredProcedureQuery(ConnexionSysteme sysAmont, params object[] args);
        ////Autres Methodes
        public abstract int ExecuteNonQuery(string sqlQuery);
        public abstract DataTable ExecuteQuery(string sqlQuery);
        #endregion
    }
}
