namespace BugManager
{
	partial class bug_manage
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.picturedemoimg = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtimg = new System.Windows.Forms.TextBox();
			this.btnbrowse = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtsrccode = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtdesc = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtmethod = new System.Windows.Forms.TextBox();
			this.txtclass = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.datereport = new System.Windows.Forms.DateTimePicker();
			this.comboprid = new System.Windows.Forms.ComboBox();
			this.combobugstatus = new System.Windows.Forms.ComboBox();
			this.txtbugtitle = new System.Windows.Forms.TextBox();
			this.textbugid = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnreset = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.comboseverity = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturedemoimg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboseverity);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.picturedemoimg);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.txtimg);
			this.panel1.Controls.Add(this.btnbrowse);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txtsrccode);
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
			this.panel1.Location = new System.Drawing.Point(7, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1050, 432);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// picturedemoimg
			// 
			this.picturedemoimg.Location = new System.Drawing.Point(622, 293);
			this.picturedemoimg.Name = "picturedemoimg";
			this.picturedemoimg.Size = new System.Drawing.Size(222, 124);
			this.picturedemoimg.TabIndex = 23;
			this.picturedemoimg.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(470, 321);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(101, 20);
			this.label11.TabIndex = 22;
			this.label11.Text = "Demo Image";
			// 
			// txtimg
			// 
			this.txtimg.Location = new System.Drawing.Point(766, 234);
			this.txtimg.Name = "txtimg";
			this.txtimg.Size = new System.Drawing.Size(221, 26);
			this.txtimg.TabIndex = 21;
			// 
			// btnbrowse
			// 
			this.btnbrowse.Location = new System.Drawing.Point(590, 229);
			this.btnbrowse.Name = "btnbrowse";
			this.btnbrowse.Size = new System.Drawing.Size(136, 37);
			this.btnbrowse.TabIndex = 20;
			this.btnbrowse.Text = "Browse";
			this.btnbrowse.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(462, 237);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(109, 20);
			this.label10.TabIndex = 19;
			this.label10.Text = "Upload Image";
			// 
			// txtsrccode
			// 
			this.txtsrccode.Location = new System.Drawing.Point(590, 132);
			this.txtsrccode.Multiline = true;
			this.txtsrccode.Name = "txtsrccode";
			this.txtsrccode.Size = new System.Drawing.Size(397, 75);
			this.txtsrccode.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(462, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 20);
			this.label9.TabIndex = 17;
			this.label9.Text = "Source Code";
			// 
			// txtdesc
			// 
			this.txtdesc.Location = new System.Drawing.Point(590, 28);
			this.txtdesc.Multiline = true;
			this.txtdesc.Name = "txtdesc";
			this.txtdesc.Size = new System.Drawing.Size(397, 75);
			this.txtdesc.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(462, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 20);
			this.label8.TabIndex = 15;
			this.label8.Text = "Bug Description";
			// 
			// txtmethod
			// 
			this.txtmethod.Location = new System.Drawing.Point(135, 339);
			this.txtmethod.Name = "txtmethod";
			this.txtmethod.Size = new System.Drawing.Size(176, 26);
			this.txtmethod.TabIndex = 14;
			// 
			// txtclass
			// 
			this.txtclass.Location = new System.Drawing.Point(135, 288);
			this.txtclass.Name = "txtclass";
			this.txtclass.Size = new System.Drawing.Size(176, 26);
			this.txtclass.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 342);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Method";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 284);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Class name";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// datereport
			// 
			this.datereport.CustomFormat = "yyyy-MM-dd";
			this.datereport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.datereport.Location = new System.Drawing.Point(135, 231);
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
			// 
			// combobugstatus
			// 
			this.combobugstatus.FormattingEnabled = true;
			this.combobugstatus.Location = new System.Drawing.Point(135, 185);
			this.combobugstatus.Name = "combobugstatus";
			this.combobugstatus.Size = new System.Drawing.Size(176, 28);
			this.combobugstatus.TabIndex = 8;
			// 
			// txtbugtitle
			// 
			this.txtbugtitle.Location = new System.Drawing.Point(135, 132);
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
			this.label5.Location = new System.Drawing.Point(15, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Report Date";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = " Bug Status";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 132);
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(23, 551);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1025, 179);
			this.dataGridView1.TabIndex = 1;
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(97, 491);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(124, 41);
			this.btnadd.TabIndex = 2;
			this.btnadd.Text = "Add Bug";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnreset
			// 
			this.btnreset.Location = new System.Drawing.Point(320, 491);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(124, 41);
			this.btnreset.TabIndex = 3;
			this.btnreset.Text = "Reset";
			this.btnreset.UseVisualStyleBackColor = true;
			this.btnreset.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(568, 491);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(124, 41);
			this.btnupdate.TabIndex = 4;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new System.EventHandler(this.button4_Click);
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(809, 491);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(124, 41);
			this.btndelete.TabIndex = 5;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.button5_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(10, 389);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 20);
			this.label12.TabIndex = 24;
			this.label12.Text = "Severity";
			// 
			// comboseverity
			// 
			this.comboseverity.FormattingEnabled = true;
			this.comboseverity.Location = new System.Drawing.Point(135, 389);
			this.comboseverity.Name = "comboseverity";
			this.comboseverity.Size = new System.Drawing.Size(176, 28);
			this.comboseverity.TabIndex = 25;
			// 
			// bug_manage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1065, 742);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btnreset);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "bug_manage";
			this.Text = "Bug Manager";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturedemoimg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker datereport;
		private System.Windows.Forms.ComboBox comboprid;
		private System.Windows.Forms.ComboBox combobugstatus;
		private System.Windows.Forms.TextBox txtbugtitle;
		private System.Windows.Forms.TextBox textbugid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picturedemoimg;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtimg;
		private System.Windows.Forms.Button btnbrowse;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtsrccode;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtdesc;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtmethod;
		private System.Windows.Forms.TextBox txtclass;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.ComboBox comboseverity;
		private System.Windows.Forms.Label label12;
	}
}

