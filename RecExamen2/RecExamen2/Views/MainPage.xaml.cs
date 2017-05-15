using RecExamen2.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RecExamen2
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //animarBarra(pg1, 1000);
            
        }

        /// <summary>
        /// Metodo que crea las animaciones para las progressbar
        /// pasandole el name del progressbar y el valor del maximo
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="valor"></param>
        private void animacion(ProgressBar pb, double valor)
        {

            Storyboard historia = new Storyboard();    
            DoubleAnimation animacion = new DoubleAnimation();
           
            animacion.From = 0;
            animacion.To = valor;
            animacion.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
            animacion.EnableDependentAnimation = true;

            Storyboard.SetTarget(animacion, pb);
            Storyboard.SetTargetProperty(animacion, "ProgressBar.Value");
            historia.Children.Add(animacion);
            historia.Begin();
        }

        /// <summary>
        /// Aplico las animaciones cuando se hace click en los elementos del listview
        /// 
        /// NO ME GUSTA COMO LO HAGO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvCampeones_ItemClick(object sender, ItemClickEventArgs e)
        {

            double vida = 0;
            double rege = 0;
            double danno = 0;
            double armor = 0;
            double velAta = 0;
            double resis = 0;
            double velMov = 0;
            string seleccionado = lsvCampeones.SelectedIndex.ToString();

            switch (seleccionado)
            {
                case "0":
                    vida = 537.8;
                    rege = 6.59;
                    danno = 60.4;
                    armor = 24.4;
                    velAta = 0.651;
                    resis = 30;
                    velMov = 345;
                    break;

                case "1":
                    vida = 514;
                    rege = 6.5;
                    danno = 53;
                    armor = 20.9;
                    velAta = 0.668;
                    resis = 32.1;
                    velMov = 330;
                    break;

                case "2":
                    vida = 587.8;
                    rege = 8.34;
                    danno = 58.4;
                    armor = 26.4;
                    velAta = 0.694;
                    resis = 32.1;
                    velMov = 350;
                    break;

                case "3":
                    vida = 613.3;
                    rege = 8.68;
                    danno = 61.1;
                    armor = 24.4;
                    velAta = 0.625;
                    resis = 32.1;
                    velMov = 330;
                    break;

                case "4":
                    vida = 613.12;
                    rege = 8.88;
                    danno = 53.4;
                    armor = 23.5;
                    velAta = 0.638;
                    resis = 32.1;
                    velMov = 335;
                    break;

                case "5":
                    vida = 467.6;
                    rege = 5.57;
                    danno = 51.4;
                    armor = 21.2;
                    velAta = 0.625;
                    resis = 30;
                    velMov = 325;
                    break;

            }

            animacion(pgVida, vida);
            animacion(pgRege, rege);
            animacion(pgDanno, danno);
            animacion(pgArmor, armor);
            animacion(pgVelAta, velAta);
            animacion(pgResis, resis);
            animacion(pgVelMov, velMov);

        }
    }    

}
