using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Scott_Water_App.Functions
{
    internal class newRegBizFuncs
    {
        public static bool IsValidEmailFormat(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                var mailAddress = new MailAddress(email);
                return string.Equals(mailAddress.Address, email, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        public static bool inputValidation(
            string businessId,
            string businessName,
            string address,
            string postCode,
            string telephone,
            string email,
            string contactPerson,
            string meterId,
            string registrationDate,
            string status,
            out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(businessId) ||
                string.IsNullOrWhiteSpace(businessName) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(postCode) ||
                string.IsNullOrWhiteSpace(telephone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contactPerson) ||
                string.IsNullOrWhiteSpace(meterId) ||
                string.IsNullOrWhiteSpace(registrationDate) ||
                string.IsNullOrWhiteSpace(status))
            {
                errorMessage = "Please fill all required fields.";
                return false;
            }

            if (!IsValidEmailFormat(email))
            {
                errorMessage = "Please enter a valid email format.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}
