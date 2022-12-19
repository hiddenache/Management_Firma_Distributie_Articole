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
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace Firma_Distributie
{
    public partial class Actiuni : Form
    {
        public Actiuni()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        MySqlConnection cnn;
        static string server = "localhost";
        static string database = "firma_distributie";
        static string uid = "root";
        static string password = "";
        static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";"
                                        + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();

        private void Actiuni_Load(object sender, EventArgs e)
        {
            
        }

        private void Connection()
        {
            cnn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private DataTable GetforDataGrid(string table)
        {
            cnn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            cnn.Open();
            DataTable data = new DataTable();
            MySqlCommand selectComm = new MySqlCommand("SELECT * FROM " + table, cnn);
            MySqlDataReader reader = selectComm.ExecuteReader();
            data.Load(reader);
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GetforDataGrid("furnizor");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }
    }
}
