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
    public partial class DeliveryAccountEdit : Form
    {
        public DeliveryAccountEdit()
        {
            InitializeComponent();
            txt_EditUsername.Text = Login.staffACName;
            using (Entitie content = new Entitie())
            {
                account EditAC = content.account.SingleOrDefault(i => i.Acc_Username == Login.staffACName);
                if (EditAC != null)
                {
                    txt_EditPhone.Text = EditAC.Acc_PhoneNumber;
                    txt_EditAddress.Text = EditAC.Acc_Address;
                    txt_EditPassword.Text = EditAC.Acc_Password;
                }
            }
        }

        private void btn_EditChange_Click(object sender, EventArgs e)
        {

            Boolean Orignal = false;

            using (Entitie content = new Entitie())
            {
                account EditAC = content.account.SingleOrDefault(i => i.Acc_Username == Login.staffACName);
                account EditPasswordRepeated = content.account.SingleOrDefault(i => i.Acc_Password == txt_EditPassword.Text);
                if (EditAC.Acc_Password == txt_EditPassword.Text)
                {
                    Orignal = true;
                }
                if (EditPasswordRepeated != null && Orignal == false)
                {
                    MessageBox.Show("Password have been use, please enter a new password");
                    txt_EditPassword.Clear();
                }
                else if (EditAC != null)
                {
                    EditAC.Acc_PhoneNumber = txt_EditPhone.Text;
                    EditAC.Acc_Address = txt_EditAddress.Text;
                    EditAC.Acc_DOB = dateTimePicker_EditDOB.Value;
                    EditAC.Acc_Password = txt_EditPassword.Text;
                    content.SaveChanges();
                    MessageBox.Show("Edit Successful");
                }
            }
        }

        private void btn_EditBack_Click(object sender, EventArgs e)
        {
            DeliveryInstallation delivery = new DeliveryInstallation();
            delivery.Show();
            this.Hide();
        }

        private void btn_EditLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void lnk_EditCH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeliveryAccountEditCH daech = new DeliveryAccountEditCH();
            daech.Show();
            this.Hide();
        }

        private void DeliveryAccountEdit_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
        }
    }
}
