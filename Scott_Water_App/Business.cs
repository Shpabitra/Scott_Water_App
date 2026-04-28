using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Water_App
{
    public partial class frmBusinessView : Form
    {
        public frmBusinessView()
        {
            InitializeComponent();
        }

        private void lblLinkRegisterBusiness_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterBusiness registerBusiness = new frmRegisterBusiness();
            registerBusiness.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmRegisterBusiness BizUpdate = new frmRegisterBusiness(2);// passing false for updating an existing business
            //BizUpdate.AddNew = false; 
            BizUpdate.Show();
            this.Hide();
        }

        private void btnAddNewBusiness_Click(object sender, EventArgs e)
        {
            frmRegisterBusiness BizUpdate = new frmRegisterBusiness(1); // passing true for adding business
            BizUpdate.Show();
            this.Hide();
        }
    }
}
