using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace Involys.Utility.Exportation
{
    public class DataCsvExporter:DataExporter
    {
        private void WriteTextFile(ref List<string> lines, string separateur = ",")
        {
            #region Header
            if (date)
                lines.Add(DateTime.Now.ToLongDateString());
            if (!string.IsNullOrEmpty(nomEvent))
                lines.Add(nomEvent);
            //Noms des colonne
            if (colsName)
            {
                lines.Add("\n");
                string[] columnNames = tbl.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();
                var cols = string.Join(",", columnNames);
                lines.Add(cols);
            }
            #endregion

            #region Body
            //Avoir les valeurs d'une ligne separé par [separateur]
            var valueLines = tbl.AsEnumerable()
                               .Select(row => string.Join(separateur, row.ItemArray));
            lines.AddRange(valueLines);
            #endregion
            lines.Add(Environment.NewLine);
            #region Footer
            if (count)
                lines.Add("Nombre Des Enregistrements: " + tbl.Rows.Count.ToString());
            //Les sommes
            if (sum != null && sum.Count > 0)
            {
                lines.Add("Les Sommes Des Colonnes Entrées:");
                //parcourir la liste des indices
                foreach (var indx in sum)
                {
                    List<double> valeurs = new List<double>();
                    //parcourir la table
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        //Les colonnes sont déja verifiés qu'il contient des valeurs numerics
                        //Avant de les passés du userSpace To Exportation
                        valeurs.Add(Convert.ToDouble(tbl.Rows[i][indx].ToString()));
                    }
                    lines.Add(string.Format("[{0}]: {1}", tbl.Columns[indx].ColumnName, valeurs.Sum().ToString()));
                }
            }
            //Les moyennes
            if (avg != null && avg.Count > 0)
            {
                lines.Add("Les Moyennes Des Colonnes Entrées:");
                //parcourir la liste des indices
                foreach (var indx in avg)
                {
                    List<double> valeurs = new List<double>();
                    //parcourir la table
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        //Les colonnes sont déja verifiés qu'il contient des valeurs numerics
                        //Avant de les passés du userSpace To Exportation
                        valeurs.Add(Convert.ToDouble(tbl.Rows[i][indx].ToString()));
                    }
                    lines.Add(string.Format("[{0}]: {1}", tbl.Columns[indx].ColumnName, valeurs.Average().ToString()));
                }
            }
            #endregion
        }

        public override void Exporter(string separateur = "")
        {
            var lines = new List<string>();
            WriteTextFile(ref lines, separateur);
            File.WriteAllLines(filename + ".csv", lines);
        }
    }
}
