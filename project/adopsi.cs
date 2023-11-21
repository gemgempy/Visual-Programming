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
    public partial class adopsi : Form
    {
        public adopsi()
        {
            InitializeComponent();
        }

        string constring = @"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";


        //BUTTON ADOPSI
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" )
            {

                string query = "insert into adopsi (tanggal_adopsi,ID_hewan,ID_adopter) values('" + dateTimePicker1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "')";
                SqlConnection conn = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, conn);
                DA.Fill(DS, "ProjectKel2");
                MessageBox.Show("Anda Berhasil Mengadopsi <3");


                string queryDelete = "delete from Hewan where ID_hewan='" + comboBox2.Text + "'";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter dap = new SqlDataAdapter(queryDelete, con);
                dap.Fill(DS, "ProjectKel2");

                tampil();

                //where textbox id yg mau diapus
            }
            else
            {
                MessageBox.Show("Data Gagal Diinput");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        //GET
        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from adopter where email = '" + comboBox1.Text + "'", conn);
            SqlDataReader srd = comm.ExecuteReader();
            while (srd.Read())
            {
                textBox1.Text = srd.GetValue(1).ToString();

            }
            conn.Close();

        }

        //DROPDOWN EMAIL
        public void emailbind()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from adopter", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(3).ToString());
            }
            dr.Close();
            conn.Close();
        }

        //DROPDOWN ID HEWAN
        public void hewanbind()
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Hewan", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr.GetValue(1).ToString());
            }
            dr.Close();
            conn.Close();
        }


        //NAMPILIN GRID OTOMATIS
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


        //LOAD
        private void adopsi_Load(object sender, EventArgs e)
        {
            emailbind();
            hewanbind();
            tampil();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
