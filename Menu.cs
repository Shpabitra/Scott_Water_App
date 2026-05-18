using Scott_Water_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;//data entyty framework
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Water_App
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMeterReading_Click(object sender, EventArgs e)
        {
            frmMeterReading meterReadingForm = new frmMeterReading();
            meterReadingForm.Show();
            this.Hide();
        }

        private void btnReserveLevel_Click(object sender, EventArgs e)
        {
            frmWaterLevel waterLevelForm = new frmWaterLevel();
            waterLevelForm.Show();
            this.Hide();
        }

        private void btnViewBusinesses_Click(object sender, EventArgs e)
        {
            frmBusinessView businessViewForm = new frmBusinessView();
            businessViewForm.Show();
            this.Hide();
        }

        private void btnCheckQuality_Click(object sender, EventArgs e)
        {
            frmWaterQuality waterQualityForm = new frmWaterQuality();
            waterQualityForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegisterBusiness registerBusinessForm = new frmRegisterBusiness(0);
            registerBusinessForm.Show();
            this.Hide();
        }
        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            frmGenerateBill generateBillForm = new frmGenerateBill();
            generateBillForm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            frmPriceChange priceChangeForm = new frmPriceChange();
            priceChangeForm.Show();
            this.Hide();
        }
    }
}
