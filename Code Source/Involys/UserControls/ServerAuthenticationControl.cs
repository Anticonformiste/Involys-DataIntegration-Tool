using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Controls;
using MetroFramework.Components;

using Involys.DataAccess.Connectors;
using Involys.Pocos;
using Involys.Utility;

namespace Involys.UserControls
{
    public partial class ServerAuthenticationControl : BaseUC
    {
        public ServerAuthenticationControl()
        {
            InitializeComponent();
        }

        //Attributes
        private List<string> databases;
        //Properties
        public ConnectionHelper Helper { get; set; }
        public bool HasDatabases { get; set; }
        public List<string> ServerDatabases
        {
            get { return databases; }
            set 
            {
                databases = (value == null) ? new List<string>() : value;
                HasDatabases = (databases.Count == 0) ? false : true;
            }
        }
        //Events
        public event EventHandler FinTraitements;

        //Methodes
        private void join_btn_Click(object sender, EventArgs e)
        {
            var bw = new BackgroundWorker();
            server_tb.Enabled = servers_list.Enabled = join_btn.Enabled = false;
            //vider la liste
            ServerDatabases.Clear();
            //Affecter le helper pour contenir les information de connection
            Helper.Server = server_tb.Text;
            Helper.Username = login_tb.Text;
            Helper.Password = password_tb.Text;
            Connector = DatasUtility.GetConenctorByProvider(servers_list.SelectedItem.ToString());
            Connector.cnxHelper = Helper;
            bw.DoWork += (send, ev) =>
            {
                ev.Result = Connector.GetServerDatabases();
            };

            bw.RunWorkerCompleted += (send, ev) =>
            {
                ServerDatabases = (List<string>)ev.Result;
                getDbProgress.Visible = false;
                server_tb.Enabled = servers_list.Enabled = join_btn.Enabled = true;
                //Affecter l'evenement du fin de traitement
                if (FinTraitements != null)
                    FinTraitements(this, new EventArgs());
            };
            getDbProgress.Visible = true;
            bw.RunWorkerAsync();
        }
    }
}
