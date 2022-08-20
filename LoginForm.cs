using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Bookshope
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string s = "select count(*) from createnewuser where UserName='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'";
            com = new SqlCommand(s, con);
            con.Open();
            int i = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            if (i == 0)
                MessageBox.Show("UserName And Password is invalid");
            else
            {
                MDIFORMMENUS obj1 = new MDIFORMMENUS();
                obj1.ShowDialog();
            }

        }

        private void linklabelfp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changepassword obj1 = new changepassword();
            obj1.ShowDialog();
        }
    }
}
