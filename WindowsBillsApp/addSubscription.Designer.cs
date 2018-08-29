namespace WindowsBillsApp
{
    partial class addSubscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSubscription));
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
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSubNew = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtSubID = new System.Windows.Forms.TextBox();
            this.lblSubID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetailDelete
            // 
            this.btnDetailDelete.Location = new System.Drawing.Point(435, 407);
            this.btnDetailDelete.Name = "btnDetailDelete";
            this.btnDetailDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDetailDelete.TabIndex = 88;
            this.btnDetailDelete.Text = "Delete";
            this.btnDetailDelete.UseVisualStyleBackColor = true;
            this.btnDetailDelete.Click += new System.EventHandler(this.btnDetailDelete_Click);
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Location = new System.Drawing.Point(273, 375);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(31, 13);
            this.lblServicePrice.TabIndex = 87;
            this.lblServicePrice.Text = "Price";
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Location = new System.Drawing.Point(385, 371);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(125, 20);
            this.txtServicePrice.TabIndex = 86;
            this.txtServicePrice.TextChanged += new System.EventHandler(this.txtServicePrice_TextChanged);
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(273, 337);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblServiceName.TabIndex = 85;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.AutoSize = true;
            this.lblSoftwareName.Location = new System.Drawing.Point(273, 301);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(80, 13);
            this.lblSoftwareName.TabIndex = 84;
            this.lblSoftwareName.Text = "Software Name";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(385, 333);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.Size = new System.Drawing.Size(125, 20);
            this.txtServiceName.TabIndex = 83;
            // 
            // txtSoftwareName
            // 
            this.txtSoftwareName.Location = new System.Drawing.Point(385, 298);
            this.txtSoftwareName.Name = "txtSoftwareName";
            this.txtSoftwareName.ReadOnly = true;
            this.txtSoftwareName.Size = new System.Drawing.Size(125, 20);
            this.txtSoftwareName.TabIndex = 82;
            // 
            // btnDetailAdd
            // 
            this.btnDetailAdd.Location = new System.Drawing.Point(354, 407);
            this.btnDetailAdd.Name = "btnDetailAdd";
            this.btnDetailAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDetailAdd.TabIndex = 81;
            this.btnDetailAdd.Text = "Add";
            this.btnDetailAdd.UseVisualStyleBackColor = true;
            this.btnDetailAdd.Click += new System.EventHandler(this.btnDetailAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(21, 374);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 80;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(21, 336);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(54, 13);
            this.lblServiceID.TabIndex = 79;
            this.lblServiceID.Text = "ServiceID";
            // 
            // lblSoftwareID
            // 
            this.lblSoftwareID.AutoSize = true;
            this.lblSoftwareID.Location = new System.Drawing.Point(21, 300);
            this.lblSoftwareID.Name = "lblSoftwareID";
            this.lblSoftwareID.Size = new System.Drawing.Size(60, 13);
            this.lblSoftwareID.TabIndex = 78;
            this.lblSoftwareID.Text = "SoftwareID";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(131, 371);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 77;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // cmbSoftwareID
            // 
            this.cmbSoftwareID.FormattingEnabled = true;
            this.cmbSoftwareID.Location = new System.Drawing.Point(131, 297);
            this.cmbSoftwareID.Name = "cmbSoftwareID";
            this.cmbSoftwareID.Size = new System.Drawing.Size(102, 21);
            this.cmbSoftwareID.TabIndex = 76;
            this.cmbSoftwareID.SelectedIndexChanged += new System.EventHandler(this.cmbSoftwareID_SelectedIndexChanged);
            // 
            // cmbServiceID
            // 
            this.cmbServiceID.FormattingEnabled = true;
            this.cmbServiceID.Location = new System.Drawing.Point(131, 333);
            this.cmbServiceID.Name = "cmbServiceID";
            this.cmbServiceID.Size = new System.Drawing.Size(100, 21);
            this.cmbServiceID.TabIndex = 75;
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
            this.listView3.Location = new System.Drawing.Point(12, 122);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(521, 166);
            this.listView3.TabIndex = 74;
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
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnSubNew);
            this.panel1.Controls.Add(this.btnSubAdd);
            this.panel1.Controls.Add(this.txtCustID);
            this.panel1.Controls.Add(this.lblCustID);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.txtSubID);
            this.panel1.Controls.Add(this.lblSubID);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 105);
            this.panel1.TabIndex = 73;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(371, 7);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker3.TabIndex = 70;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(371, 67);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker2.TabIndex = 69;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // btnSubNew
            // 
            this.btnSubNew.Location = new System.Drawing.Point(117, 67);
            this.btnSubNew.Name = "btnSubNew";
            this.btnSubNew.Size = new System.Drawing.Size(75, 22);
            this.btnSubNew.TabIndex = 67;
            this.btnSubNew.Text = "New";
            this.btnSubNew.UseVisualStyleBackColor = true;
            this.btnSubNew.Click += new System.EventHandler(this.btnSubNew_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Location = new System.Drawing.Point(26, 67);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(75, 22);
            this.btnSubAdd.TabIndex = 66;
            this.btnSubAdd.Text = "Add";
            this.btnSubAdd.UseVisualStyleBackColor = true;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
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
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(259, 42);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(52, 13);
            this.lblStartDate.TabIndex = 62;
            this.lblStartDate.Text = "StartDate";
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
            this.txtSubID.Size = new System.Drawing.Size(129, 20);
            this.txtSubID.TabIndex = 59;
            this.txtSubID.TextChanged += new System.EventHandler(this.txtSubID_TextChanged);
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(259, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "Date";
            // 
            // addSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 453);
            this.Controls.Add(this.btnDetailDelete);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.txtServicePrice);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.lblSoftwareName);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.txtSoftwareName);
            this.Controls.Add(this.btnDetailAdd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblServiceID);
            this.Controls.Add(this.lblSoftwareID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbSoftwareID);
            this.Controls.Add(this.cmbServiceID);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addSubscription";
            this.Text = "addSubscription";
            this.Load += new System.EventHandler(this.addSubscription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetailDelete;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.TextBox txtServicePrice;
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
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubAdd;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtSubID;
        private System.Windows.Forms.Label lblSubID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSubNew;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}