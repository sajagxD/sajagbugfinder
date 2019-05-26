﻿namespace BugTracer
{
	partial class create_bug
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
			this.comboseverity = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnreset = new System.Windows.Forms.Button();
			this.txtdesc = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtmethod = new System.Windows.Forms.TextBox();
			this.txtclass = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnadd = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.btndelete = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.datereport = new System.Windows.Forms.DateTimePicker();
			this.comboprid = new System.Windows.Forms.ComboBox();
			this.txtbugtitle = new System.Windows.Forms.TextBox();
			this.textbugid = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnupdate = new System.Windows.Forms.Button();
			this.combobugstatus = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtendline = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtstartline = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboseverity
			// 
			this.comboseverity.FormattingEnabled = true;
			this.comboseverity.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
			this.comboseverity.Location = new System.Drawing.Point(135, 301);
			this.comboseverity.Name = "comboseverity";
			this.comboseverity.Size = new System.Drawing.Size(176, 28);
			this.comboseverity.TabIndex = 25;
			this.comboseverity.Text = "choose";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 304);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 20);
			this.label12.TabIndex = 24;
			this.label12.Text = "Severity";
			// 
			// btnreset
			// 
			this.btnreset.Location = new System.Drawing.Point(317, 445);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(124, 41);
			this.btnreset.TabIndex = 9;
			this.btnreset.Text = "Reset";
			this.btnreset.UseVisualStyleBackColor = true;
			this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
			// 
			// txtdesc
			// 
			this.txtdesc.Location = new System.Drawing.Point(590, 36);
			this.txtdesc.Multiline = true;
			this.txtdesc.Name = "txtdesc";
			this.txtdesc.Size = new System.Drawing.Size(397, 75);
			this.txtdesc.TabIndex = 16;
			this.txtdesc.TextChanged += new System.EventHandler(this.txtdesc_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(442, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 20);
			this.label8.TabIndex = 15;
			this.label8.Text = "Bug Description";
			// 
			// txtmethod
			// 
			this.txtmethod.Location = new System.Drawing.Point(590, 309);
			this.txtmethod.Name = "txtmethod";
			this.txtmethod.Size = new System.Drawing.Size(176, 26);
			this.txtmethod.TabIndex = 14;
			// 
			// txtclass
			// 
			this.txtclass.Location = new System.Drawing.Point(590, 251);
			this.txtclass.Name = "txtclass";
			this.txtclass.Size = new System.Drawing.Size(176, 26);
			this.txtclass.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(442, 309);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Method";
			// 
			// btnadd
			// 
			this.btnadd.BackColor = System.Drawing.Color.ForestGreen;
			this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnadd.ForeColor = System.Drawing.Color.Cornsilk;
			this.btnadd.Location = new System.Drawing.Point(91, 445);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(124, 41);
			this.btnadd.TabIndex = 8;
			this.btnadd.Text = "Add Bug";
			this.btnadd.UseVisualStyleBackColor = false;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(442, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 20);
			this.label9.TabIndex = 17;
			this.label9.Text = "Source Code";
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(806, 445);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(124, 41);
			this.btndelete.TabIndex = 11;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(442, 251);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Class name";
			// 
			// datereport
			// 
			this.datereport.CustomFormat = "yyyy-MM-dd";
			this.datereport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.datereport.Location = new System.Drawing.Point(135, 251);
			this.datereport.Name = "datereport";
			this.datereport.Size = new System.Drawing.Size(176, 26);
			this.datereport.TabIndex = 10;
			// 
			// comboprid
			// 
			this.comboprid.FormattingEnabled = true;
			this.comboprid.Location = new System.Drawing.Point(135, 83);
			this.comboprid.Name = "comboprid";
			this.comboprid.Size = new System.Drawing.Size(176, 28);
			this.comboprid.TabIndex = 9;
			this.comboprid.Text = "Choose project Id";
			this.comboprid.SelectedIndexChanged += new System.EventHandler(this.comboprid_SelectedIndexChanged);
			// 
			// txtbugtitle
			// 
			this.txtbugtitle.Location = new System.Drawing.Point(135, 141);
			this.txtbugtitle.Name = "txtbugtitle";
			this.txtbugtitle.Size = new System.Drawing.Size(176, 26);
			this.txtbugtitle.TabIndex = 7;
			// 
			// textbugid
			// 
			this.textbugid.Location = new System.Drawing.Point(135, 25);
			this.textbugid.Name = "textbugid";
			this.textbugid.ReadOnly = true;
			this.textbugid.Size = new System.Drawing.Size(176, 26);
			this.textbugid.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 251);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Report Date";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = " Bug Status";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Bug Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Project Id";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bug Id";
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(565, 445);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(124, 41);
			this.btnupdate.TabIndex = 10;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
			// 
			// combobugstatus
			// 
			this.combobugstatus.FormattingEnabled = true;
			this.combobugstatus.Items.AddRange(new object[] {
            "Pending",
            "Doing",
            "Completed"});
			this.combobugstatus.Location = new System.Drawing.Point(135, 200);
			this.combobugstatus.Name = "combobugstatus";
			this.combobugstatus.Size = new System.Drawing.Size(176, 28);
			this.combobugstatus.TabIndex = 8;
			this.combobugstatus.Text = "choose";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.txtendline);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.txtstartline);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.comboseverity);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtdesc);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtmethod);
			this.panel1.Controls.Add(this.txtclass);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.datereport);
			this.panel1.Controls.Add(this.comboprid);
			this.panel1.Controls.Add(this.combobugstatus);
			this.panel1.Controls.Add(this.txtbugtitle);
			this.panel1.Controls.Add(this.textbugid);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(4, -3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1069, 432);
			this.panel1.TabIndex = 6;
			// 
			// txtendline
			// 
			this.txtendline.Location = new System.Drawing.Point(592, 358);
			this.txtendline.Name = "txtendline";
			this.txtendline.Size = new System.Drawing.Size(174, 26);
			this.txtendline.TabIndex = 30;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(442, 364);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(66, 20);
			this.label11.TabIndex = 29;
			this.label11.Text = "End line";
			// 
			// txtstartline
			// 
			this.txtstartline.Location = new System.Drawing.Point(139, 358);
			this.txtstartline.Name = "txtstartline";
			this.txtstartline.Size = new System.Drawing.Size(172, 26);
			this.txtstartline.TabIndex = 28;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(15, 361);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 20);
			this.label10.TabIndex = 27;
			this.label10.Text = "Start Line";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(590, 132);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(397, 81);
			this.richTextBox1.TabIndex = 26;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 575);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1061, 267);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(723, 520);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(283, 26);
			this.searchTextBox.TabIndex = 13;
			this.searchTextBox.Text = "\r\n";
			this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(561, 523);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(129, 20);
			this.label13.TabIndex = 14;
			this.label13.Text = "Search For Bugs";
			// 
			// projectsBindingSource
			// 
			this.projectsBindingSource.DataSource = typeof(BugTracer.projects);
			// 
			// create_bug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(1085, 865);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnreset);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.panel1);
			this.Name = "create_bug";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report Bugs";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox comboseverity;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.TextBox txtdesc;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtmethod;
		private System.Windows.Forms.TextBox txtclass;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker datereport;
		private System.Windows.Forms.ComboBox comboprid;
		private System.Windows.Forms.TextBox txtbugtitle;
		private System.Windows.Forms.TextBox textbugid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.ComboBox combobugstatus;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.BindingSource projectsBindingSource;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtendline;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtstartline;
		private System.Windows.Forms.Label label10;
	}
}