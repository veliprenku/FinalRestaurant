
namespace FinalRestaurant.Reports
{
    partial class frmReports
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStaff = new Guna.UI.WinForms.GunaButton();
            this.btnMenu = new Guna.UI.WinForms.GunaButton();
            this.btnSaleCat = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raporte";
            // 
            // btnStaff
            // 
            this.btnStaff.AnimationHoverSpeed = 0.07F;
            this.btnStaff.AnimationSpeed = 0.03F;
            this.btnStaff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStaff.BorderColor = System.Drawing.Color.Black;
            this.btnStaff.BorderSize = 1;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::FinalRestaurant.Properties.Resources.check;
            this.btnStaff.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStaff.Location = new System.Drawing.Point(271, 104);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStaff.OnHoverImage = null;
            this.btnStaff.OnPressedColor = System.Drawing.Color.Black;
            this.btnStaff.Size = new System.Drawing.Size(198, 100);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Staffi";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AnimationHoverSpeed = 0.07F;
            this.btnMenu.AnimationSpeed = 0.03F;
            this.btnMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMenu.BorderColor = System.Drawing.Color.Black;
            this.btnMenu.BorderSize = 1;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::FinalRestaurant.Properties.Resources.menu;
            this.btnMenu.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMenu.Location = new System.Drawing.Point(47, 104);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMenu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenu.OnHoverImage = null;
            this.btnMenu.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenu.Size = new System.Drawing.Size(198, 100);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menyja";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSaleCat
            // 
            this.btnSaleCat.AnimationHoverSpeed = 0.07F;
            this.btnSaleCat.AnimationSpeed = 0.03F;
            this.btnSaleCat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSaleCat.BorderColor = System.Drawing.Color.Black;
            this.btnSaleCat.BorderSize = 1;
            this.btnSaleCat.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSaleCat.ForeColor = System.Drawing.Color.White;
            this.btnSaleCat.Image = global::FinalRestaurant.Properties.Resources.check;
            this.btnSaleCat.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSaleCat.Location = new System.Drawing.Point(47, 224);
            this.btnSaleCat.Name = "btnSaleCat";
            this.btnSaleCat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSaleCat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaleCat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaleCat.OnHoverImage = null;
            this.btnSaleCat.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaleCat.Size = new System.Drawing.Size(338, 112);
            this.btnSaleCat.TabIndex = 3;
            this.btnSaleCat.Text = "Shitje sipas Kategorise";
            this.btnSaleCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaleCat.Click += new System.EventHandler(this.btnSaleCat_Click);
            // 
            // frmReports
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(948, 566);
            this.Controls.Add(this.btnSaleCat);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnMenu;
        private Guna.UI.WinForms.GunaButton btnStaff;
        private Guna.UI.WinForms.GunaButton btnSaleCat;
    }
}