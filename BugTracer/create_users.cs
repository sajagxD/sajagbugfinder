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
    public partial class create_users : Form
    {
        public create_users()
        {
            InitializeComponent();

			//calling display method to display data in datagridview
			displayData();
        }


		

		//displays data when the method is called in table
		public void displayData()
		{
			//connection to database
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";
			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();
			//query to select all data form usertable from database.
			String SQL = "Select * from usertbl";
			MySqlCommand mySqlDbCmd = new MySqlCommand(SQL, myOleDbConn);

			MySqlDataAdapter sda = new MySqlDataAdapter();
			sda.SelectCommand = mySqlDbCmd;
			DataTable dbdataset = new DataTable();
			sda.Fill(dbdataset);
			BindingSource bSource = new BindingSource();

			bSource.DataSource = dbdataset;
			AllDataGridView.DataSource = bSource;
			sda.Update(dbdataset);
		}

       
		//show table when vieww is clicked
        private void button2_Click_1(object sender, EventArgs e)
        {

            String connectionString;
            connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

            MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
            myOleDbConn.Open();

            String SQL = "Select * from usertbl";
            MySqlCommand mySqlDbCmd = new MySqlCommand(SQL, myOleDbConn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = mySqlDbCmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                AllDataGridView.DataSource = bSource;
                sda.Update(dbdataset);

            }

            catch
			//(Exception ex)
			{
				MessageBox.Show("error");
            }

        }

		//code for logout
        private void button3_Click(object sender, EventArgs e)
        {
			login lgn = new login();
			this.Close();
			lgn.Show();



        }


		//datatable view  
		private void AllDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			//assigning the index for the table in datagrid view
			string uid = AllDataGridView.Rows[index].Cells[0].Value.ToString();
			string fullname = AllDataGridView.Rows[index].Cells[1].Value.ToString();
			string email = AllDataGridView.Rows[index].Cells[2].Value.ToString();
			string username = AllDataGridView.Rows[index].Cells[3].Value.ToString();
			string password = AllDataGridView.Rows[index].Cells[4].Value.ToString();
			string contact = AllDataGridView.Rows[index].Cells[5].Value.ToString();
			string gender = AllDataGridView.Rows[index].Cells[6].Value.ToString();
			string user_status = AllDataGridView.Rows[index].Cells[7].Value.ToString();

			//selected data will be shown in the textfield and combobox.
			txtid.Text = uid;
			txtfullname.Text = fullname;
			txtemail.Text = email;  
			txtusername.Text = username ;
			txtpassword.Text = password;
			txtcontact.Text = contact;
			combogender.Text = gender;
			combostatus.Text = user_status ;

		}

		
		
		//function for delete user
		private void button4_Click(object sender, EventArgs e)
		{
			//connection to database
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";
			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();

			//sql query to delete the selected row from usertable 
			String sql = String.Format("delete from usertbl where fullname='" + txtfullname.Text + "'");
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);
			try
			{
				
				cmd.ExecuteNonQuery();
				//it displays "data deleted sucessfully" when a data is deleted.
				MessageBox.Show("Data deleted successfully");
				myOleDbConn.Close();

				//this codes will make the data fields empty after the deletion of data
				txtfullname.Text = "";
				txtemail.Text = "";
				txtusername.Text = "";
				txtpassword.Text = "";
				txtcontact.Text = "";
				combogender.Text = "";
				combostatus.Text = "";

				displayData();
			}
			catch
			{
				MessageBox.Show("Data not deleted");
				return;
			}
		}

		//the below method is to add new users which is done by admin.
		private void btnadd_Click(object sender, EventArgs e)
		{
			//connection of database
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);

			myOleDbConn.Open();

			String fullname = txtfullname.Text;
			String email = txtemail.Text;
			String username = txtusername.Text;
			String password = txtpassword.Text;
			String contact = txtcontact.Text;
			String gender = combogender.Text;
			String user_status = combostatus.Text;

			//sql query to add data to table usertbl.
			String sql = String.Format("Insert Into usertbl ( fullname, email, username, password, contact, gender, user_status) Values('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}')", 
				txtfullname.Text, txtemail.Text, txtusername.Text, txtpassword.Text, txtcontact.Text, combogender.Text, combostatus.Text);
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);


			try
			{
				cmd.ExecuteNonQuery();

				txtid.Text = "";
				txtfullname.Text = "";
				txtemail.Text = "";
				txtusername.Text = "";
				txtpassword.Text = "";
				txtcontact.Text = "";
				combogender.Text = "";
				combostatus.Text = "";
				displayData();
				MessageBox.Show("data inserted success");
			}
			catch
			{
				Console.WriteLine("Bad input! Canceling request");
				return;
			}
		}

		//function to update selected data
		private void button5_Click(object sender, EventArgs e)
		{
			//databse connection
			String connectionString;
			connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";
			MySqlConnection myOleDbConn = new MySqlConnection(connectionString);
			myOleDbConn.Open();
			String u_id = txtid.Text; 
			String fullname = txtfullname.Text;
			String email = txtemail.Text;
			String username = txtusername.Text;
			String password = txtpassword.Text;
			String contact = txtcontact.Text;
			String gender = combogender.Text;
			String user_status = combostatus.Text;

			String sql = String.Format("UPDATE usertbl SET fullname= '" + txtfullname.Text + "', email='"+ txtemail.Text+ "', username='"+ txtusername.Text+ "', password='"+ txtpassword.Text+ "', contact='"+txtcontact.Text+"', gender='"+combogender.Text+"', user_status='"+ combostatus.Text + "' where u_id = '"+ txtid.Text+ "'");
			Console.WriteLine(sql);
			MySqlCommand cmd = new MySqlCommand(sql, myOleDbConn);


			try
			{
				cmd.ExecuteNonQuery();

				txtid.Text = "";
				txtfullname.Text = "";
				txtemail.Text = "";
				txtusername.Text = "";
				txtpassword.Text = "";
				txtcontact.Text = "";
				combogender.Text = "";
				combostatus.Text = "";
				displayData();

				MessageBox.Show("data updated success");
			}
			catch
			{
				Console.WriteLine("Bad input! Canceling request");
				return;
			}
		}

		private void txtfullname_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtid_TextChanged(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtid.Text = "";
			txtfullname.Text = "";
			txtemail.Text = "";
			txtusername.Text = "";
			txtpassword.Text = "";
			txtcontact.Text = "";
			combogender.Text = "";
			combostatus.Text = "";
		}
	}
}

