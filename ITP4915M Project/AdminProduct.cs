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
    public partial class AdminProduct : Form
    {
        String productdetails = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}";
        public AdminProduct()
        {
            InitializeComponent();
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;

            lst_AdminProduct.Items.Add(String.Format(productdetails, "ID", "Name", "Price", "Supplier Name", "Stock Level"));
            using (Entitie content = new Entitie())
            {
                var productresult = content.product;
                if (productresult != null)
                {
                    var ls = productresult.ToList();
                    foreach (product prod in ls)
                    {
                        lst_AdminProduct.Items.Add(String.Format(productdetails, prod.ProductID, prod.ProductName, prod.Cost, prod.SuppName, prod.stock_level));
                    }
                }
            }
        }

        private void btn_AdminProductAdd_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                product NameRepeated = content.product.SingleOrDefault(i => i.ProductName == txt_AdminProductName.Text);
                if (txt_AdminProductName.Text == "" || txt_AdminProductPrice.Text == "" || txt_AdminProductSuppName.Text == "")
                {
                    MessageBox.Show("Please fill all the information");
                }
                else if (NameRepeated != null)
                {
                    MessageBox.Show("Name have been use, please enter a new Name");
                    txt_AdminProductName.Clear();
                }
                else
                {
                    inventory inv = new inventory();
                    product prod = new product
                    {
                        ProductName = txt_AdminProductName.Text,
                        Cost = txt_AdminProductPrice.Text,
                        SuppName = txt_AdminProductSuppName.Text,
                        stock_level = (short)(short?)int.Parse(txt_AdminProductLevel.Text),
                        ProductID = 0
                    };
                    content.product.Add(prod);
                    content.SaveChanges();

                    prod.ProductName = txt_AdminProductName.Text;
                    prod.Cost = txt_AdminProductPrice.Text;
                    prod.SuppName = txt_AdminProductSuppName.Text;
                    prod.ProductID = lst_AdminProduct.Items.Count;
                    inv.ProductID = lst_AdminProduct.Items.Count;
                    prod.stock_level = (short)(short?)int.Parse(txt_AdminProductLevel.Text);

                    lst_AdminProduct.Items.Add(String.Format(productdetails, prod.ProductID, prod.ProductName, prod.Cost, prod.SuppName, prod.stock_level));
                    AdminProduct AP = new AdminProduct();
                    AP.Show();
                    this.Hide();
                    MessageBox.Show("Add Successfully");

                }
            }
        }

        private void btn_AdminProductUpdate_Click(object sender, EventArgs e)
        {
            int index = lst_AdminProduct.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("Please select a data");
                }
                else
                {
                    inventory inv = new inventory();
                    product prod = new product();
                    prod.ProductName = txt_AdminProductName.Text;
                    prod.Cost = txt_AdminProductPrice.Text;
                    prod.SuppName = txt_AdminProductSuppName.Text;
                    prod.stock_level = (short?)int.Parse(txt_AdminProductLevel.Text);
                    prod.ProductID = index;
                    lst_AdminProduct.Items.RemoveAt(index);
                    lst_AdminProduct.Items.Insert(index, String.Format(productdetails, prod.ProductID, prod.ProductName, prod.Cost, prod.SuppName, prod.stock_level));
                    prod = content.product.SingleOrDefault(i => i.ProductID == index);
                    if (prod != null)
                    {
                        prod.ProductName = txt_AdminProductName.Text;
                        prod.Cost = txt_AdminProductPrice.Text;
                        prod.SuppName = txt_AdminProductSuppName.Text;
                        prod.stock_level = (short?)int.Parse(txt_AdminProductLevel.Text);
                        inv.Stock_level = (short?)int.Parse(txt_AdminProductLevel.Text);
                        content.SaveChanges();
                    }
                    AdminProduct AP = new AdminProduct();
                    AP.Show();
                    this.Hide();
                    MessageBox.Show("Update Successfully");
                }
            }
        }

        private void btn_AdminProductDelete_Click(object sender, EventArgs e)
        {
            int index = lst_AdminProduct.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("Please select a data");
                }
                else
                {
                    inventory inv = new inventory();
                    product prod = new product();
                    prod = content.product.SingleOrDefault(i => i.ProductID == index);
                    if (prod != null)
                    {
                        prod.ProductName = "";
                        prod.Cost = "";
                        prod.SuppName = "";
                        prod.stock_level = null;
                        inv.Stock_level = null;
                        content.SaveChanges();
                    }
                    AdminProduct AP = new AdminProduct();
                    AP.Show();
                    this.Hide();
                    MessageBox.Show("Delete Successfully");
                }
            }
        }

        private void btn_AdminProductBack_Click(object sender, EventArgs e)
        {
            admin_management ADM = new admin_management();
            ADM.Show();
            this.Hide();
        }
    }
}
