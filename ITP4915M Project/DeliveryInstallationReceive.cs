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
    public partial class DeliveryInstallationReceive : Form
    {
        public DeliveryInstallationReceive()
        {
            InitializeComponent();
        }

        private void DeliveryInstallationReceive_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            // center the windows
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

        private void button1_Click(object sender, EventArgs e)
        {
            DeliveryInstallation en = new DeliveryInstallation();
            en.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeliveryInstallationCH cn = new DeliveryInstallationCH();
            cn.Show();
            this.Hide();
        }
    }
}
