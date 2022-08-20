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
    public partial class pending_bill_details : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        public pending_bill_details()
        {
            InitializeComponent();
        }

        private void pending_bill_details_Load(object sender, EventArgs e)
        {
            string s = "select Bill_Number,Bill_Date,Customer_Name,Customer_address,Customer_Contactnum,Customer_mailid,Bill_Totalmrp,Bill_DiscountAmount,Bill_TotalAmount,Bill_Installment,Payment_mode,Amount_Paid,Bill_Status from billmaster where Bill_Status='pending'";
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            da.Fill(ds, "bm");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string s = "select * from installments where Bill_Number='" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'"; ;
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            da.Fill(ds, "im");
            dataGridView2.DataSource = ds.Tables[0];

        }
    }
}
 