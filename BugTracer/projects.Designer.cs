namespace BugTracer
{
	partial class projects
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prtitle = new System.Windows.Forms.TextBox();
            this.prend = new System.Windows.Forms.DateTimePicker();
            this.prstart = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.prurl = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprid = new System.Windows.Forms.TextBox();
            this.prdisc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Projrct start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Project End";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // prtitle
            // 
            this.prtitle.Location = new System.Drawing.Point(187, 126);
            this.prtitle.Name = "prtitle";
            this.prtitle.Size = new System.Drawing.Size(200, 26);
            this.prtitle.TabIndex = 6;
            this.prtitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // prend
            // 
            this.prend.CustomFormat = "yyyy-MM-dd";
            this.prend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.prend.Location = new System.Drawing.Point(185, 225);
            this.prend.Name = "prend";
            this.prend.Size = new System.Drawing.Size(200, 26);
            this.prend.TabIndex = 9;
            // 
            // prstart
            // 
            this.prstart.CustomFormat = "yyyy-MM-dd";
            this.prstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.prstart.Location = new System.Drawing.Point(187, 174);
            this.prstart.Name = "prstart";
            this.prstart.Size = new System.Drawing.Size(198, 26);
            this.prstart.TabIndex = 10;
            this.prstart.ValueChanged += new System.EventHandler(this.prstart_ValueChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(171, 305);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 30);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Project Url";
            // 
            // prurl
            // 
            this.prurl.Location = new System.Drawing.Point(585, 225);
            this.prurl.Name = "prurl";
            this.prurl.Size = new System.Drawing.Size(297, 26);
            this.prurl.TabIndex = 14;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(357, 305);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(101, 30);
            this.btnreset.TabIndex = 15;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(555, 305);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 30);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(942, 193);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(719, 305);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(101, 30);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Project Id";
            // 
            // txtprid
            // 
            this.txtprid.Location = new System.Drawing.Point(189, 79);
            this.txtprid.Name = "txtprid";
            this.txtprid.ReadOnly = true;
            this.txtprid.Size = new System.Drawing.Size(196, 26);
            this.txtprid.TabIndex = 20;
            // 
            // prdisc
            // 
            this.prdisc.Location = new System.Drawing.Point(491, 102);
            this.prdisc.Multiline = true;
            this.prdisc.Name = "prdisc";
            this.prdisc.Size = new System.Drawing.Size(397, 89);
            this.prdisc.TabIndex = 23;
            this.prdisc.TextChanged += new System.EventHandler(this.prdisc_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(66, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Note: select data below to update, delete and view them.";
            // 
            // projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(953, 597);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prdisc);
            this.Controls.Add(this.txtprid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.prurl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.prstart);
            this.Controls.Add(this.prend);
            this.Controls.Add(this.prtitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "projects";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox prtitle;
		private System.Windows.Forms.DateTimePicker prend;
		private System.Windows.Forms.DateTimePicker prstart;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox prurl;
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtprid;
		private System.Windows.Forms.TextBox prdisc;
		private System.Windows.Forms.Label label7;
	}
}