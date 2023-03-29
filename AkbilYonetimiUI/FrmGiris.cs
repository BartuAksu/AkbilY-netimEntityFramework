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
        public string Email { get; set; } // kayýt ol formunda kayýt olan kullanýcýnýn emaili buraya gelsin
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

            //Beni Hatýrlayý Properties.Settings ile yapana kadar burasý böyle kolaylýk saðlasýn.
            txtEmail.Text = "bartuaksu955@gmail.com";
            txtSifre.Text = "123123";

        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Bu formu gizleyeceðiz.
            //Kayýt Ol formunu açacaðýz
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
                //1) Email ve þifre textboxlarý dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //2) Girdiði email ve þifre veritabanýnda mevcut mu?
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
                    MessageBox.Show("Email ya da þifre yanlýþ! Tekrar dene! ");
                }
                else
                {
                    GenelIslemler.GirisYapanKullaniciID = (int)sonuc["Id"];
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{sonuc["Ad"]} {sonuc["Soyad"]}";
                    MessageBox.Show($"Hoþgeldiniz... {GenelIslemler.GirisYapanKullaniciAdSoyad}");

                    //BENÝ HATIRLA yazýlacak
                    this.Hide();
                    FrmAnasayfa frmanasayfa = new FrmAnasayfa();
                    frmanasayfa.Show();

                }
            }
            catch (Exception hata)
            {
                //DipNot: exceptionlar asla kullanýcýya gösterilmez.
                //Exceptionlar loglanýr. Biz þuan öðrenme/geliþtirme aþamasýnda olduðýumuz için yazdýk

                MessageBox.Show("Beklenmedik bir sorun oluþtu! " + hata.Message);

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
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) // basýlan tuþ enter ise giriþ yapacak
            {
                GirisYap();
            }
        }
    }
}