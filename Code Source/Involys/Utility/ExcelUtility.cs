using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

using Involys.Pocos;

namespace Involys.Utility
{
    public static class ExcelUtility
    {
        private static OleDbConnection cnx;
        private static OleDbCommand cmd;
        private static OleDbDataAdapter da;
        private static DataSet ds = new DataSet();
        //Jet.OLEDB.4.0 | Excel 8.0 ==> office 2003
        private static string strCnx = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;'";

        private static OleDbConnection CreateConnection(string path)
        {
            if (cnx == null)
            {
                string newStr = string.Format(strCnx, path);
                cnx = new OleDbConnection(newStr);
            }
            return cnx;
        }

        public static List<string> GetSheetsNames(string path)
        {
            var con = CreateConnection(path);
            con.Open();
            DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            List<string> ls = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i][2].ToString();
                ls.Add(name.Remove(name.Length - 1, 1));//remove the ($) symbole from the end
            }
            con.Close();
            return ls;
        }

        public static List<Parametre> GetDatasFromSheet(string table)
        {
            var ls = new List<Parametre>();
            cmd = new OleDbCommand(string.Format("select * from [{0}$]", table), cnx);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds, table);
            foreach (DataRow row in ds.Tables[table].Rows)
            {
                var par = new Parametre();
                foreach (DataColumn col in ds.Tables[table].Columns)
                {
                    switch (col.ColumnName)
                    {
                        case "Champs":
                            par.Champs = row[col].ToString();
                            break;
                        case "Type":
                            par.Type = row[col].ToString();
                            break;
                        case "Taille":
                            par.Taille = Convert.ToInt32(row[col].ToString());
                            break;
                        case "NomFonctionnel":
                            par.NomFonctionnel = row[col].ToString();
                            break;
                        case "Comptabiliser":
                            par.Comptabiliser = Convert.ToInt32(row[col].ToString());
                            break;
                        case "Critere":
                            par.Critere = Convert.ToInt32(row[col].ToString());
                            break;
                        case "Developper":
                            par.Developper = Convert.ToInt32(row[col].ToString());
                            break;
                        case "Date":
                            par.Date = Convert.ToInt32(row[col].ToString());
                            break;
                        case "Cle":
                            par.Cle = Convert.ToInt32(row[col].ToString());
                            break;
                        case "Date_Maj":
                            par.DatMaj = Convert.ToInt32(row[col].ToString());
                            break;
                        case "Impression":
                            par.Impression = Convert.ToInt32(row[col].ToString());
                            break;
                    }
                }
                ls.Add(par);
            }
            return ls;
        }
    }
}
