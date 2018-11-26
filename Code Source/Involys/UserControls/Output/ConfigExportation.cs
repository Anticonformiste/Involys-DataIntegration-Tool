using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Involys.Utility.Exportation;
using Involys.Pocos;
using Involys.DataAccess.Services;

using MetroFramework.Animation;
using MetroFramework;

namespace Involys.UserControls.Output
{
    public partial class ConfigExportation : BaseUC
    {
        private DataExporter exporter;
        private ServiceMouvements servMvt;

        private static DataTable table;
        private List<Parametre> sum_avg;
        private string separateur;
        //Header
        private bool date = false, colsName = false;
        private string nomEvent = string.Empty;
        //Footer
        private bool count = false;
        private List<int> sum, avg;//Les indices des colonnes à traités

        //constructor
        public ConfigExportation()
        {
            InitializeComponent();
            table = new DataTable();
            sum_avg = new List<Parametre>();
            servMvt = new ServiceMouvements();
        }

        public override void Recharger()
        {
            ServiceEvenements servEvent = new ServiceEvenements();
            servEvent.Connector = this.Connector;
            servMvt.Connector = this.Connector;
            //Remplissage Des Evenements
            events_liste.DataSource = servEvent.GetAll();
            events_liste.DisplayMember = "Libelle";
            events_liste.ValueMember = "Code";
            //Remplissage du type de fichier
            typeFile_liste.DataSource = Enum.GetNames(typeof(FileType));
            //Remplissage des listesbox
            if (sum_avg != null && sum_avg.Count > 0)
            {
                foreach (var item in sum_avg)
                {
                    sum_list.Items.Add(item.NomFonctionnel); sum = new List<int>();
                    avg_list.Items.Add(item.NomFonctionnel); avg = new List<int>();
                }
            }
        }


        private void events_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remplissage de champs et de la gridview
            var even = (Evenement)events_liste.SelectedItem;
            FillSumAvgList(even.Code);//remplissage de la liste des champs numeric
            table = servMvt.GetAll(even.Libelle);
            mvt_grid.DataSource = table;
        }

        private void SumAvg_checkedChanged(object sender, EventArgs e)
        {
            if (sum_avg != null && sum_avg.Count > 0)
            {
                ExpandAnimation ea = new ExpandAnimation();
                ExpandAnimation ea2 = new ExpandAnimation();
                //Afficher ou chacher les listesBox
                sum_list.Visible = sum_cb.Checked;
                avg_list.Visible = avg_cb.Checked;
                //Reglage de l'animation
                if (!sum_cb.Checked && !avg_cb.Checked)
                {//Reduire
                    ea.Start(footer_panel, new Size(832, 53), TransitionType.EaseInExpo, 15);
                    ea2.Start(this, new Size(835, 520), TransitionType.EaseInExpo, 10);
                }
                else
                {
                    ea.Start(footer_panel, new Size(832, 126), TransitionType.EaseInExpo, 15);
                    ea2.Start(this, new Size(835, 592), TransitionType.EaseInExpo, 10);
                }
            }
            else
            {
                //Unsubscribe Event
                sum_cb.CheckedChanged -= SumAvg_checkedChanged;
                avg_cb.CheckedChanged -= SumAvg_checkedChanged;
                //uncheck controls
                sum_cb.Checked = avg_cb.Checked = false;
                //Subscribe Event
                sum_cb.CheckedChanged += SumAvg_checkedChanged;
                avg_cb.CheckedChanged += SumAvg_checkedChanged;
                MessageBox.Show("Aucun Champs Numeric Dans Votre Resultat pour effectuer cette tache !");
            }
        }

        private void sepOk_btn_Click(object sender, EventArgs e)
        {
            separateur = (string.IsNullOrEmpty(sep_tb.Text)) ? " " : sep_tb.Text;
            sep_panel.Visible = false;
        }

        private void typeFile_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileType ft;
            Enum.TryParse<FileType>(typeFile_liste.SelectedValue.ToString(), out ft);
            //Pour affciher la zone du separateur
            sep_panel.Visible = (ft.Equals(FileType.CSV) || ft.Equals(FileType.Text)) ? true : false;
            //Instanciation du Exporter selon le type volu
            switch (ft)
            {
                case FileType.CSV:
                    exporter = new DataCsvExporter();
                    break;
                case FileType.Text:
                    exporter = new DataTextExporter();
                    break;
                case FileType.XML:
                    exporter = new DataXmlExporter();
                    break;
                case FileType.Excel:
                    exporter = new DataExcelExporter();
                    break;
                default:
                    MessageBox.Show("Choisir Un Type d'Exportation Valide s'Il Vous Plait");
                    break;
            }
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            if (folderDialog1.ShowDialog() == DialogResult.OK && table!=null && table.Rows.Count>0)
            {
                try
                {
                    var folder = folderDialog1.SelectedPath;
                    var fileName = folder + @"\" + nomFile_tb.Text;
                    bool dtOnFN = dateFileName_cb.Checked;
                    //header
                    colsName = colNames_cb.Checked;
                    date = dateHeader_cb.Checked;

                    #region ReglageFooter
                    count = count_cb.Checked;
                    if (sum != null)
                    {
                        sum.Clear();
                        //les sommes
                        foreach (var item in sum_list.CheckedItems)
                        {
                            sum.Add(sum_avg[sum_list.Items.IndexOf(item)].Ordre);
                        }
                    }

                    if (avg != null)
                    {
                        avg.Clear();
                        //les moyennes
                        foreach (var item in avg_list.CheckedItems)
                        {
                            avg.Add(sum_avg[avg_list.Items.IndexOf(item)].Ordre);
                        }
                    }
                    #endregion

                    //Exportation
                    exporter.SetPrerequisites(table, fileName, true);
                    exporter.SetHeader(date, nomEvent, colsName);
                    exporter.SetFooter(count, sum, avg);
                    exporter.Exporter(separateur);
                    MetroMessageBox.Show(this, "Exportation Terminée Avec Succées", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Une Erreur Est Survenu Lors De l'Exportation", "Erreur d'Exportation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MetroMessageBox.Show(this, "Il y aucune donnée à exporter", "Table Vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Implementations
        private void FillSumAvgList(int eventCode)
        {
            ServiceStructures servStruct = new ServiceStructures();
            servStruct.Connector = this.Connector;
            var all = servStruct.GetByEvenement(eventCode);
            //Passer les parametres Numeric, pour calculer les sommes ou les moyennes
            var numeric_types = new string[] { "Entier", "Réel" };
            sum_avg = (from param in all
                                      where numeric_types.Contains(param.Type)
                                      select param).ToList();
        }
        #endregion
    }
}
