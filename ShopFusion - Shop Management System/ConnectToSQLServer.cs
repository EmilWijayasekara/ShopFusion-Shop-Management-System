using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopFusion___Shop_Management_System
{
    internal class ConnectToSQLServer
    {
        SqlConnection connection;
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Emil\\Documents\\shopFusionDB.mdf;Integrated Security=True;Connect Timeout=30";

        public SqlConnection connect()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
