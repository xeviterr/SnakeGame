﻿using System;
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

namespace Snake2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            Ellipse ellSerp = new Ellipse()
            {
                Fill = Brushes.Green,
                Width = 100,
                Height = 100
            };
            canvas.Children.Add(ellSerp);
            Canvas.SetTop(ellSerp, canvas.ActualHeight / 2);
            Canvas.SetLeft(ellSerp, canvas.ActualWidth / 2);
        }
    }
}
