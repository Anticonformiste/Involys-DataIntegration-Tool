using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

using Involys.Pocos;
using Involys.Utility;
using System.Data;

namespace Involys.DataAccess.Connectors
{
    public class MSSQLConnecctor:DbConnector
    {
        /*Constructeur*/
        public MSSQLConnecctor(ConnectionHelper helper)
            : base(helper)
        {}
        /*Methodes*/

        public override string GetChaineConnection()
        {
            if (!string.IsNullOrEmpty(cnxHelper.Database))
                cnxString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
                cnxHelper.Server, cnxHelper.Database, cnxHelper.Username, cnxHelper.Password);
            else
                cnxString = string.Format("Data Source={0};User ID={1};Password={2}", 
                            cnxHelper.Server, cnxHelper.Username, cnxHelper.Password);
            return cnxString;
        }

        public override DbConnection GetConnection()
        {
            if (cnx == null)
                cnx = (DbConnection)Activator.CreateInstance(typeof(System.Data.SqlClient.SqlConnection), GetChaineConnection());
            cnx.Close();
            //redefinir à chaque fois la chaine de connection, Utile pour la basculation entre server/DB
            cnx.ConnectionString = GetChaineConnection();
            return cnx;
        }

        public override List<string> GetServerDatabases()
        {
            List<string> ls = new List<string>();
            try
            {
                var cmd = GetConnection().CreateCommand();
                cmd.CommandText = @"SELECT [name] FROM master.dbo.sysdatabases WHERE dbid > 6";
                GetConnection().Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ls.Add(dr[0].ToString());
                }
                GetConnection().Close();
            }
            catch (Exception)
            {
                return null;
            }
            return ls;
        }

        public override string CreateSelectQuery(List<Parametre> output, List<Parametre> input, string viewEvent)
        {
            //trier les parametre selon l'ordre de sortie
            List<Parametre> ordered = output.OrderBy(p => p.Ordre).ToList();
            var sb = new StringBuilder();
            #region SELECT
            sb.Append("SELECT ");
            //parcours de l'output
            foreach (var param in ordered)
            {
                if (ordered.IndexOf(param) > 0)
                    sb.Append(",");
                sb.Append("[" + viewEvent + "]");
                sb.Append(".");
                sb.Append("[" + param.Champs + "]");
            }
            #endregion
            sb.Append(string.Format("\nFROM [{0}]",viewEvent));
            #region Where(Les Parametres d'entrées)
            if (input.Count > 0)
            {
                sb.Append("\nWHERE ");
                foreach (var item in input)
                {
                    //[table].[champs] = @nom_fonctionnel
                    if (input.IndexOf(item) != 0)
                        sb.Append(" AND ");
                    sb.Append(string.Format("[{0}] = @{1}", item.Champs, item.NomFonctionnel));
                }
            }
            #endregion
            return sb.ToString();
        }

        public override string MakeCreateTableQuery(List<Parametre> output, string tableTmp)
        {
            var sb = new StringBuilder();
            //supprimmer la table temporaire avant de la créer à nouveau*
            string delQuery = "IF exists(SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME='{0}')";
            sb.Append(string.Format(delQuery + "\n", tableTmp));
            sb.AppendLine("BEGIN");
            sb.AppendLine(string.Format("DROP TABLE {0}", tableTmp));
            sb.AppendLine("END");
            sb.Append(string.Format("CREATE TABLE {0}(\n", tableTmp));
            sb.Append("ID int identity(1,1) primary key");//Ajouter la colonne cle "ID" des tables temporaires
            //La liste Output doit etre ordonnée
            foreach (var item in output)
            {
                sb.Append(",\n");
                //[Champs] Type(Taille)
                switch (item.Type.ToLower())
                {
                    case "entier":
                        sb.Append(string.Format("[{0}] {1}", item.Champs, "int", item.Taille));
                        break;
                    case "réel":
                        sb.Append(string.Format("[{0}] {1}({2})", item.Champs, "decimal", item.Taille));
                        break;
                    case "text":
                        sb.Append(string.Format("[{0}] {1}({2})", item.Champs, "nvarchar", item.Taille));
                        break;
                    case "date":
                        sb.Append(string.Format("[{0}] {1}", item.Champs, "date", item.Taille));
                        break;
                }
            }
            sb.Append(");");
            return sb.ToString();
        }

        public override string CreateInsertIntoTmpQuery(List<Parametre> output, string tableTmp)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("INSERT INTO dbo.[{0}](", tableTmp));
            foreach (var item in output)
            {
                if (output.IndexOf(item) > 0)
                    sb.Append(", ");
                sb.Append(string.Format("{0}", item.Champs));
            }
            sb.Append(")");
            return sb.ToString();
        }

        public override string CreateTriggerQuery(string tableTmp, string evenenement)
        {
            var triggerValue = DatasUtility.GetFileTriggerValue(tableTmp, evenenement);
            return triggerValue;
        }

        public override string CreateSPHeader(List<Parametre> input, string nomSP)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("CREATE PROCEDURE {0}", nomSP));

            if (input.Count > 0)
            {
                sb.Append("(\n");
                foreach (var item in input)
                {
                    if (input.IndexOf(item) != 0)
                        sb.Append(", ");
                    switch (item.Type.ToLower())
                    {
                        case "entier":
                            sb.Append(string.Format("@{0} {1}", item.Champs, "int"));
                            break;
                        case "réel":
                            sb.Append(string.Format("@{0} {1}({2})", item.Champs, "decimal", item.Taille));
                            break;
                        case "text":
                            sb.Append(string.Format("@{0} {1}({2})", item.Champs, "nvarchar", item.Taille));
                            break;
                        case "date":
                            sb.Append(string.Format("@{0} {1}", item.Champs, "date"));
                            break;
                    }
                }
                sb.Append(")");
            }
            sb.Append("\nAS");
            return sb.ToString();
        }

        public override string CreateStoredProcedureQuery(ConnexionSysteme sysAmont, params object[] args)
        {
            try
            {
                var output = (List<Parametre>)args[0]; var input = (List<Parametre>)args[1];
                string nomSp = args[2].ToString(); string tmp = args[3].ToString();
                string evenement = args[4].ToString(); string viewName = args[5].ToString();
                //Connecteur vers le systéme amont
                DbConnector connectToSystem = DatasUtility.GetConenctorByProvider(sysAmont.ServerType);
                connectToSystem.cnxHelper = sysAmont.CnxHelper;
                StringBuilder sb = new StringBuilder();
                //l'entete de la procedure
                sb.Append(connectToSystem.CreateSPHeader(input, nomSp));
                sb.Append("\nBEGIN");

                sb.Append("\n" + connectToSystem.MakeCreateTableQuery(output, tmp));//Creation de la table temporaire
                sb.Append("\n");
                //Check L'existance du trigger
                sb.Append("\nDeclare @checkTrSQL nvarchar(max) = '");
                sb.Append(DatasUtility.GetFileCheckTrValue(tmp, evenement));
                sb.Append("';");
                sb.Append("\nExecute(@checkTrSQL);");
                sb.Append("\n");
                //Creation du Trigger de trasmission: [Tmp] Vers La table[Mvt_tbLSortie] dans BD(INTERMEDIAIRE)
                sb.Append("\nDeclare @TrSQL nvarchar(max) = '");
                sb.Append(connectToSystem.CreateTriggerQuery(tmp, evenement));
                sb.Append("';");
                sb.Append("\nExecute(@TrSQL);");
                sb.Append("\n");
                //remplir la table temporaire avec le SELECT
                sb.Append("\n" + connectToSystem.CreateInsertIntoTmpQuery(output, tmp));
                sb.Append("\n" + connectToSystem.CreateSelectQuery(output, input, viewName));

                sb.Append("\nEND");//les SP de tous providers termine par END
                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "Error In Create Procedure:\n" + ex.Message;
            }
        }

        public override int ExecuteNonQuery(string sqlQuery)
        {
            var cnx = GetConnection();
            var cmd = cnx.CreateCommand();
            //try
            //{
                cmd.CommandText = sqlQuery;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 0;
            //}
            //catch (Exception)
            //{return 1;}
        }

        public override DataTable ExecuteQuery(string sqlQuery)
        {
            try
            {
                DataSet ds = new DataSet();
                DbCommand cmd = GetConnection().CreateCommand();
                cmd.CommandText = sqlQuery;
                DbDataAdapter da = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "result");
                return ds.Tables["result"];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
