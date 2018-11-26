using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Involys.Utility.Exportation
{
    public class DataExcelExporter:DataExporter
    {
        public override void Exporter(string separateur = "")
        {
            #region Preparation des Objets
            object misValue = System.Reflection.Missing.Value;
            //Creer une application excel
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //Creer un workbook
            Microsoft.Office.Interop.Excel.Workbook excelWorkBook = excelApp.Workbooks.Add(misValue);
            //Ajouter un nouveau worksheet to workbook avec le nom d'evenement
            Microsoft.Office.Interop.Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
            excelWorkSheet.Name = nomEvent;
            #endregion

            #region Header
            int startRow = 1;
            //La date du jours
            if (date)
            {
                excelWorkSheet.Cells[startRow, 1] = "Date Géneration";
                excelWorkSheet.Cells[startRow, 1].Font.Bold = true;
                excelWorkSheet.Cells[startRow++, 2] = DateTime.Now.ToLongDateString();
            }
            excelWorkSheet.Cells[startRow, 1] = "Evenement";
            excelWorkSheet.Cells[startRow, 1].Font.Bold = true;
            excelWorkSheet.Cells[startRow, 1].Font.Size = 14;
            excelWorkSheet.Cells[startRow++, 2] = nomEvent;
            if (colsName)
            {
                //Ecrire Les Noms Des Colonnes
                for (int i = 1; i < tbl.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[startRow, i] = tbl.Columns[i - 1].ColumnName;
                }
            }
            #endregion

            //Ecrire Les Données
            for (int j = 0; j < tbl.Rows.Count; j++)
            {
                startRow++;
                for (int k = 0; k < tbl.Columns.Count; k++)
                {
                    excelWorkSheet.Cells[startRow, k + 1] = tbl.Rows[j][k].ToString();
                }
            }

            #region Footer
            startRow++;
            //Nombre des enregistrements
            if (count)
            {
                excelWorkSheet.Cells[startRow, 1] = "Nombre Des Enregistrement";
                excelWorkSheet.Cells[startRow, 1].Font.Bold = true;
                excelWorkSheet.Cells[startRow, 1].Font.Size = 14;
                excelWorkSheet.Cells[startRow++, 2] = tbl.Rows.Count.ToString();
            }

            #region Les Sommes
            if (sum != null && sum.Count > 0)
            {
                excelWorkSheet.Cells[startRow, 1].Font.Bold = true;
                excelWorkSheet.Cells[startRow, 1].Font.Size = 14;
                excelWorkSheet.Cells[startRow++, 1] = "Sommes Des Champs";//changer le font
                //parcourir la liste des indices
                foreach (var indx in sum)
                {
                    List<double> valeurs = new List<double>();
                    //parcourir la table
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        valeurs.Add(Convert.ToDouble(tbl.Rows[i][indx].ToString()));
                    }
                    excelWorkSheet.Cells[startRow, 1] = tbl.Columns[indx].ColumnName;
                    excelWorkSheet.Cells[startRow, 1].Font.Italic = true;
                    excelWorkSheet.Cells[startRow++, 2] = valeurs.Sum().ToString();
                }
            }
            #endregion

            #region Les Moyennes
            if (avg != null && avg.Count > 0)
            {
                excelWorkSheet.Cells[startRow++, 1] = "Moyennes Des Champs";
                //parcourir la liste des indices
                foreach (var indx in avg)
                {
                    List<double> valeurs = new List<double>();
                    //parcourir la table
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        valeurs.Add(Convert.ToDouble(tbl.Rows[i][indx].ToString()));
                    }
                    excelWorkSheet.Cells[startRow, 1] = tbl.Columns[indx].ColumnName;
                    excelWorkSheet.Cells[startRow, 1].Font.Italic = true;
                    excelWorkSheet.Cells[startRow++, 2] = valeurs.Average().ToString();
                }
            }
            #endregion
            #endregion

            //Sauveguarder le fichier
            excelWorkBook.SaveAs(filename + ".xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
            misValue, misValue, misValue, misValue,
            Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
            misValue, misValue, misValue, misValue, misValue);

            excelWorkBook.Close();
            excelApp.Quit();
            //Liberer les COM
            Marshal.ReleaseComObject(excelWorkSheet);
            Marshal.ReleaseComObject(excelWorkBook);
            Marshal.ReleaseComObject(excelApp);
        }
    }
}
