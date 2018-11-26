namespace Involys.UserControls.Output
{
    partial class ConfigDbAmontControl
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
            this.metroTip = new MetroFramework.Components.MetroToolTip();
            this.new_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.libelle_liste = new MetroFramework.Controls.MetroComboBox();
            this.del_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.edit_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.add_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.title_lbl = new MetroFramework.Controls.MetroLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.server_tb = new MetroFramework.Controls.MetroTextBox();
            this.typeserv_list = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.libelle_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pass_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.login_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.db_tb = new MetroFramework.Controls.MetroTextBox();
            this.fields_pnl = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.fields_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTip
            // 
            this.metroTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTip.StyleManager = null;
            this.metroTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // new_btn
            // 
            this.new_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.new_btn.Image = null;
            this.new_btn.Location = new System.Drawing.Point(185, 2);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(105, 29);
            this.new_btn.TabIndex = 126;
            this.new_btn.Text = "Nouveau";
            this.metroTip.SetToolTip(this.new_btn, "Créer une nouvelle  connection systéme amont");
            this.new_btn.UseSelectable = true;
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // libelle_liste
            // 
            this.libelle_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.libelle_liste.FormattingEnabled = true;
            this.libelle_liste.ItemHeight = 23;
            this.libelle_liste.Location = new System.Drawing.Point(2, 2);
            this.libelle_liste.Name = "libelle_liste";
            this.libelle_liste.Size = new System.Drawing.Size(177, 29);
            this.libelle_liste.TabIndex = 127;
            this.metroTip.SetToolTip(this.libelle_liste, "Choisir un systéme pour manipuler ses informations");
            this.libelle_liste.UseSelectable = true;
            this.libelle_liste.SelectedIndexChanged += new System.EventHandler(this.libelle_liste_SelectedIndexChanged);
            // 
            // del_btn
            // 
            this.del_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.del_btn.Image = null;
            this.del_btn.Location = new System.Drawing.Point(186, 6);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(105, 23);
            this.del_btn.TabIndex = 120;
            this.del_btn.Text = "Supprimer";
            this.metroTip.SetToolTip(this.del_btn, "Supprimer l\'élement courant");
            this.del_btn.UseSelectable = true;
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edit_btn.Image = null;
            this.edit_btn.Location = new System.Drawing.Point(187, 4);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(105, 23);
            this.edit_btn.TabIndex = 119;
            this.edit_btn.Text = "Modifier";
            this.metroTip.SetToolTip(this.edit_btn, "Appliquer les modifications l\'element courant");
            this.edit_btn.UseSelectable = true;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.add_btn.Enabled = false;
            this.add_btn.Image = null;
            this.add_btn.Location = new System.Drawing.Point(187, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(105, 23);
            this.add_btn.TabIndex = 122;
            this.add_btn.Text = "Ajouter";
            this.metroTip.SetToolTip(this.add_btn, "Clicker sur nouveau avant d\'ajouter");
            this.add_btn.UseSelectable = true;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.title_lbl.Location = new System.Drawing.Point(0, 2);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(461, 25);
            this.title_lbl.TabIndex = 81;
            this.title_lbl.Text = "Configuration Du BD Sytémes Amonts";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_lbl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.title_lbl.UseStyleColors = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 27);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(461, 10);
            this.bunifuSeparator1.TabIndex = 82;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(4, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 25);
            this.metroLabel1.TabIndex = 112;
            this.metroLabel1.Text = "Type Serveur";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(4, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 25);
            this.metroLabel2.TabIndex = 113;
            this.metroLabel2.Text = "Serveur";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(4, 156);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(145, 25);
            this.metroLabel3.TabIndex = 114;
            this.metroLabel3.Text = "Base De Données";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(4, 191);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 25);
            this.metroLabel4.TabIndex = 115;
            this.metroLabel4.Text = "Login";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(4, 225);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 25);
            this.metroLabel5.TabIndex = 116;
            this.metroLabel5.Text = "Password";
            // 
            // server_tb
            // 
            this.server_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.server_tb.CustomButton.Image = null;
            this.server_tb.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.server_tb.CustomButton.Name = "";
            this.server_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.server_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.server_tb.CustomButton.TabIndex = 1;
            this.server_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.server_tb.CustomButton.UseSelectable = true;
            this.server_tb.CustomButton.Visible = false;
            this.server_tb.Lines = new string[0];
            this.server_tb.Location = new System.Drawing.Point(152, 122);
            this.server_tb.MaxLength = 32767;
            this.server_tb.Name = "server_tb";
            this.server_tb.PasswordChar = '\0';
            this.server_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.server_tb.SelectedText = "";
            this.server_tb.SelectionLength = 0;
            this.server_tb.SelectionStart = 0;
            this.server_tb.ShortcutsEnabled = true;
            this.server_tb.Size = new System.Drawing.Size(179, 23);
            this.server_tb.TabIndex = 117;
            this.server_tb.UseSelectable = true;
            this.server_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.server_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // typeserv_list
            // 
            this.typeserv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeserv_list.FormattingEnabled = true;
            this.typeserv_list.ItemHeight = 23;
            this.typeserv_list.Items.AddRange(new object[] {
            "MSSQLSERVER",
            "ORACLE"});
            this.typeserv_list.Location = new System.Drawing.Point(152, 82);
            this.typeserv_list.Name = "typeserv_list";
            this.typeserv_list.Size = new System.Drawing.Size(179, 29);
            this.typeserv_list.TabIndex = 120;
            this.typeserv_list.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(4, 48);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 25);
            this.metroLabel7.TabIndex = 122;
            this.metroLabel7.Text = "Libelle";
            // 
            // libelle_tb
            // 
            this.libelle_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.libelle_tb.CustomButton.Image = null;
            this.libelle_tb.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.libelle_tb.CustomButton.Name = "";
            this.libelle_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.libelle_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.libelle_tb.CustomButton.TabIndex = 1;
            this.libelle_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.libelle_tb.CustomButton.UseSelectable = true;
            this.libelle_tb.CustomButton.Visible = false;
            this.libelle_tb.Lines = new string[0];
            this.libelle_tb.Location = new System.Drawing.Point(152, 50);
            this.libelle_tb.MaxLength = 32767;
            this.libelle_tb.Name = "libelle_tb";
            this.libelle_tb.PasswordChar = '\0';
            this.libelle_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.libelle_tb.SelectedText = "";
            this.libelle_tb.SelectionLength = 0;
            this.libelle_tb.SelectionStart = 0;
            this.libelle_tb.ShortcutsEnabled = true;
            this.libelle_tb.Size = new System.Drawing.Size(179, 23);
            this.libelle_tb.TabIndex = 123;
            this.libelle_tb.UseSelectable = true;
            this.libelle_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.libelle_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(3, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(130, 25);
            this.metroLabel6.TabIndex = 124;
            this.metroLabel6.Text = "Systéme Amont";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.libelle_liste);
            this.metroPanel1.Controls.Add(this.new_btn);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(152, 11);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(292, 33);
            this.metroPanel1.TabIndex = 125;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.pass_tb);
            this.metroPanel2.Controls.Add(this.del_btn);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(152, 223);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(292, 34);
            this.metroPanel2.TabIndex = 126;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pass_tb
            // 
            this.pass_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.pass_tb.CustomButton.Image = null;
            this.pass_tb.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.pass_tb.CustomButton.Name = "";
            this.pass_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pass_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass_tb.CustomButton.TabIndex = 1;
            this.pass_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass_tb.CustomButton.UseSelectable = true;
            this.pass_tb.CustomButton.Visible = false;
            this.pass_tb.Lines = new string[0];
            this.pass_tb.Location = new System.Drawing.Point(1, 6);
            this.pass_tb.MaxLength = 32767;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.PasswordChar = '\0';
            this.pass_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass_tb.SelectedText = "";
            this.pass_tb.SelectionLength = 0;
            this.pass_tb.SelectionStart = 0;
            this.pass_tb.ShortcutsEnabled = true;
            this.pass_tb.Size = new System.Drawing.Size(179, 23);
            this.pass_tb.TabIndex = 121;
            this.pass_tb.UseSelectable = true;
            this.pass_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.edit_btn);
            this.metroPanel3.Controls.Add(this.login_tb);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(152, 187);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(292, 30);
            this.metroPanel3.TabIndex = 127;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // login_tb
            // 
            this.login_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.login_tb.CustomButton.Image = null;
            this.login_tb.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.login_tb.CustomButton.Name = "";
            this.login_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_tb.CustomButton.TabIndex = 1;
            this.login_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_tb.CustomButton.UseSelectable = true;
            this.login_tb.CustomButton.Visible = false;
            this.login_tb.Lines = new string[0];
            this.login_tb.Location = new System.Drawing.Point(0, 4);
            this.login_tb.MaxLength = 32767;
            this.login_tb.Name = "login_tb";
            this.login_tb.PasswordChar = '\0';
            this.login_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_tb.SelectedText = "";
            this.login_tb.SelectionLength = 0;
            this.login_tb.SelectionStart = 0;
            this.login_tb.ShortcutsEnabled = true;
            this.login_tb.Size = new System.Drawing.Size(179, 23);
            this.login_tb.TabIndex = 120;
            this.login_tb.UseSelectable = true;
            this.login_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel4.Controls.Add(this.db_tb);
            this.metroPanel4.Controls.Add(this.add_btn);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(152, 152);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(292, 29);
            this.metroPanel4.TabIndex = 128;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // db_tb
            // 
            this.db_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.db_tb.CustomButton.Image = null;
            this.db_tb.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.db_tb.CustomButton.Name = "";
            this.db_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.db_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.db_tb.CustomButton.TabIndex = 1;
            this.db_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.db_tb.CustomButton.UseSelectable = true;
            this.db_tb.CustomButton.Visible = false;
            this.db_tb.Lines = new string[0];
            this.db_tb.Location = new System.Drawing.Point(0, 3);
            this.db_tb.MaxLength = 32767;
            this.db_tb.Name = "db_tb";
            this.db_tb.PasswordChar = '\0';
            this.db_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.db_tb.SelectedText = "";
            this.db_tb.SelectionLength = 0;
            this.db_tb.SelectionStart = 0;
            this.db_tb.ShortcutsEnabled = true;
            this.db_tb.Size = new System.Drawing.Size(179, 23);
            this.db_tb.TabIndex = 123;
            this.db_tb.UseSelectable = true;
            this.db_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.db_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fields_pnl
            // 
            this.fields_pnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fields_pnl.Controls.Add(this.metroPanel4);
            this.fields_pnl.Controls.Add(this.metroPanel3);
            this.fields_pnl.Controls.Add(this.metroPanel2);
            this.fields_pnl.Controls.Add(this.metroPanel1);
            this.fields_pnl.Controls.Add(this.metroLabel6);
            this.fields_pnl.Controls.Add(this.libelle_tb);
            this.fields_pnl.Controls.Add(this.metroLabel7);
            this.fields_pnl.Controls.Add(this.typeserv_list);
            this.fields_pnl.Controls.Add(this.server_tb);
            this.fields_pnl.Controls.Add(this.metroLabel5);
            this.fields_pnl.Controls.Add(this.metroLabel4);
            this.fields_pnl.Controls.Add(this.metroLabel3);
            this.fields_pnl.Controls.Add(this.metroLabel2);
            this.fields_pnl.Controls.Add(this.metroLabel1);
            this.fields_pnl.HorizontalScrollbarBarColor = true;
            this.fields_pnl.HorizontalScrollbarHighlightOnWheel = false;
            this.fields_pnl.HorizontalScrollbarSize = 10;
            this.fields_pnl.Location = new System.Drawing.Point(4, 37);
            this.fields_pnl.Name = "fields_pnl";
            this.fields_pnl.Size = new System.Drawing.Size(449, 260);
            this.fields_pnl.TabIndex = 100;
            this.fields_pnl.VerticalScrollbarBarColor = true;
            this.fields_pnl.VerticalScrollbarHighlightOnWheel = false;
            this.fields_pnl.VerticalScrollbarSize = 10;
            // 
            // ConfigDbAmontControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fields_pnl);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.title_lbl);
            this.Name = "ConfigDbAmontControl";
            this.Size = new System.Drawing.Size(461, 304);
            this.Load += new System.EventHandler(this.ConfigDbAmontControl_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.fields_pnl.ResumeLayout(false);
            this.fields_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroTip;
        private MetroFramework.Controls.MetroLabel title_lbl;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox server_tb;
        private MetroFramework.Controls.MetroComboBox typeserv_list;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox libelle_tb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox libelle_liste;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton new_btn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox pass_tb;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton del_btn;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton edit_btn;
        private MetroFramework.Controls.MetroTextBox login_tb;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTextBox db_tb;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton add_btn;
        private MetroFramework.Controls.MetroPanel fields_pnl;
    }
}
