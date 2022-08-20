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
    public partial class billmaster : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;
        SqlDataReader dr;
        
        public billmaster()
        {
            InitializeComponent();
        }

        private void txtamountpaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false&&e.KeyChar !='.' &&e.KeyChar !='\b')
            {
                MessageBox.Show("accept only digits and decimals values");
                e.Handled = true;
            }
        }

        private void txtcustomername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("accept only letters only");
                e.Handled = true;
            
            }

        }

        private void txtcustomercontactnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("accept only digits only");
                e.Handled = true;
            
            }
        }

        private void txtcustomermailid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false && e.KeyChar != '.' && e.KeyChar != '@' && e.KeyChar != '\b')
            {
                MessageBox.Show("accept only digits,characters,.,@ symbols only");
                e.Handled = true;
            
            }
        }

        private void btnnewbill_Click(object sender, EventArgs e)
        {
            bookpurchase obj1 = new bookpurchase();
            obj1.ShowDialog();
            txtbillnumber.Text = GlobalData.Bill_Num;
            txtbilldate.Text = DateTime.Now.ToString();
            txtbilltotalmrp.Text = GlobalData.Mrp;
            txtbilldiscountamount.Text = GlobalData.Discount_Amount;
            txtbilltotalamount.Text = GlobalData.Total_Amount;
           }

        private void billmaster_Load(object sender, EventArgs e)
        {

            
            txtbillnumber.Enabled = false;
            txtbilldate.Enabled = false;
            txtbilltotalmrp.Enabled = false;
            txtbilldiscountamount.Enabled = false;
            txtbilltotalamount.Enabled = false;
        }

        private void cmbinstallments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbinstallments.SelectedIndex == 0)
            {
                billinstallment obj1 = new billinstallment();
                obj1.Show();
                GlobalData.Bill_Num = txtbillnumber.Text;
                GlobalData.Total_Amount = txtbilltotalamount.Text;

            }
               
            

            

        }

        private void cmbpaymentmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpaymentmode.SelectedIndex == 0)
            {
                paycheque obj1 = new paycheque();
                obj1.ShowDialog();
                GlobalData.Bill_Num = txtbillnumber.Text;
            }
            if (cmbpaymentmode.SelectedIndex == 1)
            {
                paycardform obj1 = new paycardform();
                obj1.ShowDialog();
                GlobalData.Bill_Num = txtbillnumber.Text;
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string s = "insert into billmaster values(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)";
            com = new SqlCommand(s, con);
            com.Parameters.AddWithValue("@p0", txtcustomername.Text);
            com.Parameters.AddWithValue("@p1", txtbillnumber.Text);
            com.Parameters.AddWithValue("@p2", txtbilldate.Text);
            com.Parameters.AddWithValue("@p3", txtcustomername.Text);
            com.Parameters.AddWithValue("@p4", txtcustomeraddress.Text);
            com.Parameters.AddWithValue("@p5", txtcustomercontactnum.Text);
            com.Parameters.AddWithValue("@p6", txtcustomermailid.Text);
            com.Parameters.AddWithValue("@p7", txtbilltotalmrp.Text);
            com.Parameters.AddWithValue("@p8", txtbilldiscountamount.Text);
            com.Parameters.AddWithValue("@p9", txtbilltotalamount.Text);
            com.Parameters.AddWithValue("@p10", cmbinstallments.SelectedItem);
            com.Parameters.AddWithValue("@p11", cmbpaymentmode.SelectedItem);
            com.Parameters.AddWithValue("@p12", txtamountpaid.Text);
            com.Parameters.AddWithValue("@p13", cmbbillstatus.SelectedItem);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("bill saved");


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox && x is ComboBox)
                {
                    x.Text = "";
                }
            }
        }

        private void cmbbillstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbillstatus.SelectedIndex == 1)
            {
                pending_bill_details obj1 = new pending_bill_details();
                obj1.ShowDialog();
                GlobalData.cmbbillstatus = (cmbbillstatus.SelectedIndex = 1).ToString();
            }
        }

        private void txtbillnumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
