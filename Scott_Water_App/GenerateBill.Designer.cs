namespace Scott_Water_App
{
    partial class frmGenerateBill
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
            this.cmbBusinessName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReadingDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnBacktoMeterReading = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business Name:";
            // 
            // cmbBusinessName
            // 
            this.cmbBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusinessName.FormattingEnabled = true;
            this.cmbBusinessName.Location = new System.Drawing.Point(381, 117);
            this.cmbBusinessName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBusinessName.Name = "cmbBusinessName";
            this.cmbBusinessName.Size = new System.Drawing.Size(447, 54);
            this.cmbBusinessName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date: ";
            // 
            // dtpReadingDate
            // 
            this.dtpReadingDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReadingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReadingDate.Location = new System.Drawing.Point(381, 207);
            this.dtpReadingDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpReadingDate.Name = "dtpReadingDate";
            this.dtpReadingDate.Size = new System.Drawing.Size(447, 53);
            this.dtpReadingDate.TabIndex = 3;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateBill.Location = new System.Drawing.Point(596, 314);
            this.btnGenerateBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(233, 111);
            this.btnGenerateBill.TabIndex = 4;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // btnBacktoMeterReading
            // 
            this.btnBacktoMeterReading.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBacktoMeterReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoMeterReading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBacktoMeterReading.Location = new System.Drawing.Point(319, 314);
            this.btnBacktoMeterReading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBacktoMeterReading.Name = "btnBacktoMeterReading";
            this.btnBacktoMeterReading.Size = new System.Drawing.Size(233, 111);
            this.btnBacktoMeterReading.TabIndex = 5;
            this.btnBacktoMeterReading.Text = "Back To Meter Reading";
            this.btnBacktoMeterReading.UseVisualStyleBackColor = false;
            this.btnBacktoMeterReading.Click += new System.EventHandler(this.btnBacktoMeterReading_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(31, 314);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(233, 111);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(868, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-12, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1065, 78);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Generate Bill";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 453);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnBacktoMeterReading);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.dtpReadingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBusinessName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGenerateBill";
            this.Text = "Generate Bill";
            this.Load += new System.EventHandler(this.frmGenerateBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBusinessName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpReadingDate;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Button btnBacktoMeterReading;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}