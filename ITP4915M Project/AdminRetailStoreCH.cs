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
    public partial class AdminRetailStoreCH : Form
    {
        String retailstoredetailsch = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}";
        public AdminRetailStoreCH()
        {
            
            InitializeComponent();
        }

        private void AdminRetailStoreCH_Load(object sender, EventArgs e)
        {
            lst_AdminReatilStoreCH.Items.Add(String.Format(retailstoredetailsch, "号码", "名字", "电话号码", "地址", "经理"));
            using (Entitie content = new Entitie())
            {
                var retailstoreresultch = content.retailstore;
                if (retailstoreresultch != null)
                {
                    var ls = retailstoreresultch.ToList();
                    foreach (retailstore rs in ls)
                    {
                        lst_AdminReatilStoreCH.Items.Add(String.Format(retailstoredetailsch, rs.StoreID, rs.StoreName, rs.StorePhonenumber, rs.StoreAddress, rs.StoreManager));
                    }
                }
            }
        }

        private void btn_AdminReatilStoreAddCH_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                retailstore NameRepeated = content.retailstore.SingleOrDefault(i => i.StoreName == txt_AdminReatilStoreNameCH.Text);
                if (txt_AdminReatilStoreNameCH.Text == "" || txt_AdminReatilStorePhoneNumberCH.Text == "" || txt_AdminReatilStoreAddressCH.Text == "" || txt_AdminReatilStoreManagerCH.Text == "")
                {
                    MessageBox.Show("请填写所有空格");
                }
                else if (NameRepeated != null)
                {
                    MessageBox.Show("名字已经被人用了，请用其他名字");
                    txt_AdminReatilStoreNameCH.Clear();
                }
                else
                {
                    retailstore rs = new retailstore
                    {
                        StoreName = txt_AdminReatilStoreNameCH.Text,
                        StorePhonenumber = txt_AdminReatilStorePhoneNumberCH.Text,
                        StoreAddress = txt_AdminReatilStoreAddressCH.Text,
                        StoreManager = txt_AdminReatilStoreManagerCH.Text,
                        StoreID = 0
                    };
                    content.retailstore.Add(rs);
                    content.SaveChanges();

                    rs.StoreName = txt_AdminReatilStoreNameCH.Text;
                    rs.StorePhonenumber = txt_AdminReatilStorePhoneNumberCH.Text;
                    rs.StoreAddress = txt_AdminReatilStoreAddressCH.Text;
                    rs.StoreManager = txt_AdminReatilStoreManagerCH.Text;
                    rs.StoreID = lst_AdminReatilStoreCH.Items.Count;

                    lst_AdminReatilStoreCH.Items.Add(String.Format(retailstoredetailsch, rs.StoreManager, rs.StoreName, rs.StorePhonenumber, rs.StoreAddress, rs.StoreManager));
                    AdminRetailStoreCH ARSCH = new AdminRetailStoreCH();
                    ARSCH.Show();
                    this.Hide();
                    MessageBox.Show("加入成功");

                }
            }
        }

        private void btn_AdminReatilStoreUpdateCH_Click(object sender, EventArgs e)
        {
            int index = lst_AdminReatilStoreCH.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("请选择一项资料");
                }
                else
                {
                    retailstore rs = new retailstore();
                    rs.StoreName = txt_AdminReatilStoreNameCH.Text;
                    rs.StorePhonenumber = txt_AdminReatilStorePhoneNumberCH.Text;
                    rs.StoreAddress = txt_AdminReatilStoreAddressCH.Text;
                    rs.StoreManager = txt_AdminReatilStoreManagerCH.Text;
                    rs.StoreID = index;
                    lst_AdminReatilStoreCH.Items.RemoveAt(index);
                    lst_AdminReatilStoreCH.Items.Insert(index, String.Format(retailstoredetailsch, rs.StoreManager, rs.StoreName, rs.StorePhonenumber, rs.StoreAddress, rs.StoreManager));
                    rs = content.retailstore.SingleOrDefault(i => i.StoreID == index);
                    if (rs != null)
                    {
                        rs.StoreName = txt_AdminReatilStoreNameCH.Text;
                        rs.StorePhonenumber = txt_AdminReatilStorePhoneNumberCH.Text;
                        rs.StoreAddress = txt_AdminReatilStoreAddressCH.Text;
                        rs.StoreManager = txt_AdminReatilStoreManagerCH.Text;
                        content.SaveChanges();
                    }
                    AdminRetailStoreCH ARSCH = new AdminRetailStoreCH();
                    ARSCH.Show();
                    this.Hide();
                    MessageBox.Show("更新成功");

                }
            }
        }

        private void btn_AdminReatilStoreDeleteCH_Click(object sender, EventArgs e)
        {
            int index = lst_AdminReatilStoreCH.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("请选择一项资料");
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
                    AdminRetailStoreCH ARSCH = new AdminRetailStoreCH();
                    ARSCH.Show();
                    this.Hide();
                    MessageBox.Show("删除成功");

                }
            }
        }

        private void btn_AdminReatilStoreBackCH_Click(object sender, EventArgs e)
        {
            AdminCH admch = new AdminCH();
            admch.Show();
            this.Hide();
        }
    }
}
