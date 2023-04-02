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
    public partial class AccountingPurchaseAccountEditCH : Form
    {
        public AccountingPurchaseAccountEditCH()
        {
            InitializeComponent();
            txt_EditUsernameCH.Text = LoginCH.staffACName;
            using (Entitie content = new Entitie())
            {
                account EditAC = content.account.SingleOrDefault(i => i.Acc_Username == Login.staffACName);
                if (EditAC != null)
                {
                    txt_EditPhoneCH.Text = EditAC.Acc_PhoneNumber;
                    txt_EditAddressCH.Text = EditAC.Acc_Address;
                    txt_EditPasswordCH.Text = EditAC.Acc_Password;
                }
            }
        }

        private void btn_EditChangeCH_Click(object sender, EventArgs e)
        {
            Boolean Orignal = false;
            using (Entitie content = new Entitie())
            {
                account EditAC = content.account.SingleOrDefault(i => i.Acc_Username == Login.staffACName);
                account EditPasswordRepeated = content.account.SingleOrDefault(i => i.Acc_Password == txt_EditPasswordCH.Text);
                if (EditAC.Acc_Password == txt_EditPasswordCH.Text)
                {
                    Orignal = true;
                }
                if (EditPasswordRepeated != null && Orignal == false)

                {
                    MessageBox.Show("密码被用了，请用其他密码");
                    txt_EditPasswordCH.Clear();
                }
                else if (EditAC != null)
                {
                    EditAC.Acc_PhoneNumber = txt_EditPhoneCH.Text;
                    EditAC.Acc_Address = txt_EditAddressCH.Text;
                    EditAC.Acc_DOB = dateTimePicker_EditDOBCH.Value;
                    EditAC.Acc_Password = txt_EditPasswordCH.Text;
                    content.SaveChanges();
                    MessageBox.Show("修改成功");
                }
            }
        }

        private void btn_EditLogoutCH_Click(object sender, EventArgs e)
        {
            LoginCH lgch = new LoginCH();
            lgch.Show();
            this.Hide();
        }

        private void lnk_EditENG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountingPurchaseAccountEdit apae = new AccountingPurchaseAccountEdit();
            apae.Show();
            this.Hide();
        }

        private void AccountingPurchaseAccountEditCH_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
        }
    }
}
