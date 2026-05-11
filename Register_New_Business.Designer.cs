// 1. Add this field declaration at the top of the component declarations (after line 59):
this.txtTopBar = new System.Windows.Forms.TextBox();

// 2. Add this initialization code in the InitializeComponent method (add after line 61, before the btnMenu section):
// 
// txtTopBar
// 
this.txtTopBar.BackColor = System.Drawing.Color.Teal;
this.txtTopBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
this.txtTopBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtTopBar.ForeColor = System.Drawing.SystemColors.Window;
this.txtTopBar.Location = new System.Drawing.Point(-3, -1);
this.txtTopBar.Multiline = true;
this.txtTopBar.Name = "txtTopBar";
this.txtTopBar.ReadOnly = true;
this.txtTopBar.Size = new System.Drawing.Size(1968, 63);
this.txtTopBar.TabIndex = 30;
this.txtTopBar.Text = "Register New Business";
this.txtTopBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

// 3. Add this line to the Controls.Add section (add after line 394, or near the beginning of the Controls.Add block):
this.Controls.Add(this.txtTopBar);

// 4. Add this field declaration at the bottom in the #endregion section (after line 465):
private System.Windows.Forms.TextBox txtTopBar;