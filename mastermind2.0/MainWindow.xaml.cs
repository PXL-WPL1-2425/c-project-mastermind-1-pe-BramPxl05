﻿using System.Security.AccessControl;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace mastermind2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        int attempts = 1;
       
        public MainWindow()
        {
            timer.Tick += Timer_Tick;

            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            InitializeComponent();
            InitializeComponent();

            Random rnd = new Random();
            int kleur1 = rnd.Next(1, 7);
            int kleur2 = rnd.Next(1, 7);
            int kleur3 = rnd.Next(1, 7);
            int kleur4 = rnd.Next(1, 7);

            //string kleurtext1 = Convert.ToString(kleur1);
            //string kleurtext2 = Convert.ToString(kleur2);
            //string kleurtext3 = Convert.ToString(kleur3);
            //string kleurtext4 = Convert.ToString(kleur4);

            string kleurtext1 = "";
            string kleurtext2 = "";
            string kleurtext3 = "";
            string kleurtext4 = "";

            //KLEUR 1

            if (kleur1 == 1)
            {
                kleurtext1 = "rood";
            }
            else if (kleur1 == 2)
            {
                kleurtext1 = "geel";
            }
            else if (kleur1 == 3)
            {
                kleurtext1 = "oranje";
            }
            else if (kleur1 == 4)
            {
                kleurtext1 = "wit";
            }
            else if (kleur1 == 5)
            {
                kleurtext1 = "groen";
            }
            else if (kleur1 == 6)
            {
                kleurtext1 = "blauw";
            }


            //KLEUR 2

            if (kleur2 == 1)
            {
                kleurtext2 = "rood";
            }
            else if (kleur2 == 2)
            {
                kleurtext2 = "geel";
            }
            else if (kleur2 == 3)
            {
                kleurtext2 = "oranje";
            }
            else if (kleur2 == 4)
            {
                kleurtext2 = "wit";
            }
            else if (kleur2 == 5)
            {
                kleurtext2 = "groen";
            }
            else if (kleur2 == 6)
            {
                kleurtext2 = "blauw";
            }

            //KLEUR 3

            if (kleur3 == 1)
            {
                kleurtext3 = "rood";
            }
            else if (kleur3 == 2)
            {
                kleurtext3 = "geel";
            }
            else if (kleur3 == 3)
            {
                kleurtext3 = "oranje";
            }
            else if (kleur3 == 4)
            {
                kleurtext3 = "wit";
            }
            else if (kleur3 == 5)
            {
                kleurtext3 = "groen";
            }
            else if (kleur3 == 6)
            {
                kleurtext3 = "blauw";
            }

            //KLEUR 4

            if (kleur4 == 1)
            {
                kleurtext4 = "rood";
            }
            else if (kleur4 == 2)
            {
                kleurtext4 = "geel";
            }
            else if (kleur4 == 3)
            {
                kleurtext4 = "oranje";
            }
            else if (kleur4 == 4)
            {
                kleurtext4 = "wit";
            }
            else if (kleur4 == 5)
            {
                kleurtext4 = "groen";
            }
            else if (kleur4 == 6)
            {
                kleurtext4 = "blauw";
            }

            //this.Title = ($"{kleurtext1}, {kleurtext2}, {kleurtext3}, {kleurtext4}");

            randomkleur1.Content = kleurtext1;
            randomkleur2.Content = kleurtext2;
            randomkleur3.Content = kleurtext3;
            randomkleur4.Content = kleurtext4;

           

            this.Title = $"poging {attempts}";

            toggledebug.Text = ($"{kleurtext1}, {kleurtext2}, {kleurtext3}, {kleurtext4}");

           



        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            countdown.Text = $"{DateTime.Now.ToShortTimeString()}";
        }

        private Brush GetColorFromIndex(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 1:
                    return Brushes.Red; 
                case 2:
                    return Brushes.Yellow;
                case 3:
                    return Brushes.Orange;
                case 4:
                    return Brushes.White;
                case 5:
                    return Brushes.Green;
                case 6:
                    return Brushes.Blue;
                default:
                    return Brushes.Black;
            }
        }

        private void ButtonKleurRood1_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak1.Background = Brushes.Red.Clone();
            kleurvlak1.Content = "rood";
        }

        private void ButtonKleurGeel1_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak1.Background = Brushes.Yellow;
            kleurvlak1.Content = "geel";
        }

        private void ButtonKleurOranje1_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak1.Background = Brushes.Orange.Clone();
            kleurvlak1.Content = "oranje";
        }

        private void ButtonKleurWit1_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak1.Background = Brushes.Beige.Clone();
            kleurvlak1.Content = "wit";
        }

        private void ButtonKleurGroen1_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak1.Background = Brushes.Green.Clone();
            kleurvlak1.Content = "groen";
        }

        private void ButtonKleurBlauw1_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak1.Background = Brushes.Blue.Clone();
            kleurvlak1.Content = "blauw";
        }

        private void ButtonKleurRood2_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak2.Background = Brushes.Red.Clone();
            kleurvlak2.Content = "rood";
        }

        private void ButtonKleurgeel2_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak2.Background = Brushes.Yellow.Clone();
            kleurvlak2.Content = "geel";
        }

        private void ButtonKleurOranje2_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak2.Background = Brushes.Orange.Clone();
            kleurvlak2.Content = "oranje";
        }

        private void ButtonKleurWit2_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak2.Background = Brushes.Beige.Clone();
            kleurvlak2.Content = "wit";
        }

        private void ButtonKleurGroen2_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak2.Background = Brushes.Green.Clone();
            kleurvlak2.Content = "groen";
        }

        private void ButtonKleurBlauw2_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak2.Background = Brushes.Blue.Clone();
            kleurvlak2.Content = "blauw";
        }

        private void ButtonKleurRood3_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak3.Background = Brushes.Red.Clone();
            kleurvlak3.Content = "rood";
        }

        private void ButtonKleurGeel3_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak3.Background = Brushes.Yellow.Clone();
            kleurvlak3.Content = "geel";
        }

        private void ButtonKleurOranje3_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak3.Background = Brushes.Orange.Clone();
            kleurvlak3.Content = "oranje";
        }

        private void ButtonKleurWit3_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak3.Background = Brushes.Beige.Clone();
            kleurvlak3.Content = "wit";
        }

        private void ButtonKleurGroen3_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak3.Background = Brushes.Green.Clone();
            kleurvlak3.Content = "groen";
        }

        private void ButtonKleurBlauw3_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak3.Background = Brushes.Blue.Clone();
            kleurvlak3.Content = "blauw";
        }

        private void ButtonKleurRood4_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak4.Background = Brushes.Red.Clone();
            kleurvlak4.Content = "rood";
        }

        private void ButtonKleurGeel4_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak4.Background = Brushes.Yellow.Clone();
            kleurvlak4.Content = "geel";
        }

        private void ButtonKleurOranje4_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak4.Background = Brushes.Orange.Clone();
            kleurvlak4.Content = "oranje";
        }

        private void ButtonKleurWit4_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak4.Background = Brushes.Beige.Clone();
            kleurvlak4.Content = "wit";
        }

        private void ButtonKleurGroen4_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak4.Background = Brushes.Green.Clone();
            kleurvlak4.Content = "groen";
        }

        private void ButtonKleurBlauw4_Click(object sender, RoutedEventArgs e)
        {
            kleurvlak4.Background = Brushes.Blue.Clone();
            kleurvlak4.Content = "blauw";
        }

        private void CheckCodeButton_Click(object sender, RoutedEventArgs e)
        {
            string mijnkleur1 = kleurvlak1.ToString();
            string mijnkleur2 = kleurvlak2.ToString();
            string mijnkleur3 = kleurvlak3.ToString();
            string mijnkleur4 = kleurvlak4.ToString();
            string randomkleurkeuze1 = randomkleur1.ToString();
            string randomkleurkeuze2 = randomkleur2.ToString();
            string randomkleurkeuze3 = randomkleur3.ToString();
            string randomkleurkeuze4 = randomkleur4.ToString();

            if (mijnkleur1 == randomkleurkeuze1)
            {
                kleurvlak1.BorderBrush = Brushes.Green;
            }
            else if (mijnkleur1 == randomkleurkeuze2)
            {
                kleurvlak1.BorderBrush = Brushes.Orange;
            }
            else if (mijnkleur1 == randomkleurkeuze3)
            {
                kleurvlak1.BorderBrush = Brushes.Orange;
            }
            else if (mijnkleur1 == randomkleurkeuze4)
            {
                kleurvlak1.BorderBrush = Brushes.Orange;
            }
            else
            {
                kleurvlak1.BorderBrush = Brushes.Red;
            }



            if (mijnkleur2 == randomkleurkeuze2)
            {
                kleurvlak2.BorderBrush = Brushes.Green;
            }
            else if (mijnkleur2 == randomkleurkeuze1)
            {
                kleurvlak2.BorderBrush = Brushes.Orange;
            }
            else if (mijnkleur2 == randomkleurkeuze3)
            {
                kleurvlak2.BorderBrush = Brushes.Orange;
            }
            else if (mijnkleur2 == randomkleurkeuze4)
            {
                kleurvlak2.BorderBrush = Brushes.Orange;
            }
            else
            {
                kleurvlak2.BorderBrush = Brushes.Red;
            }



            if (mijnkleur3 == randomkleurkeuze3)
            {
                kleurvlak3.BorderBrush = Brushes.Green;
            }
            else if (mijnkleur3 == randomkleurkeuze2)
            {
                kleurvlak3.BorderBrush = Brushes.Orange;
            }
            else if (mijnkleur3 == randomkleurkeuze3)
            {
                kleurvlak3.BorderBrush = Brushes.Orange;
            }
            else if (mijnkleur3 == randomkleurkeuze4)
            {
                kleurvlak3.BorderBrush = Brushes.Orange;
            }
            else
            {
                kleurvlak3.BorderBrush = Brushes.Red;
            }



            if (mijnkleur4 == randomkleurkeuze4)
            {
                kleurvlak4.BorderBrush = Brushes.Green;
            }
            else if (mijnkleur4 == randomkleurkeuze2)
            {
                kleurvlak4.BorderBrush = Brushes.Orange;
            }
            else if (mijnkleur4 == randomkleurkeuze3)
            {
                kleurvlak4.BorderBrush = Brushes.Orange;
            }
            else if (mijnkleur4 == randomkleurkeuze1)
            {
                kleurvlak4.BorderBrush = Brushes.Orange;
            }
            else
            {
                kleurvlak4.BorderBrush = Brushes.Red;
            }

            attempts++;
            this.Title = $"poging {attempts}";













        }

        private void toggledebug_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key == Key.LeftCtrl && e.Key = Key.F12)
            //{
            //    toggledebug.Visibility = Visibility.Visible;
            //}
        }
    } 
} 