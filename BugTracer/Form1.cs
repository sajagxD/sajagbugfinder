using MySql.Data.MySqlClient;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//Fillcombo();
		}

		void Fillcombo()
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			String sql = "select * from bugs";
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);
			MySqlDataReader myReader;

			try
			{
				myOleDbConn.Open();
				myReader = cmd.ExecuteReader();

				while (myReader.Read())
				{
					String tName = myReader.GetString("bugid");
					comboBox3.Items.Add(tName);
				}
			}
			catch
			{
				MessageBox.Show("Data not loaded");
				return;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);

			myOleDbConn.Open();



			//String sql = String.Format("UPDATE allbugs SET = '" + txtfullname.Text + "', email='" + txtemail.Text + "', username='" + txtusername.Text + "', password='" + txtpassword.Text + "', contact='" + txtcontact.Text + "', gender='" + combogender.Text + "', user_status='" + combostatus.Text + "' where u_id = '" + txtid.Text + "'");
			//Console.WriteLine(Mysql);
			//MySqlCommand cmd = new MySqlCommand(Mysql, myOleDbConn);

		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
