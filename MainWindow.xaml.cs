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

namespace Assassins_Creed_Remastered_Installer
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

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private async void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private async void Install_Click(object sender, RoutedEventArgs e)
        {
            Progress.Value = 0;
            TextProgress.Text = "0%";
            while (Progress.Value < 100)
            {
                Progress.Value++;
                TextProgress.Text = Progress.Value + "%";
                await Task.Delay(100); // Simulate some work being done
            }
        }

        private async void Uninstall_Click(object sender, RoutedEventArgs e)
        {
            Progress.Value = 0;
            TextProgress.Text = "0%";
        }
    }
}
