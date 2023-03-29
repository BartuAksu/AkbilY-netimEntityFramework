using AkbilYntmIsKatmani;
using AkbilYntmVeriKatmani;
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

namespace AkbilYonetimiUI
{
    public partial class FrmKayitOl : Form
    {
        IVeriTabaniIslemleri veriTabaniIslemleri = new SQLVeriTabaniIslemleri(GenelIslemler.SinifSQLBaglantiCumlesi);
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
                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("Zorunlu alanları doldurunuz!");
                        return;
                    }
                }
                Dictionary<string, object> kolonlar = new Dictionary<string, object>();
                kolonlar.Add("Ad", $"'{txtIsim.Text.ToUpper().Trim()}'");
                kolonlar.Add("Soyad", $"'{txtSoyisim.Text.ToUpper().Trim()}'");
                kolonlar.Add("Email", $"'{txtEmail.Text.Trim()}'");
                kolonlar.Add("EklenmeTarihi", $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'");
                kolonlar.Add("DogumTarihi", $"'{dtpDogumTarihi.Value.ToString("yyyyMMdd")}'");
                kolonlar.Add("Parola", $"'{GenelIslemler.MD5Encryption(txtSifre.Text.Trim())}'");


                string insertCumle = veriTabaniIslemleri.VeriEklemeCumlesiOlustur("Kullanicilar", kolonlar);
                int sonuc = veriTabaniIslemleri.KomutIsle(insertCumle);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt oluşturuldu");

                    DialogResult cevap = MessageBox.Show("Giriş sayfasına yönlendirmemizi ister misin?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        // temizklik

                        // Girişe git
                        FrmGiris frmg = new FrmGiris();
                        frmg.Email = txtEmail.Text.Trim();

                        foreach (Form item in Application.OpenForms)
                        {
                            item.Hide();
                        }
                        frmg.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt EKLENEMEDİ!");
                }
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
