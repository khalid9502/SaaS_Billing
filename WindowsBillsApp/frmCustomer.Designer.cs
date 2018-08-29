namespace WindowsBillsApp
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.tabCon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSubNew = new System.Windows.Forms.Button();
            this.btnSubDelete = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SubscriptionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CustID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDetailDelete = new System.Windows.Forms.Button();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblSoftwareName = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtSoftwareName = new System.Windows.Forms.TextBox();
            this.btnDetailAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblSoftwareID = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbSoftwareID = new System.Windows.Forms.ComboBox();
            this.cmbServiceID = new System.Windows.Forms.ComboBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubSave = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtSubID = new System.Windows.Forms.TextBox();
            this.lblSubID = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabCon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCon
            // 
            this.tabCon.Controls.Add(this.tabPage1);
            this.tabCon.Controls.Add(this.tabPage2);
            this.tabCon.Controls.Add(this.tabPage3);
            this.tabCon.Location = new System.Drawing.Point(3, 12);
            this.tabCon.Name = "tabCon";
            this.tabCon.SelectedIndex = 0;
            this.tabCon.Size = new System.Drawing.Size(541, 526);
            this.tabCon.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView4);
            this.tabPage1.Controls.Add(this.btnSubNew);
            this.tabPage1.Controls.Add(this.btnSubDelete);
            this.tabPage1.Controls.Add(this.listView2);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView4.LabelEdit = true;
            this.listView4.Location = new System.Drawing.Point(6, 340);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(520, 148);
            this.listView4.TabIndex = 58;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ServiceID";
            this.columnHeader6.Width = 79;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SoftwareID";
            this.columnHeader7.Width = 69;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ServiceName";
            this.columnHeader8.Width = 128;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SoftwareName";
            this.columnHeader9.Width = 162;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Quantity";
            this.columnHeader10.Width = 72;
            // 
            // btnSubNew
            // 
            this.btnSubNew.Location = new System.Drawing.Point(6, 311);
            this.btnSubNew.Name = "btnSubNew";
            this.btnSubNew.Size = new System.Drawing.Size(75, 23);
            this.btnSubNew.TabIndex = 12;
            this.btnSubNew.Text = "New";
            this.btnSubNew.UseVisualStyleBackColor = true;
            this.btnSubNew.Click += new System.EventHandler(this.btnSubNew_Click);
            // 
            // btnSubDelete
            // 
            this.btnSubDelete.Location = new System.Drawing.Point(451, 311);
            this.btnSubDelete.Name = "btnSubDelete";
            this.btnSubDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSubDelete.TabIndex = 11;
            this.btnSubDelete.Text = "Delete";
            this.btnSubDelete.UseVisualStyleBackColor = true;
            this.btnSubDelete.Click += new System.EventHandler(this.btnSubDelete_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubscriptionID,
            this.Date,
            this.CustomerCode,
            this.StartDate,
            this.EndDate});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(6, 169);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(520, 136);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // SubscriptionID
            // 
            this.SubscriptionID.Text = "SubscriptionID";
            this.SubscriptionID.Width = 109;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 80;
            // 
            // CustomerCode
            // 
            this.CustomerCode.Text = "CustomerCode";
            this.CustomerCode.Width = 110;
            // 
            // StartDate
            // 
            this.StartDate.Text = "StartDate";
            this.StartDate.Width = 89;
            // 
            // EndDate
            // 
            this.EndDate.Text = "EndDate";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(87, 140);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 140);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(451, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustID,
            this.CustName,
            this.CustAccount,
            this.CustPhone,
            this.CustAddress});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(6, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(520, 123);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick_1);
            // 
            // CustID
            // 
            this.CustID.Text = "ID";
            this.CustID.Width = 70;
            // 
            // CustName
            // 
            this.CustName.Text = "Name";
            this.CustName.Width = 110;
            // 
            // CustAccount
            // 
            this.CustAccount.Text = "Account";
            this.CustAccount.Width = 90;
            // 
            // CustPhone
            // 
            this.CustPhone.Text = "Phone";
            this.CustPhone.Width = 107;
            // 
            // CustAddress
            // 
            this.CustAddress.Text = "Address";
            this.CustAddress.Width = 139;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtAccount);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.lblContact);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 236);
            this.panel2.TabIndex = 45;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(116, 43);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(129, 20);
            this.txtAccount.TabIndex = 54;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(22, 46);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(90, 13);
            this.lblAccount.TabIndex = 53;
            this.lblAccount.Text = " Account Number";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(370, 46);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(125, 20);
            this.txtContact.TabIndex = 52;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(258, 49);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(87, 13);
            this.lblContact.TabIndex = 51;
            this.lblContact.Text = "Contact Number ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 72);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(379, 88);
            this.txtAddress.TabIndex = 50;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(22, 75);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 49;
            this.lblAddress.Text = "Address";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.TabIndex = 48;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 13);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "CustomerID  ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(370, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 46;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(258, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Customer Name  ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDetailDelete);
            this.tabPage3.Controls.Add(this.lblServicePrice);
            this.tabPage3.Controls.Add(this.txtServicePrice);
            this.tabPage3.Controls.Add(this.lblServiceName);
            this.tabPage3.Controls.Add(this.lblSoftwareName);
            this.tabPage3.Controls.Add(this.txtServiceName);
            this.tabPage3.Controls.Add(this.txtSoftwareName);
            this.tabPage3.Controls.Add(this.btnDetailAdd);
            this.tabPage3.Controls.Add(this.lblQuantity);
            this.tabPage3.Controls.Add(this.lblServiceID);
            this.tabPage3.Controls.Add(this.lblSoftwareID);
            this.tabPage3.Controls.Add(this.txtQuantity);
            this.tabPage3.Controls.Add(this.cmbSoftwareID);
            this.tabPage3.Controls.Add(this.cmbServiceID);
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(533, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Subscription";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnDetailDelete
            // 
            this.btnDetailDelete.Location = new System.Drawing.Point(429, 399);
            this.btnDetailDelete.Name = "btnDetailDelete";
            this.btnDetailDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDetailDelete.TabIndex = 72;
            this.btnDetailDelete.Text = "Delete";
            this.btnDetailDelete.UseVisualStyleBackColor = true;
            this.btnDetailDelete.Click += new System.EventHandler(this.btnDetailDelete_Click);
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Location = new System.Drawing.Point(267, 367);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(31, 13);
            this.lblServicePrice.TabIndex = 71;
            this.lblServicePrice.Text = "Price";
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Location = new System.Drawing.Point(379, 363);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(125, 20);
            this.txtServicePrice.TabIndex = 70;
            this.txtServicePrice.TextChanged += new System.EventHandler(this.txtServicePrice_TextChanged);
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(267, 329);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblServiceName.TabIndex = 69;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.AutoSize = true;
            this.lblSoftwareName.Location = new System.Drawing.Point(267, 293);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(80, 13);
            this.lblSoftwareName.TabIndex = 68;
            this.lblSoftwareName.Text = "Software Name";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(379, 325);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.Size = new System.Drawing.Size(125, 20);
            this.txtServiceName.TabIndex = 67;
            // 
            // txtSoftwareName
            // 
            this.txtSoftwareName.Location = new System.Drawing.Point(379, 290);
            this.txtSoftwareName.Name = "txtSoftwareName";
            this.txtSoftwareName.ReadOnly = true;
            this.txtSoftwareName.Size = new System.Drawing.Size(125, 20);
            this.txtSoftwareName.TabIndex = 65;
            // 
            // btnDetailAdd
            // 
            this.btnDetailAdd.Location = new System.Drawing.Point(348, 399);
            this.btnDetailAdd.Name = "btnDetailAdd";
            this.btnDetailAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDetailAdd.TabIndex = 64;
            this.btnDetailAdd.Text = "Add";
            this.btnDetailAdd.UseVisualStyleBackColor = true;
            this.btnDetailAdd.Click += new System.EventHandler(this.btnDetailAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(15, 366);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 63;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(15, 328);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(54, 13);
            this.lblServiceID.TabIndex = 62;
            this.lblServiceID.Text = "ServiceID";
            // 
            // lblSoftwareID
            // 
            this.lblSoftwareID.AutoSize = true;
            this.lblSoftwareID.Location = new System.Drawing.Point(15, 292);
            this.lblSoftwareID.Name = "lblSoftwareID";
            this.lblSoftwareID.Size = new System.Drawing.Size(60, 13);
            this.lblSoftwareID.TabIndex = 61;
            this.lblSoftwareID.Text = "SoftwareID";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(125, 363);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 60;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // cmbSoftwareID
            // 
            this.cmbSoftwareID.FormattingEnabled = true;
            this.cmbSoftwareID.Location = new System.Drawing.Point(125, 289);
            this.cmbSoftwareID.Name = "cmbSoftwareID";
            this.cmbSoftwareID.Size = new System.Drawing.Size(102, 21);
            this.cmbSoftwareID.TabIndex = 59;
            this.cmbSoftwareID.SelectedIndexChanged += new System.EventHandler(this.cmbSoftwareID_SelectedIndexChanged);
            // 
            // cmbServiceID
            // 
            this.cmbServiceID.FormattingEnabled = true;
            this.cmbServiceID.Location = new System.Drawing.Point(125, 325);
            this.cmbServiceID.Name = "cmbServiceID";
            this.cmbServiceID.Size = new System.Drawing.Size(100, 21);
            this.cmbServiceID.TabIndex = 58;
            this.cmbServiceID.SelectedIndexChanged += new System.EventHandler(this.cmbServiceID_SelectedIndexChanged);
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11});
            this.listView3.FullRowSelect = true;
            this.listView3.LabelEdit = true;
            this.listView3.Location = new System.Drawing.Point(6, 114);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(521, 166);
            this.listView3.TabIndex = 57;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ServiceID";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SoftwareID";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ServiceName";
            this.columnHeader3.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SoftwareName";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "k";
            this.columnHeader11.Width = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSubSave);
            this.panel1.Controls.Add(this.txtCustID);
            this.panel1.Controls.Add(this.lblCustID);
            this.panel1.Controls.Add(this.txtStartDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.txtEndDate);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.txtSubID);
            this.panel1.Controls.Add(this.lblSubID);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 105);
            this.panel1.TabIndex = 56;
            // 
            // btnSubSave
            // 
            this.btnSubSave.Location = new System.Drawing.Point(26, 67);
            this.btnSubSave.Name = "btnSubSave";
            this.btnSubSave.Size = new System.Drawing.Size(75, 22);
            this.btnSubSave.TabIndex = 66;
            this.btnSubSave.Text = "Save";
            this.btnSubSave.UseVisualStyleBackColor = true;
            this.btnSubSave.Click += new System.EventHandler(this.btnSubSave_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(117, 36);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(129, 20);
            this.txtCustID.TabIndex = 65;
            this.txtCustID.TextChanged += new System.EventHandler(this.txtCustID_TextChanged);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(23, 39);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(65, 13);
            this.lblCustID.TabIndex = 64;
            this.lblCustID.Text = " CustomerID";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(371, 39);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(125, 20);
            this.txtStartDate.TabIndex = 63;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(259, 42);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(52, 13);
            this.lblStartDate.TabIndex = 62;
            this.lblStartDate.Text = "StartDate";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(371, 69);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(125, 20);
            this.txtEndDate.TabIndex = 61;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(259, 72);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(49, 13);
            this.lblEndDate.TabIndex = 60;
            this.lblEndDate.Text = "EndDate";
            // 
            // txtSubID
            // 
            this.txtSubID.Location = new System.Drawing.Point(117, 10);
            this.txtSubID.Name = "txtSubID";
            this.txtSubID.ReadOnly = true;
            this.txtSubID.Size = new System.Drawing.Size(129, 20);
            this.txtSubID.TabIndex = 59;
            // 
            // lblSubID
            // 
            this.lblSubID.AutoSize = true;
            this.lblSubID.Location = new System.Drawing.Point(23, 10);
            this.lblSubID.Name = "lblSubID";
            this.lblSubID.Size = new System.Drawing.Size(82, 13);
            this.lblSubID.TabIndex = 58;
            this.lblSubID.Text = "SubscriptionID  ";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(371, 13);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(125, 20);
            this.txtDate.TabIndex = 57;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(259, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "Date";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 541);
            this.Controls.Add(this.tabCon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tabCon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CustID;
        private System.Windows.Forms.ColumnHeader CustName;
        private System.Windows.Forms.ColumnHeader CustAccount;
        private System.Windows.Forms.ColumnHeader CustPhone;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader SubscriptionID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader CustomerCode;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubSave;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtSubID;
        private System.Windows.Forms.Label lblSubID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSubDelete;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtSoftwareName;
        private System.Windows.Forms.Button btnDetailAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblSoftwareID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbSoftwareID;
        private System.Windows.Forms.ComboBox cmbServiceID;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnDetailDelete;
        private System.Windows.Forms.Button btnSubNew;
        private System.Windows.Forms.ColumnHeader CustAddress;
    }
}