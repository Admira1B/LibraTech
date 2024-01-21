using Npgsql;
using System;
using System.Windows;


namespace LibraTech.Windows
{
    public partial class DeletingWindow : Window
    {
        private readonly DataBase dataBase = new();
        private readonly ApplicationState _currentState;
        private string query;
      
        public DeletingWindow(ApplicationState currentState)
        {
            InitializeComponent();
            _currentState = currentState;

            switch (_currentState)
            {
                case ApplicationState.Readers:
                    DeletingName.Content = "Удаление читателя";
                    break;
                case ApplicationState.Books:
                    DeletingName.Content = "Удаление книги";
                    break;
                case ApplicationState.IssueCards:
                    DeletingName.Content = "Удаление выдачи";
                    break;
            }
        }

        private void DeletingButton_Click(object sender, RoutedEventArgs e)
        {
            dataBase.OpenConnection();
            if (_currentState == ApplicationState.Readers)
            {
                query = $@"DELETE FROM public.""Readers"" WHERE ""PK_ReaderID"" = {DeletingTextBox.Text};";
            }
            else if (_currentState == ApplicationState.Books)
            {
                query = $@"DELETE FROM public.""Books"" WHERE PK_BookID = {DeletingTextBox.Text};";
            }
            else
            {
                query = $@"DELETE FROM public.""IssueCard"" WHERE PK_CardID = {DeletingTextBox.Text};";
            }
            var userConfirm = MessageBox.Show("Вы действительно хотите выполнить удаление?", "Выполнить удаление?", MessageBoxButton.YesNo);
            if (userConfirm == MessageBoxResult.Yes)
            {
                //catch не работает
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, dataBase.GetConnection());
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("ID не найден или не существует");
                }
            }
            this.Close();
        }
    }
}