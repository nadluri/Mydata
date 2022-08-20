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
    public partial class viewbookstock : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;Database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        public viewbookstock()
        {
            InitializeComponent();
        }

        private void rbtncategory_CheckedChanged(object sender, EventArgs e)
        {
            
                cmbcategory.Visible = true;
            txtauthor.Visible = false;
            txtbookname.Visible = false;
            


        }

        private void rbtnauthor_CheckedChanged(object sender, EventArgs e)
        {
            
                cmbcategory.Visible = false;
            txtauthor.Visible = true;
            txtbookname.Visible = false;
           
        }

        private void rbtnbookname_CheckedChanged(object sender, EventArgs e)
        {
            
                cmbcategory.Visible = false;
            txtauthor.Visible = false;
            txtbookname.Visible = true;
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if(rbtncategory.Checked == true)
            {
            string s = "select b. Book_Name,b.Authors_Names,p.Publisher_Name,b.Book_Category,s.Quntity_Available from bookmaster b,Publishermaster p,BookStock s where b.Publisher_Code=P.Publisher_Code and b.Book_Id=s.Book_Id and Book_Category='" + cmbcategory.SelectedItem + "'";
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            da.Fill(ds, "bm");
            dgrvviewbooksstock.DataSource = ds.Tables[0];
            }
            if (rbtnauthor.Checked == true)
            {
                string s = "select b. Book_Name,b.Authors_Names,p.Publisher_Name,b.Book_Category,s.Quntity_Available from bookmaster b,Publishermaster p,BookStock s where b.Publisher_Code=P.Publisher_Code and b.Book_Id=s.Book_Id and Authors_Names='" +txtauthor.Text + "'";
                da = new SqlDataAdapter(s, con);
                ds = new DataSet();
                da.Fill(ds, "bm");
                dgrvviewbooksstock.DataSource = ds.Tables[0];
            }
            if (rbtnbookname.Checked == true)
            {
                string s = "select b. Book_Name,b.Authors_Names,p.Publisher_Name,b.Book_Category,s.Quntity_Available from bookmaster b,Publishermaster p,BookStock s where b.Publisher_Code=P.Publisher_Code and b.Book_Id=s.Book_Id and Book_Name='" + txtbookname. Text + "'";
                da = new SqlDataAdapter(s, con);
                ds = new DataSet();
                da.Fill(ds, "bm");
                dgrvviewbooksstock.DataSource = ds.Tables[0];
            
            }
           
        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
