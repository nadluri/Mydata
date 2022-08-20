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
//using System.Configuration;
namespace Bookshope
{
    public partial class PublisherMaster : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scmbldr;
        public PublisherMaster()
        {
            InitializeComponent();
        }

        private void txtpublishercode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtpublishercode.Text.Length == 0 && e.KeyChar != 'P')
            {
                MessageBox.Show("first letter must be P only");
                e.Handled = true;
            }
            else
            {
                if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
                {
                    MessageBox.Show("Publishercode accept letter and digits only");
                    e.Handled = true;
                }


            }             
          
               
                    

            
        }

       private void txtpublishercode_Leave(object sender, EventArgs e)
        {
            if (txtpublishercode.Text.Length == 0)
                MessageBox.Show("must be enter publishercode");
            
        }
        
        private void txtpublishername_Leave(object sender, EventArgs e)
        {
            if (txtpublishercode.Text.Length == 0)
                MessageBox.Show("must be enter publishername");
   
        }

        private void txtpublishername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter characters only");
                e.Handled = true;
            }
        }

        private void txtcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter characters only");
                e.Handled = true;
            }
        }

        private void txtcountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter characters only");
                e.Handled = true;
            }
        }

        private void txtpincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter Digits only");
                e.Handled = true;
            }
        }

        private void txtisdcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter digits only");
                e.Handled = true;
            }
        }

        private void txtstdcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter digits only");
                e.Handled = true;
            }
        }

        private void txtcontactnum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter digits only");
                e.Handled = true;
            }


        }

        private void txtcontactnum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter digits only");
                e.Handled = true;
            }

        }

        private void txtwebsiteaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar) == false && e.KeyChar != '.')
            {
                MessageBox.Show("websiteaddress accept lowercase letter and Dot values");
                e.Handled = true;
            }
        }

        private void txtmailid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false && e.KeyChar != '@' && e.KeyChar != '.'&& e.KeyChar !='\b')
            {
                MessageBox.Show("mailid accept letters,digits,@ and Dot values only");

                e.Handled = true;
            }

        }

        private void txtfaxnum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter digits only");
                e.Handled = true;
            }
        }

        private void txtfaxnum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("enter digits only");
                e.Handled = true;
            }
        }

        private void PublisherMaster_Load(object sender, EventArgs e)
        {
            string s = "select * from publishermaster";
           da = new SqlDataAdapter(s, con);
              ds = new DataSet();
            da.FillSchema( ds, SchemaType.Source, "pm");
            //da.Fill(ds, "pm");
            //publishermasterdgrv.DataSource = ds.Tables[0];

            publishermasterdgrv.DataSource =ds.Tables[0];
            scmbldr = new SqlCommandBuilder( da);
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            DataRow rec =ds.Tables[0].NewRow();
            rec[0] = txtpublishercode.Text;
            rec[1] = txtpublishername.Text;
            rec[2] = txtaddress.Text;
            rec[3] = txtcity.Text;
            rec[4] = txtcountry.Text;
            rec[5] = txtpincode.Text;
            rec[6] = txtisdcode.Text;
            rec[7] = txtstdcode.Text;
            rec[8] = txtcontactnum1.Text;
            rec[9] = txtcontactnum2.Text;
            rec[10] = txtwebsiteaddress.Text;
            rec[11] = txtmailid.Text;
            rec[12]=txtfaxnum1.Text;
            rec[13]=txtfaxnum2.Text;
          ds.Tables[0].Rows.Add(rec);
            MessageBox.Show("values are inserted dataset");
            
        }

        private void btnsavepermenently_Click(object sender, EventArgs e)
        {
            if ( ds.HasChanges() == true)
            {
               da.Update( ds, "pm");
                MessageBox.Show("values are inserted database permenently");

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                    x.Text = "";

                    
            }

        }

       
    }
}
