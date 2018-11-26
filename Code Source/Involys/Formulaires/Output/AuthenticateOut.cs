using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;

using Involys.UserControls;
using Involys.Pocos;
using Involys.DataAccess.Connectors;

namespace Involys.Formulaires.Output
{
    public partial class AuthenticateOut : MetroForm
    {
        public AuthenticateOut(MetroStyleManager msm)
        {
            InitializeComponent();
            StyleManager = msm;
            StyleManager.Owner = this;
        }

        private void AuthenticateOut_Load(object sender, EventArgs e)
        {
            //Initialisation
            serverAuth_control.Helper = new ConnectionHelper();
            serverAuth_control.Connector = new MSSQLConnecctor(serverAuth_control.Helper);
            serverAuth_control.ServerDatabases = new List<string>();
            //Affectation des evenements
            serverAuth_control.FinTraitements += new EventHandler(serverAuth_control_FinTraitements);
            dbAuth_control.FinTraitements += new EventHandler(dbAuth_control_FinTraitements);
        }

        void dbAuth_control_FinTraitements(object sender, EventArgs e)
        {
            if (dbAuth_control.IsConnected)
            {
                var frm = new MainOut(this.StyleManager, dbAuth_control.Connector);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Information Incorrects, Verifier Vos Information de Connection");
            }
        }

        void serverAuth_control_FinTraitements(object sender, EventArgs e)
        {
            if (!serverAuth_control.HasDatabases)
                MessageBox.Show("-Le Serveur que vous avez entrer n'existe pas\n-Le Serveur est vide",
                                "Aucune Base De Données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                serverAuth_control.Visible = false;
                dbAuth_control.Databases = serverAuth_control.ServerDatabases;
                dbAuth_control.Connector = serverAuth_control.Connector;
                dbAuth_control.Visible = true;
            }
        }
    }
}
