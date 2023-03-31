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
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmGiris : Form
    {
        public string Email { get; set; } // kay�t ol formunda kay�t olan kullan�c�n�n emaili buraya gelsin

        AkbildbContext context = new AkbildbContext();

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
            checkBoxHatirla.Checked = false;
            if (Properties.Akbil.Default.BeniHatirla)
            {
                txtEmail.Text = Properties.Akbil.Default.BeniHatirlaKullaniciEmail;
                txtSifre.Text = Properties.Akbil.Default.BeniHatirlaKullaniciSifre;
                checkBoxHatirla.Checked = true;
            }
            

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
               var kullanici= context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text && x.Parola == GenelIslemler.MD5Encryption(txtSifre.Text));
                if (kullanici==null)
                {
                    MessageBox.Show("EMA�L ya da ��FRE'nizi yanl�� girdiniz !");
                    return;
                }
                else
                {
                    MessageBox.Show($"HO�GELD�N�Z ...{kullanici.Ad} {kullanici.Soyad}");
                    GenelIslemler.GirisYapanKullaniciID = kullanici.Id;
                    GenelIslemler.GirisYapanKullaniciEmail = kullanici.Email;
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{kullanici.Ad} {kullanici.Soyad}";

                    if (checkBoxHatirla.Checked)
                    {
                        BeniHatirlaAyarla();
                    }


                    txtEmail.Clear(); txtSifre.Clear();
                    FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
                    this.Hide();
                    frmAnasayfa.Show();
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
            if (checkBoxHatirla.Checked)
            {
                Properties.Akbil.Default.BeniHatirla = true;
                Properties.Akbil.Default.Save();

            }
            else
            {
                Properties.Akbil.Default.BeniHatirla = false;
                Properties.Akbil.Default.Save();


            }

        }

        private void BeniHatirlaAyarla()
        {
            Properties.Akbil.Default.BeniHatirlaKullaniciEmail = txtEmail.Text.Trim();
            Properties.Akbil.Default.BeniHatirlaKullaniciSifre = txtSifre.Text.Trim();
            Properties.Akbil.Default.Save();
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