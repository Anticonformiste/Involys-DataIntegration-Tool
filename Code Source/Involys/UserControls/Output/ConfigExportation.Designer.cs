namespace Involys.UserControls.Output
{
    partial class ConfigExportation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.events_liste = new MetroFramework.Controls.MetroComboBox();
            this.mvt_grid = new MetroFramework.Controls.MetroGrid();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.export_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.footer_panel = new MetroFramework.Controls.MetroPanel();
            this.avg_list = new System.Windows.Forms.CheckedListBox();
            this.sum_list = new System.Windows.Forms.CheckedListBox();
            this.avg_cb = new MetroFramework.Controls.MetroCheckBox();
            this.sum_cb = new MetroFramework.Controls.MetroCheckBox();
            this.count_cb = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.header_panel = new MetroFramework.Controls.MetroPanel();
            this.colNames_cb = new MetroFramework.Controls.MetroCheckBox();
            this.nomEv_cb = new MetroFramework.Controls.MetroCheckBox();
            this.dateHeader_cb = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.file_panel = new MetroFramework.Controls.MetroPanel();
            this.sep_panel = new MetroFramework.Controls.MetroPanel();
            this.sepOk_btn = new MetroFramework.Controls.MetroButton();
            this.sep_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dateFileName_cb = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.nomFile_tb = new MetroFramework.Controls.MetroTextBox();
            this.typeFile_liste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new MetroFramework.Controls.MetroLabel();
            this.folderDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mvt_grid)).BeginInit();
            this.footer_panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.file_panel.SuspendLayout();
            this.sep_panel.SuspendLayout();
            this.SuspendLayout();
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(843, 10);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(832, 25);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Visualisation des Tables MVT et Exportation";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(283, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Evenement :";
            // 
            // events_liste
            // 
            this.events_liste.FormattingEnabled = true;
            this.events_liste.ItemHeight = 23;
            this.events_liste.Location = new System.Drawing.Point(362, 35);
            this.events_liste.Name = "events_liste";
            this.events_liste.Size = new System.Drawing.Size(176, 29);
            this.events_liste.TabIndex = 20;
            this.events_liste.UseSelectable = true;
            this.events_liste.SelectedIndexChanged += new System.EventHandler(this.events_liste_SelectedIndexChanged);
            // 
            // mvt_grid
            // 
            this.mvt_grid.AllowUserToResizeRows = false;
            this.mvt_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mvt_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mvt_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mvt_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvt_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mvt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mvt_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mvt_grid.EnableHeadersVisualStyles = false;
            this.mvt_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mvt_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mvt_grid.Location = new System.Drawing.Point(0, 74);
            this.mvt_grid.Name = "mvt_grid";
            this.mvt_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvt_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mvt_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mvt_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mvt_grid.Size = new System.Drawing.Size(835, 175);
            this.mvt_grid.TabIndex = 21;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-4, 64);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(843, 10);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-4, 255);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(846, 10);
            this.bunifuSeparator3.TabIndex = 23;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // export_btn
            // 
            this.export_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.export_btn.Image = null;
            this.export_btn.Location = new System.Drawing.Point(335, 479);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(167, 37);
            this.export_btn.TabIndex = 27;
            this.export_btn.Text = "Valider L\'Exportation";
            this.export_btn.UseSelectable = true;
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // footer_panel
            // 
            this.footer_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footer_panel.Controls.Add(this.avg_list);
            this.footer_panel.Controls.Add(this.sum_list);
            this.footer_panel.Controls.Add(this.avg_cb);
            this.footer_panel.Controls.Add(this.sum_cb);
            this.footer_panel.Controls.Add(this.count_cb);
            this.footer_panel.Controls.Add(this.metroLabel6);
            this.footer_panel.HorizontalScrollbarBarColor = true;
            this.footer_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.footer_panel.HorizontalScrollbarSize = 10;
            this.footer_panel.Location = new System.Drawing.Point(0, 420);
            this.footer_panel.Name = "footer_panel";
            this.footer_panel.Size = new System.Drawing.Size(832, 53);
            this.footer_panel.TabIndex = 26;
            this.footer_panel.VerticalScrollbarBarColor = true;
            this.footer_panel.VerticalScrollbarHighlightOnWheel = false;
            this.footer_panel.VerticalScrollbarSize = 10;
            // 
            // avg_list
            // 
            this.avg_list.FormattingEnabled = true;
            this.avg_list.Location = new System.Drawing.Point(541, 55);
            this.avg_list.Name = "avg_list";
            this.avg_list.Size = new System.Drawing.Size(156, 64);
            this.avg_list.TabIndex = 19;
            this.avg_list.Visible = false;
            // 
            // sum_list
            // 
            this.sum_list.FormattingEnabled = true;
            this.sum_list.Location = new System.Drawing.Point(149, 55);
            this.sum_list.Name = "sum_list";
            this.sum_list.Size = new System.Drawing.Size(143, 64);
            this.sum_list.TabIndex = 18;
            this.sum_list.Visible = false;
            // 
            // avg_cb
            // 
            this.avg_cb.AutoSize = true;
            this.avg_cb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.avg_cb.Location = new System.Drawing.Point(541, 30);
            this.avg_cb.Name = "avg_cb";
            this.avg_cb.Size = new System.Drawing.Size(159, 19);
            this.avg_cb.TabIndex = 17;
            this.avg_cb.Text = "Moyenne Du Champs";
            this.avg_cb.UseSelectable = true;
            this.avg_cb.CheckedChanged += new System.EventHandler(this.SumAvg_checkedChanged);
            // 
            // sum_cb
            // 
            this.sum_cb.AutoSize = true;
            this.sum_cb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.sum_cb.Location = new System.Drawing.Point(149, 30);
            this.sum_cb.Name = "sum_cb";
            this.sum_cb.Size = new System.Drawing.Size(145, 19);
            this.sum_cb.TabIndex = 16;
            this.sum_cb.Text = "Somme du Champs";
            this.sum_cb.UseSelectable = true;
            this.sum_cb.CheckedChanged += new System.EventHandler(this.SumAvg_checkedChanged);
            // 
            // count_cb
            // 
            this.count_cb.AutoSize = true;
            this.count_cb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.count_cb.Location = new System.Drawing.Point(347, 30);
            this.count_cb.Name = "count_cb";
            this.count_cb.Size = new System.Drawing.Size(145, 19);
            this.count_cb.TabIndex = 15;
            this.count_cb.Text = "Nombre Des Lignes";
            this.count_cb.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(0, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(830, 23);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Pied Du Fichier";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header_panel
            // 
            this.header_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_panel.Controls.Add(this.colNames_cb);
            this.header_panel.Controls.Add(this.nomEv_cb);
            this.header_panel.Controls.Add(this.dateHeader_cb);
            this.header_panel.Controls.Add(this.metroLabel3);
            this.header_panel.HorizontalScrollbarBarColor = true;
            this.header_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.header_panel.HorizontalScrollbarSize = 10;
            this.header_panel.Location = new System.Drawing.Point(0, 345);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(832, 69);
            this.header_panel.TabIndex = 25;
            this.header_panel.VerticalScrollbarBarColor = true;
            this.header_panel.VerticalScrollbarHighlightOnWheel = false;
            this.header_panel.VerticalScrollbarSize = 10;
            // 
            // colNames_cb
            // 
            this.colNames_cb.AutoSize = true;
            this.colNames_cb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.colNames_cb.Location = new System.Drawing.Point(541, 45);
            this.colNames_cb.Name = "colNames_cb";
            this.colNames_cb.Size = new System.Drawing.Size(143, 19);
            this.colNames_cb.TabIndex = 15;
            this.colNames_cb.Text = "Nom Des Colonnes";
            this.colNames_cb.UseSelectable = true;
            // 
            // nomEv_cb
            // 
            this.nomEv_cb.AutoSize = true;
            this.nomEv_cb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.nomEv_cb.Location = new System.Drawing.Point(347, 38);
            this.nomEv_cb.Name = "nomEv_cb";
            this.nomEv_cb.Size = new System.Drawing.Size(138, 19);
            this.nomEv_cb.TabIndex = 14;
            this.nomEv_cb.Text = "Nom d\'Evenement";
            this.nomEv_cb.UseSelectable = true;
            // 
            // dateHeader_cb
            // 
            this.dateHeader_cb.AutoSize = true;
            this.dateHeader_cb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.dateHeader_cb.Location = new System.Drawing.Point(149, 38);
            this.dateHeader_cb.Name = "dateHeader_cb";
            this.dateHeader_cb.Size = new System.Drawing.Size(117, 19);
            this.dateHeader_cb.TabIndex = 13;
            this.dateHeader_cb.Text = "Date Compléte";
            this.dateHeader_cb.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(830, 23);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "En-tete Du Fichier";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // file_panel
            // 
            this.file_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file_panel.Controls.Add(this.sep_panel);
            this.file_panel.Controls.Add(this.dateFileName_cb);
            this.file_panel.Controls.Add(this.metroLabel5);
            this.file_panel.Controls.Add(this.nomFile_tb);
            this.file_panel.Controls.Add(this.typeFile_liste);
            this.file_panel.Controls.Add(this.metroLabel7);
            this.file_panel.Controls.Add(this.panel1);
            this.file_panel.HorizontalScrollbarBarColor = true;
            this.file_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.file_panel.HorizontalScrollbarSize = 10;
            this.file_panel.Location = new System.Drawing.Point(0, 266);
            this.file_panel.Name = "file_panel";
            this.file_panel.Size = new System.Drawing.Size(835, 73);
            this.file_panel.TabIndex = 24;
            this.file_panel.VerticalScrollbarBarColor = true;
            this.file_panel.VerticalScrollbarHighlightOnWheel = false;
            this.file_panel.VerticalScrollbarSize = 10;
            // 
            // sep_panel
            // 
            this.sep_panel.Controls.Add(this.sepOk_btn);
            this.sep_panel.Controls.Add(this.sep_tb);
            this.sep_panel.Controls.Add(this.metroLabel4);
            this.sep_panel.HorizontalScrollbarBarColor = true;
            this.sep_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.sep_panel.HorizontalScrollbarSize = 10;
            this.sep_panel.Location = new System.Drawing.Point(326, 36);
            this.sep_panel.Name = "sep_panel";
            this.sep_panel.Size = new System.Drawing.Size(179, 29);
            this.sep_panel.TabIndex = 14;
            this.sep_panel.VerticalScrollbarBarColor = true;
            this.sep_panel.VerticalScrollbarHighlightOnWheel = false;
            this.sep_panel.VerticalScrollbarSize = 10;
            this.sep_panel.Visible = false;
            // 
            // sepOk_btn
            // 
            this.sepOk_btn.Location = new System.Drawing.Point(133, 3);
            this.sepOk_btn.Name = "sepOk_btn";
            this.sepOk_btn.Size = new System.Drawing.Size(38, 23);
            this.sepOk_btn.TabIndex = 15;
            this.sepOk_btn.Text = "OK";
            this.sepOk_btn.UseSelectable = true;
            this.sepOk_btn.Click += new System.EventHandler(this.sepOk_btn_Click);
            // 
            // sep_tb
            // 
            // 
            // 
            // 
            this.sep_tb.CustomButton.Image = null;
            this.sep_tb.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.sep_tb.CustomButton.Name = "";
            this.sep_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sep_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sep_tb.CustomButton.TabIndex = 1;
            this.sep_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sep_tb.CustomButton.UseSelectable = true;
            this.sep_tb.CustomButton.Visible = false;
            this.sep_tb.Lines = new string[0];
            this.sep_tb.Location = new System.Drawing.Point(80, 3);
            this.sep_tb.MaxLength = 1;
            this.sep_tb.Name = "sep_tb";
            this.sep_tb.PasswordChar = '\0';
            this.sep_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sep_tb.SelectedText = "";
            this.sep_tb.SelectionLength = 0;
            this.sep_tb.SelectionStart = 0;
            this.sep_tb.ShortcutsEnabled = true;
            this.sep_tb.Size = new System.Drawing.Size(47, 23);
            this.sep_tb.TabIndex = 14;
            this.sep_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sep_tb.UseSelectable = true;
            this.sep_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sep_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 4);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Séparateur:";
            // 
            // dateFileName_cb
            // 
            this.dateFileName_cb.AutoSize = true;
            this.dateFileName_cb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.dateFileName_cb.Location = new System.Drawing.Point(541, 40);
            this.dateFileName_cb.Name = "dateFileName_cb";
            this.dateFileName_cb.Size = new System.Drawing.Size(106, 19);
            this.dateFileName_cb.TabIndex = 12;
            this.dateFileName_cb.Text = "Date Du Jour";
            this.dateFileName_cb.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(326, 40);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Nom:";
            // 
            // nomFile_tb
            // 
            // 
            // 
            // 
            this.nomFile_tb.CustomButton.Image = null;
            this.nomFile_tb.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.nomFile_tb.CustomButton.Name = "";
            this.nomFile_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nomFile_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nomFile_tb.CustomButton.TabIndex = 1;
            this.nomFile_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomFile_tb.CustomButton.UseSelectable = true;
            this.nomFile_tb.CustomButton.Visible = false;
            this.nomFile_tb.Lines = new string[0];
            this.nomFile_tb.Location = new System.Drawing.Point(369, 39);
            this.nomFile_tb.MaxLength = 32767;
            this.nomFile_tb.Name = "nomFile_tb";
            this.nomFile_tb.PasswordChar = '\0';
            this.nomFile_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomFile_tb.SelectedText = "";
            this.nomFile_tb.SelectionLength = 0;
            this.nomFile_tb.SelectionStart = 0;
            this.nomFile_tb.ShortcutsEnabled = true;
            this.nomFile_tb.Size = new System.Drawing.Size(136, 23);
            this.nomFile_tb.TabIndex = 6;
            this.nomFile_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nomFile_tb.UseSelectable = true;
            this.nomFile_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nomFile_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // typeFile_liste
            // 
            this.typeFile_liste.FormattingEnabled = true;
            this.typeFile_liste.ItemHeight = 23;
            this.typeFile_liste.Location = new System.Drawing.Point(121, 36);
            this.typeFile_liste.Name = "typeFile_liste";
            this.typeFile_liste.Size = new System.Drawing.Size(165, 29);
            this.typeFile_liste.TabIndex = 4;
            this.typeFile_liste.UseSelectable = true;
            this.typeFile_liste.SelectedIndexChanged += new System.EventHandler(this.typeFile_liste_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(83, 39);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Type:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.panel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 23);
            this.panel1.TabIndex = 2;
            this.panel1.Text = "Exporter Vers Un Fichier";
            this.panel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigExportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.footer_panel);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.file_panel);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.mvt_grid);
            this.Controls.Add(this.events_liste);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ConfigExportation";
            this.Size = new System.Drawing.Size(835, 520);
            ((System.ComponentModel.ISupportInitialize)(this.mvt_grid)).EndInit();
            this.footer_panel.ResumeLayout(false);
            this.footer_panel.PerformLayout();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.file_panel.ResumeLayout(false);
            this.file_panel.PerformLayout();
            this.sep_panel.ResumeLayout(false);
            this.sep_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox events_liste;
        private MetroFramework.Controls.MetroGrid mvt_grid;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton export_btn;
        private MetroFramework.Controls.MetroPanel footer_panel;
        private System.Windows.Forms.CheckedListBox avg_list;
        private System.Windows.Forms.CheckedListBox sum_list;
        private MetroFramework.Controls.MetroCheckBox avg_cb;
        private MetroFramework.Controls.MetroCheckBox sum_cb;
        private MetroFramework.Controls.MetroCheckBox count_cb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel header_panel;
        private MetroFramework.Controls.MetroCheckBox colNames_cb;
        private MetroFramework.Controls.MetroCheckBox nomEv_cb;
        private MetroFramework.Controls.MetroCheckBox dateHeader_cb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel file_panel;
        private MetroFramework.Controls.MetroPanel sep_panel;
        private MetroFramework.Controls.MetroButton sepOk_btn;
        private MetroFramework.Controls.MetroTextBox sep_tb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox dateFileName_cb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox nomFile_tb;
        private MetroFramework.Controls.MetroComboBox typeFile_liste;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderDialog1;
    }
}
