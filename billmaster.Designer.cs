namespace Bookshope
{
    partial class billmaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbillnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbilldate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbilltotalmrp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbilldiscountamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbilltotalamount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtamountpaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcustomeraddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcustomercontactnum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcustomermailid = new System.Windows.Forms.TextBox();
            this.btnprintbill = new System.Windows.Forms.Button();
            this.btnnewbill = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.cmbinstallments = new System.Windows.Forms.ComboBox();
            this.cmbpaymentmode = new System.Windows.Forms.ComboBox();
            this.cmbbillstatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Master Details";
            // 
            // txtbillnumber
            // 
            this.txtbillnumber.Location = new System.Drawing.Point(252, 50);
            this.txtbillnumber.Name = "txtbillnumber";
            this.txtbillnumber.Size = new System.Drawing.Size(131, 20);
            this.txtbillnumber.TabIndex = 1;
            this.txtbillnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbillnumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BillNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // txtbilldate
            // 
            this.txtbilldate.Location = new System.Drawing.Point(252, 99);
            this.txtbilldate.Name = "txtbilldate";
            this.txtbilldate.Size = new System.Drawing.Size(131, 20);
            this.txtbilldate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bill Total MRP";
            // 
            // txtbilltotalmrp
            // 
            this.txtbilltotalmrp.Location = new System.Drawing.Point(252, 146);
            this.txtbilltotalmrp.Name = "txtbilltotalmrp";
            this.txtbilltotalmrp.Size = new System.Drawing.Size(131, 20);
            this.txtbilltotalmrp.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bill Discount Amount";
            // 
            // txtbilldiscountamount
            // 
            this.txtbilldiscountamount.Location = new System.Drawing.Point(252, 190);
            this.txtbilldiscountamount.Name = "txtbilldiscountamount";
            this.txtbilldiscountamount.Size = new System.Drawing.Size(131, 20);
            this.txtbilldiscountamount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bill Total Amount";
            // 
            // txtbilltotalamount
            // 
            this.txtbilltotalamount.Location = new System.Drawing.Point(252, 243);
            this.txtbilltotalamount.Name = "txtbilltotalamount";
            this.txtbilltotalamount.Size = new System.Drawing.Size(131, 20);
            this.txtbilltotalamount.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Installments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Payment Mode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Amount Paid";
            // 
            // txtamountpaid
            // 
            this.txtamountpaid.Location = new System.Drawing.Point(252, 395);
            this.txtamountpaid.Name = "txtamountpaid";
            this.txtamountpaid.Size = new System.Drawing.Size(131, 20);
            this.txtamountpaid.TabIndex = 16;
            this.txtamountpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamountpaid_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Bill Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Bill Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Customer Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Customer Name";
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(598, 96);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(168, 20);
            this.txtcustomername.TabIndex = 23;
            this.txtcustomername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustomername_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(437, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Customer Address";
            // 
            // txtcustomeraddress
            // 
            this.txtcustomeraddress.Location = new System.Drawing.Point(598, 163);
            this.txtcustomeraddress.Name = "txtcustomeraddress";
            this.txtcustomeraddress.Size = new System.Drawing.Size(168, 20);
            this.txtcustomeraddress.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(427, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 26);
            this.label15.TabIndex = 26;
            this.label15.Text = "Customer Contact Num\r\n\r\n";
            // 
            // txtcustomercontactnum
            // 
            this.txtcustomercontactnum.Location = new System.Drawing.Point(598, 232);
            this.txtcustomercontactnum.MaxLength = 10;
            this.txtcustomercontactnum.Name = "txtcustomercontactnum";
            this.txtcustomercontactnum.Size = new System.Drawing.Size(176, 20);
            this.txtcustomercontactnum.TabIndex = 27;
            this.txtcustomercontactnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustomercontactnum_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(437, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Customer MailId";
            // 
            // txtcustomermailid
            // 
            this.txtcustomermailid.Location = new System.Drawing.Point(598, 299);
            this.txtcustomermailid.Name = "txtcustomermailid";
            this.txtcustomermailid.Size = new System.Drawing.Size(176, 20);
            this.txtcustomermailid.TabIndex = 29;
            this.txtcustomermailid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustomermailid_KeyPress);
            // 
            // btnprintbill
            // 
            this.btnprintbill.Location = new System.Drawing.Point(631, 379);
            this.btnprintbill.Name = "btnprintbill";
            this.btnprintbill.Size = new System.Drawing.Size(75, 23);
            this.btnprintbill.TabIndex = 30;
            this.btnprintbill.Text = "Print Bill";
            this.btnprintbill.UseVisualStyleBackColor = true;
            // 
            // btnnewbill
            // 
            this.btnnewbill.Location = new System.Drawing.Point(211, 499);
            this.btnnewbill.Name = "btnnewbill";
            this.btnnewbill.Size = new System.Drawing.Size(75, 23);
            this.btnnewbill.TabIndex = 31;
            this.btnnewbill.Text = "New Bill";
            this.btnnewbill.UseVisualStyleBackColor = true;
            this.btnnewbill.Click += new System.EventHandler(this.btnnewbill_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(322, 500);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(430, 501);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 33;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(546, 500);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 34;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // cmbinstallments
            // 
            this.cmbinstallments.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.cmbinstallments.FormattingEnabled = true;
            this.cmbinstallments.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbinstallments.Location = new System.Drawing.Point(252, 299);
            this.cmbinstallments.Name = "cmbinstallments";
            this.cmbinstallments.Size = new System.Drawing.Size(131, 21);
            this.cmbinstallments.TabIndex = 35;
            this.cmbinstallments.SelectedIndexChanged += new System.EventHandler(this.cmbinstallments_SelectedIndexChanged);
            // 
            // cmbpaymentmode
            // 
            this.cmbpaymentmode.AutoCompleteCustomSource.AddRange(new string[] {
            "Cash",
            "Cheque"});
            this.cmbpaymentmode.FormattingEnabled = true;
            this.cmbpaymentmode.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Cheque"});
            this.cmbpaymentmode.Location = new System.Drawing.Point(252, 342);
            this.cmbpaymentmode.Name = "cmbpaymentmode";
            this.cmbpaymentmode.Size = new System.Drawing.Size(131, 21);
            this.cmbpaymentmode.TabIndex = 36;
            this.cmbpaymentmode.SelectedIndexChanged += new System.EventHandler(this.cmbpaymentmode_SelectedIndexChanged);
            // 
            // cmbbillstatus
            // 
            this.cmbbillstatus.FormattingEnabled = true;
            this.cmbbillstatus.Items.AddRange(new object[] {
            "Closed",
            "Pending"});
            this.cmbbillstatus.Location = new System.Drawing.Point(252, 443);
            this.cmbbillstatus.Name = "cmbbillstatus";
            this.cmbbillstatus.Size = new System.Drawing.Size(131, 21);
            this.cmbbillstatus.TabIndex = 37;
            this.cmbbillstatus.SelectedIndexChanged += new System.EventHandler(this.cmbbillstatus_SelectedIndexChanged);
            // 
            // billmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 546);
            this.Controls.Add(this.cmbbillstatus);
            this.Controls.Add(this.cmbpaymentmode);
            this.Controls.Add(this.cmbinstallments);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnewbill);
            this.Controls.Add(this.btnprintbill);
            this.Controls.Add(this.txtcustomermailid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtcustomercontactnum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtcustomeraddress);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtamountpaid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbilltotalamount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbilldiscountamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbilltotalmrp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbilldate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbillnumber);
            this.Controls.Add(this.label1);
            this.Name = "billmaster";
            this.Text = "billmaster";
            this.Load += new System.EventHandler(this.billmaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbillnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbilldate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbilltotalmrp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbilldiscountamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbilltotalamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtamountpaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcustomeraddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcustomercontactnum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtcustomermailid;
        private System.Windows.Forms.Button btnprintbill;
        private System.Windows.Forms.Button btnnewbill;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbinstallments;
        private System.Windows.Forms.ComboBox cmbpaymentmode;
        private System.Windows.Forms.ComboBox cmbbillstatus;
    }
}