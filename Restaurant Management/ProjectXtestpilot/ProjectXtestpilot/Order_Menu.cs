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
    public partial class Order_Menu : Form
    {
        string str_username;
        string str_usertype;
        DataAccessOrderFood order_food;
        public Order_Menu(String str_username, String str_usertype)
        {
            this.str_username = str_username;
            this.str_usertype = str_usertype;
            order_food = new DataAccessOrderFood();
            InitializeComponent();
        }

        private DataTable Get_OrderFood()
        {
            DataTable get_orderfood = new DataTable();

            order_food.comm.CommandText = "Select * from Food_Table";
            order_food.conn.Open();
            SqlDataReader reader = order_food.comm.ExecuteReader();
            get_orderfood.Load(reader);
            order_food.conn.Close();
            return get_orderfood;
        }

        private DataTable Get_AddFood()
        {
            string food_id = Get_Food_ID_Box.Text;
            string quantity = Get_Quantity_Box.Text;
            
            DataTable get_addfood = new DataTable();

            order_food.comm.CommandText = "Select * from Food_Table where FOOD_ID = ('" + food_id + "')";
            //order_food.comm.CommandText = "insert into Order_Table FOOD_ID,ITEM_NAME,PRICE,QUANTITY from Food_Table where FOOD_ID = ('" + food_id + "')";

            order_food.conn.Open();
            
            SqlDataReader reader = order_food.comm.ExecuteReader();
            get_addfood.Load(reader);
            order_food.conn.Close();
            return get_addfood;
        }

        private DataTable Get_Price()
        {
            string food_id = Get_Food_ID_Box.Text;
            int quantity = Convert.ToInt32(Get_Quantity_Box.Text);
            //string quantity = Get_Quantity_Box.Text;

            DataTable get_foodprice = new DataTable();

            //CORRECT//order_food.comm.CommandText = "Select PRICE*('" + quantity + "') as Total from Order_Table where FOOD_ID='" + food_id + "'";

            order_food.comm.CommandText = "Insert into Bill_Table (Total) Select PRICE*('" + quantity + "') as Total from Order_Table where FOOD_ID='" + food_id + "'";
            order_food.comm.CommandText = "Select * from Bill_Table ";

            //order_food.comm.CommandText = "insert into Order_Table FOOD_ID,ITEM_NAME,PRICE,QUANTITY from Food_Table where FOOD_ID = ('" + food_id + "')";

            order_food.conn.Open();

            order_food.comm.ExecuteNonQuery();
            SqlDataReader reader = order_food.comm.ExecuteReader();
            get_foodprice.Load(reader);
            order_food.conn.Close();
            return get_foodprice;

        }

        /* //showing data without pressing show button
         private void Order_Menu_Load(object sender, EventArgs e)
         {
             Order_Menu_DataGridView.DataSource = Get_OrderFood();
             this.Order_Menu_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
             this.Order_Menu_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
         }*/

        private void Show_Button_Click(object sender, EventArgs e)
        {
            Order_Menu_DataGridView.DataSource = Get_OrderFood();
            this.Order_Menu_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Order_Menu_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void Add_Buttom_Click(object sender, EventArgs e)
        {
            //int food_id = int.Parse(Get_Food_ID_Box.Text);
            //int quantity = int.Parse(Get_Quantity_Box.Text);
            string food_id = Get_Food_ID_Box.Text;
            int quantity = Convert.ToInt32 (Get_Quantity_Box.Text);
           // int quantity = Convert.ToInt32(quantity_s);
            //int x = Convert.ToInt32(TextBoxD1.Text);

            //order_food.comm.CommandText= "Select FOOD_ID,ITEM_NAME,PRICE from Food_Table where FOOD_ID = ('" + food_id + "')";
            //int price = int.Parse(price_s);
            //order_food.comm.CommandText = "insert into Order_Table(FOOD_ID,ITEM_NAME,PRICE,TOTAL is (PRICE*'quantity')) Select FOOD_ID,ITEM_NAME,PRICE from Food_Table where FOOD_ID = ('" + food_id + "')";
            order_food.comm.CommandText = "insert into Order_Table(FOOD_ID,ITEM_NAME,PRICE) Select FOOD_ID,ITEM_NAME,PRICE from Food_Table where FOOD_ID = ('" + food_id + "')";

           // order_food.comm.CommandText = "select * from Food_Table,Order_Table";
            //order_food.comm.CommandText = "insert into Order_Table values('" + Convert.ToInt32(quantity) + "')";

            order_food.conn.Open();
            order_food.comm.ExecuteNonQuery();

            MessageBox.Show("Added Successfully");
            order_food.conn.Close();
            /*     
            //order_food.comm.CommandText = "insert into Order_Table (QUANTITY) values('" + quantity + "') Select QUANTITY From Order_Table where FOOD_ID=('"+food_id+"')";
            
            order_food.conn.Open();
            order_food.comm.CommandText = "Select PRICE*('"+quantity+"') as Total from Order_Table where FOOD_ID='" + food_id + "'";
            order_food.comm.ExecuteNonQuery();

            MessageBox.Show("Added Successfully");
            order_food.conn.Close();
            */
            

            Added_Items_DataGridView.DataSource = Get_AddFood();
            this.Added_Items_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Added_Items_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            Price_DataGridView.DataSource = Get_Price();
            this.Price_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Price_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class DataAccessOrderFood
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessOrderFood()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
