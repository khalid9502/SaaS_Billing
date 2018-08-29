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
    public partial class frmCustomer : Form
    {
        //DAL dal = new DAL();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            List<Customer> customers = DAL.ReadCustomer();
            customers.ForEach(c =>
            {
                string[] row = { c.CustomerCode.ToString(), c.CustomerName, c.AccountNumber, c.ContactPerson ,c.Address};
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            });

            List<Software> softwares = DAL.ReadSoftware();

            foreach (Software sof in softwares)
            {
                string softwareid = sof.SoftwareID.ToString();
                cmbSoftwareID.Items.Add(softwareid);

            }

            cmbServiceID.Enabled = false;
            btnDetailAdd.Enabled = false;
        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            var ItemClicked = listView1.SelectedItems[0];

            txtID.Text = ItemClicked.SubItems[0].Text;
            txtName.Text = ItemClicked.SubItems[1].Text;
            txtAccount.Text = ItemClicked.SubItems[2].Text;
            txtContact.Text = ItemClicked.SubItems[3].Text;
            txtAddress.Text = ItemClicked.SubItems[4].Text;

            tabCon.SelectedIndex = 1;
            Refresh4();
            //            ListView1.SelectedItems[0].Subitems[1].Text
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            listView3.Items.Clear();

            var ItemClicked = listView2.SelectedItems[0];

            txtSubID.Text = ItemClicked.SubItems[0].Text;
            txtDate.Text = ItemClicked.SubItems[1].Text;
            txtCustID.Text = ItemClicked.SubItems[2].Text;
            txtStartDate.Text = ItemClicked.SubItems[3].Text;
            txtEndDate.Text = ItemClicked.SubItems[4].Text;

            int id = Convert.ToInt32(txtSubID.Text);
            List<SubscriptionDetail> SubscriptionDetails = DAL.ReadSubDetails(id);

            SubscriptionDetails.ForEach(s =>
            {
                string[] row = { s.ServiceID.ToString(), s.SoftwareID.ToString(), s.ServiceName, s.SoftwareName,s.Quantity.ToString(),s.Key.ToString()};
                var listViewItem = new ListViewItem(row);
                listView3.Items.Add(listViewItem);
            });

            tabCon.SelectedIndex = 2;
        }
        

        private void listView1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView4.Items.Clear();
            try
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                List<Subscription> Subscriptions = DAL.ReadCustSubscription(id);

                Subscriptions.ForEach(s =>
                {
                    string[] row = { s.SubscriptionID.ToString(), s.Date, s.CustomerCode.ToString(), s.StartDate, s.EndDate };
                    var listViewItem = new ListViewItem(row);
                    listView2.Items.Add(listViewItem);
                });
            }
            catch { Console.WriteLine("Error in listView1_click"); }
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            try
            {
                int id = Convert.ToInt32(listView2.SelectedItems[0].Text);
                List<SubscriptionDetail> SubscriptionDetails = DAL.ReadSubDetails(id);

                SubscriptionDetails.ForEach(s =>
                {
                    string[] row = { s.ServiceID.ToString(), s.SoftwareID.ToString(), s.ServiceName, s.SoftwareName, s.Quantity.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView4.Items.Add(listViewItem);
                });
            } catch { Console.WriteLine("Error in listView2_click"); }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addCustomer newCustomer = new addCustomer();
            newCustomer.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DAL.CustomerMatchFound(txtID.Text))
            {
                int id = Convert.ToInt32(txtID.Text);
                string name = Convert.ToString(txtName.Text);
                string account = Convert.ToString(txtAccount.Text);
                string contact = Convert.ToString(txtContact.Text);
                string address = Convert.ToString(txtAddress.Text);
                Customer c = new Customer() { CustomerCode = id, CustomerName = name, AccountNumber = account, ContactPerson = contact, Address = address };

                DAL.UpdateCustomer(c);
                MessageBox.Show("Customer updated");
                tabCon.SelectedIndex = 0;
                Refresh1();
            }
            else { MessageBox.Show("Customer does not exists"); }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    var ChosenCustomer = listView1.SelectedItems[i];
                    string cust = ChosenCustomer.SubItems[0].Text;
                    if (DAL.CustomerMatchFound(cust))
                    {
                        DAL.DeleteCustomer(cust);
                    }
                    MessageBox.Show("Customers deleted");
                }
            } else { MessageBox.Show("select a customer"); }

            Refresh1();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                List<Customer> customers = DAL.ReadCustomer();
                customers.ForEach(delegate (Customer c)
                {
                    string[] row = { c.CustomerCode.ToString(), c.CustomerName, c.AccountNumber, c.ContactPerson ,c.Address};
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                });

                listView2.Items.Clear();
                listView4.Items.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "Error in btnRefresh_Click");
            }
            
        }

        private void btnSubNew_Click(object sender, EventArgs e)//
        {
            Form addSub = new addSubscription();
            addSub.Show();
        }

         private void btnSubDelete_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView2.SelectedItems.Count; i++)
                {
                    var ChosenSub = listView2.SelectedItems[i];
                    string sub = ChosenSub.SubItems[0].Text;
                    if (DAL.SubscriptionMatchFound(sub))
                    {
                        DAL.DeleteSubscription(sub);
                    }
                    MessageBox.Show("Subscriptions deleted");
                }
            }
            else { MessageBox.Show("select a Subscritions"); }

            listView2.Items.Clear();
            listView4.Items.Clear();
            Refresh2();
        }

        private void btnSubSave_Click(object sender, EventArgs e)
        {
            if (DAL.SubscriptionMatchFound(txtSubID.Text))
            {
                int subid = Convert.ToInt32(txtSubID.Text);
                string date = Convert.ToString(txtDate.Text);
                int custid = Convert.ToInt32(txtCustID.Text);
                string startdate = Convert.ToString(txtStartDate.Text);
                string enddate = Convert.ToString(txtEndDate.Text);
                Subscription s = new Subscription() { SubscriptionID = subid, Date = date, CustomerCode = custid, StartDate = startdate, EndDate = enddate };

                DAL.UpdateSubscription(s);
                MessageBox.Show("Subscription updated");
                tabCon.SelectedIndex = 0;
                Refresh2();
            }
            else { MessageBox.Show("Subscription does not exists"); }
            
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
            if(!DAL.CombinationExists(Convert.ToInt32(txtSubID.Text), Convert.ToInt32(cmbSoftwareID.SelectedItem), Convert.ToInt32(cmbServiceID.SelectedItem)))
            {
                string[] row = { txtSubID.Text, cmbServiceID.SelectedItem.ToString(), cmbSoftwareID.SelectedItem.ToString(), txtQuantity.Text, txtServicePrice.Text };
                DAL.AddSubDetails(row);

                //string[] row2 = { txtSubID.Text, cmbSoftwareID.SelectedItem.ToString(), cmbServiceID.SelectedItem.ToString(), txtQuantity.Text, txtServicePrice.Text };
                //DAL.AddBillDetails(Convert.ToInt32(txtSubID.Text), row2);

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
            if (txtQuantity.Text == "" || txtServicePrice.Text == "")
            {
                btnDetailAdd.Enabled = false;
            }
            else
            {
                btnDetailAdd.Enabled = true;
            }
        }

        private void txtServicePrice_TextChanged(object sender, EventArgs e)
        {
            if (txtServicePrice.Text == "" || txtQuantity.Text == "")
            {
                btnDetailAdd.Enabled = false;
            }
            else
            {
                btnDetailAdd.Enabled = true;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        public void Refresh1()
        {
            listView1.Items.Clear();
            List<Customer> customers = DAL.ReadCustomer();
            customers.ForEach(delegate (Customer c)
            {
                string[] row = { c.CustomerCode.ToString(), c.CustomerName, c.AccountNumber, c.ContactPerson , c.Address};
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            });
        }//Refresh1

        public void Refresh2()
        {
            if(listView1.SelectedItems.Count > 0)
            {
                try
                {
                    listView2.Items.Clear();
                    int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                    List<Subscription> Subscriptions = DAL.ReadCustSubscription(id);

                    Subscriptions.ForEach(s =>
                    {
                        string[] row = { s.SubscriptionID.ToString(), s.Date, s.CustomerCode.ToString(), s.StartDate, s.EndDate };
                        var listViewItem = new ListViewItem(row);
                        listView2.Items.Add(listViewItem);
                    });
                }//try
                catch { Console.WriteLine("Error while Refreshing Listview2"); }
            }//if
        }//Refresh2

        public void Refresh3()
        {
                try
                {
                    listView3.Items.Clear();
                    int id = Convert.ToInt32(txtSubID.Text);
                    List<SubscriptionDetail> SubscriptionDetails = DAL.ReadSubDetails(id);

                    SubscriptionDetails.ForEach(s =>
                    {
                        string[] row = { s.ServiceID.ToString(), s.SoftwareID.ToString(), s.ServiceName, s.SoftwareName, s.Quantity.ToString(),s.Key.ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView3.Items.Add(listViewItem);
                    });
                }//try
                catch { Console.WriteLine("Error while Refreshing Listview3"); }
        }//Refresh3

        public void Refresh4()
        {
            if(listView2.SelectedItems.Count > 0)
            {
                try
                {
                    listView4.Items.Clear();
                    int id = Convert.ToInt32(listView2.SelectedItems[0].Text);
                    List<SubscriptionDetail> SubscriptionDetails = DAL.ReadSubDetails(id);

                    SubscriptionDetails.ForEach(s =>
                    {
                        string[] row = { s.ServiceID.ToString(), s.SoftwareID.ToString(), s.ServiceName, s.SoftwareName, s.Quantity.ToString() };
                        var listViewItem = new ListViewItem(row);
                        listView4.Items.Add(listViewItem);
                    });
                }//try
                catch { Console.WriteLine("Error while Refreshing Listview4"); }
            }//if
        }//Refresh4

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {
            if(txtCustID.Text == "")
            {
                btnSubSave.Enabled = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


//customers.ForEach(delegate (Customer c)
//{
//    string[] row = { c.CustomerCode.ToString(), c.CustomerName, c.AccountNumber, c.ContactPerson };
//    var listViewItem = new ListViewItem(row);
//    listView1.Items.Add(listViewItem);
//});

//foreach (Customer c in customers)
//{
//    string[] row = { c.CustomerCode.ToString(), c.CustomerName, c.AccountNumber, c.ContactPerson };
//    var listViewItem = new ListViewItem(row);
//    listView1.Items.Add(listViewItem);
//}

//for(int i=0; i < customers.Count; i++)
//{
//    Customer c = customers[i];
//    string[] row = { c.CustomerCode.ToString(), c.CustomerName, c.AccountNumber, c.ContactPerson };
//    var listViewItem = new ListViewItem(row);
//    listView1.Items.Add(listViewItem);
//}