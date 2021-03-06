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

namespace VSMSample
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

        private void OnOne(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(grid1, "One", useTransitions: true);
        }

        private void OnTwo(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(grid1, "Two", useTransitions: true);
        }
    }
}
