using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bookshope
{
    public partial class BookInventory : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");

        SqlCommand com;
        SqlDataReader dr;
        public BookInventory()
        {
            InitializeComponent();
        }

        private void btnbookid_Click(object sender, EventArgs e)
        {
            seletbookid obj1 = new seletbookid();
            obj1.ShowDialog();
            txtbookid.Text = (GlobalData.txtbookid).ToString();
            txquntitybefore.Text = (GlobalData.txtbeforestock).ToString();
        }

        private void txtbookid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtquntityrecevied_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter digits only");
                e.Handled = true;
            }
        }

        private void txtquntityrecevied_TextChanged(object sender, EventArgs e)
        {
            txtquntityafter.Text = (Convert.ToInt32(txquntitybefore.Text) + Convert.ToInt32(txtquntityrecevied.Text)).ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "Add")
            {
                txtbookid.Enabled = true;
                dateTimePicker1.Enabled = true;
                txquntitybefore.Enabled = true;
                txtquntityrecevied.Enabled = true;
                txtquntityafter.Enabled = true;
                txtordernumber.Enabled = true;
                btnbookid.Enabled = true;
                btnadd.Text = "save";
            }
            else if(btnadd.Text=="save")
            {
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)

                        if (x.Text.Length != 0)
                        {

                            string s = "insert into booksinventory values(@p1,@p2,@p3,@p4,@p5,@p6)";
                            com = new SqlCommand(s, con);
                            com.Parameters.AddWithValue("@p1", txtbookid.Text);
                            com.Parameters.AddWithValue("@p2", dateTimePicker1.MaxDate);
                            com.Parameters.AddWithValue("@p3", txquntitybefore.Text);
                            com.Parameters.AddWithValue("@p4", txtquntityrecevied.Text);
                            com.Parameters.AddWithValue("@p5", txtquntityafter.Text);
                            com.Parameters.AddWithValue("@p6", txtordernumber.Text);
                            con.Open();
                            int i = com.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("successfully rows(i) inserted" + i);
                            btnadd.Text = "Add";
                            txtbookid.Enabled = false;
                            dateTimePicker1.Enabled = false;
                            txquntitybefore.Enabled = false;
                            txtquntityrecevied.Enabled = false;
                            txtquntityafter.Enabled = false;
                            txtordernumber.Visible = false;
                            btnbookid.Enabled = false;
                            foreach (Control y in this.Controls)
                            {
                                if (y is TextBox)
                                    y.Text = "";
                            }

                            return;
                        }
                }
        
                


               

            }







            /* if (btnadd.Text == "Add")
             {
                 txtbookid.Visible = false;
                 dateTimePicker1.Visible = false;
                 txquntitybefore.Visible = false;
                 txtquntityrecevied.Visible = false;
                 txtquntityafter.Visible = false;
                 txtordernumber.Visible = false;
                 btnbookid.Visible = false;
                 //btnadd.Text = "Add";
             }*/

        }








        private void BookInventory_Load(object sender, EventArgs e)
        {
            txtbookid.Enabled = false;
            dateTimePicker1.Enabled = false;
            txquntitybefore.Enabled = false;
            txtquntityrecevied.Enabled = false;
            txtquntityafter.Enabled = false;
            txtordernumber.Enabled = false;
            btnbookid.Enabled = false;
            //btnadd.Text = "save";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                    x.Text = "";
            }


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
