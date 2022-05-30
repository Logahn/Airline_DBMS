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
    /// Interaction logic for PassengerTicket.xaml
    /// </summary>
    public partial class PassengerTicket : Window
    {
        string value = "";
        string query = "";
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";
        public PassengerTicket()
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
            PassengerWindow1 subWindow = new PassengerWindow1();
            subWindow.Show();
            Close();
        }

        private void order_ticket_Click(object sender, RoutedEventArgs e)
        {
            value = textbox.Text;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
          
            int x = Int32.Parse(value);
            if(value == "")
            { MessageBox.Show("No Entry"); Close(); }

            query = $"SELECT Фамилия, Имя,`ID рейса`,`Город отбытия`, `Город прибытия`, `Время отбытия`, `Ворота отбытия` FROM манифест WHERE ID = {value}";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    black_name.Content = myReader[0].ToString() + myReader[1].ToString();
                    white_name.Content = myReader[0].ToString() + myReader[1].ToString();
                    black_flight.Content = myReader[2].ToString();
                    white_flight.Content = myReader[2].ToString();
                    black_from.Content = myReader[3].ToString();
                    white_from.Content = myReader[3].ToString();
                    black_to.Content = myReader[4].ToString();
                    white_to.Content = myReader[4].ToString();
                    black_date.Content = myReader[5].ToString();
                    white_date.Content = myReader[5].ToString();
                    black_gate.Content = myReader[6].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
