using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Controls;

using Involys.DataAccess.Connectors;
using Involys.DataAccess.Services;
using Involys.Pocos;

namespace Involys.UserControls
{
    public partial class DBAuthenticationControl : BaseUC
    {
        public DBAuthenticationControl()
        {
            InitializeComponent();
        }

        //Atributes
        private List<string> databases;
        //properties
        public List<string> Databases
        {
            get { return databases; }
            set
            {
                databases = (value == null) ? new List<string>() : value;
            }
        }

        public bool IsConnected { get; set; }
        //Events
        public event EventHandler FinTraitements;

        private void go_btn_Click(object sender, EventArgs e)
        {
            var bw = new BackgroundWorker();
            fieldsPanel.Enabled = false;
            //la DB Intermediaire selectionnée
            Connector.cnxHelper.Database = databases_list.SelectedItem.ToString();
            
            bw.DoWork += (send, ev) =>
            {
                //Authentifier
                var servAuth = new ServiceAuthentification();
                servAuth.Connector = Connector;
                ev.Result = servAuth.Authenticate(username_tb.Text, password_tb.Text);
            };

            bw.RunWorkerCompleted += (send, ev) =>
            {
                fieldsPanel.Enabled = true;
                loginProgress.Visible = false;
                IsConnected = ((int)ev.Result == 0)?true:false;
                //Declancher l'evenement qui indique la fin d'operation
                if (FinTraitements != null)
                    FinTraitements(this, new EventArgs());
            };

            loginProgress.Visible = true;
            bw.RunWorkerAsync();
        }

        private void DataBaseAuthentication_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Databases)
                {
                    databases_list.Items.Add(item);
                }
            }
            catch (Exception)
            { }
        }

    }
}
