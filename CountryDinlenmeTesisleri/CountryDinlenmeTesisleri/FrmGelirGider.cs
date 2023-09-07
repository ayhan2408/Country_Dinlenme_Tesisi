using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CountryTatilKöyü
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti5 = new SqlConnection("Data Source=DESKTOP-MH4E4IE\\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            lblMaas.Text = (personel * 8500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt32(lblMaas.Text) + Convert.ToInt32(lblUrun1.Text) + Convert.ToInt32(lblUrun2.Text) + Convert.ToInt32(lblUrun3.Text) + Convert.ToInt32(lblfaturalar1.Text) + Convert.ToInt32(lblFaturalar2.Text) + Convert.ToInt32(lblFaturalar3.Text));
            lblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglanti5.Open();
            //burda Ucret tabloda varchar olarak kayıtlı oldugu icin ilk once int turune cevirdik sonra sı kolay oldu zaten.//
            SqlCommand komut = new SqlCommand("Select sum (Convert(int,Ucret)) as toplam from YeniMusteriEkle", baglanti5);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();
            }

            baglanti5.Close();

            //Gıda Giderleri
            baglanti5.Open();
            SqlCommand komut2 = new SqlCommand("Select sum (Gida) as toplam1 from Stoklar", baglanti5);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblUrun1.Text = oku2["toplam1"].ToString();
            }

            baglanti5.Close();


            //İcecek Giderleri
            baglanti5.Open();
            SqlCommand komut3 = new SqlCommand("Select sum (İcecekler) as toplam2 from Stoklar", baglanti5);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblUrun2.Text = oku3["toplam2"].ToString();
            }

            baglanti5.Close();


            //Atistirmalik Giderleri
            baglanti5.Open();
            SqlCommand komut4 = new SqlCommand("Select sum (Atistirmaliklar) as toplam3 from Stoklar", baglanti5);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblUrun3.Text = oku4["toplam3"].ToString();
            }

            baglanti5.Close();


            //Elektrik Faturası
            baglanti5.Open();
            SqlCommand komut5 = new SqlCommand("Select sum (Elektrik) as toplam4 from Faturalar", baglanti5);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblfaturalar1.Text = oku5["toplam4"].ToString();
            }

            baglanti5.Close();

            //Su Faturaları
            baglanti5.Open();
            SqlCommand komut6 = new SqlCommand("Select sum (Su) as toplam5 from Faturalar", baglanti5);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturalar2.Text = oku6["toplam5"].ToString();
            }

            baglanti5.Close();

            //İnternet Faturaları
            baglanti5.Open();
            SqlCommand komut7 = new SqlCommand("Select sum (İnternet) as toplam6 from Faturalar", baglanti5);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFaturalar3.Text = oku7["toplam6"].ToString();
            }

            baglanti5.Close();




        }
    }
}
