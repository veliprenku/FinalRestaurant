using FinalRestaurant.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalRestaurant.View
{
    public partial class frmProductView : SampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string qry = "Select pID, pName, pPrice, CategoryID, c.catName from products p inner join category c on c.catID = p.CategoryID where pName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvcat);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }

      
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmProductAdd());
            GetData();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                MessageBox.Show("A jeni të sigurtë që dëshironi të modifikoni?", "Konfirmim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvcatid"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                DialogResult result = MessageBox.Show("A jeni të sigurtë që dëshironi të fshini këtë kategori?", "Konfirmim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvID"].Value);
                    string qry = "DELETE FROM products WHERE pid = " + id;
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);
                    MessageBox.Show("E fshirë me sukses...");
                    GetData();
                }
            }
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            GetData();
        }

       
    }
}
