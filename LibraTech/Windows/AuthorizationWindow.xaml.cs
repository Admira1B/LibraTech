using Npgsql;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LibraTech.Windows
{
    public partial class AuthorizationWindow : Window
    {
        DataBase dataBase = new DataBase();
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
            if (LoginTextBox.Text.Length > 0)
            {
                if (PasswordTextBox.Text.Length > 0)
                {
                    try
                    {
                        dataBase.OpenConnection();
                        string query = $@"SELECT ""PK_EmployeeID"" FROM public.""Employee"" WHERE ""Login"" = '{LoginTextBox.Text}' AND ""Password"" = '{PasswordTextBox.Text}'";
                        NpgsqlCommand cmd = new NpgsqlCommand(query, dataBase.GetConnection());
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dataBase.CloseConnection();
                            MainWindow mainWindow = new();
                            mainWindow.Show();
                            this.Close();
                        }
                        else
                        {
                            dataBase.CloseConnection();
                            PasswordTextBox.Text = null;
                            MessageBox.Show("Пользователь не найден");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в подключении к БД");
                    }
                }
                else { MessageBox.Show("Введите пароль"); }
            }
            else { MessageBox.Show("Введите логин"); }
        }

        private void RegistrationButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RegistrationWindows registrationWindow = new();
            registrationWindow.Show();
            this.Close();
        }
    }
}
