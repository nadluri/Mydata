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

namespace Bookshope
{
    public partial class publisherdetails : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
       SqlDataAdapter da;
        DataSet ds;
        public publisherdetails()
        {
            InitializeComponent();
        }

        private void publisherdetails_Load(object sender, EventArgs e)
        {
            string s = "Select * from publishermaster";
          da = new SqlDataAdapter(s, con);
          ds = new DataSet();
          da.Fill( ds, "pm");
            publisherdetailsdgrv.DataSource = ds.Tables[0];


        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void publisherdetailsdgrv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GlobalData.pubcode =publisherdetailsdgrv. Rows[e.RowIndex].Cells[0].Value.ToString();
           
        }
    }
}
