using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanglaDictionary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string connectionString = "server = desktop-b9giqpc; database = DictionaryDB; Integrated security = true;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string en = eng.Text;
            string bn = ban.Text;

            string query = "insert into t_diction values (@en,@bn)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@en",en);
            command.Parameters.Add("@bn", bn);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Your word is added successfully!");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            eng.Text = "";
            ban.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
