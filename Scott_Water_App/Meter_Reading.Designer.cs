namespace Scott_Water_App
{
    partial class frmMeterReading
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
            this.btnMenuMeterReading = new System.Windows.Forms.Button();
            this.btnExitMeterReading = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.dudBusinessName = new System.Windows.Forms.DomainUpDown();
            this.dtpReadingDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudUsageUnits = new System.Windows.Forms.NumericUpDown();
            this.nudRecycleUnits = new System.Windows.Forms.NumericUpDown();
            this.btnSaveReading = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUsageUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecycleUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuMeterReading
            // 
            this.btnMenuMeterReading.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMenuMeterReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMeterReading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuMeterReading.Location = new System.Drawing.Point(51, 20);
            this.btnMenuMeterReading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuMeterReading.Name = "btnMenuMeterReading";
            this.btnMenuMeterReading.Size = new System.Drawing.Size(175, 90);
            this.btnMenuMeterReading.TabIndex = 0;
            this.btnMenuMeterReading.Text = "Scot Water";
            this.btnMenuMeterReading.UseVisualStyleBackColor = false;
            // 
            // btnExitMeterReading
            // 
            this.btnExitMeterReading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExitMeterReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMeterReading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitMeterReading.Location = new System.Drawing.Point(32, 617);
            this.btnExitMeterReading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitMeterReading.Name = "btnExitMeterReading";
            this.btnExitMeterReading.Size = new System.Drawing.Size(175, 95);
            this.btnExitMeterReading.TabIndex = 1;
            this.btnExitMeterReading.Text = "EXIT";
            this.btnExitMeterReading.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Business Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reading Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fresh Water Units:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Recycle Water Units:";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateBill.Location = new System.Drawing.Point(572, 560);
            this.btnGenerateBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(175, 90);
            this.btnGenerateBill.TabIndex = 8;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // dudBusinessName
            // 
            this.dudBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudBusinessName.Location = new System.Drawing.Point(383, 218);
            this.dudBusinessName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dudBusinessName.Name = "dudBusinessName";
            this.dudBusinessName.Size = new System.Drawing.Size(405, 44);
            this.dudBusinessName.TabIndex = 10;
            // 
            // dtpReadingDate
            // 
            this.dtpReadingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReadingDate.Location = new System.Drawing.Point(383, 272);
            this.dtpReadingDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpReadingDate.Name = "dtpReadingDate";
            this.dtpReadingDate.Size = new System.Drawing.Size(405, 44);
            this.dtpReadingDate.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(800, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nudUsageUnits
            // 
            this.nudUsageUnits.Location = new System.Drawing.Point(383, 345);
            this.nudUsageUnits.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudUsageUnits.Name = "nudUsageUnits";
            this.nudUsageUnits.Size = new System.Drawing.Size(214, 20);
            this.nudUsageUnits.TabIndex = 17;
            // 
            // nudRecycleUnits
            // 
            this.nudRecycleUnits.Location = new System.Drawing.Point(383, 403);
            this.nudRecycleUnits.Name = "nudRecycleUnits";
            this.nudRecycleUnits.Size = new System.Drawing.Size(214, 20);
            this.nudRecycleUnits.TabIndex = 18;
            // 
            // btnSaveReading
            // 
            this.btnSaveReading.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveReading.Location = new System.Drawing.Point(383, 560);
            this.btnSaveReading.Name = "btnSaveReading";
            this.btnSaveReading.Size = new System.Drawing.Size(175, 90);
            this.btnSaveReading.TabIndex = 19;
            this.btnSaveReading.Text = "Save Reading";
            this.btnSaveReading.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Current Reserve Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Rate Type:";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(383, 444);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 22;
            this.progressBar1.Value = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Low Reserve";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(603, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "22%";
            // 
            // frmMeterReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveReading);
            this.Controls.Add(this.nudRecycleUnits);
            this.Controls.Add(this.nudUsageUnits);
            this.Controls.Add(this.dtpReadingDate);
            this.Controls.Add(this.dudBusinessName);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitMeterReading);
            this.Controls.Add(this.btnMenuMeterReading);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMeterReading";
            this.Text = "Meter Reading";
            this.Load += new System.EventHandler(this.frmMeterReading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUsageUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecycleUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuMeterReading;
        private System.Windows.Forms.Button btnExitMeterReading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.DomainUpDown dudBusinessName;
        private System.Windows.Forms.DateTimePicker dtpReadingDate;
        private System.Windows.Forms.NumericUpDown nudUsageUnits;
        private System.Windows.Forms.NumericUpDown nudRecycleUnits;
        private System.Windows.Forms.Button btnSaveReading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}