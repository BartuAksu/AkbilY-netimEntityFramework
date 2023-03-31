namespace AkbilYonetimiUI
{
    partial class FrmAkbiller
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
            menuStrip1 = new MenuStrip();
            aNASAYFAToolStripMenuItem = new ToolStripMenuItem();
            cikisYAPToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnKaydet = new Button();
            cmbBoxAkbilTipleri = new ComboBox();
            maskedTextBoxAkbilNo = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewAkbiller = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aNASAYFAToolStripMenuItem, cikisYAPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(473, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            aNASAYFAToolStripMenuItem.Size = new Size(83, 20);
            aNASAYFAToolStripMenuItem.Text = "ANA SAYFA";
            aNASAYFAToolStripMenuItem.Click += aNASAYFAToolStripMenuItem_Click;
            // 
            // cikisYAPToolStripMenuItem
            // 
            cikisYAPToolStripMenuItem.Name = "cikisYAPToolStripMenuItem";
            cikisYAPToolStripMenuItem.Size = new Size(78, 20);
            cikisYAPToolStripMenuItem.Text = "ÇIKIŞ YAP";
            
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(cmbBoxAkbilTipleri);
            groupBox1.Controls.Add(maskedTextBoxAkbilNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(305, 16);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 78);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "YENİ AKBİL KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbBoxAkbilTipleri
            // 
            cmbBoxAkbilTipleri.FormattingEnabled = true;
            cmbBoxAkbilTipleri.Items.AddRange(new object[] { "Öğrenci Akbili", "Tam Akbil", "Anne Kartı", "65+ Kart", "Öğretmen Kart" });
            cmbBoxAkbilTipleri.Location = new Point(68, 51);
            cmbBoxAkbilTipleri.Name = "cmbBoxAkbilTipleri";
            cmbBoxAkbilTipleri.Size = new Size(220, 23);
            cmbBoxAkbilTipleri.TabIndex = 3;
            // 
            // maskedTextBoxAkbilNo
            // 
            maskedTextBoxAkbilNo.Location = new Point(67, 22);
            maskedTextBoxAkbilNo.Mask = "0000000000000000";
            maskedTextBoxAkbilNo.Name = "maskedTextBoxAkbilNo";
            maskedTextBoxAkbilNo.Size = new Size(221, 21);
            maskedTextBoxAkbilNo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 54);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Akbil Tip :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Akbil No :";
            // 
            // dataGridViewAkbiller
            // 
            dataGridViewAkbiller.AllowUserToAddRows = false;
            dataGridViewAkbiller.AllowUserToDeleteRows = false;
            dataGridViewAkbiller.AllowUserToOrderColumns = true;
            dataGridViewAkbiller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAkbiller.Location = new Point(12, 138);
            dataGridViewAkbiller.Name = "dataGridViewAkbiller";
            dataGridViewAkbiller.ReadOnly = true;
            dataGridViewAkbiller.RowTemplate.Height = 25;
            dataGridViewAkbiller.Size = new Size(413, 140);
            dataGridViewAkbiller.TabIndex = 2;
            // 
            // FrmAkbiller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istanbul_is_the_8th_most_popular_city_main;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(473, 296);
            Controls.Add(dataGridViewAkbiller);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmAkbiller";
            Text = "Akbil Kaydet";
            Load += FrmAkbiller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private ToolStripMenuItem cikisYAPToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private ComboBox cmbBoxAkbilTipleri;
        private MaskedTextBox maskedTextBoxAkbilNo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAkbiller;
    }
}