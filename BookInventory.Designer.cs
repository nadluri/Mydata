namespace Bookshope
{
    partial class BookInventory
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
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txquntitybefore = new System.Windows.Forms.TextBox();
            this.txtquntityrecevied = new System.Windows.Forms.TextBox();
            this.txtquntityafter = new System.Windows.Forms.TextBox();
            this.txtordernumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnbookid = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Inventory Details";
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(270, 128);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(187, 20);
            this.txtbookid.TabIndex = 1;
            this.txtbookid.TextChanged += new System.EventHandler(this.txtbookid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quntity Before";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quntity After";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Order Number";
            // 
            // txquntitybefore
            // 
            this.txquntitybefore.Location = new System.Drawing.Point(270, 246);
            this.txquntitybefore.Name = "txquntitybefore";
            this.txquntitybefore.Size = new System.Drawing.Size(187, 20);
            this.txquntitybefore.TabIndex = 9;
            // 
            // txtquntityrecevied
            // 
            this.txtquntityrecevied.Location = new System.Drawing.Point(270, 304);
            this.txtquntityrecevied.Name = "txtquntityrecevied";
            this.txtquntityrecevied.Size = new System.Drawing.Size(187, 20);
            this.txtquntityrecevied.TabIndex = 10;
            this.txtquntityrecevied.TextChanged += new System.EventHandler(this.txtquntityrecevied_TextChanged);
            this.txtquntityrecevied.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquntityrecevied_KeyPress);
            // 
            // txtquntityafter
            // 
            this.txtquntityafter.Location = new System.Drawing.Point(270, 356);
            this.txtquntityafter.Name = "txtquntityafter";
            this.txtquntityafter.Size = new System.Drawing.Size(187, 20);
            this.txtquntityafter.TabIndex = 11;
            // 
            // txtordernumber
            // 
            this.txtordernumber.Location = new System.Drawing.Point(270, 403);
            this.txtordernumber.Name = "txtordernumber";
            this.txtordernumber.Size = new System.Drawing.Size(187, 20);
            this.txtordernumber.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quntity Received";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(553, 116);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(553, 232);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(553, 370);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 16;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnbookid
            // 
            this.btnbookid.Location = new System.Drawing.Point(463, 129);
            this.btnbookid.Name = "btnbookid";
            this.btnbookid.Size = new System.Drawing.Size(75, 23);
            this.btnbookid.TabIndex = 17;
            this.btnbookid.Text = "....";
            this.btnbookid.UseVisualStyleBackColor = true;
            this.btnbookid.Click += new System.EventHandler(this.btnbookid_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // BookInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 479);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnbookid);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtordernumber);
            this.Controls.Add(this.txtquntityafter);
            this.Controls.Add(this.txtquntityrecevied);
            this.Controls.Add(this.txquntitybefore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label1);
            this.Name = "BookInventory";
            this.Text = "BookInventory";
            this.Load += new System.EventHandler(this.BookInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txquntitybefore;
        private System.Windows.Forms.TextBox txtquntityrecevied;
        private System.Windows.Forms.TextBox txtquntityafter;
        private System.Windows.Forms.TextBox txtordernumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnbookid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}