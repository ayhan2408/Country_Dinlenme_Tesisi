namespace CountryTatilKöyü
{
    partial class FrmMusteriler
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            BtnVerileriGoster = new Button();
            BtnAra = new Button();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            label11 = new Label();
            CbbCinsiyet = new ComboBox();
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
            txtAra = new TextBox();
            label10 = new Label();
            BtnTemizle = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveBorder;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(-1, 297);
            listView1.Name = "listView1";
            listView1.Size = new Size(967, 194);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Oda Numarası";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "G. Tarihi";
            columnHeader10.Width = 110;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Ç.Tarihi";
            columnHeader11.Width = 110;
            // 
            // BtnVerileriGoster
            // 
            BtnVerileriGoster.BackColor = SystemColors.ButtonFace;
            BtnVerileriGoster.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerileriGoster.Location = new Point(793, 12);
            BtnVerileriGoster.Name = "BtnVerileriGoster";
            BtnVerileriGoster.Size = new Size(161, 41);
            BtnVerileriGoster.TabIndex = 1;
            BtnVerileriGoster.Text = "Verileri Göster";
            BtnVerileriGoster.UseVisualStyleBackColor = false;
            BtnVerileriGoster.Click += btnVerileriGoster_Click;
            // 
            // BtnAra
            // 
            BtnAra.BackColor = SystemColors.ButtonFace;
            BtnAra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAra.Location = new Point(793, 217);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(161, 41);
            BtnAra.TabIndex = 2;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = false;
            BtnAra.Click += BtnAra_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = SystemColors.ButtonFace;
            BtnSil.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSil.Location = new Point(793, 118);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(161, 41);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = SystemColors.ButtonFace;
            BtnGuncelle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(793, 65);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(161, 41);
            BtnGuncelle.TabIndex = 4;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(52, 91);
            label11.Name = "label11";
            label11.Size = new Size(75, 21);
            label11.TabIndex = 42;
            label11.Text = "Cinsiyet :";
            // 
            // CbbCinsiyet
            // 
            CbbCinsiyet.FormattingEnabled = true;
            CbbCinsiyet.Items.AddRange(new object[] { "Bay", "Bayan" });
            CbbCinsiyet.Location = new Point(133, 89);
            CbbCinsiyet.Name = "CbbCinsiyet";
            CbbCinsiyet.Size = new Size(200, 23);
            CbbCinsiyet.TabIndex = 41;
            // 
            // dtpCıkıs
            // 
            dtpCıkıs.Location = new Point(457, 145);
            dtpCıkıs.Name = "dtpCıkıs";
            dtpCıkıs.Size = new Size(200, 23);
            dtpCıkıs.TabIndex = 40;
            // 
            // dtpGiris
            // 
            dtpGiris.Location = new Point(457, 109);
            dtpGiris.Name = "dtpGiris";
            dtpGiris.Size = new Size(200, 23);
            dtpGiris.TabIndex = 39;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.Info;
            txtSoyad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoyad.Location = new Point(133, 57);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 38;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.BackColor = SystemColors.Info;
            txtTcKimlikNo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTcKimlikNo.Location = new Point(133, 147);
            txtTcKimlikNo.MaxLength = 11;
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(200, 27);
            txtTcKimlikNo.TabIndex = 37;
            // 
            // txtOdaNumarası
            // 
            txtOdaNumarası.BackColor = SystemColors.Info;
            txtOdaNumarası.Enabled = false;
            txtOdaNumarası.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtOdaNumarası.Location = new Point(133, 183);
            txtOdaNumarası.Name = "txtOdaNumarası";
            txtOdaNumarası.Size = new Size(200, 27);
            txtOdaNumarası.TabIndex = 36;
            // 
            // txtMail
            // 
            txtMail.BackColor = SystemColors.Info;
            txtMail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMail.Location = new Point(457, 65);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(200, 27);
            txtMail.TabIndex = 35;
            // 
            // txtUcret
            // 
            txtUcret.BackColor = SystemColors.Info;
            txtUcret.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUcret.Location = new Point(457, 26);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(200, 27);
            txtUcret.TabIndex = 34;
            // 
            // mtbTelefon
            // 
            mtbTelefon.BackColor = SystemColors.Info;
            mtbTelefon.Location = new Point(133, 118);
            mtbTelefon.Mask = "(999) 000-0000";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(200, 23);
            mtbTelefon.TabIndex = 33;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Info;
            txtAd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAd.Location = new Point(133, 26);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(64, 63);
            label9.Name = "label9";
            label9.Size = new Size(63, 21);
            label9.TabIndex = 31;
            label9.Text = "Soyad :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(55, 120);
            label8.Name = "label8";
            label8.Size = new Size(72, 21);
            label8.TabIndex = 30;
            label8.Text = "Telefon :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(11, 153);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 29;
            label7.Text = "T.C Kimlik NO :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 185);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 28;
            label6.Text = "Oda Numarası :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(393, 32);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 27;
            label5.Text = "Ücret :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(402, 71);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 26;
            label4.Text = "Mail :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(359, 110);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 25;
            label3.Text = "Giriş Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(358, 147);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 24;
            label2.Text = "Çıkış Tarihi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 23;
            label1.Text = "Ad :";
            // 
            // txtAra
            // 
            txtAra.BackColor = SystemColors.Info;
            txtAra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAra.Location = new Point(754, 264);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(200, 27);
            txtAra.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(700, 270);
            label10.Name = "label10";
            label10.Size = new Size(48, 21);
            label10.TabIndex = 43;
            label10.Text = "İsim :";
            // 
            // BtnTemizle
            // 
            BtnTemizle.BackColor = SystemColors.ButtonFace;
            BtnTemizle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTemizle.Location = new Point(793, 170);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(161, 41);
            BtnTemizle.TabIndex = 45;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = false;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Silver;
            ClientSize = new Size(966, 489);
            Controls.Add(BtnTemizle);
            Controls.Add(txtAra);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(CbbCinsiyet);
            Controls.Add(dtpCıkıs);
            Controls.Add(dtpGiris);
            Controls.Add(txtSoyad);
            Controls.Add(txtTcKimlikNo);
            Controls.Add(txtOdaNumarası);
            Controls.Add(txtMail);
            Controls.Add(txtUcret);
            Controls.Add(mtbTelefon);
            Controls.Add(txtAd);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnAra);
            Controls.Add(BtnVerileriGoster);
            Controls.Add(listView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMusteriler";
            Text = "Müsteri Bilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button BtnVerileriGoster;
        private Button BtnAra;
        private Button BtnSil;
        private Button BtnGuncelle;
        private Label label11;
        private ComboBox CbbCinsiyet;
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
        private TextBox txtAra;
        private Label label10;
        private Button BtnTemizle;
    }
}