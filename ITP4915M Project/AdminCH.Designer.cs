namespace _4915Project
{
    partial class AdminCH
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
            this.btn_AdminStaffCH = new System.Windows.Forms.Button();
            this.btn_AdminProductCH = new System.Windows.Forms.Button();
            this.btn_AdminRetailStoreCH = new System.Windows.Forms.Button();
            this.btn_AdminSupplierCH = new System.Windows.Forms.Button();
            this.btn_AdminLogoutCH = new System.Windows.Forms.Button();
            this.lnk_AdminENG = new System.Windows.Forms.LinkLabel();
            this.btn_AdminEditCH = new System.Windows.Forms.Button();
            this.grb_AdminCH = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_AdminCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AdminStaffCH
            // 
            this.btn_AdminStaffCH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AdminStaffCH.Location = new System.Drawing.Point(39, 60);
            this.btn_AdminStaffCH.Name = "btn_AdminStaffCH";
            this.btn_AdminStaffCH.Size = new System.Drawing.Size(116, 62);
            this.btn_AdminStaffCH.TabIndex = 6;
            this.btn_AdminStaffCH.Text = "员工";
            this.btn_AdminStaffCH.UseVisualStyleBackColor = true;
            this.btn_AdminStaffCH.Click += new System.EventHandler(this.btn_AdminStaffCH_Click);
            // 
            // btn_AdminProductCH
            // 
            this.btn_AdminProductCH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_AdminProductCH.Location = new System.Drawing.Point(212, 60);
            this.btn_AdminProductCH.Name = "btn_AdminProductCH";
            this.btn_AdminProductCH.Size = new System.Drawing.Size(116, 62);
            this.btn_AdminProductCH.TabIndex = 7;
            this.btn_AdminProductCH.Text = "产品";
            this.btn_AdminProductCH.UseVisualStyleBackColor = true;
            this.btn_AdminProductCH.Click += new System.EventHandler(this.btn_AdminProductCH_Click);
            // 
            // btn_AdminRetailStoreCH
            // 
            this.btn_AdminRetailStoreCH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_AdminRetailStoreCH.Location = new System.Drawing.Point(39, 172);
            this.btn_AdminRetailStoreCH.Name = "btn_AdminRetailStoreCH";
            this.btn_AdminRetailStoreCH.Size = new System.Drawing.Size(116, 62);
            this.btn_AdminRetailStoreCH.TabIndex = 8;
            this.btn_AdminRetailStoreCH.Text = "商店";
            this.btn_AdminRetailStoreCH.UseVisualStyleBackColor = true;
            this.btn_AdminRetailStoreCH.Click += new System.EventHandler(this.btn_AdminRetailStoreCH_Click);
            // 
            // btn_AdminSupplierCH
            // 
            this.btn_AdminSupplierCH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_AdminSupplierCH.Location = new System.Drawing.Point(212, 172);
            this.btn_AdminSupplierCH.Name = "btn_AdminSupplierCH";
            this.btn_AdminSupplierCH.Size = new System.Drawing.Size(116, 62);
            this.btn_AdminSupplierCH.TabIndex = 9;
            this.btn_AdminSupplierCH.Text = "供应商";
            this.btn_AdminSupplierCH.UseVisualStyleBackColor = true;
            this.btn_AdminSupplierCH.Click += new System.EventHandler(this.btn_AdminSupplierCH_Click);
            // 
            // btn_AdminLogoutCH
            // 
            this.btn_AdminLogoutCH.Location = new System.Drawing.Point(454, 394);
            this.btn_AdminLogoutCH.Name = "btn_AdminLogoutCH";
            this.btn_AdminLogoutCH.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminLogoutCH.TabIndex = 10;
            this.btn_AdminLogoutCH.Text = "登出";
            this.btn_AdminLogoutCH.UseVisualStyleBackColor = true;
            this.btn_AdminLogoutCH.Click += new System.EventHandler(this.btn_AdminLogoutCH_Click);
            // 
            // lnk_AdminENG
            // 
            this.lnk_AdminENG.AutoSize = true;
            this.lnk_AdminENG.Location = new System.Drawing.Point(501, 9);
            this.lnk_AdminENG.Name = "lnk_AdminENG";
            this.lnk_AdminENG.Size = new System.Drawing.Size(28, 12);
            this.lnk_AdminENG.TabIndex = 11;
            this.lnk_AdminENG.TabStop = true;
            this.lnk_AdminENG.Text = "ENG";
            this.lnk_AdminENG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_AdminENG_LinkClicked);
            // 
            // btn_AdminEditCH
            // 
            this.btn_AdminEditCH.Location = new System.Drawing.Point(12, 394);
            this.btn_AdminEditCH.Name = "btn_AdminEditCH";
            this.btn_AdminEditCH.Size = new System.Drawing.Size(105, 23);
            this.btn_AdminEditCH.TabIndex = 12;
            this.btn_AdminEditCH.Text = "修改个人资料";
            this.btn_AdminEditCH.UseVisualStyleBackColor = true;
            this.btn_AdminEditCH.Click += new System.EventHandler(this.btn_AdminEditCH_Click);
            // 
            // grb_AdminCH
            // 
            this.grb_AdminCH.Controls.Add(this.btn_AdminStaffCH);
            this.grb_AdminCH.Controls.Add(this.btn_AdminProductCH);
            this.grb_AdminCH.Controls.Add(this.btn_AdminRetailStoreCH);
            this.grb_AdminCH.Controls.Add(this.btn_AdminSupplierCH);
            this.grb_AdminCH.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_AdminCH.Location = new System.Drawing.Point(101, 64);
            this.grb_AdminCH.Name = "grb_AdminCH";
            this.grb_AdminCH.Size = new System.Drawing.Size(372, 274);
            this.grb_AdminCH.TabIndex = 13;
            this.grb_AdminCH.TabStop = false;
            this.grb_AdminCH.Text = "管理员";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4915Project.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // AdminCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grb_AdminCH);
            this.Controls.Add(this.btn_AdminEditCH);
            this.Controls.Add(this.lnk_AdminENG);
            this.Controls.Add(this.btn_AdminLogoutCH);
            this.Name = "AdminCH";
            this.Text = "Better Limited";
            this.Load += new System.EventHandler(this.AdminCH_Load);
            this.grb_AdminCH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AdminStaffCH;
        private System.Windows.Forms.Button btn_AdminProductCH;
        private System.Windows.Forms.Button btn_AdminRetailStoreCH;
        private System.Windows.Forms.Button btn_AdminSupplierCH;
        private System.Windows.Forms.Button btn_AdminLogoutCH;
        private System.Windows.Forms.LinkLabel lnk_AdminENG;
        private System.Windows.Forms.Button btn_AdminEditCH;
        private System.Windows.Forms.GroupBox grb_AdminCH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}