using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryTatilKöyü
{
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti2 = new SqlConnection(@"Data Source=DESKTOP-MH4E4IE\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");



        private void verilerigoster3()
        {
            listView1.Items.Clear();
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar ", baglanti2);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti2.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komut2 = new SqlCommand("insert into  Mesajlar(AdSoyad,Mesaj)values('" + txtAdSoyad.Text + "','" + rchtxtMesaj.Text + "')", baglanti2);
            komut2.ExecuteNonQuery();
            baglanti2.Close();
            verilerigoster3();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster3();
        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            rchtxtMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
