namespace Scott_Water_App
{
    partial class StaffForm
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
            this.Admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResetEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.checkShowPass = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailUnlock = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstLockedUsers = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lstAllUsers = new System.Windows.Forms.ListBox();
            this.btnViewALL = new System.Windows.Forms.Button();
            this.lblLockedCount = new System.Windows.Forms.Label();
            this.lblAllAccountsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(20, 7);
            this.Admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(155, 26);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Admin Panel ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset User Password ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Email:";
            // 
            // txtResetEmail
            // 
            this.txtResetEmail.ForeColor = System.Drawing.Color.Black;
            this.txtResetEmail.Location = new System.Drawing.Point(150, 98);
            this.txtResetEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtResetEmail.Name = "txtResetEmail";
            this.txtResetEmail.Size = new System.Drawing.Size(102, 20);
            this.txtResetEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Location = new System.Drawing.Point(150, 130);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(102, 20);
            this.txtNewPassword.TabIndex = 5;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(202, 210);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(101, 47);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(66, 569);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 73);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Menu ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-4, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(443, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unlock User Account ";
            // 
            // txtConfirm
            // 
            this.txtConfirm.ForeColor = System.Drawing.Color.Black;
            this.txtConfirm.Location = new System.Drawing.Point(150, 160);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(102, 20);
            this.txtConfirm.TabIndex = 12;
            // 
            // checkShowPass
            // 
            this.checkShowPass.AutoSize = true;
            this.checkShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowPass.ForeColor = System.Drawing.Color.Black;
            this.checkShowPass.Location = new System.Drawing.Point(268, 132);
            this.checkShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.checkShowPass.Name = "checkShowPass";
            this.checkShowPass.Size = new System.Drawing.Size(134, 21);
            this.checkShowPass.TabIndex = 13;
            this.checkShowPass.Text = "Show Password?";
            this.checkShowPass.UseVisualStyleBackColor = true;
            this.checkShowPass.CheckedChanged += new System.EventHandler(this.checkShowPass_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(66, 210);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 47);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(727, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Register New Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(723, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Register a new user";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(444, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "User Email:";
            // 
            // txtEmailUnlock
            // 
            this.txtEmailUnlock.ForeColor = System.Drawing.Color.Black;
            this.txtEmailUnlock.Location = new System.Drawing.Point(528, 97);
            this.txtEmailUnlock.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailUnlock.Name = "txtEmailUnlock";
            this.txtEmailUnlock.Size = new System.Drawing.Size(102, 20);
            this.txtEmailUnlock.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(449, 176);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Unlock User Account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(-6, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(929, 46);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Admin Panel";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(446, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 39);
            this.label8.TabIndex = 21;
            this.label8.Text = "(Unlock a users account if they have \r\nentered password incorrect\r\n more than 3 t" +
    "imes)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(62, 280);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "View Locked Accounts\r\n";
            // 
            // lstLockedUsers
            // 
            this.lstLockedUsers.FormattingEnabled = true;
            this.lstLockedUsers.Location = new System.Drawing.Point(66, 340);
            this.lstLockedUsers.Name = "lstLockedUsers";
            this.lstLockedUsers.Size = new System.Drawing.Size(237, 173);
            this.lstLockedUsers.TabIndex = 23;
            this.lstLockedUsers.SelectedIndexChanged += new System.EventHandler(this.lstLockedUsers_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(66, 518);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 47);
            this.btnView.TabIndex = 24;
            this.btnView.Text = "Refresh Locked Accounts";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(436, 280);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "View All Accounts";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lstAllUsers
            // 
            this.lstAllUsers.FormattingEnabled = true;
            this.lstAllUsers.Location = new System.Drawing.Point(440, 340);
            this.lstAllUsers.Name = "lstAllUsers";
            this.lstAllUsers.Size = new System.Drawing.Size(237, 173);
            this.lstAllUsers.TabIndex = 26;
            // 
            // btnViewALL
            // 
            this.btnViewALL.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewALL.ForeColor = System.Drawing.Color.White;
            this.btnViewALL.Location = new System.Drawing.Point(440, 518);
            this.btnViewALL.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewALL.Name = "btnViewALL";
            this.btnViewALL.Size = new System.Drawing.Size(101, 47);
            this.btnViewALL.TabIndex = 27;
            this.btnViewALL.Text = "View All Accounts";
            this.btnViewALL.UseVisualStyleBackColor = false;
            this.btnViewALL.Click += new System.EventHandler(this.btnViewALL_Click);
            // 
            // lblLockedCount
            // 
            this.lblLockedCount.AutoSize = true;
            this.lblLockedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockedCount.ForeColor = System.Drawing.Color.Black;
            this.lblLockedCount.Location = new System.Drawing.Point(62, 313);
            this.lblLockedCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLockedCount.Name = "lblLockedCount";
            this.lblLockedCount.Size = new System.Drawing.Size(112, 15);
            this.lblLockedCount.TabIndex = 28;
            this.lblLockedCount.Text = "Locked Accounts: 0";
            this.lblLockedCount.Click += new System.EventHandler(this.RefreshLocked_Click);
            // 
            // lblAllAccountsCount
            // 
            this.lblAllAccountsCount.AutoSize = true;
            this.lblAllAccountsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllAccountsCount.ForeColor = System.Drawing.Color.Black;
            this.lblAllAccountsCount.Location = new System.Drawing.Point(438, 313);
            this.lblAllAccountsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllAccountsCount.Name = "lblAllAccountsCount";
            this.lblAllAccountsCount.Size = new System.Drawing.Size(99, 15);
            this.lblAllAccountsCount.TabIndex = 29;
            this.lblAllAccountsCount.Text = "Total Accounts: 0";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 643);
            this.Controls.Add(this.lblAllAccountsCount);
            this.Controls.Add(this.lblLockedCount);
            this.Controls.Add(this.btnViewALL);
            this.Controls.Add(this.lstAllUsers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lstLockedUsers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEmailUnlock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.checkShowPass);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResetEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResetEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.CheckBox checkShowPass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailUnlock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstLockedUsers;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstAllUsers;
        private System.Windows.Forms.Button btnViewALL;
        private System.Windows.Forms.Label lblLockedCount;
        private System.Windows.Forms.Label lblAllAccountsCount;
    }
}