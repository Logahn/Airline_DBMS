﻿using System;
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
    public partial class UserWindow3 : Window
    {
        string value = "";
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";

        public UserWindow3()
        {
            InitializeComponent();
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

        private void query_Click(object sender, RoutedEventArgs e)
        {
            value = textbox1.Text;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selected = combobox.Text;
            //MessageBox.Show(selected);

            if (selected == "Запрос стоимости билета")
            {
                int x = Int32.Parse(value);
                if (value == null)
                {
                    MessageBox.Show("No Entry");
                    Close();
                }
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM билет WHERE `Цена билета` >= {value}", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
                //textbox1.Clear();
            }
            else if (selected == "Запрос продолжительности полета")
            {
                int x = Int32.Parse(value);
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM рейс WHERE `Продолжительность полета (Ч)` >= {value}", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
                //textbox1.Clear();
            }
            else if (selected == "Запрос страны аэропортов")
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM аэропорт WHERE Страна LIKE '{value}%'", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
               // textbox1.Clear();
            }
            else if (selected == "Запрос страны авиакомпании")
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM авиакомпания WHERE `Страна авиакомпании` LIKE '{value}%'", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
               // textbox1.Clear();
            }
            else if (selected == "Запрос количества мест")
            {
                int x = Int32.Parse(value);
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM cамолет WHERE `Количество посадочных мест` >= {value}", connection);
                DataTable table_display = new DataTable();
                table_display.Load(cmd.ExecuteReader());
                search_data_grid.DataContext = table_display;
                connection.Close();
               // textbox1.Clear();
            }

        }
    }
}
