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
    /// Interaction logic for Login_page.xaml
    /// </summary>
    public partial class Login_page : Window
    {
        string pass = ""; 
        string connectionString = "SERVER=localhost;DATABASE=flight;UID=root;PASSWORD=1234;";

        public Login_page()
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
        private void admin_page_Click(object sender, RoutedEventArgs e)
        {
            pass = password.Text;
            int x = Int32.Parse(pass);
            if (pass == "1234")
            {
                MainWindow subWindow = new MainWindow();
                subWindow.Show();
                Close();
            }
            else
            {
                StartPage subWindow = new StartPage();
                subWindow.Show();
                Close();
            }
        }
    }
}