using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915Project
{
    public partial class AdminStaff : Form
    {
        String staffdetails = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}{7,-20}";
        public AdminStaff()
        {
            InitializeComponent();
        }

        private void AdminStaff_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;

            lstAdminStaff.Items.Add(String.Format(staffdetails, "ID", "Username", "Password", "Phone number", "Address", "DOB", "Salary", "Department"));
            using (Entitie content = new Entitie())
            {
                var staffresult = content.account;
                if (staffresult != null)
                {
                    var ls = staffresult.ToList();
                    foreach (account ac in ls)
                    {
                        lstAdminStaff.Items.Add(String.Format(staffdetails, ac.AccountID, ac.Acc_Username, ac.Acc_Password, ac.Acc_PhoneNumber, ac.Acc_Address, ac.Acc_DOB, ac.Salary, ac.DepartmentName));
                    }
                }
            }
        }

        private void lstAdminStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_AdminStaffAdd_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                account PasswordRepeated = content.account.SingleOrDefault(i => i.Acc_Password == txt_AdminStaffPassword.Text);
                if (txt_AdminStaffPassword.Text == "" || txt_AdminStaffName.Text == ""|| txt_AdminStaffAddress.Text=="" || cbo_AdminDepartment.Text=="" || txt_AdminStaffPhonenumber.Text==""|| txt_AdminStaffSalary.Text =="")
                {
                    MessageBox.Show("Please fill all the information");
                }
                else if (PasswordRepeated != null)
                {
                    MessageBox.Show("Password have been use, please enter a new password");
                    txt_AdminStaffPassword.Clear();
                }
                else
                {
                    account ac = new account
                    {
                        Acc_Username = txt_AdminStaffName.Text,
                        Acc_Password = txt_AdminStaffPassword.Text,
                        Acc_PhoneNumber = txt_AdminStaffPhonenumber.Text,
                        Acc_Address = txt_AdminStaffAddress.Text,
                        Acc_status = 0,
                        Salary = txt_AdminStaffSalary.Text,
                        DepartmentName = cbo_AdminDepartment.Text,
                        Acc_DOB = dateTimePicker_AdminStaffDOB.Value,
                        AccountID = 0
                    };
                    content.account.Add(ac);
                    content.SaveChanges();
                    ac.Acc_PhoneNumber = txt_AdminStaffPhonenumber.Text;
                    ac.Acc_Address = txt_AdminStaffAddress.Text;
                    ac.Acc_DOB = dateTimePicker_AdminStaffDOB.Value;
                    ac.Acc_Password = txt_AdminStaffPassword.Text;
                    ac.Acc_Username = txt_AdminStaffName.Text;
                    ac.DepartmentName = cbo_AdminDepartment.Text;
                    ac.Salary = txt_AdminStaffSalary.Text;
                    ac.AccountID = lstAdminStaff.Items.Count;
                    lstAdminStaff.Items.Add(String.Format(staffdetails, ac.AccountID, ac.Acc_Username, ac.Acc_Password, ac.Acc_PhoneNumber, ac.Acc_Address, ac.Acc_DOB, ac.Salary, ac.DepartmentName));
                    AdminStaff AS = new AdminStaff();
                    AS.Show();
                    this.Hide();
                    MessageBox.Show("Add Successfully");
                }
            }
        }

        private void btn_AdminStaffUpdate_Click(object sender, EventArgs e)
        {
            int index = lstAdminStaff.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                account AdminStaffPasswordRepeated = content.account.SingleOrDefault(i => i.Acc_Password == txt_AdminStaffPassword.Text);
                if (AdminStaffPasswordRepeated != null)
                {
                    MessageBox.Show("Password have been use, please enter a new password");
                    txt_AdminStaffPassword.Clear();
                }
                else if (index == -1)
                {
                    MessageBox.Show("Please select a data");
                }
                else
                {
                    account ac = new account();
                    ac.Acc_PhoneNumber = txt_AdminStaffPhonenumber.Text;
                    ac.Acc_Address = txt_AdminStaffAddress.Text;
                    ac.Acc_DOB = dateTimePicker_AdminStaffDOB.Value;
                    ac.Acc_Password = txt_AdminStaffPassword.Text;
                    ac.Acc_Username = txt_AdminStaffName.Text;
                    ac.DepartmentName = cbo_AdminDepartment.Text;
                    ac.Salary = txt_AdminStaffSalary.Text;
                    ac.AccountID = index;
                    content.SaveChanges();
                    lstAdminStaff.Items.RemoveAt(index);
                    lstAdminStaff.Items.Insert(index, String.Format(staffdetails, ac.AccountID, ac.Acc_Username, ac.Acc_Password, ac.Acc_PhoneNumber, ac.Acc_Address, ac.Acc_DOB, ac.Salary, ac.DepartmentName));
                    ac = content.account.SingleOrDefault(i => i.AccountID == index);
                    if (ac != null)
                    {
                        ac.Acc_PhoneNumber = txt_AdminStaffPhonenumber.Text;
                        ac.Acc_Address = txt_AdminStaffAddress.Text;
                        ac.Acc_DOB = dateTimePicker_AdminStaffDOB.Value;
                        ac.Acc_Password = txt_AdminStaffPassword.Text;
                        ac.Acc_Username = txt_AdminStaffName.Text;
                        ac.DepartmentName = cbo_AdminDepartment.Text;
                        ac.Salary = txt_AdminStaffSalary.Text;
                        content.SaveChanges();
                        AdminStaff AS = new AdminStaff();
                        AS.Show();
                        this.Hide();
                        MessageBox.Show("Update Successfully");
                    }
                }
            }
        }

        private void btn_AdminStaffDelete_Click(object sender, EventArgs e)
        {
            int index = lstAdminStaff.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("Please select a data");
                }
                else
                {
                    account ac = new account();
                    ac = content.account.SingleOrDefault(i => i.AccountID == index);
                    if (ac != null)
                    {
                        ac.DepartmentName = "";
                        ac.Salary = "";
                        content.SaveChanges();
                    }
                    AdminStaff AS = new AdminStaff();
                    AS.Show();
                    this.Hide();
                    MessageBox.Show("Delete Successfully");
                }
            }

        }

        private void btn_AdminStaffBack_Click(object sender, EventArgs e)
        {
            admin_management ADM = new admin_management();
            ADM.Show();
            this.Hide();
        }
    }
}
