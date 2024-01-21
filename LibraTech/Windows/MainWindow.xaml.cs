using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using Npgsql;


namespace LibraTech.Windows
{
    public partial class MainWindow : Window
    {
        private readonly DataBase _dataBase = new();
        private ApplicationState _currentState;
        public MainWindow()
        {

                InitializeComponent();
                WindowStartupLocation = WindowStartupLocation.CenterScreen;

                _currentState = ApplicationState.Books;
                LoadBooksData();
                AddButton.Visibility = Visibility.Visible;
                DeleteButton.Visibility = Visibility.Visible;
        }


        // Загрузка данных из БД.
        private void LoadBooksData()
        {
            try
            {
                _dataBase.OpenConnection();
                string query = (@"SELECT * FROM public.""Books"" 
                                JOIN public.""Authors"" ON public.""Books"".""FK_AuthorID""=""PK_AuthorID""
                                JOIN public.""Publishers"" ON public.""Books"".""FK_PublisherID"" = ""PK_PublisherID""
                                ORDER BY ""PK_BookID"" ASC ");
                NpgsqlCommand cmd = new(query, _dataBase.GetConnection());
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    DataTable books = new();
                    books.Load(reader);
                    DataGrid BooksGrid = (DataGrid)this.FindName("BooksGrid");
                    BooksGrid.ItemsSource = books.DefaultView;
                }
                _dataBase.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void LoadReadersData()
        {
            try
            {
                _dataBase.OpenConnection();
                string query = (@"SELECT * FROM public.""Readers""
                                JOIN public.""Statuses"" ON public.""Readers"".""FK_StatusID""=""PK_StatusID""
                                ORDER BY ""PK_ReaderID"" ASC");
                NpgsqlCommand cmd = new(query, _dataBase.GetConnection());
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    DataTable readers = new();
                    readers.Load(reader);
                    DataGrid ReadersGrid = (DataGrid)this.FindName("ReadersGrid");
                    ReadersGrid.ItemsSource = readers.DefaultView;
                }
                _dataBase.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadIssueCardsData()
        {
            try
            {
                _dataBase.OpenConnection();
                string query = (@"SELECT * FROM public.""IssueCard""
                                JOIN public.""Books"" ON ""Books"".""PK_BookID"" = ""IssueCard"".""FK_BookID""
                                JOIN public.""Employee"" ON ""Employee"".""PK_EmployeeID"" = ""IssueCard"".""FK_EmployeeID""
                                JOIN public.""Readers"" ON ""Readers"".""PK_ReaderID"" = ""IssueCard"".""FK_ReaderID""
                                ORDER BY ""PK_CardID"" ASC");
                NpgsqlCommand cmd = new(query, _dataBase.GetConnection());
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    DataTable IssueCards = new();
                    IssueCards.Load(reader);
                    DataGrid IssueCardsGrid = (DataGrid)this.FindName("TakenBooksGrid");
                    IssueCardsGrid.ItemsSource = IssueCards.DefaultView;
                }
                _dataBase.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadLibrariansData()
        {
            try
            {
                _dataBase.OpenConnection();
                string query = (@"SELECT * FROM public.""Employee""
                                ORDER BY ""PK_EmployeeID"" ASC ");
                NpgsqlCommand cmd = new(query, _dataBase.GetConnection());
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    DataTable Librarians = new();
                    Librarians.Load(reader);
                    DataGrid LibrariansGrid = (DataGrid)this.FindName("LibrariansGrid");
                    LibrariansGrid.ItemsSource = Librarians.DefaultView;
                }
                _dataBase.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadLogsData()
        {
            try
            {
                _dataBase.OpenConnection();
                string query = (@"SELECT * FROM public.""Logs""
                                JOIN public.""Employee"" ON ""Employee"".""PK_EmployeeID"" = ""Logs"".""FK_EmployeeID""
                                ORDER BY ""PK_LogID"" ASC ");
                NpgsqlCommand cmd = new(query, _dataBase.GetConnection());
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    DataTable Logs = new();
                    Logs.Load(reader);
                    DataGrid LibrariansGrid = (DataGrid)this.FindName("LogsGrid");
                    LogsGrid.ItemsSource = Logs.DefaultView;
                }
                _dataBase.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        // Кнопки выключения и выхода из аккаунта.
        private void OffButton_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void UnauthorizationButton_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new();
            authorizationWindow.Show();
            this.Close();
        }


        // Показ таблиц с данными.
        private void BooksRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _currentState = ApplicationState.Books;
            BooksStackPanel.Visibility = Visibility.Visible;
            ReadersStackPanel.Visibility = Visibility.Collapsed;
            TakenBooksStackPanel.Visibility = Visibility.Collapsed;
            LogsStackPanel.Visibility = Visibility.Collapsed;
            LibrariansStackPanel.Visibility = Visibility.Collapsed;
            LoadBooksData();
        }
        private void BooksButton_Click(object sender, RoutedEventArgs e)
        {
            AddButton.Visibility = Visibility.Visible;
            DeleteButton.Visibility = Visibility.Visible;
        }

        private void ReadersRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _currentState = ApplicationState.Readers;
            ReadersStackPanel.Visibility = Visibility.Visible;
            BooksStackPanel.Visibility = Visibility.Collapsed;
            TakenBooksStackPanel.Visibility = Visibility.Collapsed;
            LogsStackPanel.Visibility = Visibility.Collapsed;
            LibrariansStackPanel.Visibility = Visibility.Collapsed;
            LoadReadersData();
            AddButton.Visibility = Visibility.Visible;
            DeleteButton.Visibility = Visibility.Visible;
        }

        private void CardsRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _currentState = ApplicationState.IssueCards;
            TakenBooksStackPanel.Visibility = Visibility.Visible;
            ReadersStackPanel.Visibility = Visibility.Collapsed;
            BooksStackPanel.Visibility = Visibility.Collapsed;
            LogsStackPanel.Visibility = Visibility.Collapsed;
            LibrariansStackPanel.Visibility = Visibility.Collapsed;
            LoadIssueCardsData();
            AddButton.Visibility = Visibility.Visible;
            DeleteButton.Visibility = Visibility.Visible;
        }

        private void LibrariansRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _currentState = ApplicationState.Librarians;
            LibrariansStackPanel.Visibility = Visibility.Visible;
            TakenBooksStackPanel.Visibility = Visibility.Collapsed;
            ReadersStackPanel.Visibility = Visibility.Collapsed;
            BooksStackPanel.Visibility = Visibility.Collapsed;
            LogsStackPanel.Visibility = Visibility.Collapsed;
            LoadLibrariansData();
            AddButton.Visibility = Visibility.Collapsed;
            DeleteButton.Visibility = Visibility.Collapsed;
        }

        private void LogsRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _currentState = ApplicationState.Logs;
            LogsStackPanel.Visibility = Visibility.Visible;
            LibrariansStackPanel.Visibility = Visibility.Collapsed;
            TakenBooksStackPanel.Visibility = Visibility.Collapsed;
            ReadersStackPanel.Visibility = Visibility.Collapsed;
            BooksStackPanel.Visibility = Visibility.Collapsed;
            LoadLogsData();
            AddButton.Visibility = Visibility.Collapsed;
            DeleteButton.Visibility = Visibility.Collapsed;
        }


        // Добавление и удаление данных.
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            switch (_currentState)
            {
                case ApplicationState.Readers:
                    break;
                case ApplicationState.Books:
                    break;
                case ApplicationState.IssueCards:
                    break;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            switch (_currentState)
            {
                case ApplicationState.Readers:
                    break;
                case ApplicationState.Books:
                    break;
                case ApplicationState.IssueCards:
                    break;
            }
        }
    }
}
