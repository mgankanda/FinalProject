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
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome ob = new welcome();
            ob.Show();
            this.Hide();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'passport_dbDataSet5.Applicant' table. You can move, or remove it, as needed.
            this.applicantTableAdapter2.Fill(this.passport_dbDataSet5.Applicant);
            // TODO: This line of code loads data into the 'passport_dbDataSet4.Applicant' table. You can move, or remove it, as needed.
            this.applicantTableAdapter1.Fill(this.passport_dbDataSet4.Applicant);
            // TODO: This line of code loads data into the 'passport_dbDataSet.Applicant' table. You can move, or remove it, as needed.
            this.applicantTableAdapter.Fill(this.passport_dbDataSet.Applicant);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int search = int.Parse(textSearch.Text);
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\FinalProject\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM applicant WHERE id = '"+search+"' ;";
            try
            {
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(qry, connect);
                DataSet dt = new DataSet();

                sda.Fill(dt, "details");
                dataGridView1.DataSource = dt.Tables["details"];

            }
            catch(SqlException ex)
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
