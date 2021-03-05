using Hanssens.Net;
using System;
using System.Collections.Generic;
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
using System.Data.SQLite;
using System.IO;

namespace camera_store
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            createDBFile();
        }
        public SQLiteConnection conn;

        private void createDBFile()
        {
                           
            conn = new SQLiteConnection("Data Source=camera_store.sqlite3");

            if (!File.Exists("./camera_store.sqlite3"))
            {
                SQLiteConnection.CreateFile("camera_store.sqlite3");
                System.Console.WriteLine("DB File Created");
            }
            else
            {
                System.Console.WriteLine("DB File Already Created");
            }
        }

    /*
            public LocalStorage localStorageInitialize()
            {
                var config = new LocalStorageConfiguration()
                {
                    AutoLoad = true
                };

                var storage = new LocalStorage(config);
                return storage;
            }
    */

        private void btnSignIn(object sender, RoutedEventArgs e)
        {

        }

        private void btnSignUp(object sender, RoutedEventArgs e)
        {
            var userRegistration = new userRegistration("UDARA");
            userRegistration.Show();
            this.Close();
        }

        private void btnItemDetails(object sender, RoutedEventArgs e)
        {
            var itemDetails = new ItemDetails();
            itemDetails.Show();
            this.Close();
        }
    }
}
