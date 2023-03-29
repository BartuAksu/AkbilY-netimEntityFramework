using AkbilYntmIsKatmani;
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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            KullanicininBilgileriniGetir();
        }

        private void KullanicininBilgileriniGetir()
        {
            try
            {
                //Not:Giriş yapmış kullanıcının bilgilerini select sorgusu yazacağız
                //Kullanıcı bilgisini alabilmek için burada 2 yöntem kullanabiliriz.
                //Static bir class açıp içinde GirisYapmisKullaiciEmail propertysi kullanılabilir
                //2.Yöntem olarak Properties settings içine kayıtlı email bilgisinden yararlanılabilir.



            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik hata oluştu! " + hata.Message);

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception hata)
            {

                MessageBox.Show("Güncelleme BAŞARISIZDIR !" + hata.Message);
            }
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Güle Güle.. \n Çıkış Yapıldı");
            GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            GenelIslemler.GirisYapanKullaniciID = 0;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name != "FrmGiris")
                {
                    item.Hide();
                }
            }
            Application.OpenForms["FrmGiris"].Show();
        }
    }
}
