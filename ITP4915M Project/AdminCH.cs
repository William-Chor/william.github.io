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
    public partial class AdminCH : Form
    {
        public AdminCH()
        {
            InitializeComponent();
        }

        private void btn_AdminStaffCH_Click(object sender, EventArgs e)
        {
            AdminStaffCH admstaffch = new AdminStaffCH();
            admstaffch.Show();
            this.Hide();
        }

        private void btn_AdminProductCH_Click(object sender, EventArgs e)
        {
            AdminProductCH admproductch = new AdminProductCH();
            admproductch.Show();
            this.Hide();
        }

        private void btn_AdminRetailStoreCH_Click(object sender, EventArgs e)
        {
            AdminRetailStoreCH admrsch = new AdminRetailStoreCH();
            admrsch.Show();
            this.Hide();
        }

        private void btn_AdminSupplierCH_Click(object sender, EventArgs e)
        {
            AdminSupplierCH admsuppch = new AdminSupplierCH();
            admsuppch.Show();
            this.Hide();
        }

        private void btn_AdminLogoutCH_Click(object sender, EventArgs e)
        {
            LoginCH lgch = new LoginCH();
            lgch.Show();
            this.Hide();
        }

        private void lnk_AdminENG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_management adm = new admin_management();
            adm.Show();
            this.Hide();
        }

        private void btn_AdminEditCH_Click(object sender, EventArgs e)
        {
            AdminAccountEditCH AACCH = new AdminAccountEditCH();
            AACCH.Show();
            this.Hide();
        }

        private void AdminCH_Load(object sender, EventArgs e)
        {
            // center the windows
            this.MaximizeBox = false;
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
        }
    }
}
