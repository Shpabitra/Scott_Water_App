namespace Scott_Water_App
{
    partial class frmBusinessView
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
            this.dgvBusiness = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExitBusiness = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dudSearchBusiness = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusiness
            // 
            this.dgvBusiness.AllowUserToOrderColumns = true;
            this.dgvBusiness.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusiness.Location = new System.Drawing.Point(90, 214);
            this.dgvBusiness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBusiness.Name = "dgvBusiness";
            this.dgvBusiness.Size = new System.Drawing.Size(753, 403);
            this.dgvBusiness.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(20, 20);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 90);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Scot Water";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(63, 994);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(262, 100);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(796, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnExitBusiness
            // 
            this.btnExitBusiness.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExitBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitBusiness.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExitBusiness.Location = new System.Drawing.Point(20, 648);
            this.btnExitBusiness.Name = "btnExitBusiness";
            this.btnExitBusiness.Size = new System.Drawing.Size(175, 90);
            this.btnExitBusiness.TabIndex = 4;
            this.btnExitBusiness.Text = "EXIT";
            this.btnExitBusiness.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Business:";
            // 
            // dudSearchBusiness
            // 
            this.dudSearchBusiness.Location = new System.Drawing.Point(417, 180);
            this.dudSearchBusiness.Name = "dudSearchBusiness";
            this.dudSearchBusiness.Size = new System.Drawing.Size(372, 20);
            this.dudSearchBusiness.TabIndex = 6;
            // 
            // frmBusinessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.dudSearchBusiness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitBusiness);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvBusiness);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBusinessView";
            this.Text = "Business View";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusiness;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExitBusiness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudSearchBusiness;
    }
}