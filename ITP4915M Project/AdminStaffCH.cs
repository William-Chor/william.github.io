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
    public partial class AdminStaffCH : Form
    {
        String staffdetailsch = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}{7,-20}";
        public AdminStaffCH()
        {
            InitializeComponent();
        }

        private void AdminStaffCH_Load(object sender, EventArgs e)
        {
            lstAdminStaffCH.Items.Add(String.Format(staffdetailsch, "号码", "名字", "密码", "电话号码", "地址", "出生日期", "月薪", "部门"));
            using (Entitie content = new Entitie())
            {
                var staffresultch = content.account;
                if (staffresultch != null)
                {
                    var ls = staffresultch.ToList();
                    foreach (account ac in ls)
                    {
                        lstAdminStaffCH.Items.Add(String.Format(staffdetailsch, ac.AccountID, ac.Acc_Username, ac.Acc_Password, ac.Acc_PhoneNumber, ac.Acc_Address, ac.Acc_DOB, ac.Salary, ac.DepartmentName));
                    }
                }
            }
        }

        private void btn_AdminStaffAddCH_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                account PasswordRepeated = content.account.SingleOrDefault(i => i.Acc_Password == txt_AdminStaffPasswordCH.Text);
                if (txt_AdminStaffPasswordCH.Text == "" || txt_AdminStaffNameCH.Text == "" || txt_AdminStaffAddressCH.Text == "" || cbo_AdminDepartmentCH.Text == "" || txt_AdminStaffPhonenumberCH.Text == "" || txt_AdminStaffSalaryCH.Text == "")
                {
                    MessageBox.Show("请填写所有空格");
                }
                else if (PasswordRepeated != null)
                {
                    MessageBox.Show("密码已经被人用了，请用其他密码");
                    txt_AdminStaffPasswordCH.Clear();
                }
                else
                {
                    account ac = new account
                    {
                        Acc_Username = txt_AdminStaffNameCH.Text,
                        Acc_Password = txt_AdminStaffPasswordCH.Text,
                        Acc_PhoneNumber = txt_AdminStaffPhonenumberCH.Text,
                        Acc_Address = txt_AdminStaffAddressCH.Text,
                        Acc_status = 0,
                        Salary = txt_AdminStaffSalaryCH.Text,
                        DepartmentName = cbo_AdminDepartmentCH.Text,
                        Acc_DOB = dateTimePicker_AdminStaffDOBCH.Value,
                        AccountID = 0
                    };
                    content.account.Add(ac);
                    content.SaveChanges();
                    ac.Acc_PhoneNumber = txt_AdminStaffPhonenumberCH.Text;
                    ac.Acc_Address = txt_AdminStaffAddressCH.Text;
                    ac.Acc_DOB = dateTimePicker_AdminStaffDOBCH.Value;
                    ac.Acc_Password = txt_AdminStaffPasswordCH.Text;
                    ac.Acc_Username = txt_AdminStaffNameCH.Text;
                    ac.DepartmentName = cbo_AdminDepartmentCH.Text;
                    ac.Salary = txt_AdminStaffSalaryCH.Text;
                    ac.AccountID = lstAdminStaffCH.Items.Count;
                    lstAdminStaffCH.Items.Add(String.Format(staffdetailsch, ac.AccountID, ac.Acc_Username, ac.Acc_Password, ac.Acc_PhoneNumber, ac.Acc_Address, ac.Acc_DOB, ac.Salary, ac.DepartmentName));
                    AdminStaffCH ASCH = new AdminStaffCH();
                    ASCH.Show();
                    this.Hide();
                    MessageBox.Show("加入成功");
                }
            }
        }

        private void btn_AdminStaffUpdateCH_Click(object sender, EventArgs e)
        {
            Boolean Orignal = false;
            int index = lstAdminStaffCH.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                account EditAC = content.account.SingleOrDefault(i => i.Acc_Username == Login.staffACName);
                account AdminStaffPasswordRepeated = content.account.SingleOrDefault(i => i.Acc_Password == txt_AdminStaffPasswordCH.Text);
                if (EditAC.Acc_Password == txt_AdminStaffPasswordCH.Text)
                {
                    Orignal = true;
                }
                if (AdminStaffPasswordRepeated != null && Orignal == false)
                {
                    MessageBox.Show("密码已经被人用了，请用其他密码");
                    txt_AdminStaffPasswordCH.Clear();
                }
                else if (index == -1)
                {
                    MessageBox.Show("请选择一项资料");
                }
                else
                {
                    account ac = new account();
                    ac.Acc_PhoneNumber = txt_AdminStaffPhonenumberCH.Text;
                    ac.Acc_Address = txt_AdminStaffAddressCH.Text;
                    ac.Acc_DOB = dateTimePicker_AdminStaffDOBCH.Value;
                    ac.Acc_Password = txt_AdminStaffPasswordCH.Text;
                    ac.Acc_Username = txt_AdminStaffNameCH.Text;
                    ac.DepartmentName = cbo_AdminDepartmentCH.Text;
                    ac.Salary = txt_AdminStaffSalaryCH.Text;
                    ac.AccountID = index;
                    content.SaveChanges();
                    lstAdminStaffCH.Items.RemoveAt(index);
                    lstAdminStaffCH.Items.Insert(index, String.Format(staffdetailsch, ac.AccountID, ac.Acc_Username, ac.Acc_Password, ac.Acc_PhoneNumber, ac.Acc_Address, ac.Acc_DOB, ac.Salary, ac.DepartmentName));
                    ac = content.account.SingleOrDefault(i => i.AccountID == index);
                    if (ac != null)
                    {
                        ac.Acc_PhoneNumber = txt_AdminStaffPhonenumberCH.Text;
                        ac.Acc_Address = txt_AdminStaffAddressCH.Text;
                        ac.Acc_DOB = dateTimePicker_AdminStaffDOBCH.Value;
                        ac.Acc_Password = txt_AdminStaffPasswordCH.Text;
                        ac.Acc_Username = txt_AdminStaffNameCH.Text;
                        ac.DepartmentName = cbo_AdminDepartmentCH.Text;
                        ac.Salary = txt_AdminStaffSalaryCH.Text;
                        content.SaveChanges();
                    }
                    AdminStaffCH ASCH = new AdminStaffCH();
                    ASCH.Show();
                    this.Hide();
                    MessageBox.Show("更新成功");
                }
            }
        }

        private void btn_AdminStaffDeleteCH_Click(object sender, EventArgs e)
        {
            int index = lstAdminStaffCH.SelectedIndex;
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
                    AdminStaffCH ASCH = new AdminStaffCH();
                    ASCH.Show();
                    this.Hide();
                    MessageBox.Show("删除成功");
                }
            }
        }

        private void btn_AdminStaffBackCH_Click(object sender, EventArgs e)
        {
            AdminCH admch = new AdminCH();
            admch.Show();
            this.Hide();
        }
    }
}
