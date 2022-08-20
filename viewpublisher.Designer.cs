namespace Bookshope
{
    partial class viewpublisher
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
            this.rbtnpublishername = new System.Windows.Forms.RadioButton();
            this.txpublishername = new System.Windows.Forms.TextBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.rbtncategory = new System.Windows.Forms.RadioButton();
            this.viewpublisherdgrv = new System.Windows.Forms.DataGridView();
            this.btnsubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewpublisherdgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnpublishername
            // 
            this.rbtnpublishername.AutoSize = true;
            this.rbtnpublishername.Location = new System.Drawing.Point(162, 56);
            this.rbtnpublishername.Name = "rbtnpublishername";
            this.rbtnpublishername.Size = new System.Drawing.Size(96, 17);
            this.rbtnpublishername.TabIndex = 0;
            this.rbtnpublishername.TabStop = true;
            this.rbtnpublishername.Text = "PublisherName";
            this.rbtnpublishername.UseVisualStyleBackColor = true;
            this.rbtnpublishername.CheckedChanged += new System.EventHandler(this.rbtnpublishername_CheckedChanged);
            // 
            // txpublishername
            // 
            this.txpublishername.Location = new System.Drawing.Point(264, 56);
            this.txpublishername.Name = "txpublishername";
            this.txpublishername.Size = new System.Drawing.Size(100, 20);
            this.txpublishername.TabIndex = 1;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(255, 99);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(121, 21);
            this.cmbcategory.TabIndex = 2;
            // 
            // rbtncategory
            // 
            this.rbtncategory.AutoSize = true;
            this.rbtncategory.Location = new System.Drawing.Point(162, 103);
            this.rbtncategory.Name = "rbtncategory";
            this.rbtncategory.Size = new System.Drawing.Size(67, 17);
            this.rbtncategory.TabIndex = 3;
            this.rbtncategory.TabStop = true;
            this.rbtncategory.Text = "Category";
            this.rbtncategory.UseVisualStyleBackColor = true;
            this.rbtncategory.CheckedChanged += new System.EventHandler(this.rbtncategory_CheckedChanged);
            // 
            // viewpublisherdgrv
            // 
            this.viewpublisherdgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewpublisherdgrv.Location = new System.Drawing.Point(188, 161);
            this.viewpublisherdgrv.Name = "viewpublisherdgrv";
            this.viewpublisherdgrv.Size = new System.Drawing.Size(240, 150);
            this.viewpublisherdgrv.TabIndex = 4;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(255, 132);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // viewpublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 323);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.viewpublisherdgrv);
            this.Controls.Add(this.rbtncategory);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.txpublishername);
            this.Controls.Add(this.rbtnpublishername);
            this.Name = "viewpublisher";
            this.Text = "viewpublisher";
            this.Load += new System.EventHandler(this.viewpublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewpublisherdgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnpublishername;
        private System.Windows.Forms.TextBox txpublishername;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.RadioButton rbtncategory;
        private System.Windows.Forms.DataGridView viewpublisherdgrv;
        private System.Windows.Forms.Button btnsubmit;
    }
}