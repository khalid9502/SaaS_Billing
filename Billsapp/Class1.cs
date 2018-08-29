using System;
using System.Collections.Generic;
using  System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security;

namespace Billsapp
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.Read();
            string UserInput;
            int input = 1;
            List<Customer> Customers = new List<Customer>();

            while (input != 0)
            {
                Console.WriteLine("Press 1 to view data");
                Console.WriteLine("Press 2 to enter data");
                Console.WriteLine("Press 0 to exit");
                try
                {
                    UserInput = Console.ReadLine();
                    Console.WriteLine();
                    input = Convert.ToInt32(UserInput);
                    if (input == 1)
                    {
                        Customers = ReadCustomer();
                        DisplayCustomer(Customers);
                    }
                    else if (input == 2)
                    {
                        AddCustomer();
                    }
                }//try
                catch { }

            }//while
        }//void main

        static void AddCustomer()
        {
            Console.WriteLine("Enter the customer data");
            string[] row = Console.ReadLine().Split(',');
            int CustomerCode = Convert.ToInt32(row[0]);
            string CustomerName = row[1].ToString();
            string AccountNumber = row[2].ToString();
            string ContactPerson = row[3].ToString();
            string Address = row[4].ToString();
            PersistCustomer(CustomerCode, CustomerName, AccountNumber, ContactPerson, Address);
            Console.WriteLine("Row inserted");
        }//AddCustomer

        static void PersistCustomer(int CustomerCode, string CustomerName, string AccountNumber, string ContactPerson, string Address)
        {
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO Customer VALUES(@CustomerCode,@CustomerName,@AccountNumber,@ContactPerson,@Address)", con))
                    {
                        command.Parameters.Add(new SqlParameter("CustomerCode", CustomerCode));
                        command.Parameters.Add(new SqlParameter("CustomerName", CustomerName));
                        command.Parameters.Add(new SqlParameter("AccountNumber", AccountNumber));
                        command.Parameters.Add(new SqlParameter("ContactPerson", ContactPerson));
                        command.Parameters.Add(new SqlParameter("Address", Address));
                        command.ExecuteNonQuery();
                    }//sqlcommand
                }//try
                catch { Console.WriteLine("Failed to insert your data, please try again"); }
                con.Close();
            }//sqlconnection
        }//PersistCustomer
        static List<Customer> ReadCustomer()
        {
            List<Customer> Customers = new List<Customer>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int customercode = Convert.ToInt32(reader["CustomerCode"]);
                            string customername = reader["CustomerName"].ToString();
                            string accountnumber = reader["AccountNumber"].ToString();
                            string contactperson = reader["ContactPerson"].ToString();
                            string address = reader["Address"].ToString();
                            Customers.Add(new Customer()
                            {
                                CustomerCode = customercode,
                                CustomerName = customername,
                                AccountNumber = accountnumber,
                                ContactPerson = contactperson,
                                Address = address
                            });

                            //string[] row = { textBox1.Text, textBox2.Text, textBox3.Text };
                            //var listViewItem = new ListViewItem(row);
                            //listView1.Items.Add(listViewItem);
                        }//while
                        reader.Close();
                    }//sql command
                    con.Close();
                }//sql connection
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }

            return Customers;
        }//readCustomer
        static void DisplayCustomer(List<Customer> Customers)
        {
            foreach (Customer c in Customers)
            {
                Console.WriteLine(c.ToString());
                //Console.WriteLine(c.CustomerName + "\t"  + c.Address);
            }
        }//display customer

    }//class1

    public class Customer
    {
        public int CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string AccountNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public List<Subscription> Subscriptions = new List<Subscription>();
        public override string ToString()
        {
            return string.Format("CustomerCode: {0},CustomerName: {1},AccountNumber: {2},ContactPerson: {3},Address: {4} \n",
                CustomerCode, CustomerName, AccountNumber, ContactPerson, Address);
        }
    }//customer

    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public string Date { get; set; }
        public int CustumerCode { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<SubscriptionDetail> SubscriptionDetails = new List<SubscriptionDetail>();
        public List<Bill> Bills = new List<Bill>();
        public override string ToString()
        {
            return string.Format("SubscriptionID: {0},Date: {1},CustumerCode: {2},StartDate: {3},EndDate: {4} \n",
                SubscriptionID, Date, CustumerCode, StartDate, EndDate);

        }
    }//Subscription

    public class SubscriptionDetail
    {
        public int SubscriptionID { get; set; }
        public int Key { get; set; }
        public int ServiceID { get; set; }
        public int SoftwareID { get; set; }
        public string ServiceName { get; set; }
        public string SoftwareName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return string.Format("SubscriptionID: {0},Key: {1},ServiceID: {2},SoftwareID: {3},ServiceName: {4},SoftwareName: {5},Quantity: {6},Price: {7} \n",
               SubscriptionID, Key, ServiceID, SoftwareID, ServiceName, SoftwareName, Quantity, Price);
        }
    }//SubscriptionDetail

    public class Bill
    {
        public int SubscriptionID { get; set; }
        public string BillNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Total { get; set; }
        public List<BillDetail> BillDeatails = new List<BillDetail>();
        public override string ToString()
        {
            return string.Format("SubscriptionID: {0},BillNumber: {1},StartDate: {2},EndDate: {3},Total: {4} \n",
                SubscriptionID, BillNumber, StartDate, EndDate, Total);

        }
    }//Bill

    public class BillDetail
    {
        public int BillNumber { get; set; }
        public int Key { get; set; }
        public int SoftwareID { get; set; }
        public string SoftwareName { get; set; }
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SubTotal { get; set; }
        public override string ToString()
        {
            return string.Format("BillNumber: {0},Key: {1},SoftwareID: {2},SoftwareName: {3},ServiceID: {4},ServiceName: {5},Quantity: {6},Price: {7},SubTotal: {8} \n",
               BillNumber, Key, SoftwareID, SoftwareName, ServiceID, ServiceName, Quantity, Price, SubTotal);
        }
    }//BillDetail

    public class Software
    {
        public int SoftwareID { get; set; }
        public string Name { get; set; }
        public List<Service> Services = new List<Service>();
        public override string ToString()
        {
            return string.Format("SoftwareID: {0},Name: {1} \n",
                SoftwareID, Name);

        }
    }//Software

    public class Service
    {
        public int ServiceID { get; set; }
        public int SoftwareID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int MinimumQuantity { get; set; }
        public override string ToString()
        {
            return string.Format("ServiceID: {0},SoftwareID: {1},Name: {2},Price: {3},Quantity: {4} \n",
               ServiceID, SoftwareID, Name, Price, MinimumQuantity);
        }
    }//Service

}//namespace
