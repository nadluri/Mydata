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
    public partial class paycheque : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        public paycheque()
        {
            InitializeComponent();
        }

        private void paycheque_Load(object sender, EventArgs e)
        {
            
            txtbillnumber.Text = GlobalData.Bill_Num;
            string s="select * from paycheque";
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            da.FillSchema(ds,SchemaType.Source, "pc");
            dataGridView1.DataSource = ds.Tables[0];
          



        }

        private void txtchequenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("It should accepts digits only");
                e.Handled = true;
            }
        }

        private void txtbranch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("It should accepts characters only");
                e.Handled = true;
            
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar!='.' && e.KeyChar != '\b')
            {
                MessageBox.Show("It should accepts digits and decimal points only");
                e.Handled = true;
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DataRow rec = ds.Tables[0].NewRow();
            rec[0] = txtbillnumber.Text;
            rec[1] = txtchequenumber.Text;
            rec[2] = cmbbankname.SelectedItem;
            rec[3] = txtbranch.Text;
            rec[4] = txtamount.Text;
            rec[5] = dateTimePicker1.Value;
            rec[6] = cmbchequestatus.SelectedItem;
            ds.Tables[0].Rows.Add(rec);


        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
