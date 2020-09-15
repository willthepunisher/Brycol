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

namespace BRYCOL_v0._5.Vues
{
    /// <summary>
    /// Logique d'interaction pour ModifierItems.xaml
    /// </summary>
    public partial class ModifierItems : Window
    {
        public string couleurRGB;
        public ModifierItems()
        {
            InitializeComponent();
        }

        

        private void clkContinuer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClrPcker_Background_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            couleurRGB = ClrPcker_Background.SelectedColor.ToString();
        }
    }
}
