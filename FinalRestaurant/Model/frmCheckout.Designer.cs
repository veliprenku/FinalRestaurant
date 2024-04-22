
namespace FinalRestaurant.Model
{
    partial class frmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.txtReceived = new Guna.UI.WinForms.GunaTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBillAmount = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChange = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Size = new System.Drawing.Size(558, 131);
            this.gunaPanel1.Controls.SetChildIndex(this.gunaButton1, 0);
            this.gunaPanel1.Controls.SetChildIndex(this.gunaPictureBox1, 0);
            this.gunaPanel1.Controls.SetChildIndex(this.label1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(145, 49);
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.Text = "Pagesa";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Size = new System.Drawing.Size(96, 89);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 431);
            this.gunaPanel2.Size = new System.Drawing.Size(558, 92);
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Red;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(498, 12);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(48, 45);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "X";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.BaseColor = System.Drawing.Color.White;
            this.txtReceived.BorderColor = System.Drawing.Color.Silver;
            this.txtReceived.BorderSize = 1;
            this.txtReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReceived.FocusedBaseColor = System.Drawing.Color.White;
            this.txtReceived.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtReceived.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReceived.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtReceived.Location = new System.Drawing.Point(282, 203);
            this.txtReceived.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtReceived.PasswordChar = '\0';
            this.txtReceived.Radius = 10;
            this.txtReceived.Size = new System.Drawing.Size(216, 46);
            this.txtReceived.TabIndex = 8;
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(278, 168);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(134, 23);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Para të gatshme";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BaseColor = System.Drawing.Color.White;
            this.txtBillAmount.BorderColor = System.Drawing.Color.Silver;
            this.txtBillAmount.BorderSize = 1;
            this.txtBillAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillAmount.Enabled = false;
            this.txtBillAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBillAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBillAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBillAmount.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtBillAmount.Location = new System.Drawing.Point(38, 203);
            this.txtBillAmount.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtBillAmount.PasswordChar = '\0';
            this.txtBillAmount.Radius = 10;
            this.txtBillAmount.Size = new System.Drawing.Size(208, 46);
            this.txtBillAmount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Për pagesë";
            // 
            // txtChange
            // 
            this.txtChange.BaseColor = System.Drawing.Color.White;
            this.txtChange.BorderColor = System.Drawing.Color.Silver;
            this.txtChange.BorderSize = 1;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.Enabled = false;
            this.txtChange.FocusedBaseColor = System.Drawing.Color.White;
            this.txtChange.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtChange.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtChange.Location = new System.Drawing.Point(38, 333);
            this.txtChange.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtChange.Name = "txtChange";
            this.txtChange.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtChange.PasswordChar = '\0';
            this.txtChange.Radius = 10;
            this.txtChange.Size = new System.Drawing.Size(208, 46);
            this.txtChange.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kusuri";
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 523);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label2);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBillAmount, 0);
            this.Controls.SetChildIndex(this.lblPhone, 0);
            this.Controls.SetChildIndex(this.txtReceived, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtChange, 0);
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        public Guna.UI.WinForms.GunaTextBox txtReceived;
        public System.Windows.Forms.Label lblPhone;
        public Guna.UI.WinForms.GunaTextBox txtBillAmount;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txtChange;
        public System.Windows.Forms.Label label4;
    }
}