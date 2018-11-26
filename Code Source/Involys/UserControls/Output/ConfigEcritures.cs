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
    public partial class ConfigEcritures : BaseUC
    {
        private ServiceEvenements servEvents;
        private ServiceConditions servCondis;
        private ServiceEcritures servEcriture;
        private ServiceStructures servStructs;
        private Ecriture current;

        private BindingSource bs;

        public ConfigEcritures()
        {
            InitializeComponent();
            servEvents = new ServiceEvenements();
            servCondis = new ServiceConditions();
            servEcriture = new ServiceEcritures();
            servStructs = new ServiceStructures();
            bs = new BindingSource();
        }

        public override void Recharger()
        {
            servEvents.Connector = this.Connector;
            servCondis.Connector = this.Connector;
            servEcriture.Connector = this.Connector;
            servStructs.Connector = this.Connector;
            //remplir les evenements
            events_liste.DataSource = servEvents.GetAll();
            events_liste.DisplayMember = "Libelle";
            events_liste.ValueMember = "Code";
        }

        private void events_liste_SelectedIndexChanged(object sender, EventArgs e)
        {//remplir les conditions de l'evenement
            conditions_liste.DataSource = servCondis.GetByEvenement(Convert.ToInt32(events_liste.SelectedValue.ToString()));
            conditions_liste.DisplayMember = "Libelle";
            conditions_liste.ValueMember = "Ref_util";
        }

        private void conditions_liste_SelectedIndexChanged(object sender, EventArgs e)
        {//remplir les ecriures de l'evenement
            var even = (Evenement)events_liste.SelectedItem;
            var condi = (Condition)conditions_liste.SelectedItem;
            ecritures_liste.DataSource = servEcriture.GetByCondition(even,condi);
            ecritures_liste.DisplayMember = "Cle";
            ecritures_liste.ValueMember = "Cle";
        }

        private void ecritures_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                current = (Ecriture)ecritures_liste.SelectedItem;
                bs.DataSource = new BindingList<ColumnEcriture>(current.Colonnes);
                columnsGrid.DataSource = bs;

                ligneCondi_tb.Text = current.Condition;
                num_tb.Text = current.Numero.ToString();
                cle_tb.Text = current.Cle.ToString();

                num_tb.ReadOnly = cle_tb.ReadOnly = true;
            }
            catch (Exception)
            {}
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            if (new_btn.Tag==null || !(bool)new_btn.Tag)
            {
                current = new Ecriture();
                current.Colonnes = new List<ColumnEcriture>();
                foreach (var item in servStructs.GetByEvenement(Convert.ToInt32(events_liste.SelectedValue.ToString())))
                {
                    current.Colonnes.Add(new ColumnEcriture { Champs = item });
                }
                var liste = new List<Ecriture>();
                liste.Add(current);
                bs.DataSource = new BindingList<ColumnEcriture>(current.Colonnes);
                columnsGrid.DataSource = bs;
                cle_tb.Clear(); num_tb.Clear(); ligneCondi_tb.Clear();
                num_tb.ReadOnly = cle_tb.ReadOnly = false;
                ecritures_liste.Enabled = false;
                new_btn.Text = "A\nn\nn\nu\nl\ne\nr";
                new_btn.Tag = true;
            }
            else
            {
                columnsGrid.DataSource = null;
                cle_tb.Clear(); num_tb.Clear(); ligneCondi_tb.Clear();
                ecritures_liste.Enabled = true;
                ecritures_liste.SelectedIndex = -1;
                new_btn.Text = "N\no\nu\nv\ne\na\nu";
                new_btn.Tag = false; 
            }
        }

        private void valider_btn_Click(object sender, EventArgs e)
        {
            if (ecritures_liste.Enabled)//modification
            {
                bool pass = true;
                //verification des ecritures de chaque champs
                foreach (var item in current.Colonnes)
                {
                    if (string.IsNullOrEmpty(item.Requette))
                    {
                        pass = false;
                        break;
                    }
                }
                if (pass)
                {
                    current.Cle = Convert.ToInt32(cle_tb.Text);
                    current.Numero = Convert.ToInt32(num_tb.Text);
                    current.Condition = ligneCondi_tb.Text;
                    //confirmer la modification
                    if (servEcriture.Modifier(current, (Evenement)events_liste.SelectedItem) == 0)
                    {
                        MessageBox.Show("L'écriture est bien modifiée");
                    }
                    else
                    {
                        MessageBox.Show("Il y a une erreur dans la modfication");
                    }
                }
                else
                    MessageBox.Show("Verifier vos informations, les requettes des champs ne doivent pas etre vides");

            }
            else//Ajout
            {
                bool pass = true;
                //verification des ecritures de chaque champs
                foreach (var item in current.Colonnes)
                {
                    if (string.IsNullOrEmpty(item.Requette))
                    {
                        pass = false;
                        break;
                    }
                }
                //verification des champs: cle et numero 
                if (string.IsNullOrEmpty(cle_tb.Text) || string.IsNullOrEmpty(num_tb.Text))
                    pass = false;
                if (pass)
                {
                    current.Cle = Convert.ToInt32(cle_tb.Text);
                    current.Numero = Convert.ToInt32(num_tb.Text);
                    current.Condition = ligneCondi_tb.Text;
                    //confirmer l'ajout
                    if (!servEcriture.IsExist(current, (Evenement)events_liste.SelectedItem))
                    {
                        if (servEcriture.Ajouter(current, (Evenement)events_liste.SelectedItem) == 0)
                        {
                            MessageBox.Show("L'écriture est bien ajoutée");
                            new_btn.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Il y a une erreur dans l'ajout");
                        }
                    }
                }
                else
                    MessageBox.Show("Verifier vos informations, il y a des champs sans requette, ou la cle/numero n'ont pas été inserés");

            }
        }
    }
}
