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
using BRYCOL_v0._5.Vues;

namespace BRYCOL_v0._5
{
    /// <summary>
    /// Logique d'interaction pour DimensionPiece.xaml
    /// </summary>
    public partial class DimensionPiece : Window
    {
        public MainWindow MainWindow = new MainWindow();

        public DimensionPiece()
        {
            InitializeComponent();
        }

        private void clkContinuer(object sender, RoutedEventArgs e)
        {

            this.Close();
            MainWindow.grid1.Visibility = Visibility.Collapsed;
            MainWindow.presenteurContenu.Content = new PlanTravail();
        }
    }
}
