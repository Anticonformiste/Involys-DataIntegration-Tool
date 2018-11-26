namespace Involys.UserControls.Output
{
    partial class ConfigStructures
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
            this.sysAmont_liste = new MetroFramework.Controls.MetroComboBox();
            this.evenements_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.file_tb = new MetroFramework.Controls.MetroTextBox();
            this.browse_btn = new MetroFramework.Controls.MetroButton();
            this.loadfile_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.structures_Grid = new System.Windows.Forms.DataGridView();
            this.submit_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.fields_panel = new MetroFramework.Controls.MetroPanel();
            this.edit_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.del_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.add_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.modifyField_grid = new System.Windows.Forms.DataGridView();
            this.loadProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.structures_Grid)).BeginInit();
            this.fields_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifyField_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(830, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Configuration Des Strucutres Par Evenement";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 25);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(829, 10);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "BD Systéme Amont :";
            // 
            // sysAmont_liste
            // 
            this.sysAmont_liste.FormattingEnabled = true;
            this.sysAmont_liste.ItemHeight = 23;
            this.sysAmont_liste.Location = new System.Drawing.Point(138, 43);
            this.sysAmont_liste.Name = "sysAmont_liste";
            this.sysAmont_liste.Size = new System.Drawing.Size(203, 29);
            this.sysAmont_liste.TabIndex = 3;
            this.sysAmont_liste.UseSelectable = true;
            this.sysAmont_liste.SelectedIndexChanged += new System.EventHandler(this.sysAmont_liste_SelectedIndexChanged);
            // 
            // evenements_liste
            // 
            this.evenements_liste.FormattingEnabled = true;
            this.evenements_liste.ItemHeight = 23;
            this.evenements_liste.Location = new System.Drawing.Point(138, 80);
            this.evenements_liste.Name = "evenements_liste";
            this.evenements_liste.Size = new System.Drawing.Size(203, 29);
            this.evenements_liste.TabIndex = 5;
            this.evenements_liste.UseSelectable = true;
            this.evenements_liste.SelectedIndexChanged += new System.EventHandler(this.evenements_liste_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Evenement :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(347, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(151, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Fichier De Parametrage:";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 112);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(830, 10);
            this.bunifuSeparator2.TabIndex = 7;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // file_tb
            // 
            // 
            // 
            // 
            this.file_tb.CustomButton.Image = null;
            this.file_tb.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.file_tb.CustomButton.Name = "";
            this.file_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.file_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.file_tb.CustomButton.TabIndex = 1;
            this.file_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.file_tb.CustomButton.UseSelectable = true;
            this.file_tb.CustomButton.Visible = false;
            this.file_tb.Lines = new string[0];
            this.file_tb.Location = new System.Drawing.Point(494, 43);
            this.file_tb.MaxLength = 32767;
            this.file_tb.Name = "file_tb";
            this.file_tb.PasswordChar = '\0';
            this.file_tb.ReadOnly = true;
            this.file_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.file_tb.SelectedText = "";
            this.file_tb.SelectionLength = 0;
            this.file_tb.SelectionStart = 0;
            this.file_tb.ShortcutsEnabled = true;
            this.file_tb.Size = new System.Drawing.Size(333, 23);
            this.file_tb.TabIndex = 8;
            this.file_tb.UseSelectable = true;
            this.file_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.file_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(785, 72);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(42, 23);
            this.browse_btn.TabIndex = 9;
            this.browse_btn.Text = ". . .";
            this.browse_btn.UseSelectable = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // loadfile_btn
            // 
            this.loadfile_btn.Image = null;
            this.loadfile_btn.Location = new System.Drawing.Point(494, 72);
            this.loadfile_btn.Name = "loadfile_btn";
            this.loadfile_btn.Size = new System.Drawing.Size(155, 23);
            this.loadfile_btn.TabIndex = 10;
            this.loadfile_btn.Text = "Charger Le fichier";
            this.loadfile_btn.UseSelectable = true;
            this.loadfile_btn.UseVisualStyleBackColor = true;
            this.loadfile_btn.Click += new System.EventHandler(this.loadfile_btn_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.structures_Grid);
            this.metroPanel1.Controls.Add(this.submit_btn);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 232);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(830, 264);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // structures_Grid
            // 
            this.structures_Grid.AllowUserToAddRows = false;
            this.structures_Grid.AllowUserToDeleteRows = false;
            this.structures_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.structures_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structures_Grid.Location = new System.Drawing.Point(0, 0);
            this.structures_Grid.MultiSelect = false;
            this.structures_Grid.Name = "structures_Grid";
            this.structures_Grid.ReadOnly = true;
            this.structures_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.structures_Grid.Size = new System.Drawing.Size(830, 241);
            this.structures_Grid.TabIndex = 3;
            this.structures_Grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.structures_Grid_CellMouseClick);
            // 
            // submit_btn
            // 
            this.submit_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submit_btn.Enabled = false;
            this.submit_btn.Image = null;
            this.submit_btn.Location = new System.Drawing.Point(0, 241);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(830, 23);
            this.submit_btn.TabIndex = 2;
            this.submit_btn.Text = "Valider La Structure";
            this.submit_btn.UseSelectable = true;
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // fields_panel
            // 
            this.fields_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fields_panel.Controls.Add(this.edit_btn);
            this.fields_panel.Controls.Add(this.del_btn);
            this.fields_panel.Controls.Add(this.add_btn);
            this.fields_panel.Controls.Add(this.modifyField_grid);
            this.fields_panel.HorizontalScrollbarBarColor = true;
            this.fields_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.fields_panel.HorizontalScrollbarSize = 10;
            this.fields_panel.Location = new System.Drawing.Point(0, 128);
            this.fields_panel.Name = "fields_panel";
            this.fields_panel.Size = new System.Drawing.Size(830, 98);
            this.fields_panel.TabIndex = 12;
            this.fields_panel.VerticalScrollbarBarColor = true;
            this.fields_panel.VerticalScrollbarHighlightOnWheel = false;
            this.fields_panel.VerticalScrollbarSize = 10;
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Image = null;
            this.edit_btn.Location = new System.Drawing.Point(347, 64);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(141, 34);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Modifier";
            this.edit_btn.UseSelectable = true;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.del_btn.Image = null;
            this.del_btn.Location = new System.Drawing.Point(689, 64);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(141, 34);
            this.del_btn.TabIndex = 4;
            this.del_btn.Text = "Supprimer";
            this.del_btn.UseSelectable = true;
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_btn.Image = null;
            this.add_btn.Location = new System.Drawing.Point(0, 64);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(141, 34);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Ajouter";
            this.add_btn.UseSelectable = true;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // modifyField_grid
            // 
            this.modifyField_grid.AllowUserToAddRows = false;
            this.modifyField_grid.AllowUserToDeleteRows = false;
            this.modifyField_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyField_grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.modifyField_grid.Location = new System.Drawing.Point(0, 0);
            this.modifyField_grid.Name = "modifyField_grid";
            this.modifyField_grid.Size = new System.Drawing.Size(830, 64);
            this.modifyField_grid.TabIndex = 2;
            this.modifyField_grid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.modifyField_grid_DataError);
            // 
            // loadProgress
            // 
            this.loadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadProgress.Location = new System.Drawing.Point(385, 67);
            this.loadProgress.Maximum = 100;
            this.loadProgress.Name = "loadProgress";
            this.loadProgress.Size = new System.Drawing.Size(50, 44);
            this.loadProgress.Speed = 5F;
            this.loadProgress.TabIndex = 13;
            this.loadProgress.UseSelectable = true;
            this.loadProgress.Value = 20;
            this.loadProgress.Visible = false;
            // 
            // ConfigStructures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadProgress);
            this.Controls.Add(this.fields_panel);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.loadfile_btn);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.file_tb);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.evenements_liste);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.sysAmont_liste);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ConfigStructures";
            this.Size = new System.Drawing.Size(830, 496);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.structures_Grid)).EndInit();
            this.fields_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modifyField_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox sysAmont_liste;
        private MetroFramework.Controls.MetroComboBox evenements_liste;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private MetroFramework.Controls.MetroTextBox file_tb;
        private MetroFramework.Controls.MetroButton browse_btn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton loadfile_btn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton submit_btn;
        private System.Windows.Forms.DataGridView structures_Grid;
        private MetroFramework.Controls.MetroPanel fields_panel;
        private System.Windows.Forms.DataGridView modifyField_grid;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton add_btn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton del_btn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton edit_btn;
        private MetroFramework.Controls.MetroProgressSpinner loadProgress;
    }
}
