using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security;

namespace Billsapp
{
    public static class DAL
    {
        //public static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello");
        //    //Console.Read();
        //    string UserInput;
        //    int input = 1;
        //    List<Customer> Customers = new List<Customer>();

        //    while (input != 0)
        //    {
        //        Console.WriteLine("Press 1 to view data");
        //        Console.WriteLine("Press 2 to enter data");
        //        Console.WriteLine("Press 0 to exit");
        //        try
        //        {
        //            UserInput = Console.ReadLine();
        //            Console.WriteLine();
        //            input = Convert.ToInt32(UserInput);
        //            if (input == 1)
        //            {
        //                Customers = ReadCustomer();
        //                DisplayCustomer(Customers);
        //            }
        //            else if (input == 2)
        //            {
        //                AddCustomer();
        //            }
        //        }//try
        //        catch { }

        //    }//while
        //}//void main

        public static void AddCustomer(string[] row)
        {
            // Console.WriteLine("Enter the customer data");
            //string[] row = Console.ReadLine().Split(',');
            int CustomerCode = Convert.ToInt32(row[0]);
            string CustomerName = row[1].ToString();
            string AccountNumber = row[2].ToString();
            string ContactPerson = row[3].ToString();
            string Address = row[4].ToString();
            PersistCustomer(CustomerCode, CustomerName, AccountNumber, ContactPerson, Address);
        }//AddCustomer

