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
    public partial class publishermastermodify : Form
    {
        SqlConnection con=new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;
        SqlDataReader dr;
        string s;

        SqlDataAdapter da;
        DataSet ds;
        DataRow rec;
        SqlCommandBuilder scmbldr;
       
        public publishermastermodify()
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

        private void txtpublishername_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("Publishername accept letter only");
                e.Handled = true;
            }
        }

        private void txtcontactnum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
                MessageBox.Show("Publishernum1 accept numbers only");
            e.Handled = true;
  

        }

        private void txtcontactnum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
                MessageBox.Show("Publishernum2 accept numbers only");
            e.Handled = true;
  
        }

        private void txtwebsiteaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar) == false && e.KeyChar != '.')
                MessageBox.Show("websiteaddress accept lowercase letter and Dot values");
            e.Handled = true;

        }

        private void txtcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("Publishercity accept letter only");
                e.Handled = true;

            }
        }

        private void txtcountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("Publishercountry accept letters only");
                e.Handled = true;
            }

        }

        private void txtpincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("pincode accept digits only");
                e.Handled = true;
            }

        }

        private void txtisdcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("isdcode accept digits only");
                e.Handled = true;
            }

        }

        private void txtstdcode_KeyPress(object sender, KeyPressEventArgs e)
        {
        
         if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("stdcode accept digits only");
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
                MessageBox.Show("stdcode accept digits only");
                e.Handled = true;
            }

        }

        private void txtfaxnum2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("stdcode accept digits only");
                e.Handled = true;
            }

        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            string s="Select * from publishermaster where Publisher_Code='"+txtpublishercode.Text+"'";
            txtpublishercode.Visible = false;
            com=new SqlCommand(s,con);
            con.Open();
            dr=com.ExecuteReader();
            while(dr.Read())
            {
                //txtpublishercode.Text=dr[0].ToString();
               txtpublishername.Text=dr[1].ToString();
                txtaddress.Text=dr[2].ToString();
                txtcity.Text=dr[3].ToString();
                txtcountry.Text=dr[4].ToString();
                txtpincode.Text=dr[5].ToString();
                txtisdcode.Text=dr[6].ToString();
                txtstdcode.Text=dr[7].ToString();
                txtcontactnum1.Text=dr[8].ToString();
                txtcontactnum2.Text=dr[9].ToString();
                txtwebsiteaddress.Text=dr[10].ToString();
                txtmailid.Text=dr[11].ToString();
               txtfaxnum1.Text=dr[12].ToString();
                txtfaxnum2.Text=dr[13].ToString();

            }
            con.Close();
        
        }

        private void publishermastermodify_Load(object sender, EventArgs e)
        {
            s = "select * from publishermaster";
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            //da.FillSchema(ds, SchemaType.Source, "pm");
            da.Fill(ds, "pm");
            //publishermasterdgrv.DataSource = ds.Tables[0];

            publishermasterdgrv.DataSource = ds.Tables[0];
            scmbldr = new SqlCommandBuilder(da);

           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            /*string s1 = "update publishermaster set Publisher_Name=p1,Address=p2,City=p3,Country=p4,PinCode=p5,IsdCode=p6,StdCode=p7,ContactNum1=p8,ContactNum2=p9,Website_Address=p10,MailId=p11,FaxNum1=p12,FaxNum2=p13  where Publisher_Code=p0";
            com = new SqlCommand(s1, con);
           
            com.Parameters.AddWithValue("p1", txtpublishername.Text);
            com.Parameters.AddWithValue("p2", txtaddress.Text);
            com.Parameters.AddWithValue("p3", txtcity.Text);
            com.Parameters.AddWithValue("p4", txtcountry.Text);
            com.Parameters.AddWithValue("p5", txtpincode.Text);
            com.Parameters.AddWithValue("p6", txtisdcode.Text);
            com.Parameters.AddWithValue("p7", txtstdcode.Text);
            com.Parameters.AddWithValue("p8", txtcontactnum1.Text);
            com.Parameters.AddWithValue("p9", txtcontactnum2.Text);
            com.Parameters.AddWithValue("p10",txtwebsiteaddress. Text);
            com.Parameters.AddWithValue("p11", txtmailid.Text);
            com.Parameters.AddWithValue("p12", txtfaxnum1.Text);
            com.Parameters.AddWithValue("p13", txtfaxnum2.Text);
            com.Parameters.AddWithValue("p0", txtpublishercode.Text);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i+"successfully updated");*/
            rec = ds.Tables[0].Select("Publisher_Code='" + txtpublishercode.Text+"'")[0];
            //rec[0] = txtpublishercode.Text;
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
            rec[12] = txtfaxnum1.Text;
            rec[13] = txtfaxnum2.Text;
            //ds.Tables[0].Rows.Add(rec);
           


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            /* s = " delete publishermaster where Publisher_Code='" + txtpublishercode.Text + "'";
             com = new SqlCommand(s, con);
             con.Open();
             int i = com.ExecuteNonQuery();
             con.Close();
             MessageBox.Show(i + "rows(i) deleted");*/

            rec = ds.Tables[0].Select("Publisher_Code='" + txtpublishercode.Text + "'")[0];
            rec.Delete();
            MessageBox.Show("record deleted ");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (ds.HasChanges() == true)
            //{
                da.Update(ds, "pm");
                MessageBox.Show("record is inserted database permenently ");
           // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                    x.Text = "";


            }

        }

        private void btnsavepermenently_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        } 

       
    }


