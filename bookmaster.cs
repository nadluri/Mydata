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
using System.IO;

namespace Bookshope
{
    public partial class bookmaster : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;
        SqlParameter p;
        string s,fname;
        FileStream fstream;

        SqlDataReader dr;
        byte[] Data;
        public bookmaster()
        {
            InitializeComponent();
        }

        private void txtbookid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtpublishercode.Text.Length == 0 && e.KeyChar != 'B'&& e.KeyChar !='\b')
            {
                MessageBox.Show("first letter must be B only");
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

        private void txtpublishercode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("Publishercode accept letter and digits only");
                e.Handled = true;
            }

        }

        private void txtisbncode_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (txtpublishercode.Text.Length == 0 && e.KeyChar != 'I')
            {
                MessageBox.Show("first letter must be I only");
                e.Handled = true;
                
            }

            
             
             if (txtpublishercode.Text.Length == 1&& e.KeyChar != 'S') 
                
            {
                MessageBox.Show("secondletter must be S only");
                e.Handled = true;
                
                
            }
               
                
             if (txtpublishercode.Text.Length == 2 && e.KeyChar != 'B')
            {
                MessageBox.Show("Third letter must be B only");
                e.Handled = true;
               
               
            }

             else if (txtpublishercode.Text.Length == 3 && e.KeyChar != 'N')
            {
                MessageBox.Show("Fourh letter must be N only");
                e.Handled = true;
                
               
            }





        }

        private void btnfind_Click(object sender, EventArgs e)
        {
           /* if (dr.Read())
            {
                Data = (byte[])dr[12];
                Stream sdata = new MemoryStream(Data);
                picbookimage.Image = Image.FromStream(sdata);
            }
            com = new SqlCommand("findrecordmaster", con);
            com.CommandType = CommandType.StoredProcedure;
            p = new SqlParameter("@Pbookid", SqlDbType.VarChar, 20);
            p.Value = txtpublishercode.Text;
            com.Parameters.Add(p);
            p = new SqlParameter("@ppublishercode", SqlDbType.VarChar, 20);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pisbncode", SqlDbType.VarChar, 20);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbookname", SqlDbType.VarChar, 20);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbooktype", SqlDbType.VarChar, 20);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbooklevel", SqlDbType.VarChar, 20);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbookcategory", SqlDbType.VarChar, 20);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pauthersnames", SqlDbType.VarChar, 20);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@ppublisheyear", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pcostprice", SqlDbType.Money);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pmrp", SqlDbType.Money);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbookimage", SqlDbType.Image, 20);
            p.Direction = ParameterDirection.Output;
            com.Parameters.Add(p);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            txtpublishercode.Text = com.Parameters["@ppublishercode"].Value.ToString();
            txtisbncode.Text = com.Parameters["@pisbncode"].Value.ToString();
            txtbookname.Text = com.Parameters["@pbookname"].Value.ToString();
            cmbbooktype.SelectedItem = com.Parameters["@pbooktype"].Value.ToString();
            cmbbooklevel.SelectedItem= com.Parameters["@pbooklevel"].Value.ToString();
            cmbbookcategory.SelectedItem = com.Parameters["@pbookcategory"].Value.ToString();
           txtauthornames. Text = com.Parameters["@pauthorsnames"].Value.ToString();
           cmbpublishedyear.SelectedItem = com.Parameters["@ppublishedyear"].Value.ToString();
           txtcostprice.Text = com.Parameters["@pcostprice"].Value.ToString();
           txtmrp.Text = com.Parameters["@pmrp"].Value.ToString();
           */
            string s = "select * from bookmaster where Book_Id= '" + txtbookid.Text+"'";
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                txtpublishercode.Text = dr[1].ToString();
                txtisbncode.Text = dr[2].ToString();
                txtbookname.Text = dr[3].ToString();
                cmbbooktype.SelectedItem = dr[4].ToString();
                cmbbooklevel.SelectedItem = dr[5].ToString();
                cmbbookcategory.SelectedItem = dr[6].ToString();
                txtbookname.Text = dr[7].ToString();
                cmbpublishedyear.SelectedItem = dr[8].ToString();
                txtcostprice.Text = dr[9].ToString();
                txtmrp.Text = dr[10].ToString();
                Data = (byte[])dr[11];
                Stream sdata = new MemoryStream(Data);
                picbookimage.Image = Image.FromStream(sdata);
           

                
            }
            con.Close();









        }

        private void txtbookname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsSymbol(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("letters and only special symbols accept");
                e.Handled = true;
            }
        }

        private void txtauthornames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
            {
                MessageBox.Show("letters and only special symbols accept");
                e.Handled = true;
            }
            
        }

        private void txtcostprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar!='.'&& e.KeyChar != '\b')
            {
                MessageBox.Show("digits and decimal points are accepted");
                e.Handled = true;
            }
           
        }

        private void txtmrp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                MessageBox.Show("digits and decimal points are accepted");
                e.Handled = true;
            }
           
        }

        private void btnpublishercode_Click(object sender, EventArgs e)
        {
            if (txtbookid.Text != "")
            {



                publisherdetails obj1 = new publisherdetails();
                obj1.ShowDialog();
                txtpublishercode.Text = (GlobalData.pubcode).ToString();


            }
            else
            {
                MessageBox.Show("enter textbookid");
            }
           }

        private void btnbookimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files|*.jpg|Allfiles|*.*";
            openFileDialog1.ShowDialog();
            fname=openFileDialog1.FileName;
            picbookimage.ImageLocation = fname;
        }
         
        private void btninsert_Click(object sender, EventArgs e)
        {

            fstream = new FileStream(fname,FileMode.Open,FileAccess.Read);
            Data=new byte[fstream.Length];
            fstream.Read(Data,0,Convert.ToInt32(fstream.Length));
            fstream.Close();
            com = new SqlCommand("insertbookmasterrec", con);
            com.CommandType = CommandType.StoredProcedure;
            p = new SqlParameter("@pbookid", SqlDbType.VarChar, 20);
            p.Value = txtbookid.Text;
            com.Parameters.Add(p);
            p = new SqlParameter("@ppublishercode", SqlDbType.VarChar, 20);
            p.Value = txtpublishercode. Text;
            com.Parameters.Add(p);
            p = new SqlParameter("@pisbncode", SqlDbType.VarChar, 20);
            p.Value = txtisbncode.Text;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbookname", SqlDbType.VarChar, 20);
            p.Value = txtbookname.Text;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbooktype", SqlDbType.VarChar, 20);
            p.Value = cmbbooktype.SelectedItem;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbooklevel", SqlDbType.VarChar, 20);
            p.Value = cmbbooklevel.SelectedItem;
            com.Parameters.Add(p);
            p = new SqlParameter("@pbookcategory", SqlDbType.VarChar, 20);
            p.Value = cmbbookcategory.SelectedItem;
            com.Parameters.Add(p);
            p = new SqlParameter("@pauthersnames", SqlDbType.VarChar, 20);
            p.Value =txtauthornames. Text;
            com.Parameters.Add(p);
            p = new SqlParameter("@ppublishedyear", SqlDbType.Int);
            p.Value = cmbpublishedyear.SelectedItem;
            com.Parameters.Add(p);
            p = new SqlParameter("@pcostprice", SqlDbType.Money);
            p.Value =Convert.ToDouble (txtcostprice.Text);
            com.Parameters.Add(p);
            p = new SqlParameter("@pmrp", SqlDbType.Money);
            p.Value = Convert.ToDouble(txtmrp.Text);
            com.Parameters.Add(p);
            p = new SqlParameter("@pbookimage", SqlDbType.Image);
            p.Value = Data;
           com.Parameters.Add(p);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "successfully exequated");
           
           
           
           

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           /* string s = "update bookmaster set Publisher_Code='" + txtpublishercode.Text + "',Isbn_Code='" + txtisbncode.Text + "',Book_Name='" + txtbookname.Text +
           "',Book_Type='" + cmbbooktype.SelectedItem + "',Book_Level='" + cmbbooklevel.SelectedItem + "',Book_Category='" + cmbbookcategory.SelectedItem + 
           "',Authors_Names='" + txtbookname.Text + "',Published_year=" + cmbpublishedyear.SelectedItem + ",Cost_Price=" + txtcostprice.Text + 
           ",MRP=" + txtmrp.Text + ",BookImage=" + picbookimage.Image + "where Book_Id='" + txtbookid.Text + "'";*/
             picbookimage.ImageLocation = fname;
        
            string s = "update bookmaster set Publisher_Code=@P1,Isbn_Code=p2,Book_Name=@p3,Book_Type=@p4,Book_Level=@p5,Book_Category=@p6,Authors_Names=@p7,Published_year=@p8,Cost_Price=@p9,MRP=@p10,BookImage=@p11 where Book_Id=@p2" ;
             fstream = new FileStream(fname,FileMode.Open,FileAccess.Read);
            Data=new byte[fstream.Length];
            fstream.Read(Data,0,Convert.ToInt32(fstream.Length));
            fstream.Close();
           
            com = new SqlCommand(s, con);
            com.Parameters.AddWithValue("@p1",txtpublishercode.Text );
            com.Parameters.AddWithValue("@p2",txtisbncode.Text);
            com.Parameters.AddWithValue("@p3",txtbookname.Text );
            com.Parameters.AddWithValue("@p4",cmbbooktype.SelectedItem );
            com.Parameters.AddWithValue("@p5",cmbbooklevel.SelectedItem );
            com.Parameters.AddWithValue("@p6",cmbbookcategory.SelectedItem);
            com.Parameters.AddWithValue("@p7",txtbookname.Text );
            com.Parameters.AddWithValue("@p8", cmbpublishedyear.SelectedItem);
            com.Parameters.AddWithValue("@p9", txtcostprice.Text);
            com.Parameters.AddWithValue("@p10",txtmrp.Text);
            com.Parameters.AddWithValue("@p11",Data);
           
            //com.Parameters.AddWithValue("@p11",picbookimage.Image);


          
            com.Parameters.AddWithValue("@p12",txtbookid.Text);
           
            con.Open();
            int i = com.ExecuteNonQuery();
     

             
            con.Close();
            MessageBox.Show("successfully updated");
        }

        private void bookmaster_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
