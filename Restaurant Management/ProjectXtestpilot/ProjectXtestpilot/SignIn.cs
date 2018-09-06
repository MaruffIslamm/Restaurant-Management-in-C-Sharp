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
    public partial class SignIn : Form
    {
        string str_usertype;
        string str_username;
        DataAccess dt;
        public SignIn()
        {
            dt= new DataAccess();
            InitializeComponent();
        }

        private void Get_Username_Box_TextChanged(object sender, EventArgs e)
        {
            Get_Password_Box.Text = "";
        }

        private void Get_Password_Box_TextChanged(object sender, EventArgs e)
        {
            //Get_Password_Box.Text = "";
            Get_Password_Box.UseSystemPasswordChar = true;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signin_Button_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string usertype;

            username = Get_Username_Box.Text;
            password = Get_Password_Box.Text;
            usertype = Get_Combo_Box.Text;

            // SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Signin_Table where Username ='" + Get_Username_Box.Text + "'and Password ='" + Get_Password_Box.Text + "'");
            dt.comm.CommandText = "Select * from Account_Table where USERNAME ='" + Get_Username_Box.Text + "'and PASSWORD ='" + Get_Password_Box.Text + "'and USERTYPE ='" + Get_Combo_Box.Text + "'";
            dt.conn.Open();
            SqlDataReader reader = dt.comm.ExecuteReader();
            //MessageBox.Show("Save Successfull");
 
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Successfully Logged in");
                this.Hide();

                this.str_username = username;
                this.str_usertype = usertype;
                Main si = new Main(username,usertype);
                si.Show();
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate username and password");
            }
            else
            {
                MessageBox.Show(" username or password or usertype incorrect");
            }
              dt.conn.Close();
        }

        private void Show_Password_label_Click(object sender, EventArgs e)
        {
            Get_Password_Box.UseSystemPasswordChar = false;
        }

        private void Show_Password_label_DoubleClick(object sender, EventArgs e)
        {
            Get_Password_Box.UseSystemPasswordChar = true;
        }

        private void Account_Line_Label_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class DataAccess
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccess()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
