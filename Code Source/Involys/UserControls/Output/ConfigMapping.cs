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

using Involys.DataAccess.Connectors;
using Involys.DataAccess.Services;
using Involys.Pocos;
using Involys.Utility;

namespace Involys.UserControls.Output
{
    public partial class ConfigMapping : BaseUC
    {
        private ServiceEvenements servEvents;
        private ServiceConnexionsSystemes servConSys;
        private ServiceStructures servStructs;
        private ServiceDesVues servViews;
        private ServiceConditions servCondi;

        private List<Parametre> outputs,inputs;

        private string sqlStoredProcedure="";

        #region MesImplementations
        private void DropIntoGridView(DataGridView dgv, DragEventArgs e, List<Parametre> liste)
        {
            #region Reorder Rows
            var row = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
            if (row != null)
            {
                // get source and target indices
                var pt = dgv.PointToClient(new Point(e.X, e.Y));
                var ht = dgv.HitTest(pt.X, pt.Y);
                int src = row.Index;
                int dst = ht.RowIndex;
                // -1 c'est a dire au fin de la liste
                if (dst < 0)
                {
                    dst = dgv.Rows.Count - 1;
                }
                // deplacer la ligne
                if (src != dst)
                {
                    dgv.Rows.RemoveAt(src);
                    dgv.Rows.Insert(dst, row);
                }
                return;
            }
            #endregion

            #region Insert New Rows
                TreeNode node = (TreeNode)e.Data.GetData(typeof(TreeNode));
                var fieldsToDrop = new List<Parametre>();
                fieldsToDrop.Add((Parametre)node.Tag);

                #region Do Drop And Add To GridView
                // Chercher l'emplacement du DROP
                Point pnt = dgv.PointToClient(new Point(e.X, e.Y));
                DataGridView.HitTestInfo info = dgv.HitTest(pnt.X, pnt.Y);
                foreach (var field in fieldsToDrop)
                {
                    //Creer une ligne de cette datagridview
                    DataGridViewRow dgvr = (DataGridViewRow)dgv.RowTemplate.Clone();
                    dgvr.CreateCells(dgv);
                    dgvr.Cells[0].Value = field.Champs;
                    dgvr.Cells[1].Value = field.Type;
                    //Verifier que l'element n'existe pas avant le drop
                    bool existe = false;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (dgv.Rows[i].Cells[0].Value.Equals(dgvr.Cells[0].Value))
                        {
                            existe = true;
                            MessageBox.Show("Ce Champs Est Déja Existe Dans La Liste");
                            dgv.ClearSelection();
                            dgv.Rows[i].Selected = true;
                            break;
                        }
                    }
                    if (!existe)
                    {
                        if (info.RowIndex == -1)// si le 1er drop
                        {
                            dgv.Rows.Add(dgvr);
                        }
                        else// si il y a des autres lignes avant et prendre en consideration l'ordre de drop
                        {
                            dgv.Rows.Insert(info.RowIndex, dgvr);
                        }
                        //Ajouter à la liste correspondante
                        liste.Add(field);
                    }
                }
                #endregion
            #endregion

            //AffecteOutputsOrders();
        }

        //private void AffecteOutputsOrders()
        //{
        //    for (int i = 0; i < output_grid.Rows.Count; i++)
        //    {
        //        var champs = output_grid.Rows[i].Cells[0].Value.ToString();
        //        outputs.Find(x => x.Champs.Equals(
        //                    champs, StringComparison.CurrentCultureIgnoreCase)
        //                    ).Ordre = i;
        //    }
        //}
        #endregion

        public ConfigMapping()
        {
            servConSys = new ServiceConnexionsSystemes();
            servEvents = new ServiceEvenements();
            servStructs = new ServiceStructures();
            servViews = new ServiceDesVues();
            servCondi = new ServiceConditions();
            outputs = new List<Parametre>();
            inputs = new List<Parametre>();
            InitializeComponent();
        }

        public override void Recharger()
        {
            servConSys.Connector = this.Connector;
            servEvents.Connector = this.Connector;
            servStructs.Connector = this.Connector;
            servCondi.Connector = this.Connector;
            //remplir les systemes
            systemes_liste.DataSource = servConSys.GetAll();
            systemes_liste.DisplayMember = "Libelle";
            systemes_liste.ValueMember = "Code";
        }

        private void systemes_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            var system = (ConnexionSysteme)systemes_liste.SelectedItem;
            //remplir les evenements
            evenets_liste.DataSource = servEvents.GetBySystem(system.Code);
            evenets_liste.DisplayMember = "Libelle";
            evenets_liste.ValueMember = "Code";
            //remplir les vues
            views_liste.Items.Clear();
            foreach (var item in servViews.GetAllBySystem(system))
            {
                views_liste.Items.Add(item);
            }
        }

        private void evenets_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            var even = (Evenement)evenets_liste.SelectedItem;
            //remplissage des conditions
            conditions_liste.DataSource = servCondi.GetByEvenement(even.Code);
            conditions_liste.DisplayMember = "Libelle";
            conditions_liste.ValueMember = "Ref_Util";
            //remplissage des champs(structure) de l'evenement
            champs_tree.Nodes.Clear();
            outputs = servStructs.GetByEvenement(even.Code);
            foreach (var item in outputs)
            {
                var node = new TreeNode {Text=item.Champs,Tag=item};
                champs_tree.Nodes.Add(node);
            }
            input_grid.Rows.Clear(); inputs.Clear();
        }

        private void champs_tree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        #region Input Drag&drop
        private void input_grid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void input_grid_DragDrop(object sender, DragEventArgs e)
        {
            DropIntoGridView(input_grid, e, inputs);
        }
        #endregion

        #region Supression Des Parametres
        private void input_grid_KeyDown(object sender, KeyEventArgs e)
        {
            //La supression des parametres d'entrées
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    foreach (DataGridViewRow item in input_grid.SelectedRows)
                    {
                        int indx = input_grid.Rows.IndexOf(item);
                        inputs.RemoveAt(indx);
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void generer_btn_Click(object sender, EventArgs e)
        {
            //Generation de la procedure
            var view = views_liste.SelectedItem.ToString();
            var evenement = (Evenement)evenets_liste.SelectedItem;
            var systemAmont = (ConnexionSysteme)systemes_liste.SelectedItem;
            var condition = (Condition)conditions_liste.SelectedItem;
            sqlStoredProcedure = Connector.CreateStoredProcedureQuery(systemAmont, outputs, inputs,
            nameSp_tb.Text, condition.TableTmp, evenement.Libelle, view);
            Clipboard.SetText(sqlStoredProcedure);
            MessageBox.Show("La SP est bien generée, et copiée");
        }

        private void valider_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sqlStoredProcedure))
            {
                var systemAmont = (ConnexionSysteme)systemes_liste.SelectedItem;
                var amontConnector = DatasUtility.GetConenctorByProvider(systemAmont.ServerType);
                amontConnector.cnxHelper = systemAmont.CnxHelper;
                MessageBox.Show("AmontConnector: "+amontConnector.GetChaineConnection());
                if(amontConnector.ExecuteNonQuery(sqlStoredProcedure)==0)
                    MessageBox.Show("La Procedure à été bien créer sur le systeme");
                else
                    MessageBox.Show("Il y avait une erreur dans la creation de la procedure stockée");
            }
            else
                MessageBox.Show("Veuillez generer d'abord la procedure stockée");
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            inputs.Clear(); input_grid.Rows.Clear();
            nameSp_tb.Clear();
            sqlStoredProcedure = "";
        }
    }
}
