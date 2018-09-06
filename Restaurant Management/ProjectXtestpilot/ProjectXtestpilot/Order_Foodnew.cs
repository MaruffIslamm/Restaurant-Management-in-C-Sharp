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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectXtestpilot
{
    public partial class Order_Foodnew : Form
    {
        string str_usertype;
        string str_username;
       
        String operation;
        Double firstnum;
        Double secondnum;
        Double answer;
        Double interest_tax = 15.00;

        Double chicken_fry;
        Double french_fry;
        Double burger;
        Double pizza;
        Double kabab;
        Double chicken_grill;
        Double fried_rice;
        Double vegetable_curry;
        Double chicken_curry;
        Double beef_curry;
        Double tea;
        Double coffee;
        Double cold_drinks;
        Double water;

        Double us_dollar = 78.00;
        Double canadian_dollar = 65.00;
        Double indian_rupee = 1.30;
        Double bangladesh_taka = 1.00;

        Double unitprice1;
        Double unitprice2;
        Double unitprice3;
        Double unitprice4;
        Double unitprice5;
        Double unitprice6;
        Double unitprice7;
        Double unitprice8;
        Double unitprice9;
        Double unitprice10;
        Double unitprice11;
        Double unitprice12;
        Double unitprice13;
        Double unitprice14;

        DataAccessOrderFoodnew OrderFood;
        public Order_Foodnew(string str_username, string str_usertype)
        {
            this.str_username = str_username;
            this.str_usertype = str_usertype;
            OrderFood = new DataAccessOrderFoodnew();
            InitializeComponent();
        }

        private DataTable Get_MenuFood()
        {

            DataTable get_menufood = new DataTable();

            OrderFood.comm.CommandText = "Select * from Food_Table";
            //order_food.comm.CommandText = "insert into Order_Table FOOD_ID,ITEM_NAME,PRICE,QUANTITY from Food_Table where FOOD_ID = ('" + food_id + "')";

            OrderFood.conn.Open();

            SqlDataReader reader = OrderFood.comm.ExecuteReader();
            get_menufood.Load(reader);
            OrderFood.conn.Close();
            return get_menufood;
        }
        private DataTable Get_OrderMenu()
        {

            DataTable get_ordermenu = new DataTable();

            OrderFood.comm.CommandText = "Select * from Order_Table";
            //order_food.comm.CommandText = "insert into Order_Table FOOD_ID,ITEM_NAME,PRICE,QUANTITY from Food_Table where FOOD_ID = ('" + food_id + "')";

            OrderFood.conn.Open();

            SqlDataReader reader = OrderFood.comm.ExecuteReader();
            get_ordermenu.Load(reader);
            OrderFood.conn.Close();
            return get_ordermenu;
        }
        private void Show_Button_Click(object sender, EventArgs e)
        {
            Food_Menu_DataGridView.DataSource = Get_MenuFood();
            this.Food_Menu_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Food_Menu_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void Show_Order_Button_Click(object sender, EventArgs e)
        {
            Order_DataGridView.DataSource = Get_OrderMenu();
            this.Order_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Order_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

 

        private void Button_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (Get_Display_Calc_Box.Text == "0")
            {
                Get_Display_Calc_Box.Text = num.Text;
            }
            else
            {
                Get_Display_Calc_Box.Text = Get_Display_Calc_Box.Text + num.Text;
            }
        }
        /*
        private void Order_Foodnew_Load(object sender, EventArgs e)
        {
            OrderFood.conn.Open();
            
            
            SqlDataAdapter sda = new SqlDataAdapter();
            OrderFood.comm.CommandText = "Select * from Order_Table";
            DataTable t = new DataTable();
            SqlDataReader reader = OrderFood.comm.ExecuteReader();
            sda.Fill(t);
            OrderFood.conn.Close();
        }*/

        private void Calc_Operator(object sender, EventArgs e)
        {
            Button ops = (Button)sender;
            firstnum = Double.Parse(Get_Display_Calc_Box.Text);
            Get_Display_Calc_Box.Text = "";
            operation = ops.Text;
            Show_Calc_Display_Label.Text = System.Convert.ToString(firstnum) + " " + operation;
        }

        private void Equal_Calc_Button_Click(object sender, EventArgs e)
        {
            Show_Calc_Display_Label.Text = "";
             
            secondnum = Double.Parse(Get_Display_Calc_Box.Text);
            switch(operation)
            {
                case "+":
                    {
                        answer = firstnum + secondnum;
                        Get_Display_Calc_Box.Text = System.Convert.ToString(answer);
                        break;
                    }
                case "-":
                    {
                        answer = firstnum - secondnum;
                        Get_Display_Calc_Box.Text = System.Convert.ToString(answer);
                        break;
                    }
                case "/":
                    {
                        answer = firstnum / secondnum;
                        Get_Display_Calc_Box.Text = System.Convert.ToString(answer);
                        break;
                    }
                case "*":
                    {
                        answer = firstnum * secondnum;
                        Get_Display_Calc_Box.Text = System.Convert.ToString(answer);
                        break;
                    }
            }
        }

        private void Backspace_Button_Click(object sender, EventArgs e)
        {
            if(Get_Display_Calc_Box.Text.Length>0)
            {
                Get_Display_Calc_Box.Text = Get_Display_Calc_Box.Text.Remove(Get_Display_Calc_Box.Text.Length - 1, 1);
            }
        }

        private void Point_Calc_Button_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if(Point_Calc_Button.Text==".")
            {
                Get_Display_Calc_Box.Text = Get_Display_Calc_Box.Text + Point_Calc_Button.Text;
            }
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            Get_Display_Calc_Box.Text = "";
            Show_Calc_Display_Label.Text = "";
            Get_Display_Calc_Box.Text = "0";
        }

        private void currencyConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currency_Converter_Button.Visible = false;
        }

        private void Currency_Converter_Button_Click(object sender, EventArgs e)
        {
            Currency_Converter_Button.Visible = false;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currency_Converter_Button.Visible = true;
        }

        private void Close_Converter_Button_Click(object sender, EventArgs e)
        {
            Currency_Converter_Button.Visible = true;
        }

        private void Order_Foodnew_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Get_Conversion_Country_ComboBox.Text = "Choose any One";
            Get_Conversion_Country_ComboBox.Items.Add("USA");
            Get_Conversion_Country_ComboBox.Items.Add("Canada");
            Get_Conversion_Country_ComboBox.Items.Add("India");
            Get_Conversion_Country_ComboBox.Items.Add("Bangladesh");

            DateTime nDate = DateTime.Now;
            Get_Order_Date_Box.Text = nDate.ToString("d/M/yyyy");
            Get_Order_Time_Box.Text = nDate.ToString("HH:mm:ss");

            Get_Chicken_Fry_Qty_Box.Text = "0";
            Get_French_Fry_Qty_Box.Text = "0";
            Get_Burger_Qty_Box.Text = "0";
            Get_Pizza_Qty_Box.Text = "0";
            Get_Kabab_Qty_Box.Text = "0";
            Get_Chicken_Grill_Qty_Box.Text = "0";
            Get_Fried_Rice_Qty_Box.Text = "0";
            Get_Vegetable_Curry_Qty_Box.Text = "0";
            Get_Chicken_Curry_Qty_Box.Text = "0";
            Get_Beef_Curry_Qty_Box.Text = "0"; ;
            Get_Tea_Qty_Box.Text = "0";
            Get_Coffee_Qty_Box.Text = "0";
            Get_Cold_Drinks_Qty_Box.Text = "0";
            Get_Water_Qty_Box.Text = "0";

            Get_Chicken_Fry_Unit_Box.Text = "0";
            Get_French_Fry_Unit_Box.Text = "0";
            Get_Burger_Unit_Box.Text = "0";
            Get_Pizza_Unit_Box.Text = "0";
            Get_Kabab_Unit_Box.Text = "0";
            Get_Chicken_Grill_Unit_Box.Text = "0";
            Get_Fried_Rice_Unit_Box.Text = "0";
            Get_Vegetable_Curry_Unit_Box.Text = "0";
            Get_Chicken_Curry_Unit_Box.Text = "0";
            Get_Beef_Curry_Unit_Box.Text = "0";
            Get_Tea_Unit_Box.Text = "0";
            Get_Coffee_Unit_Box.Text = "0";
            Get_Cold_Drinks_Unit_Box.Text = "0";
            Get_Water_Unit_Box.Text = "0";

/*            Get_Chicken_Fry_Subtotal_Box.Text = "0";
            Get_French_Fry_Subtotal_Box.Text = "0";
            Get_Burger_Subtotal_Box.Text = "0";
            Get_Pizza_Subtotal_Box.Text = "0";
            Get_Kabab_Subtotal_Box.Text = "0";
            Get_Chicken_Grill_Subtotal_Box.Text = "0";
            Get_Fried_Rice_Subtotal_Box.Text = "0";
            Get_Vegetable_Curry_Subtotal_Box.Text = "0";
            Get_Chicken_Curry_Subtotal_Box.Text = "0";
            Get_Beef_Curry_Subtotal_Box.Text = "0";
            Get_Tea_Subtotal_Box.Text = "0";
            Get_Coffee_Subtotal_Box.Text = "0";
            Get_Cold_Drinks_Subtotal_Box.Text = "0";
            Get_Water_Subtotal_Box.Text = "0";*/
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Get_Chicken_Fry_Qty_Box.Text = "0";
            Get_French_Fry_Qty_Box.Text = "0";
            Get_Burger_Qty_Box.Text = "0";
            Get_Pizza_Qty_Box.Text = "0";
            Get_Kabab_Qty_Box.Text = "0";
            Get_Chicken_Grill_Qty_Box.Text = "0";
            Get_Fried_Rice_Qty_Box.Text = "0";
            Get_Vegetable_Curry_Qty_Box.Text = "0";
            Get_Chicken_Curry_Qty_Box.Text = "0";
            Get_Beef_Curry_Qty_Box.Text = "0"; ;
            Get_Tea_Qty_Box.Text = "0";
            Get_Coffee_Qty_Box.Text = "0";
            Get_Cold_Drinks_Qty_Box.Text = "0";
            Get_Water_Qty_Box.Text = "0";

            Get_Chicken_Fry_Unit_Box.Text = "0";
            Get_French_Fry_Unit_Box.Text = "0";
            Get_Burger_Unit_Box.Text = "0";
            Get_Pizza_Unit_Box.Text = "0";
            Get_Kabab_Unit_Box.Text = "0";
            Get_Chicken_Grill_Unit_Box.Text = "0";
            Get_Fried_Rice_Unit_Box.Text = "0";
            Get_Vegetable_Curry_Unit_Box.Text = "0";
            Get_Chicken_Curry_Unit_Box.Text = "0";
            Get_Beef_Curry_Unit_Box.Text = "0";
            Get_Tea_Unit_Box.Text = "0";
            Get_Coffee_Unit_Box.Text = "0";
            Get_Cold_Drinks_Unit_Box.Text = "0";
            Get_Water_Unit_Box.Text = "0";

            Get_Chicken_Fry_Subtotal_Box.Text = "";
            Get_French_Fry_Subtotal_Box.Text = "";
            Get_Burger_Subtotal_Box.Text = "";
            Get_Pizza_Subtotal_Box.Text = "";
            Get_Kabab_Subtotal_Box.Text = "";
            Get_Chicken_Grill_Subtotal_Box.Text = "";
            Get_Fried_Rice_Subtotal_Box.Text = "";
            Get_Vegetable_Curry_Subtotal_Box.Text = "";
            Get_Chicken_Curry_Subtotal_Box.Text = "";
            Get_Beef_Curry_Subtotal_Box.Text = "";
            Get_Tea_Subtotal_Box.Text = "";
            Get_Coffee_Subtotal_Box.Text = "";
            Get_Cold_Drinks_Subtotal_Box.Text = "";
            Get_Water_Subtotal_Box.Text = "";
            Get_Order_Subtotal_Box.Text = "";
            Get_Tax_Box.Text = "";
            Get_Total_Box.Text = "";
            Get_Customer_Name_Box.Text = "";
            Get_Customer_Phone_Box.Text = "";
            Get_Order_Ref_Box.Text = "";
        }

        private void Add_To_Basket_Button_Click(object sender, EventArgs e)
        {
            Order_TabControl.SelectedTab = Receipt_TabPage;

            Receipt_Box.AppendText("\t\t\t" + "  Hello Kitchen Restaurant");
            Receipt_Box.AppendText("\t\t\t" + "=============================================================="+ Environment.NewLine);
            Receipt_Box.AppendText(" " + Environment.NewLine);
            Receipt_Box.AppendText("Name:" + Get_Customer_Name_Box.Text + "\t" + "Phone No:" + Get_Customer_Phone_Box.Text + "\t" + "Ref_No:" + Get_Order_Ref_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Order Date:" + "\t" + Get_Order_Date_Box.Text + "\t" + "Order Time:" + "\t" + Get_Order_Time_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Item Type" + "\t" +"\t" + "Qty" + "\t" + "Unit Price" + "\t" + "Sub Total" + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Chicken Fry" + "\t" + Get_Chicken_Fry_Qty_Box.Text + "\t" + Get_Chicken_Fry_Unit_Box.Text + "\t" + Get_Chicken_Fry_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "French Fry" + "\t" + Get_French_Fry_Qty_Box.Text + "\t" + Get_French_Fry_Unit_Box.Text + "\t" + Get_French_Fry_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Burger   " + "\t" + Get_Burger_Qty_Box.Text + "\t" + "\t" +Get_Burger_Unit_Box.Text + "\t" + Get_Burger_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Pizza    " + "\t" + Get_Pizza_Qty_Box.Text + "\t" + Get_Pizza_Unit_Box.Text + "\t" + Get_Pizza_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Kabab    " + "\t" + Get_Kabab_Qty_Box.Text + "\t" + Get_Kabab_Unit_Box.Text + "\t" + Get_Kabab_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Chicken Grill" + "\t" + Get_Chicken_Grill_Qty_Box.Text + "\t" + Get_Chicken_Grill_Unit_Box.Text + "\t" + Get_Chicken_Grill_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Fried Rice" + "\t" + Get_Fried_Rice_Qty_Box.Text + "\t" + Get_Fried_Rice_Unit_Box.Text + "\t" + Get_Fried_Rice_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Vegetable Curry" + "\t" + Get_Vegetable_Curry_Qty_Box.Text + "\t" + Get_Vegetable_Curry_Unit_Box.Text + "\t" + Get_Vegetable_Curry_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Chicken Curry" + "\t" + Get_Chicken_Curry_Qty_Box.Text + "\t" + Get_Chicken_Curry_Unit_Box.Text + "\t" + Get_Chicken_Curry_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Beef Curry" + "\t" + Get_Beef_Curry_Qty_Box.Text + "\t" + Get_Beef_Curry_Unit_Box.Text + "\t" + Get_Beef_Curry_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Tea       " + "\t" + Get_Tea_Qty_Box.Text + "\t" + Get_Tea_Unit_Box.Text + "\t" + Get_Tea_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Coffee    " + "\t" + Get_Coffee_Qty_Box.Text + "\t" + Get_Coffee_Unit_Box.Text + "\t" + Get_Coffee_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Cold Drinks" + "\t" + Get_Cold_Drinks_Qty_Box.Text + "\t" + Get_Cold_Drinks_Unit_Box.Text + "\t" + Get_Cold_Drinks_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "Mineral Water" + "\t" + Get_Water_Qty_Box.Text + "\t" + Get_Water_Unit_Box.Text + "\t" + Get_Water_Subtotal_Box.Text + Environment.NewLine);

            Receipt_Box.AppendText(Environment.NewLine + "\t\t\t" + "Order Sub Total:" + "\t" + Get_Order_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "\t\t\t" + "Tax on Order:" + "\t" + Get_Tax_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "\t\t\t" + "Net Total:" + "\t" + Get_Total_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "==============================================================" + Get_Order_Subtotal_Box.Text + Environment.NewLine);
            Receipt_Box.AppendText(Environment.NewLine + "\t\t\t" + "Online Shoping Receipt" + Environment.NewLine);
        }

        private void Calculator_Button_Click(object sender, EventArgs e)
        {
            Order_TabControl.SelectedTab = Calculator_TabPage;
        }

        private void Receipt_Button_Click(object sender, EventArgs e)
        {
            Order_TabControl.SelectedTab = Receipt_TabPage;
        }

        private void Order_Button_Click(object sender, EventArgs e)
        {
            Order_TabControl.SelectedTab = Order_TabPage;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Order_TabControl.SelectedTab = Order_TabPage;

            int quantity_of_chicken_fry = System.Convert.ToInt32(Get_Chicken_Curry_Qty_Box.Text);
            int quantity_of_french_fry = System.Convert.ToInt32(Get_French_Fry_Qty_Box.Text);
            int quantity_of_burger = System.Convert.ToInt32(Get_Burger_Qty_Box.Text);
            int quantity_of_pizza = System.Convert.ToInt32(Get_Pizza_Qty_Box.Text);
            int quantity_of_kabab = System.Convert.ToInt32(Get_Kabab_Qty_Box.Text);
            int quantity_of_chicken_grill = System.Convert.ToInt32(Get_Chicken_Grill_Qty_Box.Text);
            int quantity_of_fried_rice = System.Convert.ToInt32(Get_Fried_Rice_Qty_Box.Text);
            int quantity_of_vegetable_curry = System.Convert.ToInt32(Get_Vegetable_Curry_Qty_Box.Text);
            int quantity_of_chicken_curry = System.Convert.ToInt32(Get_Chicken_Curry_Qty_Box.Text);
            int quantity_of_beef_curry = System.Convert.ToInt32(Get_Beef_Curry_Qty_Box.Text);
            int quantity_of_tea = System.Convert.ToInt32(Get_Tea_Qty_Box.Text);
            int quantity_of_coffee = System.Convert.ToInt32(Get_Coffee_Qty_Box.Text);
            int quantity_of_cold_drinks = System.Convert.ToInt32(Get_Cold_Drinks_Qty_Box.Text);
            int quantity_of_water = System.Convert.ToInt32(Get_Water_Qty_Box.Text);

            OrderFood.conn.Open();
            OrderFood.comm.CommandText = "Insert Order_Table (Order_Ref_No,Customer_Name,Customer_Phone,Order_Date,Order_Time,Qty1,Qty2,Qty3,Qty4,Qty5,Qty6,Qty7,Qty8,Qty9,Qty10,Qty11,Qty12,Qty13,Qty14,Unit_Price1,Unit_Price2,Unit_Price3,Unit_Price4,Unit_Price5,Unit_Price6,Unit_Price7,Unit_Price8,Unit_Price9,Unit_Price10,Unit_Price11,Unit_Price12,Unit_Price13,Unit_Price14,Sub_Total1,Sub_Total2,Sub_Total3,Sub_Total4,Sub_Total5,Sub_Total6,Sub_Total7,Sub_Total8,Sub_Total9,Sub_Total10,Sub_Total11,Sub_Total12,Sub_Total13,Sub_Total14,Tax,Net_Sub_Total,Net_Total) values('" + Get_Order_Ref_Box.Text + "','" + Get_Customer_Name_Box.Text + "','" + Get_Customer_Phone_Box.Text + "','" + Get_Order_Date_Box.Text + "','" + Get_Order_Time_Box.Text + "','" + Get_Chicken_Fry_Qty_Box.Text + "','" + Get_French_Fry_Qty_Box.Text + "','" + Get_Burger_Qty_Box.Text + "','" + Get_Pizza_Qty_Box.Text + "','" + Get_Kabab_Qty_Box.Text + "','" + Get_Chicken_Grill_Qty_Box.Text + "','" + Get_Fried_Rice_Qty_Box.Text + "','" + Get_Vegetable_Curry_Qty_Box.Text + "','" + Get_Chicken_Curry_Qty_Box.Text + "','" + Get_Beef_Curry_Qty_Box.Text + "','" + Get_Tea_Qty_Box.Text + "','" + Get_Coffee_Qty_Box.Text + "','" + Get_Cold_Drinks_Qty_Box.Text + "','" + Get_Water_Qty_Box.Text + "','" + Get_Chicken_Fry_Unit_Box.Text + "','" + Get_French_Fry_Unit_Box.Text + "','" + Get_Burger_Unit_Box.Text + "','" + Get_Pizza_Unit_Box.Text + "','" + Get_Kabab_Unit_Box.Text + "','" + Get_Chicken_Grill_Unit_Box.Text + "','" + Get_Fried_Rice_Unit_Box.Text + "','" + Get_Vegetable_Curry_Unit_Box.Text + "','" + Get_Chicken_Curry_Unit_Box.Text + "','" + Get_Beef_Curry_Unit_Box.Text + "','" + Get_Tea_Unit_Box.Text + "','" + Get_Coffee_Unit_Box.Text + "','" + Get_Cold_Drinks_Unit_Box.Text + "','" + Get_Water_Unit_Box.Text + "','" + Get_Chicken_Fry_Subtotal_Box.Text + "','" + Get_French_Fry_Subtotal_Box.Text + "','" + Get_Burger_Subtotal_Box.Text + "','" + Get_Pizza_Subtotal_Box.Text + "','" + Get_Kabab_Subtotal_Box.Text + "','" + Get_Chicken_Grill_Subtotal_Box.Text + "','" + Get_Fried_Rice_Subtotal_Box.Text + "','" + Get_Vegetable_Curry_Subtotal_Box.Text + "','" + Get_Chicken_Curry_Subtotal_Box.Text + "','" + Get_Beef_Curry_Subtotal_Box.Text + "','" + Get_Tea_Subtotal_Box.Text + "','" + Get_Coffee_Subtotal_Box.Text + "','" + Get_Cold_Drinks_Subtotal_Box.Text + "','" + Get_Water_Subtotal_Box.Text + "','" + Get_Tax_Box.Text + "','" + Get_Order_Subtotal_Box.Text + "','" + Get_Total_Box.Text + "')";
            OrderFood.comm.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");
            OrderFood.conn.Close();
            /*
            OrderFood.comm.CommandText = "select AVAILABLE_QUANTITY from Food_Table ";
            SqlDataReader reader = OrderFood.comm.ExecuteReader();
            while (reader.Read())
            {
                quantity_of_chicken_fry = System.Convert.ToInt32(reader[0].ToString());
                quantity_of_french_fry = System.Convert.ToInt32(reader[1].ToString());
                quantity_of_burger = System.Convert.ToInt32(reader[2].ToString());
                quantity_of_pizza = System.Convert.ToInt32(reader[3].ToString());
                quantity_of_kabab = System.Convert.ToInt32(reader[4].ToString());
                quantity_of_chicken_grill = System.Convert.ToInt32(reader[5].ToString());
                quantity_of_fried_rice = System.Convert.ToInt32(reader[6].ToString());
                quantity_of_vegetable_curry = System.Convert.ToInt32(reader[7].ToString());
                quantity_of_chicken_curry = System.Convert.ToInt32(reader[8].ToString());
                quantity_of_beef_curry = System.Convert.ToInt32(reader[9].ToString());
                quantity_of_tea = System.Convert.ToInt32(reader[10].ToString());
                quantity_of_coffee = System.Convert.ToInt32(reader[11].ToString());
                quantity_of_cold_drinks = System.Convert.ToInt32(reader[12].ToString());
                quantity_of_water = System.Convert.ToInt32(reader[13].ToString());
            }
            OrderFood.conn.Close();

            OrderFood.conn.Open();
            OrderFood.comm.CommandText = "update Food_Table set AVAILABLE_QUANTITY = '" + name + "' where USERNAME = '" + uname + "'";
            OrderFood.comm.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");
            OrderFood.conn.Close(); */
        }

        private void Total_Button_Click(object sender, EventArgs e)
        {
            Double Cchicken_fry;
            Double Ffrench_fry;
            Double Bburger;
            Double Ppizza;
            Double Kkabab;
            Double Cchicken_grill;
            Double Ffried_rice;
            Double Vvegetable_curry;
            Double Cchicken_curry;
            Double Bbeef_curry;
            Double Ttea;
            Double Ccoffee;
            Double Ccold_drinks;
            Double Wwater;
            Double Net_Tax;

            Cchicken_fry = Double.Parse(Get_Chicken_Fry_Qty_Box.Text);
            Ffrench_fry = Double.Parse(Get_French_Fry_Qty_Box.Text);
            Bburger = Double.Parse(Get_Burger_Qty_Box.Text);
            Ppizza = Double.Parse(Get_Pizza_Qty_Box.Text);
            Kkabab = Double.Parse(Get_Kabab_Qty_Box.Text);
            Cchicken_grill = Double.Parse(Get_Chicken_Grill_Qty_Box.Text);
            Ffried_rice = Double.Parse(Get_Fried_Rice_Qty_Box.Text);
            Vvegetable_curry = Double.Parse(Get_Vegetable_Curry_Qty_Box.Text);
            Cchicken_curry = Double.Parse(Get_Chicken_Curry_Qty_Box.Text);
            Bbeef_curry = Double.Parse(Get_Beef_Curry_Qty_Box.Text);
            Ttea = Double.Parse(Get_Tea_Qty_Box.Text);
            Ccoffee = Double.Parse(Get_Coffee_Qty_Box.Text);
            Ccold_drinks = Double.Parse(Get_Cold_Drinks_Qty_Box.Text);
            Wwater = Double.Parse(Get_Water_Qty_Box.Text);

            unitprice1 = Double.Parse(Get_Chicken_Fry_Unit_Box.Text);
            unitprice2 = Double.Parse(Get_French_Fry_Unit_Box.Text);
            unitprice3 = Double.Parse(Get_Burger_Unit_Box.Text);
            unitprice4 = Double.Parse(Get_Pizza_Unit_Box.Text);
            unitprice5 = Double.Parse(Get_Kabab_Unit_Box.Text);
            unitprice6 = Double.Parse(Get_Chicken_Grill_Unit_Box.Text);
            unitprice7 = Double.Parse(Get_Fried_Rice_Unit_Box.Text);
            unitprice8 = Double.Parse(Get_Vegetable_Curry_Unit_Box.Text);
            unitprice9 = Double.Parse(Get_Chicken_Curry_Unit_Box.Text);
            unitprice10 = Double.Parse(Get_Beef_Curry_Unit_Box.Text);
            unitprice11 = Double.Parse(Get_Tea_Unit_Box.Text);
            unitprice12 = Double.Parse(Get_Coffee_Unit_Box.Text);
            unitprice13 = Double.Parse(Get_Cold_Drinks_Unit_Box.Text);
            unitprice14 = Double.Parse(Get_Water_Unit_Box.Text);

            chicken_fry = Cchicken_fry * unitprice1;
            french_fry = Ffrench_fry * unitprice2;
            burger = Bburger * unitprice3;
            pizza = Ppizza * unitprice4;
            kabab = Kkabab * unitprice5;
            chicken_grill = Cchicken_grill * unitprice6;
            fried_rice = Ffried_rice * unitprice7;
            vegetable_curry = Vvegetable_curry * unitprice8;
            chicken_curry = Cchicken_curry * unitprice9;
            beef_curry = Bbeef_curry * unitprice10;
            tea = Ttea * unitprice11;
            coffee = Ccoffee * unitprice12;
            cold_drinks = Ccold_drinks * unitprice13;
            water = Wwater * unitprice14;

            Get_Chicken_Fry_Subtotal_Box.Text = System.Convert.ToString(chicken_fry);
            Get_French_Fry_Subtotal_Box.Text = System.Convert.ToString(french_fry);
            Get_Burger_Subtotal_Box.Text = System.Convert.ToString(burger);
            Get_Pizza_Subtotal_Box.Text = System.Convert.ToString(pizza);
            Get_Kabab_Subtotal_Box.Text = System.Convert.ToString(kabab);
            Get_Chicken_Grill_Subtotal_Box.Text = System.Convert.ToString(chicken_grill);
            Get_Fried_Rice_Subtotal_Box.Text = System.Convert.ToString(fried_rice);
            Get_Vegetable_Curry_Subtotal_Box.Text = System.Convert.ToString(vegetable_curry);
            Get_Chicken_Curry_Subtotal_Box.Text = System.Convert.ToString(chicken_curry);
            Get_Beef_Curry_Subtotal_Box.Text = System.Convert.ToString(beef_curry);
            Get_Tea_Subtotal_Box.Text = System.Convert.ToString(tea);
            Get_Coffee_Subtotal_Box.Text = System.Convert.ToString(coffee);
            Get_Cold_Drinks_Subtotal_Box.Text = System.Convert.ToString(cold_drinks);
            Get_Water_Subtotal_Box.Text = System.Convert.ToString(water);
            Get_Chicken_Fry_Subtotal_Box.Text = System.Convert.ToString(chicken_fry);

            Get_Order_Subtotal_Box.Text = System.Convert.ToString(chicken_fry+french_fry+burger+pizza+kabab+chicken_grill+fried_rice+vegetable_curry+chicken_curry+beef_curry+tea+coffee+cold_drinks+water);
            Net_Tax = (chicken_fry + french_fry + burger + pizza + kabab + chicken_grill + fried_rice + vegetable_curry + chicken_curry + beef_curry + tea + coffee + cold_drinks + water) * interest_tax / 100;
            Get_Tax_Box.Text = System.Convert.ToString(Net_Tax);
            Get_Total_Box.Text = System.Convert.ToString(Net_Tax + (chicken_fry + french_fry + burger + pizza + kabab + chicken_grill + fried_rice + vegetable_curry + chicken_curry + beef_curry + tea + coffee + cold_drinks + water));

            Get_Chicken_Fry_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Chicken_Fry_Unit_Box.Text));
            Get_French_Fry_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_French_Fry_Unit_Box.Text));
            Get_Burger_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Burger_Unit_Box.Text));
            Get_Pizza_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Pizza_Unit_Box.Text));
            Get_Kabab_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Kabab_Unit_Box.Text));
            Get_Chicken_Grill_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Chicken_Grill_Unit_Box.Text));
            Get_Fried_Rice_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Fried_Rice_Unit_Box.Text));
            Get_Vegetable_Curry_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Vegetable_Curry_Unit_Box.Text));
            Get_Chicken_Curry_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Chicken_Curry_Unit_Box.Text));
            Get_Beef_Curry_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Beef_Curry_Unit_Box.Text));
            Get_Tea_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Tea_Unit_Box.Text));
            Get_Coffee_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Coffee_Unit_Box.Text));
            Get_Cold_Drinks_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Cold_Drinks_Unit_Box.Text));
            Get_Water_Unit_Box.Text = String.Format("{0:C}", Double.Parse(Get_Water_Unit_Box.Text));

            Get_Chicken_Fry_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Chicken_Fry_Subtotal_Box.Text));
            Get_French_Fry_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_French_Fry_Subtotal_Box.Text));
            Get_Burger_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Burger_Subtotal_Box.Text));
            Get_Pizza_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Pizza_Subtotal_Box.Text));
            Get_Kabab_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Kabab_Subtotal_Box.Text));
            Get_Chicken_Grill_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Chicken_Grill_Subtotal_Box.Text));
            Get_Fried_Rice_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Fried_Rice_Subtotal_Box.Text));
            Get_Vegetable_Curry_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Vegetable_Curry_Subtotal_Box.Text));
            Get_Chicken_Curry_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Chicken_Curry_Subtotal_Box.Text));
            Get_Beef_Curry_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Beef_Curry_Subtotal_Box.Text));
            Get_Tea_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Tea_Subtotal_Box.Text));
            Get_Coffee_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Coffee_Subtotal_Box.Text));
            Get_Cold_Drinks_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Cold_Drinks_Subtotal_Box.Text));
            Get_Water_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Water_Subtotal_Box.Text));

            Get_Tax_Box.Text = String.Format("{0:C}", Double.Parse(Get_Tax_Box.Text));
            Get_Order_Subtotal_Box.Text = String.Format("{0:C}", Double.Parse(Get_Order_Subtotal_Box.Text));
            Get_Total_Box.Text = String.Format("{0:C}", Double.Parse(Get_Total_Box.Text));


        }

        private void Covert_Button_Click(object sender, EventArgs e)
        {
            Get_Conversion_Country_ComboBox.Items.Add("USA");
            Get_Conversion_Country_ComboBox.Items.Add("Canada");
            Get_Conversion_Country_ComboBox.Items.Add("India");
            Get_Conversion_Country_ComboBox.Items.Add("Bangladesh");

            Double bangladesh_taka = Double.Parse(Get_Convert_Box.Text);

            if(Get_Conversion_Country_ComboBox.Text=="USA")
            {
                TextConvert_Label.Text = System.Convert.ToString(bangladesh_taka * us_dollar);
            }
            else if (Get_Conversion_Country_ComboBox.Text == "Canada")
            {
                TextConvert_Label.Text = System.Convert.ToString(bangladesh_taka * canadian_dollar);
            }
            else if (Get_Conversion_Country_ComboBox.Text == "India")
            {
                TextConvert_Label.Text = System.Convert.ToString(bangladesh_taka * indian_rupee);
            }
            else if (Get_Conversion_Country_ComboBox.Text == "Bangladesh")
            {
                TextConvert_Label.Text = System.Convert.ToString(bangladesh_taka * bangladesh_taka);
            }
        }

        private void viewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_TabControl.SelectedTab = Order_TabPage;
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_TabControl.SelectedTab = Receipt_TabPage;
        }
    }
    public class DataAccessOrderFoodnew
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessOrderFoodnew()
        {
            conn = new SqlConnection();
            comm = new SqlCommand();
            //conn.ConnectionString = "Server=MARUF-LAPTOP\SQLEXPRESS;Database=StudentDataBase;Trusted_Connection=True;" name="StudentString";
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
