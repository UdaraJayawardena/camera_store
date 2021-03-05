using System;
using Hanssens.Net;
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
using System.Windows.Shapes;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace camera_store
{
    /// <summary>
    /// Interaction logic for userRegistration.xaml
    /// </summary>
    public partial class userRegistration : Window
    {
        public userRegistration()
        {
            InitializeComponent();
            fetchLoginStatus();
        }

        public userRegistration(string name)
        {
            InitializeComponent();
            Console.WriteLine("NAME FROM MAIN");
            Console.WriteLine(name);
        }


        SqlConnection con;
        SqlCommand cmd;

        //User Registration
        private void btnSaveUser(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-SNN93E2;Initial Catalog=CameraStore;Integrated Security=True");

            string id, fName, lName, dob, address, imgUrl;
            //string createAt, updatedAt;
            int mobileNumber;

            id = "2";
            fName = "Udara";
            lName = "Jayawardena";
            dob = "1998-01-30";
            address = "mathugama";
            imgUrl = "URL";
            // createAt = DateTime.Now;
            // updatedAt = DateTime.Now;
            mobileNumber = 123;

            try
            {
                con.Open();
                cmd = new SqlCommand("Insert into Test values (@a, @b, @c, @d, @e, @f, @g)", con);

                cmd.Parameters.AddWithValue("a", id);
                cmd.Parameters.AddWithValue("b", fName);
                cmd.Parameters.AddWithValue("c", lName);
                cmd.Parameters.AddWithValue("d", dob);
                cmd.Parameters.AddWithValue("e", address);
                cmd.Parameters.AddWithValue("f", imgUrl);
                cmd.Parameters.AddWithValue("g", mobileNumber);
                // cmd.Parameters.AddWithValue("h", createAt);
                // cmd.Parameters.AddWithValue("i", updatedAt);

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Registration Successful");
                    con.Close();
                    cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("Registration Failed");
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error 1");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error 2");
            }
        }

        //ToDo : Local Storage
        private void btnViewLocalStorage(object sender, RoutedEventArgs e)
        {
      
        }

        //Fixme : SQLite Create user Record
        private void btnCreateLogin(object sender, RoutedEventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            string query = "INSERT INTO Login (`id`, `status`) VALUES (@id, @status)";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbCon.conn);
            dbCon.openDBConnection();

            myCommand.Parameters.AddWithValue("@id", "2");
            myCommand.Parameters.AddWithValue("@status", "LOGOUT");
            
            var result = myCommand.ExecuteNonQuery();
            
            dbCon.closeDBConnection();
            Console.WriteLine("User Created : ", result);
            Console.ReadLine();
        }
   
        //Fixme : SQLite Fetch User details
        private void fetchLoginStatus()
        {
            DBConnection dbCon = new DBConnection();
            string query = "SELECT * FROM Login";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbCon.conn);
            dbCon.openDBConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();
            Console.WriteLine(result.HasRows);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    Console.WriteLine(result);
                }
            }

            dbCon.closeDBConnection();
          //  Console.ReadKey();
        }
   
    }
}
