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
    public partial class viewusers : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlDataAdapter da;
        DataSet ds;
        public viewusers()
        {
            InitializeComponent();
        }

        private void viewusers_Load(object sender, EventArgs e)
        {
            string s = "select username from createnewuser";
            da = new SqlDataAdapter(s, con);
            ds = new DataSet();
            da.Fill(ds, "cnu");
            dgrvviewusers.DataSource = ds.Tables[0];
        }
    }
}
