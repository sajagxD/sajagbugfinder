using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;
using Microsoft.Alm.Authentication;

namespace BugTracer
{
	public partial class home : Form
	{
		public home()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		//thid method opens create_users pannel when it picturebox2 is clicked
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			create_users cuser = new create_users();
			cuser.Show();
			//this.Hide();
		}

		//thid method opens Projects pannel when it picturebox2 is clicked
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			projects pr = new projects();
			pr.Show();
			//this.Hide();
		}

		//thid method opens bugmanager pannel when it picturebox2 is clicked
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			create_bug bugmgr = new create_bug();
			bugmgr.Show();

		}

		//thid method exits the home page and redirects login page
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			login logn = new login();
			logn.Show();
			this.Close();
			
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{

		}

		private void home_Load(object sender, EventArgs e)
		{
			label_Welcome.Text = "Welcome, " + login.uname;
		}

		
		//this option helps to clone a git project to a specific folder
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			//opens git repo in browser
			Process.Start("https://github.com/sajagxD/sajagbugfinder.git");

			var secrets = new SecretStore("git");
			var auth = new BasicAuthentication(secrets);
			var creds = auth.GetCredentials(new TargetUri("https://github.com"));

			var options = new CloneOptions
			{
				CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials
				{
					Username = creds.Username,
					Password = creds.Password
				},
			};

			Repository.Clone("https://github.com/sajagxD/sajagbugfinder.git", @"c:\projects", options);
		}

		private void label_Welcome_Click(object sender, EventArgs e)
		{

		}
	}
}
