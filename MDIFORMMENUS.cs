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
    public partial class MDIFORMMENUS : Form
    {
        SqlConnection con = new SqlConnection("server=.;user id=sa;password=sa123;database=BookShop");
        SqlCommand com;
        SqlDataReader dr;
        bool[] Rec;

        public MDIFORMMENUS()
        {
                InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmaster bm = new bookmaster();
            bm.ShowDialog();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbookstock vs = new viewbookstock();
            vs.ShowDialog();
        }

        private void booksInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInventory bi = new BookInventory();
            bi.ShowDialog();

        }

        private void booksTurnoverToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherMaster pm = new PublisherMaster();
            pm.ShowDialog();
        }

        private void modifyDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            publishermastermodify pmm = new publishermastermodify();
            pmm.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewpublisher vp = new viewpublisher();
            vp.ShowDialog();
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billmaster bm = new billmaster();
            bm.ShowDialog();
        }

        private void viewPendingBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pending_bill_details pbd = new pending_bill_details();
            pbd.ShowDialog();

        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createnewuser cnu = new createnewuser();
            cnu.ShowDialog();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewusers vu = new viewusers();
            vu.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassword cp = new changepassword();
            cp.ShowDialog();
        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setpermission sp = new setpermission();
            sp.ShowDialog();
        }

        private void shopDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIFORMMENUS_Load(object sender, EventArgs e)
        {
           /* int i = 1;
            this.WindowState = FormWindowState.Maximized;
            string s = "select * from Setpermissions where Username='" + GlobalData.username + "'";
            com = new SqlCommand(s, con);
            con.Open();
            dr = com.ExecuteReader();
            dr.Read();
            {
                 Rec = new bool[dr.FieldCount];
                for (i = 1; i < Rec.Length; i++)
                {
                    Rec[i] = (bool)dr[i];
                }
            }
            con.Close();
             i= 1;
            foreach (ToolStripMenuItem I in menuStrip1.Items)
            {
                for (int j = 0; j < I.DropDownItems.Count; j++)
                {
                    if (I.DropDownItems[j].Name != "toopstripSeperator1")
                    {
                        if (Rec[i] == false)
                        {
                            I.DropDownItems[j].Enabled = true;
                            i++;
                        }
                        else
                        {
                            I.DropDownItems[j].Enabled = false;
                            i++;
                        }
                    }
                }


            }*/




        }

        private void publisherDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
