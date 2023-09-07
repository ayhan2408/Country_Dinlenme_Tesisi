namespace CountryDinlenmeTesisleri
{
    partial class FrmYeniMusteriEkle
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
            groupBox1 = new GroupBox();
            label11 = new Label();
            CbbCinsiyet = new ComboBox();
            label10 = new Label();
            btnKayıtOl = new Button();
            dtpCıkıs = new DateTimePicker();
            dtpGiris = new DateTimePicker();
            txtSoyad = new TextBox();
            txtTcKimlikNo = new TextBox();
            txtOdaNumarası = new TextBox();
            txtMail = new TextBox();
            txtUcret = new TextBox();
            mtbTelefon = new MaskedTextBox();
            txtAd = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn109 = new Button();
            btn102 = new Button();
            btn103 = new Button();
            btn104 = new Button();
            btn105 = new Button();
            btn106 = new Button();
            btn107 = new Button();
            btn108 = new Button();
            btn101 = new Button();
            btnDolu = new Button();
            btnBos = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(CbbCinsiyet);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnKayıtOl);
            groupBox1.Controls.Add(dtpCıkıs);
            groupBox1.Controls.Add(dtpGiris);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtTcKimlikNo);
            groupBox1.Controls.Add(txtOdaNumarası);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtUcret);
            groupBox1.Controls.Add(mtbTelefon);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 481);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Kullanıcı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(59, 87);
            label11.Name = "label11";
            label11.Size = new Size(75, 21);
            label11.TabIndex = 22;
            label11.Text = "Cinsiyet :";
            // 
            // CbbCinsiyet
            // 
            CbbCinsiyet.FormattingEnabled = true;
            CbbCinsiyet.Items.AddRange(new object[] { "Bay", "Bayan" });
            CbbCinsiyet.Location = new Point(140, 85);
            CbbCinsiyet.Name = "CbbCinsiyet";
            CbbCinsiyet.Size = new Size(200, 23);
            CbbCinsiyet.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(307, 392);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 20;
            label10.Text = "0";
            label10.Visible = false;
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.BackColor = SystemColors.Control;
            btnKayıtOl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKayıtOl.Location = new Point(129, 392);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(112, 57);
            btnKayıtOl.TabIndex = 19;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = false;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // dtpCıkıs
            // 
            dtpCıkıs.Location = new Point(140, 336);
            dtpCıkıs.Name = "dtpCıkıs";
            dtpCıkıs.Size = new Size(200, 23);
            dtpCıkıs.TabIndex = 18;
            dtpCıkıs.ValueChanged += dtpCıkıs_ValueChanged;
            // 
            // dtpGiris
            // 
            dtpGiris.Location = new Point(140, 300);
            dtpGiris.Name = "dtpGiris";
            dtpGiris.Size = new Size(200, 23);
            dtpGiris.TabIndex = 17;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Info;
            txtSoyad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyad.Location = new Point(140, 53);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 16;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.BackColor = SystemColors.Info;
            txtTcKimlikNo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTcKimlikNo.Location = new Point(140, 143);
            txtTcKimlikNo.MaxLength = 11;
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(200, 27);
            txtTcKimlikNo.TabIndex = 15;
            // 
            // txtOdaNumarası
            // 
            txtOdaNumarası.BackColor = SystemColors.Info;
            txtOdaNumarası.Enabled = false;
            txtOdaNumarası.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtOdaNumarası.Location = new Point(140, 179);
            txtOdaNumarası.Name = "txtOdaNumarası";
            txtOdaNumarası.Size = new Size(200, 27);
            txtOdaNumarası.TabIndex = 14;
            // 
            // txtMail
            // 
            txtMail.BackColor = SystemColors.Info;
            txtMail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMail.Location = new Point(140, 256);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(200, 27);
            txtMail.TabIndex = 13;
            // 
            // txtUcret
            // 
            txtUcret.BackColor = SystemColors.Info;
            txtUcret.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUcret.Location = new Point(140, 217);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(200, 27);
            txtUcret.TabIndex = 12;
            // 
            // mtbTelefon
            // 
            mtbTelefon.BackColor = SystemColors.Info;
            mtbTelefon.Location = new Point(140, 114);
            mtbTelefon.Mask = "(999) 000-0000";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(200, 23);
            mtbTelefon.TabIndex = 11;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Info;
            txtAd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAd.Location = new Point(140, 22);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(71, 59);
            label9.Name = "label9";
            label9.Size = new Size(63, 21);
            label9.TabIndex = 8;
            label9.Text = "Soyad :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(62, 116);
            label8.Name = "label8";
            label8.Size = new Size(72, 21);
            label8.TabIndex = 7;
            label8.Text = "Telefon :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 149);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 6;
            label7.Text = "T.C Kimlik NO :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 181);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 5;
            label6.Text = "Oda Numarası :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(76, 223);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 4;
            label5.Text = "Ücret :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 262);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 3;
            label4.Text = "Mail :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 301);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 2;
            label3.Text = "Giriş Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 338);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "Çıkış Tarihi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn109);
            groupBox2.Controls.Add(btn102);
            groupBox2.Controls.Add(btn103);
            groupBox2.Controls.Add(btn104);
            groupBox2.Controls.Add(btn105);
            groupBox2.Controls.Add(btn106);
            groupBox2.Controls.Add(btn107);
            groupBox2.Controls.Add(btn108);
            groupBox2.Controls.Add(btn101);
            groupBox2.Location = new Point(417, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odalar";
            // 
            // btn109
            // 
            btn109.BackColor = Color.FromArgb(255, 255, 128);
            btn109.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn109.Location = new Point(258, 231);
            btn109.Name = "btn109";
            btn109.Size = new Size(76, 55);
            btn109.TabIndex = 8;
            btn109.Text = "109";
            btn109.UseVisualStyleBackColor = false;
            btn109.Click += btn109_Click;
            // 
            // btn102
            // 
            btn102.BackColor = Color.FromArgb(255, 255, 128);
            btn102.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn102.Location = new Point(149, 35);
            btn102.Name = "btn102";
            btn102.Size = new Size(76, 55);
            btn102.TabIndex = 7;
            btn102.Text = "102";
            btn102.UseVisualStyleBackColor = false;
            btn102.Click += btn102_Click;
            // 
            // btn103
            // 
            btn103.BackColor = Color.FromArgb(255, 255, 128);
            btn103.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn103.Location = new Point(258, 35);
            btn103.Name = "btn103";
            btn103.Size = new Size(76, 55);
            btn103.TabIndex = 6;
            btn103.Text = "103";
            btn103.UseVisualStyleBackColor = false;
            btn103.Click += btn103_Click;
            // 
            // btn104
            // 
            btn104.BackColor = Color.FromArgb(255, 255, 128);
            btn104.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn104.Location = new Point(38, 133);
            btn104.Name = "btn104";
            btn104.Size = new Size(76, 55);
            btn104.TabIndex = 5;
            btn104.Text = "104";
            btn104.UseVisualStyleBackColor = false;
            btn104.Click += btn104_Click;
            // 
            // btn105
            // 
            btn105.BackColor = Color.FromArgb(255, 255, 128);
            btn105.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn105.Location = new Point(149, 133);
            btn105.Name = "btn105";
            btn105.Size = new Size(76, 55);
            btn105.TabIndex = 4;
            btn105.Text = "105";
            btn105.UseVisualStyleBackColor = false;
            btn105.Click += btn105_Click;
            // 
            // btn106
            // 
            btn106.BackColor = Color.FromArgb(255, 255, 128);
            btn106.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn106.Location = new Point(258, 133);
            btn106.Name = "btn106";
            btn106.Size = new Size(76, 55);
            btn106.TabIndex = 3;
            btn106.Text = "106";
            btn106.UseVisualStyleBackColor = false;
            btn106.Click += btn106_Click;
            // 
            // btn107
            // 
            btn107.BackColor = Color.FromArgb(255, 255, 128);
            btn107.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn107.Location = new Point(38, 235);
            btn107.Name = "btn107";
            btn107.Size = new Size(76, 55);
            btn107.TabIndex = 2;
            btn107.Text = "107";
            btn107.UseVisualStyleBackColor = false;
            btn107.Click += btn107_Click;
            // 
            // btn108
            // 
            btn108.BackColor = Color.FromArgb(255, 255, 128);
            btn108.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn108.Location = new Point(149, 235);
            btn108.Name = "btn108";
            btn108.Size = new Size(76, 55);
            btn108.TabIndex = 1;
            btn108.Text = "108";
            btn108.UseVisualStyleBackColor = false;
            btn108.Click += btn108_Click;
            // 
            // btn101
            // 
            btn101.BackColor = Color.FromArgb(255, 255, 128);
            btn101.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn101.Location = new Point(38, 35);
            btn101.Name = "btn101";
            btn101.Size = new Size(76, 55);
            btn101.TabIndex = 0;
            btn101.Text = "101";
            btn101.UseVisualStyleBackColor = false;
            btn101.Click += btn101_Click;
            // 
            // btnDolu
            // 
            btnDolu.BackColor = Color.Red;
            btnDolu.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnDolu.Location = new Point(689, 452);
            btnDolu.Name = "btnDolu";
            btnDolu.Size = new Size(75, 39);
            btnDolu.TabIndex = 9;
            btnDolu.Text = "DOLU";
            btnDolu.UseVisualStyleBackColor = false;
            btnDolu.Click += btnDolu_Click;
            // 
            // btnBos
            // 
            btnBos.BackColor = Color.FromArgb(255, 255, 128);
            btnBos.Font = new Font("Impact", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnBos.Location = new Point(689, 398);
            btnBos.Name = "btnBos";
            btnBos.Size = new Size(76, 39);
            btnBos.TabIndex = 10;
            btnBos.Text = "BOŞ";
            btnBos.UseVisualStyleBackColor = false;
            btnBos.Click += btnBos_Click;
            // 
            // FrmYeniMusteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(830, 543);
            Controls.Add(btnDolu);
            Controls.Add(btnBos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmYeniMusteriEkle";
            Text = "Müsteri Ekleme";
            Load += FrmYeniMusteriEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnKayıtOl;
        private DateTimePicker dtpCıkıs;
        private DateTimePicker dtpGiris;
        private TextBox txtSoyad;
        private TextBox txtTcKimlikNo;
        private TextBox txtOdaNumarası;
        private TextBox txtMail;
        private TextBox txtUcret;
        private MaskedTextBox mtbTelefon;
        private TextBox txtAd;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn109;
        private Button btn102;
        private Button btn103;
        private Button btn104;
        private Button btn105;
        private Button btn106;
        private Button btn107;
        private Button btn108;
        private Button btn101;
        private Button btnDolu;
        private Button btnBos;
        private Label label10;
        private Label label11;
        private ComboBox CbbCinsiyet;
    }
}