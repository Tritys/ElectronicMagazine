﻿using Microsoft.Win32;
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

namespace ElectronicMagazine.Admin
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Message());
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Profile());
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Student());
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Teacher());
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Schedule());
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Links_to_Resources());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new News_and_Updates());
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                Image.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new MainWindow());
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService AppFrame1 = NavigationService.GetNavigationService(this);
            AppFrame1.Navigate(new Documents());
        }
    }
}
