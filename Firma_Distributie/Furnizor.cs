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
        static string password = "dragosdb";
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
            DateTime termenPlata = termen_plata.Value.Date;
            
            Connection();
            String query = "INSERT INTO furnizor (nume_firma, nr_inregistrare, CUI, adresa, telefon, cont_bancar, exemplare_primite, exemplare_returnate, exemplare_vandute, suma_plata, terment_plata) VALUES (" +
                "@nume_firma,@nr_inregistrare,@CUI,@adresa,@telefon,@cont_bancar,@exemplare_primite,@exemplare_returnate,@exemplare_vandute,@suma_plata,@terment_plata)";




            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@nume_firma", nume_firma.Text);
                cmd.Parameters.AddWithValue("@nr_inregistrare", int.Parse(nr_inregistrare.Text));
                cmd.Parameters.AddWithValue("@CUI", CUI.Text);
                cmd.Parameters.AddWithValue("@adresa", adresa.Text);
                cmd.Parameters.AddWithValue("@telefon", telefon.Text);
                cmd.Parameters.AddWithValue("@cont_bancar", cont_bancar.Text);
                cmd.Parameters.AddWithValue("@exemplare_primite", int.Parse(exemplare_primite.Text));
                cmd.Parameters.AddWithValue("@exemplare_returnate", int.Parse(exemplare_returnate.Text));
                cmd.Parameters.AddWithValue("@exemplare_vandute", int.Parse(exemplare_vandute.Text));
                cmd.Parameters.AddWithValue("@suma_plata", float.Parse(suma_plata.Text));
                cmd.Parameters.AddWithValue("@terment_plata", termenPlata);




                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                MessageBox.Show("Furnizor introdus cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
               
        }
    }
}
