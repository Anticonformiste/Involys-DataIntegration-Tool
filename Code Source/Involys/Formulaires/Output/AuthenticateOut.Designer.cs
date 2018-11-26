namespace Involys.Formulaires.Output
{
    partial class AuthenticateOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticateOut));
            this.dbAuth_control = new Involys.UserControls.DBAuthenticationControl();
            this.serverAuth_control = new Involys.UserControls.ServerAuthenticationControl();
            this.SuspendLayout();
            // 
            // dbAuth_control
            // 
            this.dbAuth_control.Connector = null;
            this.dbAuth_control.Databases = ((System.Collections.Generic.List<string>)(resources.GetObject("dbAuth_control.Databases")));
            this.dbAuth_control.IsConnected = false;
            this.dbAuth_control.Location = new System.Drawing.Point(43, 63);
            this.dbAuth_control.Name = "dbAuth_control";
            this.dbAuth_control.Size = new System.Drawing.Size(258, 241);
            this.dbAuth_control.TabIndex = 1;
            this.dbAuth_control.UseSelectable = true;
            this.dbAuth_control.Visible = false;
            // 
            // serverAuth_control
            // 
            this.serverAuth_control.Connector = null;
            this.serverAuth_control.HasDatabases = false;
            this.serverAuth_control.Helper = null;
            this.serverAuth_control.Location = new System.Drawing.Point(43, 63);
            this.serverAuth_control.Margin = new System.Windows.Forms.Padding(30);
            this.serverAuth_control.Name = "serverAuth_control";
            this.serverAuth_control.ServerDatabases = ((System.Collections.Generic.List<string>)(resources.GetObject("serverAuth_control.ServerDatabases")));
            this.serverAuth_control.Size = new System.Drawing.Size(250, 282);
            this.serverAuth_control.TabIndex = 0;
            this.serverAuth_control.UseSelectable = true;
            // 
            // AuthenticateOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 343);
            this.Controls.Add(this.dbAuth_control);
            this.Controls.Add(this.serverAuth_control);
            this.Name = "AuthenticateOut";
            this.Text = "Accés Au Parametrage OUT";
            this.Load += new System.EventHandler(this.AuthenticateOut_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ServerAuthenticationControl serverAuth_control;
        private UserControls.DBAuthenticationControl dbAuth_control;

    }
}