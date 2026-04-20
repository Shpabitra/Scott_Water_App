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
