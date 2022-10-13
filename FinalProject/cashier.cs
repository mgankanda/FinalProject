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
    public partial class cashier : Form
    {
        public cashier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome ob = new welcome();
            ob.Show();
            this.Hide();
        }

        private void cashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'passport_dbDataSet6.Applicant' table. You can move, or remove it, as needed.
            this.applicantTableAdapter1.Fill(this.passport_dbDataSet6.Applicant);
            // TODO: This line of code loads data into the 'passport_dbDataSet1.Applicant' table. You can move, or remove it, as needed.
            this.applicantTableAdapter.Fill(this.passport_dbDataSet1.Applicant);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int search = int.Parse(textBox1.Text);
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\FinalProject\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM applicant WHERE id = '" + search + "' ;";
            DataTable dataTable = new DataTable();
            try
            {
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(qry, connect);
                DataSet dt = new DataSet();

                sda.Fill(dt, "details");
                dataGridView1.DataSource = dt.Tables["details"];
                DataRow dataRow = dataTable.Rows[0];
                String value = dataRow["has_paid"].ToString();               

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\FinalProject\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM applicant ;";
            try
            {
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(qry, connect);
                DataSet dt = new DataSet();

                sda.Fill(dt, "details");
                dataGridView1.DataSource = dt.Tables["details"];

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnViewUnpaidApplicants_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\FinalProject\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM applicant WHERE has_paid = 'offline';";
            try
            {
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(qry, connect);
                DataSet dt = new DataSet();

                sda.Fill(dt, "details");
                dataGridView1.DataSource = dt.Tables["details"];

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int search = int.Parse(textBox1.Text);

        }
    }
}
