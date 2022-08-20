namespace Bookshope
{
    partial class bookpurchase
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
            this.cmbbookid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmrp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiscountprice = new System.Windows.Forms.TextBox();
            this.txtdiscountamount = new System.Windows.Forms.TextBox();
            this.txtsaleamount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.dgrvbillmaster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvbillmaster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Book Id";
            // 
            // cmbbookid
            // 
            this.cmbbookid.FormattingEnabled = true;
            this.cmbbookid.Location = new System.Drawing.Point(224, 37);
            this.cmbbookid.Name = "cmbbookid";
            this.cmbbookid.Size = new System.Drawing.Size(121, 21);
            this.cmbbookid.TabIndex = 1;
            this.cmbbookid.SelectedIndexChanged += new System.EventHandler(this.cmbbookid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name is";
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(224, 76);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(121, 20);
            this.txtbookname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MRP is";
            // 
            // txtmrp
            // 
            this.txtmrp.Location = new System.Drawing.Point(224, 115);
            this.txtmrp.Name = "txtmrp";
            this.txtmrp.Size = new System.Drawing.Size(121, 20);
            this.txtmrp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Entity Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(224, 163);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(121, 20);
            this.txtquantity.TabIndex = 7;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Price";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(224, 213);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(121, 20);
            this.txtprice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Discount Percent";
            // 
            // txtdiscountprice
            // 
            this.txtdiscountprice.Location = new System.Drawing.Point(224, 261);
            this.txtdiscountprice.Name = "txtdiscountprice";
            this.txtdiscountprice.Size = new System.Drawing.Size(121, 20);
            this.txtdiscountprice.TabIndex = 11;
            this.txtdiscountprice.TextChanged += new System.EventHandler(this.txtdiscountprice_TextChanged);
            // 
            // txtdiscountamount
            // 
            this.txtdiscountamount.Location = new System.Drawing.Point(224, 322);
            this.txtdiscountamount.Name = "txtdiscountamount";
            this.txtdiscountamount.Size = new System.Drawing.Size(121, 20);
            this.txtdiscountamount.TabIndex = 12;
            this.txtdiscountamount.TextChanged += new System.EventHandler(this.txtdiscountamount_TextChanged);
            // 
            // txtsaleamount
            // 
            this.txtsaleamount.Location = new System.Drawing.Point(224, 377);
            this.txtsaleamount.Name = "txtsaleamount";
            this.txtsaleamount.Size = new System.Drawing.Size(121, 20);
            this.txtsaleamount.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Discount Amount is";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sale Amount is";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Book Purchase  Detail Form";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(104, 434);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(224, 439);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 18;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // dgrvbillmaster
            // 
            this.dgrvbillmaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvbillmaster.Location = new System.Drawing.Point(473, 56);
            this.dgrvbillmaster.Name = "dgrvbillmaster";
            this.dgrvbillmaster.Size = new System.Drawing.Size(319, 269);
            this.dgrvbillmaster.TabIndex = 19;
            // 
            // bookpurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 512);
            this.Controls.Add(this.dgrvbillmaster);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsaleamount);
            this.Controls.Add(this.txtdiscountamount);
            this.Controls.Add(this.txtdiscountprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmrp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbookid);
            this.Controls.Add(this.label1);
            this.Name = "bookpurchase";
            this.Text = "bookpurchase";
            this.Load += new System.EventHandler(this.billmaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvbillmaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbookid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmrp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiscountprice;
        private System.Windows.Forms.TextBox txtdiscountamount;
        private System.Windows.Forms.TextBox txtsaleamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.DataGridView dgrvbillmaster;
    }
}