namespace Bookshope
{
    partial class bookmaster
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
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmrp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcostprice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtauthornames = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.txtisbncode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpublishercode = new System.Windows.Forms.TextBox();
            this.btnpublishercode = new System.Windows.Forms.Button();
            this.btnbookimage = new System.Windows.Forms.Button();
            this.cmbbooktype = new System.Windows.Forms.ComboBox();
            this.cmbbooklevel = new System.Windows.Forms.ComboBox();
            this.cmbbookcategory = new System.Windows.Forms.ComboBox();
            this.cmbpublishedyear = new System.Windows.Forms.ComboBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picbookimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbookimage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(217, 193);
            this.txtbookid.MaxLength = 5;
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(100, 20);
            this.txtbookid.TabIndex = 158;
            this.txtbookid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookid_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 154;
            this.label15.Text = "Book Image";
            // 
            // txtmrp
            // 
            this.txtmrp.Location = new System.Drawing.Point(453, 351);
            this.txtmrp.Name = "txtmrp";
            this.txtmrp.Size = new System.Drawing.Size(100, 20);
            this.txtmrp.TabIndex = 153;
            this.txtmrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmrp_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(358, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 152;
            this.label14.Text = "MRP";
            // 
            // txtcostprice
            // 
            this.txtcostprice.Location = new System.Drawing.Point(453, 309);
            this.txtcostprice.Name = "txtcostprice";
            this.txtcostprice.Size = new System.Drawing.Size(100, 20);
            this.txtcostprice.TabIndex = 151;
            this.txtcostprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcostprice_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 150;
            this.label13.Text = "Cost Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(358, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 148;
            this.label12.Text = "Published Year";
            // 
            // txtauthornames
            // 
            this.txtauthornames.Location = new System.Drawing.Point(453, 229);
            this.txtauthornames.MaxLength = 10;
            this.txtauthornames.Name = "txtauthornames";
            this.txtauthornames.Size = new System.Drawing.Size(100, 20);
            this.txtauthornames.TabIndex = 147;
            this.txtauthornames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtauthornames_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 146;
            this.label11.Text = "Author_Names";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 144;
            this.label10.Text = "Book_Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 140;
            this.label8.Text = "Book_Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 138;
            this.label7.Text = "Book_Type ";
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(217, 302);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(100, 20);
            this.txtbookname.TabIndex = 137;
            this.txtbookname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookname_KeyPress);
            // 
            // txtisbncode
            // 
            this.txtisbncode.Location = new System.Drawing.Point(217, 262);
            this.txtisbncode.MaxLength = 18;
            this.txtisbncode.Name = "txtisbncode";
            this.txtisbncode.Size = new System.Drawing.Size(100, 20);
            this.txtisbncode.TabIndex = 136;
            this.txtisbncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtisbncode_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 135;
            this.label5.Text = "ISBNCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "Publisher Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "Book _Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "Publisher Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 130;
            this.label1.Text = "Book Master Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 159;
            this.label6.Text = "Book _Name";
            // 
            // txtpublishercode
            // 
            this.txtpublishercode.Location = new System.Drawing.Point(217, 225);
            this.txtpublishercode.MaxLength = 6;
            this.txtpublishercode.Name = "txtpublishercode";
            this.txtpublishercode.Size = new System.Drawing.Size(100, 20);
            this.txtpublishercode.TabIndex = 134;
            this.txtpublishercode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpublishercode_KeyPress);
            // 
            // btnpublishercode
            // 
            this.btnpublishercode.Location = new System.Drawing.Point(323, 225);
            this.btnpublishercode.Name = "btnpublishercode";
            this.btnpublishercode.Size = new System.Drawing.Size(25, 23);
            this.btnpublishercode.TabIndex = 161;
            this.btnpublishercode.Text = ".....";
            this.btnpublishercode.UseVisualStyleBackColor = true;
            this.btnpublishercode.Click += new System.EventHandler(this.btnpublishercode_Click);
            // 
            // btnbookimage
            // 
            this.btnbookimage.Location = new System.Drawing.Point(559, 425);
            this.btnbookimage.Name = "btnbookimage";
            this.btnbookimage.Size = new System.Drawing.Size(25, 23);
            this.btnbookimage.TabIndex = 162;
            this.btnbookimage.Text = ".....";
            this.btnbookimage.UseVisualStyleBackColor = true;
            this.btnbookimage.Click += new System.EventHandler(this.btnbookimage_Click);
            // 
            // cmbbooktype
            // 
            this.cmbbooktype.FormattingEnabled = true;
            this.cmbbooktype.Items.AddRange(new object[] {
            "General",
            "CopurseMaterial"});
            this.cmbbooktype.Location = new System.Drawing.Point(207, 343);
            this.cmbbooktype.Name = "cmbbooktype";
            this.cmbbooktype.Size = new System.Drawing.Size(121, 21);
            this.cmbbooktype.TabIndex = 163;
            // 
            // cmbbooklevel
            // 
            this.cmbbooklevel.FormattingEnabled = true;
            this.cmbbooklevel.Items.AddRange(new object[] {
            "PresShool",
            "PrimarySchool",
            "HighSchool",
            "10+2",
            "Degree",
            "MCA",
            "MBA",
            "Engineering",
            "PG",
            "Competative",
            "General"});
            this.cmbbooklevel.Location = new System.Drawing.Point(207, 386);
            this.cmbbooklevel.Name = "cmbbooklevel";
            this.cmbbooklevel.Size = new System.Drawing.Size(121, 21);
            this.cmbbooklevel.TabIndex = 164;
            // 
            // cmbbookcategory
            // 
            this.cmbbookcategory.FormattingEnabled = true;
            this.cmbbookcategory.Items.AddRange(new object[] {
            "IT",
            "BioGraphy",
            "FantaSy",
            "Function",
            "Funny",
            "Horror",
            "History",
            "Mystery",
            "NonFunction",
            "Poetry",
            "ShortStories",
            "General"});
            this.cmbbookcategory.Location = new System.Drawing.Point(444, 193);
            this.cmbbookcategory.Name = "cmbbookcategory";
            this.cmbbookcategory.Size = new System.Drawing.Size(121, 21);
            this.cmbbookcategory.TabIndex = 165;
            // 
            // cmbpublishedyear
            // 
            this.cmbpublishedyear.FormattingEnabled = true;
            this.cmbpublishedyear.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013"});
            this.cmbpublishedyear.Location = new System.Drawing.Point(444, 269);
            this.cmbpublishedyear.Name = "cmbpublishedyear";
            this.cmbpublishedyear.Size = new System.Drawing.Size(121, 21);
            this.cmbpublishedyear.TabIndex = 166;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(640, 188);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(68, 23);
            this.btninsert.TabIndex = 167;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(640, 232);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(68, 23);
            this.btnfind.TabIndex = 168;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(640, 281);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(68, 23);
            this.btnupdate.TabIndex = 169;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(640, 325);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(68, 23);
            this.btnclear.TabIndex = 170;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(640, 379);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(68, 23);
            this.btnclose.TabIndex = 171;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picbookimage
            // 
            this.picbookimage.Location = new System.Drawing.Point(453, 389);
            this.picbookimage.Name = "picbookimage";
            this.picbookimage.Size = new System.Drawing.Size(100, 107);
            this.picbookimage.TabIndex = 160;
            this.picbookimage.TabStop = false;
            // 
            // bookmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 518);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.cmbpublishedyear);
            this.Controls.Add(this.cmbbookcategory);
            this.Controls.Add(this.cmbbooklevel);
            this.Controls.Add(this.cmbbooktype);
            this.Controls.Add(this.btnbookimage);
            this.Controls.Add(this.btnpublishercode);
            this.Controls.Add(this.picbookimage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtmrp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtcostprice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtauthornames);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.txtisbncode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpublishercode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bookmaster";
            this.Text = "bookmaster";
            this.Load += new System.EventHandler(this.bookmaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbookimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtmrp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcostprice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtauthornames;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.TextBox txtisbncode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picbookimage;
        private System.Windows.Forms.TextBox txtpublishercode;
        private System.Windows.Forms.Button btnpublishercode;
        private System.Windows.Forms.Button btnbookimage;
        private System.Windows.Forms.ComboBox cmbbooktype;
        private System.Windows.Forms.ComboBox cmbbooklevel;
        private System.Windows.Forms.ComboBox cmbbookcategory;
        private System.Windows.Forms.ComboBox cmbpublishedyear;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}