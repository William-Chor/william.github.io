namespace _4915Project
{
    partial class admin_management
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
            this.btn_AdminStaff = new System.Windows.Forms.Button();
            this.btn_AdminRetailStore = new System.Windows.Forms.Button();
            this.btn_AdminProduct = new System.Windows.Forms.Button();
            this.btn_AdminSupplier = new System.Windows.Forms.Button();
            this.btn_AdminLogout = new System.Windows.Forms.Button();
            this.lnk_AdminCH = new System.Windows.Forms.LinkLabel();
            this.btn_AdminEdit = new System.Windows.Forms.Button();
            this.grb_Admin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AdminStaff
            // 
            this.btn_AdminStaff.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminStaff.Location = new System.Drawing.Point(20, 58);
            this.btn_AdminStaff.Name = "btn_AdminStaff";
            this.btn_AdminStaff.Size = new System.Drawing.Size(116, 62);
            this.btn_AdminStaff.TabIndex = 0;
            this.btn_AdminStaff.Text = "Staff";
            this.btn_AdminStaff.UseVisualStyleBackColor = true;
            this.btn_AdminStaff.Click += new System.EventHandler(this.btn_AdminStaff_Click);
            // 
            // btn_AdminRetailStore
            // 
            this.btn_AdminRetailStore.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_AdminRetailStore.Location = new System.Drawing.Point(20, 157);
            this.btn_AdminRetailStore.Name = "btn_AdminRetailStore";
            this.btn_AdminRetailStore.Size = new System.Drawing.Size(116, 62);
            this.btn_AdminRetailStore.TabIndex = 1;
            this.btn_AdminRetailStore.Text = "Retail Store";
            this.btn_AdminRetailStore.UseVisualStyleBackColor = true;
            this.btn_AdminRetailStore.Click += new System.EventHandler(this.btn_AdminRetailStore_Click);
            // 
            // btn_AdminProduct
            // 
            this.btn_AdminProduct.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_AdminProduct.Location = new System.Drawing.Point(183, 58);
            this.btn_AdminProduct.Name = "btn_AdminProduct";
            this.btn_AdminProduct.Size = new System.Drawing.Size(116, 62);
            this.btn_AdminProduct.TabIndex = 2;
            this.btn_AdminProduct.Text = "Product";
            this.btn_AdminProduct.UseVisualStyleBackColor = true;
            this.btn_AdminProduct.Click += new System.EventHandler(this.btn_AdminProduct_Click);
            // 
            // btn_AdminSupplier
            // 
            this.btn_AdminSupplier.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_AdminSupplier.Location = new System.Drawing.Point(183, 157);
            this.btn_AdminSupplier.Name = "btn_AdminSupplier";
            this.btn_AdminSupplier.Size = new System.Drawing.Size(116, 62);
            this.btn_AdminSupplier.TabIndex = 3;
            this.btn_AdminSupplier.Text = "Supplier";
            this.btn_AdminSupplier.UseVisualStyleBackColor = true;
            this.btn_AdminSupplier.Click += new System.EventHandler(this.btn_AdminSupplier_Click);
            // 
            // btn_AdminLogout
            // 
            this.btn_AdminLogout.Location = new System.Drawing.Point(389, 347);
            this.btn_AdminLogout.Name = "btn_AdminLogout";
            this.btn_AdminLogout.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminLogout.TabIndex = 5;
            this.btn_AdminLogout.Text = "Logout";
            this.btn_AdminLogout.UseVisualStyleBackColor = true;
            this.btn_AdminLogout.Click += new System.EventHandler(this.btn_AdminLogout_Click);
            // 
            // lnk_AdminCH
            // 
            this.lnk_AdminCH.AutoSize = true;
            this.lnk_AdminCH.Location = new System.Drawing.Point(435, 9);
            this.lnk_AdminCH.Name = "lnk_AdminCH";
            this.lnk_AdminCH.Size = new System.Drawing.Size(29, 12);
            this.lnk_AdminCH.TabIndex = 6;
            this.lnk_AdminCH.TabStop = true;
            this.lnk_AdminCH.Text = "中文";
            this.lnk_AdminCH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_AdminCH_LinkClicked);
            // 
            // btn_AdminEdit
            // 
            this.btn_AdminEdit.Location = new System.Drawing.Point(53, 347);
            this.btn_AdminEdit.Name = "btn_AdminEdit";
            this.btn_AdminEdit.Size = new System.Drawing.Size(153, 23);
            this.btn_AdminEdit.TabIndex = 7;
            this.btn_AdminEdit.Text = "Edit Personal Information ";
            this.btn_AdminEdit.UseVisualStyleBackColor = true;
            this.btn_AdminEdit.Click += new System.EventHandler(this.btn_AdminEdit_Click);
            // 
            // grb_Admin
            // 
            this.grb_Admin.Controls.Add(this.btn_AdminStaff);
            this.grb_Admin.Controls.Add(this.btn_AdminProduct);
            this.grb_Admin.Controls.Add(this.btn_AdminRetailStore);
            this.grb_Admin.Controls.Add(this.btn_AdminSupplier);
            this.grb_Admin.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_Admin.Location = new System.Drawing.Point(101, 44);
            this.grb_Admin.Name = "grb_Admin";
            this.grb_Admin.Size = new System.Drawing.Size(325, 267);
            this.grb_Admin.TabIndex = 8;
            this.grb_Admin.TabStop = false;
            this.grb_Admin.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4915Project.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // admin_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grb_Admin);
            this.Controls.Add(this.btn_AdminEdit);
            this.Controls.Add(this.lnk_AdminCH);
            this.Controls.Add(this.btn_AdminLogout);
            this.Name = "admin_management";
            this.Text = "Better Limited";
            this.Load += new System.EventHandler(this.admin_management_Load);
            this.grb_Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AdminStaff;
        private System.Windows.Forms.Button btn_AdminRetailStore;
        private System.Windows.Forms.Button btn_AdminProduct;
        private System.Windows.Forms.Button btn_AdminSupplier;
        private System.Windows.Forms.Button btn_AdminLogout;
        private System.Windows.Forms.LinkLabel lnk_AdminCH;
        private System.Windows.Forms.Button btn_AdminEdit;
        private System.Windows.Forms.GroupBox grb_Admin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}