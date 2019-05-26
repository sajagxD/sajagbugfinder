using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracer
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			create_bug cbug = new create_bug();
			cbug.Show();
		
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			this.Close();
			login lgn = new login();
			lgn.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			viewproject prj = new viewproject();
			prj.Show();
			
		}

		private void Form2_load(object sender, EventArgs e)
		{
			label_Welcome.Text = "Welcome, " + login.uname;
		}

		private void label_Welcome_Click(object sender, EventArgs e)
		{ 

		}
	}
}
