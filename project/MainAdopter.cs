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

namespace project
{
    public partial class MainAdopter : Form
    {
        public MainAdopter()
        {
            InitializeComponent();
        }

        string constring = @"Data Source=DESKTOP-RU8KUJJ\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";


        //KATALOG
        private void katalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            katalogHewan kh = new katalogHewan();
            kh.MdiParent = this;
            kh.Show();
        }


        //DONASI
        private void donasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donasi dn = new donasi();
            dn.MdiParent = this;
            dn.Show();
        }

        //ADOPSI
        private void adopsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adopsi ad = new adopsi();
            ad.MdiParent = this;
            ad.Show();
        }

        //LOG OUT
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm panggil = new LoginForm();
            panggil.Show();
            this.Hide();
        }

        private void sertifikatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ya = new about();
            ya.Show();
            this.Hide();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faq yaya = new faq();
            yaya.Show();
            this.Hide();
        }
    }
}
