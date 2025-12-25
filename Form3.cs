using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Amaliy_mashg_ulot
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");
        private void button2_Click(object sender, EventArgs e)
        {
            string Login = textBox4.Text.Trim();
            string Parol = textBox5.Text.Trim();
            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT*FROM `admin` WHERE Login='{Login}' and Parol='{Parol}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i = dt.Rows.Count;
            if (i > 0)
            {

                /* Form3 a = new Form3();
                 a.ShowDialog();*/
                //int id = Convert.ToInt32(dt.Rows[0]["id"]);
                Adminoynasi a = new Adminoynasi();
                a.ShowDialog();


            }
            else
            {
                MessageBox.Show("login yoki parol xato.....");

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
