using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Data.SqlClient;

namespace project
{
    public partial class gen_txt_hewan : Form
    {
        public gen_txt_hewan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"D:\visual program\snoringpaw\hewan.txt");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.WriteLine("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" );

                }
                writer.WriteLine("");
                writer.WriteLine("------------------------------------------------------------------------");

            }
            writer.Close();
            MessageBox.Show("Data Txt berhasil dibuat");
        }

        private void gen_txt_hewan_Load(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-G2KTG3U\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
            DataSet DS = new DataSet();
            string vquery = "";

            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from Hewan";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);

            DA.Fill(DS, "ProjectKel2");
            dataGridView1.DataSource = DS.Tables["ProjectKel2"];
            conn.Close();
        }
    }
}
