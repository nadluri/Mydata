namespace Bookshope
{
    partial class paycheque
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
            this.txtchequenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbchequestatus = new System.Windows.Forms.ComboBox();
            this.cmbbankname = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Number";
            // 
            // txtbillnumber
            // 
            this.txtbillnumber.Location = new System.Drawing.Point(152, 50);
            this.txtbillnumber.Name = "txtbillnumber";
            this.txtbillnumber.Size = new System.Drawing.Size(100, 20);
            this.txtbillnumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cheque Number";
            // 
            // txtchequenumber
            // 
            this.txtchequenumber.Location = new System.Drawing.Point(152, 94);
            this.txtchequenumber.Name = "txtchequenumber";
            this.txtchequenumber.Size = new System.Drawing.Size(100, 20);
            this.txtchequenumber.TabIndex = 3;
            this.txtchequenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtchequenumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bank Name";
            // 
            // txtbranch
            // 
            this.txtbranch.Location = new System.Drawing.Point(161, 192);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(100, 20);
            this.txtbranch.TabIndex = 5;
            this.txtbranch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbranch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(152, 231);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 9;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cheque Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cheque Status";
            // 
            // cmbchequestatus
            // 
            this.cmbchequestatus.FormattingEnabled = true;
            this.cmbchequestatus.Items.AddRange(new object[] {
            "Cleared",
            "Received",
            "Bounced",
            "Submitted",
            "Returned"});
            this.cmbchequestatus.Location = new System.Drawing.Point(152, 324);
            this.cmbchequestatus.Name = "cmbchequestatus";
            this.cmbchequestatus.Size = new System.Drawing.Size(121, 21);
            this.cmbchequestatus.TabIndex = 14;
            // 
            // cmbbankname
            // 
            this.cmbbankname.FormattingEnabled = true;
            this.cmbbankname.Items.AddRange(new object[] {
            "SBI",
            "SBH",
            "ICC",
            "DCC",
            "ANDHRA",
            "AXISE"});
            this.cmbbankname.Location = new System.Drawing.Point(152, 146);
            this.cmbbankname.Name = "cmbbankname";
            this.cmbbankname.Size = new System.Drawing.Size(121, 21);
            this.cmbbankname.TabIndex = 15;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(55, 393);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(177, 393);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 17;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // paycheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 462);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbbankname);
            this.Controls.Add(this.cmbchequestatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbranch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtchequenumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbillnumber);
            this.Controls.Add(this.label1);
            this.Name = "paycheque";
            this.Text = "paycheque";
            this.Load += new System.EventHandler(this.paycheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbillnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtchequenumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbchequestatus;
        private System.Windows.Forms.ComboBox cmbbankname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}