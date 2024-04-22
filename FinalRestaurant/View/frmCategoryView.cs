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
    public partial class frmCategoryView : SampleView

    {
        public frmCategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select * from category where catName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, gunaDataGridView1, lb);
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCategoryAdd());
            GetData();
        }

        public override void txtSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                MessageBox.Show("A jeni të sigurtë që dëshironi të modifikoni?", "Konfirmim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);             
                frmCategoryAdd frm = new frmCategoryAdd();               
                frm.id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(gunaDataGridView1.CurrentRow.Cells["dgvName"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                DialogResult result = MessageBox.Show("A jeni të sigurtë që dëshironi të fshini këtë kategori?", "Konfirmim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);              
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvID"].Value);
                    string qry = "DELETE FROM category WHERE catID = " + id;
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);                    
                    MessageBox.Show("E fshirë me sukses...");
                    GetData();
                }
            }
        }
    }
}
