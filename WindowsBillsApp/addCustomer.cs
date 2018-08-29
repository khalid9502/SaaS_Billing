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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!DAL.CustomerMatchFound(txtID.Text))
            {
                string[] row = { txtID.Text, txtName.Text, txtAccount.Text, txtContact.Text, txtAddress.Text };
                DAL.AddCustomer(row);
                MessageBox.Show("Customer added");
                txtID.Text = "";
                txtName.Text = "";
                txtAccount.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
            }
            else { MessageBox.Show("Customer already exists"); }

}

private void addCustomer_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
}
