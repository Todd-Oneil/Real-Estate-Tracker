using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstate
{
    public partial class frmLogin : Form
    {
        User loginUser;
        public bool auth { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
        }


        private void Label6_Click(object sender, EventArgs e)
        {
            /*
             * 1. Create registration form object
             * 2. Display resistratoin form
             * 3. Hide current form
             */
            Form1 registerForm = new Form1();// 1
            registerForm.Show();// 2
            Hide();// 3
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            /*
             * 1. Clear inputs
             * 2. Move curser to username input
             */
            txtUsername.Text = txtPassword.Text = string.Empty;
            txtUsername.Focus();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            /*
             * 1. Create User object
             * 2. Call Authentication Method
             * 3. If valid login and show dashboard page
             * 4. If invalid credentials display error message
             */
            loginUser = new User(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            auth = DatabaseConnection.Auth(ref loginUser);
            if(auth == true)
            {
                Dashboard dashboard = new Dashboard(loginUser.GetUsername, loginUser.GetID);
                dashboard.Show();
                this.Hide();
            }
            else if(auth == false)
            {
                MessageBox.Show("Invalid Username or Password", "", MessageBoxButtons.OK);
                Show();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
