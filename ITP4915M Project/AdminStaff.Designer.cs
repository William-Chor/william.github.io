namespace _4915Project
{
    partial class AdminStaff
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
            this.lstAdminStaff = new System.Windows.Forms.ListBox();
            this.lbl_AdminStaffName = new System.Windows.Forms.Label();
            this.lbl_AdminStaffPassword = new System.Windows.Forms.Label();
            this.lbl_AdminStaffPhonenumber = new System.Windows.Forms.Label();
            this.lbl_AdminStaffAddress = new System.Windows.Forms.Label();
            this.lbl_AdminStaffDOB = new System.Windows.Forms.Label();
            this.lbl_AdminStaffSalary = new System.Windows.Forms.Label();
            this.lbl_AdminStaffDepartmentname = new System.Windows.Forms.Label();
            this.txt_AdminStaffAddress = new System.Windows.Forms.TextBox();
            this.txt_AdminStaffPhonenumber = new System.Windows.Forms.TextBox();
            this.txt_AdminStaffPassword = new System.Windows.Forms.TextBox();
            this.txt_AdminStaffName = new System.Windows.Forms.TextBox();
            this.txt_AdminStaffSalary = new System.Windows.Forms.TextBox();
            this.dateTimePicker_AdminStaffDOB = new System.Windows.Forms.DateTimePicker();
            this.btn_AdminStaffAdd = new System.Windows.Forms.Button();
            this.btn_AdminStaffUpdate = new System.Windows.Forms.Button();
            this.btn_AdminStaffDelete = new System.Windows.Forms.Button();
            this.btn_AdminStaffBack = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.grb_AdminStaffTitle = new System.Windows.Forms.GroupBox();
            this.cbo_AdminDepartment = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_AdminStaffTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAdminStaff
            // 
            this.lstAdminStaff.FormattingEnabled = true;
            this.lstAdminStaff.ItemHeight = 12;
            this.lstAdminStaff.Location = new System.Drawing.Point(12, 330);
            this.lstAdminStaff.Name = "lstAdminStaff";
            this.lstAdminStaff.Size = new System.Drawing.Size(776, 256);
            this.lstAdminStaff.TabIndex = 0;
            this.lstAdminStaff.SelectedIndexChanged += new System.EventHandler(this.lstAdminStaff_SelectedIndexChanged);
            // 
            // lbl_AdminStaffName
            // 
            this.lbl_AdminStaffName.AutoSize = true;
            this.lbl_AdminStaffName.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_AdminStaffName.Location = new System.Drawing.Point(6, 57);
            this.lbl_AdminStaffName.Name = "lbl_AdminStaffName";
            this.lbl_AdminStaffName.Size = new System.Drawing.Size(36, 12);
            this.lbl_AdminStaffName.TabIndex = 2;
            this.lbl_AdminStaffName.Text = "Name";
            this.lbl_AdminStaffName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_AdminStaffPassword
            // 
            this.lbl_AdminStaffPassword.AutoSize = true;
            this.lbl_AdminStaffPassword.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_AdminStaffPassword.Location = new System.Drawing.Point(6, 98);
            this.lbl_AdminStaffPassword.Name = "lbl_AdminStaffPassword";
            this.lbl_AdminStaffPassword.Size = new System.Drawing.Size(56, 12);
            this.lbl_AdminStaffPassword.TabIndex = 3;
            this.lbl_AdminStaffPassword.Text = "Password";
            // 
            // lbl_AdminStaffPhonenumber
            // 
            this.lbl_AdminStaffPhonenumber.AutoSize = true;
            this.lbl_AdminStaffPhonenumber.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_AdminStaffPhonenumber.Location = new System.Drawing.Point(6, 145);
            this.lbl_AdminStaffPhonenumber.Name = "lbl_AdminStaffPhonenumber";
            this.lbl_AdminStaffPhonenumber.Size = new System.Drawing.Size(85, 12);
            this.lbl_AdminStaffPhonenumber.TabIndex = 4;
            this.lbl_AdminStaffPhonenumber.Text = "Phone number";
            // 
            // lbl_AdminStaffAddress
            // 
            this.lbl_AdminStaffAddress.AutoSize = true;
            this.lbl_AdminStaffAddress.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_AdminStaffAddress.Location = new System.Drawing.Point(269, 54);
            this.lbl_AdminStaffAddress.Name = "lbl_AdminStaffAddress";
            this.lbl_AdminStaffAddress.Size = new System.Drawing.Size(49, 12);
            this.lbl_AdminStaffAddress.TabIndex = 5;
            this.lbl_AdminStaffAddress.Text = "Address";
            // 
            // lbl_AdminStaffDOB
            // 
            this.lbl_AdminStaffDOB.AutoSize = true;
            this.lbl_AdminStaffDOB.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_AdminStaffDOB.Location = new System.Drawing.Point(6, 189);
            this.lbl_AdminStaffDOB.Name = "lbl_AdminStaffDOB";
            this.lbl_AdminStaffDOB.Size = new System.Drawing.Size(32, 12);
            this.lbl_AdminStaffDOB.TabIndex = 6;
            this.lbl_AdminStaffDOB.Text = "DOB";
            // 
            // lbl_AdminStaffSalary
            // 
            this.lbl_AdminStaffSalary.AutoSize = true;
            this.lbl_AdminStaffSalary.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_AdminStaffSalary.Location = new System.Drawing.Point(269, 98);
            this.lbl_AdminStaffSalary.Name = "lbl_AdminStaffSalary";
            this.lbl_AdminStaffSalary.Size = new System.Drawing.Size(40, 12);
            this.lbl_AdminStaffSalary.TabIndex = 7;
            this.lbl_AdminStaffSalary.Text = "Salary";
            // 
            // lbl_AdminStaffDepartmentname
            // 
            this.lbl_AdminStaffDepartmentname.AutoSize = true;
            this.lbl_AdminStaffDepartmentname.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_AdminStaffDepartmentname.Location = new System.Drawing.Point(269, 145);
            this.lbl_AdminStaffDepartmentname.Name = "lbl_AdminStaffDepartmentname";
            this.lbl_AdminStaffDepartmentname.Size = new System.Drawing.Size(69, 12);
            this.lbl_AdminStaffDepartmentname.TabIndex = 8;
            this.lbl_AdminStaffDepartmentname.Text = "Department";
            // 
            // txt_AdminStaffAddress
            // 
            this.txt_AdminStaffAddress.Font = new System.Drawing.Font("新細明體", 9F);
            this.txt_AdminStaffAddress.Location = new System.Drawing.Point(360, 54);
            this.txt_AdminStaffAddress.Name = "txt_AdminStaffAddress";
            this.txt_AdminStaffAddress.Size = new System.Drawing.Size(100, 22);
            this.txt_AdminStaffAddress.TabIndex = 12;
            // 
            // txt_AdminStaffPhonenumber
            // 
            this.txt_AdminStaffPhonenumber.Font = new System.Drawing.Font("新細明體", 9F);
            this.txt_AdminStaffPhonenumber.Location = new System.Drawing.Point(117, 142);
            this.txt_AdminStaffPhonenumber.Name = "txt_AdminStaffPhonenumber";
            this.txt_AdminStaffPhonenumber.Size = new System.Drawing.Size(100, 22);
            this.txt_AdminStaffPhonenumber.TabIndex = 14;
            // 
            // txt_AdminStaffPassword
            // 
            this.txt_AdminStaffPassword.Font = new System.Drawing.Font("新細明體", 9F);
            this.txt_AdminStaffPassword.Location = new System.Drawing.Point(117, 95);
            this.txt_AdminStaffPassword.Name = "txt_AdminStaffPassword";
            this.txt_AdminStaffPassword.Size = new System.Drawing.Size(100, 22);
            this.txt_AdminStaffPassword.TabIndex = 15;
            // 
            // txt_AdminStaffName
            // 
            this.txt_AdminStaffName.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_AdminStaffName.Location = new System.Drawing.Point(117, 54);
            this.txt_AdminStaffName.Name = "txt_AdminStaffName";
            this.txt_AdminStaffName.Size = new System.Drawing.Size(100, 22);
            this.txt_AdminStaffName.TabIndex = 16;
            // 
            // txt_AdminStaffSalary
            // 
            this.txt_AdminStaffSalary.Font = new System.Drawing.Font("新細明體", 9F);
            this.txt_AdminStaffSalary.Location = new System.Drawing.Point(360, 95);
            this.txt_AdminStaffSalary.Name = "txt_AdminStaffSalary";
            this.txt_AdminStaffSalary.Size = new System.Drawing.Size(100, 22);
            this.txt_AdminStaffSalary.TabIndex = 17;
            // 
            // dateTimePicker_AdminStaffDOB
            // 
            this.dateTimePicker_AdminStaffDOB.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_AdminStaffDOB.Font = new System.Drawing.Font("新細明體", 9F);
            this.dateTimePicker_AdminStaffDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_AdminStaffDOB.Location = new System.Drawing.Point(117, 189);
            this.dateTimePicker_AdminStaffDOB.Name = "dateTimePicker_AdminStaffDOB";
            this.dateTimePicker_AdminStaffDOB.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker_AdminStaffDOB.TabIndex = 18;
            // 
            // btn_AdminStaffAdd
            // 
            this.btn_AdminStaffAdd.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AdminStaffAdd.Location = new System.Drawing.Point(16, 247);
            this.btn_AdminStaffAdd.Name = "btn_AdminStaffAdd";
            this.btn_AdminStaffAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminStaffAdd.TabIndex = 19;
            this.btn_AdminStaffAdd.Text = "Add";
            this.btn_AdminStaffAdd.UseVisualStyleBackColor = true;
            this.btn_AdminStaffAdd.Click += new System.EventHandler(this.btn_AdminStaffAdd_Click);
            // 
            // btn_AdminStaffUpdate
            // 
            this.btn_AdminStaffUpdate.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AdminStaffUpdate.Location = new System.Drawing.Point(202, 247);
            this.btn_AdminStaffUpdate.Name = "btn_AdminStaffUpdate";
            this.btn_AdminStaffUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminStaffUpdate.TabIndex = 20;
            this.btn_AdminStaffUpdate.Text = "Update";
            this.btn_AdminStaffUpdate.UseVisualStyleBackColor = true;
            this.btn_AdminStaffUpdate.Click += new System.EventHandler(this.btn_AdminStaffUpdate_Click);
            // 
            // btn_AdminStaffDelete
            // 
            this.btn_AdminStaffDelete.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AdminStaffDelete.Location = new System.Drawing.Point(385, 247);
            this.btn_AdminStaffDelete.Name = "btn_AdminStaffDelete";
            this.btn_AdminStaffDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminStaffDelete.TabIndex = 21;
            this.btn_AdminStaffDelete.Text = "Delete";
            this.btn_AdminStaffDelete.UseVisualStyleBackColor = true;
            this.btn_AdminStaffDelete.Click += new System.EventHandler(this.btn_AdminStaffDelete_Click);
            // 
            // btn_AdminStaffBack
            // 
            this.btn_AdminStaffBack.Location = new System.Drawing.Point(713, 592);
            this.btn_AdminStaffBack.Name = "btn_AdminStaffBack";
            this.btn_AdminStaffBack.Size = new System.Drawing.Size(75, 34);
            this.btn_AdminStaffBack.TabIndex = 22;
            this.btn_AdminStaffBack.Text = "Back";
            this.btn_AdminStaffBack.UseVisualStyleBackColor = true;
            this.btn_AdminStaffBack.Click += new System.EventHandler(this.btn_AdminStaffBack_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(768, 330);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 256);
            this.vScrollBar1.TabIndex = 23;
            // 
            // grb_AdminStaffTitle
            // 
            this.grb_AdminStaffTitle.Controls.Add(this.cbo_AdminDepartment);
            this.grb_AdminStaffTitle.Controls.Add(this.txt_AdminStaffName);
            this.grb_AdminStaffTitle.Controls.Add(this.lbl_AdminStaffName);
            this.grb_AdminStaffTitle.Controls.Add(this.lbl_AdminStaffPassword);
            this.grb_AdminStaffTitle.Controls.Add(this.btn_AdminStaffDelete);
            this.grb_AdminStaffTitle.Controls.Add(this.lbl_AdminStaffPhonenumber);
            this.grb_AdminStaffTitle.Controls.Add(this.btn_AdminStaffUpdate);
            this.grb_AdminStaffTitle.Controls.Add(this.lbl_AdminStaffAddress);
            this.grb_AdminStaffTitle.Controls.Add(this.btn_AdminStaffAdd);
            this.grb_AdminStaffTitle.Controls.Add(this.lbl_AdminStaffDOB);
            this.grb_AdminStaffTitle.Controls.Add(this.dateTimePicker_AdminStaffDOB);
            this.grb_AdminStaffTitle.Controls.Add(this.lbl_AdminStaffSalary);
            this.grb_AdminStaffTitle.Controls.Add(this.txt_AdminStaffSalary);
            this.grb_AdminStaffTitle.Controls.Add(this.lbl_AdminStaffDepartmentname);
            this.grb_AdminStaffTitle.Controls.Add(this.txt_AdminStaffAddress);
            this.grb_AdminStaffTitle.Controls.Add(this.txt_AdminStaffPassword);
            this.grb_AdminStaffTitle.Controls.Add(this.txt_AdminStaffPhonenumber);
            this.grb_AdminStaffTitle.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_AdminStaffTitle.Location = new System.Drawing.Point(143, 23);
            this.grb_AdminStaffTitle.Name = "grb_AdminStaffTitle";
            this.grb_AdminStaffTitle.Size = new System.Drawing.Size(585, 289);
            this.grb_AdminStaffTitle.TabIndex = 24;
            this.grb_AdminStaffTitle.TabStop = false;
            this.grb_AdminStaffTitle.Text = "Staff";
            // 
            // cbo_AdminDepartment
            // 
            this.cbo_AdminDepartment.Font = new System.Drawing.Font("新細明體", 9F);
            this.cbo_AdminDepartment.FormattingEnabled = true;
            this.cbo_AdminDepartment.Items.AddRange(new object[] {
            "Admin Department",
            "Sales Department",
            "Accounting Department",
            "Purchase Department",
            "Delivery",
            "Technical Support Department",
            "Inventory Department"});
            this.cbo_AdminDepartment.Location = new System.Drawing.Point(360, 142);
            this.cbo_AdminDepartment.Name = "cbo_AdminDepartment";
            this.cbo_AdminDepartment.Size = new System.Drawing.Size(201, 20);
            this.cbo_AdminDepartment.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4915Project.Properties.Resources.staff;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // AdminStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grb_AdminStaffTitle);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btn_AdminStaffBack);
            this.Controls.Add(this.lstAdminStaff);
            this.Name = "AdminStaff";
            this.Text = "Better Limited";
            this.Load += new System.EventHandler(this.AdminStaff_Load);
            this.grb_AdminStaffTitle.ResumeLayout(false);
            this.grb_AdminStaffTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstAdminStaff;
        private System.Windows.Forms.Label lbl_AdminStaffName;
        private System.Windows.Forms.Label lbl_AdminStaffPassword;
        private System.Windows.Forms.Label lbl_AdminStaffPhonenumber;
        private System.Windows.Forms.Label lbl_AdminStaffAddress;
        private System.Windows.Forms.Label lbl_AdminStaffDOB;
        private System.Windows.Forms.Label lbl_AdminStaffSalary;
        private System.Windows.Forms.Label lbl_AdminStaffDepartmentname;
        private System.Windows.Forms.TextBox txt_AdminStaffAddress;
        private System.Windows.Forms.TextBox txt_AdminStaffPhonenumber;
        private System.Windows.Forms.TextBox txt_AdminStaffPassword;
        private System.Windows.Forms.TextBox txt_AdminStaffName;
        private System.Windows.Forms.TextBox txt_AdminStaffSalary;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AdminStaffDOB;
        private System.Windows.Forms.Button btn_AdminStaffAdd;
        private System.Windows.Forms.Button btn_AdminStaffUpdate;
        private System.Windows.Forms.Button btn_AdminStaffDelete;
        private System.Windows.Forms.Button btn_AdminStaffBack;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox grb_AdminStaffTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_AdminDepartment;
    }
}