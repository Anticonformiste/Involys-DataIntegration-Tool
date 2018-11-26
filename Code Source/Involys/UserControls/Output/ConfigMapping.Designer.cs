namespace Involys.UserControls.Output
{
    partial class ConfigMapping
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.systemes_liste = new MetroFramework.Controls.MetroComboBox();
            this.evenets_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.champs_tree = new System.Windows.Forms.TreeView();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.valider_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.views_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.generer_btn = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.conditions_liste = new MetroFramework.Controls.MetroComboBox();
            this.input_grid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.nameSp_tb = new MetroFramework.Controls.MetroTextBox();
            this.reset_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.input_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Systéme Amont :";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-3, 24);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(448, 10);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(448, 25);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Configuration Du Mapping";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(58, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Evenement :";
            // 
            // systemes_liste
            // 
            this.systemes_liste.FormattingEnabled = true;
            this.systemes_liste.ItemHeight = 23;
            this.systemes_liste.Location = new System.Drawing.Point(142, 37);
            this.systemes_liste.Name = "systemes_liste";
            this.systemes_liste.Size = new System.Drawing.Size(198, 29);
            this.systemes_liste.TabIndex = 20;
            this.metroToolTip1.SetToolTip(this.systemes_liste, "le systeme amont(source) des données");
            this.systemes_liste.UseSelectable = true;
            this.systemes_liste.SelectedIndexChanged += new System.EventHandler(this.systemes_liste_SelectedIndexChanged);
            // 
            // evenets_liste
            // 
            this.evenets_liste.FormattingEnabled = true;
            this.evenets_liste.ItemHeight = 23;
            this.evenets_liste.Location = new System.Drawing.Point(142, 72);
            this.evenets_liste.Name = "evenets_liste";
            this.evenets_liste.Size = new System.Drawing.Size(198, 29);
            this.evenets_liste.TabIndex = 21;
            this.metroToolTip1.SetToolTip(this.evenets_liste, "l\'evenement de l\'interfaçage(Table de sortie)");
            this.evenets_liste.UseSelectable = true;
            this.evenets_liste.SelectedIndexChanged += new System.EventHandler(this.evenets_liste_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Champs Evenement";
            // 
            // champs_tree
            // 
            this.champs_tree.Location = new System.Drawing.Point(3, 208);
            this.champs_tree.Name = "champs_tree";
            this.champs_tree.Size = new System.Drawing.Size(159, 201);
            this.champs_tree.TabIndex = 24;
            this.metroToolTip1.SetToolTip(this.champs_tree, "les champs de la structure de l\'evenement");
            this.champs_tree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.champs_tree_ItemDrag);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 176);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(448, 10);
            this.bunifuSeparator2.TabIndex = 25;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // valider_btn
            // 
            this.valider_btn.Image = null;
            this.valider_btn.Location = new System.Drawing.Point(188, 386);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(240, 23);
            this.valider_btn.TabIndex = 29;
            this.valider_btn.Text = "Valider La Procedure Stockée";
            this.metroToolTip1.SetToolTip(this.valider_btn, "validation de la SP et sa creation dans la BD du systéme amont");
            this.valider_btn.UseSelectable = true;
            this.valider_btn.UseVisualStyleBackColor = true;
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // views_liste
            // 
            this.views_liste.FormattingEnabled = true;
            this.views_liste.ItemHeight = 23;
            this.views_liste.Location = new System.Drawing.Point(142, 107);
            this.views_liste.Name = "views_liste";
            this.views_liste.Size = new System.Drawing.Size(198, 29);
            this.views_liste.TabIndex = 31;
            this.metroToolTip1.SetToolTip(this.views_liste, "la vue an relation avec l\'evenement choisie(dans le Systeme amont)");
            this.views_liste.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(4, 112);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(135, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Vue De L\'evenement :";
            // 
            // generer_btn
            // 
            this.generer_btn.Location = new System.Drawing.Point(188, 360);
            this.generer_btn.Name = "generer_btn";
            this.generer_btn.Size = new System.Drawing.Size(240, 23);
            this.generer_btn.TabIndex = 32;
            this.generer_btn.Text = "Génerer La Procedure Stockée";
            this.metroToolTip1.SetToolTip(this.generer_btn, "géneration de la SP, et l\'afficher sans la créer au niveau du serveur");
            this.generer_btn.UseSelectable = true;
            this.generer_btn.Click += new System.EventHandler(this.generer_btn_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // conditions_liste
            // 
            this.conditions_liste.FormattingEnabled = true;
            this.conditions_liste.ItemHeight = 23;
            this.conditions_liste.Location = new System.Drawing.Point(142, 143);
            this.conditions_liste.Name = "conditions_liste";
            this.conditions_liste.Size = new System.Drawing.Size(198, 29);
            this.conditions_liste.TabIndex = 39;
            this.metroToolTip1.SetToolTip(this.conditions_liste, "la vue an relation avec l\'evenement choisie(dans le Systeme amont)");
            this.conditions_liste.UseSelectable = true;
            // 
            // input_grid
            // 
            this.input_grid.AllowDrop = true;
            this.input_grid.AllowUserToAddRows = false;
            this.input_grid.AllowUserToResizeRows = false;
            this.input_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.input_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4});
            this.input_grid.Location = new System.Drawing.Point(167, 208);
            this.input_grid.Name = "input_grid";
            this.input_grid.Size = new System.Drawing.Size(277, 113);
            this.input_grid.TabIndex = 28;
            this.metroToolTip1.SetToolTip(this.input_grid, "les parametre d\'entréé de l\'interfaçage(where)");
            this.input_grid.DragDrop += new System.Windows.Forms.DragEventHandler(this.input_grid_DragDrop);
            this.input_grid.DragEnter += new System.Windows.Forms.DragEventHandler(this.input_grid_DragEnter);
            this.input_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_grid_KeyDown);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Champs";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(65, 148);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(78, 19);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "Conditions :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(188, 327);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 40;
            this.metroLabel5.Text = "Nom SP: ";
            // 
            // nameSp_tb
            // 
            // 
            // 
            // 
            this.nameSp_tb.CustomButton.Image = null;
            this.nameSp_tb.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.nameSp_tb.CustomButton.Name = "";
            this.nameSp_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameSp_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameSp_tb.CustomButton.TabIndex = 1;
            this.nameSp_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameSp_tb.CustomButton.UseSelectable = true;
            this.nameSp_tb.CustomButton.Visible = false;
            this.nameSp_tb.Lines = new string[0];
            this.nameSp_tb.Location = new System.Drawing.Point(248, 327);
            this.nameSp_tb.MaxLength = 32767;
            this.nameSp_tb.Name = "nameSp_tb";
            this.nameSp_tb.PasswordChar = '\0';
            this.nameSp_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameSp_tb.SelectedText = "";
            this.nameSp_tb.SelectionLength = 0;
            this.nameSp_tb.SelectionStart = 0;
            this.nameSp_tb.ShortcutsEnabled = true;
            this.nameSp_tb.Size = new System.Drawing.Size(180, 23);
            this.nameSp_tb.TabIndex = 41;
            this.nameSp_tb.UseSelectable = true;
            this.nameSp_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameSp_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // reset_btn
            // 
            this.reset_btn.Image = null;
            this.reset_btn.Location = new System.Drawing.Point(346, 40);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(98, 130);
            this.reset_btn.TabIndex = 42;
            this.reset_btn.Text = "Reinitialiser\r\nLa\r\nDemande";
            this.reset_btn.UseSelectable = true;
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(167, 187);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(280, 19);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "Paramétres d\'Entrée";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.nameSp_tb);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.conditions_liste);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.generer_btn);
            this.Controls.Add(this.views_liste);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.input_grid);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.champs_tree);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.evenets_liste);
            this.Controls.Add(this.systemes_liste);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ConfigMapping";
            this.Size = new System.Drawing.Size(448, 415);
            ((System.ComponentModel.ISupportInitialize)(this.input_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox systemes_liste;
        private MetroFramework.Controls.MetroComboBox evenets_liste;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TreeView champs_tree;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton valider_btn;
        private MetroFramework.Controls.MetroComboBox views_liste;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton generer_btn;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroComboBox conditions_liste;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox nameSp_tb;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton reset_btn;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView input_grid;
    }
}
