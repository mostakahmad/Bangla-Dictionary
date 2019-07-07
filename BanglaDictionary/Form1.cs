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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            string connectionString = "server = desktop-b9giqpc; database = DictionaryDB; Integrated security = true;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataTable table = new DataTable();
            string query = "select * from t_diction";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView.DataSource = table;

            connection.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string connectionString = "server = desktop-b9giqpc; database = DictionaryDB; Integrated security = true;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
            DataTable table = new DataTable();
            string query = "select * from t_diction where [               English Word            ] = '"+engTextBox.Text+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView.DataSource = table;

            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            engTextBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
