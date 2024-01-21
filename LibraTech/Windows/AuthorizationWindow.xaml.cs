using System;
using System.Windows;
using System.Windows.Input;

namespace LibraTech.Windows
{
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void OffButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            this.Close();
        }
    }
}
