using System;
using System.Collections.Generic;
using System.IO;
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

namespace _lotMachin_
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



        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Collapsed;
            tbWelcome.Visibility = Visibility.Collapsed;
            btnAnmelden.Visibility = Visibility.Visible;
            tbNutzername.Visibility = Visibility.Visible;
            
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            
                Application.Current.Shutdown();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAnmelden_Click(object sender, RoutedEventArgs e)
        {
            tbNutzername.Visibility = Visibility.Collapsed;
            btnAnmelden.Visibility = Visibility.Collapsed;
            tbUserName.Text = "Nutzername: " + tbNutzername.Text;
            frmContent.NavigationService.Navigate(new PageGame());
        }
    }
}
