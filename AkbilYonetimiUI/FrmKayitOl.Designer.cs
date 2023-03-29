using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AkbilYonetimiUI
{
    partial class FrmKayitOl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "D. Tarihi:";
            // 
            // txtIsim
            // 
            txtIsim.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtIsim.Location = new Point(76, 17);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(180, 21);
            txtIsim.TabIndex = 5;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyisim.Location = new Point(76, 46);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(180, 21);
            txtSoyisim.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(76, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 21);
            txtEmail.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.Location = new Point(76, 113);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(180, 21);
            txtSifre.TabIndex = 8;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(23, 200);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(261, 35);
            btnKayitOl.TabIndex = 10;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(23, 251);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(261, 33);
            btnGirisYap.TabIndex = 11;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDogumTarihi.Location = new Point(76, 155);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(180, 21);
            dtpDogumTarihi.TabIndex = 12;
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(296, 314);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(btnGirisYap);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyisim);
            Controls.Add(txtIsim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmKayitOl";
            Text = "KAYIT OL";
            FormClosed += FrmKayitOl_FormClosed;
            Load += FrmKayitOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIsim;
        private TextBox txtSoyisim;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button btnKayitOl;
        private Button btnGirisYap;
        private DateTimePicker dtpDogumTarihi;
    }
}