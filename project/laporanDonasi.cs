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
    public partial class laporanDonasi : Form
    {
        public laporanDonasi()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-RU8KUJJ\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd;
            SqlDataAdapter adapter;
            string date1;
            string date2;

            date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;

            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Donasi WHERE tanggal_donasi BETWEEN '" + date1 + "' AND '" + date2 + "'",con);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.RefreshReport();
            con.Close();
        
        }
    }
}
