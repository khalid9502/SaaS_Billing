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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {

            List<Customer> customers = DAL.ReadCustomer();
            customers.ForEach(c =>
            {
                string[] row = { c.CustomerCode.ToString(), c.CustomerName, c.AccountNumber, c.ContactPerson };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            });

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click_1(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
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

        private void listView2_Click_1(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
            try
            {
                int id = Convert.ToInt32(listView2.SelectedItems[0].Text);
                List<Bill> ProBills = DAL.ReadProSubBill(id);

                ProBills.ForEach(b =>
                {
                    string[] row = { b.BillNumber.ToString(), b.StartDate, b.EndDate, b.Total.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView3.Items.Add(listViewItem);
                });

                List<Bill> UnProBills = DAL.ReadUnProSubBill(id);

                UnProBills.ForEach(b =>
                {
                    string[] row = { b.BillNumber.ToString(), b.StartDate, b.EndDate, b.Total.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView5.Items.Add(listViewItem);
                });

            }
            catch { Console.WriteLine("Error in listView2_click"); }
        }

        private void listView3_Click_1(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            try
            {
                int id = Convert.ToInt32(listView3.SelectedItems[0].Text);
                List<BillDetail> BillDetails = DAL.ReadBillDetail(id);

                BillDetails.ForEach(bd =>
                {
                    string[] row = { bd.SoftwareID.ToString(), bd.SoftwareName, bd.ServiceID.ToString(), bd.ServiceName, bd.Quantity.ToString(), bd.Price.ToString(), bd.SubTotal.ToString(), bd.Key.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView4.Items.Add(listViewItem);
                });
            }
            catch { Console.WriteLine("Error in listView3_click"); }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            string SD = FormatDate(dateTimePicker1.Value.ToString("dd/MM/yy"));
            DateTime StartDate = DateTime.Parse(SD);
            DateTime EndDate = StartDate.AddMonths(1);

            List<Subscription> Subscriptions = DAL.ReadSubscription();

            Subscriptions.ForEach(s =>
            {
                int SubID = s.SubscriptionID;
                string SubStartDate = s.StartDate;
                string SubEndDate = s.EndDate;

                List<Bill> Bills = DAL.ReadUnProSubBill(SubID);
                
                Bills.ForEach(b =>
                {
                    DateTime BillStartDate = DateTime.Parse(b.StartDate);
                    string billstartdate = FormatDate(BillStartDate.ToString("dd/MM/yy"));
                    if (billstartdate == SD)
                    {
                        DAL.ProcessBill(b.BillNumber);
                        List<SubscriptionDetail> SubDetails= DAL.ReadSubDetails(SubID);

                        SubDetails.ForEach(d =>
                        {
                            string[] row = { SubID.ToString(),d.SoftwareID.ToString(),d.ServiceID.ToString(),d.Quantity.ToString(),d.Price.ToString() };
                           DAL.AddBillDetails(b.BillNumber,row);
                        });

                    }
                });

            });

        }

        public string FormatDate(string date)
        {
            string[] temp = date.Split('-');
            string Date = temp[0] + "/" + temp[1] + "/" + temp[2];
            return Date;
        }

    }
}
