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
    public partial class DeleteProfile : Form
    {
        DataAccessDeleteProfile dt_deletep;
        string str_user_name;
        string str_user_type;
        public DeleteProfile(string str_user_name,string str_user_type)
        {
            this.str_user_name = str_user_name;
            this.str_user_type = str_user_type;
            InitializeComponent();
            dt_deletep = new DataAccessDeleteProfile();
        }

        private DataTable Get_Profile()
        {
            DataTable dt_profile = new DataTable();

            // SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Signin_Table where Username ='" + Get_Username_Box.Text + "'and Password ='" + Get_Password_Box.Text + "'");
            dt_deletep.comm.CommandText = "Select * from Account_Table";
            dt_deletep.conn.Open();
            SqlDataReader reader = dt_deletep.comm.ExecuteReader();
            dt_profile.Load(reader);
            dt_deletep.conn.Close();
            return dt_profile;
        }

        private void DeleteProfile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Delete_Profile_DataGridView.DataSource = Get_Profile();
            this.Delete_Profile_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Delete_Profile_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void Exit_Buttom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string uname = Get_Username_Box.Text;
            string id = Get_ID_Box.Text;

            dt_deletep.comm.CommandText = "delete from Account_Table where USERNAME ='" + Get_Username_Box.Text + "'and ID ='" + Get_ID_Box.Text + "'";
            dt_deletep.conn.Open();
            dt_deletep.comm.ExecuteNonQuery();

            MessageBox.Show("Deleted Successfully");
            dt_deletep.conn.Close();
        }
    }

    public class DataAccessDeleteProfile
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessDeleteProfile()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
