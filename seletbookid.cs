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
    public partial class seletbookid : Form
    {
        SqlConnection con = new SqlConnection("server=.; user id=sa;password=sa123;database=BookShop");
        public seletbookid()
        {
            InitializeComponent();
        }

        private void seletbookid_Load(object sender, EventArgs e)
        {
            string s = "select b.Book_Id,b.Publisher_Code, b.ISBN_Code,b.Book_Name,s.Stock_Date,s.Quntity_Before,s.Quntity_Received,s.Quntity_After,s.Order_Number from bookmaster b,booksinventory s where s.Book_Id=b.Book_Id";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "bm");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GlobalData.txtbookid =dataGridView1. Rows[e.RowIndex].Cells[0].Value.ToString();
            GlobalData.txtbeforestock = dataGridView1.Rows[e.RowIndex].Cells[5].Value. ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
