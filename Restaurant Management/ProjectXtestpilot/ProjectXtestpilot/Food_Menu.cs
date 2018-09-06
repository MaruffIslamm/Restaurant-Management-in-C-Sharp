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
    public partial class Food_Menu : Form
    {
        string str_username;
        string str_usertype;
        DataAccessFood dt_food;
        public Food_Menu(String str_username, String str_usertype)
        {
            this.str_username = str_username;
            this.str_usertype = str_usertype;
            dt_food = new DataAccessFood();
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Manager" || this.str_usertype == "Admin")
            {
                string item_name = Get_Item_Name_Box.Text;
                int price = Convert.ToInt32(Get_Price_Box.Text);
                int food_id = Convert.ToInt32(Get_Food_ID_Box.Text);

                dt_food.comm.CommandText = "insert into Food_Table values ('" + food_id + "','" + item_name + "','" + price + "')";
                dt_food.conn.Open();
                dt_food.comm.ExecuteNonQuery();

                MessageBox.Show("Added Successfully");
                dt_food.conn.Close();
            }
            else
            {
                MessageBox.Show("Sorry,You are not authorized");
            }
        }

        private void Show_Food_Button_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Manager" || this.str_usertype == "Admin")
            {
                Food_Menu_DataGridView.DataSource = Get_Food();
                this.Food_Menu_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                this.Food_Menu_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            }
            else
            {
                MessageBox.Show("Sorry,You are not authorized");
            }
        }
        private DataTable Get_Food()
        {
            DataTable get_food = new DataTable();

                dt_food.comm.CommandText = "Select * from Food_Table";
                dt_food.conn.Open();
                SqlDataReader reader = dt_food.comm.ExecuteReader();
                get_food.Load(reader);
                dt_food.conn.Close();
                return get_food;
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Admin" || this.str_usertype == "Manager")
            {
                int food_id = Convert.ToInt32(Get_Food_ID_Box.Text);
                dt_food.comm.CommandText = "Delete from Food_Table where FOOD_ID = '" + food_id + "'";
                dt_food.conn.Open();
                dt_food.comm.ExecuteNonQuery();
                MessageBox.Show("Removed Successfully");
                dt_food.conn.Close();
            }
            else
            {
                MessageBox.Show("Sorry,You are not authorized");
            }
        }

        private void Food_Menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }

    public class DataAccessFood
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessFood()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
