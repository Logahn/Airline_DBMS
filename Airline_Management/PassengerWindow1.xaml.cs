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
    /// Interaction logic for PassengerWindow1.xaml
    /// </summary>
    public partial class PassengerWindow1 : Window
    {
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";
        public PassengerWindow1()
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
        private void start_page_Click(object sender, RoutedEventArgs e)
        {
            StartPage subWindow = new StartPage();
            subWindow.Show();
            Close();
        }

        private void book_ticket_Click(object sender, RoutedEventArgs e)
        {
            PassengerBooking subWindow = new PassengerBooking();
            subWindow.Show();
            Close();
        }

        private void view_ticket_Click(object sender, RoutedEventArgs e)
        {
            PassengerTicket subWindow = new PassengerTicket();
            subWindow.Show();
            Close();
        }
    }
}
