namespace Bookshope
{
    partial class paycardform
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
            this.dgrvpaycardform = new System.Windows.Forms.DataGridView();
            this.cmdbank = new System.Windows.Forms.ComboBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcardnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbillnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.cmbcrdtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvpaycardform)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvpaycardform
            // 
            this.dgrvpaycardform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvpaycardform.Location = new System.Drawing.Point(275, 94);
            this.dgrvpaycardform.Name = "dgrvpaycardform";
            this.dgrvpaycardform.Size = new System.Drawing.Size(240, 150);
            this.dgrvpaycardform.TabIndex = 29;
            // 
            // cmdbank
            // 
            this.cmdbank.FormattingEnabled = true;
            this.cmdbank.Items.AddRange(new object[] {
            "SBI",
            "SBH",
            "ICC",
            "DCC",
            "ANDHRA",
            "AXISE"});
            this.cmdbank.Location = new System.Drawing.Point(117, 236);
            this.cmdbank.Name = "cmdbank";
            this.cmdbank.Size = new System.Drawing.Size(121, 21);
            this.cmdbank.TabIndex = 28;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(126, 275);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 27;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Card Type";
            // 
            // txtcardnumber
            // 
            this.txtcardnumber.Location = new System.Drawing.Point(126, 138);
            this.txtcardnumber.Name = "txtcardnumber";
            this.txtcardnumber.Size = new System.Drawing.Size(100, 20);
            this.txtcardnumber.TabIndex = 22;
            this.txtcardnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcardnumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Card Number";
            // 
            // txtbillnumber
            // 
            this.txtbillnumber.Location = new System.Drawing.Point(126, 94);
            this.txtbillnumber.Name = "txtbillnumber";
            this.txtbillnumber.Size = new System.Drawing.Size(100, 20);
            this.txtbillnumber.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bill Number";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(55, 334);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 30;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(275, 334);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 31;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // cmbcrdtype
            // 
            this.cmbcrdtype.FormattingEnabled = true;
            this.cmbcrdtype.Items.AddRange(new object[] {
            "VISA",
            "Master",
            "Debit Card",
            "Credit Card"});
            this.cmbcrdtype.Location = new System.Drawing.Point(126, 185);
            this.cmbcrdtype.Name = "cmbcrdtype";
            this.cmbcrdtype.Size = new System.Drawing.Size(121, 21);
            this.cmbcrdtype.TabIndex = 32;
            this.cmbcrdtype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // paycardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 389);
            this.Controls.Add(this.cmbcrdtype);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgrvpaycardform);
            this.Controls.Add(this.cmdbank);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcardnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbillnumber);
            this.Controls.Add(this.label1);
            this.Name = "paycardform";
            this.Text = "paycardform";
            this.Load += new System.EventHandler(this.paycardform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvpaycardform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvpaycardform;
        private System.Windows.Forms.ComboBox cmdbank;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcardnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbillnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.ComboBox cmbcrdtype;
    }
}