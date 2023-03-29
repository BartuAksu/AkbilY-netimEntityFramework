using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkbilYntmIsKatmani;
using AkbilYntmVeriKatmani;

namespace AkbilYonetimiUI
{
    public partial class FrmGiris : Form
    {
        public string Email { get; set; } // kay�t ol formunda kay�t olan kullan�c�n�n emaili buraya gelsin
        IVeriTabaniIslemleri veriTabaniIslemleri = new SQLVeriTabaniIslemleri(GenelIslemler.SinifSQLBaglantiCumlesi);


        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            if (Email != null)
            {
                txtEmail.Text = Email;
            }

            txtEmail.TabIndex = 1;
            txtSifre.TabIndex = 2;
            checkBoxHatirla.TabIndex = 3;
            btnGirisYap.TabIndex = 4;
            btnKayitOl.TabIndex = 5;
            txtSifre.PasswordChar = '*';

            //Beni Hat�rlay� Properties.Settings ile yapana kadar buras� b�yle kolayl�k sa�las�n.
            txtEmail.Text = "bartuaksu955@gmail.com";
            txtSifre.Text = "123123";

        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Bu formu gizleyece�iz.
            //Kay�t Ol formunu a�aca��z
            this.Hide();
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            try
            {
                //1) Email ve �ifre textboxlar� dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //2) Girdi�i email ve �ifre veritaban�nda mevcut mu?
                //select * from Kullanicilar where Email='' and Sifre=''

                string[] istedigimKolonlar = new string[] { "Id", "Ad", "Soyad" };
                string kosullar = string.Empty;
                StringBuilder sb = new StringBuilder();
                sb.Append($"Email='{txtEmail.Text.Trim()}'");
                sb.Append(" and ");
                sb.Append($"Parola='{GenelIslemler.MD5Encryption(txtSifre.Text.Trim())}'");
                kosullar = sb.ToString();

                var sonuc = veriTabaniIslemleri.VeriOku("Kullanicilar", istedigimKolonlar, kosullar);

                if (sonuc.Count == 0)
                {
                    MessageBox.Show("Email ya da �ifre yanl��! Tekrar dene! ");
                }
                else
                {
                    GenelIslemler.GirisYapanKullaniciID = (int)sonuc["Id"];
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{sonuc["Ad"]} {sonuc["Soyad"]}";
                    MessageBox.Show($"Ho�geldiniz... {GenelIslemler.GirisYapanKullaniciAdSoyad}");

                    //BEN� HATIRLA yaz�lacak
                    this.Hide();
                    FrmAnasayfa frmanasayfa = new FrmAnasayfa();
                    frmanasayfa.Show();

                }
            }
            catch (Exception hata)
            {
                //DipNot: exceptionlar asla kullan�c�ya g�sterilmez.
                //Exceptionlar loglan�r. Biz �uan ��renme/geli�tirme a�amas�nda oldu��umuz i�in yazd�k

                MessageBox.Show("Beklenmedik bir sorun olu�tu! " + hata.Message);

            }
        }

        private void checkBoxHatirla_CheckedChanged(object sender, EventArgs e)
        {
            BeniHatirlaAyarla();

        }

        private void BeniHatirlaAyarla()
        {

        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) // bas�lan tu� enter ise giri� yapacak
            {
                GirisYap();
            }
        }
    }
}