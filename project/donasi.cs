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
    public partial class donasi : Form
    {
        public donasi()
        {
            InitializeComponent();
        }

        
        string constring = @"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";


        //BUTTON DONASI
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                string query = "insert into donasi (nomor_adopsi,jumlah_donasi,jenis_pembayaran, tanggal_donasi) values('" + textBox1.Text + "','" + textBox4.Text + "','" + comboBox2.SelectedItem + "', '" + dateTimePicker1.Text + "')";
                SqlConnection conn = new SqlConnection(constring);
                SqlDataAdapter DA = new SqlDataAdapter(query, conn);
                DA.Fill(DS, "ProjectKel2");
                MessageBox.Show("Data Berhasil Diinput");
            }
            else
            {
                MessageBox.Show("Data Gagal Diinput");
            }
            
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


        //LOAD FORM
        private void donasi_Load(object sender, EventArgs e)
        {
            emailbind();
        }



        //GET
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            SqlCommand comm = new SqlCommand("select adopter.email, adopsi.nomor_adopsi from adopter join adopsi on adopter.ID_adopter = adopter.ID_adopter where email = '" + comboBox1.Text + "'", conn);
            SqlDataReader srd = comm.ExecuteReader();
            while (srd.Read())
            {
                textBox1.Text = srd.GetValue(1).ToString();

            }
            conn.Close();
        }
    }
}
