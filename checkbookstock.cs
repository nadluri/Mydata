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
    public partial class checkbookstock : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand com;
        SqlDataReader dr;
        public checkbookstock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkbookstock_Load(object sender, EventArgs e)
        {
            string s = "select b.Book_Id,b.Book_Name,b.Publisher_Code ,p.Publisher_Name from bookmaster b,publishermaster p where b.Publisher_Code=p.Publisher_Code";
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            da.Fill(ds, "pm");
            dgrvcheckbookstock.DataSource = ds.Tables[0];
          
        }

        private void dgrvcheckbookstock_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string s = "select Quntity_Available from BookStock where Book_Id='" + dgrvcheckbookstock.Rows[e.RowIndex].Cells[0].Value + "'";
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtavailability.Text = dr[0].ToString();
            }
            con.Close();

           
        }

     
    }
}
