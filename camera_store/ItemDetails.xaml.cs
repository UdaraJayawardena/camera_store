using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace camera_store
{
    /// <summary>
    /// Interaction logic for ItemDetails.xaml
    /// </summary>
    public partial class ItemDetails : Window
    {
        public ItemDetails()
        {
            InitializeComponent();
        }

        private void btnSaveItem(object sender, RoutedEventArgs e)
        {

            SqlConnection con;
            SqlCommand cmd;

            //ToDo : Ned to Add OpenFileDialog Box
            DateTime myDateTime = DateTime.Now;
            var createdAt = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string imgUrl = "Image Url Here";
            int id = Int16.Parse(txtboxId.Text);
            int qty= Int16.Parse(txtboxQty.Text);
            string name = txtboxQty.Text;
            double unitPrice = Convert.ToDouble(txtboxQty.Text);


            con = new SqlConnection("Data Source=DESKTOP-SNN93E2;Initial Catalog=CameraStore;Integrated Security=True");

   
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Item VALUES (@id, @name, @qty, @unitPrice, @imgUrl, @createdAt)", con);

                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("qty", qty);
                cmd.Parameters.AddWithValue("unitPrice", unitPrice);
                cmd.Parameters.AddWithValue("imgUrl", imgUrl);
                cmd.Parameters.AddWithValue("createdAt", createdAt);
                
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Save Success");
                    con.Close();
                    cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed");
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

        private void txtboxId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtboxUnitPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtboxQty_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnUpdateItem(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteItem(object sender, RoutedEventArgs e)
        {

        }
    }
}
