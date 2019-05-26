using MySql.Data.MySqlClient;
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

namespace BugTracer
{
	public partial class viewproject : Form
	{
		public viewproject()
		{
			InitializeComponent();
			displayData();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{


			txtprid.Clear();
			prtitle.Clear();
			prstart.Text = "";
			prend.Text = "";
			prdisc.Clear(); ;
			prurl.Clear(); ;
		}

		private void btnadd_Click(object sender, EventArgs e)
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();

			String pr_id = txtprid.Text;
			String pr_title = prtitle.Text;
			String pr_startdate = prstart.Text;
			String pr_enddate = prend.Text;
			String pr_description = prdisc.Text;
			String pr_url = prurl.Text;

			// Format and execute SQL statement.[3
			String sql = String.Format("Insert Into projects (pr_title, pr_startdate, pr_enddate," +
				" pr_description, pr_url) Values('{0}', '{1}', '{2}','{3}','{4}')",
				prtitle.Text, prstart.Text, prend.Text, prdisc.Text, prurl.Text);
			//Console.WriteLine(sql);
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);
			try
			{


				cmd.ExecuteNonQuery();
				displayData();

				prtitle.Text = "";
				prstart.Text = "";
				prend.Text = "";
				prdisc.Text = "";
				prurl.Text = "";

			}
			catch
			{
				Console.WriteLine("Bad input! Canceling request");
				return;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			 int index = e.RowIndex;
			string pr_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
			string pr_title = dataGridView1.Rows[index].Cells[1].Value.ToString();
			string pr_startdate = dataGridView1.Rows[index].Cells[2].Value.ToString();
			string pr_enddate = dataGridView1.Rows[index].Cells[3].Value.ToString();
			string pr_discription = dataGridView1.Rows[index].Cells[4].Value.ToString();
			string pr_url = dataGridView1.Rows[index].Cells[5].Value.ToString();

			txtprid.Text = pr_id;
			prtitle.Text = pr_title;
			prstart.Text = pr_startdate;
			prend.Text = pr_enddate;
			prdisc.Text = pr_discription;
			prurl.Text = pr_url;
		}

		//method for display data
		public void displayData()
		{

			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();

			String SQL = "Select * from projects";
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
		//for deleteing data
		private void btndelete_Click(object sender, EventArgs e)
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();


			String sql = String.Format("delete from projects where pr_title='" + prtitle.Text + "'");
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);
			try
			{
				MessageBox.Show("Data deleted successfully");
				cmd.ExecuteNonQuery();
				myOleDbConn.Close();

				prtitle.Text = "";
				prstart.Text = "";
				prend.Text = "";
				prdisc.Text = "";
				prurl.Text = "";
				displayData();
			}
			catch
			{
				MessageBox.Show("Data not deleted");
				return;
			}
		}

		//for update data
		private void btnupdate_Click(object sender, EventArgs e)
		{

			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();

			String pr_id = txtprid.Text;
			String pr_title = prtitle.Text;
			String pr_startdate = prstart.Text;
			String pr_enddate = prend.Text;
			String pr_description = prdisc.Text;
			String pr_url = prurl.Text;


			// Format and execute SQL statement.[3
			Console.WriteLine(prdisc.Text);
			String sql = String.Format("update projects set pr_title='" + prtitle.Text + "', pr_startdate='" + prstart.Text + "', pr_enddate='" + prend.Text + "', pr_description='" + prdisc.Text + "', pr_url='" + prurl.Text + "' where pr_id = '" + txtprid.Text + "'");
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);


			Console.WriteLine(cmd);
			try
			{

				cmd.ExecuteNonQuery();
				displayData();

				prtitle.Text = "";
				prstart.Text = "";
				prend.Text = "";
				prdisc.Text = "";
				prurl.Text = "";

				MessageBox.Show("Data updated successfully");

			}
			catch
			{
				MessageBox.Show("Data not updated");
				return;
			}

		}

		private void prstart_ValueChanged(object sender, EventArgs e)
		{

		}

		private void prdisc_TextChanged(object sender, EventArgs e)
		{

		}

		

		private void prdisc_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void prdisc_TextChanged_2(object sender, EventArgs e)
		{

		}
	}
}
