using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billsapp;

namespace WindowsBillsApp
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            btnEnter.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string UserID = txtUserID.Text;
            string Password = txtPassword.Text;
            Boolean Authorized = DAL.Authenticate(UserID, Password);
            if (Authorized)
            {
                StartUp StartPage = new StartUp();
                StartPage.Show();
                txtPassword.Text = "";

            } else
            {
                MessageBox.Show("UserID or Password incorrect.");
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click((object)sender, (EventArgs)e);
            }

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            if(txtUserID.Text != "")
            {
                btnEnter.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = false;
            }
        }
    }
}
