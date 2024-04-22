
namespace FinalRestaurant.Model
{
    partial class frmStaffAdd
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
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRole = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Size = new System.Drawing.Size(559, 131);
            this.gunaPanel1.TabIndex = 4;
            this.gunaPanel1.Controls.SetChildIndex(this.gunaPictureBox1, 0);
            this.gunaPanel1.Controls.SetChildIndex(this.label1, 0);
            this.gunaPanel1.Controls.SetChildIndex(this.gunaButton1, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shto staff";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Image = global::FinalRestaurant.Properties.Resources.add;
            this.gunaPictureBox1.Size = new System.Drawing.Size(99, 94);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 404);
            this.gunaPanel2.Size = new System.Drawing.Size(559, 98);
            this.gunaPanel2.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.TabIndex = 1;
            this.btnClose.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.TabIndex = 0;
            this.btnSave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.BorderSize = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(32, 190);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 10;
            this.txtName.Size = new System.Drawing.Size(208, 46);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Emri";
            // 
            // txtPhone
            // 
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(276, 190);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 10;
            this.txtPhone.Size = new System.Drawing.Size(216, 46);
            this.txtPhone.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(272, 155);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(68, 23);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Telefoni";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pozita";
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbRole.BaseColor = System.Drawing.Color.White;
            this.cbRole.BorderColor = System.Drawing.Color.Silver;
            this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbRole.ForeColor = System.Drawing.Color.Black;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Kamarier",
            "Shofer",
            "Pastrues",
            "etj..."});
            this.cbRole.Location = new System.Drawing.Point(32, 305);
            this.cbRole.Name = "cbRole";
            this.cbRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbRole.Size = new System.Drawing.Size(208, 40);
            this.cbRole.TabIndex = 2;
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
            this.gunaButton1.Location = new System.Drawing.Point(499, 12);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(48, 45);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "X";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 502);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Name = "frmStaffAdd";
            this.Text = "frmStaffAdd";
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.lblPhone, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbRole, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaTextBox txtName;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txtPhone;
        public System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.Label label4;
        public Guna.UI.WinForms.GunaComboBox cbRole;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}