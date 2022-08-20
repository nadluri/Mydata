namespace Bookshope
{
    partial class checkbookstock
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
            this.dgrvcheckbookstock = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtavailability = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvcheckbookstock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Books Stock";
            // 
            // dgrvcheckbookstock
            // 
            this.dgrvcheckbookstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvcheckbookstock.Location = new System.Drawing.Point(143, 112);
            this.dgrvcheckbookstock.Name = "dgrvcheckbookstock";
            this.dgrvcheckbookstock.Size = new System.Drawing.Size(240, 150);
            this.dgrvcheckbookstock.TabIndex = 1;
            this.dgrvcheckbookstock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvcheckbookstock_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Availabile Stock";
            // 
            // txtavailability
            // 
            this.txtavailability.AccessibleName = "txtavailabilitystock";
            this.txtavailability.Location = new System.Drawing.Point(423, 133);
            this.txtavailability.Name = "txtavailability";
            this.txtavailability.Size = new System.Drawing.Size(100, 20);
            this.txtavailability.TabIndex = 3;
            // 
            // btnclose
            // 
            this.btnclose.AccessibleName = "btnclose";
            this.btnclose.Location = new System.Drawing.Point(434, 187);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbookstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 378);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtavailability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrvcheckbookstock);
            this.Controls.Add(this.label1);
            this.Name = "checkbookstock";
            this.Text = "checkbookstock";
            this.Load += new System.EventHandler(this.checkbookstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvcheckbookstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrvcheckbookstock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtavailability;
        private System.Windows.Forms.Button btnclose;
    }
}