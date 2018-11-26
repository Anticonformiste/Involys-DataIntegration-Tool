namespace Involys.UserControls
{
    partial class ServerAuthenticationControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.password_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.login_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.getDbProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.join_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.server_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.servers_list = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(284, 25);
            this.title_lbl.TabIndex = 54;
            this.title_lbl.Text = "Authentification To Server";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_lbl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.title_lbl.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.password_tb);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.login_tb);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.getDbProgress);
            this.metroPanel1.Controls.Add(this.join_btn);
            this.metroPanel1.Controls.Add(this.server_tb);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.servers_list);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 24);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(258, 249);
            this.metroPanel1.TabIndex = 55;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // password_tb
            // 
            this.password_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.password_tb.CustomButton.Image = null;
            this.password_tb.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.password_tb.CustomButton.Name = "";
            this.password_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_tb.CustomButton.TabIndex = 1;
            this.password_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_tb.CustomButton.UseSelectable = true;
            this.password_tb.CustomButton.Visible = false;
            this.password_tb.Lines = new string[0];
            this.password_tb.Location = new System.Drawing.Point(3, 176);
            this.password_tb.MaxLength = 24;
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_tb.SelectedText = "";
            this.password_tb.SelectionLength = 0;
            this.password_tb.SelectionStart = 0;
            this.password_tb.ShortcutsEnabled = true;
            this.password_tb.Size = new System.Drawing.Size(252, 23);
            this.password_tb.TabIndex = 3;
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_tb.UseSelectable = true;
            this.password_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.Location = new System.Drawing.Point(3, 154);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(252, 19);
            this.metroLabel7.TabIndex = 74;
            this.metroLabel7.Text = "Password";
            // 
            // login_tb
            // 
            this.login_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.login_tb.CustomButton.Image = null;
            this.login_tb.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.login_tb.CustomButton.Name = "";
            this.login_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_tb.CustomButton.TabIndex = 1;
            this.login_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_tb.CustomButton.UseSelectable = true;
            this.login_tb.CustomButton.Visible = false;
            this.login_tb.Lines = new string[0];
            this.login_tb.Location = new System.Drawing.Point(3, 128);
            this.login_tb.MaxLength = 32767;
            this.login_tb.Name = "login_tb";
            this.login_tb.PasswordChar = '\0';
            this.login_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_tb.SelectedText = "";
            this.login_tb.SelectionLength = 0;
            this.login_tb.SelectionStart = 0;
            this.login_tb.ShortcutsEnabled = true;
            this.login_tb.Size = new System.Drawing.Size(252, 23);
            this.login_tb.TabIndex = 2;
            this.login_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_tb.UseSelectable = true;
            this.login_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.Location = new System.Drawing.Point(3, 107);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(252, 19);
            this.metroLabel8.TabIndex = 72;
            this.metroLabel8.Text = "Login";
            // 
            // getDbProgress
            // 
            this.getDbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getDbProgress.Location = new System.Drawing.Point(5, 211);
            this.getDbProgress.Maximum = 100;
            this.getDbProgress.Name = "getDbProgress";
            this.getDbProgress.Size = new System.Drawing.Size(42, 32);
            this.getDbProgress.Speed = 2F;
            this.getDbProgress.TabIndex = 71;
            this.getDbProgress.UseSelectable = true;
            this.getDbProgress.Value = 20;
            this.getDbProgress.Visible = false;
            // 
            // join_btn
            // 
            this.join_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.join_btn.Image = null;
            this.join_btn.Location = new System.Drawing.Point(141, 207);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(113, 23);
            this.join_btn.TabIndex = 4;
            this.join_btn.Text = "Valider";
            this.join_btn.UseSelectable = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // server_tb
            // 
            this.server_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.server_tb.CustomButton.Image = null;
            this.server_tb.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.server_tb.CustomButton.Name = "";
            this.server_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.server_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.server_tb.CustomButton.TabIndex = 1;
            this.server_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.server_tb.CustomButton.UseSelectable = true;
            this.server_tb.CustomButton.Visible = false;
            this.server_tb.Lines = new string[0];
            this.server_tb.Location = new System.Drawing.Point(3, 79);
            this.server_tb.MaxLength = 32767;
            this.server_tb.Name = "server_tb";
            this.server_tb.PasswordChar = '\0';
            this.server_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.server_tb.SelectedText = "";
            this.server_tb.SelectionLength = 0;
            this.server_tb.SelectionStart = 0;
            this.server_tb.ShortcutsEnabled = true;
            this.server_tb.Size = new System.Drawing.Size(252, 23);
            this.server_tb.TabIndex = 1;
            this.server_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.server_tb.UseSelectable = true;
            this.server_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.server_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 57);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(252, 19);
            this.metroLabel6.TabIndex = 68;
            this.metroLabel6.Text = "Serveur";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // servers_list
            // 
            this.servers_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.servers_list.FormattingEnabled = true;
            this.servers_list.ItemHeight = 23;
            this.servers_list.Items.AddRange(new object[] {
            "MSSQLSERVER",
            "ORACLE"});
            this.servers_list.Location = new System.Drawing.Point(3, 25);
            this.servers_list.Name = "servers_list";
            this.servers_list.Size = new System.Drawing.Size(252, 29);
            this.servers_list.TabIndex = 0;
            this.servers_list.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(252, 19);
            this.metroLabel1.TabIndex = 66;
            this.metroLabel1.Text = "Type De Serveur";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerAuthenticationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.title_lbl);
            this.Margin = new System.Windows.Forms.Padding(30);
            this.Name = "ServerAuthenticationControl";
            this.Size = new System.Drawing.Size(284, 278);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel title_lbl;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox password_tb;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox login_tb;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroProgressSpinner getDbProgress;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton join_btn;
        private MetroFramework.Controls.MetroTextBox server_tb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox servers_list;
        private MetroFramework.Controls.MetroLabel metroLabel1;

    }
}
