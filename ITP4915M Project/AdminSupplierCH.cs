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
    public partial class AdminSupplierCH : Form
    {
        String supplierdetailsch = "{0,-10}{1,-20}{2,-20}{3,-20}";
        public AdminSupplierCH()
        {
            InitializeComponent();
        }

        private void AdminSupplierCH_Load(object sender, EventArgs e)
        {
            lst_AdminSupplierCH.Items.Add(String.Format(supplierdetailsch, "号码", "名字", "电话号码", "地址"));
            using (Entitie content = new Entitie())
            {
                var supplierresultch = content.supplier;
                if (supplierresultch != null)
                {
                    var ls = supplierresultch.ToList();
                    foreach (supplier supp in ls)
                    {
                        lst_AdminSupplierCH.Items.Add(String.Format(supplierdetailsch, supp.SupplierID, supp.SupplierName, supp.SupplierPhonenumber, supp.SupplierAddress));
                    }
                }
            }
        }

        private void btn_AdminSupplierAddCH_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                supplier NameRepeated = content.supplier.SingleOrDefault(i => i.SupplierName == txt_AdminSupplierNameCH.Text);
                if (txt_AdminSupplierAddressCH.Text == "" || txt_AdminSupplierNameCH.Text == "" || txt_AdminSupplierPhonenubmerCH.Text == "")
                {
                    MessageBox.Show("请填写所有空格");
                }
                else if (NameRepeated != null)
                {
                    MessageBox.Show("名字已经被人用了，请用其他名字");
                    txt_AdminSupplierNameCH.Clear();
                }
                else
                {
                    supplier supp = new supplier
                    {
                        SupplierAddress = txt_AdminSupplierAddressCH.Text,
                        SupplierName = txt_AdminSupplierNameCH.Text,
                        SupplierPhonenumber = txt_AdminSupplierPhonenubmerCH.Text,
                        SupplierID = 0
                    };
                    content.supplier.Add(supp);
                    content.SaveChanges();

                    supp.SupplierName = txt_AdminSupplierNameCH.Text;
                    supp.SupplierPhonenumber = txt_AdminSupplierPhonenubmerCH.Text;
                    supp.SupplierAddress = txt_AdminSupplierAddressCH.Text;
                    supp.SupplierID = lst_AdminSupplierCH.Items.Count;

                    lst_AdminSupplierCH.Items.Add(String.Format(supplierdetailsch, supp.SupplierID, supp.SupplierName, supp.SupplierPhonenumber, supp.SupplierAddress));
                    AdminSupplierCH ASUPPCH = new AdminSupplierCH();
                    ASUPPCH.Show();
                    this.Hide();
                    MessageBox.Show("加入成功");

                }
            }
        }

        private void btn_AdminSupplierUpdateCH_Click(object sender, EventArgs e)
        {
            int index = lst_AdminSupplierCH.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("请选择一项资料");
                }
                else
                {
                    supplier supp = new supplier();
                    supp.SupplierName = txt_AdminSupplierNameCH.Text;
                    supp.SupplierPhonenumber = txt_AdminSupplierPhonenubmerCH.Text;
                    supp.SupplierAddress = txt_AdminSupplierAddressCH.Text;
                    supp.SupplierID = index;
                    lst_AdminSupplierCH.Items.RemoveAt(index);
                    lst_AdminSupplierCH.Items.Insert(index, String.Format(supplierdetailsch, supp.SupplierID, supp.SupplierName, supp.SupplierPhonenumber, supp.SupplierAddress));
                    supp = content.supplier.SingleOrDefault(i => i.SupplierID == index);
                    if (supp != null)
                    {
                        supp.SupplierName = txt_AdminSupplierNameCH.Text;
                        supp.SupplierPhonenumber = txt_AdminSupplierPhonenubmerCH.Text;
                        supp.SupplierAddress = txt_AdminSupplierAddressCH.Text;
                        content.SaveChanges();
                    }
                    AdminSupplierCH ASUPPCH = new AdminSupplierCH();
                    ASUPPCH.Show();
                    this.Hide();
                    MessageBox.Show("更新成功");

                }
            }
        }

        private void btn_AdminSupplierDeleteCH_Click(object sender, EventArgs e)
        {
            int index = lst_AdminSupplierCH.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("请选择一项资料");
                }
                else
                {
                    supplier supp = new supplier();
                    supp = content.supplier.SingleOrDefault(i => i.SupplierID == index);
                    if (supp != null)
                    {
                        supp.SupplierAddress = "";
                        supp.SupplierPhonenumber = "";
                        content.SaveChanges();
                    }
                    AdminSupplierCH ASUPPCH = new AdminSupplierCH();
                    ASUPPCH.Show();
                    this.Hide();
                    MessageBox.Show("删除成功");

                }
            }
        }

        private void btn_AdminSupplierBackCH_Click(object sender, EventArgs e)
        {
            AdminCH admch = new AdminCH();
            admch.Show();
            this.Hide();
        }
    }
}
