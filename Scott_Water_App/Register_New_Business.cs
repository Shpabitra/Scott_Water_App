using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scott_Water_App.Functions;

namespace Scott_Water_App
{
    public partial class frmRegisterBusiness : Form
    {
        public frmRegisterBusiness()
        {
            InitializeComponent();
            FillFakeBusinessData();
        }

        private void FillFakeBusinessData()
        {
            var data = newRegBizFuncs.GenerateFakeBusinessData();

            txtBusinessID.Text = data.BusinessId;
            txtBusinessName.Text = data.BusinessName;
            txtAddress.Text = data.Address;
            txtPostCode.Text = data.PostCode;
            txtTelephone.Text = data.Telephone;
            TxtEmail.Text = data.Email;
            txtContactPerson.Text = data.ContactPerson;
            textBox1.Text = data.MeterId;
            textBox2.Text = data.RegistrationDate;
            textBox3.Text = data.Status;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string errorMessage;
            var isValid = newRegBizFuncs.inputValidation(
                txtBusinessID.Text.Trim(),
                txtBusinessName.Text.Trim(),
                txtAddress.Text.Trim(),
                txtPostCode.Text.Trim(),
                txtTelephone.Text.Trim(),
                TxtEmail.Text.Trim(),
                txtContactPerson.Text.Trim(),
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                textBox3.Text.Trim(),
                out errorMessage);

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("All inputs are valid.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
