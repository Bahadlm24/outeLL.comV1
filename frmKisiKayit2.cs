using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace outeLL.comV1
{
    public partial class frmKisiKayit2 : Form
    {
        public frmKisiKayit2()
        {
            InitializeComponent();
        }

        // veri tabanımıza ait bağlantı cümlemizi buraya eklememiz gerekiyor.
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BBSVC63\\SQLEXPRESS;Initial Catalog=outeLL.comVT;Integrated Security=True");


        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            // tüm projeyi kapatmak istediğimizden ötürü this.close komutunu kullanmayacağız
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmKisiKayit frm = new frmKisiKayit();
            frm.Show();
            this.Close();
        }

        public string tc, ad, soyad, dogumt, tel, mail, aciklama, cinsiyet;
        string kuladi, sifre, soru, cevap;

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //if (baglanti.State==ConnectionState.Open)
            //{
            //    MessageBox.Show("açık");
            //}
            //else
            //{
            //    MessageBox.Show("kapalı");
            //}
            //baglanti.Close();

            Temizle();
        }
        void Temizle()
        {
            txtKulAdi.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
            txtCevap.Text = "";
            rbSoru1.Checked = true;
            rbSoru2.Checked = false;
            rbSoru3.Checked = false;
            txtKulAdi.Focus();
            lblSecilenSoru.Text = rbSoru1.Text;
        }

        private void rbSoru3_CheckedChanged(object sender, EventArgs e)
        {
            lblSecilenSoru.Text = rbSoru3.Text;
        }

        private void rbSoru2_CheckedChanged(object sender, EventArgs e)
        {
            lblSecilenSoru.Text = rbSoru2.Text;
        }

        private void rbSoru1_CheckedChanged(object sender, EventArgs e)
        {
            lblSecilenSoru.Text = rbSoru1.Text;
        }

        bool tcKontrol = false;
        bool kulAdiKontrol = false;


        void tcKontrolMetodu()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kisiler WHERE kisiTC=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",tc);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                tcKontrol = true;
            }
            else
            {
                tcKontrol = false;
            }
            baglanti.Close();
            MessageBox.Show("TC kimlik numarasına Ait Değer:" + tcKontrol.ToString());

        }

        void kulAdiKontrolMetodu()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kisiler WHERE kisiKul=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", kuladi);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                kulAdiKontrol = true;
            }
            else
            {
                kulAdiKontrol = false;
            }
            baglanti.Close();
            MessageBox.Show("Kullanıcı Adına Ait Değer:" + kulAdiKontrol.ToString());

        }

        void kisiKayitMetodu()
        {
            // Kayıtlarmızı gerçekleştireceğimiz alanlar

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kisiler(kisiTc,kisiAd,kisiSoyad,kisiCinsiyet,kisiDogumT,kisiTel,kisiMail,kisiAciklama,kisiKul,kisiSifre,kisiSoru,kisiCevap,kisiYetki) VALUES (@kisiTc, @kisiAd, @kisiSoyad, @kisiCinsiyet, @kisiDogumT, @kisiTel, @kisiMail, @kisiAciklama, @kisiKul, @kisiSifre, @kisiSoru, @kisiCevap, @kisiYetki)", baglanti);
            komut.Parameters.AddWithValue("@kisiTc", tc);
            komut.Parameters.AddWithValue("@kisiAd", ad);
            komut.Parameters.AddWithValue("@kisiSoyad", soyad);
            komut.Parameters.AddWithValue("@kisiCinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@kisiDogumT", dogumt);
            komut.Parameters.AddWithValue("@kisiTel", tel);
            komut.Parameters.AddWithValue("@kisiMail", mail);
            komut.Parameters.AddWithValue("@kisiAciklama", aciklama);
            komut.Parameters.AddWithValue("@kisiKul", kuladi);
            komut.Parameters.AddWithValue("@kisiSifre", sifre);
            komut.Parameters.AddWithValue("@kisiSoru", soru);
            komut.Parameters.AddWithValue("@kisiCevap", cevap);
            komut.Parameters.AddWithValue("@kisiYetki", "1");
            komut.ExecuteNonQuery();
            baglanti.Close();
            Temizle();
            MessageBox.Show("kayıt işlemi başarıyla gerçekleşti");
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text!=""&& txtSifre.Text!=""&&txtSifreTekrar.Text!=""&&txtCevap.Text!="")
            {
                if (txtSifre.Text==txtSifreTekrar.Text)
                {
                    //kayıt işlemi gerçekleşitirilebilir.

                    kuladi = txtKulAdi.Text;
                    sifre = txtSifre.Text;
                    soru=lblSecilenSoru.Text;
                    cevap = txtCevap.Text;
                    tcKontrolMetodu();
                    kulAdiKontrolMetodu();
                    if (tcKontrol==false && kulAdiKontrol == false)
                    {
                        kisiKayitMetodu();
                        frmKullaniciGiris giris = new frmKullaniciGiris();
                        giris.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("kayıt yapılamaz");
                    }

                    //MessageBox.Show(tc + " " + ad + " " + soyad + " " + dogumt + " " + mail + " " + aciklama + " " + tel + " " + cinsiyet);
                    //MessageBox.Show(kuladi + " " + sifre + " " + soru + " " + cevap);

                }
                else
                {
                    frmPopupmenu frm = new frmPopupmenu();
                    frm.label1.Text = "Şifreler aynı değil";
                    frm.Show();
                }
            }
            else
            {
                frmPopupmenu frm = new frmPopupmenu();
                frm.label1.Text = "Lütfen zorunlu alanları doldurunuz.";
                frm.Show();
            }
            
         }

        private void frmKisiKayit2_Load(object sender, EventArgs e)
        {
            lblSecilenSoru.Text = rbSoru1.Text;
        }
    }
}
