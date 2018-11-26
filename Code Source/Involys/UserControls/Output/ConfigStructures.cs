using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Components;

using Involys.DataAccess.Connectors;
using Involys.DataAccess.Services;
using Involys.Pocos;
using Involys.Utility;

namespace Involys.UserControls.Output
{
    public partial class ConfigStructures : BaseUC
    {
        private ServiceConnexionsSystemes servConSys;
        private ServiceEvenements servEvents;
        private ServiceStructures servStructs;

        private BindingList<Parametre> liste;
        private BindingSource bs,bsDb;

        public ConfigStructures()
        {
            InitializeComponent();
            servConSys = new ServiceConnexionsSystemes();
            servEvents = new ServiceEvenements();
            servStructs = new ServiceStructures();
            sysAmont_liste.SelectedIndexChanged -= sysAmont_liste_SelectedIndexChanged;
            evenements_liste.SelectedIndexChanged -= evenements_liste_SelectedIndexChanged;
        }

        public override void Recharger()
        {
            servEvents.Connector = this.Connector;
            servConSys.Connector = this.Connector;
            servStructs.Connector = this.Connector;
            //Remplir les system
            sysAmont_liste.DataSource = servConSys.GetAll();
            sysAmont_liste.DisplayMember = "Libelle";
            sysAmont_liste.ValueMember = "Code";
            //Attacher les evenement
            sysAmont_liste.SelectedIndexChanged += sysAmont_liste_SelectedIndexChanged;
            evenements_liste.SelectedIndexChanged += evenements_liste_SelectedIndexChanged;
        }

        private void sysAmont_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remplir la liste des Evenements
            int code = int.Parse(sysAmont_liste.SelectedValue.ToString());
            evenements_liste.DataSource = servEvents.GetBySystem(code);
            evenements_liste.DisplayMember = "Libelle";
            evenements_liste.ValueMember = "Code";
        }

        private void evenements_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remplir la data Grid View par la structure(lES CHAMPS DE CET EVENT)
            int even = -1;
            if (int.TryParse(evenements_liste.SelectedValue.ToString(), out even))
            {
                modifyField_grid.Rows.Clear();
                liste = new BindingList<Parametre>(servStructs.GetByEvenement(even));
                bs = new BindingSource(liste, null);
                structures_Grid.DataSource = bs;
                structures_Grid.CellMouseClick += structures_Grid_CellMouseClick;
                submit_btn.Enabled = false;
            }
        }

        private void structures_Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var src = new List<Parametre>();
            var obj = (Parametre)liste[bs.Position].Clone();
            obj.Evenement = servEvents.GetByCode(Convert.ToInt32(evenements_liste.SelectedValue.ToString()));
            src.Add(obj);
            bsDb = new BindingSource(src, null);
            modifyField_grid.DataSource = bsDb;
        }

        private void modifyField_grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Verifier vos données", "Donnée Incorrecte");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            var current = (Parametre)bsDb.Current;
            MessageBox.Show(current.Champs);
            if (!liste.Any(o => o.Champs.Equals(current.Champs, StringComparison.CurrentCultureIgnoreCase)))
            {
                if (servStructs.Ajouter(current) == 0)
                {
                    MessageBox.Show("Le sum_moy à éte ajouté avec succés");
                    evenements_liste_SelectedIndexChanged(this, EventArgs.Empty);
                }
                else
                    MessageBox.Show("Une Erreur Dans L'ajout");
            }
            else
                MessageBox.Show("Il existe déja un parametre avec ce nom de champs dans cet evenement");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            var new_current = (Parametre)bsDb.Current;
            var ancien = (Parametre)bs.Current;
            if (servStructs.Modifier(new_current, ancien) == 0)
            {
                MessageBox.Show("Le champs à été Modifié avec succés");
                evenements_liste_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
                MessageBox.Show("Une Erreur Dans la modification");
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            var current = (Parametre)bsDb.Current;
            if (servStructs.Supprimer(current) == 0)
            {
                MessageBox.Show("Le sum_moy à été Supprimé avec succés");
                evenements_liste_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
                MessageBox.Show("Une Erreur Dans la suppression");
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Selection Le Canvas De Parmétrage du "+evenements_liste.SelectedText;
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                file_tb.Text = ofd.FileName;
            }
        }

        private void loadfile_btn_Click(object sender, EventArgs e)
        {
            var mb = MessageBox.Show(@"Le chrgement de structures depuis le canvas annuleras toute structure 
                                    prédefini dans la BD pour cet evenement.\n
                                    Etes-Vous sure de continuer?","Demande De Confirmation",
                                    MessageBoxButtons.OKCancel);
            if (mb==DialogResult.OK)
            {
                //Call Excel Reader
                var sheet = ExcelUtility.GetSheetsNames(file_tb.Text)[0];
                var datas = ExcelUtility.GetDatasFromSheet(sheet);
                var even = servEvents.GetByCode(Convert.ToInt32(evenements_liste.SelectedValue.ToString()));
                //affecter le code Table
                foreach (var item in datas)
                {
                    item.Evenement = even;
                } 
                //Bind Datas
                liste = new BindingList<Parametre>(datas);
                bs = new BindingSource(liste,null);
                structures_Grid.DataSource = bs;
                //desactiver le panel des modification
                modifyField_grid.DataSource = null;
                fields_panel.Enabled = false;
                //Permettre la modification
                structures_Grid.ReadOnly = false;
                //annuler le rowclick
                structures_Grid.CellMouseClick -= structures_Grid_CellMouseClick;
                submit_btn.Enabled = true;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            var bw = new BackgroundWorker();
            int evenCode = Convert.ToInt32(evenements_liste.SelectedValue.ToString());
            string even = evenements_liste.SelectedText;
            bw.DoWork += (send, ev) =>
            {
                try
                {
                    //Vider La Table Structure
                    servStructs.Clear();
                    //Inserer la masse du Canvas Vers La base de données
                    foreach (var item in liste)
                    {
                        servStructs.Ajouter(item);
                    }
                    ev.Result = 0;
                }
                catch (Exception)
                { ev.Result = -1; }
            };

            bw.RunWorkerCompleted += (send, ev) =>
            {
                if (int.Parse(ev.Result.ToString())==0)
                {
                    //Refraichir
                    evenements_liste_SelectedIndexChanged(this, EventArgs.Empty);
                    //activer le panel des modification
                    fields_panel.Enabled = true;
                    //deny la modification
                    structures_Grid.ReadOnly = true;
                    loadProgress.Visible = false;
                    file_tb.Clear();
                    MessageBox.Show(string.Format("Parametrage de l'evenement {0} terminer avec succés.", even));
                }
                else
                    MessageBox.Show(string.Format("Il y avait une erreur dans le parametrage de l'evenement {0}.",even));
            };
            loadProgress.Visible = true;
            bw.RunWorkerAsync();
        }
        
    }
}
