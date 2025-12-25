
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Amaliy_mashg_ulot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=attm22;password=;");

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text.Trim();
            string Parol = textBox2.Text.Trim();
            MySqlDataAdapter da = new MySqlDataAdapter($"SELECT*FROM `attm22` WHERE login='{Login}' and Password='{Parol}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i = dt.Rows.Count;
            if (i > 0)
            {

                /* Form3 a = new Form3();
                 a.ShowDialog();*/
                int id = Convert.ToInt32(dt.Rows[0]["id"]);
                Form4 user = new Form4(id);
                user.ShowDialog();

            }
            else
            {
                MessageBox.Show("login yoki parol xato.....");

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.ShowDialog();
        }
    }
}
