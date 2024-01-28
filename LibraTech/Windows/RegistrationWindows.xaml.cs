using Npgsql;
using System;
using System.Windows;
using System.Windows.Input;


namespace LibraTech.Windows
{
    public partial class RegistrationWindows : Window
    {
        private readonly DataBase dataBase = new();
        private string query;
        public RegistrationWindows()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void OffButton_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private bool CheckForExistence()
        {
            try
            {
                dataBase.OpenConnection();
                string query = $@"SELECT ""PK_EmployeeID"" FROM public.""Employee"" WHERE ""Login"" = '{LoginTextBox.Text}'";
                NpgsqlCommand cmd = new NpgsqlCommand(query, dataBase.GetConnection());
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dataBase.CloseConnection();
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return false;
                }
                dataBase.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (FIOTextBox.Text.Length > 0)
            {
                if (LoginTextBox.Text.Length > 0)
                {
                    if (PasswordBox.Password.Length > 0)
                    {
                        if (CheckForExistence())
                        {
                            try
                            {
                                dataBase.OpenConnection();
                                query = $@"INSERT INTO public.""Employee""(""FK_PostID"", ""EmployeeName"", ""Login"", ""Password"") values(1, '{FIOTextBox.Text}', '{LoginTextBox.Text}', '{PasswordBox.Password}')";
                                NpgsqlCommand cmd = new NpgsqlCommand(query, dataBase.GetConnection());
                                cmd.ExecuteNonQuery();

                                dataBase.CloseConnection();
                                AuthorizationWindow authorizationWindow = new();
                                authorizationWindow.Show();
                                this.Close();
                            }
                            catch (Exception)
                            {
                                dataBase.CloseConnection();
                                PasswordBox.Password = null;
                                MessageBox.Show("Пользователь не найден");
                            }

                        }
                    }
                    else { MessageBox.Show("Введите пароль"); }
                }
                else { MessageBox.Show("Введите логин"); }
            }
            else { MessageBox.Show("Введите ФИО"); }
        }

        private void BackButton_Click(object sender, MouseButtonEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
