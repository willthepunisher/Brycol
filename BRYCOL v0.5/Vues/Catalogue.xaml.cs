using BRYCOL_v0._5.Vues;
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
using System.Windows.Shapes;

namespace BRYCOL_v0._5
{
    /// <summary>
    /// Logique d'interaction pour Catalogue.xaml
    /// </summary>
    public partial class Catalogue : Window
    {
        public Catalogue()
        {
            InitializeComponent();
        }

        private void Coucher_Selected(object sender, RoutedEventArgs e)
        {
            presenteurContenu.Content = new EcranLtsChamCou();
        }

        private void Bain_Selected(object sender, RoutedEventArgs e)
        {
            presenteurContenu.Content = new EcranLstChamBain();
        }

        private void Salon_Selected(object sender, RoutedEventArgs e)
        {
            presenteurContenu.Content = new EcranLstSalon();
        }

        private void Cuisine_Selected(object sender, RoutedEventArgs e)
        {
            presenteurContenu.Content = new EcranLstCuisine();
        }

        private void SalMang_Selected(object sender, RoutedEventArgs e)
        {
            presenteurContenu.Content = new EcranLstSalleMan();
        }
    }
}
