using FinalRestaurant.Model;
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

namespace FinalRestaurant.Reports
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            String qry = @"Select * from products";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrint frm = new frmPrint();
            rptMenuList cr = new rptMenuList();

            cr.SetDatabaseLogon("DESKTOP-CIECBTM", "");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            String qry = @"Select * from staff";

            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();
            frmPrint frm = new frmPrint();
            rptStaffList cr = new rptStaffList();

            cr.SetDatabaseLogon("DESKTOP-CIECBTM", "");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();

        }

        private void btnSaleCat_Click(object sender, EventArgs e)
        {
            frmSalesByCategory frm = new frmSalesByCategory();
            frm.ShowDialog();

        }
    }
}
