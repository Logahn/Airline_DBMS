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
    /// Interaction logic for UserWindow4.xaml
    /// </summary>
    public partial class StartPage : Window
    {
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";
        public StartPage()
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
            Login_page subWindow = new Login_page();
            subWindow.Show();
            Close();
        }


        private void passenger_window_Click(object sender, RoutedEventArgs e)
        {
            PassengerWindow1 subWindow = new PassengerWindow1();
            subWindow.Show();
            Close();
        }

      
    }
}
