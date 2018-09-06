using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectXtestpilot
{
    public partial class Main : Form
    {
        string str_usertype;
        string str_username;
        public Main(string str_username,string str_usertype)
        {
            this.str_username = str_username;
            this.str_usertype = str_usertype;
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showprofileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProfile mp = new MyProfile(str_username, str_usertype);
            mp.Show();
        }

        private void addnewprofileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.str_usertype != "Admin")
            {
                MessageBox.Show("Only Admin User Can Access This Feature");
            }
            else
            {
                Signup addnewprofile = new Signup();
                addnewprofile.Show();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.str_usertype!="Admin")
            {
                MessageBox.Show("Only Admin User Can Access This Feature");
            } else
            {
                DeleteProfile delp = new DeleteProfile(this.str_username, this.str_usertype);
                delp.Show();
            }
            
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Admin" || this.str_usertype == "Owner")
            {
                UpdateProfile uprofile = new UpdateProfile(this.str_username,this.str_usertype);
                uprofile.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you are not authorized to access this feature.\n **Only Admin/Owner User Can Access This Feature.**");
            }
        }

        private void updateFoodMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Admin" || this.str_usertype == "Manager")
            {
                Food_Menu foodm = new Food_Menu(this.str_username, this.str_usertype);
                foodm.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you are not authorized to access!!!");
            }
        }

        private void orderFoodMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Cashier" || this.str_usertype == "Admin" || this.str_usertype == "Manager")
            {
                Order_Foodnew orderfood = new Order_Foodnew(this.str_username, this.str_usertype);
                orderfood.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you are not authorized to access!!!");
            }
        }
        /*
        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Admin" || this.str_usertype == "Manager")
            {
                Stock_Record Stock = new Stock_Record();
                Stock.Show();
            }
            else
            {
                MessageBox.Show("Only Admin/Manager User Can Access This Feature");
            }
        }*/

        private void tableReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Admin" || this.str_usertype == "Manager")
            {
                Table_Reservation Table_Reservation = new Table_Reservation();
                Table_Reservation.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you are not authorized to access this feature.\n **Only Admin/Manager User Can Access This Feature.**");
            }
        }

        private void tableReservationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Table_Reservation Table_Reservation = new Table_Reservation();
            Table_Reservation.Show();
        }

        private void stockRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.str_usertype == "Admin" || this.str_usertype == "Manager")
            {
                Stock_Record Stock = new Stock_Record();
                Stock.Show();
            }
            else
            {
                MessageBox.Show("Sorry, you are not authorized to access this feature.\n **Only Admin/Owner User Can Access This Feature.**");
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn form = new SignIn();
            form.Show();
        }
        /*
        private void Main_Load(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = "F:/Study/CSE 411(Software Engineering & Information System Design)/Project X/x.jpg"; //path to image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }*/

        private void Main_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void signOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            SignIn form = new SignIn();
            form.Show();
            this.Hide();

        }
    }
}
