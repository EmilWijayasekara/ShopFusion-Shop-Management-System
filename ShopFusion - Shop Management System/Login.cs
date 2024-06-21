using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopFusion___Shop_Management_System
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        SqlConnection connection;

        private void button_Login_LoginFrame_Click(object sender, EventArgs e)
        {
            if (guna2TextBox_Username_LoginFrame.Text.Trim() == "")
            {
                MessageBox.Show("Enter your username to continue", "ShopFusion - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (guna2TextBox_Password_LoginFrame.Text.Trim() == "")
            {
                MessageBox.Show("Enter your password to continue", "ShopFusion - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userName = guna2TextBox_Username_LoginFrame.Text.Trim();
            string userPassword = guna2TextBox_Password_LoginFrame.Text.Trim();

            try
            {
                ConnectToSQLServer connectToSQLServer = new ConnectToSQLServer();
                connection = connectToSQLServer.connect();

                SqlCommand command = new SqlCommand("SELECT * FROM loginUsers WHERE userName=@userName AND userPassword=@userPassword",connection);

                command.Parameters.AddWithValue("@username", userName);
                command.Parameters.AddWithValue ("@userPassword", userPassword);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                int isValid = dataSet.Tables[0].Rows.Count;

                if(isValid == 1)
                {
                    MessageBox.Show("Succsel", "ShopFusion - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password", "ShopFusion - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                    
                }
                guna2TextBox_Username_LoginFrame.Clear();
                guna2TextBox_Password_LoginFrame.Clear();
            }
        }
    }
}
