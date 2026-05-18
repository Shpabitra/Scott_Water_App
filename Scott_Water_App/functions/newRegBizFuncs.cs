using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scott_Water_App.Models;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Scott_Water_App.Functions
{
    public static class newRegBizFuncs
    {
        // Comprehensive input validation for Business object
        public static bool inputvalidation(Businesses business)
        {
            // Check for null object
            if (business == null)
            {
                MessageBox.Show("Business object cannot be null.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Business ID
            if (!ValidateBusinessID(business.BusinessID))
                return false;

            // Validate Business Name
            if (!ValidateBusinessName(business.BusinessName))
                return false;

            // Validate Business Email
            if (!ValidateEmail(business.BusinessEmail))
                return false;

            // Validate Address (City)
            if (!ValidateAddress(business.BusinessCity))
                return false;

            // Validate Postcode
            if (!ValidatePostcode(business.BusinessPostcode))
                return false;

            // Validate Telephone Number
            if (!ValidatePhoneNumber(business.BusinessContactNumber))
                return false;

            // Validate Contact Person
            if (!ValidateContactPerson(business.ContactPerson))
                return false;

            // Validate Registration Date
            if (!ValidateRegistrationDate(business.RegistrationDate))
                return false;

            // Validate Status
            if (!ValidateStatus(business.Status))
                return false;

            return true;
        }

        // Validation: Business ID must be a positive number
        public static bool ValidateBusinessID(int businessID)
        {
            if (businessID <= 0)
            {
                MessageBox.Show("Business ID must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Validation: Business Name (2-100 characters, alphanumeric with special chars)
        public static bool ValidateBusinessName(string businessName)
        {
            if (string.IsNullOrWhiteSpace(businessName))
            {
                MessageBox.Show("Business Name is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (businessName.Length < 2)
            {
                MessageBox.Show("Business Name must be at least 2 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (businessName.Length > 100)
            {
                MessageBox.Show("Business Name must not exceed 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Allow alphanumeric, spaces, hyphens, ampersand, comma, period, apostrophe
            if (!Regex.IsMatch(businessName, @"^[a-zA-Z0-9\s\-&,.']+$"))
            {
                MessageBox.Show("Business Name contains invalid characters. Allowed: letters, numbers, spaces, hyphens, ampersand, comma, period, apostrophe.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Validation: Email format
        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Business Email is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Email pattern validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Please enter a valid email address (e.g., name@domain.com).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Validation: Address/City (5-100 characters)
        public static bool ValidateAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address/City is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (address.Length < 5)
            {
                MessageBox.Show("Address must be at least 5 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (address.Length > 100)
            {
                MessageBox.Show("Address must not exceed 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Allow alphanumeric, spaces, hyphens, comma, period, apostrophe, parentheses
            if (!Regex.IsMatch(address, @"^[a-zA-Z0-9\s\-,.'()]+$"))
            {
                MessageBox.Show("Address contains invalid characters. Allowed: letters, numbers, spaces, hyphens, comma, period, apostrophe, parentheses.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Validation: UK Postcode format
        public static bool ValidatePostcode(string postcode)
        {
            if (string.IsNullOrWhiteSpace(postcode))
            {
                MessageBox.Show("Postcode is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // UK postcode validation pattern
            string pattern = @"^[A-Z]{1,2}[0-9]{1,2}[A-Z]?\s?[0-9][A-Z]{2}$";
            if (!Regex.IsMatch(postcode, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Please enter a valid UK postcode (e.g., G2 1BB or G21BB).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Validation: Phone Number (10-15 digits with optional separators)
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Telephone number is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Remove common separators: spaces, hyphens, parentheses
            string cleaned = Regex.Replace(phoneNumber, @"[\s\-\(\)]+", "");

            // Check if it contains only digits and has 10-15 digits
            if (!Regex.IsMatch(cleaned, @"^\d{10,15}$"))
            {
                MessageBox.Show("Telephone number must be 10-15 digits (can include spaces, dashes, or parentheses).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Validation: Contact Person (2-100 characters, letters only with some punctuation)
        public static bool ValidateContactPerson(string contactPerson)
        {
            if (string.IsNullOrWhiteSpace(contactPerson))
            {
                MessageBox.Show("Contact Person name is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contactPerson.Length < 2)
            {
                MessageBox.Show("Contact Person name must be at least 2 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contactPerson.Length > 100)
            {
                MessageBox.Show("Contact Person name must not exceed 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Allow only letters, spaces, hyphens, periods, apostrophes
            if (!Regex.IsMatch(contactPerson, @"^[a-zA-Z\s\-.']+$"))
            {
                MessageBox.Show("Contact Person name contains invalid characters. Allowed: letters, spaces, hyphens, periods, apostrophes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Validation: Registration Date (multiple formats supported)
        public static bool ValidateRegistrationDate(string registrationDate)
        {
            if (string.IsNullOrWhiteSpace(registrationDate))
            {
                MessageBox.Show("Registration Date is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime result;
            string[] formats = { "dd/MM/yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss", "yyyy-MM-dd HH:mm:ss", "d/M/yyyy HH:mm:ss", "M/d/yyyy HH:mm:ss" };

            if (!DateTime.TryParseExact(registrationDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result))
            {
                MessageBox.Show("Please enter a valid date and time (e.g., DD/MM/YYYY HH:MM:SS, MM/DD/YYYY HH:MM:SS, or YYYY-MM-DD HH:MM:SS).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Optional: Check if date is not in the future
            if (result > DateTime.Now)
            {
                MessageBox.Show("Registration Date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Validation: Status (must be one of predefined values)
        public static bool ValidateStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Status is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string[] validStatuses = { "Active", "Inactive", "Suspended" };
            if (!validStatuses.Contains(status.Trim()))
            {
                MessageBox.Show("Status must be one of: Active, Inactive, or Suspended.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Get business count from database
        public static int GetBusinessCount(ScotWaterContext database)
        {
            if (database == null)
                return 0;

            return database.Businesses.Count();
        }

        // Add other existing methods here (GetBusinessNames, CreateBusinessObjectFromInputFields, etc.)

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
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                Status = "Active"
            };
        }



        public static Businesses CreateBusinessObjectFromInputFields(
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

        public static bool checkIfAnyBusiessInfoChanged(Businesses existingBusiness, Businesses updatedInput)
        {
            if (existingBusiness == null || updatedInput == null)
            {
                return false;
            }

            return
                !string.Equals(existingBusiness.BusinessName, updatedInput.BusinessName, StringComparison.Ordinal) ||
                !string.Equals(existingBusiness.BusinessCity, updatedInput.BusinessCity, StringComparison.Ordinal) ||
                !string.Equals(existingBusiness.BusinessPostcode, updatedInput.BusinessPostcode, StringComparison.Ordinal) ||
                !string.Equals(existingBusiness.BusinessContactNumber, updatedInput.BusinessContactNumber, StringComparison.Ordinal) ||
                !string.Equals(existingBusiness.BusinessEmail, updatedInput.BusinessEmail, StringComparison.OrdinalIgnoreCase) ||
                !string.Equals(existingBusiness.ContactPerson, updatedInput.ContactPerson, StringComparison.Ordinal) ||
                !string.Equals(existingBusiness.RegistrationDate, updatedInput.RegistrationDate, StringComparison.Ordinal) ||
                !string.Equals(existingBusiness.Status, updatedInput.Status, StringComparison.Ordinal);
        }

        public static void updateExistingBusinessInfo(Businesses existingBusiness, Businesses updatedInput)
        {
            if (existingBusiness == null || updatedInput == null)
            {
                return;
            }

            existingBusiness.BusinessName = updatedInput.BusinessName;
            existingBusiness.BusinessCity = updatedInput.BusinessCity;
            existingBusiness.BusinessPostcode = updatedInput.BusinessPostcode;
            existingBusiness.BusinessContactNumber = updatedInput.BusinessContactNumber;
            existingBusiness.BusinessEmail = updatedInput.BusinessEmail;
            existingBusiness.ContactPerson = updatedInput.ContactPerson;
            existingBusiness.RegistrationDate = updatedInput.RegistrationDate;
            existingBusiness.Status = updatedInput.Status;
        }
        public static System.Collections.Generic.List<string> GetBusinessIds(ScotWaterContext database)
        {
            var businessIds = new System.Collections.Generic.List<string>();

            if (database != null)
            {
                businessIds = database.Businesses
                    .Select(b => b.BusinessID.ToString())
                    .OrderBy(id => id)
                    .ToList();
            }

            businessIds.Add("Add New Business");
            return businessIds;
        }

        public static System.Collections.Generic.List<string> GetBusinessNames(ScotWaterContext database, int addNew)
        {
            var businessNames = new System.Collections.Generic.List<string>();

            if (database != null)
            {
                businessNames = database.Businesses
                    .Select(b => b.BusinessName)
                    .OrderBy(name => name)
                    .ToList();
            }

            if (addNew == 0)
             businessNames.Add("Add New Business");
            return businessNames;
        }

        public static int? GetBusinessIdFromSelectedValue(string selectedBusinessIdStr, ScotWaterContext db)
        {
            if (db == null || string.IsNullOrWhiteSpace(selectedBusinessIdStr))
                return null;

            if (selectedBusinessIdStr == "Add New Business")
                return null;

            // Supports both modes: name list or ID list
            int parsedId;
            if (int.TryParse(selectedBusinessIdStr, out parsedId))
                return parsedId;

            var business = db.Businesses.FirstOrDefault(b => b.BusinessName == selectedBusinessIdStr);
            return business != null ? (int?)business.BusinessID : null;
        }

    }
}
