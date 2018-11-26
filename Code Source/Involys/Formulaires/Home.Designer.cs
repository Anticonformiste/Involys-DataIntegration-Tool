namespace Involys
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.output_btn = new MetroFramework.Controls.MetroTile();
            this.input_btn = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msm
            // 
            this.msm.Owner = this;
            this.msm.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // output_btn
            // 
            this.output_btn.ActiveControl = null;
            this.output_btn.Location = new System.Drawing.Point(228, 126);
            this.output_btn.Name = "output_btn";
            this.output_btn.Size = new System.Drawing.Size(220, 182);
            this.output_btn.TabIndex = 2;
            this.output_btn.Text = "OUTPUT";
            this.output_btn.TileImage = global::Involys.Properties.Resources.outPic;
            this.output_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.output_btn.UseSelectable = true;
            this.output_btn.UseTileImage = true;
            this.output_btn.Click += new System.EventHandler(this.output_btn_Click);
            // 
            // input_btn
            // 
            this.input_btn.ActiveControl = null;
            this.input_btn.Location = new System.Drawing.Point(1, 126);
            this.input_btn.Name = "input_btn";
            this.input_btn.Size = new System.Drawing.Size(221, 182);
            this.input_btn.TabIndex = 1;
            this.input_btn.Text = "INPUT";
            this.input_btn.TileImage = global::Involys.Properties.Resources.inPic;
            this.input_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.input_btn.UseSelectable = true;
            this.input_btn.UseTileImage = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Involys.Properties.Resources.logoApp;
            this.pictureBox1.Location = new System.Drawing.Point(1, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 314);
            this.Controls.Add(this.output_btn);
            this.Controls.Add(this.input_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile input_btn;
        private MetroFramework.Controls.MetroTile output_btn;
        private MetroFramework.Components.MetroStyleManager msm;

    }
}

