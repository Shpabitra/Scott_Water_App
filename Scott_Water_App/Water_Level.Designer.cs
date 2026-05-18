namespace Scott_Water_App
{
    partial class frmWaterLevel
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
            this.tkblevel = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prbWater = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSaveWaterLevel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudReservePercentage = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBusinessName = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkblevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReservePercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(291, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Water Reserver";
            // 
            // tkblevel
            // 
            this.tkblevel.Location = new System.Drawing.Point(412, 313);
            this.tkblevel.Maximum = 100;
            this.tkblevel.Name = "tkblevel";
            this.tkblevel.Size = new System.Drawing.Size(405, 45);
            this.tkblevel.TabIndex = 2;
            this.tkblevel.Scroll += new System.EventHandler(this.tkblevel_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(220, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Track Bar: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(170, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Progress Bar: ";
            // 
            // prbWater
            // 
            this.prbWater.Location = new System.Drawing.Point(412, 368);
            this.prbWater.Name = "prbWater";
            this.prbWater.Size = new System.Drawing.Size(405, 45);
            this.prbWater.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbWater.TabIndex = 5;
            this.prbWater.Value = 50;
            this.prbWater.BackColorChanged += new System.EventHandler(this.nudReserve_ValueChanged);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPercentage.Location = new System.Drawing.Point(65, 246);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(341, 37);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "Reserve Percentage: ";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWarning.Location = new System.Drawing.Point(236, 453);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(170, 37);
            this.lblWarning.TabIndex = 7;
            this.lblWarning.Text = "STATUS: ";
            // 
            // btnSaveWaterLevel
            // 
            this.btnSaveWaterLevel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveWaterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWaterLevel.Location = new System.Drawing.Point(525, 535);
            this.btnSaveWaterLevel.Name = "btnSaveWaterLevel";
            this.btnSaveWaterLevel.Size = new System.Drawing.Size(175, 90);
            this.btnSaveWaterLevel.TabIndex = 8;
            this.btnSaveWaterLevel.Text = "SAVE";
            this.btnSaveWaterLevel.UseVisualStyleBackColor = false;
            this.btnSaveWaterLevel.Click += new System.EventHandler(this.btnSaveWaterLevel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(214, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 90);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(827, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nudReservePercentage
            // 
            this.nudReservePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudReservePercentage.Location = new System.Drawing.Point(412, 253);
            this.nudReservePercentage.Name = "nudReservePercentage";
            this.nudReservePercentage.Size = new System.Drawing.Size(205, 38);
            this.nudReservePercentage.TabIndex = 11;
            this.nudReservePercentage.ValueChanged += new System.EventHandler(this.nudReserve_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(398, 471);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(157, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Business City:";
            // 
            // cmbBusinessName
            // 
            this.cmbBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusinessName.FormattingEnabled = true;
            this.cmbBusinessName.Location = new System.Drawing.Point(412, 186);
            this.cmbBusinessName.Name = "cmbBusinessName";
            this.cmbBusinessName.Size = new System.Drawing.Size(316, 41);
            this.cmbBusinessName.TabIndex = 16;
            this.cmbBusinessName.SelectedIndexChanged += new System.EventHandler(this.cmbBusinessName_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-8, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(999, 63);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "System Water Reserver";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmWaterLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 647);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbBusinessName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.nudReservePercentage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveWaterLevel);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.prbWater);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tkblevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmWaterLevel";
            this.Text = "Water Level";
            this.Load += new System.EventHandler(this.frmWaterLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkblevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReservePercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tkblevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prbWater;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnSaveWaterLevel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudReservePercentage;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBusinessName;
        private System.Windows.Forms.TextBox textBox1;
    }
}