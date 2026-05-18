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
            this.components = new System.ComponentModel.Container();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dudBusinessName = new System.Windows.Forms.DomainUpDown();
            this.dtpReadingDate = new System.Windows.Forms.DateTimePicker();
            this.nudUsageUnits = new System.Windows.Forms.NumericUpDown();
            this.nudRecycleUnits = new System.Windows.Forms.NumericUpDown();
            this.btnSaveReading = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReserveLevel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudUsageUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecycleUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.Location = new System.Drawing.Point(71, 504);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(219, 112);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Business Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reading Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fresh Water Units:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 339);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 46);
            this.label5.TabIndex = 7;
            this.label5.Text = "Recycle Water Units:";
            // 
            // dudBusinessName
            // 
            this.dudBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudBusinessName.Location = new System.Drawing.Point(479, 106);
            this.dudBusinessName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dudBusinessName.Name = "dudBusinessName";
            this.dudBusinessName.ReadOnly = true;
            this.dudBusinessName.Size = new System.Drawing.Size(424, 53);
            this.dudBusinessName.TabIndex = 10;
            this.dudBusinessName.SelectedItemChanged += new System.EventHandler(this.dudBusinessName_SelectedItemChanged);
            // 
            // dtpReadingDate
            // 
            this.dtpReadingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReadingDate.Location = new System.Drawing.Point(479, 189);
            this.dtpReadingDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpReadingDate.Name = "dtpReadingDate";
            this.dtpReadingDate.Size = new System.Drawing.Size(423, 53);
            this.dtpReadingDate.TabIndex = 11;
            this.dtpReadingDate.ValueChanged += new System.EventHandler(this.dtpReadingDate_ValueChanged);
            // 
            // nudUsageUnits
            // 
            this.nudUsageUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUsageUnits.Location = new System.Drawing.Point(479, 271);
            this.nudUsageUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudUsageUnits.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudUsageUnits.Name = "nudUsageUnits";
            this.nudUsageUnits.Size = new System.Drawing.Size(268, 46);
            this.nudUsageUnits.TabIndex = 17;
            // 
            // nudRecycleUnits
            // 
            this.nudRecycleUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRecycleUnits.Location = new System.Drawing.Point(479, 341);
            this.nudRecycleUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudRecycleUnits.Name = "nudRecycleUnits";
            this.nudRecycleUnits.Size = new System.Drawing.Size(268, 46);
            this.nudRecycleUnits.TabIndex = 18;
            // 
            // btnSaveReading
            // 
            this.btnSaveReading.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveReading.Location = new System.Drawing.Point(528, 504);
            this.btnSaveReading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveReading.Name = "btnSaveReading";
            this.btnSaveReading.Size = new System.Drawing.Size(219, 112);
            this.btnSaveReading.TabIndex = 19;
            this.btnSaveReading.Text = "Save Reading";
            this.btnSaveReading.UseVisualStyleBackColor = false;
            this.btnSaveReading.Click += new System.EventHandler(this.btnSaveReading_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "Current Reserve Level:";
            // 
            // txtReserveLevel
            // 
            this.txtReserveLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserveLevel.Location = new System.Drawing.Point(479, 408);
            this.txtReserveLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReserveLevel.Name = "txtReserveLevel";
            this.txtReserveLevel.Size = new System.Drawing.Size(266, 53);
            this.txtReserveLevel.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(952, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-2, -4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1136, 79);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Meter Reading";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(301, 504);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(219, 112);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMeterReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1135, 641);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtReserveLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaveReading);
            this.Controls.Add(this.nudRecycleUnits);
            this.Controls.Add(this.nudUsageUnits);
            this.Controls.Add(this.dtpReadingDate);
            this.Controls.Add(this.dudBusinessName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMeterReading";
            this.Text = "Meter Reading";
            this.Load += new System.EventHandler(this.frmMeterReading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUsageUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecycleUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown dudBusinessName;
        private System.Windows.Forms.DateTimePicker dtpReadingDate;
        private System.Windows.Forms.NumericUpDown nudUsageUnits;
        private System.Windows.Forms.NumericUpDown nudRecycleUnits;
        private System.Windows.Forms.Button btnSaveReading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReserveLevel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClear;
    }
}