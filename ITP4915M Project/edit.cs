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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
            txB_id.Text = Re_Order.reorder_data;
            using (Entitie content = new Entitie())
            {
                reorder ro = content.reorder.SingleOrDefault(i => i.reo_id == Re_Order.reorder_data);
                if (ro != null)
                {
                    txB_cost.Text = Convert.ToString(ro.cost);
                    txB_quantity.Text = Convert.ToString(ro.quantity);
                    if (ro.appOfAcc == true)
                    {
                        chB_Acc.CheckState = CheckState.Checked;
                    }
                    if (ro.appOfPur == true)
                    {
                        chB_pur.CheckState = CheckState.Checked;
                    }
                }
            }
        }

        private void edit_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                inventory inv = new inventory();
                reorder ro = content.reorder.SingleOrDefault(i => i.reo_id == Re_Order.reorder_data);
                if (ro != null)
                {
                    ro.cost = (short)(short?)int.Parse(txB_cost.Text);
                    ro.quantity = (short)(short?)int.Parse(txB_quantity.Text);
                    ro.appOfAcc = chB_Acc.Checked;
                    ro.appOfPur = chB_pur.Checked;
                    ro.confirem = chB_conf.Checked;
                    content.SaveChanges();
                    MessageBox.Show("Edit Success!");
                    Re_Order f1 = new Re_Order();
                    f1.Show();
                    this.Hide();
                }
                if (ro.confirem == true)
                {
                    inv.Qty += ro.quantity;
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {
                reorder ro = content.reorder.SingleOrDefault(i => i.reo_id == Re_Order.reorder_data);
                if (ro != null)
                {
                    ro.cost = 0;
                    ro.quantity = 0;
                    ro.appOfAcc = false;
                    ro.appOfPur = false;
                    content.SaveChanges();
                    MessageBox.Show("Data Deleted!");
                    Re_Order f1 = new Re_Order();
                    f1.Show();
                    this.Hide();
                }
            }
        }
        private void SC_lab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SC_edit sce = new SC_edit();
            sce.Show();
            this.Hide();
        }
        private void lab_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Re_Order f1 = new Re_Order();
            f1.Show();
            this.Hide();
        }
 

        
    }
}
