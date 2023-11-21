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
    public partial class SignUpKry : Form
    {
        public SignUpKry()
        {
            InitializeComponent();
        }


        //BUTTON KEMBALI
        private void button2_Click(object sender, EventArgs e)
        {
            SignUp panggil = new SignUp();
            panggil.Show();
            this.Hide();
        }


        //BUTTON SIGN UP KARYAWAN
        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);

            SqlCommand insert = new SqlCommand("insert into Karyawan(nama_kry, email_kry, pass_kry, tgl_lahir_karyawan, jk_karyawan, alamat_karyawan, telp_karyawan) values(@nama_kry, @email_kry, @pass_kry, @tgl_lahir_karyawan, @jk_karyawan, @alamat_karyawan, @telp_karyawan)", con);           
            //ID_karyawan, nama_kry, tgl_lahir_karyawan, jk_karyawan, alamat_karyawan, telp_karyawan
            insert.Parameters.AddWithValue("@nama_kry", textBox1.Text);
            insert.Parameters.AddWithValue("@email_kry", textBox2.Text);
            insert.Parameters.AddWithValue("@pass_kry", textBox3.Text);
            insert.Parameters.AddWithValue("@tgl_lahir_karyawan", dateTimePicker1.Text);
            insert.Parameters.AddWithValue("@jk_karyawan", comboBox1.SelectedItem);
            insert.Parameters.AddWithValue("@alamat_karyawan", textBox6.Text);
            insert.Parameters.AddWithValue("@telp_karyawan", textBox7.Text);
            
            try
            {
                con.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Sign Up Berhasil!");
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

        //BUTTON LOGIN
        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm panggil = new LoginForm();
            panggil.Show();
            this.Hide();
        }


        //ICON KEMBALI
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SignUp panggil = new SignUp();
            panggil.Show();
            this.Close();
        }

        private void SignUpKry_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