        public static void PersistCustomer(int CustomerCode, string CustomerName, string AccountNumber, string ContactPerson, string Address)
        {
            string Deleted = "false";
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO Customer VALUES(@CustomerCode,@CustomerName,@AccountNumber,@ContactPerson,@Address,@Deleted)", con))
                    {
                        command.Parameters.Add(new SqlParameter("CustomerCode", CustomerCode));
                        command.Parameters.Add(new SqlParameter("CustomerName", CustomerName));
                        command.Parameters.Add(new SqlParameter("AccountNumber", AccountNumber));
                        command.Parameters.Add(new SqlParameter("ContactPerson", ContactPerson));
                        command.Parameters.Add(new SqlParameter("Address", Address));
                        command.Parameters.Add(new SqlParameter("Deleted", Deleted));
                        command.ExecuteNonQuery();
                    }//sqlcommand
                    Console.WriteLine("Row inserted");
                }//try
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                con.Close();
            }//sqlconnection
        }//PersistCustomer

        public static List<Customer> ReadCustomer()
        {
            List<Customer> Customers = new List<Customer>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER WHERE Deleted != 'true'", con))
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

        public static void UpdateCustomer(Customer c)
        {
            int id = c.CustomerCode;
            string name = c.CustomerName;
            string account = c.AccountNumber;
            string contact = c.ContactPerson;
            string address = c.Address;

            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {
                    var sqlString = "UPDATE Customer SET [CustomerName] = " + name + ",[AccountNumber] = " + account + ",[ContactPerson] = " + contact + ",[Address] = " + address + " WHERE [CustomerCode] = " + id;
                    Console.WriteLine(sqlString);
                    using (SqlCommand command = new SqlCommand("UPDATE Customer SET [CustomerName] = '" + name + "' ,[AccountNumber] = '" + account + "' ,[ContactPerson] = '" + contact + "' ,[Address] = '" + address + "' WHERE [CustomerCode] = " + id, con))
                    {
                        //command.Parameters.Add(new SqlParameter("CustomerName", name));
                        //command.Parameters.Add(new SqlParameter("AccountNumber", account));
                        //command.Parameters.Add(new SqlParameter("ContactPerson", contact));
                        //command.Parameters.Add(new SqlParameter("Address", address));
                        command.ExecuteNonQuery();
                    }//sqlcommand
                }//try
                catch { Console.WriteLine("Failed to update, please try again"); }
                con.Close();
            }//sqlconnection
        }//UpdateCustomer

        public static void DeleteCustomer(string CustomerCode)
        {
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Customer SET Deleted = 'true' WHERE  CustomerCode = " + CustomerCode, con))
                {
                    command.ExecuteNonQuery();
                }//sqlcommand
                con.Close();
            }//sqlconnection
        }//DeleteCustomer

        public static Boolean CustomerMatchFound(string Custcode)
        {
            int code = Convert.ToInt32(Custcode);
            int found = 0;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT CustomerCode FROM CUSTOMER", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int customercode = Convert.ToInt32(reader["CustomerCode"]);
                            if (code == customercode)
                            {
                                found = 1;
                            }//if
                        }//while
                        reader.Close();
                    }//sql command
                    con.Close();
                }//sql connection

                if (found == 1) { return true; }
                else { return false; }

            }//try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//catch
            return true;
        }//MatchFound

        //----------------------Subscription Methods

        public static void AddSubscription(string[] row)
        {
            int SubscriptionID = Convert.ToInt32(row[0]);
            string Date = row[1].ToString();
            int CustomerCode = Convert.ToInt32(row[2]);
            string StartDate = row[3].ToString();
            string EndDate = row[4].ToString();
            PersistSubscription(SubscriptionID, Date, CustomerCode, StartDate, EndDate);
        }//AddCustomer

        public static void PersistSubscription(int SubscriptionID, string Date, int CustomerCode, string StartDate, string EndDate)
        {
            string Deleted = "false";
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO Subscription VALUES(@SubscriptionID,@Date,@CustomerCode,@StartDate,@EndDate,@Deleted)", con))
                    {
                        command.Parameters.Add(new SqlParameter("SubscriptionID", SubscriptionID));
                        command.Parameters.Add(new SqlParameter("Date", Date));
                        command.Parameters.Add(new SqlParameter("CustomerCode", CustomerCode));
                        command.Parameters.Add(new SqlParameter("StartDate", StartDate));
                        command.Parameters.Add(new SqlParameter("EndDate", EndDate));
                        command.Parameters.Add(new SqlParameter("Deleted", Deleted));
                        command.ExecuteNonQuery();
                    }//sqlcommand
                    Console.WriteLine("Row inserted");
                }//try
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                con.Close();
            }//sqlconnection
        }//PersistCustomer

        public static List<Subscription> ReadCustSubscription(int CustCode)
        {
            List<Subscription> Subscriptions = new List<Subscription>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Subscription WHERE CustomerCode = " + CustCode + " and Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int subscriptionID = Convert.ToInt32(reader["SubscriptionID"]);
                            string date = reader["Date"].ToString();
                            int customercode = Convert.ToInt32(reader["CustomerCode"]);
                            string startdate = reader["StartDate"].ToString();
                            string enddate = reader["EndDate"].ToString();
                            Subscriptions.Add(new Subscription()
                            {
                                SubscriptionID = subscriptionID,
                                Date = date,
                                CustomerCode = customercode,
                                StartDate = startdate,
                                EndDate = enddate
                            });

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
            return Subscriptions;
        }//readCustSubscription

        public static List<Subscription> ReadSubscription()
        {
            List<Subscription> Subscriptions = new List<Subscription>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Subscription WHERE Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int subscriptionID = Convert.ToInt32(reader["SubscriptionID"]);
                            string date = reader["Date"].ToString();
                            int customercode = Convert.ToInt32(reader["CustomerCode"]);
                            string startdate = reader["StartDate"].ToString();
                            string enddate = reader["EndDate"].ToString();
                            Subscriptions.Add(new Subscription()
                            {
                                SubscriptionID = subscriptionID,
                                Date = date,
                                CustomerCode = customercode,
                                StartDate = startdate,
                                EndDate = enddate
                            });

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
            return Subscriptions;
        }//readSubscription

        public static int WhichSubscription(int RowKey)
        {
            int SubscriptionID = 0;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT SubscriptionID FROM SubscriptionDetail WHERE Deleted != 'true' and RowKey = " + RowKey, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            SubscriptionID = Convert.ToInt32(reader["SubscriptionID"]);
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
            return SubscriptionID;
        }//WhichSubscription
        
        public static Boolean SubscriptionMatchFound(string SubID)
        {
            int id = Convert.ToInt32(SubID);
            int found = 0;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT SubscriptionID FROM Subscription", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int subscriptionid = Convert.ToInt32(reader["SubscriptionID"]);
                            if (id == subscriptionid)
                            {
                                found = 1;
                            }//if
                        }//while
                        reader.Close();
                    }//sql command
                    con.Close();
                }//sql connection

                if (found == 1) { return true; }
                else { return false; }

            }//try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }//catch
            return true;
        }//SubscriptionMatchFound

        public static void DeleteSubscription(string SubscriptionID)
        {
            int BillNumber = 4001;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Subscription SET Deleted = 'true' WHERE SubscriptionID = " + SubscriptionID, con))
                {
                    command.ExecuteNonQuery();
                }//
                using (SqlCommand command = new SqlCommand("UPDATE SubscriptionDetail SET Deleted = 'true' WHERE SubscriptionID = " + SubscriptionID, con))
                {
                    command.ExecuteNonQuery();
                }//sqlcommand

                int subID = Convert.ToInt32(SubscriptionID);
                List<Bill> Bills = DAL.ReadSubBill(subID);

                Bills.ForEach(b =>
                {
                    BillNumber = b.BillNumber;

                    using (SqlCommand command = new SqlCommand("UPDATE BillDetail SET Deleted = 'true' WHERE BillNumber = " + BillNumber, con))
                    {
                        command.ExecuteNonQuery();
                    }//sqlcommand

                });

                using (SqlCommand command = new SqlCommand("UPDATE Bill SET Deleted = 'true' WHERE SubscriptionID = " + SubscriptionID, con))
                {
                    command.ExecuteNonQuery();
                }//sqlcommand

                con.Close();
            }//sqlconnection
        }//DeleteSubscription

        public static void UpdateSubscription(Subscription s)
        {
            int subid = s.SubscriptionID;
            string date = s.Date;
            int custid = s.CustomerCode;
            string startdate = s.StartDate;
            string enddate = s.EndDate;

            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("UPDATE Subscription SET [SubscriptionID] = '" + subid + "' ,[Date] = '" + date + "' ,[CustomerCode] = '" + custid + "' ,[StartDate] = '" + startdate + "' ,[EndDate] = '" + enddate + "' WHERE [SubscriptionID] = " + subid, con))
                    {
                        //command.Parameters.Add(new SqlParameter("CustomerName", name));
                        //command.Parameters.Add(new SqlParameter("AccountNumber", account));
                        //command.Parameters.Add(new SqlParameter("ContactPerson", contact));
                        //command.Parameters.Add(new SqlParameter("Address", address));
                        command.ExecuteNonQuery();
                    }//sqlcommand
                }//try
                catch { Console.WriteLine("Failed to update, please try again"); }
                con.Close();
            }//sqlconnection
        }//UpdateCustomer

        //----------------------SubscriptionDetail Methods

        public static void AddSubDetails(string[] row)
        {
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";

            int SubscriptionID = Convert.ToInt32(row[0]);
            int SubRowKey = 9001;
            int ServiceID = Convert.ToInt32(row[1]);
            int SoftwareID = Convert.ToInt32(row[2]);
            string ServiceName = WhichService(ServiceID);
            string SoftwareName = WhichSoftware(SoftwareID);
            int Quantity = Convert.ToInt32(row[3]);
            int Price = Convert.ToInt32(row[4]);

            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT RowKey FROM SubscriptionDetail", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            SubRowKey = Convert.ToInt32(reader["RowKey"]);
                        }
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
             SubRowKey = SubRowKey + 1;
             PersistSubDetail(SubscriptionID, SubRowKey, ServiceID, SoftwareID, ServiceName,SoftwareName,Quantity,Price);
        }//AddSubDetails

        public static void PersistSubDetail(int SubscriptionID, int SubRowKey, int ServiceID, int SoftwareID, string ServiceName,string SoftwareName,int Quantity,int Price)
        {
            string Deleted = "false";
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO SubscriptionDetail VALUES(@SubscriptionID,@RowKey,@ServiceID,@SoftwareID,@ServiceName,@SoftwareName,@Quantity,@Price,@Deleted)", con))
                    {
                        command.Parameters.Add(new SqlParameter("SubscriptionID", SubscriptionID));
                        command.Parameters.Add(new SqlParameter("RowKey",SubRowKey ));
                        command.Parameters.Add(new SqlParameter("ServiceID", ServiceID));
                        command.Parameters.Add(new SqlParameter("SoftwareID", SoftwareID));
                        command.Parameters.Add(new SqlParameter("ServiceName", ServiceName));
                        command.Parameters.Add(new SqlParameter("SoftwareName", SoftwareName));
                        command.Parameters.Add(new SqlParameter("Quantity", Quantity));
                        command.Parameters.Add(new SqlParameter("Price", Price));
                        command.Parameters.Add(new SqlParameter("Deleted", Deleted));
                        command.ExecuteNonQuery();
                    }//sqlcommand
                    Console.WriteLine("Row inserted");
                }//try
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                con.Close();
            }//sqlconnection
        }//PersistSubDetail

        public static List<SubscriptionDetail> ReadSubDetails(int SubID)
        {
            List<SubscriptionDetail> SubscriptionDetails = new List<SubscriptionDetail>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM SubscriptionDetail WHERE SubscriptionID = " + SubID + " and Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int subscriptionID = Convert.ToInt32(reader["SubscriptionID"]);
                            int key = Convert.ToInt32(reader["RowKey"]);
                            int serviceID = Convert.ToInt32(reader["ServiceID"]);
                            int softwareID = Convert.ToInt32(reader["SoftwareID"]);
                            string servicename = reader["Service Name"].ToString();
                            string softwarename = reader["Software Name"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            int price = Convert.ToInt32(reader["Price"]);
                            SubscriptionDetails.Add(new SubscriptionDetail()
                            {
                                SubscriptionID = subscriptionID,
                                Key = key,
                                ServiceID = serviceID,
                                SoftwareID = softwareID,
                                ServiceName = servicename,
                                SoftwareName = softwarename,
                                Quantity = quantity,
                                Price = price
                            });

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
            return SubscriptionDetails;
        }//readSubDetails

        public static void DeleteSubDetails(int SubRowKey)
        {
            int BillNumber = 0;
            int SoftwareID = RowSoftwareID(SubRowKey);
            int ServiceID = RowSerivceID(SubRowKey);

            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                //int subID = WhichSubscription(SubRowKey);
                //List<Bill> Bills = DAL.ReadSubBill(subID);

                //Bills.ForEach(b =>
                //{
                //    BillNumber = b.BillNumber;


                //    int Total = BillTotal(BillNumber) - SubTotal(SubRowKey);

                //    using (SqlCommand command = new SqlCommand("UPDATE Bill SET Total = " + Total + " WHERE BillNumber = " + BillNumber, con))
                //    {
                //        command.ExecuteNonQuery();
                //    }//sqlcommand

                //    using (SqlCommand command = new SqlCommand("UPDATE BillDetail SET Deleted = 'true' WHERE BillNumber = " + BillNumber + " and SoftwareID = " + SoftwareID + " and ServiceID = " + ServiceID, con))
                //    {
                //        command.ExecuteNonQuery();
                //    }//sqlcommand

                //});

                using (SqlCommand command = new SqlCommand("UPDATE SubscriptionDetail SET Deleted = 'true' WHERE  RowKey = " + SubRowKey, con))
                {
                    command.ExecuteNonQuery();
                }//sqlcommand
                
                con.Close();
            }//sqlconnection
        }//DeleteSubDetails

        public static int SubTotal(int SubRowkey)
        {
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            int subtotal = 0;

            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Quantity,Price FROM SubscriptionDetail WHERE RowKey = " + SubRowkey + " and Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            int price = Convert.ToInt32(reader["Price"]);
                            subtotal = quantity * price;
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
            return subtotal;
        }//SubTotal

        public static int RowSoftwareID(int SubRowkey)
        {
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            int SoftwareID = 1001;

            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT SoftwareID FROM SubscriptionDetail WHERE RowKey = " + SubRowkey + " and Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            SoftwareID = Convert.ToInt32(reader["SoftwareID"]);
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
            return SoftwareID;
        }//RowSoftwareID

        public static int RowSerivceID(int SubRowkey)
        {
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            int ServiceID = 2001;

            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT ServiceID FROM SubscriptionDetail WHERE RowKey = " + SubRowkey + " and Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            ServiceID = Convert.ToInt32(reader["ServiceID"]);
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
            return ServiceID;
        }//RowSoftwareID

        public static Boolean CombinationExists(int SubscriptionID,int SoftwareID,int ServiceID)
        {
            Boolean exist = false;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT SoftwareID,ServiceID FROM SubscriptionDetail WHERE SubscriptionID = " + SubscriptionID + " and Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int softwareID = Convert.ToInt32(reader["SoftwareID"]);
                            int serviceID = Convert.ToInt32(reader["ServiceID"]);

                            if(SoftwareID == softwareID && ServiceID == serviceID)
                            {
                                exist = true;
                            }
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
            return exist;
        }//readSubDetails

        //----------------------Bill Methods

        public static void AddBill(string[] row)
        {
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";

            int SubscriptionID = Convert.ToInt32(row[0]);
            int BillNumber = 4001;
            string StartDate = row[1];
            string EndDate = row[2];
            string enddate = "";
            int Total = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT BillNumber FROM Bill", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            BillNumber = Convert.ToInt32(reader["BillNumber"]);
                        }
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
            BillNumber = BillNumber + 1;

            int NumberOfMonths = MonthsBetween(StartDate, EndDate);
            int Day = WhatDay(StartDate);
            int Month = WhatMonth(StartDate);
            int Year = WhatYear(StartDate);
            string startdate = StartDate;

            for (int i = 1;i <= NumberOfMonths; i++)
            {
                if(i != NumberOfMonths)
                {
                    Month = Month + 1;
                    if (Month > 12)
                    {
                        Month = 1;
                        Year = Year + 1;
                    }
                    enddate = Day.ToString() + "/" + Month.ToString() + "/" + Year.ToString();

                }
                else { enddate = EndDate; }
                
                PersistBill(SubscriptionID, BillNumber, startdate, enddate, Total);
                BillNumber = BillNumber + 1;
                startdate = enddate;
            }

            

        }//AddBill

        public static void PersistBill(int SubscriptionID, int BillNumber, string StartDate, string EndDate, int Total)
        {
            string Deleted = "false";
            string Processed = "false";
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {

                    using (SqlCommand command = new SqlCommand("INSERT INTO Bill VALUES(@SubscriptionID,@BillNumber,@StartDate,@EndDate,@Total,@Deleted,@Processed)", con))
                    {
                        command.Parameters.Add(new SqlParameter("SubscriptionID", SubscriptionID));
                        command.Parameters.Add(new SqlParameter("BillNumber",BillNumber ));
                        command.Parameters.Add(new SqlParameter("StartDate", StartDate));
                        command.Parameters.Add(new SqlParameter("EndDate", EndDate));
                        command.Parameters.Add(new SqlParameter("Total", Total));
                        command.Parameters.Add(new SqlParameter("Deleted", Deleted));
                        command.Parameters.Add(new SqlParameter("Processed", Processed));
                        command.ExecuteNonQuery();
                    }//sqlcommand

                    Console.WriteLine("Row inserted");
                }//try
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                con.Close();
            }//sqlconnection

        }//PersistBill

        public static List<Bill> ReadSubBill(int SubID)
        {
            List<Bill> Bills = new List<Bill>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE SubscriptionID = " + SubID + " and Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int subscriptionID = Convert.ToInt32(reader["SubscriptionID"]);
                            int billnumber = Convert.ToInt32(reader["BillNumber"]);
                            string startdate = reader["StartDate"].ToString();
                            string enddate = reader["EndDate"].ToString();
                            int total = Convert.ToInt32(reader["Total"]);
                            Bills.Add(new Bill()
                            {
                                SubscriptionID = subscriptionID,
                                BillNumber = billnumber,
                                StartDate = startdate,
                                EndDate = enddate,
                                Total = total
                            });

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
            return Bills;
        }//ReadSubBill

        public static List<Bill> ReadProSubBill(int SubID)
        {
            List<Bill> Bills = new List<Bill>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE SubscriptionID = " + SubID + " and Deleted != 'true' and Processed = 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int subscriptionID = Convert.ToInt32(reader["SubscriptionID"]);
                            int billnumber = Convert.ToInt32(reader["BillNumber"]);
                            string startdate = reader["StartDate"].ToString();
                            string enddate = reader["EndDate"].ToString();
                            int total = Convert.ToInt32(reader["Total"]);
                            Bills.Add(new Bill()
                            {
                                SubscriptionID = subscriptionID,
                                BillNumber = billnumber,
                                StartDate = startdate,
                                EndDate = enddate,
                                Total = total
                            });

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
            return Bills;
        }//ReadProSubBill

        public static List<Bill> ReadUnProSubBill(int SubID)
        {
            List<Bill> Bills = new List<Bill>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE SubscriptionID = " + SubID + " and Deleted != 'true' and Processed = 'false'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int subscriptionID = Convert.ToInt32(reader["SubscriptionID"]);
                            int billnumber = Convert.ToInt32(reader["BillNumber"]);
                            string startdate = reader["StartDate"].ToString();
                            string enddate = reader["EndDate"].ToString();
                            int total = Convert.ToInt32(reader["Total"]);
                            Bills.Add(new Bill()
                            {
                                SubscriptionID = subscriptionID,
                                BillNumber = billnumber,
                                StartDate = startdate,
                                EndDate = enddate,
                                Total = total
                            });

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
            return Bills;
        }//ReadUnProSubBill

        public static void ProcessBill(int BillNumber)
        {
            
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("UPDATE Bill SET Processed = 'true'  WHERE BillNumber = " + BillNumber, con))
                    {
                       
                        command.ExecuteNonQuery();
                    }//sqlcommand
                }//try
                catch { Console.WriteLine("Failed to update, please try again"); }
                con.Close();
            }//sqlconnection
        }//ProcessBill

        public static int BillTotal(int BillNumber)
        {
            int Total = 0;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Total FROM Bill WHERE BillNumber = " + BillNumber, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            
                            Total = Convert.ToInt32(reader["Total"]);
                            
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
            return Total;
        }//ReadSubBill
        
        public static int MonthsBetween(string start, string finish)
        {
            string[] startdate = start.Split('/');
            string[] enddate = finish.Split('/');

            int StartDay = Convert.ToInt32(startdate[0]);
            int StartMonth = Convert.ToInt32(startdate[1]);
            int StartYear = Convert.ToInt32(startdate[2]);

            int EndDay = Convert.ToInt32(enddate[0]);
            int EndMonth = Convert.ToInt32(enddate[1]);
            int EndYear = Convert.ToInt32(enddate[2]);

            int multiplier = 1;

            double totalMonths = (EndYear - StartYear) * 12;

            totalMonths += EndMonth - StartMonth;

            double averageDaysInMonth = 30.436875;

            totalMonths -= StartDay / averageDaysInMonth;

            totalMonths += EndDay / averageDaysInMonth;
            int NumMonths = Convert.ToInt32(totalMonths);
            return NumMonths * multiplier;
        }//MonthsBetween

        public static int[] PreviousDate(int Day,int Month,int Year)
        {
            Day = Day - 1;
            if(Day == 0)
            {
                Month = Month - 1;
                if(Month == 0)
                {
                    Year = Year - 1;
                }
            }
            int[] Date = { Day, Month, Year };

            return Date;
        }//PreviousDate

        public static int WhatDay(string date)
        {
            string[] Date = date.Split('/');

            int Day = Convert.ToInt32(Date[0]);
            return Day;
            
        }//WhatDay

        public static int WhatMonth(string date)
        {
            string[] Date = date.Split('/');

            int Month = Convert.ToInt32(Date[1]);
            return Month;

        }//WhatMonth

        public static int WhatYear(string date)
        {
            string[] Date = date.Split('/');

            int Year = Convert.ToInt32(Date[2]);
            return Year;

        }//WhatYear

        //----------------------BillDetail Methods


        public static void AddBillDetails(int BillNumber,string[] row)
        {
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";

            int SubscriptionID = Convert.ToInt32(row[0]);
            //int BillNumber = 4001;
            int BillRowKey = 5001;
            int SoftwareID = Convert.ToInt32(row[1]);
            string SoftwareName = WhichSoftware(SoftwareID);
            int ServiceID = Convert.ToInt32(row[2]);
            string ServiceName = WhichService(ServiceID);
            int Quantity = Convert.ToInt32(row[3]);
            int Price = Convert.ToInt32(row[4]);
            int SubTotal = Quantity * Price;

            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT RowKey FROM BillDetail", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            BillRowKey = Convert.ToInt32(reader["RowKey"]);
                        }
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

            BillRowKey = BillRowKey + 1;

            //List<Bill> Bills = DAL.ReadSubBill(SubscriptionID);

            //Bills.ForEach(b =>
            //{
            //    BillNumber = b.BillNumber;

                PersistBillDetail(BillNumber, BillRowKey, SoftwareID, SoftwareName , ServiceID, ServiceName, Quantity, Price, SubTotal);
            //    BillRowKey = BillRowKey + 1;
            //});
            
        }//AddSubDetails

        public static void PersistBillDetail(int BillNumber, int BillRowKey, int SoftwareID, string SoftwareName, int ServiceID, string ServiceName, int Quantity, int Price, int SubTotal)
        {
            string Deleted = "false";
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO BillDetail VALUES(@BillNumber,@RowKey,@SoftwareID,@SoftwareName,@ServiceID,@ServiceName,@Quantity,@Price,@SubTotal,@Deleted)", con))
                    {
                        command.Parameters.Add(new SqlParameter("BillNumber", BillNumber));
                        command.Parameters.Add(new SqlParameter("RowKey", BillRowKey));
                        command.Parameters.Add(new SqlParameter("SoftwareID", SoftwareID));
                        command.Parameters.Add(new SqlParameter("SoftwareName", SoftwareName));
                        command.Parameters.Add(new SqlParameter("ServiceID", ServiceID));
                        command.Parameters.Add(new SqlParameter("ServiceName", ServiceName));
                        command.Parameters.Add(new SqlParameter("Quantity", Quantity));
                        command.Parameters.Add(new SqlParameter("Price", Price));
                        command.Parameters.Add(new SqlParameter("SubTotal", SubTotal));
                        command.Parameters.Add(new SqlParameter("Deleted", Deleted));
                        command.ExecuteNonQuery();
                    }//sqlcommand
                    Console.WriteLine("Row inserted");

                    int Total = BillTotal(BillNumber) + SubTotal;

                    using (SqlCommand command = new SqlCommand("UPDATE Bill SET Total = " + Total + " WHERE BillNumber = " + BillNumber, con))
                    {
                        command.ExecuteNonQuery();
                    }//sqlcommand

                }//try
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                con.Close();
            }//sqlconnection
        }//PersistBillDetail

        public static List<BillDetail> ReadBillDetail(int BillNum)
        {
            List<BillDetail> BillDetails = new List<BillDetail>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM BillDetail WHERE BillNumber = " + BillNum + " and Deleted != 'true'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int billnumber = Convert.ToInt32(reader["BillNumber"]);
                            int BillRowkey = Convert.ToInt32(reader["RowKey"]);
                            int softwareID = Convert.ToInt32(reader["SoftwareID"]);
                            string softwarename = reader["SoftwareName"].ToString();
                            int serviceID = Convert.ToInt32(reader["ServiceID"]);
                            string servicename = reader["ServiceName"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            int price = Convert.ToInt32(reader["Price"]);
                            int subtotal = Convert.ToInt32(reader["SubTotal"]);
                            BillDetails.Add(new BillDetail()
                            {
                                BillNumber = billnumber,
                                Key = BillRowkey,
                                SoftwareID = softwareID,
                                SoftwareName = softwarename,
                                ServiceID = serviceID,
                                ServiceName = servicename,
                                Quantity = quantity,
                                Price = price,
                                SubTotal = subtotal
                            });

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
            return BillDetails;
        }//readBillDetail

        //----------------------Software and Service Methods

        public static String WhichSoftware(int SoftwareID)
        {
            string softwarename = "";
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Software WHERE SoftwareID = " + SoftwareID, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            softwarename = reader["Name"].ToString();
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
            return softwarename;
        }//WhichSoftware

        public static String WhichService(int ServiceID)
        {
            string servicename = "";
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Service WHERE ServiceID = " + ServiceID, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            servicename = reader["Name"].ToString();
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
            return servicename;
        }//WhichService

        public static int ServicePrice(int ServiceID)
        {
            int serviceprice = 0;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Price FROM Service WHERE ServiceID = " + ServiceID, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            serviceprice = Convert.ToInt32(reader["Price"]);
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
            return serviceprice;
        }//ServicePrice

        public static int ServiceMinQuantity(int ServiceID)
        {
            int minquantity = 0;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [Minimum Quantity] FROM Service WHERE ServiceID = " + ServiceID, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            minquantity = Convert.ToInt32(reader["Minimum Quantity"]);
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
            return minquantity;
        }//ServicePrice

        public static List<Software> ReadSoftware()
        {
            List<Software> Softwares = new List<Software>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Software", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int softwareID = Convert.ToInt32(reader["SoftwareID"]);
                            string name = reader["Name"].ToString();
                            Softwares.Add(new Software()
                            {
                                SoftwareID = softwareID,
                                Name = name
                            });

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
            return Softwares;
        }//readSoftware

        public static List<Service> ReadService()
        {
            List<Service> Services = new List<Service>();
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Service", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int serviceID = Convert.ToInt32(reader["ServiceID"]);
                            int softwareID = Convert.ToInt32(reader["SoftwareID"]);
                            string name = reader["Name"].ToString();
                            int price = Convert.ToInt32(reader["Price"]);
                            int minimumquantity = Convert.ToInt32(reader["Minimum Quantity"]);
                            Services.Add(new Service()
                            {
                                ServiceID = serviceID,
                                SoftwareID = softwareID,
                                Name = name,
                                Price = price,
                                MinimumQuantity = minimumquantity
                            });

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
            return Services;
        }//readService

        //----------------------Authentication Methods

        public static Boolean Authenticate(string UserID,string Password)
        {
            Boolean Authorized = false;
            string connString = "Database=KhalidTest;Server=Localhost;Trusted_Connection=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Password FROM Authentication WHERE UserID = '" + UserID + "'", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                           string password = reader["Password"].ToString();
                            if (password == Password) { Authorized = true; }
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
            return Authorized;
        }//Authenticate

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
        public int CustomerCode { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<SubscriptionDetail> SubscriptionDetails = new List<SubscriptionDetail>();
        public List<Bill> Bills = new List<Bill>();
        public override string ToString()
        {
            return string.Format("SubscriptionID: {0},Date: {1},CustumerCode: {2},StartDate: {3},EndDate: {4} \n",
                SubscriptionID, Date, CustomerCode, StartDate, EndDate);

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
        public int BillNumber { get; set; }
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
