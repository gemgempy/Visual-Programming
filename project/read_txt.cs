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
namespace project
{
    public partial class read_txt : Form
    {
        public read_txt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                fileExt = Path.GetExtension(filepath);
                if (fileExt.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(filepath);
                        StringBuilder builder = new StringBuilder();
                        string line = "";

                        while ((line = reader.ReadLine()) != null)
                        {
                            builder.AppendLine(line);
                        }

                        reader.Close();
                        richTextBox1.Text = builder.ToString();

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
