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
    /// Interaction logic for PassengerBooking.xaml
    /// </summary>
    public partial class PassengerBooking : Window
    {
        string ID_input = "";
        string ID = "";
        string surname = "";
        string first_name = "";
        string middle_name = "";
        string telephone = "";
        string address = "";
        string passport_number = "";
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";
    
        public PassengerBooking()
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
            ID = textbox9.Text;
            surname = textbox1.Text;
            first_name = textbox2.Text;
            middle_name = textbox3.Text;
            telephone = textbox4.Text;
            address = textbox5.Text;
            passport_number = textbox6.Text;

            int x = Int32.Parse(ID_input);
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO manifest (`ID`,`Фамилия`, `Имя`," +
                $" `Отчество`, `Телефон`, `Место жительства`, `Номер паспорта`) " +
                $"VALUES ({ID},{surname}, {first_name}, {middle_name},{telephone}, {address}, {passport_number})", connection);
          //  DataTable table_display = new DataTable();
           // table_display.Load(cmd.ExecuteReader());
           // gen_Display.DataContext = table_display;
            connection.Close();
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
            textbox4.Clear();
            textbox5.Clear();
            textbox9.Clear();
        }
    }
}