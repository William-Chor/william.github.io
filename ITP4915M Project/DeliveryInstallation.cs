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
    public partial class DeliveryInstallation : Form
    {
        public DeliveryInstallation()
        {
            InitializeComponent();
        }

        private void DeliveryInstallation_Load(object sender, EventArgs e)
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
            listBox1.Items.Add(String.Format(deliveryListDetail, "Order Number", "       Order Time", "            Price", "     Payment Method", "Delivery Stasus", "Deliver", "Payment Status"));
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
            DeliveryInstallationCH cn = new DeliveryInstallationCH();
            cn.Show();
            this.Hide();
        }

        private void btn_DeliveryInstallationEdit_Click(object sender, EventArgs e)
        {
            DeliveryAccountEdit DAE = new DeliveryAccountEdit();
            DAE.Show();
            this.Hide();
        }

        // Assignt workman

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
                        MessageBox.Show("Please select a order and workman.");
                    }
                    else
                    {
                        d.deliver = listBox2.SelectedItem.ToString();
                        MessageBox.Show("This order has already assigned workman.");
                        //restart the windows
                        // Application.Exit();
                        // System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                        DeliveryInstallation di = new DeliveryInstallation();
                        di.Show();
                        this.Hide();
                    }

                }
                content.SaveChanges();

            }
        }

        // Cancel workman
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
                        MessageBox.Show("Please select a order.");
                    }
                    else
                    {
                        d.deliver = "None";
                        MessageBox.Show("This order has been cancelled the workman.");
                        //restart the windows
                        // Application.Exit();
                        // System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                        DeliveryInstallation di = new DeliveryInstallation();
                        di.Show();
                        this.Hide();
                    }

                }
                content.SaveChanges();

            }
        }

        //Change payment status
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
                        MessageBox.Show("Please select a order.");
                    }
                    else
                    {
                        if (d.payStatus == "Paid")
                        {
                            d.payStatus = "Non-payment";

                        }
                        else { d.payStatus = "Paid"; }

                        MessageBox.Show("This order has been changed the status.");
                        //restart the windows
                        // Application.Exit();
                        // System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                        DeliveryInstallation di = new DeliveryInstallation();
                        di.Show();
                        this.Hide();
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
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String order = listBox1.SelectedItem.ToString();
            order = order.Substring(0, 16);
            textBox1.Text = order;
        }
    }
}
