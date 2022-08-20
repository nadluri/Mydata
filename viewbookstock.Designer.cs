namespace Bookshope
{
    partial class viewbookstock
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
            this.rbtncategory = new System.Windows.Forms.RadioButton();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.rbtnauthor = new System.Windows.Forms.RadioButton();
            this.rbtnbookname = new System.Windows.Forms.RadioButton();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.dgrvviewbooksstock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvviewbooksstock)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtncategory
            // 
            this.rbtncategory.AutoSize = true;
            this.rbtncategory.Location = new System.Drawing.Point(51, 49);
            this.rbtncategory.Name = "rbtncategory";
            this.rbtncategory.Size = new System.Drawing.Size(67, 17);
            this.rbtncategory.TabIndex = 0;
            this.rbtncategory.TabStop = true;
            this.rbtncategory.Text = "Category";
            this.rbtncategory.UseVisualStyleBackColor = true;
            this.rbtncategory.CheckedChanged += new System.EventHandler(this.rbtncategory_CheckedChanged);
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Items.AddRange(new object[] {
            "IT",
            "CSE",
            "Funny",
            "Function",
            "ECE",
            "Degreei",
            "EEE",
            "Maths",
            "Physics"});
            this.cmbcategory.Location = new System.Drawing.Point(142, 49);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(121, 21);
            this.cmbcategory.TabIndex = 1;
            this.cmbcategory.SelectedIndexChanged += new System.EventHandler(this.cmbcategory_SelectedIndexChanged);
            // 
            // rbtnauthor
            // 
            this.rbtnauthor.AutoSize = true;
            this.rbtnauthor.Location = new System.Drawing.Point(51, 104);
            this.rbtnauthor.Name = "rbtnauthor";
            this.rbtnauthor.Size = new System.Drawing.Size(56, 17);
            this.rbtnauthor.TabIndex = 2;
            this.rbtnauthor.TabStop = true;
            this.rbtnauthor.Text = "Author";
            this.rbtnauthor.UseVisualStyleBackColor = true;
            this.rbtnauthor.CheckedChanged += new System.EventHandler(this.rbtnauthor_CheckedChanged);
            // 
            // rbtnbookname
            // 
            this.rbtnbookname.AutoSize = true;
            this.rbtnbookname.Location = new System.Drawing.Point(51, 161);
            this.rbtnbookname.Name = "rbtnbookname";
            this.rbtnbookname.Size = new System.Drawing.Size(81, 17);
            this.rbtnbookname.TabIndex = 3;
            this.rbtnbookname.TabStop = true;
            this.rbtnbookname.Text = "Book Name";
            this.rbtnbookname.UseVisualStyleBackColor = true;
            this.rbtnbookname.CheckedChanged += new System.EventHandler(this.rbtnbookname_CheckedChanged);
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(142, 104);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(121, 20);
            this.txtauthor.TabIndex = 4;
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(142, 161);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(121, 20);
            this.txtbookname.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(161, 203);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // dgrvviewbooksstock
            // 
            this.dgrvviewbooksstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvviewbooksstock.Location = new System.Drawing.Point(86, 232);
            this.dgrvviewbooksstock.Name = "dgrvviewbooksstock";
            this.dgrvviewbooksstock.Size = new System.Drawing.Size(367, 150);
            this.dgrvviewbooksstock.TabIndex = 7;
            // 
            // viewbookstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 375);
            this.Controls.Add(this.dgrvviewbooksstock);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.rbtnbookname);
            this.Controls.Add(this.rbtnauthor);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.rbtncategory);
            this.Name = "viewbookstock";
            this.Text = "viewbookstock";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvviewbooksstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtncategory;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.RadioButton rbtnauthor;
        private System.Windows.Forms.RadioButton rbtnbookname;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DataGridView dgrvviewbooksstock;
    }
}