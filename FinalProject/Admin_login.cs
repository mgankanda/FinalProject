using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            //check data validation
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
            String selectQ = "SELECT * FROM admin_user WHERE username = '" + username + "' AND password = '" + password + "';";
            SqlCommand cmd = new SqlCommand(selectQ, con);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //Check the role
            try
            {
                con.Open();
                DA.Fill(dt);
                int i = cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    MessageBox.Show("Successfully logged in...");
                    String role = row["role"].ToString().Trim();
                    //Console.WriteLine("Role is selected as " + role + " .Trailing characters");
                    if (role == "cash")
                    {
                        this.Hide();
                        cashier gk = new cashier();
                        gk.Show();
                        //Console.WriteLine("logged in as " + role);
                    }
                    else if (role == "recep")
                    {
                        this.Hide();
                        Receptionist rece = new Receptionist();
                        rece.Show();
                        //Console.WriteLine("logged in as " + role);
                    }
                    else if (role == "dist")
                    {
                        this.Hide();
                        Distributer dis = new Distributer();
                        dis.Show();
                        //Console.WriteLine("logged in as " + role);
                    }
                    else if (role == "papersup")
                    {
                        this.Hide();
                        PaperSupplier paper = new PaperSupplier();
                        paper.Show();
                        //Console.WriteLine("logged in as " + role);
                    }
                    else if (role == "logisup")
                    {
                        this.Hide();
                        LogisticPartner logi = new LogisticPartner();
                        logi.Show();
                        //Console.WriteLine("logged in as " + role);
                    }

                    else
                    {
                        MessageBox.Show("Error!!! Can't show window. Role is " + role);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                    //txtUsername.Focus();
                }
            }
            catch (SqlException msg)
            {
                MessageBox.Show("Error!!! \n Please Try agian later "+msg);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
