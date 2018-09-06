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
    public partial class UpdateProfile : Form
    {
        string uname;
        string usertype;
        DataAccessUpdateProfile dt_updatep;
        public UpdateProfile(string str_username,string str_usertype)
        {
            InitializeComponent();
            dt_updatep = new DataAccessUpdateProfile();
            uname = str_username;
            usertype = str_usertype;
        }

        private void Exit_Buttom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Name_Button_Click(object sender, EventArgs e)
        {
            string name = Get_Name_Box.Text;
            string id = Get_ID_Box.Text;

            dt_updatep.comm.CommandText = "update Account_Table set NAME = '" + name + "' where ID = '" + id + "'";
            dt_updatep.conn.Open();
            dt_updatep.comm.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
            dt_updatep.conn.Close();
        }

        private void Update_Gender_Button_Click(object sender, EventArgs e)
        {
            string gender = Get_Gender_Box.Text;
            string id = Get_ID_Box.Text;

            dt_updatep.comm.CommandText = "update Account_Table set GENDER = '" + gender + "' where ID = '" + id + "'";
            dt_updatep.conn.Open();
            dt_updatep.comm.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
            dt_updatep.conn.Close();
        }

        private void Uppdate_Age_Button_Click(object sender, EventArgs e)
        {
            
            string age = Get_Age_Box.Text;
            string id = Get_ID_Box.Text;

            dt_updatep.comm.CommandText = "update Account_Table set AGE = '" + age + "' where ID = '" + id + "'";
            dt_updatep.conn.Open();
            dt_updatep.comm.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
            dt_updatep.conn.Close();
        }
        
        private void Update_ID_Button_Click(object sender, EventArgs e)
        {
            string id = Get_ID_Box.Text;

            dt_updatep.comm.CommandText = "update Account_Table set ID = '" + id + "' where USERNAME = '" + uname + "'";
            dt_updatep.conn.Open();
            dt_updatep.comm.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
            dt_updatep.conn.Close();
        }

        private void Update_Job_Position_Button_Click(object sender, EventArgs e)
        {
            string job_position = Get_Job_Position_Box.Text;
            string id = Get_ID_Box.Text;


            dt_updatep.comm.CommandText = "update Account_Table set JOB_POSITION = '" + job_position + "' where ID = '" + id + "'";
            dt_updatep.conn.Open();
            dt_updatep.comm.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
            dt_updatep.conn.Close();
        }

        private void Update_Present_Address_Button_Click(object sender, EventArgs e)
        {
            string present_address = Get_Present_Address_Box.Text;
            string id = Get_ID_Box.Text;


            dt_updatep.comm.CommandText = "update Account_Table set PRESENT_ADDRESS = '" + present_address + "' where ID = '" + id + "'";
            dt_updatep.conn.Open();
            dt_updatep.comm.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
            dt_updatep.conn.Close();
        }

        private void Update_Permanent_Address_Button_Click(object sender, EventArgs e)
        {
            string permanent_address = Get_Permanent_Address_Box.Text;
            string id = Get_ID_Box.Text;

            dt_updatep.comm.CommandText = "update Account_Table set PERMANENT_ADDRESS = '" + permanent_address + "' where ID = '" + id + "'";
            dt_updatep.conn.Open();
            dt_updatep.comm.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully");
            dt_updatep.conn.Close();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }



    public class DataAccessUpdateProfile
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessUpdateProfile()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
