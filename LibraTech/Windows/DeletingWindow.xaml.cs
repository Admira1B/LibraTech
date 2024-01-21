using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace LibraTech.Windows
{
    /// <summary>
    /// Логика взаимодействия для DeletingWindow.xaml
    /// </summary>
    public partial class DeletingWindow : Window
    {
        DataBase dataBase = new DataBase();
        public string query;
        private ApplicationState _currentState;
      
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
