using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tietokilpailupeli
{
    public partial class Form1 : Form
    {

        // Tietokilpailupeli Varibles

        int OikeaVastaus;
        int KysymysNumero = 1;
        int Pisteet;
        int Prosenttiluku;
        int TotalQuestions;


        public Form1()
        {
            InitializeComponent();

            KysyKysymys(KysymysNumero);

            TotalQuestions = 5;
        }

        private void VastausEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == OikeaVastaus)
            {
                Pisteet++;
            }

            if(KysymysNumero == TotalQuestions)
            {
                // Selvitä Prosentti määrä
                Prosenttiluku = (int)Math.Round((double)(Pisteet * 100) / TotalQuestions);

                // Tietokilpailun loppu teksti ja pistemäärän kertominen
                MessageBox.Show(
                   "Tietokilpailu päättyi!" + Environment.NewLine +
                   "Vastasit " + Pisteet + " kysymykseen oikein" + Environment.NewLine +
                   "Vastasit " + Prosenttiluku + "% kysymyksistä oikein " + Environment.NewLine + 
                   "Paina OK pelataksesi uudelleen!"
                    );

                Pisteet = 0;
                KysymysNumero = 0;
                KysyKysymys(KysymysNumero);
            }

            KysymysNumero++;
            KysyKysymys(KysymysNumero);
        }

        private void KysyKysymys(int knum)
        {
            switch(knum)
            {
                case 1:
                    // Kysymys 1 kuva
                    Kuva.Image = Properties.Resources.Kissa;

                    // Kysymys 1
                    KysymysLabel.Text = "Mikä eläin on kuvassa?";

                    // kysymys 1 vastaus vaihtoehdot
                    VastausNappi1.Text = "Koira";
                    VastausNappi2.Text = "Kissa";
                    VastausNappi3.Text = "Karhu";
                    VastausNappi4.Text = "Lehmä";

                    // Oikean vastauksen määrittäminen
                    OikeaVastaus = 2;

                    break;

                case 2:
                    // Kysymys 1 kuva
                    Kuva.Image = Properties.Resources.Elefantti;

                    // Kysymys 1
                    KysymysLabel.Text = "Mikä eläin on kuvassa";

                    // kysymys 1 vastaus vaihtoehdot
                    VastausNappi1.Text = "Zebra";
                    VastausNappi2.Text = "Leijona";
                    VastausNappi3.Text = "Elefantti";
                    VastausNappi4.Text = "Hevonen";

                    // Oikean vastauksen määrittäminen
                    OikeaVastaus = 3;

                    break;

                case 3:
                    // Kysymys 1 kuva
                    Kuva.Image = Properties.Resources.Hevonen;

                    // Kysymys 1
                    KysymysLabel.Text = "Mikä eläin on kuvassa";

                    // kysymys 1 vastaus vaihtoehdot
                    VastausNappi1.Text = "Hevonen";
                    VastausNappi2.Text = "Karhu";
                    VastausNappi3.Text = "Tiikeri";
                    VastausNappi4.Text = "Zebra";

                    // Oikean vastauksen määrittäminen
                    OikeaVastaus = 1;

                    break;

                case 4:
                    // Kysymys 1 kuva
                    Kuva.Image = Properties.Resources.Zebra;

                    // Kysymys 1
                    KysymysLabel.Text = "Mikä eläin on kuvassa";

                    // kysymys 1 vastaus vaihtoehdot
                    VastausNappi1.Text = "Zebra";
                    VastausNappi2.Text = "Koira";
                    VastausNappi3.Text = "Tiikeri";
                    VastausNappi4.Text = "Elefantti";

                    // Oikean vastauksen määrittäminen
                    OikeaVastaus = 1;

                    break;

                case 5:
                    // Kysymys 1 kuva
                    Kuva.Image = Properties.Resources.Tiikeri;

                    // Kysymys 1
                    KysymysLabel.Text = "Mikä eläin on kuvassa";

                    // kysymys 1 vastaus vaihtoehdot
                    VastausNappi1.Text = "Kissa";
                    VastausNappi2.Text = "Karhu";
                    VastausNappi3.Text = "Zebra";
                    VastausNappi4.Text = "Tiikeri";

                    // Oikean vastauksen määrittäminen
                    OikeaVastaus = 4;

                    break;
            }


        }
    }
}
