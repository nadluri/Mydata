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
    public partial class paycardform : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        public paycardform()
        {
            InitializeComponent();
        }

        private void paycardform_Load(object sender, EventArgs e)
        {
            txtbillnumber.Text = GlobalData.Bill_Num;
            string s = "select * from  paycard";
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source, "pc");
            dgrvpaycardform.DataSource = ds.Tables[0];

        }

        private void txtcardnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("it accepts digits only");
                e.Handled = true;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar!='.'&&e.KeyChar != '\b')
            {
                MessageBox.Show("it accepts digits and decimal points only");
                e.Handled = true;
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DataRow rec = ds.Tables[0].NewRow();
            rec[0] = txtbillnumber.Text;
            rec[1] = txtcardnumber.Text;
            rec[2] = cmbcrdtype.SelectedItem;
            rec[3] = cmdbank.SelectedItem;
            rec[4] = txtamount.Text;
            ds.Tables[0].Rows.Add(rec);
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
