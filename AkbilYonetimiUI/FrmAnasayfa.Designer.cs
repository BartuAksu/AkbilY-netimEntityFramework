namespace AkbilYonetimiUI
{
    partial class FrmAnasayfa
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
            btnAkbil = new Button();
            btnTalimat = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnAkbil
            // 
            btnAkbil.BackColor = Color.Turquoise;
            btnAkbil.Location = new Point(27, 32);
            btnAkbil.Name = "btnAkbil";
            btnAkbil.Size = new Size(216, 51);
            btnAkbil.TabIndex = 0;
            btnAkbil.Text = "AKBİL İŞLEMLERİ";
            btnAkbil.UseVisualStyleBackColor = false;
            btnAkbil.Click += btnAkbil_Click;
            // 
            // btnTalimat
            // 
            btnTalimat.BackColor = Color.Turquoise;
            btnTalimat.Location = new Point(27, 102);
            btnTalimat.Name = "btnTalimat";
            btnTalimat.Size = new Size(216, 51);
            btnTalimat.TabIndex = 1;
            btnTalimat.Text = "TALİMAT İŞLEMLERİ";
            btnTalimat.UseVisualStyleBackColor = false;
            btnTalimat.Click += btnTalimat_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.Turquoise;
            btnAyarlar.Location = new Point(27, 175);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(216, 51);
            btnAyarlar.TabIndex = 2;
            btnAyarlar.Text = "AYARLAR";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += button3_Click;
            // 
            // FrmAnasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(274, 251);
            Controls.Add(btnAyarlar);
            Controls.Add(btnTalimat);
            Controls.Add(btnAkbil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FrmAnasayfa";
            Text = "ANASAYFA";
            FormClosed += FrmAnasayfa_FormClosed;
            Load += FrmAnasayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAkbil;
        private Button btnTalimat;
        private Button btnAyarlar;
    }
}