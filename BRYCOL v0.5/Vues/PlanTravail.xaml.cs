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

namespace BRYCOL_v0._5.Vues
{
    /// <summary>
    /// Logique d'interaction pour PlanTravail.xaml
    /// </summary>
    public partial class PlanTravail : UserControl
    {
        public PlanTravail()
        {
            InitializeComponent();
        }

        private void clkModifierPiece(object sender, RoutedEventArgs e)
        {
            DimensionPiece popup = new DimensionPiece();
            popup.ShowDialog();
        }

        private void clkEnregistrer(object sender, RoutedEventArgs e)
        {
            Enregistrer popup = new Enregistrer();
            popup.ShowDialog();
        }

        private void clkAjouterMeuble(object sender, RoutedEventArgs e)
        {
            Catalogue popup = new Catalogue();
            popup.ShowDialog();
        }

        private void clkAjouterPiece(object sender, RoutedEventArgs e)
        {
            TextBox dynamicTB = new TextBox();
            dynamicTB.Text = "Nouvelle pièce";
            dynamicTB.Height = 40;
            dynamicTB.FontSize = 20;
            panelPieces.Children.Add(dynamicTB);
        }

        private void clkAide(object sender, RoutedEventArgs e)
        {
            Aide popup = new Aide();
            popup.ShowDialog();
        }

        private void clkModifierMeuble(object sender, RoutedEventArgs e)
        {
            ModifierItems popup = new ModifierItems();
            popup.ShowDialog();
        }
    }
}
