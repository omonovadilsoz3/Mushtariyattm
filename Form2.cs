
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Amaliy_mashg_ulot
{
    public partial class Form2 : Form
    {
        
    public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Group_name = textBox2.Text;
            string Address = textBox3.Text;
            string Login = textBox4.Text;
            string Password = textBox5.Text;

            MySqlDataAdapter da1=new MySqlDataAdapter($"SELECT*FROM `attm22` WHERE login='{Login}'",con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            int i=dt1.Rows.Count; 
            if( i > 0)
            {
                MessageBox.Show("Bunday login mavjud ,iltimos boshqa login kiriting!");
                textBox4.Clear();
            }
            else
            {
                MySqlDataAdapter da = new MySqlDataAdapter($"INSERT INTO `attm22` (`Name`,`Group_name`,`Address`,`Login`,`Password`)" +
              $"VALUES ('{Name}', '{Group_name}', '{Address}', '{Login}', '{Password}')", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.Close();

                MessageBox.Show("Siz muvaffaqqiyatli ro'yxatdan o'tdingiz!");
                this.Close();

            }

            
           
        }
            
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
