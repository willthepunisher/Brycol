﻿using BRYCOL_v0._5.Vues;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BRYCOL_v0._5
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int choixMenu;

        public MainWindow()
        {
            InitializeComponent();
        }

        #region canvasTest
        //private Point startPoint;
        //private Rectangle rect;

        //private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    startPoint = e.GetPosition(canvas);

        //    rect = new Rectangle
        //    {
        //        Stroke = Brushes.LightBlue,
        //        StrokeThickness = 2
        //    };
        //    Canvas.SetLeft(rect, startPoint.X);
        //    Canvas.SetTop(rect, startPoint.Y);
        //    canvas.Children.Add(rect);
        //}

        //private void Canvas_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.LeftButton == MouseButtonState.Released || rect == null)
        //        return;

        //    var pos = e.GetPosition(canvas);

        //    var x = Math.Min(pos.X, startPoint.X);
        //    var y = Math.Min(pos.Y, startPoint.Y);

        //    var w = Math.Max(pos.X, startPoint.X) - x;
        //    var h = Math.Max(pos.Y, startPoint.Y) - y;

        //    rect.Width = w;
        //    rect.Height = h;

        //    Canvas.SetLeft(rect, x);
        //    Canvas.SetTop(rect, y);
        //}


        //private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    rect = null;
        //}
        #endregion

        private void clkContinuer(object sender, RoutedEventArgs e)
        {
            if (choixMenu == 1)
            {
                DimensionPiece popup = new DimensionPiece();
                popup.ShowDialog();
                this.grid1.Children.Clear();
                this.grid1.Children.Add(presenteurContenu);
                this.presenteurContenu.Content = new PlanTravail();
            }
            else if (choixMenu == 2)
            {
                MessageBox.Show("Option de téléversement à venir!");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un option");
                //DimensionPiece popup = new DimensionPiece();
                //popup.ShowDialog();
            }



        }

        private void clkCreerPiece(object sender, RoutedEventArgs e)
        {
            choixMenu = 1;
            btnChoixMenu.BorderBrush = Brushes.DarkBlue;
            btnChoixMenu2.BorderBrush = Brushes.Transparent;
        }

        private void clkTeleverserPiece(object sender, RoutedEventArgs e)
        {
            choixMenu = 2;
            btnChoixMenu2.BorderBrush = Brushes.DarkBlue;
            btnChoixMenu.BorderBrush = Brushes.Transparent;
        }
    }
}
