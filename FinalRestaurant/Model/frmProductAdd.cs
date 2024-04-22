using System;
using System.Collections;
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
    public partial class frmProductAdd : SampleAdd
    {
        public int id = 0;
        public int cID = 0;

        public frmProductAdd()
        {
            InitializeComponent();
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.restaurantDataSet.category);
            string qry = "Select catID 'id', catName 'name' from category";
            MainClass.CBFill(qry, cbCat);

            if (cID > 0)
            {
                cbCat.SelectedValue = cID;
            }
            if(id > 0)
            {
                ForUpdateLoadData();
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)//create
            {
                qry = "INSERT INTO products VALUES (@Name, @price, @cat);";
            }
            else
            {
                qry = "UPDATE products set pName = @Name, pPrice = @price, CategoryID = @cat where pID = @id;";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(cbCat.SelectedValue));

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("E ruajtur me sukses...");
                id = 0;
                cID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                cbCat.SelectedIndex = 0;
                cbCat.SelectedIndex = -1;
                txtName.Focus();
            }
        }

        private void ForUpdateLoadData()
        {
            string qry = @"SELECT * FROM products where pid = " + id +"";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();

            }


        }
    }
}

