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
    public partial class MyProfile : Form
    {
        string str_username;
        string str_usertype;
        DataAccessMyProfile dt_mp;
        public MyProfile(String str_username,String str_usertype)
        {
            this.str_username = str_username;
            this.str_usertype = str_usertype;

            dt_mp = new DataAccessMyProfile();
            InitializeComponent();
            //textBox1.Text = uname;
        }
        private void Exit_Buttom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            Profile_DataGridView.DataSource = Get_Profile();
            this.Profile_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Profile_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }
        private DataTable Get_Profile()
        {
            DataTable dt_profile = new DataTable();

            // SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Signin_Table where Username ='" + Get_Username_Box.Text + "'and Password ='" + Get_Password_Box.Text + "'");
            if (this.str_usertype == "Admin")
            {
                //dt_mp.comm.CommandText = "Select * from Account_Table where USERNAME ='" + uname + "'";
                dt_mp.comm.CommandText = "Select * from Account_Table";
                dt_mp.conn.Open();
                SqlDataReader reader = dt_mp.comm.ExecuteReader();
                dt_profile.Load(reader);
                dt_mp.conn.Close();
                return dt_profile;
            }
            else
            {
                dt_mp.comm.CommandText = "Select * from Account_Table where USERNAME ='" + str_username + "'";
                dt_mp.conn.Open();
                SqlDataReader reader = dt_mp.comm.ExecuteReader();
                dt_profile.Load(reader);
                dt_mp.conn.Close();
                return dt_profile;
            }

        }
        //showing data without pressing show button
        private void MyProfile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Profile_DataGridView.DataSource = Get_Profile();
            this.Profile_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Profile_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }
    }

    public class DataAccessMyProfile
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessMyProfile()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
