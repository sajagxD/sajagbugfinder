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
	public partial class login : Form
    {
		public static string uname;
		public login()
        {
            InitializeComponent();
        }

        

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String connectionString;
            connectionString = "server=localhost;database=bugtracker;user id=root;password=;integrated security=true";

            MySqlConnection mysqlConn = new MySqlConnection(connectionString);
			String query = "Select * from usertbl where username = '" + txtuname.Text.Trim() + "' and password = '" + txtpassword.Text.Trim() + "' ";
				//"and userstatus = '" +comboBox1.Text.Trim()"' ";

			MySqlDataAdapter sda = new MySqlDataAdapter(query, mysqlConn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

			String userstatus = comboBox1.Text;

            if (txtuname.Text != "" && txtpassword.Text != "" && comboBox1.Text != "")
            {
                if (dtbl.Rows.Count == 1)	            {
					switch (userstatus) {
						case "Admin":
							 home hom = new home();
							uname = txtuname.Text.Trim();

							hom.Show();
							this.Hide();
								break;
						case "Tester":
							Form2 testerlogin = new Form2();
							testerlogin.Show();

							
							this.Hide();
							break;
						case "Programmer":
						
							uname = txtuname.Text.Trim();
							homedebuger mgbugs = new  homedebuger();
							mgbugs.Show();

						
							this.Hide();
							break;
						default:
							MessageBox.Show("select user type");
							break;
					}
                    
                }
                else
                {
                    MessageBox.Show("incorrect username or password");
                }
            }
            else {
                MessageBox.Show("Please fill all field! ");
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("contact your admin for password.");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void login_Load(object sender, EventArgs e)
		{

		}
	}
}
