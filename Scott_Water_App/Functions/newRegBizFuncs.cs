using Scott_Water_App.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Scott_Water_App.Functions
{
    internal class newRegBizFuncs
    {
        internal class FakeBusinessData
        {
            public string BusinessId { get; set; }
            public string BusinessName { get; set; }
            public string Address { get; set; }
            public string PostCode { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }
            public string ContactPerson { get; set; }
            public string MeterId { get; set; }
            public string RegistrationDate { get; set; }
            public string Status { get; set; }
        }

        public static Businesses GenerateFakeBusinessData()
        {
            var random = new Random();

            string[] businessPrefixes = { "North", "City", "Green", "Prime", "Blue", "River" };
            string[] businessTypes = { "Traders", "Solutions", "Supplies", "Holdings", "Services", "Group" };
            string[] streets = { "Argyle Street", "Buchanan Street", "High Street", "George Street", "Clyde Street" };
            string[] contactFirstNames = { "John", "Emma", "Liam", "Olivia", "Noah", "Ava" };
            string[] contactLastNames = { "Smith", "Brown", "Wilson", "Taylor", "Campbell", "Stewart" };

            var prefix = businessPrefixes[random.Next(businessPrefixes.Length)];
            var type = businessTypes[random.Next(businessTypes.Length)];
            var firstName = contactFirstNames[random.Next(contactFirstNames.Length)];
            var lastName = contactLastNames[random.Next(contactLastNames.Length)];
            var street = streets[random.Next(streets.Length)];

            return new Businesses
            {
                BusinessID = random.Next(1000, 9999),
                BusinessName = prefix + " " + type,
                BusinessCity = random.Next(1, 250) + " " + street + ", Glasgow",
                BusinessPostcode = "G" + random.Next(1, 99) + " " + random.Next(1, 9) + "AA",
                BusinessContactNumber = "07" + random.Next(100000000, 999999999),
                BusinessEmail = (firstName + "." + lastName + "@" + prefix + type + ".com").ToLower(),
                ContactPerson = firstName + " " + lastName,
                RegistrationDate = DateTime.Today.ToString("yyyy-MM-dd"),
                Status = "Active"
            };
        }

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


        public static bool inputvalidation(Businesses business)
        {
            if (business == null)
            {
                MessageBox.Show("Business object is null.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(business.BusinessName) ||
                string.IsNullOrWhiteSpace(business.BusinessEmail) ||
                string.IsNullOrWhiteSpace(business.BusinessContactNumber) ||
                string.IsNullOrWhiteSpace(business.BusinessCity) ||
                string.IsNullOrWhiteSpace(business.BusinessPostcode) ||
                string.IsNullOrWhiteSpace(business.ContactPerson) ||
                string.IsNullOrWhiteSpace(business.RegistrationDate) ||
                string.IsNullOrWhiteSpace(business.Status))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmailFormat(business.BusinessEmail))
            {
                MessageBox.Show("Please enter a valid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // a lot of validation could be added here such as phone number format, postcode format, registration date format etc. but for the sake of time and simplicity I will leave it at this for now.

            return true;
        }

        public static Businesses GetBusinessFromInputFields(
            string businessId,
            string businessName,
            string address,
            string postCode,
            string telephone,
            string email,
            string contactPerson,
            string registrationDate,
            string status)
        {
            var business = new Businesses
            {
                BusinessName = businessName,
                BusinessEmail = email,
                BusinessContactNumber = telephone,
                BusinessCity = address,
                BusinessPostcode = postCode,
                ContactPerson = contactPerson,
                RegistrationDate = registrationDate,
                Status = status
            };

            int parsedBusinessId;
            if (int.TryParse(businessId, out parsedBusinessId))
            {
                business.BusinessID = parsedBusinessId;
            }

            return business;
        }

        
    }
}
