using CountryTatilKöyü;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Data;

namespace CountryDinlenmeTesisleri
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti5 = new SqlConnection(@"Data Source=DESKTOP-MH4E4IE\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti5.Open();
                string sql = "select * from AdminGiris where Kullanici=@KullaniciAdi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi",txtkullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,baglanti5);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da   = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0 )
                {
                    FrmAnaSayfa fr = new FrmAnaSayfa();
                    fr.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalý Bilgiler Girdiniz");
            }
            baglanti5.Close();

        }
    }
}