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
    public partial class laporanAdopt : Form
    {
        public laporanAdopt()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connstring = @"Data Source=DESKTOP-RU8KUJJ\SQLEXPRESS;Initial Catalog=ProjectKel2;Integrated Security=True";
            //DataSet DS = new DataSet();
            //string vquery = "";
            //DataTable dt = new DataTable();

            //string date1;
            //string date2;

            //date1 = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            //date2 = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;


            //SqlConnection conn = new SqlConnection(connstring);
            //conn.Open();
            //DS.Clear();
            //vquery = "select * from adopsi where tanggal_adopsi between '" + date1 + "' and '" + date2 + "'";
            //SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);

            //DA.Fill(DS, "ProjectKel2");

            //laporanAdopsi cr = new laporanAdopsi();
            //cr.Database.Tables["ProjectKel2"].SetDataSource(dt);
            //this.crystalReportViewer1.ReportSource = cr;

            //conn.Close();
        }
    }
}
