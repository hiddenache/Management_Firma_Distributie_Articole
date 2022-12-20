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
    public partial class Articol : Form
    {
        public Articol()
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

        private void Articol_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Connection();
            int idFurnizor = int.Parse(id_furnizor.Text);
            float pretInt = float.Parse(pret.Text);
            String query = "INSERT INTO articol (titlu, id_furnizor, pret, tip) VALUES ('"+titlu.Text+"', '"+idFurnizor+"', '"+pretInt+"', '"+tip.Text+"')";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Articol introdus cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cnn.Close();
        }
    }
}
