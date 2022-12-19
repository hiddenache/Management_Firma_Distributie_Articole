using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firma_Distributie
{
    public partial class Furnizor : Form
    {
        public Furnizor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void Furnizor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO furnizor (nume_firma, nr_inregistrare, CUI, adresa, telefon, cont_bancar, exemplare_primite, exemplare_returnate, exemplare_vandute, suma_plata, terment_plata) VALUES ('" + nume_firma.Text + "', '" + nr_inregistrare.Text + "', '" + CUI.Text + "', '" + adresa.Text + "', '" + telefon.Text + "', '" + cont_bancar.Text + "','" + exemplare_primite + "', '" + exemplare_returnate + "', '" + exemplare_vandute + "', '" + suma_plata + "', '" + DateTime.Parse(termen_plata.Text) + "') ";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Furnizor introdus cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
               
        }
    }
}
