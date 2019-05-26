namespace BugTracer
{
    partial class create_users
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnadd = new System.Windows.Forms.Button();
			this.txtfullname = new System.Windows.Forms.TextBox();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.txtusername = new System.Windows.Forms.TextBox();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.combostatus = new System.Windows.Forms.ComboBox();
			this.AllDataGridView = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtcontact = new System.Windows.Forms.TextBox();
			this.combogender = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.AllDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Full Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 244);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Username";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 326);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(59, 581);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "User Status";
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(74, 690);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(119, 38);
			this.btnadd.TabIndex = 5;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// txtfullname
			// 
			this.txtfullname.AccessibleName = "txtFullname";
			this.txtfullname.Location = new System.Drawing.Point(74, 119);
			this.txtfullname.Name = "txtfullname";
			this.txtfullname.Size = new System.Drawing.Size(283, 26);
			this.txtfullname.TabIndex = 6;
			this.txtfullname.TextChanged += new System.EventHandler(this.txtfullname_TextChanged);
			// 
			// txtemail
			// 
			this.txtemail.AccessibleName = "txtEmail";
			this.txtemail.Location = new System.Drawing.Point(74, 204);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(283, 26);
			this.txtemail.TabIndex = 7;
			// 
			// txtusername
			// 
			this.txtusername.AccessibleName = "txtUsername";
			this.txtusername.Location = new System.Drawing.Point(74, 282);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(283, 26);
			this.txtusername.TabIndex = 8;
			// 
			// txtpassword
			// 
			this.txtpassword.AccessibleName = "txtPassword";
			this.txtpassword.Location = new System.Drawing.Point(74, 363);
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.Size = new System.Drawing.Size(283, 26);
			this.txtpassword.TabIndex = 9;
			// 
			// combostatus
			// 
			this.combostatus.AccessibleName = "status";
			this.combostatus.FormattingEnabled = true;
			this.combostatus.Items.AddRange(new object[] {
            "Admin",
            "Programmer",
            "Debugger",
            "Tester"});
			this.combostatus.Location = new System.Drawing.Point(74, 619);
			this.combostatus.Name = "combostatus";
			this.combostatus.Size = new System.Drawing.Size(281, 28);
			this.combostatus.TabIndex = 10;
			this.combostatus.Text = "Select User Status";
			// 
			// AllDataGridView
			// 
			this.AllDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AllDataGridView.Location = new System.Drawing.Point(424, 80);
			this.AllDataGridView.Name = "AllDataGridView";
			this.AllDataGridView.RowTemplate.Height = 28;
			this.AllDataGridView.Size = new System.Drawing.Size(664, 294);
			this.AllDataGridView.TabIndex = 11;
			this.AllDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllDataGridView_CellContentClick);
			// 
			// button2
			// 
			this.button2.AccessibleName = "viewtable";
			this.button2.Location = new System.Drawing.Point(467, 435);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 38);
			this.button2.TabIndex = 12;
			this.button2.Text = "View Table";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(863, 435);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(104, 38);
			this.button4.TabIndex = 14;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(671, 435);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(95, 38);
			this.button5.TabIndex = 15;
			this.button5.Text = "Update";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(59, 407);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 20);
			this.label6.TabIndex = 16;
			this.label6.Text = "Contact";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(59, 493);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 20);
			this.label7.TabIndex = 17;
			this.label7.Text = "Gender";
			// 
			// txtcontact
			// 
			this.txtcontact.Location = new System.Drawing.Point(74, 451);
			this.txtcontact.Name = "txtcontact";
			this.txtcontact.Size = new System.Drawing.Size(283, 26);
			this.txtcontact.TabIndex = 18;
			// 
			// combogender
			// 
			this.combogender.FormattingEnabled = true;
			this.combogender.Items.AddRange(new object[] {
            "male",
            "female",
            "others"});
			this.combogender.Location = new System.Drawing.Point(74, 534);
			this.combogender.Name = "combogender";
			this.combogender.Size = new System.Drawing.Size(283, 28);
			this.combogender.TabIndex = 19;
			this.combogender.Text = "Select Gender";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.txtid);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.combogender);
			this.panel1.Controls.Add(this.txtcontact);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.btnadd);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtfullname);
			this.panel1.Controls.Add(this.combostatus);
			this.panel1.Controls.Add(this.txtemail);
			this.panel1.Controls.Add(this.txtpassword);
			this.panel1.Controls.Add(this.txtusername);
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(418, 783);
			this.panel1.TabIndex = 20;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(247, 690);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 38);
			this.button1.TabIndex = 20;
			this.button1.Text = "Reset";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(74, 44);
			this.txtid.Name = "txtid";
			this.txtid.ReadOnly = true;
			this.txtid.Size = new System.Drawing.Size(283, 26);
			this.txtid.TabIndex = 21;
			this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(55, 10);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 20);
			this.label9.TabIndex = 20;
			this.label9.Text = "User Id";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1120, 33);
			this.menuStrip1.TabIndex = 21;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(463, 525);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(405, 20);
			this.label8.TabIndex = 22;
			this.label8.Text = "Tips: select table row which you want to delete or update";
			// 
			// create_users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(1120, 814);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.AllDataGridView);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "create_users";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create Users";
			((System.ComponentModel.ISupportInitialize)(this.AllDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox combostatus;
        private System.Windows.Forms.DataGridView AllDataGridView;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtcontact;
		private System.Windows.Forms.ComboBox combogender;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label9;
	}
}