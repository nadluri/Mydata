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
    public partial class bookpurchase : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand com;
        SqlDataReader dr;
        string s;
        public bookpurchase()
        {
            InitializeComponent();
        }

        private void billmaster_Load(object sender, EventArgs e)
        {
            
            txtbookname.Enabled = false;
            txtmrp.Enabled = false;
             s = "select * from Transaction1";
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            da.FillSchema(ds, SchemaType.Source, "tr");
            //da.Fill(ds, "tr");
            dgrvbillmaster.DataSource = ds.Tables[0];

         
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbbookid.Items.Add(dr[1]);
            }
            con.Close();
            


        }

        private void cmbbookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbookname.Enabled = true;
            txtmrp.Enabled = true;
            string s = "select Book_name,MRP from Transaction1 where Book_Id='"+cmbbookid.SelectedItem+"'";
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtbookname.Text = dr[0].ToString();
                txtmrp.Text = dr[1].ToString();
            }
            GlobalData.BooK_Id = cmbbookid.SelectedItem.ToString();
            con.Close();
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (txtquantity.Text != "")
            {
                txtprice.Text = (Convert.ToDouble(txtmrp.Text) * Convert.ToInt32(txtquantity.Text)).ToString();
            }
        }

        private void txtdiscountprice_TextChanged(object sender, EventArgs e)
        {
            if (txtdiscountprice.Text != "")
            {
                txtdiscountamount.Text = (Convert.ToDouble(txtprice.Text) * Convert.ToDouble(txtdiscountprice.Text) / 100).ToString();
            }
        }

        private void txtdiscountamount_TextChanged(object sender, EventArgs e)
        {
            
                txtsaleamount.Text = (Convert.ToDouble(txtprice.Text) - Convert.ToDouble(txtdiscountamount.Text)).ToString();
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string s = "select Bill_Num from autogeneratebillnum ";
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                int a =Convert.ToInt32( dr[0]);
                string b="EMSC"+a;
                GlobalData.Bill_Num=b;
            }
            con.Close();
        
            DataRow rec = ds.Tables[0].NewRow();
            rec[0] = GlobalData.Bill_Num;
            rec[1] = cmbbookid.SelectedItem;
            rec[2] = txtbookname.Text;
            rec[3] = txtmrp.Text;
            rec[4] = txtquantity.Text;
            rec[5] = txtprice.Text;
            rec[6] = txtdiscountprice.Text;
            rec[7] = txtdiscountamount.Text;
            rec[8] = txtsaleamount.Text;
           ds.Tables[0].Rows.Add(rec);
           GlobalData.Mrp = txtmrp.Text;
           GlobalData.Discount_Amount = txtdiscountamount.Text;
           GlobalData.Total_Amount = txtsaleamount.Text;
     

          /* foreach (Control x in this.Controls)
            {
                if ( x is TextBox)
                {
                    x.Text = "";
                }
            }*/
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
