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
    public partial class Table_Reservation : Form
    {
        DataAccessReservation dt_reservation;
        public Table_Reservation()
        {
            dt_reservation = new DataAccessReservation();
            InitializeComponent();
        }
        private DataTable Get_Reservation()
        {
            DataTable get_reservation = new DataTable();
            dt_reservation.comm.CommandText = "Select * from Reservation_Table";
            dt_reservation.conn.Open();
            SqlDataReader reader = dt_reservation.comm.ExecuteReader();
            get_reservation.Load(reader);
            dt_reservation.conn.Close();
            return get_reservation;
        }

        private void Show_Reservation_Button_Click(object sender, EventArgs e)
        {
            Table_Reservation_DataGridView.DataSource = Get_Reservation();
            this.Table_Reservation_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Table_Reservation_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        private void Confirm_Reservation_Button_Click(object sender, EventArgs e)
        {
            String name = Get_Name_Box.Text;
            String phone = Get_Phone_Box.Text;
            String reservation_date = DateTimePicker.Text;
            String reservation_time = Get_Reservation_Time_ComboBox.Text;
            String reservation_type = Get_Reservation_Type_ComboBox.Text;
            int number_of_guests = System.Convert.ToInt32(Get_Number_Of_Guests_Box.Text);
            
            int sum_of_guest = 0;
            
            dt_reservation.conn.Open();

            //dt_reservation.comm.CommandText = "select sum(NUMBER_OF_GUEST) from Reservation_Table where DATE_OF_RESERVATION='" + reservation_date + "' select NUMBER_OF_GUEST from Rerservation_Table where RESERVATION_TIME ='" + reservation_time + "'";
            //dt_reservation.comm.CommandText = "select sum(NUMBER_OF_GUEST) from Reservation_Table where DATE_OF_RESERVATION ='" + reservation_date + "' and RESERVATION_TIME ='" + reservation_time + "'";
            //dt_reservation.comm.CommandText = "select sum(NUMBER_OF_GUEST) from Reservation_Table where (DATE_OF_RESERVATION ='" + reservation_date + "' or DATE_OF_RESERVATION ='') and (RESERVATION_TIME ='" + reservation_time + "' or RESERVATION_TIME ='')";
            //dt_reservation.comm.CommandText = "insert into Reservation_Table values ('" + reservation_date + "','" + reservation_time + "', '" + sum_of_guest + "') where DATE_OF_RESERVATION is not '" + reservation_date + "' and RESERVATION_TIME is not '" + reservation_time + "'";

            dt_reservation.comm.CommandText = "insert into Reservation_Table(DATE_OF_RESERVATION,RESERVATION_TIME,NUMBER_OF_GUEST) values ('" + reservation_date + "','" + reservation_time + "', '" + sum_of_guest + "')";
            dt_reservation.comm.ExecuteNonQuery();
            dt_reservation.conn.Close();

            dt_reservation.conn.Open();
            dt_reservation.comm.CommandText = "select sum(NUMBER_OF_GUEST) from Reservation_Table where DATE_OF_RESERVATION ='" + reservation_date + "' and RESERVATION_TIME ='" + reservation_time + "'";
            SqlDataReader reader = dt_reservation.comm.ExecuteReader();
            while (reader.Read())
            {
                sum_of_guest = System.Convert.ToInt32(reader[0].ToString());
            }
            dt_reservation.conn.Close();
      
            int final_sum_of_guest = number_of_guests + sum_of_guest;

            if (final_sum_of_guest <= 200)
            {
                dt_reservation.conn.Open();
                dt_reservation.comm.CommandText = "insert into Reservation_Table values ('" + name + "','" + phone + "','" + reservation_date + "','" + reservation_time + "','" + reservation_type + "', '" + number_of_guests + "')";
                dt_reservation.comm.ExecuteNonQuery();
                MessageBox.Show("Reserved Successfully");
                dt_reservation.conn.Close();

                dt_reservation.conn.Open();
                dt_reservation.comm.CommandText = "delete from Reservation_Table WHERE ISNULL(NAME,'')= ''";
                dt_reservation.comm.ExecuteNonQuery();
                dt_reservation.conn.Close();

            }
            else
            {
                dt_reservation.conn.Open();
                dt_reservation.comm.CommandText = "delete from Reservation_Table WHERE ISNULL(NAME,'')= ''";
                dt_reservation.comm.ExecuteNonQuery();
                dt_reservation.conn.Close();
                MessageBox.Show("Full Reserved !!!");
            }          
        }

        private void Cancel_Reservation_Button_Click(object sender, EventArgs e)
        {
            String name = Get_Name_Box.Text;
            String phone = Get_Phone_Box.Text;
            String reservation_date = DateTimePicker.Text;
            String reservation_time = Get_Reservation_Time_ComboBox.Text;
            String reservation_type = Get_Reservation_Type_ComboBox.Text;
            //int number_of_guests = System.Convert.ToInt32(Get_Number_Of_Guests_Box.Text);

            dt_reservation.conn.Open();
            dt_reservation.comm.CommandText = "delete from Reservation_Table where NAME = '"+ name +"' and PHONE = '"+ phone +"' and DATE_OF_RESERVATION ='" + reservation_date + "' and RESERVATION_TIME ='" + reservation_time + "'";
            dt_reservation.comm.ExecuteNonQuery();
            MessageBox.Show("Reservation Cancelled !!!");
            dt_reservation.conn.Close();
        }

        private void Table_Reservation_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }

    public class DataAccessReservation
    {
        public SqlConnection conn;
        public SqlCommand comm;
        public DataAccessReservation()
        {
            comm = new SqlCommand();
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ProjectXtestpilotString"].ConnectionString;
            comm.Connection = conn;
        }
    }
}
