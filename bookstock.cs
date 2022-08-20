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
    public partial class bookstock : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;
        SqlDataReader dr;
        public bookstock()
        {
            InitializeComponent();
        }

        private void bookstock_Load(object sender, EventArgs e)
        {
            string s = "select Book_Id from BookStock";
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
           
            while (dr.Read())
            {
                cmbbookid.Items.Add(dr[0]);
            }
            con.Close();

            
        }

      

        private void btnsave_Click(object sender, EventArgs e)
        {
            string s = "insert into BookStock values(@p1,@p2)";
            com = new SqlCommand(s, con);
            com.Parameters.AddWithValue("@p1", cmbbookid.SelectedItem);
            com.Parameters.AddWithValue("@p2", txtquantityavilable.Text);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("records sasved");


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
