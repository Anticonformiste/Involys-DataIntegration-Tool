namespace Involys.UserControls.Output
{
    partial class ConfigEcritures
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
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.events_liste = new MetroFramework.Controls.MetroComboBox();
            this.conditions_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.columnsGrid = new System.Windows.Forms.DataGridView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ligneCondi_tb = new MetroFramework.Controls.MetroTextBox();
            this.valider_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.ecritures_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cle_tb = new MetroFramework.Controls.MetroTextBox();
            this.num_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.new_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.tooltip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.columnsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 24);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(529, 10);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(526, 25);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Configuration Des Ecritures";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Evenement";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(262, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Conditions";
            // 
            // events_liste
            // 
            this.events_liste.FormattingEnabled = true;
            this.events_liste.ItemHeight = 23;
            this.events_liste.Location = new System.Drawing.Point(76, 37);
            this.events_liste.Name = "events_liste";
            this.events_liste.Size = new System.Drawing.Size(177, 29);
            this.events_liste.TabIndex = 19;
            this.tooltip.SetToolTip(this.events_liste, "la liste des evenements disponibles");
            this.events_liste.UseSelectable = true;
            this.events_liste.SelectedIndexChanged += new System.EventHandler(this.events_liste_SelectedIndexChanged);
            // 
            // conditions_liste
            // 
            this.conditions_liste.FormattingEnabled = true;
            this.conditions_liste.ItemHeight = 23;
            this.conditions_liste.Location = new System.Drawing.Point(336, 37);
            this.conditions_liste.Name = "conditions_liste";
            this.conditions_liste.Size = new System.Drawing.Size(185, 29);
            this.conditions_liste.TabIndex = 20;
            this.tooltip.SetToolTip(this.conditions_liste, "la liste des condition disponible pour l\'evenement choisi");
            this.conditions_liste.UseSelectable = true;
            this.conditions_liste.SelectedIndexChanged += new System.EventHandler(this.conditions_liste_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 115);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Colonnes :";
            // 
            // columnsGrid
            // 
            this.columnsGrid.AllowUserToAddRows = false;
            this.columnsGrid.AllowUserToDeleteRows = false;
            this.columnsGrid.AllowUserToResizeRows = false;
            this.columnsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.columnsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnsGrid.Location = new System.Drawing.Point(3, 137);
            this.columnsGrid.Name = "columnsGrid";
            this.columnsGrid.Size = new System.Drawing.Size(468, 117);
            this.columnsGrid.TabIndex = 22;
            this.tooltip.SetToolTip(this.columnsGrid, "les colonne des ecritures et leurs requettes");
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 259);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(121, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Conditions Du Ligne";
            // 
            // ligneCondi_tb
            // 
            // 
            // 
            // 
            this.ligneCondi_tb.CustomButton.Image = null;
            this.ligneCondi_tb.CustomButton.Location = new System.Drawing.Point(497, 1);
            this.ligneCondi_tb.CustomButton.Name = "";
            this.ligneCondi_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ligneCondi_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ligneCondi_tb.CustomButton.TabIndex = 1;
            this.ligneCondi_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ligneCondi_tb.CustomButton.UseSelectable = true;
            this.ligneCondi_tb.CustomButton.Visible = false;
            this.ligneCondi_tb.Lines = new string[0];
            this.ligneCondi_tb.Location = new System.Drawing.Point(6, 281);
            this.ligneCondi_tb.MaxLength = 32767;
            this.ligneCondi_tb.Name = "ligneCondi_tb";
            this.ligneCondi_tb.PasswordChar = '\0';
            this.ligneCondi_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ligneCondi_tb.SelectedText = "";
            this.ligneCondi_tb.SelectionLength = 0;
            this.ligneCondi_tb.SelectionStart = 0;
            this.ligneCondi_tb.ShortcutsEnabled = true;
            this.ligneCondi_tb.Size = new System.Drawing.Size(519, 23);
            this.ligneCondi_tb.TabIndex = 24;
            this.tooltip.SetToolTip(this.ligneCondi_tb, "la condition globale de cette ecriture");
            this.ligneCondi_tb.UseSelectable = true;
            this.ligneCondi_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ligneCondi_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // valider_btn
            // 
            this.valider_btn.Image = null;
            this.valider_btn.Location = new System.Drawing.Point(414, 310);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(111, 27);
            this.valider_btn.TabIndex = 25;
            this.valider_btn.Text = "Valider";
            this.tooltip.SetToolTip(this.valider_btn, "Valider l\'ajour ou la modification des ecritures");
            this.valider_btn.UseSelectable = true;
            this.valider_btn.UseVisualStyleBackColor = true;
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // ecritures_liste
            // 
            this.ecritures_liste.FormattingEnabled = true;
            this.ecritures_liste.ItemHeight = 23;
            this.ecritures_liste.Location = new System.Drawing.Point(76, 72);
            this.ecritures_liste.Name = "ecritures_liste";
            this.ecritures_liste.Size = new System.Drawing.Size(177, 29);
            this.ecritures_liste.TabIndex = 27;
            this.tooltip.SetToolTip(this.ecritures_liste, "la liste des ecritures de la condition selectionnée");
            this.ecritures_liste.UseSelectable = true;
            this.ecritures_liste.SelectedIndexChanged += new System.EventHandler(this.ecritures_liste_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 76);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Ecriture N°";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(261, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Clé :";
            // 
            // cle_tb
            // 
            // 
            // 
            // 
            this.cle_tb.CustomButton.Image = null;
            this.cle_tb.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.cle_tb.CustomButton.Name = "";
            this.cle_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cle_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cle_tb.CustomButton.TabIndex = 1;
            this.cle_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cle_tb.CustomButton.UseSelectable = true;
            this.cle_tb.CustomButton.Visible = false;
            this.cle_tb.Lines = new string[0];
            this.cle_tb.Location = new System.Drawing.Point(295, 78);
            this.cle_tb.MaxLength = 32767;
            this.cle_tb.Name = "cle_tb";
            this.cle_tb.PasswordChar = '\0';
            this.cle_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cle_tb.SelectedText = "";
            this.cle_tb.SelectionLength = 0;
            this.cle_tb.SelectionStart = 0;
            this.cle_tb.ShortcutsEnabled = true;
            this.cle_tb.Size = new System.Drawing.Size(80, 23);
            this.cle_tb.TabIndex = 29;
            this.tooltip.SetToolTip(this.cle_tb, "la clé de l\'ecriture");
            this.cle_tb.UseSelectable = true;
            this.cle_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cle_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // num_tb
            // 
            // 
            // 
            // 
            this.num_tb.CustomButton.Image = null;
            this.num_tb.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.num_tb.CustomButton.Name = "";
            this.num_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.num_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.num_tb.CustomButton.TabIndex = 1;
            this.num_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.num_tb.CustomButton.UseSelectable = true;
            this.num_tb.CustomButton.Visible = false;
            this.num_tb.Lines = new string[0];
            this.num_tb.Location = new System.Drawing.Point(441, 78);
            this.num_tb.MaxLength = 32767;
            this.num_tb.Name = "num_tb";
            this.num_tb.PasswordChar = '\0';
            this.num_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.num_tb.SelectedText = "";
            this.num_tb.SelectionLength = 0;
            this.num_tb.SelectionStart = 0;
            this.num_tb.ShortcutsEnabled = true;
            this.num_tb.Size = new System.Drawing.Size(80, 23);
            this.num_tb.TabIndex = 31;
            this.tooltip.SetToolTip(this.num_tb, "le numéro de l\'ecriture");
            this.num_tb.UseSelectable = true;
            this.num_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.num_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(377, 78);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(65, 19);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Numero :";
            // 
            // new_btn
            // 
            this.new_btn.Image = null;
            this.new_btn.Location = new System.Drawing.Point(475, 137);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(50, 117);
            this.new_btn.TabIndex = 32;
            this.new_btn.Text = "N\r\no\r\nu\r\nv\r\ne\r\na\r\nu";
            this.tooltip.SetToolTip(this.new_btn, "Créer une novelle ecriture");
            this.new_btn.UseSelectable = true;
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // tooltip
            // 
            this.tooltip.Style = MetroFramework.MetroColorStyle.Blue;
            this.tooltip.StyleManager = null;
            this.tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ConfigEcritures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cle_tb);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.ecritures_liste);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.ligneCondi_tb);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.columnsGrid);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.conditions_liste);
            this.Controls.Add(this.events_liste);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ConfigEcritures";
            this.Size = new System.Drawing.Size(529, 341);
            ((System.ComponentModel.ISupportInitialize)(this.columnsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox events_liste;
        private MetroFramework.Controls.MetroComboBox conditions_liste;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridView columnsGrid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox ligneCondi_tb;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton valider_btn;
        private MetroFramework.Controls.MetroComboBox ecritures_liste;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox cle_tb;
        private MetroFramework.Controls.MetroTextBox num_tb;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton new_btn;
        private MetroFramework.Components.MetroToolTip tooltip;
    }
}
