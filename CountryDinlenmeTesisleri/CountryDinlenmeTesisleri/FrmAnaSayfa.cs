using CountryDinlenmeTesisleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryTatilKöyü
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYeniMusteriEkle fr = new FrmYeniMusteriEkle();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Country Koyu Siz ve Dostlarınız İçin Hizmet Vermektedir.  /  2022 - 22 - 05");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
