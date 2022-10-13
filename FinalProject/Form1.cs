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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int UserNic = int.Parse(textNic.Text);
            String ApplicantName = textName.Text;
            String PhoneNumber = textPhone.Text;
            String Address = textAddress.Text;
            String Disctric = comboBox1.Text;
            String ServiceType = comboBox2.Text;
            String AppoitmentDate = textdate.Text; //still not in data base
            String Payment = comboBox3.Text;
            String PaymentNumber = textPaymentNumber.Text;

            if (UserNic == 0 || ApplicantName == "" || PhoneNumber == "" || Address == "")
            {
                MessageBox.Show("pleace enter values");
                textName.Focus();
            }
            else
            {
                //Insert data into database
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\FinalProject\passport_db.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "INSERT INTO Applicant (nic_number,name,phone_number,address,district,service_type,has_paid, receipt_number, appointment_date) VALUES('" + UserNic + "','" + ApplicantName + "','" + PhoneNumber + "','" + Address + "','" + Disctric + "','" + ServiceType + "' ,'" + Payment + "', '" + PaymentNumber+ "', '" + AppoitmentDate + "');";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You are succesfully Registered !!!");
                }
                catch (SqlException msg)
                {
                    MessageBox.Show("Error!!!\n Please Try agian later");
                    Console.WriteLine(msg.Message);
                }
                finally
                {
                    con.Close();
                }
            }


            //hide this page 
            welcome fm = new welcome();
            fm.Show();
            this.Hide();
        }
    }
}
