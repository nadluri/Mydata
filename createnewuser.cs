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
    public partial class createnewuser : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;
        
        public createnewuser()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string s = "insert into createnewuser values('" + txtusername.Text + "','" + txtpassword.Text + "','" + cmbquestion.SelectedItem + "','" + txtanswer.Text + "')";
            com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("rows inserted");

            

        }
    }
}
