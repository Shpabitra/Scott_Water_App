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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeWaterLevel = new System.Windows.Forms.Button();
            this.btnExitWaterQuality = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReservePercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Business Name:";
            // 
            // btnChangeWaterLevel
            // 
            this.btnChangeWaterLevel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeWaterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeWaterLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeWaterLevel.Location = new System.Drawing.Point(391, 229);
            this.btnChangeWaterLevel.Name = "btnChangeWaterLevel";
            this.btnChangeWaterLevel.Size = new System.Drawing.Size(215, 90);
            this.btnChangeWaterLevel.TabIndex = 4;
            this.btnChangeWaterLevel.Text = "Change Water Level";
            this.btnChangeWaterLevel.UseVisualStyleBackColor = false;
            this.btnChangeWaterLevel.Click += new System.EventHandler(this.btnChangeWaterLevel_Click);
            // 
            // btnExitWaterQuality
            // 
            this.btnExitWaterQuality.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExitWaterQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitWaterQuality.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitWaterQuality.Location = new System.Drawing.Point(168, 229);
            this.btnExitWaterQuality.Name = "btnExitWaterQuality";
            this.btnExitWaterQuality.Size = new System.Drawing.Size(175, 90);
            this.btnExitWaterQuality.TabIndex = 7;
            this.btnExitWaterQuality.Text = "EXIT";
            this.btnExitWaterQuality.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(726, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reserve Percentage:";
            // 
            // lblReservePercentage
            // 
            this.lblReservePercentage.AutoSize = true;
            this.lblReservePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservePercentage.Location = new System.Drawing.Point(367, 133);
            this.lblReservePercentage.Name = "lblReservePercentage";
            this.lblReservePercentage.Size = new System.Drawing.Size(23, 20);
            this.lblReservePercentage.TabIndex = 9;
            this.lblReservePercentage.Text = "rp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(366, 186);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "status";
            // 
            // cmbLocation
            // 
            this.cmbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(369, 71);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(304, 41);
            this.cmbLocation.TabIndex = 12;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-8, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(902, 50);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Business Water Reserve";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmWaterQuality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 344);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblReservePercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitWaterQuality);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangeWaterLevel);
            this.Controls.Add(this.label1);
            this.Name = "frmWaterQuality";
            this.Text = "Water Quality Check";
            this.Load += new System.EventHandler(this.frmWaterQuality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeWaterLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExitWaterQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReservePercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox textBox1;
    }
}