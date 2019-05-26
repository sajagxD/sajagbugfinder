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
	public partial class managebugs : Form
	{
		public managebugs()
		{
			InitializeComponent();
			Fillcombouser();
			displayData();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
		void Fillcombouser()
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true; convert zero datetime=True";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			String sql = "select * from usertbl";
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);
			MySqlDataReader myReader;

			try
			{
				myOleDbConn.Open();
				myReader = cmd.ExecuteReader();

				while (myReader.Read())
				{
					String tName = myReader.GetString("username");
					comboBox2.Items.Add(tName);
				}
			}
			catch
			{
				MessageBox.Show("Data not loaded");
				return;
			}
		}
		public void displayData()
		{

			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true; convert zero datetime=True";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();

			String SQL = "Select * from bugs";
			MySqlCommand mySqlDbCmd = new MySqlCommand(SQL, myOleDbConn);

			MySqlDataAdapter sda = new MySqlDataAdapter();
			sda.SelectCommand = mySqlDbCmd;
			DataTable dbdataset = new DataTable();
			sda.Fill(dbdataset);
			BindingSource bSource = new BindingSource();

			bSource.DataSource = dbdataset;
			dataGridView1.DataSource = bSource;
			sda.Update(dbdataset);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			


			int index = e.RowIndex;		
			string bugid = dataGridView1.Rows[index].Cells[0].Value.ToString();
			string bugtitle = dataGridView1.Rows[index].Cells[1].Value.ToString();
			string bugstatus = dataGridView1.Rows[index].Cells[2].Value.ToString();
			string fixeddate = dataGridView1.Rows[index].Cells[3].Value.ToString();
			string fixedby = dataGridView1.Rows[index].Cells[12].Value.ToString();
			string bugdescription = dataGridView1.Rows[index].Cells[7].Value.ToString();
			string solution = dataGridView1.Rows[index].Cells[11].Value.ToString();						
			


			


			txtbugid.Text = bugid;
			txtbugtitle.Text = bugtitle;
			comboBox1.Text = bugstatus ;
			txtbugdesc.Text = bugdescription;
			txtbugsolution.Text = solution;
			dateTimePicker1.Text = fixeddate;
			comboBox2.Text = fixedby;
			//dateTimePicker1.Text = fixeddate;
			

		}

		private void button1_Click(object sender, EventArgs e)
		{

			//databse connection
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";
			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();
			String bugid = txtbugid.Text;
			String bugtitle = txtbugtitle.Text;
			String bugstatus = comboBox1.Text;
			String bugdescription = txtbugdesc.Text;
			String solution = txtbugsolution.Text;
			String fixedby = comboBox2.Text;
			

			String sql = "UPDATE bugs SET bugstatus = '" + comboBox1.Text + "', solution='" + txtbugsolution.Text + "', fixedby = '" + comboBox2.Text + "'where bugid = '" + txtbugid.Text + "'";
			Console.WriteLine(sql);
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);


			try
			{
				cmd.ExecuteNonQuery();

				txtbugid.Text = "";
				txtbugtitle.Text = "";
				comboBox1.Text = "";
				txtbugdesc.Text = "";
				txtbugsolution.Text = "";
				
				displayData();

				MessageBox.Show("data updated success");
			}
			catch
			{
				Console.WriteLine("Bad input! Canceling request");
				return;
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txtbugsolution_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
