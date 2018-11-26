namespace Involys.UserControls.Output
{
    partial class ConfigConditions
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
            this.modifyField_grid = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.parents_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.types_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.event_panel = new MetroFramework.Controls.MetroPanel();
            this.events_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.new_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.edit_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.del_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.add_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.modifyField_grid)).BeginInit();
            this.table1.SuspendLayout();
            this.tabel2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.event_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifyField_grid
            // 
            this.modifyField_grid.AllowUserToAddRows = false;
            this.modifyField_grid.AllowUserToDeleteRows = false;
            this.modifyField_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel2.SetColumnSpan(this.modifyField_grid, 3);
            this.modifyField_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifyField_grid.Location = new System.Drawing.Point(3, 72);
            this.modifyField_grid.Name = "modifyField_grid";
            this.modifyField_grid.Size = new System.Drawing.Size(545, 63);
            this.modifyField_grid.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(160, 207);
            this.treeView1.TabIndex = 18;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // table1
            // 
            this.table1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table1.ColumnCount = 2;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0982F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.9018F));
            this.table1.Controls.Add(this.treeView1, 0, 0);
            this.table1.Controls.Add(this.tabel2, 1, 0);
            this.table1.Location = new System.Drawing.Point(3, 42);
            this.table1.Name = "table1";
            this.table1.RowCount = 1;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table1.Size = new System.Drawing.Size(723, 213);
            this.table1.TabIndex = 18;
            // 
            // tabel2
            // 
            this.tabel2.ColumnCount = 3;
            this.tabel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tabel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tabel2.Controls.Add(this.metroPanel2, 2, 0);
            this.tabel2.Controls.Add(this.metroPanel1, 1, 0);
            this.tabel2.Controls.Add(this.event_panel, 0, 0);
            this.tabel2.Controls.Add(this.modifyField_grid, 0, 1);
            this.tabel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabel2.Location = new System.Drawing.Point(169, 3);
            this.tabel2.Name = "tabel2";
            this.tabel2.RowCount = 3;
            this.tabel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabel2.Size = new System.Drawing.Size(551, 207);
            this.tabel2.TabIndex = 19;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.parents_liste);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(369, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(179, 63);
            this.metroPanel2.TabIndex = 21;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // parents_liste
            // 
            this.parents_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parents_liste.FormattingEnabled = true;
            this.parents_liste.ItemHeight = 23;
            this.parents_liste.Items.AddRange(new object[] {
            "Racine",
            "Teble"});
            this.parents_liste.Location = new System.Drawing.Point(3, 25);
            this.parents_liste.Name = "parents_liste";
            this.parents_liste.Size = new System.Drawing.Size(173, 29);
            this.parents_liste.TabIndex = 7;
            this.parents_liste.UseSelectable = true;
            this.parents_liste.SelectedIndexChanged += new System.EventHandler(this.parents_liste_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(1, 4);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Pére";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.types_liste);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(186, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(177, 63);
            this.metroPanel1.TabIndex = 20;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // types_liste
            // 
            this.types_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.types_liste.FormattingEnabled = true;
            this.types_liste.ItemHeight = 23;
            this.types_liste.Items.AddRange(new object[] {
            "Racine",
            "Table"});
            this.types_liste.Location = new System.Drawing.Point(3, 25);
            this.types_liste.Name = "types_liste";
            this.types_liste.Size = new System.Drawing.Size(171, 29);
            this.types_liste.TabIndex = 7;
            this.types_liste.UseSelectable = true;
            this.types_liste.SelectedIndexChanged += new System.EventHandler(this.types_liste_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(1, 4);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Type";
            // 
            // event_panel
            // 
            this.event_panel.Controls.Add(this.events_liste);
            this.event_panel.Controls.Add(this.metroLabel2);
            this.event_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.event_panel.HorizontalScrollbarBarColor = true;
            this.event_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.event_panel.HorizontalScrollbarSize = 10;
            this.event_panel.Location = new System.Drawing.Point(3, 3);
            this.event_panel.Name = "event_panel";
            this.event_panel.Size = new System.Drawing.Size(177, 63);
            this.event_panel.TabIndex = 19;
            this.event_panel.VerticalScrollbarBarColor = true;
            this.event_panel.VerticalScrollbarHighlightOnWheel = false;
            this.event_panel.VerticalScrollbarSize = 10;
            // 
            // events_liste
            // 
            this.events_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.events_liste.FormattingEnabled = true;
            this.events_liste.ItemHeight = 23;
            this.events_liste.Location = new System.Drawing.Point(3, 25);
            this.events_liste.Name = "events_liste";
            this.events_liste.Size = new System.Drawing.Size(171, 29);
            this.events_liste.TabIndex = 7;
            this.events_liste.UseSelectable = true;
            this.events_liste.SelectedIndexChanged += new System.EventHandler(this.events_liste_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(1, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Evenement";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tabel2.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.new_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.edit_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.del_btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.add_btn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 141);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 63);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // new_btn
            // 
            this.new_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.new_btn.Image = null;
            this.new_btn.Location = new System.Drawing.Point(3, 17);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(130, 29);
            this.new_btn.TabIndex = 23;
            this.new_btn.Text = "Nouveau";
            this.new_btn.UseSelectable = true;
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Image = null;
            this.edit_btn.Location = new System.Drawing.Point(275, 16);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(130, 30);
            this.edit_btn.TabIndex = 22;
            this.edit_btn.Text = "Modifier";
            this.edit_btn.UseSelectable = true;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.del_btn.Image = null;
            this.del_btn.Location = new System.Drawing.Point(411, 16);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(131, 30);
            this.del_btn.TabIndex = 21;
            this.del_btn.Text = "Supprimer";
            this.del_btn.UseSelectable = true;
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Enabled = false;
            this.add_btn.Image = null;
            this.add_btn.Location = new System.Drawing.Point(139, 17);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(130, 29);
            this.add_btn.TabIndex = 20;
            this.add_btn.Text = "Ajouter";
            this.add_btn.UseSelectable = true;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(726, 25);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Configuration Des Conditions";
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(726, 11);
            this.bunifuSeparator1.TabIndex = 14;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // ConfigConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ConfigConditions";
            this.Size = new System.Drawing.Size(728, 255);
            ((System.ComponentModel.ISupportInitialize)(this.modifyField_grid)).EndInit();
            this.table1.ResumeLayout(false);
            this.tabel2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.event_panel.ResumeLayout(false);
            this.event_panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel table1;
        private System.Windows.Forms.TableLayoutPanel tabel2;
        protected System.Windows.Forms.DataGridView modifyField_grid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel event_panel;
        private MetroFramework.Controls.MetroComboBox events_liste;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox types_liste;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroComboBox parents_liste;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton new_btn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton edit_btn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton del_btn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton add_btn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
