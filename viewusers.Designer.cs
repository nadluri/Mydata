﻿namespace Bookshope
{
    partial class viewusers
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
            this.dgrvviewusers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvviewusers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvviewusers
            // 
            this.dgrvviewusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvviewusers.Location = new System.Drawing.Point(0, 0);
            this.dgrvviewusers.Name = "dgrvviewusers";
            this.dgrvviewusers.Size = new System.Drawing.Size(240, 150);
            this.dgrvviewusers.TabIndex = 0;
            // 
            // viewusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgrvviewusers);
            this.Name = "viewusers";
            this.Text = "viewusers";
            this.Load += new System.EventHandler(this.viewusers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvviewusers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvviewusers;
    }
}