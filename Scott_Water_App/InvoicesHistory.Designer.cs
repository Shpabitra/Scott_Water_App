namespace Scott_Water_App
{
    partial class frmInvoicesHistory
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
            this.dgvInvoiceHistory = new System.Windows.Forms.DataGridView();
            this.btnMainmenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBusinessName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoiceHistory
            // 
            this.dgvInvoiceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceHistory.Location = new System.Drawing.Point(82, 216);
            this.dgvInvoiceHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInvoiceHistory.Name = "dgvInvoiceHistory";
            this.dgvInvoiceHistory.RowHeadersWidth = 51;
            this.dgvInvoiceHistory.RowTemplate.Height = 24;
            this.dgvInvoiceHistory.Size = new System.Drawing.Size(614, 345);
            this.dgvInvoiceHistory.TabIndex = 0;
            // 
            // btnMainmenu
            // 
            this.btnMainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainmenu.Location = new System.Drawing.Point(322, 592);
            this.btnMainmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainmenu.Name = "btnMainmenu";
            this.btnMainmenu.Size = new System.Drawing.Size(148, 49);
            this.btnMainmenu.TabIndex = 1;
            this.btnMainmenu.Text = "Main Menu ";
            this.btnMainmenu.UseVisualStyleBackColor = true;
            this.btnMainmenu.Click += new System.EventHandler(this.btnMainmenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(686, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(1, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(773, 64);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Invoices";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Business Name: ";
            // 
            // cmbBusinessName
            // 
            this.cmbBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusinessName.FormattingEnabled = true;
            this.cmbBusinessName.Location = new System.Drawing.Point(305, 129);
            this.cmbBusinessName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBusinessName.Name = "cmbBusinessName";
            this.cmbBusinessName.Size = new System.Drawing.Size(204, 28);
            this.cmbBusinessName.TabIndex = 17;
            this.cmbBusinessName.SelectedIndexChanged += new System.EventHandler(this.cmbBusinessName_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(305, 172);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(204, 23);
            this.dtpDate.TabIndex = 19;
            // 
            // frmInvoicesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 677);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBusinessName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMainmenu);
            this.Controls.Add(this.dgvInvoiceHistory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInvoicesHistory";
            this.Text = "Invoices History";
            this.Load += new System.EventHandler(this.frmInvoicesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoiceHistory;
        private System.Windows.Forms.Button btnMainmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBusinessName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}