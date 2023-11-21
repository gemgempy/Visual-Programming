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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        string constring = @"Data Source=DESKTOP-RU8KUJJ\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";


        //BUTTON LAPORAN
        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        //BUTTON HEWAN BARU (MENU)
        private void hewanBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HewanBaru hb = new HewanBaru();
            hb.MdiParent = this;
            hb.Show();
        }

        //EDIT HEWAN
        private void editHewanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateHewan uh = new UpdateHewan();
            uh.MdiParent = this;
            uh.Show();
        }

        //LAPORAN HEWAN MASUK
        private void hewanMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laporanHewanMasuk vform = new laporanHewanMasuk();
            vform.Show();
        }

        //LAPORAN ADOPSI
        private void hewanTeradopsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laporanAdopt vform = new laporanAdopt();
            vform.Show();
        }

        //LAPORAN HASIL DONASI
        private void hasilDonasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laporanDonasi vform = new laporanDonasi();
            vform.Show();
        }


        //DETAIL DONASI
        private void detailDonasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailDonasi dd = new detailDonasi();
            dd.MdiParent = this;
            dd.Show();
        }


        //DETAIL KATALOG
        private void detailKatalogHewanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            katalogHewan kh = new katalogHewan();
            kh.MdiParent = this;
            kh.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        //LOG OUT
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm panggil = new LoginForm();
            panggil.Show();
            this.Hide();

        
        }

        
        private void generateTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        //READ TXT
        private void readTxtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            read_txt rt = new read_txt();
            rt.MdiParent = this;
            rt.Show();
        }


        //GENERATE TXT KATALOG
        private void generateKatalogHewanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gen_txt_hewan kh = new gen_txt_hewan();
            kh.MdiParent = this;
            kh.Show();
        }


        //GENERATE TXT DONASI
        private void generateDetailDonasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gen_txt_donasi kh = new gen_txt_donasi();
            kh.MdiParent = this;
            kh.Show();
        }

        
    }
}
