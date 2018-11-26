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

using Involys.Pocos;
using Involys.DataAccess.Connectors;
using Involys.DataAccess.Services;
using Involys.Utility;

namespace Involys.UserControls.Output
{
    public partial class ConfigConditions : BaseUC
    {
        private ServiceConditions servCondi;
        private ServiceEvenements servEvents;

        private List<Condition> current;

        private BindingList<Condition> liste;
        private BindingSource bs;

        public ConfigConditions()
        {
            InitializeComponent();
            servCondi = new ServiceConditions();
            servEvents = new ServiceEvenements();
        }

        private void FillTreeView()
        {
            treeView1.Nodes.Clear();
            var bigNodes = ConditionsUtility.GenerateNodesFromList(servCondi.GetAll());
            foreach (var item in bigNodes)
            {
                treeView1.Nodes.Add(item);
            }
        }

        public override void Recharger()
        {
            servCondi.Connector = this.Connector;
            servEvents.Connector = this.Connector;
            //Remplir les evenements
            events_liste.DataSource = servEvents.GetAll();
            events_liste.DisplayMember = "Libelle";
            events_liste.ValueMember = "Code";
            //remplir la liste des parents(seulement de type:Racine)
            parents_liste.DataSource = servCondi.GetByType("Racine");
            parents_liste.DisplayMember = "Libelle";
            parents_liste.ValueMember = "Ref_util";
            //remplir la tree view
            FillTreeView();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            var condition = (Condition)node.Tag;

            current = new List<Condition>();
            current.Add(condition);
            bs = new BindingSource(new BindingList<Condition>(current), null);
            modifyField_grid.DataSource = bs;

            if (condition.Type.Equals("Table",StringComparison.CurrentCultureIgnoreCase))
            {
                //enable combos
                parents_liste.Enabled = types_liste.Enabled = events_liste.Enabled = true;
                //selectionner le type,le pére et l'evenement
                events_liste.SelectedValue = condition.CodeTable;
                types_liste.SelectedItem = condition.Type;
                parents_liste.SelectedValue = condition.Code_Pere;
                /*Desactiver la liste du type, il ne peut pas changer la ref_util,code_fils,type
                 le niveau aussi car il est configurable auto lors le choix du pére*/
                types_liste.Enabled = false;
                //desactiver les champs
                int[] to_disable = {0,1,3,4,6,13};
                foreach (var indx in to_disable)
                {
                    modifyField_grid.Rows[0].Cells[indx].ReadOnly = true;
                }
            }
            else//les racine on peut changer seulement leurs noms
            {
                modifyField_grid.Rows[0].ReadOnly = true;
                modifyField_grid.Rows[0].Cells[2].ReadOnly = false;//libelle
                events_liste.Enabled = parents_liste.Enabled = types_liste.Enabled = false;
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            if (!add_btn.Enabled)
            {
                new_btn.Text = "Annuler";
                add_btn.Enabled = types_liste.Enabled = true;
                treeView1.Enabled = false;
                //clear la grid view pour preparer un nouveau objet
                current = new List<Condition>();
                current.Add(new Condition());
                liste = new BindingList<Condition>(current);
                bs = new BindingSource(liste, null);
                modifyField_grid.DataSource = bs;
                //desactiver les champs
                int[] to_disable = { 3, 4, 6, 13 };
                foreach (var indx in to_disable)
                {
                    modifyField_grid.Rows[0].Cells[indx].ReadOnly = true;
                }
            }
            else //le cancel
            {
                new_btn.Text = "Nouveau";
                add_btn.Enabled = types_liste.Enabled = false;
                liste.Clear();
                treeView1.Enabled = true;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (servCondi.Ajouter(current[0]) == 0)
            {
                new_btn_Click(null, EventArgs.Empty);
                Recharger();
                MessageBox.Show("L'élement à été ajouté avec succés");
            }
            else
                MessageBox.Show("Une Erreur dans l'ajout !");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (!add_btn.Enabled)
            {
                if (servCondi.Modifier(current[0]) == 0)
                {
                    MessageBox.Show("L'élement à été modifié avec succés");
                    Recharger();
                }
                else
                    MessageBox.Show("Une Erreur dans la modification !"); 
            }
            else
                MessageBox.Show("Vous ne pouvez que ajouter maintenant");
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (!add_btn.Enabled)
            {
                if (servCondi.Supprimer(current[0].Ref_Util) == 0)
                {
                    MessageBox.Show("L'élement à été supprimé avec succés");
                    Recharger();
                }
                else
                    MessageBox.Show("Une Erreur dans la suppression !"); 
            }
            else
                MessageBox.Show("Vous ne pouvez que ajouter maintenant");
        }

        private void events_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modifyField_grid.Rows.Count>0)
            {
                modifyField_grid.Rows[0].Cells[13].Value=events_liste.SelectedValue.ToString();
            }
        }

        private void types_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modifyField_grid.Rows.Count > 0)
            {
                modifyField_grid.Rows[0].Cells[4].Value = types_liste.SelectedItem.ToString();
            }
        }

        private void parents_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            var parent = (Condition)parents_liste.SelectedItem;
            if (!add_btn.Enabled)//modifier
            {
                if (modifyField_grid.Rows.Count > 0)
                {
                    modifyField_grid.Rows[0].Cells[3].Value = parents_liste.SelectedValue.ToString();
                    modifyField_grid.Rows[0].Cells[6].Value = parent.Niveau + 1;
                }
            }
            else//ajouter
            {
                //comparer le niveau du pere et le niveau du fils si le fils de type racine aussi
                var fils = current[0];
                if (!string.IsNullOrEmpty(fils.Type) && fils.Type.Equals(parent.Type,StringComparison.CurrentCultureIgnoreCase))//2 racines
                {
                    if (parent.Niveau == 1)
                    {
                        fils.Niveau = 2;
                    }
                    else//impossible d'etre racine et niveau 3 au meme temps
                    {
                        MessageBox.Show("Impossible d'etre Racine et du Niveau 3, veuillez changer le type ou le pere à un pere du niveau 1");
                        return;
                    }
                }
                else//table ou type non encore determinée
                {
                    fils.Niveau = parent.Niveau + 1;
                    if (string.IsNullOrEmpty(fils.Type) && fils.Niveau==3)
                        types_liste.SelectedIndex = 1;
                }
                modifyField_grid.Rows[0].Cells[3].Value = parent.Ref_Util.ToString();
                modifyField_grid.Rows[0].Cells[6].Value = fils.Niveau.ToString();
            }
        }
    }
}
