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
    public partial class Stock_Record : Form
    {
        DataAccessStock dt_stock;
        public Stock_Record()
        {
            dt_stock = new DataAccessStock();
            InitializeComponent();
        }
        private DataTable Get_Stock()
        {
            DataTable get_stock = new DataTable();

            dt_stock.comm.CommandText = "Select * from Stock_Table";
            dt_stock.conn.Open();
            SqlDataReader reader = dt_stock.comm.ExecuteReader();
            get_stock.Load(reader);
            dt_stock.conn.Close();
            return get_stock;
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            Stock_DataGridView.DataSource = Get_Stock();
            this.Stock_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Stock_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }


        private void Stock_Record_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            DateTime nDate = DateTime.Now;
            Get_Update_Date_Box.Text = nDate.ToString("d/M/yyyy");
            Get_Update_Time_Box.Text = nDate.ToString("HH:mm:ss");
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            String item_code = Get_Item_Code_Box.Text;
            String item_name = Get_Item_Name_Box.Text;
            String quantity = Get_Quantity_Box.Text;
            String price = Get_Price_Box.Text;
            String available = Get_Available_Box.Text;
            String update_date = Get_Update_Date_Box.Text;
            String update_time = Get_Update_Time_Box.Text;

            dt_stock.conn.Open();
            dt_stock.comm.CommandText= "insert into Stock_Table values ('" + item_code + "','" + item_name + "','" + quantity + "','" + price + "','" + available + "', '" + update_date + "','" + update_time + "')";
            dt_stock.comm.ExecuteNonQuery();
            MessageBox.Show("Added Successfully");
            dt_stock.conn.Close();
        }

        private void Get_Available_Box_Click(object sender, EventArgs e)
        {
            Get_Available_Box.Text = "";
        }

        private DataTable Get_Search_Stock()
        {
            String item_code = Get_Item_Code_Box.Text;

            DataTable get_search_stock = new DataTable();
            dt_stock.comm.CommandText = "Select * from Stock_Table where ITEM_CODE = '"+ item_code +"'";
            dt_stock.conn.Open();
            SqlDataReader reader = dt_stock.comm.ExecuteReader();
            get_search_stock.Load(reader);
            dt_stock.conn.Close();
            return get_search_stock;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Stock_DataGridView.DataSource = Get_Search_Stock();
            this.Stock_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Stock_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            String item_code = Get_Item_Code_Box.Text;
            dt_stock.conn.Open();
            dt_stock.comm.CommandText = "delete Stock_Table where ITEM_CODE = '" + item_code + "'";
            dt_stock.comm.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully");
            dt_stock.conn.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Get_Item_Code_Box_TextChanged(object sender, EventArgs e)
        {
            Get_Item_Name_Box.Text = "";
            Get_Quantity_Box.Text = "";
            Get_Price_Box.Text = "";
            Get_Available_Box.Text = "";
        }
    }

    public class DataAccessStock
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessStock()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
