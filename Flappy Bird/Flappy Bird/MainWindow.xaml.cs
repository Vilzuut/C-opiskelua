using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace Flappy_Bird
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer peliAika = new DispatcherTimer();

        double pisteet;
        int gravity = 8;
        bool peliPaattyi;
        Rect FlappyBirdHitBox;

        public MainWindow()
        {
            InitializeComponent();

            peliAika.Tick += MainEventTimer;
            peliAika.Interval = TimeSpan.FromMilliseconds(20);
            aloitaPeli();
        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            txtpisteet.Content = "Pisteet: " + pisteet;

            FlappyBirdHitBox = new Rect(Canvas.GetLeft(Lintu), Canvas.GetTop(Lintu), Lintu.Width, Lintu.Height);

            Canvas.SetTop(Lintu, Canvas.GetTop(Lintu) + gravity);


            if(Canvas.GetTop(Lintu) < -10 || Canvas.GetTop(Lintu) > 445)
            {
                lopetaPeli();
            }


            foreach(var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string)x.Tag == "este1" || (string)x.Tag == "este2" || (string)x.Tag == "este3")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);

                    if (Canvas.GetLeft(x) < -100)
                    {
                        Canvas.SetLeft(x, 800);

                        pisteet += .5;
                    }

                    Rect pipeHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);


                    if(FlappyBirdHitBox.IntersectsWith(pipeHitBox))
                    {
                        lopetaPeli();
                    }
                }

                if ((string)x.Tag == "pilvi")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 3);

                    if(Canvas.GetLeft(x) < -250)
                    {
                        Canvas.SetLeft(x, 550);
                    }
                }

            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
            {
                Lintu.RenderTransform = new RotateTransform(-20, Lintu.Width / 2, Lintu.Height / 2);
                gravity = -8;
            }

            if(e.Key == Key.R && peliPaattyi == true)
            {
                aloitaPeli();
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Lintu.RenderTransform = new RotateTransform(5, Lintu.Width / 2, Lintu.Height / 2);
            gravity = 8;
        }


        private void aloitaPeli()
        {
            MyCanvas.Focus();

            int temp = 300;

            peliPaattyi = false;
            Canvas.SetTop(Lintu, 190);

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
               if((string)x.Tag == "este1")
                {
                    Canvas.SetLeft(x, 500);
                }

                if ((string)x.Tag == "este2")
                {
                    Canvas.SetLeft(x, 800);
                }

                if ((string)x.Tag == "este3")
                {
                    Canvas.SetLeft(x, 1100);
                }

                if ((string)x.Tag == "cloud")
                {
                    Canvas.SetLeft(x, 300 + temp);
                    temp = 800;
                }
            }

            peliAika.Start();

        }

        private void lopetaPeli()
        {
            peliAika.Stop();
            peliPaattyi = true;
            pisteet = 0;
            txtpisteet.Content += " Peli päättyi!" + Environment.NewLine +
            "Paina R aloittaaksesi uudelleen!";
        }
    }
}
