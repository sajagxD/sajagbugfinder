namespace BugTracer
{
	partial class managebugs
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
			this.txtbugid = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtbugtitle = new System.Windows.Forms.TextBox();
			this.txtbugdesc = new System.Windows.Forms.RichTextBox();
			this.txtbugsolution = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bug Id";
			// 
			// txtbugid
			// 
			this.txtbugid.Location = new System.Drawing.Point(209, 53);
			this.txtbugid.Name = "txtbugid";
			this.txtbugid.ReadOnly = true;
			this.txtbugid.Size = new System.Drawing.Size(211, 26);
			this.txtbugid.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Bug Title";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Bug Status";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 253);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Bug Description";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(509, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Solution";
			// 
			// txtbugtitle
			// 
			this.txtbugtitle.Location = new System.Drawing.Point(209, 114);
			this.txtbugtitle.Name = "txtbugtitle";
			this.txtbugtitle.ReadOnly = true;
			this.txtbugtitle.Size = new System.Drawing.Size(211, 26);
			this.txtbugtitle.TabIndex = 8;
			// 
			// txtbugdesc
			// 
			this.txtbugdesc.Location = new System.Drawing.Point(209, 233);
			this.txtbugdesc.Name = "txtbugdesc";
			this.txtbugdesc.Size = new System.Drawing.Size(211, 84);
			this.txtbugdesc.TabIndex = 9;
			this.txtbugdesc.Text = "";
			// 
			// txtbugsolution
			// 
			this.txtbugsolution.Location = new System.Drawing.Point(513, 88);
			this.txtbugsolution.Name = "txtbugsolution";
			this.txtbugsolution.Size = new System.Drawing.Size(380, 122);
			this.txtbugsolution.TabIndex = 10;
			this.txtbugsolution.Text = "";
			this.txtbugsolution.TextChanged += new System.EventHandler(this.txtbugsolution_TextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Honeydew;
			this.button1.Location = new System.Drawing.Point(95, 373);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 42);
			this.button1.TabIndex = 11;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightCoral;
			this.button2.Location = new System.Drawing.Point(298, 373);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 42);
			this.button2.TabIndex = 12;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(19, 444);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(874, 205);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "Doing",
            "Completed"});
			this.comboBox1.Location = new System.Drawing.Point(215, 182);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(205, 28);
			this.comboBox1.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(501, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 20);
			this.label6.TabIndex = 15;
			this.label6.Text = "Fixed By";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(625, 250);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(148, 28);
			this.comboBox2.TabIndex = 16;
			this.comboBox2.Text = "select";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(505, 309);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 20);
			this.label7.TabIndex = 18;
			this.label7.Text = "Fixed Date";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(625, 311);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
			this.dateTimePicker1.TabIndex = 19;
			// 
			// managebugs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(915, 661);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtbugsolution);
			this.Controls.Add(this.txtbugdesc);
			this.Controls.Add(this.txtbugtitle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtbugid);
			this.Controls.Add(this.label1);
			this.Name = "managebugs";
			this.Text = "managebugs";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtbugid;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtbugtitle;
		private System.Windows.Forms.RichTextBox txtbugdesc;
		private System.Windows.Forms.RichTextBox txtbugsolution;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}