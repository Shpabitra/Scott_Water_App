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
            this.btnMenuWaterLevel = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkblevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Water Reserver";
            // 
            // tkblevel
            // 
            this.tkblevel.Location = new System.Drawing.Point(413, 179);
            this.tkblevel.Maximum = 100;
            this.tkblevel.Name = "tkblevel";
            this.tkblevel.Size = new System.Drawing.Size(405, 45);
            this.tkblevel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Track Bar: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Progress Bar: ";
            // 
            // prbWater
            // 
            this.prbWater.Location = new System.Drawing.Point(413, 227);
            this.prbWater.Name = "prbWater";
            this.prbWater.Size = new System.Drawing.Size(405, 45);
            this.prbWater.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbWater.TabIndex = 5;
            this.prbWater.Value = 50;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(171, 293);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(307, 37);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "Current Level: 50%";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(243, 348);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(598, 37);
            this.lblWarning.TabIndex = 7;
            this.lblWarning.Text = "STATUS: NORMAL, ForeColor: Green";
            // 
            // btnSaveWaterLevel
            // 
            this.btnSaveWaterLevel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveWaterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWaterLevel.Location = new System.Drawing.Point(388, 476);
            this.btnSaveWaterLevel.Name = "btnSaveWaterLevel";
            this.btnSaveWaterLevel.Size = new System.Drawing.Size(175, 90);
            this.btnSaveWaterLevel.TabIndex = 8;
            this.btnSaveWaterLevel.Text = "SAVE";
            this.btnSaveWaterLevel.UseVisualStyleBackColor = false;
            // 
            // btnMenuWaterLevel
            // 
            this.btnMenuWaterLevel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMenuWaterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuWaterLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuWaterLevel.Location = new System.Drawing.Point(32, 24);
            this.btnMenuWaterLevel.Name = "btnMenuWaterLevel";
            this.btnMenuWaterLevel.Size = new System.Drawing.Size(175, 90);
            this.btnMenuWaterLevel.TabIndex = 9;
            this.btnMenuWaterLevel.Text = "Scot Water";
            this.btnMenuWaterLevel.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(32, 631);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(175, 90);
            this.btn.TabIndex = 10;
            this.btn.Text = "EXIT";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scott_Water_App.Properties.Resources.Scot_Water_App_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(800, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmWaterLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnMenuWaterLevel);
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
        private System.Windows.Forms.Button btnMenuWaterLevel;
        private System.Windows.Forms.Button btn;
    }
}