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
        static string password = "dragosdb";
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
                gridViewFurnizori.DataSource = GetforDataGrid("furnizor");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dateSearch = dateTimePicker1.Value.Date;
            cnn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            cnn.Open();
            DataTable data = new DataTable();
            string selectie = "SELECT exemplare_primite AS stoc,exemplare_returnate AS retururi,exemplare_vandute as VanazriCantitative FROM furnizor where terment_plata =@search";
            MySqlCommand selectComm = new MySqlCommand(selectie, cnn);
            selectComm.Parameters.AddWithValue("@search", dateSearch);
            MySqlDataReader reader = selectComm.ExecuteReader();
            data.Load(reader);
            dataGridView2.DataSource = data;
            selectComm.Parameters.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Connection();
            double pretArticol = 0;
            int exemplareVandute = 0;
            double profitPerBuc = 0;
            double profitTotal = 0;
            string selectieIdFurnizor = "SELECT ID FROM furnizor where nume_firma=@search";
            MySqlCommand selectComm = new MySqlCommand(selectieIdFurnizor, cnn);
            selectComm.Parameters.AddWithValue("@search", textBox3.Text);
            int IDFurnizor = (int)selectComm.ExecuteScalar();
            selectComm.Parameters.Clear();

            string selectie = "SELECT pret FROM articol where id_furnizor=@search";
            MySqlCommand selectComm2 = new MySqlCommand(selectie, cnn);
            selectComm2.Parameters.AddWithValue("@search", IDFurnizor);
            pretArticol = (float)selectComm2.ExecuteScalar();           
            selectComm2.Parameters.Clear();

            string selectie2 = "SELECT exemplare_vandute FROM furnizor where ID=@search";
            MySqlCommand selectComm3 = new MySqlCommand(selectie2, cnn);
            selectComm3.Parameters.AddWithValue("@search", IDFurnizor);
            exemplareVandute = (int)selectComm3.ExecuteScalar();
            selectComm3.Parameters.Clear();
            
            profitPerBuc = (5 * pretArticol) / 100;
            profitTotal = profitPerBuc * exemplareVandute;
            textBox1.Text = profitPerBuc.ToString() + " LEI";
            textBox4.Text = profitTotal.ToString() + " LEI";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Connection();
            double pretArticol = 0;
            int nr_buc = 0;
            double profitPerBucFurnizor = 0;
            double profitPerBucArticol = 0;
            double profitTotal = 0;
            int idArticol = 0;
            double pretFurnizor = 0;


            int id = int.Parse(textBox6.Text);
            string selectieNrBuc = "SELECT nr_buc FROM punct_desfacere WHERE ID='" + id + "'";
            MySqlCommand selectComm = new MySqlCommand(selectieNrBuc, cnn);
            nr_buc = (int)selectComm.ExecuteScalar();

            string selectIdArticol = "SELECT id_articol FROM punct_desfacere where ID=@search1";
            MySqlCommand selectComm2 = new MySqlCommand(selectIdArticol, cnn);
            selectComm2.Parameters.AddWithValue("@search1", int.Parse(textBox6.Text));
            idArticol = (int)selectComm.ExecuteScalar();
            selectComm2.Parameters.Clear();

            string selectie = "SELECT pret FROM articol where ID=@search3";
            MySqlCommand selectComm3 = new MySqlCommand(selectie, cnn);
            selectComm3.Parameters.AddWithValue("@search3", idArticol);
            pretArticol = (float)selectComm3.ExecuteScalar();
            selectComm3.Parameters.Clear();
            profitPerBucFurnizor = (5 * pretArticol) / 100;
            pretFurnizor = pretArticol + profitPerBucFurnizor;
            profitPerBucArticol = (15 * pretFurnizor) / 100;

            profitTotal = profitPerBucArticol * nr_buc;
            textBox5.Text = profitPerBucArticol.ToString() + " LEI";
            textBox2.Text = profitTotal.ToString() + " LEI";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection();
            DataTable data = new DataTable();
            string selectie = "SELECT id_articol, nr_buc AS bucatiReceptionate, pret AS pretPerBuc FROM punct_desfacere join articol";
            MySqlCommand selectComm = new MySqlCommand(selectie, cnn);
            MySqlDataReader reader = selectComm.ExecuteReader();
            data.Load(reader);
            dataGridView3.DataSource = data;
        }
    }
}
