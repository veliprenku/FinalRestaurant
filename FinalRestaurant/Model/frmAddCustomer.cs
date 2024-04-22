using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalRestaurant.Model
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string orderType = "";
        public int driverID = 0;
        public string cusName = "";

        public int mainID = 0;
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            if(orderType == "Me Vete")
            {
                lblDriver.Visible = false;
                cbDriver.Visible = false;

            }
            string qry = "SELECT staffID 'id', sName 'name' FROM staff where sRole = 'Shofer'";
            MainClass.CBFill(qry, cbDriver);

            if(mainID > 0)
            {
                cbDriver.SelectedValue = driverID;
            }
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverID = Convert.ToInt32(cbDriver.SelectedValue);
        }
    }
}
