namespace CountryDinlenmeTesisleri
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            btnGirisYap = new Button();
            txtkullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.Transparent;
            lblKullaniciAdi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAdi.Location = new Point(184, 322);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(102, 20);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.Location = new Point(238, 359);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 20);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre :";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = SystemColors.AppWorkspace;
            btnGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(315, 420);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(101, 57);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtkullaniciAdi
            // 
            txtkullaniciAdi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtkullaniciAdi.Location = new Point(297, 315);
            txtkullaniciAdi.Name = "txtkullaniciAdi";
            txtkullaniciAdi.Size = new Size(153, 27);
            txtkullaniciAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSifre.Location = new Point(297, 352);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(153, 27);
            txtSifre.TabIndex = 4;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(754, 516);
            Controls.Add(pictureBox1);
            Controls.Add(txtSifre);
            Controls.Add(txtkullaniciAdi);
            Controls.Add(btnGirisYap);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Name = "FrmAdminGiris";
            Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private Label lblSifre;
        private Button btnGirisYap;
        private TextBox txtkullaniciAdi;
        private TextBox txtSifre;
        private PictureBox pictureBox1;
    }
}