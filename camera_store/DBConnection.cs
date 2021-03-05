using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camera_store
{
     class DBConnection
    {

        public SQLiteConnection conn;
        public DBConnection()
        {
            conn = new SQLiteConnection("Data Source=camera_store.sqlite3");
            if (!File.Exists("./camera_store.sqlite3"))
            {
                SQLiteConnection.CreateFile("camera_store.sqlite3");
                System.Console.WriteLine("DB File Created");
            }
        }

        public void openDBConnection()
        {

            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void closeDBConnection()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }

        }
    }
}
