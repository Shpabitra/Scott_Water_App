namespace Scott_Water_App
{
    partial class frmWaterQuality
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dupLocation = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbDrought = new System.Windows.Forms.RadioButton();
            this.rdbNoDrought = new System.Windows.Forms.RadioButton();
            this.btnSaveWaterQuality = new System.Windows.Forms.Button();
            this.btnMenuQuality = new System.Windows.Forms.Button();
            this.btnExitWaterQuality = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dupLocation
            // 
            this.dupLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dupLocation.Location = new System.Drawing.Point(401, 210);
            this.dupLocation.Name = "dupLocation";
            this.dupLocation.Size = new System.Drawing.Size(405, 44);
            this.dupLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location: ";
            // 
            // rdbDrought
            // 
            this.rdbDrought.AutoSize = true;
            this.rdbDrought.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDrought.Location = new System.Drawing.Point(46, 36);
            this.rdbDrought.Name = "rdbDrought";
            this.rdbDrought.Size = new System.Drawing.Size(157, 41);
            this.rdbDrought.TabIndex = 2;
            this.rdbDrought.TabStop = true;
            this.rdbDrought.Text = "Drought";
            this.rdbDrought.UseVisualStyleBackColor = true;
            // 
            // rdbNoDrought
            // 
            this.rdbNoDrought.AutoSize = true;
            this.rdbNoDrought.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoDrought.Location = new System.Drawing.Point(277, 36);
            this.rdbNoDrought.Name = "rdbNoDrought";
            this.rdbNoDrought.Size = new System.Drawing.Size(211, 41);
            this.rdbNoDrought.TabIndex = 3;
            this.rdbNoDrought.TabStop = true;
            this.rdbNoDrought.Text = "No Drought";
            this.rdbNoDrought.UseVisualStyleBackColor = true;
            // 
            // btnSaveWaterQuality
            // 
            this.btnSaveWaterQuality.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveWaterQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWaterQuality.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveWaterQuality.Location = new System.Drawing.Point(383, 479);
            this.btnSaveWaterQuality.Name = "btnSaveWaterQuality";
            this.btnSaveWaterQuality.Size = new System.Drawing.Size(175, 90);
            this.btnSaveWaterQuality.TabIndex = 4;
            this.btnSaveWaterQuality.Text = "SAVE";
            this.btnSaveWaterQuality.UseVisualStyleBackColor = false;
            // 
            // btnMenuQuality
            // 
            this.btnMenuQuality.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMenuQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQuality.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuQuality.Location = new System.Drawing.Point(12, 20);
            this.btnMenuQuality.Name = "btnMenuQuality";
            this.btnMenuQuality.Size = new System.Drawing.Size(175, 90);
            this.btnMenuQuality.TabIndex = 5;
            this.btnMenuQuality.Text = "Scot Water";
            this.btnMenuQuality.UseVisualStyleBackColor = false;
            // 
            // btnExitWaterQuality
            // 
            this.btnExitWaterQuality.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExitWaterQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitWaterQuality.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitWaterQuality.Location = new System.Drawing.Point(12, 614);
            this.btnExitWaterQuality.Name = "btnExitWaterQuality";
            this.btnExitWaterQuality.Size = new System.Drawing.Size(175, 90);
            this.btnExitWaterQuality.TabIndex = 7;
            this.btnExitWaterQuality.Text = "EXIT";
            this.btnExitWaterQuality.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.rdbDrought);
            this.groupBox1.Controls.Add(this.rdbNoDrought);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(243, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 103);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Environmental Condition";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(800, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmWaterQuality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExitWaterQuality);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenuQuality);
            this.Controls.Add(this.btnSaveWaterQuality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dupLocation);
            this.Name = "frmWaterQuality";
            this.Text = "Water Quality";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dupLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbDrought;
        private System.Windows.Forms.RadioButton rdbNoDrought;
        private System.Windows.Forms.Button btnSaveWaterQuality;
        private System.Windows.Forms.Button btnMenuQuality;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExitWaterQuality;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}