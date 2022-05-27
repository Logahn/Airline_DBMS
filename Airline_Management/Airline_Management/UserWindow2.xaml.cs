using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airline_Management
{
    /// <summary>
    /// Interaction logic for UserWindow2.xaml
    /// </summary>
    public partial class UserWindow2 : Window
    {
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";
        public UserWindow2()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(connectionString);
        }
        private void dragMe(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

            }
        }

        private void closeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Normal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void main_window_Click(object sender, RoutedEventArgs e)
        {
            MainWindow subWindow = new MainWindow();
            subWindow.Show();
            Close();
        }

        private void contact_view_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from contact_view", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            view_data_grid.DataContext = table_display;
            connection.Close();
        }

        private void manifest_view_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from манифест", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            view_data_grid.DataContext = table_display;
            connection.Close();
        }

        private void pilot_view_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from pilot_view", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            view_data_grid.DataContext = table_display;
            connection.Close();
        }
               
    }
}
