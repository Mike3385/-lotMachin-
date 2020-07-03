using System;
using System.Collections.Generic;
using System.IO;
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

namespace _lotMachin_
{
    /// <summary>
    /// Interaction logic for PageGame.xaml
    /// </summary>
    public partial class PageGame : Page
    {
        public PageGame()
        {
            InitializeComponent();
        }
        
        //int win = 0;
        int coins = 0;
        int bet = 10;
        int p1;
        int p2;
        int p3;
        
       
        private void WinCheck()
        {
            if (p1 == p2)
            {
                if (p2 == p3)
                {
                    coins += 100;
                    lbWin.Content = "Win: 100";
                    lbWin.Visibility = Visibility.Visible;
                }
                else
                {
                    coins += 50;
                    lbWin.Content = "Win: 50";
                    lbWin.Visibility = Visibility.Visible;
                }
            }
            else
            {
                lbWin.Visibility = Visibility.Collapsed;
            }
        }
        private void btnSpin_Click(object sender, RoutedEventArgs e)
        {
            if (coins >= bet)
            {
                coins -= bet;
                img1.Visibility = Visibility.Collapsed;
                img2.Visibility = Visibility.Collapsed;
                img3.Visibility = Visibility.Collapsed;
                Random random = new Random();
                p1 = random.Next(8, 13);
                p2 = random.Next(8, 13);
                p3 = random.Next(8, 13);
                img1.Source = new BitmapImage(new Uri(p1.ToString() + ".png", UriKind.RelativeOrAbsolute));
                img2.Source = new BitmapImage(new Uri(p2.ToString() + ".png", UriKind.RelativeOrAbsolute));
                img3.Source = new BitmapImage(new Uri(p3.ToString() + ".png", UriKind.RelativeOrAbsolute));
                WinCheck();
                lbCoins.Content = "Coins: " + coins.ToString();
                img1.Visibility = Visibility.Visible;
                img2.Visibility = Visibility.Visible;
                img3.Visibility = Visibility.Visible;
            }
            else
            {
                btnSpin.Visibility = Visibility.Collapsed;
                lbOutput.Content = "Nicht ausreichend Coins!";
                lbOutput.Visibility = Visibility.Visible;
                btnGetCoins.Visibility = Visibility.Visible;
                
            }
        }

        private void btnGetCoins_Click(object sender, RoutedEventArgs e)
        {
            coins += 1000;
            lbCoins.Content = "Coins: " + coins.ToString();
            btnGetCoins.Visibility = Visibility.Collapsed;
            lbOutput.Visibility = Visibility.Collapsed;
            btnSpin.Visibility = Visibility.Visible;
        }
    }
}
