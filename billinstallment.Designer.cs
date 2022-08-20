namespace Bookshope
{
    partial class billinstallment
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
            this.label2 = new System.Windows.Forms.Label();
            this.Txtbillnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinstallmentnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbpaymentmode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpaydate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtamountbefore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtamountpaid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbalanceamount = new System.Windows.Forms.TextBox();
            this.dgrvbillinstallment = new System.Windows.Forms.DataGridView();
            this.Addbtn = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvbillinstallment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Installment Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill Number";
            // 
            // Txtbillnumber
            // 
            this.Txtbillnumber.Location = new System.Drawing.Point(159, 66);
            this.Txtbillnumber.Name = "Txtbillnumber";
            this.Txtbillnumber.Size = new System.Drawing.Size(100, 20);
            this.Txtbillnumber.TabIndex = 2;
            this.Txtbillnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbillnumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Installment Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtinstallmentnumber
            // 
            this.txtinstallmentnumber.Location = new System.Drawing.Point(159, 118);
            this.txtinstallmentnumber.Name = "txtinstallmentnumber";
            this.txtinstallmentnumber.Size = new System.Drawing.Size(100, 20);
            this.txtinstallmentnumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Payment Mode";
            // 
            // cmbpaymentmode
            // 
            this.cmbpaymentmode.FormattingEnabled = true;
            this.cmbpaymentmode.Items.AddRange(new object[] {
            "Cashe",
            "Cheque",
            "Credit card"});
            this.cmbpaymentmode.Location = new System.Drawing.Point(159, 167);
            this.cmbpaymentmode.Name = "cmbpaymentmode";
            this.cmbpaymentmode.Size = new System.Drawing.Size(100, 21);
            this.cmbpaymentmode.TabIndex = 6;
            this.cmbpaymentmode.SelectedIndexChanged += new System.EventHandler(this.cmbpaymentmode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pay Date";
            // 
            // txtpaydate
            // 
            this.txtpaydate.Location = new System.Drawing.Point(159, 228);
            this.txtpaydate.Name = "txtpaydate";
            this.txtpaydate.Size = new System.Drawing.Size(100, 20);
            this.txtpaydate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount Before";
            // 
            // txtamountbefore
            // 
            this.txtamountbefore.Location = new System.Drawing.Point(159, 276);
            this.txtamountbefore.Name = "txtamountbefore";
            this.txtamountbefore.Size = new System.Drawing.Size(100, 20);
            this.txtamountbefore.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amount Paid";
            // 
            // txtamountpaid
            // 
            this.txtamountpaid.Location = new System.Drawing.Point(159, 329);
            this.txtamountpaid.Name = "txtamountpaid";
            this.txtamountpaid.Size = new System.Drawing.Size(100, 20);
            this.txtamountpaid.TabIndex = 12;
            this.txtamountpaid.TextChanged += new System.EventHandler(this.txtamountpaid_TextChanged);
            this.txtamountpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamountpaid_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Balance Amount";
            // 
            // txtbalanceamount
            // 
            this.txtbalanceamount.Location = new System.Drawing.Point(159, 375);
            this.txtbalanceamount.Name = "txtbalanceamount";
            this.txtbalanceamount.Size = new System.Drawing.Size(100, 20);
            this.txtbalanceamount.TabIndex = 14;
            // 
            // dgrvbillinstallment
            // 
            this.dgrvbillinstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvbillinstallment.Location = new System.Drawing.Point(331, 49);
            this.dgrvbillinstallment.Name = "dgrvbillinstallment";
            this.dgrvbillinstallment.Size = new System.Drawing.Size(343, 277);
            this.dgrvbillinstallment.TabIndex = 15;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(235, 420);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 16;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(331, 420);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 17;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // billinstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 483);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.dgrvbillinstallment);
            this.Controls.Add(this.txtbalanceamount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtamountpaid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtamountbefore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpaydate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbpaymentmode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtinstallmentnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtbillnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "billinstallment";
            this.Text = "billinstallment";
            this.Load += new System.EventHandler(this.billinstallment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvbillinstallment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtbillnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinstallmentnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbpaymentmode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpaydate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtamountbefore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtamountpaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbalanceamount;
        private System.Windows.Forms.DataGridView dgrvbillinstallment;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button btnok;
    }
}