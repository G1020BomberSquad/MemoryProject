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
            System.IO.Stream str = Memory.Properties.Resources.lobby;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            new Spellenscherm().ShowDialog();
        }

        private void Hervatten_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Highscore_Click(object sender, RoutedEventArgs e)
        {
            new Highscores().ShowDialog();
        }

        private void Themas_Click(object sender, RoutedEventArgs e)
        {
            new Thema().ShowDialog();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
