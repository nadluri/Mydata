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
    public partial class billinstallment : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        SqlDataReader dr;
        DataRow rec;
        public billinstallment()
        {
            InitializeComponent();
        }

        private void txtamountpaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("accepts only digits");
                e.Handled = true;
            }
        }

        private void cmbpaymentmode_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void billinstallment_Load(object sender, EventArgs e)
        {
            Txtbillnumber.Text = GlobalData.Bill_Num;
            string s1 = "select * from Installments";
            da = new SqlDataAdapter(s1, con);
            ds = new DataSet();
            da.FillSchema(ds,SchemaType.Source, "im");
            dgrvbillinstallment.DataSource = ds.Tables[0];
            Txtbillnumber.Text = GlobalData.Bill_Num;
            txtamountbefore.Text = GlobalData.Total_Amount;
            txtpaydate.Text = DateTime.Now.ToShortDateString();

            string s = "select count(*) from Installments where Bill_Number='" + GlobalData.Bill_Num+"'" ;

            cmd = new SqlCommand(s, con);
            con.Open();
            int i =Convert.ToInt32( cmd.ExecuteScalar());
            con.Close();
            if (i == 0)
                txtinstallmentnumber.Text = (i + 1).ToString();
           else
                txtinstallmentnumber.Text = (i + 1).ToString();
        }

        private void txtamountpaid_TextChanged(object sender, EventArgs e)
       {
            txtbalanceamount.Text = (Convert.ToInt32(txtamountbefore.Text) - Convert.ToInt32(txtamountpaid.Text)).ToString();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            rec = ds.Tables[0].NewRow();
            rec[0] = Txtbillnumber.Text;
            rec[1] = txtinstallmentnumber.Text;
            rec[2] = cmbpaymentmode.SelectedItem;
            rec[3] = txtpaydate.Text;
            rec[4] = txtamountbefore.Text;
            rec[5] = txtamountpaid.Text;
            rec[6] = txtbalanceamount.Text;
            ds.Tables[0].Rows.Add(rec);

            
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtbillnumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
