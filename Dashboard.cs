using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class Dashboard : Form
    {
        string loggedUser;
        int loggedID;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string name, int ID)
        {
            InitializeComponent();
            loggedUser = name;
            loggedID = ID;
            greetingLabel.Text = "Welcome " + loggedUser;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addProperty propWindow = new addProperty(this, loggedID);
            propWindow.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            this.Hide();
        }

        public void Display()
        {
            DatabaseConnection.Display(loggedID, propertyList);
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
