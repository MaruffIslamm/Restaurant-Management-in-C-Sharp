using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjectXtestpilot
{
    public partial class Signup : Form
    {
        DataAccessSignup das;
        public Signup()
        {
            das = new DataAccessSignup();
            InitializeComponent();
            
           // Get_Password_Box.Text = str_password;
        }

        private void Exit_Buttom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            string name = Get_Name_Box.Text;
            string gender = Get_Gender_Box.Text;
            string id = Get_ID_Box.Text;
            string age = Get_Age_Box.Text;
            string job_position = Get_Job_Position_Box.Text;
            string present_address = Get_Present_Address_Box.Text;
            string permanent_address = Get_Permanent_Address_Box.Text;

            string username = Get_Username_Box.Text;
            string password = Get_Password_Box.Text;
            string usertype = Get_Combo_Box.Text;

            string uname = "";
            das.comm.CommandText = "Select USERNAME from Account_Table where USERNAME ='" + Get_Username_Box.Text + "'";
            das.conn.Open();
            SqlDataReader reader = das.comm.ExecuteReader();
            
            while (reader.Read())
            {
                uname = reader[0].ToString();
            }
            das.conn.Close();
            if (uname == username)
            {
                MessageBox.Show("Same username already exists");
            }
            else
            {
                das.comm.CommandText = "insert into Account_Table values ('" + name + "','" + gender + "','" + id + "','" + age + "','" + job_position + "', '" + present_address + "','" + permanent_address + "','" + username + "','" + password + "','" + usertype + "')";
                das.conn.Open();
                das.comm.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");
                das.conn.Close();
            }
        }
        
        private void Show_Password_label_Click(object sender, EventArgs e)
        {
            Get_Password_Box.UseSystemPasswordChar = true;
        }

        private void Show_Password_label_DoubleClick(object sender, EventArgs e)
        {
            Get_Password_Box.UseSystemPasswordChar = false;
        }

        private void Get_Password_Box_TextChanged(object sender, EventArgs e)
        {
            Get_Password_Box.UseSystemPasswordChar = true;
        }

        private void Get_Username_Box_TextChanged(object sender, EventArgs e)
        {
            Signup signup = new Signup();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
    public class DataAccessSignup
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessSignup()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}