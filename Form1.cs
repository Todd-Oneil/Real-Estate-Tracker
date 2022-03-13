using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            /*
             * 1. clears all inputs
             */
            txtUsername.Text = txtPassword.Text = txtConfirmPass.Text = string.Empty;// 1
        }

        private void label6_Click(object sender, EventArgs e)
        {
            /*
             * 1. Creates new login form
             * 2. Displays login form
             * 3. Hides current form
             */
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            /*
             * 1. clears all inputs
             * 2. Moves curser to Username
             */
            Clear();
            txtUsername.Focus();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            /*
             * 1. Checks if inputs are empty
             * 2. Check that password fields are the same
             * 3. Checks that password field is longer thatn 3 characters
             */
            string tempName = txtUsername.Text.Trim();
            string tempPass = txtPassword.Text.Trim();
            string tempConfirm = txtConfirmPass.Text.Trim();
            bool exists = false;

            if((tempName.Length == 0 || tempPass.Length == 0 || tempConfirm.Length == 0) )// 1
            {
                MessageBox.Show("Username and Password Fields Cannot be Empty", "Invalid Username/Password", MessageBoxButtons.OK);
            }
            else if(!tempConfirm.Equals(tempPass))
            {
                MessageBox.Show("Invalid Password.  Passwords Must be the Same!", "Invalid Password", MessageBoxButtons.OK);
            }
            else if(tempPass.Length < 3)// 1
            {
                MessageBox.Show("Invalid Password Length.  Passwords Must be Longer Than 3 Characters!", "Invalid Password", MessageBoxButtons.OK);
            }
            else if(registerBtn.Text.Equals("REGISTER"))
            {
                exists = DatabaseConnection.UserCheck(tempName);
                if (exists == false)
                {
                    User user = new User(tempName, User.ComputeHash(tempPass));
                    DatabaseConnection.AddUser(user);
                    Clear();
                }
                else if(exists == true)
                {
                    DialogResult result = MessageBox.Show("Username is taken", "", MessageBoxButtons.OK);
                    if(result == DialogResult.OK)
                    {
                        Show();
                    }
                }
            }
        }

        private void viewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(viewPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
            }
        }
    }
}
