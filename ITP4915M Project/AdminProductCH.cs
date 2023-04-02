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
    public partial class AdminProductCH : Form
    {
        String productdetailsch = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}";
        public AdminProductCH()
        {
            InitializeComponent();
        }

        private void btn_AdminProductAddCH_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                product NameRepeated = content.product.SingleOrDefault(i => i.ProductName == txt_AdminProductNameCH.Text);
                if (txt_AdminProductNameCH.Text == "" || txt_AdminProductPriceCH.Text == "" || txt_AdminProductSuppNameCH.Text == "" || txt_AdminProductStockLevelCH.Text == "")
                {
                    MessageBox.Show("请填写所有空格");
                }
                else if (NameRepeated != null)
                {
                    MessageBox.Show("名字已经被人用了，请用其他名字");
                    txt_AdminProductNameCH.Clear();
                }
                else
                {
                    inventory inv = new inventory();
                    product prod = new product
                    {
                        ProductName = txt_AdminProductNameCH.Text,
                        Cost = txt_AdminProductPriceCH.Text,
                        SuppName = txt_AdminProductSuppNameCH.Text,
                        stock_level = (short)(short?)int.Parse(txt_AdminProductStockLevelCH.Text),
                        ProductID = 0
                    };
                    content.product.Add(prod);
                    content.SaveChanges();

                    prod.ProductName = txt_AdminProductNameCH.Text;
                    prod.Cost = txt_AdminProductPriceCH.Text;
                    prod.SuppName = txt_AdminProductSuppNameCH.Text;
                    prod.stock_level = (short)(short?)int.Parse(txt_AdminProductStockLevelCH.Text);
                    inv.Stock_level = (short)(short?)int.Parse(txt_AdminProductStockLevelCH.Text);
                    prod.ProductID = lst_AdminProductCH.Items.Count;
                    inv.ProductID = lst_AdminProductCH.Items.Count;

                    lst_AdminProductCH.Items.Add(String.Format(productdetailsch, prod.ProductID, prod.ProductName, prod.Cost, prod.SuppName, prod.stock_level));
                    AdminProductCH APCH = new AdminProductCH();
                    APCH.Show();
                    this.Hide();
                    MessageBox.Show("加入成功");

                }
            }
        }

        private void btn_AdminProductUpdateCH_Click(object sender, EventArgs e)
        {
            int index = lst_AdminProductCH.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("请选择一个数据");
                }
                else
                {
                    inventory inv = new inventory();
                    product prod = new product();
                    prod.ProductName = txt_AdminProductNameCH.Text;
                    prod.Cost = txt_AdminProductPriceCH.Text;
                    prod.SuppName = txt_AdminProductSuppNameCH.Text;
                    prod.stock_level = (short)(short?)int.Parse(txt_AdminProductStockLevelCH.Text);
                    prod.ProductID = index;
                    lst_AdminProductCH.Items.RemoveAt(index);
                    lst_AdminProductCH.Items.Insert(index, String.Format(productdetailsch, prod.ProductID, prod.ProductName, prod.Cost, prod.SuppName, prod.stock_level));
                    prod = content.product.SingleOrDefault(i => i.ProductID == index);
                    if (prod != null)
                    {
                        prod.ProductName = txt_AdminProductNameCH.Text;
                        prod.Cost = txt_AdminProductPriceCH.Text;
                        prod.SuppName = txt_AdminProductSuppNameCH.Text;
                        prod.stock_level = (short)(short?)int.Parse(txt_AdminProductStockLevelCH.Text);
                        inv.Stock_level = (short)(short?)int.Parse(txt_AdminProductStockLevelCH.Text);
                        content.SaveChanges();
                    }
                    AdminProductCH APCH = new AdminProductCH();
                    APCH.Show();
                    this.Hide();
                    MessageBox.Show("更新成功");

                }
            }
        }

        private void btn_AdminProductDeleteCH_Click(object sender, EventArgs e)
        {
            int index = lst_AdminProductCH.SelectedIndex;
            using (Entitie content = new Entitie())
            {
                if (index == -1)
                {
                    MessageBox.Show("请选择一个数据");
                }
                else
                {
                    inventory inv = new inventory();
                    product prod = new product();
                    prod = content.product.SingleOrDefault(i => i.ProductID == index);
                    if (prod != null)
                    {
                        prod.Cost = "";
                        prod.SuppName = "";
                        prod.stock_level = null;
                        inv.Stock_level = null;
                        content.SaveChanges();
                    }
                    AdminProductCH APCH = new AdminProductCH();
                    APCH.Show();
                    this.Hide();
                    MessageBox.Show("删除成功");

                }
            }
        }

        private void btn_AdminProductBackCH_Click(object sender, EventArgs e)
        {
            AdminCH admch = new AdminCH();
            admch.Show();
            this.Hide();
        }

        private void AdminProductCH_Load(object sender, EventArgs e)
        {
            lst_AdminProductCH.Items.Add(String.Format(productdetailsch, "编号", "名称", "价格", "供应商", "库存水平"));
            using (Entitie content = new Entitie())
            {
                var productresultch = content.product;
                if (productresultch != null)
                {
                    var ls = productresultch.ToList();
                    foreach (product prod in ls)
                    {
                        lst_AdminProductCH.Items.Add(String.Format(productdetailsch, prod.ProductID, prod.ProductName, prod.Cost, prod.SuppName, prod.stock_level));
                    }
                }
            }
        }
    }
}
