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
   
    public partial class UserWindow1 : Window
    {
        string value = "";
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";
       
        public UserWindow1()
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

        private void find_Click(object sender, RoutedEventArgs e)
        {
            value = textbox1.Text;
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selected = combobox.Text;
            //MessageBox.Show(selected);

            if (selected == "ID")
            {
                int x = Int32.Parse(value);
                if (value == null)
                {
                    MessageBox.Show("No Entry");
                    Close();
                }
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM manifest WHERE ID = {value}", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
                textbox1.Clear();
            }
            else if (selected == "Фамилия")
            { 
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM manifest WHERE Фамилия LIKE '{value}%'", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
                textbox1.Clear();
            }
            else if (selected == "Имя")
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM manifest WHERE Имя LIKE '{value}%'", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
                textbox1.Clear();
            }
            else if (selected == "Номер паспорта")
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM manifest WHERE `Номер паспорта` LIKE '{value}%'", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
                textbox1.Clear();
            }

        }
    }
}
