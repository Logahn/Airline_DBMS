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
    public partial class MainWindow : Window
    {
        string ID_input = "";
        string ID = "";
        string surname = "";
        string first_name = "";
        string middle_name = "";
        string telephone = "";
        string address = "";
        string passport_number = "";
        string query = "";
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";

        public MainWindow()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(connectionString);
           
        }

        private void passengers_button_Click(object sender, RoutedEventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            query = "select * from manifest";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            gen_Display.DataContext = table_display;
            connection.Close();
        }

        private void planes_button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from cамолет", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            gen_Display.DataContext = table_display;
            connection.Close();
        }

        private void airlines_button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from авиакомпания", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            gen_Display.DataContext = table_display;
            connection.Close();
        }

        private void airports_button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from аэропорт", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            gen_Display.DataContext = table_display;
            connection.Close();

        }

        private void tickets_button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  билет", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            gen_Display.DataContext = table_display;
            connection.Close();

        }

        private void pilots_button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from летчик", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            gen_Display.DataContext = table_display;
            connection.Close();
        }

        private void flights_button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from рейс", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            gen_Display.DataContext = table_display;
            connection.Close();

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
        {   try{Close();}
            catch (Exception ex)
            {MessageBox.Show(ex.Message);}
        }
        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {   try{ this.WindowState = WindowState.Minimized;
            }catch (Exception ex)
            {MessageBox.Show(ex.Message);}
        }
        private void resizeApp(object sender, MouseButtonEventArgs e)
        {   try{ this.WindowState = WindowState.Normal;}
            catch (Exception ex)
            {MessageBox.Show(ex.Message);}
        }

        private void add_row_Click(object sender, RoutedEventArgs e)
        {
            ID = textbox9.Text;
            surname = textbox1.Text;
            first_name = textbox2.Text;
            middle_name = textbox3.Text;
            telephone = textbox4.Text;
            address = textbox5.Text;
            passport_number = textbox6.Text;

            int x = Int32.Parse(ID);
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO manifest (`Фамилия`, `Имя`," +
                $" `Отчество`, `Телефон`, `Место жительства`, `Номер паспорта`) " +
                $"VALUES ({@surname}, {@first_name}, {@middle_name},{@telephone}, {@address}, {@passport_number})", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            gen_Display.DataContext = table_display;
            connection.Close();
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
            textbox4.Clear();
            textbox5.Clear();
            textbox9.Clear();
        }

        private void delete_row_Click(object sender, RoutedEventArgs e)
        {
            ID_input = textbox7.Text;
            int x = Int32.Parse(ID_input);
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand($"Delete FROM manifest WHERE ID = {ID_input}", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            MessageBox.Show("Data Deleted");
            gen_Display.DataContext = table_display;
            connection.Close();
            textbox7.Clear();
        }

        private void find_row_Click(object sender, RoutedEventArgs e)
        {
            ID_input = textbox8.Text;
            //int x = Int32.Parse(ID_input);
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM manifest WHERE ID = {ID_input}", connection);
            DataTable table_display = new DataTable();
            table_display.Load(cmd.ExecuteReader());
            MessageBox.Show("Search completed");
            gen_Display.DataContext = table_display;
            connection.Close();
            textbox8.Clear();

        }

        private void user_window_Click(object sender, RoutedEventArgs e)
        {
            UserWindow1 subWindow = new UserWindow1();
            subWindow.Show();
            Close();
        }

        private void user_window2_Click(object sender, RoutedEventArgs e)
        {
            UserWindow2 subWindow = new UserWindow2();
            subWindow.Show();
            Close();
        }

        private void user_window3_Click(object sender, RoutedEventArgs e)
        {
            UserWindow3 subWindow = new UserWindow3();
            subWindow.Show();
            Close();
        }

        private void user_window4_Click(object sender, RoutedEventArgs e)
        {
            UserWindow4 subWindow = new UserWindow4();
            subWindow.Show();
            Close();
        }

        private void start_page_Click(object sender, RoutedEventArgs e)
        {
            StartPage subWindow = new StartPage();
            subWindow.Show();
            Close();
        }
    }
}
