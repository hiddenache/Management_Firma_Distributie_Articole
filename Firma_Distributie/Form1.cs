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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Furnizor furnizor = new Furnizor();
            furnizor.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articol articol = new Articol();
            articol.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PunctDesfacere punctDesfacere = new PunctDesfacere();
            punctDesfacere.Show();
            this.Hide();
        }
    }
}
