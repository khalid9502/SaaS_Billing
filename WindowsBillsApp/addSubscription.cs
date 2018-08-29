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
    public partial class addSubscription : Form
    {
        public addSubscription()
        {
            InitializeComponent();
        }

        private void addSubscription_Load(object sender, EventArgs e)
        {

            List<Software> softwares = DAL.ReadSoftware();

            foreach (Software sof in softwares)
            {
                string softwareid = sof.SoftwareID.ToString();
                cmbSoftwareID.Items.Add(softwareid);

            }
            cmbSoftwareID.Enabled = false;
            cmbServiceID.Enabled = false;
            btnDetailAdd.Enabled = false;
            btnSubAdd.Enabled = false;
        }

        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            
            string StartDate = FormatDate(dateTimePicker1.Value.ToString("dd/MM/yy"));
            string EndDate = FormatDate(dateTimePicker2.Value.ToString("dd/MM/yy"));
            string Date = FormatDate(dateTimePicker3.Value.ToString("dd/MM/yy"));

            if (DAL.MonthsBetween(StartDate,EndDate) >= 1)
            {
                if (DAL.CustomerMatchFound(txtCustID.Text))
                {
                    if (!DAL.SubscriptionMatchFound(txtSubID.Text))
                    {
                        string[] row = { txtSubID.Text, Date, txtCustID.Text, StartDate, EndDate };
                        DAL.AddSubscription(row);
                        MessageBox.Show("Subscription added");

                        string[] row2 = { txtSubID.Text, StartDate, EndDate };
                        DAL.AddBill(row2);
                    }
                    else { MessageBox.Show("Subscription already exists"); }
                }
                else { MessageBox.Show("Customer does not exist"); }

                cmbSoftwareID.Enabled = true;

            }
            else
            {
                MessageBox.Show("Date Range should be atleast a month");
            }


        }

        private void txtSubID_TextChanged(object sender, EventArgs e)
        {
            Enable_btnSubAdd();
        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {
            Enable_btnSubAdd();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            Enable_btnSubAdd();

        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            Enable_btnSubAdd();

        }

        private void txtEndDate_TextChanged(object sender, EventArgs e)
        {
            Enable_btnSubAdd();

        }

        private void cmbSoftwareID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(cmbSoftwareID.SelectedItem);
            txtSoftwareName.Text = DAL.WhichSoftware(selectedID);

            cmbServiceID.Items.Clear();

            List<Service> services = DAL.ReadService();

            foreach (Service ser in services)
            {
                if (ser.SoftwareID == selectedID)
                {
                    string serviceid = ser.ServiceID.ToString();
                    cmbServiceID.Items.Add(serviceid);
                }

            }

            cmbServiceID.Enabled = true;
        }

        private void cmbServiceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(cmbServiceID.SelectedItem);
            txtServiceName.Text = DAL.WhichService(selectedID);
            txtServicePrice.Text = DAL.ServicePrice(selectedID).ToString();
            txtQuantity.Text = DAL.ServiceMinQuantity(selectedID).ToString();
            btnDetailAdd.Enabled = true;
        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            if (!DAL.CombinationExists(Convert.ToInt32(txtSubID.Text), Convert.ToInt32(cmbSoftwareID.SelectedItem), Convert.ToInt32(cmbServiceID.SelectedItem)))
            {
                string[] row = { txtSubID.Text, cmbServiceID.SelectedItem.ToString(), cmbSoftwareID.SelectedItem.ToString(), txtQuantity.Text, txtServicePrice.Text };
                DAL.AddSubDetails(row);

                //string[] row2 = { txtSubID.Text, cmbSoftwareID.SelectedItem.ToString(), cmbServiceID.SelectedItem.ToString(), txtQuantity.Text, txtServicePrice.Text };
                //DAL.AddBillDetails(Convert.ToInt32(txtSubID.Text),row2);

                cmbSoftwareID.Text = "";
                cmbServiceID.Text = "";
                cmbServiceID.Items.Clear();
                txtSoftwareName.Text = "";
                txtServiceName.Text = "";
                txtServicePrice.Text = "";
                txtQuantity.Text = "";
                btnDetailAdd.Enabled = false;
                Refresh3();
            }
            else
            {
                MessageBox.Show("Already subscribed for that service");
            }
        }

        private void btnDetailDelete_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView3.SelectedItems.Count; i++)
                {
                    var ChosenSubDetail = listView3.SelectedItems[i];
                    int key = Convert.ToInt32(ChosenSubDetail.SubItems[5].Text);
                    DAL.DeleteSubDetails(key);
                    MessageBox.Show("Details deleted");
                }
            }
            else { MessageBox.Show("select a subscription detail"); }

            Refresh3();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            Enable_btnDetailAdd();
        }

        private void txtServicePrice_TextChanged(object sender, EventArgs e)
        {
            Enable_btnDetailAdd();
        }

        public void Refresh3()
        {
            try
            {
                listView3.Items.Clear();
                int id = Convert.ToInt32(txtSubID.Text);
                List<SubscriptionDetail> SubscriptionDetails = DAL.ReadSubDetails(id);

                SubscriptionDetails.ForEach(s =>
                {
                    string[] row = { s.ServiceID.ToString(), s.SoftwareID.ToString(), s.ServiceName, s.SoftwareName, s.Quantity.ToString(), s.Key.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView3.Items.Add(listViewItem);
                });
            }//try
            catch { Console.WriteLine("Error while Refreshing Listview3"); }
        }//Refresh3

        public void Enable_btnSubAdd()
        {
            if (txtCustID.Text == "" || txtSubID.Text == "" /*|| txtDate.Text == "" || txtStartDate.Text == "" || txtEndDate.Text == ""*/)
            {
                btnSubAdd.Enabled = false;
            }
            else
            {
                btnSubAdd.Enabled = true;
            }
        }

        public void Enable_btnDetailAdd()
        {
            if (txtServicePrice.Text == "" || txtQuantity.Text == "" || txtServiceName.Text == "")
            {
                btnDetailAdd.Enabled = false;
            }
            else
            {
                btnDetailAdd.Enabled = true;
            }
        }

        private void btnSubNew_Click(object sender, EventArgs e)
        {
            cmbSoftwareID.Enabled = false;
            cmbServiceID.Enabled = false;
            btnDetailAdd.Enabled = false;
            btnSubAdd.Enabled = false;
            txtSubID.Text = "";
            txtCustID.Text = "";
           // txtDate.Text = "";
            //txtStartDate.Text = "";
            //txtEndDate.Text = "";
            txtSoftwareName.Text = "";
            txtServiceName.Text = "";
            txtServicePrice.Text = "";
            txtQuantity.Text = "";
            cmbServiceID.Items.Clear();
            listView3.Items.Clear();
        }

      
        public string FormatDate(string date)
        {
            string[] temp = date.Split('-');
            string Date = temp[0] + "/" + temp[1] + "/" + temp[2];
            return Date;
        }

    }
}
 