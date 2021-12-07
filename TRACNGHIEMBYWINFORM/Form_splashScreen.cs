using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_splashScreen : Form
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
        public Form_splashScreen()
        {        
            InitializeComponent();
        }

        private void Form_Splash_Screen_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            //  metroProgressBar1.MarqueeAnimationSpeed = 150;
            //    MainMenu.count_Splash = 0;
            connection.Open();
            string query_color1 = "SELECT R from login where MSV='" + Form_Begin.usernamestatic + "'";
            SqlCommand query_color_R = new SqlCommand(query_color1, connection);
            string R = query_color_R.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            string query_color2 = "SELECT G from login where MSV='" + Form_Begin.usernamestatic + "'";
            SqlCommand query_color_G = new SqlCommand(query_color2, connection);
            string G = query_color_G.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            string query_color3 = "SELECT B from login where MSV='" + Form_Begin.usernamestatic + "'";
            SqlCommand query_color_B = new SqlCommand(query_color3, connection);
            string B = query_color_B.ExecuteScalar().ToString();
            connection.Close();


            if (R == "" || G == "" || B == "")
            {

                R = "41";
                G = "128";
                B = "185";
            }
            panel_form.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
            metroPanel1.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
            metroProgressBar1.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
            label1.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B)); ;
        }
    }
}
