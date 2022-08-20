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
using System.Configuration;
namespace Bookshope
{
    public partial class setpermission : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;
        SqlDataReader dr;
        
          bool[] Rec;
        string s;
        string allowchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz@#$/<>";
        char[] newpassword = new char[8]; 
        
        Random rd = new Random();
        
   
      
    
        public setpermission()
        {
            InitializeComponent();
        }

        private void setpermission_Load(object sender, EventArgs e)
        {
           s = "select UserName from CreateNewUser";
             com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbusername.Items.Add(dr[0].ToString());
            }
            con.Close();
            s = "select Column_Name from information_schema.columns where table_name='setpermissions'";
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                chksetpermissions.Items.Add(dr[0]);
            }
            con.Close();
           

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Rec = new bool[chksetpermissions.Items.Count];
            for (int i = 0; i <chksetpermissions .Items.Count; i++)
            {
                if (chksetpermissions.GetItemCheckState(i) == 0)
                {
                    Rec[i] = false;
                }
                else
                {
                    Rec[i] = true;
                }
                s = "Update setpermissions Set Book_Master=@p1,Book_Viewstock=@p2,Book_Inventory=@p3,Publisher_AddNew=@p6,Publisher_Modify=@p7,Publisher_View=@p8,Bill_NewBill=@p9,Bill_ViewPendingBills=@p10,Users_NewUser=@p11,User_SetPermissions=@p12,User_View=@p13,User_ChangePassword=@p14,Setup_BackupData=@p15,Setup_ShopDetails=@p16,Reports_ViewBill=@p18,Reports_PublisherDetails=@p19,Reports_BookDetails=@p20 where Username=@p23";

                com = new SqlCommand(s, con);

                
                
com.Parameters.AddWithValue("@p1", Rec[1]);
                
com.Parameters.AddWithValue("@p2", Rec[2]);
                
com.Parameters.AddWithValue("@p3", Rec[3]);
                
//com.Parameters.AddWithValue("@p4", Rec[4]);
                
//com.Parameters.AddWithValue("@p5", Rec[5]);
                
com.Parameters.AddWithValue("@p6", Rec[6]);
                
com.Parameters.AddWithValue("@p7", Rec[7]);
                
com.Parameters.AddWithValue("@p8", Rec[8]);
                
com.Parameters.AddWithValue("@p9", Rec[9]);
                
com.Parameters.AddWithValue("@p10", Rec[10]);
                
com.Parameters.AddWithValue("@p11", Rec[11]);
                
com.Parameters.AddWithValue("@p12", Rec[12]);
                
com.Parameters.AddWithValue("@p13", Rec[13]);
                
com.Parameters.AddWithValue("@p14", Rec[14]);
                
com.Parameters.AddWithValue("@p15", Rec[15]);
                
com.Parameters.AddWithValue("@p16", Rec[16]);
                
//com.Parameters.AddWithValue("@p17", Rec[17]);
                
com.Parameters.AddWithValue("@p18", Rec[18]);
                
com.Parameters.AddWithValue("@p19", Rec[19]);
                
com.Parameters.AddWithValue("@p20", Rec[20]);
                
//com.Parameters.AddWithValue("@p21", Rec[21]);
                
 //com.Parameters.AddWithValue("@p22", Rec[22]);
                
com.Parameters.AddWithValue("@p23", cmbusername.SelectedItem.ToString());
                con.Open();
                int j = com.ExecuteNonQuery();
                con.Close();
                if (j == 1)
                {
                    MessageBox.Show("Permissions set for the user" +cmbusername. SelectedItem.ToString());
                    
                  
                  
                   
                    
                }
                j++;
            }

        }
    }
}
