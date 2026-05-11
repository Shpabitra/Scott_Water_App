                    MessageBox.Show($"Business {business.BusinessName} registered successfully!", $"Number of businesses after added: {db.Businesses.Count()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Number of businesses after added: " + db.Businesses.Count(), "Business Count1", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //cmbSelectBusiness.DataSource = newRegBizFuncs.GetBusinessIds(db);
                    cmbSelectBusiness.DataSource = newRegBizFuncs.GetBusinessNames(db, addNew);

                    // Refresh form with addNew = 0 to show both Register and Save buttons
                    addNew = 0;
                    ToggleButtons(addNew);
                    ToggleBusinessSelection(addNew);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to validate email in database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }