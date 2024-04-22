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
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType = "";
        public int driverID = 0;
        public string customerName = "";
        public string customerPhone = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProduct();
            lblDriverName.Visible = false;
        }

        private void AddCategory()
        {
            String qry = "Select * from category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            Button b2 = new Button();
            b2.BackColor = Color.PaleVioletRed;
            b2.ForeColor = Color.White;
            b2.FlatStyle = FlatStyle.Flat;
            b2.FlatAppearance.BorderSize = 0;
            b2.Size = new Size(134, 45);
            b2.Text = ("Te Gjitha");

            b2.Click += new EventHandler(b_Click);


            CategoryPanel.Controls.Add(b2);


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Button b = new Button();
                    b.BackColor = Color.PaleVioletRed;
                    b.ForeColor = Color.White; 
                    b.FlatStyle = FlatStyle.Flat; 
                    b.FlatAppearance.BorderSize = 0; 
                    b.Size = new Size(134, 45);
                    b.Text = row["catName"].ToString();

                    b.Click += new EventHandler(b_Click);


                    CategoryPanel.Controls.Add(b);
                }
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            if(b.Text == "Te Gjitha")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
            }

            foreach(var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, String proID, string name, string cat, string price)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                id = Convert.ToInt32(proID)
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in gunaDataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        return;
                    }
                    
                }
                gunaDataGridView1.Rows.Add(new object[] {0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        private void LoadProduct()
        {
            string qry = "SELECT * FROM products inner join category on catID = CategoryID ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow item in dt.Rows)
            {
                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
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

        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";

            foreach(DataGridViewRow item in gunaDataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = tot.ToString("N2");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            gunaDataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "0.00";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Dergesë";


            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlurBackground(frm);

            if (frm.txtName.Text != "")
            {
                driverID = frm.driverID;
                lblDriverName.Text = "Klienti: " + frm.txtName.Text + " Telefoni: " + frm.txtPhone.Text + " Shoferi: " + frm.cbDriver.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Me Vete";

            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlurBackground(frm);

            if(frm.txtName.Text != "")
            {
                driverID = frm.driverID;
                lblDriverName.Text = "Klienti: " + frm.txtName.Text + " Telefoni: " + frm.txtPhone.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;
            }

        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "Porosi Brenda";
            lblDriverName.Visible = false;
            frmTableSelect frm = new frmTableSelect();
            MainClass.BlurBackground(frm);

            if(frm.TableName != "")
            {
                lblTalbe.Text = frm.TableName;
                lblTalbe.Visible = true;
            }
            else
            {
                lblTalbe.Text = "";
                lblTalbe.Visible = false;
            }

            frmWaiterSelect frm2 = new frmWaiterSelect();
            MainClass.BlurBackground(frm2);

            if (frm2.WaiterName != "")
            {
                lblWaiter.Text = frm2.WaiterName;
                lblWaiter.Visible = true;

            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }
        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            string qry1 = ""; //Main Table
            string qry2 = ""; //Details Table


            int detailID = 0;
            if (MainID == 0)
            {
                qry1 = @"INSERT INTO tblMain Values( @aDate, @aTime, @TableName, @WaiterName, 
                                                @status, @orderType, @total, @received, @change,@driverID,@CustName,@CustPhone);
                                                    SELECT SCOPE_IDENTITY()";
            }
            else
            {
                qry1 = @"UPDATE tblMain set status = @status, orderType = @orderType, total =  @total, received = @received, change = @change where MainID = @ID";
            }

            Hashtable ht = new Hashtable();

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);

            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTalbe.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Në Pritje");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID",driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0)
                {
                    qry2 = @"INSERT INTO tblDetails Values(@MainID, @proID, @qty, @price, @amount)";
                }
                else
                {
                    qry2 = @"UPDATE tblDetails set proID = @proID, qty = @qty, price = @price, amount = @amount
                                    where DetailID = @ID";
                }



                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);

                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery(); 
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

               

            }
            MessageBox.Show("E ruajtur me sukses...");
            MainID = 0;
            detailID = 0;
            gunaDataGridView1.Rows.Clear();
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            lblDriverName.Text = "";
        }
        public int id = 0;
        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBillList frm = new frmBillList();
            MainClass.BlurBackground(frm);

            if(frm.MainID > 0)
            {
                id = frm.MainID;
                MainID = frm.MainID;
                LoadEntries();
            }
        }
        private void LoadEntries()
        {
            string qry = @"SELECT * FROM tblMain m
                                inner join tblDetails d on m.MainID = d.MainID
                                inner join products p on p.pID = d.proID
                                where m.MainID = " + id + "";
            
            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);


            
            gunaDataGridView1.Rows.Clear();

            foreach(DataRow item in dt2.Rows)
            {
                lblTalbe.Text = item["TableName"].ToString();
                lblWaiter.Text = item["WaiterName"].ToString();
                string detailid = item["DetailID"].ToString();
                string proName = item["pName"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = { 0, detailid, proid, proName, qty, price, amount };
                gunaDataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.MainID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);
            
            
            MainID = 0;
            
            gunaDataGridView1.Rows.Clear();
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            string qry1 = ""; //Main Table
            string qry2 = ""; //Details Table


            int detailID = 0;
            if(OrderType == "")
            {
                MessageBox.Show("Ju lutem vendoesni llojin e porosise!!!");
                return;
            }

            if (MainID == 0)
            {
                qry1 = @"INSERT INTO tblMain Values( @aDate, @aTime, @TableName, @WaiterName, 
                                                @status, @orderType, @total, @received, @change,@driverID,@CustName,@CustPhone);
                                                    SELECT SCOPE_IDENTITY()";
            }
            else
            {
                qry1 = @"UPDATE tblMain set status = @status, orderType = @orderType, total =  @total, received = @received, change = @change where MainID = @ID";
            }

            Hashtable ht = new Hashtable();

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);

            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTalbe.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Mbaje");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }


            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0)
                {
                    qry2 = @"INSERT INTO tblDetails Values(@MainID, @proID, @qty, @price, @amount)";
                }
                else
                {
                    qry2 = @"UPDATE tblDetails set proID = @proID, qty = @qty, price = @price, amount = @amount
                                    where DetailID = @ID";
                }



                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);

                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }



            }
            MessageBox.Show("E ruajtur me sukses...");
            MainID = 0;
            detailID = 0;
            gunaDataGridView1.Rows.Clear();
            lblTalbe.Text = "";
            lblWaiter.Text = "";
            lblTalbe.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            lblDriverName.Text = "";
        }
    }
    
}
