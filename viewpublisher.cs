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
    public partial class viewpublisher : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123; database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand com;
        SqlDataReader dr;
        string s;
        public viewpublisher()
        {
            InitializeComponent();
        }

      

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (rbtnpublishername.Checked == true)
            {
                s = "select publishername,bookcategory,address,city,country,PinCode from publishermaster p ,bookmaster b where p.publishercode=b.publishercode and publishername='" + txpublishername.Text + "'";
                da = new SqlDataAdapter(s, con);
                ds = new DataSet();
                da.Fill(ds, "pm");
                viewpublisherdgrv.DataSource = ds.Tables[0];
            }
            if (rbtncategory.Checked == true)
            {

                s = "select publishername,bookcategory,address,city,country,pinCode from publishermaster p ,bookmaster b where p.publishercode=b.publishercode and bookcategory='" + cmbcategory.SelectedItem+ "'";
                da = new SqlDataAdapter(s, con);
                ds = new DataSet();
                da.Fill(ds, "pm");
                viewpublisherdgrv.DataSource = ds.Tables[0];
    

            }

        }

        private void rbtncategory_CheckedChanged(object sender, EventArgs e)
        {

            cmbcategory.Visible = true;
            txpublishername.Visible = false;
        }

        private void rbtnpublishername_CheckedChanged(object sender, EventArgs e)
        {
            txpublishername.Visible = true;
            cmbcategory.Visible = false;
        }

        private void viewpublisher_Load(object sender, EventArgs e)
        {
            string s = "select bookcategory from bookmaster";
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbcategory.Items.Add(dr[0]);
            }
            con.Close();
        }
    }
}
