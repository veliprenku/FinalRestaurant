using FinalRestaurant.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalRestaurant.Model
{
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }
        public int MainID = 0;


        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
           
                string qry = @"Select MainID, TableName, WaiterName, orderType, status, total from tblMain
                               where status <> 'Në Pritje'";
                ListBox lb = new ListBox();
                lb.Items.Add(dgvid);
                lb.Items.Add(dgvTable);
                lb.Items.Add(dgvWaiter);
                lb.Items.Add(dgvType);
                lb.Items.Add(dgvStatus);
                lb.Items.Add(dgvTotal);

                MainClass.LoadData(qry, gunaDataGridView1, lb);
            
        }

        private void gunaDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach(DataGridViewRow row in gunaDataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {

                MainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();
               
            }
            if (gunaDataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                MainID = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = @"SELECT * FROM tblMain m inner join
                                tblDetails d on d.MainID = m.MainID
                                inner join products p on p.pID = d.proID
                                where m.MainID = "+ MainID + "";

                SqlCommand cmd = new SqlCommand(qry,MainClass.con);
                MainClass.con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();
                frmPrint frm = new frmPrint();
                rptBill cr = new rptBill();

                cr.SetDatabaseLogon("DESKTOP-CIECBTM", "");
                cr.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();
            
            
            }


        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
