using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gitterhubber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Etusivu_Click(object sender, EventArgs e)
        {
            string etunimi = Tekstilaatikko.Text;
            Viesti.Text = "Hei " + etunimi + ", oikein hyvää päivää sinulle";
            Viesti.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
