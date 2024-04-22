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
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)//create
            {
                qry = "INSERT INTO tables VALUES (@Name);";
            }
            else
            {
                qry = "UPDATE tables set tname = @Name where tid = @id;";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("E ruajtur me sukses...");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }
    }
}
