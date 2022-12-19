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
        static string password = "";
        static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";"
                                        + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            cnn.Open();
            String query = "INSERT INTO punct_desfacere (id_articol, titlu, pret_vanzare, tip) VALUES ('" + id_articol.Text + "', '" + titlu.Text + "', '" + pret_vanzare + "', '" + tip.Text + "')";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
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
