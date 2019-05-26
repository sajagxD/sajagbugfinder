namespace BugTracer
{
	partial class viewproject
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
			this.prdisc = new System.Windows.Forms.TextBox();
			this.txtprid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.prurl = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.prstart = new System.Windows.Forms.DateTimePicker();
			this.prend = new System.Windows.Forms.DateTimePicker();
			this.prtitle = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// prdisc
			// 
			this.prdisc.Location = new System.Drawing.Point(471, 49);
			this.prdisc.Multiline = true;
			this.prdisc.Name = "prdisc";
			this.prdisc.ReadOnly = true;
			this.prdisc.Size = new System.Drawing.Size(397, 89);
			this.prdisc.TabIndex = 41;
			this.prdisc.TextChanged += new System.EventHandler(this.prdisc_TextChanged_2);
			// 
			// txtprid
			// 
			this.txtprid.Location = new System.Drawing.Point(169, 26);
			this.txtprid.Name = "txtprid";
			this.txtprid.ReadOnly = true;
			this.txtprid.Size = new System.Drawing.Size(196, 26);
			this.txtprid.TabIndex = 39;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 38;
			this.label1.Text = "Project Id";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 286);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(832, 228);
			this.dataGridView1.TabIndex = 36;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// prurl
			// 
			this.prurl.Location = new System.Drawing.Point(565, 172);
			this.prurl.Name = "prurl";
			this.prurl.ReadOnly = true;
			this.prurl.Size = new System.Drawing.Size(297, 26);
			this.prurl.TabIndex = 33;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(467, 178);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 20);
			this.label6.TabIndex = 32;
			this.label6.Text = "Project Url";
			// 
			// prstart
			// 
			this.prstart.CustomFormat = "yyyy-MM-dd";
			this.prstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.prstart.Location = new System.Drawing.Point(167, 121);
			this.prstart.Name = "prstart";
			this.prstart.Size = new System.Drawing.Size(198, 26);
			this.prstart.TabIndex = 30;
			// 
			// prend
			// 
			this.prend.CustomFormat = "yyyy-MM-dd";
			this.prend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.prend.Location = new System.Drawing.Point(165, 172);
			this.prend.Name = "prend";
			this.prend.Size = new System.Drawing.Size(200, 26);
			this.prend.TabIndex = 29;
			// 
			// prtitle
			// 
			this.prtitle.Location = new System.Drawing.Point(167, 73);
			this.prtitle.Name = "prtitle";
			this.prtitle.ReadOnly = true;
			this.prtitle.Size = new System.Drawing.Size(200, 26);
			this.prtitle.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 20);
			this.label5.TabIndex = 27;
			this.label5.Text = "Project End";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 20);
			this.label4.TabIndex = 26;
			this.label4.Text = "Projrct start";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(467, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 20);
			this.label3.TabIndex = 25;
			this.label3.Text = "Project Description";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 24;
			this.label2.Text = "Project Title";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Cornsilk;
			this.label7.Location = new System.Drawing.Point(59, 239);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(297, 20);
			this.label7.TabIndex = 42;
			this.label7.Text = "Note: select the data below to view them ";
			// 
			// viewproject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(902, 534);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.prdisc);
			this.Controls.Add(this.txtprid);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.prurl);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.prstart);
			this.Controls.Add(this.prend);
			this.Controls.Add(this.prtitle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "viewproject";
			this.Text = "viewproject";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox prdisc;
		private System.Windows.Forms.TextBox txtprid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox prurl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker prstart;
		private System.Windows.Forms.DateTimePicker prend;
		private System.Windows.Forms.TextBox prtitle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
	}
}