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

using Involys.Formulaires.Output;
//using Involys.Formulaires.Input;

namespace Involys
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = msm;
        }

        private void output_btn_Click(object sender, EventArgs e)
        {
            new AuthenticateOut(StyleManager).ShowDialog();
        }
    }
}
