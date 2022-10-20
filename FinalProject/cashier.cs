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
        int id = 0;
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
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thisura\source\repos\FinalProject\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM applicant WHERE id = '" + search + "' ;";
            DataTable dataTable = new DataTable();
            try
            {
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(qry, connect);
                DataSet dt = new DataSet();

                sda.Fill(dt, "details");
                dataGridView1.DataSource = dt.Tables["details"];
                Console.WriteLine("Read data");
                //DataRow dataRow = dataTable.Rows[0];
                //String value = dataRow["has_paid"].ToString();

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
            refreshTable();
        }

        private void btnViewUnpaidApplicants_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thisura\source\repos\FinalProject\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM applicant WHERE has_paid = 'NotPaid';";
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
            //int search = int.Parse(textBox1.Text);
            //MessageBox.Show("" + id);
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thisura\source\repos\FinalProject\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "UPDATE Applicant SET has_paid = 'Paid' WHERE id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(qry, connect);
            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Marked as Paid");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);
            }
            finally { connect.Close(); }
            refreshTable();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            //MessageBox.Show("" + id);
            lblIDNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void refreshTable()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thisura\source\repos\FinalProject\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
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
    }
}
