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
    public partial class AdminRetailStore : Form
    {
        String retailstoredetails = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}";
        public AdminRetailStore()
        {
            InitializeComponent();
        }

        private void lst_AdminReatilStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AdminReatilStoreAdd_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                retailstore NameRepeated = content.retailstore.SingleOrDefault(i => i.StoreName == txt_AdminReatilStoreName.Text);
                if (txt_AdminReatilStoreName.Text == "" || txt_AdminReatilStorePhoneNumber.Text == "" || txt_AdminReatilStoreAddress.Text == "" || txt_AdminReatilStoreManager.Text=="")
                {
                    MessageBox.Show("Please fill all the information");
                }
                else if (NameRepeated != null)
                {
                    MessageBox.Show("Name have been use, please enter a new Name");
                    txt_AdminReatilStoreName.Clear();
                }
                else
                {
                    retailstore rs = new retailstore
                    {
                        StoreName = txt_AdminReatilStoreName.Text,
                        StorePhonenumber = txt_AdminReatilStorePhoneNumber.Text,
                        StoreAddress = txt_AdminReatilStoreAddress.Text,
                        StoreManager = txt_AdminReatilStoreManager.Text,
                        StoreID = 0
                    };
                    content.retailstore.Add(rs);
                    content.SaveChanges();

                    rs.StoreName = txt_AdminReatilStoreName.Text;
                    rs.StorePhonenumber = txt_AdminReatilStorePhoneNumber.Text;
                    rs.StoreAddress = txt_AdminReatilStoreAddress.Text;
                    rs.StoreManager = txt_AdminReatilStoreManager.Text;
                    rs.StoreID = lst_AdminReatilStore.Items.Count;

                    lst_AdminReatilStore.Items.Add(String.Format(retailstoredetails, rs.StoreManager, rs.StoreName, rs.StorePhonenumber, rs.StoreAddress, rs.StoreManager));
                    AdminRetailStore ARS = new AdminRetailStore();
                    ARS.Show();
                    this.Hide();
                    MessageBox.Show("Add Successfully");

                }
            }
        }

        private void btn_AdminReatilStoreUpdate_Click(object sender, EventArgs e)
        {
            int index = lst_AdminReatilStore.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("Please select a data");
                }
                else
                {
                    retailstore rs = new retailstore();
                    rs.StoreName = txt_AdminReatilStoreName.Text;
                    rs.StorePhonenumber = txt_AdminReatilStorePhoneNumber.Text;
                    rs.StoreAddress = txt_AdminReatilStoreAddress.Text;
                    rs.StoreManager = txt_AdminReatilStoreManager.Text;
                    rs.StoreID = index;
                    lst_AdminReatilStore.Items.RemoveAt(index);
                    lst_AdminReatilStore.Items.Insert(index, String.Format(retailstoredetails, rs.StoreManager, rs.StoreName, rs.StorePhonenumber, rs.StoreAddress, rs.StoreManager));
                    rs = content.retailstore.SingleOrDefault(i => i.StoreID == index);
                    if (rs != null)
                    {
                        rs.StoreName = txt_AdminReatilStoreName.Text;
                        rs.StorePhonenumber = txt_AdminReatilStorePhoneNumber.Text;
                        rs.StoreAddress = txt_AdminReatilStoreAddress.Text;
                        rs.StoreManager = txt_AdminReatilStoreManager.Text;
                        content.SaveChanges();
                    }
                    AdminRetailStore ARS = new AdminRetailStore();
                    ARS.Show();
                    this.Hide();
                    MessageBox.Show("Update Successfully");

                }
            }
        }

        private void btn_AdminReatilStoreDelete_Click(object sender, EventArgs e)
        {
            int index = lst_AdminReatilStore.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("Please select a data");
                }
                else
                {
                    retailstore rs = new retailstore();
                    rs = content.retailstore.SingleOrDefault(i => i.StoreID == index);
                    if (rs != null)
                    {
                        rs.StoreAddress = "";
                        rs.StoreManager = "";
                        content.SaveChanges();
                    }
                    AdminRetailStore ARS = new AdminRetailStore();
                    ARS.Show();
                    this.Hide();
                    MessageBox.Show("Delete Successfully");

                }
            }
        }

        private void btn_AdminReatilStoreBack_Click(object sender, EventArgs e)
        {
            admin_management ADM = new admin_management();
            ADM.Show();
            this.Hide();
        }

        private void AdminRetailStore_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;

            lst_AdminReatilStore.Items.Add(String.Format(retailstoredetails, "ID", "Name", "Phone number", "Address", "Manager"));
            using (Entitie content = new Entitie())
            {
                var retailstoreresult = content.retailstore;
                if (retailstoreresult != null)
                {
                    var ls = retailstoreresult.ToList();
                    foreach (retailstore rs in ls)
                    {
                        lst_AdminReatilStore.Items.Add(String.Format(retailstoredetails, rs.StoreID, rs.StoreName, rs.StorePhonenumber, rs.StoreAddress,rs.StoreManager));
                    }
                }
            }
        }
    }
}
