using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopFusion___Shop_Management_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_userName.Text == "" || this.textBox_password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String username = textBox_userName.Text;
            String password = textBox_password.Text;

            try
            {
                
            }
        }
    }
}
