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
	public partial class homedebuger : Form
	{
		public homedebuger()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			projects prj = new projects();
			prj.Show();

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			managebugs mgb = new managebugs();
			mgb.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
			login ln = new login();
			ln.Show();
		}

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
