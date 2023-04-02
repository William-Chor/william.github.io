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
    public partial class Form3 : Form
    {
        public static string oid;
        public Form3()
        {
            InitializeComponent();
            textBox1.Text = Form5.oid;
            using (Entitie content = new Entitie())
            {
                sale_order so = content.sale_order.SingleOrDefault(i => i.orderID == Form5.oid);
                if (so != null)
                {
                    textBox2.Text = so.productID;
                    so.QTY = textBox3.Text;
                    so.Total = textBox4.Text;
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                sale_order so = content.sale_order.SingleOrDefault(i => i.orderID == Form5.oid);
                if (so != null)
                {
                    so.orderID = textBox1.Text;
                    so.productID = textBox2.Text;
                    so.QTY = textBox3.Text;
                    so.Total = textBox4.Text;
                    content.SaveChanges();
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void btn_ShoppingCartBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
        }
    }
}
