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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti3 = new SqlConnection("Data Source=DESKTOP-MH4E4IE\\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            List<Button> buttonList = new List<Button>
            {
                btn101, btn102, btn103, btn104, btn105, btn106, btn107, btn108, btn109
            };

            foreach (Button button in buttonList)
            {
                string odaNumarasi = button.Text;

                // Veritabanı bağlantısı ve sorgu işlemleri
               
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM OdalarSon WHERE OdaNumarasi = @OdaNumarasi", baglanti3);
                komut.Parameters.AddWithValue("@OdaNumarasi", odaNumarasi);

                baglanti3.Open();
                int count = (int)komut.ExecuteScalar();
                baglanti3.Close();

                // Kontrol ve işlemler
                if (count > 0)
                {
                    button.BackColor = Color.Red;
                    button.Text = "DOLU";
                    button.Enabled = false;
                }
            }

        }
   
    }
}
