using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TRACNGHIEMBYWINFORM
{
    public partial class UC_Rank : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

        public static string _MONTHI;
        public static string _MADT;

        private static UC_Rank _instance;
     

        public static UC_Rank _Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Rank();
                }
                return _instance;
            }
         
        }

        public void _reset()
        {
            _instance = null;
        }
        public UC_Rank()
        {
            InitializeComponent();

          
        }

        private void UC_History_Load(object sender, EventArgs e)
        {
            chart1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
           
            btn_close.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B)); 
            
            Binddata_monHoc();
            try
            {
                // fetchdata();


                //Fetch the Statistical data from database.
                string query = "SELECT distinct MSV , Max(socaudung) as Total ";
                query += " FROM PHIEUKETQUA GROUP BY MSV ";
                //  query += " GROUP BY Solanthi";
                DataTable dt = GetData(query);

                //Get the names of Cities.
                string[] x = (from p in dt.AsEnumerable()
                              orderby p.Field<string>("MSV") ascending
                              select p.Field<string>("MSV")).ToArray();

                //Get the Total of Orders for each City.
                int[] y = (from p in dt.AsEnumerable()
                           orderby p.Field<int>("Total") ascending
                           select p.Field<int>("Total")).ToArray();

                chart1.Series[0].LegendText = "Correct";

                chart1.Series[0].ChartType = SeriesChartType.Column;
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].Points.DataBindXY(x, y);

            }
            catch
            {
                MessageBox.Show("WRONG CODE");

            }
        }
        public void DrawChart_Rank()
        {
           
            try
            {
                // fetchdata();


                //Fetch the Statistical data from database.
                string query = "SELECT distinct MSV, Max(socaudung) [Total]";
                query += " FROM PHIEUKETQUA WHERE MonTHI ='" + cbox_monthi.Text + "'and MaDT='" + cbox_made.Text + "' GROUP BY MSV ";
                //  query += " GROUP BY Solanthi";
                DataTable dt = GetData(query);

                //Get the names of Cities.
                string[] x = (from p in dt.AsEnumerable()
                              orderby p.Field<string>("MSV") ascending
                              select p.Field<string>("MSV")).ToArray();

                //Get the Total of Orders for each City.
                int[] y = (from p in dt.AsEnumerable()
                           orderby p.Field<int>("Total") ascending
                           select p.Field<int>("Total")).ToArray();

                chart1.Series[0].LegendText = "Correct";

                chart1.Series[0].ChartType = SeriesChartType.Column;
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].Points.DataBindXY(x, y);

            }
            catch
            {
                MessageBox.Show("WRONG CODE");

            }
        }
        private static DataTable GetData(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
        void Binddata_MaDT()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select distinct MaDT FROM PHIEUKETQUA where MSV='" + Form_Begin.usernamestatic + "'and MonTHI=N'" + cbox_monthi.Text + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbox_made.DisplayMember = "MaDT";
            cbox_made.DataSource = dt;
            
            
            //  connection.Close();


        }

        void Binddata_monHoc()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select distinct MonTHI FROM PHIEUKETQUA  where MSV = '" + Form_Begin.usernamestatic + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

           
            cbox_monthi.DisplayMember = "MonTHI";
          
            cbox_monthi.DataSource = dt;
           


            cbox_made.Enabled = false;

            //  connection.Close();
        }

        private void cbox_monthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Binddata_MaDT();
            cbox_made.Enabled = true;

            ////

            _MONTHI = cbox_monthi.Text;
               
        }

        private void cbox_made_SelectedIndexChanged(object sender, EventArgs e)
        {
            _MADT = cbox_made.Text;
            DrawChart_Rank();

            Form_Rank master = (Form_Rank)Application.OpenForms["Form_Rank"];
            master.btn_load.PerformClick();

        }

        public void reset()
        {

            _instance = null;

        }

        private void cbox_monthi_TextChanged(object sender, EventArgs e)
        {
            if (cbox_monthi.Items.Count >0)
                cbox_monthi.Text = "--Choose--";
        }

        private void cbox_made_MouseHover(object sender, EventArgs e)
        {
            Form_Rank master = (Form_Rank)Application.OpenForms["Form_Rank"];
            master.btn_load.PerformClick();
        }

    /*    public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();*/
        private void UC_Rank_MouseDown(object sender, MouseEventArgs e)
        {
           /* if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            MainMenu n = new MainMenu();
            n.Show();
            _instance = new UC_Rank();
        }
    }
}
