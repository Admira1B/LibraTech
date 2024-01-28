using Npgsql;
using System;
using System.Windows;


namespace LibraTech.Windows
{
    public partial class BookDistribution : Window
    {
        private readonly DataBase _dataBase = new();
        public BookDistribution()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(ReaderIDTextBox.Text) && !string.IsNullOrWhiteSpace(BookIDTextBox.Text)
                && !string.IsNullOrWhiteSpace(IssueDatePicker.Text) && !string.IsNullOrWhiteSpace(ReturnDatePicker.Text))
            {

                try
                {
                    if (DateTime.Parse(IssueDatePicker.Text) >= DateTime.Parse(ReturnDatePicker.Text))
                    {
                        MessageBox.Show("Дата предполагаемого возврата должна быть после выдачи!");
                        return;
                    }

                    _dataBase.OpenConnection();
                    string query = (@$"INSERT INTO public.""IssueCard""(""FK_EmployeeID"", ""FK_BookID"", ""FK_ReaderID"", ""DateOfIssue"", ""DateOfReturn"")
                                    VALUES(1, {BookIDTextBox.Text}, {ReaderIDTextBox.Text}, '{IssueDatePicker.Text}', '{ReturnDatePicker.Text}')");
                    NpgsqlCommand cmd = new(query, _dataBase.GetConnection());
                    cmd.ExecuteNonQuery();
                    _dataBase.CloseConnection();

                    MessageBox.Show("Книга была успешно выдана.");
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
