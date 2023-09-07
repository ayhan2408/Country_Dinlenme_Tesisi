using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CountryDinlenmeTesisleri
{
    public partial class FrmYeniMusteriEkle : Form
    {
        public FrmYeniMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MH4E4IE\\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");



        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "101";
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "105";
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "106";
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "107";
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "108";
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "109";
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sarı Olanlar Boş Odaları Göstermektedir.");
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Olanlar Malasef Şuan Doludur.");
        }

        private void dtpCıkıs_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCıkıs.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label10.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label10.Text) * 260;
            txtUcret.Text = Ucret.ToString();
        }


        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" insert into YeniMusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CıkısTarihi) values('" + txtAd.Text + "' ,'" + txtSoyad.Text + "','" + CbbCinsiyet.Text + "','" + mtbTelefon.Text + "','" + txtMail.Text + "','" + txtTcKimlikNo.Text + "','" + txtOdaNumarası.Text + "','" + txtUcret.Text + "','" + dtpGiris.Value.ToString("yyyy-MM-dd") + "','" + dtpCıkıs.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand(" insert into OdalarSon (OdaNumarasi) values('" + txtOdaNumarası.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı. ");

        }

        private void FrmYeniMusteriEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT OdaNumarasi FROM OdalarSon WHERE OdaNumarasi BETWEEN '101' AND '109'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string odaNo = oku["OdaNumarasi"].ToString();
                Button button = Controls.Find("btn" + odaNo, true).FirstOrDefault() as Button;

                if (button != null)
                {
                    button.Text = "DOLU";
                    button.Enabled = false;
                    button.BackColor = Color.Red;
                }
            }
            baglanti.Close();
        }   
    }
}
