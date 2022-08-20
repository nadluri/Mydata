namespace Bookshope
{
    partial class setpermission
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
            this.cmbusername = new System.Windows.Forms.ComboBox();
            this.chksetpermissions = new System.Windows.Forms.CheckedListBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter User Name";
            // 
            // cmbusername
            // 
            this.cmbusername.FormattingEnabled = true;
            this.cmbusername.Location = new System.Drawing.Point(137, 34);
            this.cmbusername.Name = "cmbusername";
            this.cmbusername.Size = new System.Drawing.Size(121, 21);
            this.cmbusername.TabIndex = 2;
            // 
            // chksetpermissions
            // 
            this.chksetpermissions.FormattingEnabled = true;
            this.chksetpermissions.Location = new System.Drawing.Point(121, 61);
            this.chksetpermissions.Name = "chksetpermissions";
            this.chksetpermissions.Size = new System.Drawing.Size(120, 94);
            this.chksetpermissions.TabIndex = 3;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(110, 197);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 4;
            this.btnsubmit.Text = "SUbmit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // setpermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.chksetpermissions);
            this.Controls.Add(this.cmbusername);
            this.Controls.Add(this.label1);
            this.Name = "setpermission";
            this.Text = "setpermission";
            this.Load += new System.EventHandler(this.setpermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbusername;
        private System.Windows.Forms.CheckedListBox chksetpermissions;
        private System.Windows.Forms.Button btnsubmit;

    }
}