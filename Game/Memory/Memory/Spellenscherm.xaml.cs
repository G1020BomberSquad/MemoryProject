﻿using SpellenScherm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.IO;

namespace Memory
{
    /// <summary>
    /// Interaction logic for Spellenscherm.xaml
    /// </summary>
    public partial class Spellenscherm : Window
    {
        private MemoryGrid grid;
        private string path = @"Save1.csv";
        public static string delimiter = ";";

        public Spellenscherm()
        {
            InitializeComponent();
            main = this;
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "ready");
            }
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menuBar.Visibility = Visibility.Visible;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            grid = new MemoryGrid(GameGrid, 4, 4);
            start.Visibility = Visibility.Collapsed;
            name1.Background = Brushes.HotPink;

            SetCardsSave.Write();
        }

        private void setNames_Click(object sender, RoutedEventArgs e)
        {
            string userName1 = nameEnter1.Text;
            string userName2 = nameEnter2.Text;

            // memoryGridInstance.player1 = userName1;
            // memoryGridInstance.player2 = userName2;

            name1.Content = userName1;
            name2.Content = userName2;
            set1.Visibility = Visibility.Collapsed;
            set2.Visibility = Visibility.Collapsed;

            File.WriteAllText(path, userName1 + delimiter + userName2 + Environment.NewLine);
        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You can't save your game yet.");
        }

        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You can't load a game yet.");
        }

        private void ResetGame_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void toMain_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A main screen has not been made yet.");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nl.wikipedia.org/wiki/Memory");
        }

        private void CloseMenuBar_Click(object sender, RoutedEventArgs e)
        {
            menuBar.Visibility = Visibility.Collapsed;
        }

        internal static Spellenscherm main;
        internal string Score1
        {
            get { return scoreName1.Content.ToString(); }
            set { Dispatcher.Invoke(new Action(() => { scoreName1.Content = value; })); }
        }

        internal string Score2
        {
            get { return scoreName2.Content.ToString(); }
            set { Dispatcher.Invoke(new Action(() => { scoreName2.Content = value; })); }
        }

        //internal string setName1
        //{
        //    get { return name1.Background.ToString(); }
        //    set { Dispatcher.Invoke(new Action(() => { name1.Background = value; })); }
        //}

        //internal string setName2
        //{
        //    get { return name2.Background.ToString(); }
        //    set { Dispatcher.Invoke(new Action(() => { name2.Background = value; })); }
        //}

    }
}
