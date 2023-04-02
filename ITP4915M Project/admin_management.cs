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
    public partial class admin_management : Form
    {
        public admin_management()
        {
            InitializeComponent();
        }

      

        private void btn_AdminStaff_Click(object sender, EventArgs e)
        {
            AdminStaff admstaff = new AdminStaff();
            admstaff.Show();
            this.Hide();
        }

        private void btn_AdminProduct_Click(object sender, EventArgs e)
        {
            AdminProduct admproduct = new AdminProduct();
            admproduct.Show();
            this.Hide();
        }

        private void btn_AdminRetailStore_Click(object sender, EventArgs e)
        {
            AdminRetailStore admretailstore = new AdminRetailStore();
            admretailstore.Show();
            this.Hide();
        }

        private void btn_AdminSupplier_Click(object sender, EventArgs e)
        {
            AdminSupplier admsupplier = new AdminSupplier();
            admsupplier.Show();
            this.Hide();
        }


        private void btn_AdminLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void lnk_AdminCH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminCH adCH = new AdminCH();
            adCH.Show();
            this.Hide();
        }

        private void btn_AdminEdit_Click(object sender, EventArgs e)
        {
            AdminAccountEdit AAE = new AdminAccountEdit();
            AAE.Show();
            this.Hide();
        }

        private void admin_management_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
        }
    }
}
