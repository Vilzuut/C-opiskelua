using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaksilukuayhteen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Laskeyhteen_Click(object sender, EventArgs e)
        {
            int luku1, luku2, summa;
            try
            {
                luku1 = int.Parse(Tekstilaatikko1.Text);
            }
            catch
            {
                Vastauslabel.Text = "Anna vain kokonaisnumeroita";
                Tekstilaatikko1.Text = "";
                Tekstilaatikko1.Focus();
            }

            try
            {
                luku2 = int.Parse(Tekstilaatikko2.Text);
            }
            catch
            {
                Vastauslabel.Text = "Anna vain kokonaisnumeroita";
                Tekstilaatikko2.Text = "";
                Tekstilaatikko2.Focus();
            }
            
            summa = luku1 + luku2;
            Vastauslabel.Visible = true;
            Vastauslabel.Text = ("" + summa);
        }
    }
}
