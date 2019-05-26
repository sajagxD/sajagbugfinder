using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracer
{
	public partial class create_bug : Form
	{
		public create_bug()
		{
			InitializeComponent();
			Fillcombo();
			displayData();
		}

		void Fillcombo()
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true; convert zero datetime=True";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			String sql = "select * from projects";
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);
			MySqlDataReader myReader;

			try
			{
				myOleDbConn.Open();
				myReader = cmd.ExecuteReader();

				while (myReader.Read())
				{
					String tName = myReader.GetString("pr_id");
					comboprid.Items.Add(tName);
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

		private void btnadd_Click(object sender, EventArgs e)
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true; convert zero datetime=True";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);

			myOleDbConn.Open();

			String bug_title = txtbugtitle.Text;
			String bug_status = combobugstatus.Text;
			String bug_reportdate = datereport.Text;
			String bug_classname = txtclass.Text;
			String bug_method = txtmethod.Text;
			String bug_severity = comboseverity.Text;
			String bug_bugdescription = txtdesc.Text;
			String bug_sourcecode = richTextBox1.Text;
			String startline = txtstartline.Text;
			String endline = txtendline.Text;
			String bug_pr_id = comboprid.Text;

			String sql = String.Format("Insert Into bugs (bugtitle, bugstatus, reportdate, classname, method, severity, bugdescription, sourcecode, startline, endline, pr_id) Values('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
				txtbugtitle.Text, combobugstatus.Text, datereport.Text, txtclass.Text, txtmethod.Text, comboseverity.Text, txtdesc.Text, richTextBox1.Text, txtstartline.Text, txtendline.Text, comboprid.Text);
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);


			try
			{
				cmd.ExecuteNonQuery();

				displayData();

				txtbugtitle.Text = "";
				combobugstatus.Text = "";
				datereport.Text = "";
				txtclass.Text = "";
				txtmethod.Text = "";
				comboseverity.Text = "";
				txtdesc.Text = "";
				richTextBox1.Text = "";
				txtstartline.Text = "";
				txtendline.Text = "";
				comboprid.Text = "";

				MessageBox.Show("data inserted success");


			}
			catch
			{
				Console.WriteLine("Bad input! Canceling request");
				return;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}



		private void picturedemoimg_Click(object sender, EventArgs e)
		{

		}

		private void txtimg_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboprid_SelectedIndexChanged(object sender, EventArgs e)
		{

		}



		//Syntax to highlight
		public Regex keyWords = new Regex("abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|" +
		"foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|" +
			"string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|volatile|void|while|");
		//For Syntax Color Changing
		//[DllImport("user32.dll")] // import lockwindow to remove flashing

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				//LockWindowUpdate(richTextBox1.Handle);
				//Highlight every found word from keyWords.
				//Get the last cursor position in the richTextBox1.
				int selPos = richTextBox1.SelectionStart;
				//For each match from the regex, highlight the word.
				foreach (Match keyWordMatch in keyWords.Matches(richTextBox1.Text))
				{
					richTextBox1.Select(keyWordMatch.Index, keyWordMatch.Length);
					richTextBox1.SelectionColor = Color.Blue;
					richTextBox1.SelectionStart = selPos;
					richTextBox1.SelectionColor = Color.Black;
				}
			}
			catch (Exception)
			{

			}
			//finally { LockWindowUpdate(IntPtr.Zero); }

		}


		private void txtdesc_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnupdate_Click(object sender, EventArgs e)
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();

			String bugtitle = txtbugtitle.Text;
			String bugstatus =combobugstatus.Text;
			String reportdate = datereport.Text;
			String classname = txtclass.Text;
			String method = txtmethod.Text;
			String severity = comboseverity.Text;
			String bugdescription = txtdesc.Text;
			String sourcecode = richTextBox1.Text;
			String startline = txtstartline.Text;
			String endline = txtendline.Text;
			String pr_id = comboprid.Text;
			String bugid = textbugid.Text;

			


			// Format and execute SQL statement.[3
			//Console.WriteLine(prdisc.Text);
			String sql = "update bugs set bugtitle='" + txtbugtitle.Text + "', bugstatus='" + combobugstatus.Text + "', reportdate='" + datereport.Text + "', classname='" + txtclass.Text + "', method='" + txtmethod.Text + "', severity='" + comboseverity.Text + "', bugdescription='" + txtdesc.Text + "', sourcecode='" + richTextBox1.Text + "', startline='" + txtstartline.Text + "' where bugid = '" + textbugid.Text + "'";
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);


			Console.WriteLine(cmd);
			try
			{

				cmd.ExecuteNonQuery();
				displayData();

				//displayData();

				txtbugtitle.Text = "";
				combobugstatus.Text = "";
				datereport.Text = "";
				txtclass.Text = "";
				txtmethod.Text = "";
				comboseverity.Text = "";
				txtdesc.Text = "";
				richTextBox1.Text = "";
				txtstartline.Text = "";
				txtendline.Text = "";
				comboprid.Text = "";



				MessageBox.Show("Data updated successfully");

			}
			catch
			{
				MessageBox.Show("Data not updated");
				return;
			}
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			string bugid = dataGridView1.Rows[index].Cells[0].Value.ToString();
			string bugtitle = dataGridView1.Rows[index].Cells[1].Value.ToString();
			string bugstatus = dataGridView1.Rows[index].Cells[2].Value.ToString();
			string reportdate = dataGridView1.Rows[index].Cells[3].Value.ToString();
			string classname = dataGridView1.Rows[index].Cells[4].Value.ToString();
			string method = dataGridView1.Rows[index].Cells[5].Value.ToString();
			string severity = dataGridView1.Rows[index].Cells[6].Value.ToString();
			string bugdescription = dataGridView1.Rows[index].Cells[7].Value.ToString();
			string sourcecode = dataGridView1.Rows[index].Cells[8].Value.ToString();
			string startline = dataGridView1.Rows[index].Cells[9].Value.ToString();
			string endline = dataGridView1.Rows[index].Cells[10].Value.ToString();
			string pr_id = dataGridView1.Rows[index].Cells[11].Value.ToString();

			textbugid.Text = bugid;
			txtbugtitle.Text = bugtitle;
			combobugstatus.Text = bugstatus;
			datereport.Text = reportdate;
			txtclass.Text = classname;
			txtmethod.Text = method;
			comboseverity.Text = severity;
			txtdesc.Text = bugdescription;
			richTextBox1.Text = sourcecode;
			txtstartline.Text = startline;
			txtendline.Text = endline;
			comboprid.Text = pr_id;
			


		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			string BugKey = searchTextBox.Text.Trim();
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true; convert zero datetime=True";
			MySqlConnection conn = new MySqlConnection(connectionString);
			MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM bugs WHERE bugtitle LIKE '%" + BugKey + "%' OR bugdescription LIKE '%" + txtdesc + "%'", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;

		}

		private void btnreset_Click(object sender, EventArgs e)
		{
			textbugid.Text = "";
			txtbugtitle.Text = "";
			combobugstatus.Text = "";
			datereport.Text = "";
			txtclass.Text = "";
			txtmethod.Text = "";
			comboseverity.Text = "";
			txtdesc.Text = "";
			richTextBox1.Text = "";
			txtstartline.Text = "";
			txtendline.Text = "";
			comboprid.Text = "";
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true; convert zero datetime=True";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);

			myOleDbConn.Open();

			//sql query to delete the selected row from usertable 
			String sql = String.Format("delete from bugs where bugtitle='" + txtbugtitle.Text + "'");
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);
			try
			{

				cmd.ExecuteNonQuery();
				//it displays "data deleted sucessfully" when a data is deleted.
				MessageBox.Show("Data deleted successfully");
				//myOleDbConn.Close();

				//this codes will make the data fields empty after the deletion of data

				textbugid.Text = "";
				txtbugtitle.Text = "";
				combobugstatus.Text = "";
				datereport.Text = "";
				txtclass.Text = "";
				txtmethod.Text = "";
				comboseverity.Text = "";
				txtdesc.Text = "";
				richTextBox1.Text = "";
				txtstartline.Text = "";
				txtendline.Text = "";
				comboprid.Text = "";


				displayData();
			}

			catch
			{
				MessageBox.Show("Data not deleted");
				return;
			}
		}
	}
}


