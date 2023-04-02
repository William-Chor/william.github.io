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
    public partial class DeliveryInstallationCH : Form
    {
        public DeliveryInstallationCH()
        {
            InitializeComponent();
        }

        private void DeliveryInstallationCH_Load(object sender, EventArgs e)
        {
            //load workman list
            using (Entitie content = new Entitie())
            {
                var results = content.workman.Where(i => i.name != null);
                if (results != null)
                {
                    var ls = results.ToList();
                    foreach (workman wm in ls)
                    {
                        listBox2.Items.Add(wm.name);
                    }
                }
            }

            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;

            //load delivery list
            String deliveryListDetail = "{0,-20}{1,-25}{2,-10}{3,-20}{4,-20}{5,-20}{6,-20}";
            listBox1.Items.Add(String.Format(deliveryListDetail, "订单编号", "       订单时间", "            价格", "     付款方式", "运输状态", "运输员", "支付状态"));
            using (Entitie content = new Entitie())
            {
                var result = content.delivery;
                if (result != null)
                {
                    var ls = result.ToList();
                    foreach (delivery dl in ls)
                    {
                        listBox1.Items.Add(String.Format(deliveryListDetail, dl.ordNum, dl.ordTime, dl.price, dl.method, dl.dilyStatus, dl.deliver, dl.payStatus));
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeliveryInstallation en = new DeliveryInstallation();
            en.Show();
            this.Hide();
        }

        private void btn_DeliveryInstallationEditCH_Click(object sender, EventArgs e)
        {
            DeliveryAccountEditCH DAECH = new DeliveryAccountEditCH();
            DAECH.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String order = listBox1.SelectedItem.ToString();
            order = order.Substring(0, 16);
            textBox1.Text = order;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {

                String result = textBox1.Text;
                delivery d = content.delivery.First(i => i.ordNum == result);
                if (d != null)
                {
                    if (listBox1.SelectedItem == null || listBox2.SelectedItem == null)
                    {
                        MessageBox.Show("请选择一张订单和一位工人！");
                    }
                    else
                    {
                        d.deliver = listBox2.SelectedItem.ToString();
                        MessageBox.Show("订单已成功分配工人！");
                        //restart the windows
                        Application.Exit();
                        System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    }

                }
                content.SaveChanges();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {

                String result = textBox1.Text;
                delivery d = content.delivery.First(i => i.ordNum == result);
                if (d != null)
                {
                    if (listBox1.SelectedItem == null)
                    {
                        MessageBox.Show("请选择一张订单！");
                    }
                    else
                    {
                        d.deliver = "None";
                        MessageBox.Show("订单的工人已被取消分配！");
                        //restart the windows
                        Application.Exit();
                        System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    }

                }
                content.SaveChanges();

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (Entitie content = new Entitie())
            {

                String result = textBox1.Text;
                delivery d = content.delivery.First(i => i.ordNum == result);
                if (d != null)
                {
                    if (listBox1.SelectedItem == null)
                    {
                        MessageBox.Show("请选择一张订单！");
                    }
                    else
                    {
                        if (d.payStatus == "Paid")
                        {
                            d.payStatus = "Non-payment";

                        }
                        else { d.payStatus = "Paid"; }

                        MessageBox.Show("订单支付状态已更改！");
                        //restart the windows
                        Application.Exit();
                        System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    }

                }
                content.SaveChanges();

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DeliveryInstallationReceive rc = new DeliveryInstallationReceive();
            rc.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LoginCH lgCH = new LoginCH();
            lgCH.Show();
            this.Hide();
        }
    }
}
