
namespace FinalRestaurant.Model
{
    partial class frmPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTalbe = new System.Windows.Forms.Label();
            this.btnNew = new Guna.UI.WinForms.GunaTileButton();
            this.btnHold = new Guna.UI.WinForms.GunaTileButton();
            this.btnBill = new Guna.UI.WinForms.GunaTileButton();
            this.btnKot = new Guna.UI.WinForms.GunaTileButton();
            this.btnDelivery = new Guna.UI.WinForms.GunaTileButton();
            this.btnTake = new Guna.UI.WinForms.GunaTileButton();
            this.btnDin = new Guna.UI.WinForms.GunaTileButton();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckout = new Guna.UI.WinForms.GunaTileButton();
            this.btnExit = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDin);
            this.panel1.Controls.Add(this.btnTake);
            this.panel1.Controls.Add(this.btnDelivery);
            this.panel1.Controls.Add(this.btnKot);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnHold);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.lblWaiter);
            this.panel1.Controls.Add(this.lblTalbe);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 111);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnCheckout);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 684);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblTalbe
            // 
            this.lblTalbe.AutoSize = true;
            this.lblTalbe.Font = new System.Drawing.Font("Segoe UI", 15.2F);
            this.lblTalbe.Location = new System.Drawing.Point(1050, 9);
            this.lblTalbe.Name = "lblTalbe";
            this.lblTalbe.Size = new System.Drawing.Size(106, 36);
            this.lblTalbe.TabIndex = 1;
            this.lblTalbe.Text = "Tavolina";
            // 
            // btnNew
            // 
            this.btnNew.AnimationHoverSpeed = 0.07F;
            this.btnNew.AnimationSpeed = 0.03F;
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnNew.BorderColor = System.Drawing.Color.Black;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = null;
            this.btnNew.ImageSize = new System.Drawing.Size(52, 52);
            this.btnNew.Location = new System.Drawing.Point(261, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNew.OnHoverImage = null;
            this.btnNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnNew.Radius = 10;
            this.btnNew.Size = new System.Drawing.Size(90, 85);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Porosi e Re";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnHold
            // 
            this.btnHold.AnimationHoverSpeed = 0.07F;
            this.btnHold.AnimationSpeed = 0.03F;
            this.btnHold.BackColor = System.Drawing.Color.Transparent;
            this.btnHold.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnHold.BorderColor = System.Drawing.Color.Black;
            this.btnHold.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.Image = null;
            this.btnHold.ImageSize = new System.Drawing.Size(52, 52);
            this.btnHold.Location = new System.Drawing.Point(373, 10);
            this.btnHold.Name = "btnHold";
            this.btnHold.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHold.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHold.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHold.OnHoverImage = null;
            this.btnHold.OnPressedColor = System.Drawing.Color.Black;
            this.btnHold.Radius = 10;
            this.btnHold.Size = new System.Drawing.Size(90, 85);
            this.btnHold.TabIndex = 2;
            this.btnHold.Text = "Prit";
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnBill
            // 
            this.btnBill.AnimationHoverSpeed = 0.07F;
            this.btnBill.AnimationSpeed = 0.03F;
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnBill.BorderColor = System.Drawing.Color.Black;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = null;
            this.btnBill.ImageSize = new System.Drawing.Size(52, 52);
            this.btnBill.Location = new System.Drawing.Point(487, 10);
            this.btnBill.Name = "btnBill";
            this.btnBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBill.OnHoverImage = null;
            this.btnBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnBill.Radius = 10;
            this.btnBill.Size = new System.Drawing.Size(90, 85);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Lista e Faturave";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnKot
            // 
            this.btnKot.AnimationHoverSpeed = 0.07F;
            this.btnKot.AnimationSpeed = 0.03F;
            this.btnKot.BackColor = System.Drawing.Color.Transparent;
            this.btnKot.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnKot.BorderColor = System.Drawing.Color.Black;
            this.btnKot.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnKot.ForeColor = System.Drawing.Color.White;
            this.btnKot.Image = null;
            this.btnKot.ImageSize = new System.Drawing.Size(52, 52);
            this.btnKot.Location = new System.Drawing.Point(607, 10);
            this.btnKot.Name = "btnKot";
            this.btnKot.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKot.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKot.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKot.OnHoverImage = null;
            this.btnKot.OnPressedColor = System.Drawing.Color.Black;
            this.btnKot.Radius = 10;
            this.btnKot.Size = new System.Drawing.Size(90, 85);
            this.btnKot.TabIndex = 2;
            this.btnKot.Text = "Porosit";
            this.btnKot.Click += new System.EventHandler(this.btnKot_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.AnimationHoverSpeed = 0.07F;
            this.btnDelivery.AnimationSpeed = 0.03F;
            this.btnDelivery.BackColor = System.Drawing.Color.Transparent;
            this.btnDelivery.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelivery.BorderColor = System.Drawing.Color.Black;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Image = null;
            this.btnDelivery.ImageSize = new System.Drawing.Size(52, 52);
            this.btnDelivery.Location = new System.Drawing.Point(729, 12);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelivery.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelivery.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelivery.OnHoverImage = null;
            this.btnDelivery.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelivery.Radius = 10;
            this.btnDelivery.Size = new System.Drawing.Size(90, 85);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "Dergo Porosi";
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnTake
            // 
            this.btnTake.AnimationHoverSpeed = 0.07F;
            this.btnTake.AnimationSpeed = 0.03F;
            this.btnTake.BackColor = System.Drawing.Color.Transparent;
            this.btnTake.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnTake.BorderColor = System.Drawing.Color.Black;
            this.btnTake.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnTake.ForeColor = System.Drawing.Color.White;
            this.btnTake.Image = null;
            this.btnTake.ImageSize = new System.Drawing.Size(52, 52);
            this.btnTake.Location = new System.Drawing.Point(843, 12);
            this.btnTake.Name = "btnTake";
            this.btnTake.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTake.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTake.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTake.OnHoverImage = null;
            this.btnTake.OnPressedColor = System.Drawing.Color.Black;
            this.btnTake.Radius = 10;
            this.btnTake.Size = new System.Drawing.Size(90, 85);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Me Vete";
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnDin
            // 
            this.btnDin.AnimationHoverSpeed = 0.07F;
            this.btnDin.AnimationSpeed = 0.03F;
            this.btnDin.BackColor = System.Drawing.Color.Transparent;
            this.btnDin.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnDin.BorderColor = System.Drawing.Color.Black;
            this.btnDin.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnDin.ForeColor = System.Drawing.Color.White;
            this.btnDin.Image = null;
            this.btnDin.ImageSize = new System.Drawing.Size(52, 52);
            this.btnDin.Location = new System.Drawing.Point(954, 12);
            this.btnDin.Name = "btnDin";
            this.btnDin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDin.OnHoverImage = null;
            this.btnDin.OnPressedColor = System.Drawing.Color.Black;
            this.btnDin.Radius = 10;
            this.btnDin.Size = new System.Drawing.Size(90, 85);
            this.btnDin.TabIndex = 2;
            this.btnDin.Text = "Porosit";
            this.btnDin.Click += new System.EventHandler(this.btnDin_Click);
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 15.2F);
            this.lblWaiter.Location = new System.Drawing.Point(1050, 59);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(122, 36);
            this.lblWaiter.TabIndex = 1;
            this.lblWaiter.Text = "Kamarieri";
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.ColumnHeadersHeight = 40;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvproID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(1003, 189);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 30;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(350, 489);
            this.gunaDataGridView1.TabIndex = 11;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = true;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gunaDataGridView1_CellFormatting);
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Location = new System.Drawing.Point(149, 189);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(848, 489);
            this.ProductPanel.TabIndex = 2;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Location = new System.Drawing.Point(6, 189);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(140, 489);
            this.CategoryPanel.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(158, 140);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.Size = new System.Drawing.Size(280, 43);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kerko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.2F);
            this.label2.Location = new System.Drawing.Point(106, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "POS";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.2F);
            this.label3.Location = new System.Drawing.Point(1068, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Totali: ";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.2F);
            this.lblTotal.Location = new System.Drawing.Point(1181, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 36);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0.00";
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 50F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 50;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 50;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvproID
            // 
            this.dgvproID.HeaderText = "ProductID";
            this.dgvproID.MinimumWidth = 6;
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.ReadOnly = true;
            this.dgvproID.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.FillWeight = 85.47237F;
            this.dgvName.HeaderText = "Emri";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 58F;
            this.dgvQty.HeaderText = "Sasia";
            this.dgvQty.MinimumWidth = 58;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 58;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 58F;
            this.dgvPrice.HeaderText = "Qmimi";
            this.dgvPrice.MinimumWidth = 58;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 58;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 58F;
            this.dgvAmount.HeaderText = "Vlera";
            this.dgvAmount.MinimumWidth = 58;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 58;
            // 
            // btnCheckout
            // 
            this.btnCheckout.AnimationHoverSpeed = 0.07F;
            this.btnCheckout.AnimationSpeed = 0.03F;
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.BaseColor = System.Drawing.Color.SkyBlue;
            this.btnCheckout.BorderColor = System.Drawing.Color.Black;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = null;
            this.btnCheckout.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCheckout.Location = new System.Drawing.Point(905, 25);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCheckout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCheckout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCheckout.OnHoverImage = null;
            this.btnCheckout.OnPressedColor = System.Drawing.Color.Black;
            this.btnCheckout.Radius = 10;
            this.btnCheckout.Size = new System.Drawing.Size(139, 50);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Paguaj";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BaseColor = System.Drawing.Color.White;
            this.btnExit.Image = global::FinalRestaurant.Properties.Resources.icons8_power_button_48;
            this.btnExit.Location = new System.Drawing.Point(1287, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 53);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::FinalRestaurant.Properties.Resources.icons8_point_of_sale_64;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(88, 83);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Font = new System.Drawing.Font("Segoe UI", 15.2F);
            this.lblDriverName.Location = new System.Drawing.Point(455, 140);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(96, 36);
            this.lblDriverName.TabIndex = 12;
            this.lblDriverName.Text = "Shoferi";
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1353, 784);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox btnExit;
        private Guna.UI.WinForms.GunaTileButton btnDin;
        private Guna.UI.WinForms.GunaTileButton btnTake;
        private Guna.UI.WinForms.GunaTileButton btnDelivery;
        private Guna.UI.WinForms.GunaTileButton btnKot;
        private Guna.UI.WinForms.GunaTileButton btnBill;
        private Guna.UI.WinForms.GunaTileButton btnHold;
        private Guna.UI.WinForms.GunaTileButton btnNew;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTalbe;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        public Guna.UI.WinForms.GunaTextBox txtSearch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private Guna.UI.WinForms.GunaTileButton btnCheckout;
        private System.Windows.Forms.Label lblDriverName;
    }
}