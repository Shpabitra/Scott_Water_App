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
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblLinkRegisterBusiness = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInvHistory = new System.Windows.Forms.Button();
            this.btnAddNewBusiness = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBox1.Location = new System.Drawing.Point(804, -194);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(325, 190);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(175, 90);
            this.btnReturnToMainMenu.TabIndex = 4;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // lblLinkRegisterBusiness
            // 
            this.lblLinkRegisterBusiness.AutoSize = true;
            this.lblLinkRegisterBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkRegisterBusiness.Location = new System.Drawing.Point(366, 303);
            this.lblLinkRegisterBusiness.Name = "lblLinkRegisterBusiness";
            this.lblLinkRegisterBusiness.Size = new System.Drawing.Size(285, 29);
            this.lblLinkRegisterBusiness.TabIndex = 7;
            this.lblLinkRegisterBusiness.TabStop = true;
            this.lblLinkRegisterBusiness.Text = "Register New Business";
            this.lblLinkRegisterBusiness.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkRegisterBusiness_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Could Not Find the Business ? ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(428, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 90);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(12, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 90);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInvHistory
            // 
            this.btnInvHistory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInvHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvHistory.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInvHistory.Location = new System.Drawing.Point(623, 94);
            this.btnInvHistory.Name = "btnInvHistory";
            this.btnInvHistory.Size = new System.Drawing.Size(175, 90);
            this.btnInvHistory.TabIndex = 10;
            this.btnInvHistory.Text = "INVOICE";
            this.btnInvHistory.UseVisualStyleBackColor = false;
            this.btnInvHistory.Click += new System.EventHandler(this.btnInvHistory_Click);
            // 
            // btnAddNewBusiness
            // 
            this.btnAddNewBusiness.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBusiness.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddNewBusiness.Location = new System.Drawing.Point(217, 94);
            this.btnAddNewBusiness.Name = "btnAddNewBusiness";
            this.btnAddNewBusiness.Size = new System.Drawing.Size(175, 90);
            this.btnAddNewBusiness.TabIndex = 11;
            this.btnAddNewBusiness.Text = "ADD NEW";
            this.btnAddNewBusiness.UseVisualStyleBackColor = false;
            this.btnAddNewBusiness.Click += new System.EventHandler(this.btnAddNewBusiness_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-2, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(975, 63);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Login";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(804, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // frmBusinessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 344);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.btnInvHistory);
            this.Controls.Add(this.btnAddNewBusiness);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLinkRegisterBusiness);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBusinessView";
            this.Text = "Business View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.LinkLabel lblLinkRegisterBusiness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInvHistory;
        private System.Windows.Forms.Button btnAddNewBusiness;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}