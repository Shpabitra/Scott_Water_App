using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace Scott_Water_App.Models
{
    public partial class frmPriceChange : Form
    {
        //load the latest price details into the form when it opens
        public frmPriceChange()
        {
            InitializeComponent();

            using(var db = new ScotWaterContext())
            {
                var currentPrice = db.Prices
                    .OrderByDescending(p => p.EffectiveDate)
                    .FirstOrDefault();
                if (currentPrice != null)
                {
                    dtpEffectiveDate.Value = currentPrice.EffectiveDate;
                    nudLowT1.Value = Convert.ToDecimal(currentPrice.DroughtTier1Rate);
                    nudLowT2.Value = Convert.ToDecimal(currentPrice.DroughtTier2Rate);
                    nudLowT3.Value = Convert.ToDecimal(currentPrice.DroughtTier3Rate);

                    nudStndT1.Value = Convert.ToDecimal(currentPrice.NoDroughtTier1Rate);
                    nudStndT2.Value = Convert.ToDecimal(currentPrice.NoDroughtTier2Rate);
                    nudStndT3.Value = Convert.ToDecimal(currentPrice.NoDroughtTier3Rate);

                    nudRcy1.Value = Convert.ToDecimal(currentPrice.RecycleRate1);
                    nudRcy2.Value = Convert.ToDecimal(currentPrice.RecycleRate2);
                    nudRcy3.Value = Convert.ToDecimal(currentPrice.RecycleRate3);
                }
            }


        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMenu menuForm = new frmMenu();
            menuForm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new ScotWaterContext())
            {
                DateTime effectiveDate = dtpEffectiveDate.Value.Date;
                var newPrice = new Price
                {
                    EffectiveDate = effectiveDate,
                    DroughtTier1Rate = Convert.ToDouble(nudLowT1.Value),
                    DroughtTier2Rate = Convert.ToDouble(nudLowT2.Value),
                    DroughtTier3Rate = Convert.ToDouble(nudLowT3.Value),

                    NoDroughtTier1Rate = Convert.ToDouble(nudStndT1.Value),
                    NoDroughtTier2Rate = Convert.ToDouble(nudStndT2.Value),
                    NoDroughtTier3Rate = Convert.ToDouble(nudStndT3.Value),

                    RecycleRate1 = Convert.ToDouble(nudRcy1.Value),
                    RecycleRate2 = Convert.ToDouble(nudRcy2.Value),
                    RecycleRate3 = Convert.ToDouble(nudRcy3.Value)
                };
                db.Prices.Add(newPrice);
                db.SaveChanges();
                MessageBox.Show("New price saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
