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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti5 = new SqlConnection("Data Source=DESKTOP-MH4E4IE\\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti5.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti5);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecekler"].ToString());
                ekle.SubItems.Add(oku["Atistirmaliklar"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti5.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti5.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglanti5);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti5.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti5.Open();
            SqlCommand komut = new SqlCommand("insert into  Stoklar (Gida,İcecekler,Atistirmaliklar) values ('" + txtGida.Text + "' , '" + txtİcecek.Text + "' , '" + txtAtistirmalik.Text + "') ", baglanti5);
            komut.ExecuteNonQuery();
            baglanti5.Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti5.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar(Elektrik,Su,İnternet)values('" + txtElektrik.Text + "','" + txtSu.Text + "','" + txtİnternet.Text + "')", baglanti5);
            komut2.ExecuteNonQuery();
            baglanti5.Close();
            veriler2();
        }
    }
}
