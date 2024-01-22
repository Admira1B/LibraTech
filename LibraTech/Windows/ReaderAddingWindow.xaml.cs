using System;
using Npgsql;
using System.Windows;


namespace LibraTech.Windows
{
    public partial class ReaderAddingWindow : Window
    {
        private readonly DataBase _dataBase = new();
        public ReaderAddingWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void AddReaderButton_Click(object sender, RoutedEventArgs e)
        {
            if (FirstnameTextBox.Text.Length != 0 && SecondnameTextBox.Text.Length != 0 && 
                MiddlenameTextBox.Text.Length != 0 && TelephoneTextBox.Text.Length != 0 && AddressTextBox.Text.Length != 0)
            {
                try
                {
                    _dataBase.OpenConnection();
                    string query = (@$"INSERT INTO public.""Readers""(""FK_StatusID"", ""FirstName"", ""SecondName"", ""MiddleName"", ""Address"", ""PhoneNumber"")
                                    values(2, '{FirstnameTextBox.Text}', '{SecondnameTextBox.Text}', '{MiddlenameTextBox.Text}', '{AddressTextBox.Text}', '{TelephoneTextBox.Text}')");
                    NpgsqlCommand cmd = new(query, _dataBase.GetConnection());
                    cmd.ExecuteNonQuery();
                    _dataBase.CloseConnection();

                    MessageBox.Show("Читатель был успешно добавлен.");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Тут какая-то ошибка.");
                    _dataBase.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Обратите внимание на то, чтоб все поля были заполнены!");
            }

        }
    }
}
