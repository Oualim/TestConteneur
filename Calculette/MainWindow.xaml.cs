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

namespace Calculette
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //
        {
            var actualButton = ((Button)sender).Content.ToString();
            //MessageBox.Show(actualButton);

            Ecran.Text = Ecran.Text + actualButton;
        }

        
        private void RetourZero(object sender, RoutedEventArgs e)
        {
            Ecran.Text = "0";
        }


        private void Inversement(object sender, RoutedEventArgs e)
        {
            

        }


        private void Pourcentage(object sender, RoutedEventArgs e)
        {

        }


        private void Division(object sender, RoutedEventArgs e)
        {

        }


        private void Multiplier(object sender, RoutedEventArgs e)
        {

        }

        private void Soustraire(object sender, RoutedEventArgs e)
        {

        }


        private void Additionner(object sender, RoutedEventArgs e)
        {
            
        }


        private void Egal(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
