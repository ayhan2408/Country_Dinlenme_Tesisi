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

namespace CountryTatilKöyü
{
    public partial class FrmMusteriler : Form
    {


        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti2 = new SqlConnection(@"Data Source=DESKTOP-MH4E4IE\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");


        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("select * from YeniMusteriEkle", baglanti2);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti2.Close();
        }
        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CbbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mtbTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTcKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNumarası.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCıkıs.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("delete from YeniMusteriEkle where Musteriid= (" + id + ")", baglanti2);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("delete from OdalarSon where OdaNumarasi= (" +txtOdaNumarası.Text+ ")", baglanti2);
            komut2.ExecuteNonQuery();
            baglanti2.Close();
            verilerigoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            CbbCinsiyet.Text = "";
            mtbTelefon.Clear();
            txtMail.Clear();
            txtTcKimlikNo.Clear();
            txtOdaNumarası.Clear();
            txtUcret.Clear();
            dtpGiris.Text = "";
            dtpCıkıs.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("update YeniMusteriEkle set Adi='" + txtAd.Text + "' ,Soyadi='" + txtSoyad.Text + "' ,Cinsiyet='" + CbbCinsiyet.Text + "',Telefon = '" + mtbTelefon.Text + "',Mail='" + txtMail.Text + "',TC='" + txtTcKimlikNo.Text + "',OdaNo='" + txtOdaNumarası.Text + "',Ucret='" + txtUcret.Text + "',GirisTarihi='" + dtpGiris.Value.ToString("yyyy.MM.dd") + "',CıkısTarihi='" + dtpCıkıs.Value.ToString("yyyy.MM.dd") + "' where Musteriid=" + id + "", baglanti2);
            komut.ExecuteNonQuery();
            baglanti2.Close();
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("select * from YeniMusteriEkle  where Adi like '%" + txtAra.Text + "%'", baglanti2);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti2.Close();
        }
    }
}
