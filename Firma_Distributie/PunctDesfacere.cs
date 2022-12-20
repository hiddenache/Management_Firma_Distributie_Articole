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
    public partial class PunctDesfacere : Form
    {
        public PunctDesfacere()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Connection();
            String query = "INSERT INTO punct_desfacere (id_articol, titlu, nr_buc, pret_vanzare, tip) VALUES (" +
                "@id_articol,@titlu,@nr_buc,@pret_vanzare,@tip)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@id_articol", int.Parse(id_articol.Text));
                cmd.Parameters.AddWithValue("@titlu",titlu.Text);
                cmd.Parameters.AddWithValue("@nr_buc", int.Parse(nrBuc.Text));
                cmd.Parameters.AddWithValue("@pret_vanzare", float.Parse(pret_vanzare.Text));
                cmd.Parameters.AddWithValue("@tip", tip.Text);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Punct de desfacere introdus cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cnn.Close();
        }
    }
}
