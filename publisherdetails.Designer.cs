namespace Bookshope
{
    partial class publisherdetails
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
            this.publisherdetailsdgrv = new System.Windows.Forms.DataGridView();
            this.btnok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.publisherdetailsdgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher Details";
            // 
            // publisherdetailsdgrv
            // 
            this.publisherdetailsdgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherdetailsdgrv.Location = new System.Drawing.Point(113, 58);
            this.publisherdetailsdgrv.Name = "publisherdetailsdgrv";
            this.publisherdetailsdgrv.Size = new System.Drawing.Size(297, 150);
            this.publisherdetailsdgrv.TabIndex = 1;
            this.publisherdetailsdgrv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.publisherdetailsdgrv_RowHeaderMouseClick);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(207, 226);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // publisherdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 261);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.publisherdetailsdgrv);
            this.Controls.Add(this.label1);
            this.Name = "publisherdetails";
            this.Text = "publisherdetails";
            this.Load += new System.EventHandler(this.publisherdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publisherdetailsdgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView publisherdetailsdgrv;
        private System.Windows.Forms.Button btnok;
    }
}