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

namespace Memory
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

        private void newGame_Click(object sender, RoutedEventArgs e)
        {
            new Spellenscherm(0).ShowDialog();
        }

        private void hervatten_Click(object sender, RoutedEventArgs e)
        {
            int load = 1;
            new Spellenscherm(load).ShowDialog();
        }

        private void highscore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void themas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
