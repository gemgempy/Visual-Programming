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
    public partial class HewanBaru : Form
    {
        public HewanBaru()
        {
            InitializeComponent();
        }

        //BUTTON SIMPAN
        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand insert = new SqlCommand("insert into Hewan(nama_hewan, spesies_hewan, jenis_hewan, tanggal_masuk, jk_hewan, riwayat_penyakit, umur_hewan) values(@nama_hewan, @spesies_hewan, @jenis_hewan, @tanggal_masuk, @jk_hewan, @riwayat_penyakit, @umur_hewan)", con);
            //@ID_hewan, @nama_hewan, @jenis_hewan, @tanggal_masuk, @jk_hewan, @riwayat_penyakit, @umur_hewan
            insert.Parameters.AddWithValue("@nama_hewan", textBox1.Text);
            insert.Parameters.AddWithValue("@spesies_hewan", textBox2.Text);
            insert.Parameters.AddWithValue("@jenis_hewan", textBox3.Text);
            insert.Parameters.AddWithValue("@tanggal_masuk", dateTimePicker1.Value);
            insert.Parameters.AddWithValue("@jk_hewan", comboBox1.SelectedItem);
            insert.Parameters.AddWithValue("@riwayat_penyakit", textBox6.Text);
            insert.Parameters.AddWithValue("@umur_hewan", textBox7.Text);
            try
            {
                con.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data telah di input");
            }
            catch
            {
                MessageBox.Show("cannot open connection!");
            }
            finally
            {
                con.Close();
            }
        }


        //BUTTON KEMBALI
        private void button2_Click(object sender, EventArgs e)
        {
            //MainForm panggil = new MainForm();
            //panggil.Show();
            this.Close();
         
        }

        private void HewanBaru_Load(object sender, EventArgs e)
        {

        }


        //BUTTON CLEAR
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;

            comboBox1.Text = String.Empty;
        }
    }
}
