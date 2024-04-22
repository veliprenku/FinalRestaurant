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

namespace FinalRestaurant.Model
{
    public partial class frmStaffAdd : SampleAdd
    {
        public frmStaffAdd()
        {
            InitializeComponent();
        }
        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)//create
            {
                qry = "INSERT INTO staff VALUES (@Name, @phone, @role);";
            }
            else
            {
                qry = "UPDATE staff set sName = @Name, sPhone = @phone, sRole = @role where staffID = @id;";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("E ruajtur me sukses...");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
