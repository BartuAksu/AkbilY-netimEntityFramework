namespace AkbilYonetimiUI
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBoxGiris = new GroupBox();
            btnKayitOl = new Button();
            checkBoxHatirla = new CheckBox();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpBoxGiris.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxGiris
            // 
            grpBoxGiris.BackColor = Color.Transparent;
            grpBoxGiris.Controls.Add(btnKayitOl);
            grpBoxGiris.Controls.Add(checkBoxHatirla);
            grpBoxGiris.Controls.Add(btnGirisYap);
            grpBoxGiris.Controls.Add(txtSifre);
            grpBoxGiris.Controls.Add(txtEmail);
            grpBoxGiris.Controls.Add(label2);
            grpBoxGiris.Controls.Add(label1);
            grpBoxGiris.Location = new Point(-1, 12);
            grpBoxGiris.Name = "grpBoxGiris";
            grpBoxGiris.Size = new Size(239, 191);
            grpBoxGiris.TabIndex = 0;
            grpBoxGiris.TabStop = false;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Turquoise;
            btnKayitOl.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(6, 151);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(197, 39);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(72, 81);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(98, 19);
            checkBoxHatirla.TabIndex = 4;
            checkBoxHatirla.Text = "Beni Hatırla!";
            checkBoxHatirla.UseVisualStyleBackColor = true;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Turquoise;
            btnGirisYap.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(6, 106);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(197, 39);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.Location = new Point(72, 44);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(161, 22);
            txtSifre.TabIndex = 3;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(72, 18);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 22);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istanbul_is_the_8th_most_popular_city_03;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(423, 337);
            Controls.Add(grpBoxGiris);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmGiris";
            Text = "HOŞGELDİNİZ...";
            Load += FrmGiris_Load;
            grpBoxGiris.ResumeLayout(false);
            grpBoxGiris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxGiris;
        private Button btnGirisYap;
        private Button btnKayitOl;
        private CheckBox checkBoxHatirla;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}