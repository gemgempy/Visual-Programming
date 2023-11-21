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
    public partial class UpdateHewan : Form
    {
        public UpdateHewan()
        {
            InitializeComponent();
        }

        string constring = @"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";


        //NAMPILIN GRID VIEW
        void tampil()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Hewan";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "ProjectKel2");
            dataGridView1.DataSource = DS.Tables["ProjectKel2"];
            conn.Close();
        }


        //BUTTON UPDATE
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" )
            {
              
                string query = "update Hewan set nama_hewan='" + textBox2.Text + "', spesies_hewan='" + textBox3.Text + "', jenis_hewan='" + textBox4.Text + "', tanggal_masuk='" + dateTimePicker1.Text + "', jk_hewan='" + comboBox2.SelectedItem + "', riwayat_penyakit='" + textBox7.Text + "', umur_hewan='" + textBox8.Text + "' where ID_hewan='" + comboBox1.Text + "'";
                SqlConnection conn = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, conn);
                DA.Fill(DS, "ProjectKel2");
                tampil();
                MessageBox.Show("Data Berhasil Di Update");
            }
            else
            {
                MessageBox.Show("Data Gagal Di Update");
            }
        }

        //LOAD
        private void UpdateHewan_Load(object sender, EventArgs e)
        {
            idhewanbind();
        }


        //BUTTON UNTUK NAMPILIN
        private void button4_Click_1(object sender, EventArgs e)
        {
            tampil();
        }


        //BUTTON DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string query = "delete from Hewan where ID_hewan='" + comboBox1.Text + "'";
                SqlConnection conn = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, conn);
                DA.Fill(DS, "ProjectKel2");
                tampil();
                MessageBox.Show("delete berhasil");
            }
            else
            {
                MessageBox.Show("delete data gagal");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //DROPDOWN IDHEWAN
        public void idhewanbind()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Hewan", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(1).ToString());
            }
            dr.Close();
            conn.Close();
        }

        //GET
        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from Hewan where ID_hewan = '" + comboBox1.Text + "'", conn);
            SqlDataReader srd = comm.ExecuteReader();
            while (srd.Read())
            {
                textBox2.Text = srd.GetValue(2).ToString();
                textBox3.Text = srd.GetValue(3).ToString();
                textBox4.Text = srd.GetValue(4).ToString();

                comboBox2.SelectedItem = srd.GetValue(6).ToString();

                textBox7.Text = srd.GetValue(7).ToString();
                textBox8.Text = srd.GetValue(8).ToString();


            }
            conn.Close();
        }


        //TOMBOL CLEAR
        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            comboBox2.Text = String.Empty;
        }
    }
}
