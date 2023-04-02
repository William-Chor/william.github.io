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
    public partial class Form5 : Form
    {
        public static string oid;
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                sale_order so = content.sale_order.SingleOrDefault(i => i.orderID == textBox1.Text);
                if (so != null)
                {
                    oid = textBox1.Text;
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide(); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
        }

        private void btn_ViewOrderBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
