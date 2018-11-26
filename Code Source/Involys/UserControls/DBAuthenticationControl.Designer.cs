namespace Involys.UserControls
{
    partial class DBAuthenticationControl
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
            this.fieldsPanel = new MetroFramework.Controls.MetroPanel();
            this.loginProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.password_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.username_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.go_btn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.databases_list = new MetroFramework.Controls.MetroComboBox();
            this.fieldsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(258, 25);
            this.title_lbl.TabIndex = 80;
            this.title_lbl.Text = "Authentification BD Interfaçage";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_lbl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.title_lbl.UseStyleColors = true;
            // 
            // fieldsPanel
            // 
            this.fieldsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldsPanel.Controls.Add(this.loginProgress);
            this.fieldsPanel.Controls.Add(this.password_tb);
            this.fieldsPanel.Controls.Add(this.metroLabel4);
            this.fieldsPanel.Controls.Add(this.username_tb);
            this.fieldsPanel.Controls.Add(this.metroLabel3);
            this.fieldsPanel.Controls.Add(this.go_btn);
            this.fieldsPanel.Controls.Add(this.metroLabel2);
            this.fieldsPanel.Controls.Add(this.databases_list);
            this.fieldsPanel.HorizontalScrollbarBarColor = true;
            this.fieldsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.fieldsPanel.HorizontalScrollbarSize = 10;
            this.fieldsPanel.Location = new System.Drawing.Point(0, 27);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.Size = new System.Drawing.Size(258, 205);
            this.fieldsPanel.TabIndex = 81;
            this.fieldsPanel.VerticalScrollbarBarColor = true;
            this.fieldsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.fieldsPanel.VerticalScrollbarSize = 10;
            // 
            // loginProgress
            // 
            this.loginProgress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginProgress.Location = new System.Drawing.Point(14, 158);
            this.loginProgress.Maximum = 100;
            this.loginProgress.Name = "loginProgress";
            this.loginProgress.Size = new System.Drawing.Size(47, 40);
            this.loginProgress.Speed = 2F;
            this.loginProgress.TabIndex = 87;
            this.loginProgress.UseSelectable = true;
            this.loginProgress.Value = 20;
            this.loginProgress.Visible = false;
            // 
            // password_tb
            // 
            this.password_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.password_tb.CustomButton.Image = null;
            this.password_tb.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.password_tb.CustomButton.Name = "";
            this.password_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_tb.CustomButton.TabIndex = 1;
            this.password_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_tb.CustomButton.UseSelectable = true;
            this.password_tb.CustomButton.Visible = false;
            this.password_tb.Lines = new string[0];
            this.password_tb.Location = new System.Drawing.Point(14, 130);
            this.password_tb.MaxLength = 24;
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_tb.SelectedText = "";
            this.password_tb.SelectionLength = 0;
            this.password_tb.SelectionStart = 0;
            this.password_tb.ShortcutsEnabled = true;
            this.password_tb.Size = new System.Drawing.Size(222, 23);
            this.password_tb.TabIndex = 2;
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_tb.UseSelectable = true;
            this.password_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.Location = new System.Drawing.Point(14, 108);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(222, 19);
            this.metroLabel4.TabIndex = 85;
            this.metroLabel4.Text = "Password";
            // 
            // username_tb
            // 
            this.username_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.username_tb.CustomButton.Image = null;
            this.username_tb.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.username_tb.CustomButton.Name = "";
            this.username_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username_tb.CustomButton.TabIndex = 1;
            this.username_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username_tb.CustomButton.UseSelectable = true;
            this.username_tb.CustomButton.Visible = false;
            this.username_tb.Lines = new string[0];
            this.username_tb.Location = new System.Drawing.Point(14, 81);
            this.username_tb.MaxLength = 32767;
            this.username_tb.Name = "username_tb";
            this.username_tb.PasswordChar = '\0';
            this.username_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username_tb.SelectedText = "";
            this.username_tb.SelectionLength = 0;
            this.username_tb.SelectionStart = 0;
            this.username_tb.ShortcutsEnabled = true;
            this.username_tb.Size = new System.Drawing.Size(222, 23);
            this.username_tb.TabIndex = 1;
            this.username_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_tb.UseSelectable = true;
            this.username_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.Location = new System.Drawing.Point(14, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(222, 19);
            this.metroLabel3.TabIndex = 83;
            this.metroLabel3.Text = "Login";
            // 
            // go_btn
            // 
            this.go_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.go_btn.Image = null;
            this.go_btn.Location = new System.Drawing.Point(139, 158);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(97, 29);
            this.go_btn.TabIndex = 3;
            this.go_btn.Text = "Se Connecter";
            this.go_btn.UseSelectable = true;
            this.go_btn.UseVisualStyleBackColor = true;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(14, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(222, 19);
            this.metroLabel2.TabIndex = 80;
            this.metroLabel2.Text = "Base De Données:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // databases_list
            // 
            this.databases_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.databases_list.FormattingEnabled = true;
            this.databases_list.ItemHeight = 23;
            this.databases_list.Location = new System.Drawing.Point(14, 27);
            this.databases_list.Name = "databases_list";
            this.databases_list.Size = new System.Drawing.Size(222, 29);
            this.databases_list.TabIndex = 0;
            this.databases_list.UseSelectable = true;
            // 
            // DBAuthenticationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldsPanel);
            this.Controls.Add(this.title_lbl);
            this.Name = "DBAuthenticationControl";
            this.Size = new System.Drawing.Size(258, 241);
            this.Load += new System.EventHandler(this.DataBaseAuthentication_Load);
            this.fieldsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel title_lbl;
        private MetroFramework.Controls.MetroPanel fieldsPanel;
        private MetroFramework.Controls.MetroProgressSpinner loginProgress;
        private MetroFramework.Controls.MetroTextBox password_tb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox username_tb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton go_btn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox databases_list;
    }
}
