using System;
using Npgsql;
using System.Windows;
using System.Windows.Controls;

namespace LibraTech.Windows
{
    public partial class BookAddingWindow : Window
    {
        private readonly DataBase _dataBase = new();
        public BookAddingWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text.Length != 0 && AuthorTextBox.Text.Length != 0 &&
                NumberOfBooksTextBox.Text.Length != 0 && PublisherTextBox.Text.Length != 0 && YearTextBox.Text.Length != 0)
            {
                try
                {
                    _dataBase.OpenConnection();
                    string query = (@$"INSERT iNTO public.""Books""(""FK_AuthorID"", ""FK_PublisherID"", ""Name"", ""PublishingYear"", ""NumberOfBooks"") VAlUES('{int.Parse(AuthorTextBox.Text)}', '{int.Parse(PublisherTextBox.Text)}', '{NameTextBox.Text}', '{int.Parse(YearTextBox.Text)}', '{int.Parse(NumberOfBooksTextBox.Text)}')");
                    NpgsqlCommand cmd = new(query, _dataBase.GetConnection());
                    cmd.ExecuteNonQuery();
                    _dataBase.CloseConnection();

                    MessageBox.Show("Книга была успешно добавлена.");
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
