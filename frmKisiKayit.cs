using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace outeLL.comV1
{
    public partial class frmKisiKayit : Form
    {
        public frmKisiKayit()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        string tc, ad, soyad, dogumt, tel, mail, aciklama, cinsiyet;

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtDogumTarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //harf girişi engellebecek
            if (e.KeyChar=='.')
            {
                e.Handled= false;
            }
            else
            {
                //nokta dışında başka bir karakter var ise engelle 
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            if (txtTcKimlik.Text !="" && txtAd.Text !="" && txtSoyad.Text !="" && txtDogumTarihi.Text !="" && txtMail.Text !="" && txtTelNo.Text !="")
            {
                // değişkenlere değer atama işlemleri.

                tc = txtTcKimlik.Text; 
                ad = txtAd.Text.ToUpper();
                soyad = txtSoyad.Text.ToUpper(); 
                dogumt=txtDogumTarihi.Text;
                tel = txtTelNo.Text;
                mail = txtMail.Text;
                aciklama = txtAciklama.Text;
                cinsiyet = lblCinsiyetKontrol.Text;


                // input <araçlar> kontrölü sağlandıktan sonra form açılma ya da çağırma işlemi yapılacaktır.
                frmKisiKayit2 frm = new frmKisiKayit2();
                frm.tc = tc;
                frm.ad = ad;
                frm.soyad = soyad;
                frm.dogumt = dogumt;
                frm.tel = tel;
                frm.mail = mail;
                frm.aciklama = aciklama;
                frm.cinsiyet = cinsiyet;
                frm.Show();
                this.Hide();
            }
            else
            {
                frmPopupmenu frm = new frmPopupmenu();
                frm.label1.Text = "Lütfen zorunlu alanları doldurunuz.";
                frm.Show();
            }

            
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            lblCinsiyetKontrol.Text = "0";
        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {
            lblCinsiyetKontrol.Text = "1";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAciklama.Text = "";
            txtAd.Text = "";
            txtDogumTarihi.Text = "";
            txtMail.Text = "";
            txtSoyad.Text = "";
            txtTcKimlik.Text = "";
            txtTelNo.Text = "";
            lblCinsiyetKontrol.Text = "0";
            rbErkek.Checked = true;
            rbKadin.Checked = false;
            txtTcKimlik.Focus();
        }

        private void txtTcKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled =!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar);
        }

        private void txtTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
