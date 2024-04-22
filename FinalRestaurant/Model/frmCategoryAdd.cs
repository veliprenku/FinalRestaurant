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
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if(id == 0)//create
            {
                qry = "INSERT INTO category VALUES (@Name);";
            }
            else
            {
                qry = "UPDATE category set catName = @Name where catID = @id;";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if(MainClass.SQl(qry,ht) > 0)
            {
                MessageBox.Show("E ruajtur me sukses...");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }


    }
}
