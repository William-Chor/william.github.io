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
    public partial class AdminSupplier : Form
    {
        String supplierdetails = "{0,-10}{1,-20}{2,-20}{3,-20}";
        public AdminSupplier()
        {
            InitializeComponent();
        }

        private void btn_AdminSupplierAdd_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                supplier NameRepeated = content.supplier.SingleOrDefault(i => i.SupplierName == txt_AdminSupplierName.Text);
                if (txt_AdminSupplierAddress.Text == "" || txt_AdminSupplierName.Text == "" || txt_AdminSupplierPhonenubmer.Text == "")
                {
                    MessageBox.Show("Please fill all the information");
                }
                else if (NameRepeated != null)
                {
                    MessageBox.Show("Name have been use, please enter a new Name");
                    txt_AdminSupplierName.Clear();
                }
                else
                {
                    supplier supp = new supplier
                    {
                        SupplierAddress = txt_AdminSupplierAddress.Text,
                        SupplierName = txt_AdminSupplierName.Text,
                        SupplierPhonenumber = txt_AdminSupplierPhonenubmer.Text,
                        SupplierID = 0
                    };
                    content.supplier.Add(supp);
                    content.SaveChanges();
               
                    supp.SupplierName = txt_AdminSupplierName.Text;
                    supp.SupplierPhonenumber = txt_AdminSupplierPhonenubmer.Text;
                    supp.SupplierAddress = txt_AdminSupplierAddress.Text;
                    supp.SupplierID = lst_AdminSupplier.Items.Count;

                    lst_AdminSupplier.Items.Add(String.Format(supplierdetails, supp.SupplierID, supp.SupplierName, supp.SupplierPhonenumber, supp.SupplierAddress));
                    AdminSupplier ASUPP = new AdminSupplier();
                    ASUPP.Show();
                    this.Hide();
                    MessageBox.Show("Add Successfully");

                }
            }
        }

        private void btn_AdminSupplierUpdate_Click(object sender, EventArgs e)
        {
            int index = lst_AdminSupplier.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("Please select a data");
                }
                else
                {
                    supplier supp = new supplier();
                    supp.SupplierName = txt_AdminSupplierName.Text;
                    supp.SupplierPhonenumber = txt_AdminSupplierPhonenubmer.Text;
                    supp.SupplierAddress = txt_AdminSupplierAddress.Text;
                    supp.SupplierID = index;
                    lst_AdminSupplier.Items.RemoveAt(index);
                    lst_AdminSupplier.Items.Insert(index,String.Format(supplierdetails, supp.SupplierID, supp.SupplierName, supp.SupplierPhonenumber, supp.SupplierAddress));
                    supp = content.supplier.SingleOrDefault(i => i.SupplierID == index);
                    if (supp != null)
                    {
                        supp.SupplierName = txt_AdminSupplierName.Text;
                        supp.SupplierPhonenumber = txt_AdminSupplierPhonenubmer.Text;
                        supp.SupplierAddress = txt_AdminSupplierAddress.Text;
                        content.SaveChanges();
                    }
                    AdminSupplier ASUPP = new AdminSupplier();
                    ASUPP.Show();
                    this.Hide();
                    MessageBox.Show("Update Successfully");

                }
            }
        }

        private void btn_AdminSupplierDelete_Click(object sender, EventArgs e)
        {
            int index = lst_AdminSupplier.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("Please select a data");
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
                    AdminSupplier ASUPP = new AdminSupplier();
                    ASUPP.Show();
                    this.Hide();
                    MessageBox.Show("Delete Successfully");

                }
            }
        }

        private void btn_AdminSupplierBack_Click(object sender, EventArgs e)
        {
            admin_management ADM = new admin_management();
            ADM.Show();
            this.Hide();
        }

        private void AdminSupplier_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;

            lst_AdminSupplier.Items.Add(String.Format(supplierdetails, "ID", "Name", "Phone number", "Address"));
            using (Entitie content = new Entitie())
            {
                var supplierresult = content.supplier;
                if (supplierresult != null)
                {
                    var ls = supplierresult.ToList();
                    foreach (supplier supp in ls)
                    {
                        lst_AdminSupplier.Items.Add(String.Format(supplierdetails, supp.SupplierID, supp.SupplierName, supp.SupplierPhonenumber,supp.SupplierAddress));
                    }
                }
            }
        }
    }
}
