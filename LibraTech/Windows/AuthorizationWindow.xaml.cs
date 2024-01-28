using Npgsql;
using System;
using System.Windows;
using System.Windows.Input;


namespace LibraTech.Windows
{
    public partial class AuthorizationWindow : Window
    {
        private readonly DataBase dataBase = new();
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
                if (PasswordBox.Password.Length > 0)
                {
                    try
                    {
                        dataBase.OpenConnection();
                        string query = $@"SELECT ""FK_PostID"" FROM public.""Employee"" WHERE ""Login"" = '{LoginTextBox.Text}' AND ""Password"" = '{PasswordBox.Password}'";
                        NpgsqlCommand cmd = new(query, dataBase.GetConnection());
                        var role = cmd.ExecuteScalar();
                        if (role != null)
                        {
                            dataBase.CloseConnection();

                            MainWindow mainWindow = new(role.ToString());
                            mainWindow.Show();
                            this.Close();
                        }
                        else
                        {
                            dataBase.CloseConnection();
                            PasswordBox.Password = null;
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
