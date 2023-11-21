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
    public partial class SignUpAdo : Form
    {
        public SignUpAdo()
        {
            InitializeComponent();
        }

        string constring = @"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
        DataSet DS = new DataSet();
        string vquery = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "")
            {

                string query = "insert into adopter (nama_adopter,email,pswrd,tanggal_join, alamat, role_) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "', '" + comboBox1.SelectedItem + "')";
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


        //BUTTON LOGIN
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm panggil = new LoginForm();
            panggil.Show();
        }


        //BUTTON KEMBALI
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp panggil = new SignUp();
            panggil.Show();
        }

        //ICON KEMBALI
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SignUp panggil = new SignUp();
            panggil.Show();
            this.Close();
        }


        //HIDE PASSWORD
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

    }
}
