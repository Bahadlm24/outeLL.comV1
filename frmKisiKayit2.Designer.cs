namespace outeLL.comV1
{
    partial class frmKisiKayit2
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSoru3 = new System.Windows.Forms.RadioButton();
            this.rbSoru2 = new System.Windows.Forms.RadioButton();
            this.rbSoru1 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblSecilenSoru = new System.Windows.Forms.Label();
            this.pnl_UstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_UstMenu
            // 
            this.pnl_UstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.pnl_UstMenu.Controls.Add(this.label1);
            this.pnl_UstMenu.Controls.Add(this.pictureBox1);
            this.pnl_UstMenu.Controls.Add(this.btn_Cikis);
            this.pnl_UstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_UstMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_UstMenu.Name = "pnl_UstMenu";
            this.pnl_UstMenu.Size = new System.Drawing.Size(660, 62);
            this.pnl_UstMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişi Kayıt Tamamlama Ekranı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::outeLL.comV1.Properties.Resources.arrow_left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.btn_Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.ForeColor = System.Drawing.Color.White;
            this.btn_Cikis.Location = new System.Drawing.Point(598, 0);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(62, 62);
            this.btn_Cikis.TabIndex = 1;
            this.btn_Cikis.Text = "x";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKulAdi);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(23, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 15;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(23, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(200, 53);
            this.groupBox2.TabIndex = 16;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSifreTekrar);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(23, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(200, 53);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Şifre (Tekrar)";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifreTekrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSifreTekrar.Location = new System.Drawing.Point(15, 28);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(182, 22);
            this.txtSifreTekrar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbSoru3);
            this.groupBox4.Controls.Add(this.rbSoru2);
            this.groupBox4.Controls.Add(this.rbSoru1);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(232, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(407, 112);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Güvenlik Sorusu";
            // 
            // rbSoru3
            // 
            this.rbSoru3.AutoSize = true;
            this.rbSoru3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSoru3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSoru3.Location = new System.Drawing.Point(15, 81);
            this.rbSoru3.Name = "rbSoru3";
            this.rbSoru3.Size = new System.Drawing.Size(74, 25);
            this.rbSoru3.TabIndex = 3;
            this.rbSoru3.Text = "Soru 3";
            this.rbSoru3.UseVisualStyleBackColor = true;
            this.rbSoru3.CheckedChanged += new System.EventHandler(this.rbSoru3_CheckedChanged);
            // 
            // rbSoru2
            // 
            this.rbSoru2.AutoSize = true;
            this.rbSoru2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSoru2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSoru2.Location = new System.Drawing.Point(15, 53);
            this.rbSoru2.Name = "rbSoru2";
            this.rbSoru2.Size = new System.Drawing.Size(74, 25);
            this.rbSoru2.TabIndex = 2;
            this.rbSoru2.Text = "Soru 2";
            this.rbSoru2.UseVisualStyleBackColor = true;
            this.rbSoru2.CheckedChanged += new System.EventHandler(this.rbSoru2_CheckedChanged);
            // 
            // rbSoru1
            // 
            this.rbSoru1.AutoSize = true;
            this.rbSoru1.Checked = true;
            this.rbSoru1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSoru1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSoru1.Location = new System.Drawing.Point(15, 24);
            this.rbSoru1.Name = "rbSoru1";
            this.rbSoru1.Size = new System.Drawing.Size(71, 25);
            this.rbSoru1.TabIndex = 1;
            this.rbSoru1.TabStop = true;
            this.rbSoru1.Text = "Soru 1";
            this.rbSoru1.UseVisualStyleBackColor = true;
            this.rbSoru1.CheckedChanged += new System.EventHandler(this.rbSoru1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(15, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 22);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCevap);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(232, 210);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(404, 53);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Güvenlik Cevabı";
            // 
            // txtCevap
            // 
            this.txtCevap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCevap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCevap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtCevap.Location = new System.Drawing.Point(15, 28);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(386, 22);
            this.txtCevap.TabIndex = 0;
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(123)))));
            this.btnTamamla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamamla.FlatAppearance.BorderSize = 0;
            this.btnTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamla.ForeColor = System.Drawing.Color.White;
            this.btnTamamla.Location = new System.Drawing.Point(232, 269);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(407, 62);
            this.btnTamamla.TabIndex = 20;
            this.btnTamamla.Text = "TAMAMLA";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(23, 269);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(200, 62);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblSecilenSoru
            // 
            this.lblSecilenSoru.AutoSize = true;
            this.lblSecilenSoru.Location = new System.Drawing.Point(25, 335);
            this.lblSecilenSoru.Name = "lblSecilenSoru";
            this.lblSecilenSoru.Size = new System.Drawing.Size(36, 21);
            this.lblSecilenSoru.TabIndex = 21;
            this.lblSecilenSoru.Text = "null";
            this.lblSecilenSoru.Visible = false;
            // 
            // frmKisiKayit2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 360);
            this.Controls.Add(this.lblSecilenSoru);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_UstMenu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKisiKayit2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKisiKayit2";
            this.Load += new System.EventHandler(this.frmKisiKayit2_Load);
            this.pnl_UstMenu.ResumeLayout(false);
            this.pnl_UstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_UstMenu;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.RadioButton rbSoru3;
        private System.Windows.Forms.RadioButton rbSoru2;
        private System.Windows.Forms.RadioButton rbSoru1;
        private System.Windows.Forms.Label lblSecilenSoru;
    }
}