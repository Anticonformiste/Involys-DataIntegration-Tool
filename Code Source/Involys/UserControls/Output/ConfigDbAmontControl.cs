using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;

using Involys.DataAccess.Connectors;
using Involys.DataAccess.Services;
using Involys.Pocos;

namespace Involys.UserControls.Output
{
    public partial class ConfigDbAmontControl : BaseUC
    {
        private ServiceConnexionsSystemes servConnexionSystem;

        public ConfigDbAmontControl()
        {
            InitializeComponent();
            servConnexionSystem = new ServiceConnexionsSystemes();
            libelle_liste.SelectedIndexChanged -= libelle_liste_SelectedIndexChanged;
        }

        public override void Recharger()
        {
            servConnexionSystem.Connector = this.Connector;
            //Remplir la liste des libélles s'il y a des connections
            var liste = servConnexionSystem.GetAll();
            if (liste != null)
            {
                if (liste.Count > 0)
                {
                    libelle_liste.DataSource = liste;
                    libelle_liste.DisplayMember = "Libelle";
                    libelle_liste.ValueMember = "Code";
                    //Attacher l'event
                    libelle_liste.SelectedIndexChanged += libelle_liste_SelectedIndexChanged;
                    libelle_liste.SelectedIndex = 0;
                    return; 
                }
            }
            MessageBox.Show("Il Existe Aucune Connection Au Systéme Amont,Veillez les créer");
            return;
        }

        private void ConfigDbAmontControl_Load(object sender, EventArgs e)
        {
        }

        private void libelle_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libelle_liste.SelectedValue != null)
            {
                int code = Convert.ToInt32(libelle_liste.SelectedValue);
                var obj = servConnexionSystem.GetById(code);
                libelle_tb.Text = obj.Libelle;
                server_tb.Text = obj.CnxHelper.Server;
                typeserv_list.Text = obj.ServerType;
                db_tb.Text = obj.CnxHelper.Database;
                login_tb.Text = obj.CnxHelper.Username;
                pass_tb.Text = obj.CnxHelper.Password;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (typeserv_list.SelectedIndex!=-1 && libelle_liste.SelectedIndex!=-1)
            {
                var obj = new ConnexionSysteme();
                obj.Code = Convert.ToInt32(libelle_liste.SelectedValue);
                obj.Libelle = libelle_tb.Text;
                obj.ServerType = typeserv_list.SelectedItem.ToString();
                obj.CnxHelper.Database = db_tb.Text;
                obj.CnxHelper.Server = server_tb.Text;
                obj.CnxHelper.Username = login_tb.Text;
                obj.CnxHelper.Password = pass_tb.Text;
                //Update
                if (servConnexionSystem.Modifier(obj) == 0)
                {
                    MessageBox.Show("Modification Terminée");
                    Recharger();
                }
                else
                    MessageBox.Show("Une erreur est survenu lors de la modification!\n-Verifier Les champs"); 
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (libelle_liste.SelectedIndex != -1)
            {
                //Delete
                if (servConnexionSystem.Supprimer(Convert.ToInt32(libelle_liste.SelectedValue)) == 0)
                {
                    MessageBox.Show("La suppression est terminée avec succés");
                    Recharger();
                }
                else
                    MessageBox.Show("Une Erreur est survenue lors la supression!\n-Verifier La selection"); 
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            if (!add_btn.Enabled)//Un ajout
            {
                new_btn.Text = "Annuler";
                metroTip.SetToolTip(new_btn,"Annuler l'ajout de cet enregistrement");
                add_btn.Enabled = true;
                libelle_liste.Enabled = false;
                //clear les champs
                Action<Control.ControlCollection> func = null;
                func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };
                func(Controls);
            }
            else//Annulation
            {
                metroTip.SetToolTip(new_btn, "Créer une nouvelle  connection systéme amont");
                new_btn.Text = "Nouveau";
                add_btn.Enabled = false;
                libelle_liste.Enabled = true;
                Recharger();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (typeserv_list.SelectedIndex != -1)
            {
                var obj = new ConnexionSysteme();
                obj.Code = Convert.ToInt32(libelle_liste.SelectedValue);
                obj.Libelle = libelle_tb.Text;
                obj.ServerType = typeserv_list.SelectedItem.ToString();
                obj.CnxHelper.Database = db_tb.Text;
                obj.CnxHelper.Server = server_tb.Text;
                obj.CnxHelper.Username = login_tb.Text;
                obj.CnxHelper.Password = pass_tb.Text;
                //Add
                if (servConnexionSystem.Ajouter(obj) == 0)
                {
                    MessageBox.Show("Ajout Terminé");
                    new_btn.PerformClick();
                }
                else
                    MessageBox.Show("Une erreur est survenu lors de l'ajout!\n-Verifier Les champs"); 
            }
        }
    }
}
