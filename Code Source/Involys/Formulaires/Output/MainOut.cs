using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;

using Involys.DataAccess.Connectors;
using Involys.UserControls.Output;
using Involys.UserControls;

namespace Involys.Formulaires.Output
{
    public partial class MainOut : MetroForm
    {
        private DbConnector connector;
        //Les User Controls Utilisés
        private BaseUC user_control;

        public void addToTableLayout(BaseUC uc)
        {
            //Vider le layout
            tableLayoutPanel1.Controls.Clear();

            uc.Connector = this.connector;
            uc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tableLayoutPanel1.Controls.Add(uc, 1, 1);
            uc.Recharger();
        }

        public MainOut(MetroStyleManager msm, DbConnector con)
        {
            InitializeComponent();
            StyleManager = msm;
            StyleManager.Owner = this;
            connector = con;
        }

        private void MainOut_Load(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb.Name = "logo_pb";
            pb.Image = Involys.Properties.Resources.logoApp;
            pb.Size = pb.Image.Size;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(pb, 1, 1);
        }

        private void option1_btn_Click(object sender, EventArgs e)
        {
            user_control = new ConfigDbAmontControl();
            addToTableLayout(user_control);
        }

        private void option2_btn_Click(object sender, EventArgs e)
        {
            user_control = new ConfigStructures();
            addToTableLayout(user_control);
        }

        private void option3_btn_Click(object sender, EventArgs e)
        {
            user_control = new ConfigConditions();
            addToTableLayout(user_control);
        }

        private void option4_btn_Click(object sender, EventArgs e)
        {
            user_control = new ConfigEcritures();
            addToTableLayout(user_control);
        }

        private void option5_btn_Click(object sender, EventArgs e)
        {
            user_control = new ConfigMapping();
            addToTableLayout(user_control);
        }

        private void option6_btn_Click(object sender, EventArgs e)
        {
            user_control = new ConfigExportation();
            addToTableLayout(user_control);
        }

        private void MainOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
