using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        //BUTTON SIGN UP KARYAWAN
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpKry panggil = new SignUpKry();
            panggil.Show();
        }


        //BUTTON SIGN UP ADOPTER
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpAdo panggil = new SignUpAdo();
            panggil.Show();
        }

        //ICON BACK
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            
            LoginForm panggil = new LoginForm();
            panggil.Show();
        }
    }
}
