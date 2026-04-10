using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scott_Water_App.Models;

namespace Scott_Water_App
{
    public partial class frmWaterLevel : Form
    {
        public frmWaterLevel()
        {
            InitializeComponent();
        }

        private void frmWaterLevel_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveWaterLevel_Click(object sender, EventArgs e)
        {
            try
            {


                using (var db = new Models.ScotWaterContext())
                {
                    WaterLevel wL = new WaterLevel

                    // Create a new WaterLevel object and set its properties

                    {
                        ReservePercentage = (double)nudReserve.Value,
                        DateSet = DateTime.Now
                    };
                    // Add the new water level to the database and save changes
                    db.WaterLevel.Add(wL);
                    db.SaveChanges();
                    MessageBox.Show("Water level saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving water level: {ex.Message}");
            }
        }
    
        

        private void tkblevel_Scroll(object sender, EventArgs e)
        {
            nudReserve.Value = tkblevel.Value;
            prbWater.Value = tkblevel.Value;
            UpdateStatus(tkblevel.Value);
        }
        private void UpdateStatus(int reserveLevel)
        {
            lblStatus.Text = reserveLevel + "%";
            if (reserveLevel < 25)
            {
                lblStatus.Text = "Low Reserve";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = "NORMAL";
                lblStatus.ForeColor = Color.Green;

            }
        }

        private void nudReserve_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)nudReserve.Value;
            tkblevel.Value = value;
            prbWater.Value = value;
            UpdateStatus(value);
        }
    }
}
