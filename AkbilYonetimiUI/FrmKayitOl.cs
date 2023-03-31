
using AkbilYonetimiVeriKatmani.Models;
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
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmKayitOl : Form
    {
        AkbildbContext context = new AkbildbContext();
       
        public FrmKayitOl()
        {
            InitializeComponent(); // İnşa etmek
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            #region Ayarlar
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;

            #endregion
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                btnKayitOl.Enabled = false;
                btnGirisYap.Enabled = false;
                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("Zorunlu alanları doldurunuz!");
                        btnKayitOl.Enabled = true;
                        btnGirisYap.Enabled = true;
                        return;
                    }
                }
                if (context.Kullanicilars.FirstOrDefault(x=>x.Email==txtEmail.Text.Trim())!=null)
                {
                    MessageBox.Show("Bu Emaille Sistemde Kayıt Mevcuttur!");
                    btnKayitOl.Enabled = true;
                    btnGirisYap.Enabled = true;
                    return;
                }
                Kullanicilar yeniKullanici = new Kullanicilar()
                { 
                    EklenmeTarihi=DateTime.Now,
                    Ad=txtIsim.Text.Trim(),
                    Soyad=txtSoyisim.Text.Trim(),
                    DogumTarihi=dtpDogumTarihi.Value,
                    Email=txtEmail.Text.Trim(),
                    Parola=GenelIslemler.MD5Encryption(txtSifre.Text.Trim())

                
                };
                context.Kullanicilars.Add(yeniKullanici);
                if (context.SaveChanges()>0)
                {
                    MessageBox.Show("Kullanici Eklendi!");
                    foreach (var item in Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();
                        }
                        if (item is DateTimePicker)
                        {
                            ((DateTimePicker)item).Value = ((DateTimePicker)item).MaxDate;
                        }
                    }
                    var cevap= MessageBox.Show("Giriş Sayfasın Gitmek İstermisiniz?","SORU",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if ((int)cevap==6)
                    {
                        FrmGiris frgm = new FrmGiris();
                        frgm.Email = txtEmail.Text.Trim();
                        this.Hide();
                        frgm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanici Ekleme Başarısız Oldu!");
                }
                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;


            }
            catch (Exception ex)
            {
                // ex log.txt'ye yazılanacak (loglama)
                MessageBox.Show("Beklenmedik bir hata oluştu! Lütfen tekrar deneyiniz !");
            }
        }

        private void GirisFormunaGit()
        {
            FrmGiris frmG = new FrmGiris();
            frmG.Email = txtEmail.Text.Trim();
            this.Hide();
            frmG.Show();
        }

        private void FrmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormunaGit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisFormunaGit();
        }
    }
}
