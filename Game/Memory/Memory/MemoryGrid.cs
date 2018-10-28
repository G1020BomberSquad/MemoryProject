﻿using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Text;

namespace SpellenScherm
{
    public class MemoryGrid
    {
        private Grid grid;
        public string player1 { get; set; }
        public string player2 { get; set; }
        private int rows, cols;
        static int numberOfClicks = 0;
        static int scoreName1Tot;
        static int scoreName2Tot;
        static int scoreName1;
        static int scoreName2;
        static int numberOfPairs;
        private bool hasDelay;
        private bool turnName1 = true;
        private bool turnName2 = false;
        private Image card;
        private Image Image1;
        private Image Image2;

        public MemoryGrid(Grid grid, int rows, int cols)
        {
            this.grid = grid;
            this.rows = rows;
            this.cols = cols;

            InitializeGrid();
            AddImages();
        }

        /// <summary>
        /// Initialises the GameGrid
        /// </summary>
        private void InitializeGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < cols; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        /// <summary>
        /// Adds images to the grid
        /// </summary>
        private void AddImages()
        {
            List<ImageSource> images = GetImagesList();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Image back = new Image();
                    back.Source = new BitmapImage(new Uri("/images/back.png", UriKind.Relative));

                    back.MouseDown += new System.Windows.Input.MouseButtonEventHandler(CardClick);

                    back.Tag = images.First();
                    images.RemoveAt(0);
                    Grid.SetColumn(back, col);
                    Grid.SetRow(back, row);
                    grid.Children.Add(back);
                }
            }
        }

        /// <summary>
        /// Give each card a random image
        /// </summary>
        /// <returns>Return the images</returns>
        public List<ImageSource> GetImagesList()
        {
            List<ImageSource> images = new List<ImageSource>();
            List<string> random1 = new List<string>();
            List<string> random2 = new List<string>();


            string C1 = null;
            string C2 = null;
            string C3 = null;
            string C4 = null;
            string C5 = null;
            string C6 = null;
            string C7 = null;
            string C8 = null;
            string C9 = null;
            string C10 = null;
            string C11 = null;
            string C12 = null;
            string C13 = null;
            string C14 = null;
            string C15 = null;
            string C16 = null;

            for (int i = 0; i < 16; i++)
            {
                if (i < 8)
                {
                    int imageNR = 0;

                    Random rnd = new Random();
                    imageNR = rnd.Next(1, 9);
                    if (random1.Contains(Convert.ToString(imageNR)))
                    {
                        i--;
                    }
                    else
                    {
                        random1.Add(Convert.ToString(imageNR));
                        ImageSource source = new BitmapImage(new Uri("images/" + imageNR + ".png", UriKind.Relative));
                        images.Add(source);

                        string path = @"Save1.csv";

                        var reader = new StreamReader(File.OpenRead(path));
                        var data = new List<List<string>>();

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            data.Add(new List<String> { values[0], values[1]
                        });
                        }
                        reader.Close();

                        string delimiter = ";";

                        if (i == 0)
                        {
                            C1 = Convert.ToString(imageNR);
                        }
                        if (i == 1)
                        {
                            C2 = Convert.ToString(imageNR);
                        }
                        if (i == 2)
                        {
                            C3 = Convert.ToString(imageNR);
                        }
                        if (i == 3)
                        {
                            C4 = Convert.ToString(imageNR);
                        }
                        if (i == 4)
                        {
                            C5 = Convert.ToString(imageNR);
                        }
                        if (i == 5)
                        {
                            C6 = Convert.ToString(imageNR);
                        }
                        if (i == 6)
                        {
                            C7 = Convert.ToString(imageNR);
                        }
                        if (i == 7)
                        {
                            C8 = Convert.ToString(imageNR);
                        }
                    }
                }
                if (i >= 8)
                {
                    int imageNR = 0;

                    Random rnd = new Random();
                    imageNR = rnd.Next(1, 9);
                    if (random2.Contains(Convert.ToString(imageNR)))
                    {
                        i--;
                    }
                    else
                    {
                        random2.Add(Convert.ToString(imageNR));
                        ImageSource source = new BitmapImage(new Uri("images/" + imageNR + ".png", UriKind.Relative));
                        images.Add(source);

                        string path = @"Save1.csv";

                        var reader = new StreamReader(File.OpenRead(path));
                        var data = new List<List<string>>();

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            data.Add(new List<String> { values[0], values[1]
                        });
                        }
                        reader.Close();

                        string delimiter = ";";

                        if (i == 8)
                        {
                            C9 = Convert.ToString(imageNR);
                        }
                        if (i == 9)
                        {
                            C10 = Convert.ToString(imageNR);
                        }
                        if (i == 10)
                        {
                            C11 = Convert.ToString(imageNR);
                        }
                        if (i == 11)
                        {
                            C12 = Convert.ToString(imageNR);
                        }
                        if (i == 12)
                        {
                            C13 = Convert.ToString(imageNR);
                        }
                        if (i == 13)
                        {
                            C14 = Convert.ToString(imageNR);
                        }
                        if (i == 14)
                        {
                            C15 = Convert.ToString(imageNR);
                        }
                        if (i == 15)
                        {
                            C16 = Convert.ToString(imageNR);
                        }


                        File.WriteAllText(path, data[0][0] + delimiter + data[0][1] + Environment.NewLine + C1 + delimiter + C2 + delimiter + C3 + delimiter + C4 + Environment.NewLine + C5 + delimiter + C6 + delimiter + C7 + delimiter + C8 + Environment.NewLine + C9 + delimiter + C10 + delimiter + C11 + delimiter + C12 + Environment.NewLine + C13 + delimiter + C14 + delimiter + C15 + delimiter + C16);
                    }
                }
            }
            return images;
        }

        /// <summary>
        /// Turns the card when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            if (hasDelay) return;

            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
            numberOfClicks++;

            checkCards(card);
        }

        /// <summary>
        /// Highlights player, who's turn it is. (non functional, yet)
        /// </summary>
        private void showTurn()
        {
            if (turnName1 == true)
            {
                var bc = new BrushConverter();









                foreach (Spellenscherm window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Spellenscherm))
                    {
                        (window as Spellenscherm).name1.Background = Brushes.HotPink;
                    }
                }

                foreach (Spellenscherm window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Spellenscherm))
                    {
                        (window as Spellenscherm).name2.Background = (Brush)bc.ConvertFrom("#5d689a");
                    }
                }
            }
            else if (turnName2 == true)
            {
                var bc = new BrushConverter();
                foreach (Spellenscherm window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Spellenscherm))
                    {
                        (window as Spellenscherm).name2.Background = Brushes.HotPink;
                    }
                }

                foreach (Spellenscherm window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(Spellenscherm))
                    {
                        (window as Spellenscherm).name1.Background = (Brush)bc.ConvertFrom("#5d689a");
                    }
                }
            }
        }

        /// <summary>
        /// Grab the clicked card
        /// </summary>
        /// <param name="card">The card that has been clicked</param>
        private void checkCards(Image card)
        {

            this.card = card;
            if (numberOfClicks < 2 || numberOfClicks == 2)
            {

                if (this.Image1 == null)
                {
                    Image1 = card;
                }
                else if (this.Image2 == null)
                {
                    Image2 = card;
                }
            }

            if (numberOfClicks == 2)
            {
                checkPair(Image1, Image2);

                numberOfClicks = 0;
                Image1 = null;
                Image2 = null;
            }
        }

        /// <summary>
        /// Check if the two clicked cards have the same image (source)
        /// </summary>
        /// <param name="card1">The first card that has been clicked</param>
        /// <param name="card2">The second card that has been clicked</param>
        public void checkPair(Image card1, Image card2)
        {
            this.Image1 = card1;
            this.Image2 = card2;

            if (Convert.ToString(card1.Source) == Convert.ToString(card2.Source) && (card1 != card2))
            {
                getPoint(card1, card2);
            }
            else
            {
                resetCards(Image1, Image2);
            }   

            checkTurn();

            if (Convert.ToString(card1.Source) == Convert.ToString(card2.Source) && (card1 == card2))
            {
                stayTurn();
            }

            updateScore();

            if (numberOfPairs == 8)
            {
                checkWinner();
            }

            scoreName1 = 0;
            scoreName2 = 0;
           // showTurn();
        }

        /// <summary>
        /// Gives turns
        /// </summary>
        private void checkTurn()
        {
            if (turnName1 == true)
            {
                if (scoreName1 == 1)
                {
                    scoreName1Tot = scoreName1 + scoreName1Tot;
                }
                else if (scoreName1 == 0)
                {
                    turnName1 = false;
                    turnName2 = true;
                }
            }
            else if (turnName2 == true)
            {
                if (scoreName2 == 1)
                {
                    scoreName2Tot = scoreName2 + scoreName2Tot;
                }
                else if (scoreName2 == 0)
                {
                    turnName2 = false;
                    turnName1 = true;
                }
            }
        }

        /// <summary>
        /// When the same card is doubleclicked, the turn is kept
        /// </summary>
        private void stayTurn()
        {
            if (turnName1 == true)
            {
                turnName1 = false;
                turnName2 = true;
            }
            else if (turnName1 == false)
            {
                turnName1 = true;
                turnName2 = false;
            }
        }

        /// <summary>
        /// Updates Score Labels
        /// </summary>
        private void updateScore()
        {
            Spellenscherm.main.Score1 = "Score: " + scoreName1Tot;
            Spellenscherm.main.Score2 = "Score: " + scoreName2Tot;
        }

        /// <summary>
        /// Give points and remove pairs from GameGrid
        /// </summary>
        /// <param name="card1">The first card that has been clicked</param>
        /// <param name="card2">The second card that has been clicked</param>
        private async void getPoint(Image card1, Image card2)
        {
            if (turnName1 == true)
            {
                numberOfPairs++;
                scoreName1++;
            }
            else if (turnName2 == true)
            {
                numberOfPairs++;
                scoreName2++;
            }

            hasDelay = true;
            await Task.Delay(300);

            card1.Source = new BitmapImage(new Uri("", UriKind.Relative));
            card2.Source = new BitmapImage(new Uri("", UriKind.Relative));

            hasDelay = false;
        }

        /// <summary>
        /// Reset the cards
        /// </summary>
        /// <param name="card1">The first card that has been clicked</param>
        /// <param name="card2">The second card that has been clicked</param>
        private async void resetCards(Image card1, Image card2)
        {
            this.Image1 = card1;
            this.Image2 = card2;

            hasDelay = true;
            await Task.Delay(1000);


            card1.Source = new BitmapImage(new Uri("/images/back.png", UriKind.Relative));
            card2.Source = new BitmapImage(new Uri("/images/back.png", UriKind.Relative));
            hasDelay = false;
        }

        private void checkWinner()
        {
            if (scoreName1Tot == scoreName2Tot)
            {
                MessageBox.Show("Gelijkspel!");
            }
            else
            {
                string winner = (scoreName1Tot > scoreName2Tot) ? player1 : player2;
                MessageBox.Show(winner + " heeft gewonnen!");
            }
        }
    }

    public class SetCardsSave
    {


        public static void Write()
        {
            string path = @"Save1.csv";

            var reader = new StreamReader(File.OpenRead(path));
            var data = new List<List<string>>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                data.Add(new List<String> { values[0], values[1]
                });
            }
            reader.Close();

            string delimiter = ";";

            File.WriteAllText(path, data[0][0] + delimiter + data[0][1] + delimiter + Environment.NewLine + "test");
        }
    }
}
