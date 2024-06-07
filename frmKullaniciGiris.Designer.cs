namespace outeLL.comV1
{
    partial class frmKullaniciGiris
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
            this.pnl_UstMenu = new System.Windows.Forms.Panel();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.pnl_UstMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_UstMenu
            // 
            this.pnl_UstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.pnl_UstMenu.Controls.Add(this.btn_Cikis);
            this.pnl_UstMenu.Controls.Add(this.label1);
            this.pnl_UstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_UstMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_UstMenu.Name = "pnl_UstMenu";
            this.pnl_UstMenu.Size = new System.Drawing.Size(651, 62);
            this.pnl_UstMenu.TabIndex = 1;
            this.pnl_UstMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_UstMenu_Paint);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.btn_Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.ForeColor = System.Drawing.Color.White;
            this.btn_Cikis.Location = new System.Drawing.Point(589, 0);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(62, 62);
            this.btn_Cikis.TabIndex = 1;
            this.btn_Cikis.Text = "x";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Giriş Ekranı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(200, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSifre.Location = new System.Drawing.Point(15, 28);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(182, 22);
            this.txtSifre.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKulAdi);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Adı";
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKulAdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtKulAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtKulAdi.Location = new System.Drawing.Point(15, 28);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(182, 22);
            this.txtKulAdi.TabIndex = 0;
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_UstMenu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKullaniciGiris";
            this.pnl_UstMenu.ResumeLayout(false);
            this.pnl_UstMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_UstMenu;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKulAdi;
    }
}