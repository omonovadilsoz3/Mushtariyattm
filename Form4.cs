using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Amaliy_mashg_ulot
{
    public partial class Form4 : Form
    {
        public int id1;
        public Form4(int id)
        {
            InitializeComponent();
            id1 = id;
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");
            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT*FROM `attm22` WHERE id='{id1}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label1.Text = dt.Rows[0]["Name"].ToString();
            label3.Text = dt.Rows[0]["Group_name"].ToString();
            label4.Text = dt.Rows[0]["Address"].ToString();
            label10.Text = dt.Rows[0]["Login"].ToString();
            label11.Text = dt.Rows[0]["Login"].ToString();

        }

        public void baza()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");
            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT*FROM `attm22` WHERE id='{id1}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label1.Text = dt.Rows[0]["Name"].ToString();
            label3.Text = dt.Rows[0]["Group_name"].ToString();
            label4.Text = dt.Rows[0]["Address"].ToString();
            label10.Text = dt.Rows[0]["Login"].ToString();
            label11.Text = dt.Rows[0]["Login"].ToString();

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button1.Visible = true;
            textBox1.Text = label1.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string newname = textBox1.Text;
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");
            MySqlDataAdapter da = new MySqlDataAdapter($"UPDATE  `attm22` SET `Name`='{newname}'  WHERE id={id1}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox1.Visible = false;
            button1.Visible = false;
            baza();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button7.Visible = true;
            textBox2.Text = label3.Text;


        }

        private void button7_Click(object sender, EventArgs e)
        {



        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string newgroup = textBox2.Text;
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");
            MySqlDataAdapter da = new MySqlDataAdapter($"UPDATE  `attm22` SET `Group_name`='{newgroup}'  WHERE id={id1}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox2.Visible = false;
            button7.Visible = false;
            baza();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox3.Visible = true;
            button8.Visible = true;
            textBox3.Text = label4.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string newaddress = textBox3.Text;
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");
            MySqlDataAdapter da = new MySqlDataAdapter($"UPDATE  `attm22` SET `Address`='{newaddress}'  WHERE id={id1}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox3.Visible = false;
            button8.Visible = false;
            baza();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            button9.Visible = true;
            textBox4.Text = label10.Text;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            string newlogin = textBox4.Text;
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");
            MySqlDataAdapter da = new MySqlDataAdapter($"UPDATE  `attm22` SET `Login`='{newlogin}'  WHERE id={id1}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox4.Visible = false;
            button9.Visible = false;
            baza();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            button10.Visible = true;
            textBox5.Text = label11.Text;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            string newpassword = textBox5.Text;
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");
            MySqlDataAdapter da = new MySqlDataAdapter($"UPDATE  `attm22` SET `Password`='{newpassword}'  WHERE id={id1}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox5.Visible = false;
            button10.Visible = false;
            baza();


        }
    }
}
