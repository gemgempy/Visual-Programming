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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //LABEL DONT HAVE ACCOUNT
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp panggil = new SignUp();
            panggil.Show();
        }


        //BUTTON LOGIN KARYAWAN
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Karyawan where email_kry = '" + textBox1.Text + "' and pass_kry = '" + textBox2.Text + "'", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainForm panggil = new MainForm();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah! Harap mengisi username dan password dengan benar", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //BUTTON LOGIN ADOPTER
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True");
            SqlDataAdapter ho = new SqlDataAdapter("select count (*) from adopter where email = '" + textBox1.Text + "' and pswrd = '" + textBox2.Text + "'", koneksi);
            DataTable dt = new DataTable();
            ho.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainAdopter panggil = new MainAdopter();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password salah! Harap mengisi username dan password dengan benar", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
