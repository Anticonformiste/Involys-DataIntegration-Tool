using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;

namespace Involys.Utility.Exportation
{
    public class DataXmlExporter:DataExporter
    {
        public override void Exporter(string separateur = "")
        {
            //Enregistrer D'abord les enregistrements de la table
            tbl.TableName = "Record";
            tbl.WriteXml(filename + ".xml", true);
            //Apres lire le fichier pour ajouter le header et le footer
            XmlDocument doc = new XmlDocument();
            doc.Load(filename + ".xml");
            var root = doc.DocumentElement;

            #region Header
            var header = doc.CreateElement("Header");
            if (date)
            {
                var dt = doc.CreateElement("DateOperation");
                dt.InnerText = DateTime.Now.ToLongDateString();
                header.AppendChild(dt);
            }
            if (!string.IsNullOrEmpty(nomEvent))
            {
                var nmev = doc.CreateElement("NomEvenement");
                nmev.InnerText = nomEvent;
                header.AppendChild(nmev);
            }
            #endregion

            #region Footer
            var footer = doc.CreateElement("Footer");
            if (count)
            {
                var cnt = doc.CreateElement("NombreDesRecords");
                cnt.InnerText = tbl.Rows.Count.ToString();
                footer.AppendChild(cnt);
            }

            #region Les Sommes
            if (sum != null && sum.Count > 0)
            {
                var sumNode = doc.CreateElement("SommesDesChamps");
                //parcourir la liste des indices
                foreach (var indx in sum)
                {
                    List<double> valeurs = new List<double>();
                    //parcourir la table
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        valeurs.Add(Convert.ToDouble(tbl.Rows[i][indx].ToString()));
                    }
                    //Creer un node pour le chmaps et mettre dedans sa somme
                    var champSum = doc.CreateElement(tbl.Columns[indx].ColumnName);
                    champSum.InnerText = valeurs.Sum().ToString();
                    //ajouter le champs au node (sumNode)
                    sumNode.AppendChild(champSum);
                }
                footer.AppendChild(sumNode);
            }
            #endregion

            #region Les Moyennes
            if (avg != null && avg.Count > 0)
            {
                var avgNode = doc.CreateElement("MoyennesDesChamps");
                //parcourir la liste des indices
                foreach (var indx in avg)
                {
                    List<double> valeurs = new List<double>();
                    //parcourir la table
                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                        valeurs.Add(Convert.ToDouble(tbl.Rows[i][indx].ToString()));
                    }
                    //Creer un node pour le chmaps et mettre dedans sa moyenne
                    var champAvg = doc.CreateElement(tbl.Columns[indx].ColumnName);
                    champAvg.InnerText = valeurs.Average().ToString();
                    //ajouter le champs au node moyenne(avgNode)
                    avgNode.AppendChild(champAvg);
                }
                footer.AppendChild(avgNode);
            }
            #endregion
            #endregion

            root.PrependChild(header);
            root.AppendChild(footer);
            doc.AppendChild(root);
            doc.Save(filename + ".xml");
        }
    }
}
