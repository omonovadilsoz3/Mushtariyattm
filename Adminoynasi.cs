using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Amaliy_mashg_ulot
{
    public partial class Adminoynasi : Form
    {
        public Adminoynasi()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `attm22` WHERE 1 ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Group_name = textBox2.Text;
            string Address = textBox3.Text;
            string Login = textBox4.Text;
            string Password = textBox5.Text;

            MySqlDataAdapter da = new MySqlDataAdapter($"INSERT INTO `attm22` (`Name`,`Group_name`,`Address`,`Login`,`Password`)" +
           $"VALUES ('{Name}', '{Group_name}', '{Address}', '{Login}', '{Password}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //this.Close();
            button1_Click(sender, e);

            //MessageBox.Show("Siz muvaffaqqiyatli ro'yxatdan o'tdingiz!");
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Id = textBox6.Text;
            string Name = textBox1.Text;
            string Group_name = textBox2.Text;
            string Address = textBox3.Text;
            string Login = textBox4.Text;
            string Password = textBox5.Text;
            MySqlDataAdapter da = new MySqlDataAdapter($"UPDATE  `attm22`  SET `Name`='{Name}',`Group_name`='{Group_name}',`Address`='{Address}',`Login`='{Login}',`Password`='{Password}' WHERE id={Id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //this.Close();
            button1_Click(sender, e);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox6.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();

            }
        }

        private void Adminoynasi_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Id = textBox6.Text;
            MySqlDataAdapter da = new MySqlDataAdapter($"Delete FROM `attm22`  WHERE id={Id}", con);
            DataTable dt = new DataTable();
            
            DialogResult dr = MessageBox.Show($"Siz  id = {Id} ma'lumotni  haqiqatdan  o'chirmoqchimisiz?", "Diqqat!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                da.Fill(dt);
                //this.Close();
                button1_Click(sender, e);
                clear();
            }
           

        }
    }
}

