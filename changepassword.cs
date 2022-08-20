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
    public partial class changepassword : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;
        public changepassword()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtnewpassword.Text == txtconfirmpassword.Text)
            {
                string s = "update createnewuser set password='" + txtnewpassword.Text + "' where username='" + txtusername.Text + "' and password='" + txtoldpassword.Text + "'";
                com = new SqlCommand(s, con);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("success fully oldpassword to newpassword changed ");
            }
            else
                MessageBox.Show("newpassword and confirmpassword not match ");

        }
    }
}
