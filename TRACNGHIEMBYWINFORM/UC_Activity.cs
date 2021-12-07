using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class UC_Activity : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

        private static UC_Activity _instance;
        public static UC_Activity _Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new UC_Activity();

                return _instance;
            }
          
        }

        public UC_Activity()
        {
            InitializeComponent();
        }

        public void reset()
        {
            _instance = null;
        }

        public void _Refresh()
        {
            connection.Open();
            string query2 = "SELECT MSV , Convert(varchar,Date,103) as Date , Time , Activity  FROM History where MSV not Like 'admin' order by Date DESC ";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, connection);

            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView1.DataSource = dt2;
     

            connection.Close();
        }
     

        private void UC_Activity_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_calendar.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_tim.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_close.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            _Refresh();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            MainMenu n = new MainMenu();
            n.Show();
            _instance = new UC_Activity();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          string activity = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string user = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(activity,"Activity Log Of "+user, MessageBoxButtons.OK);
            //  MessageBox.Show(activity);
        }

        int count_click = 0;
     

        private void btn_calendar_Click(object sender, EventArgs e)
        {
            count_click++;
            if (count_click % 2 != 0)
            {
                dateTimePicker1.Visible = true;
            }
            if(count_click%2==0)
            {
                dateTimePicker1.Visible = false;
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query2 = "SELECT MSV , Convert(varchar,Date,103) as Date , Time , Activity FROM History where  MSV='" + tbox_MSV.Text+ "' and  MSV not Like 'admin' order by Date DESC ";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, connection);

            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView1.DataSource = dt2;
         

            connection.Close();
        }

        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           string _date = dateTimePicker1.Value.ToString("yyyy/MM/dd");

            if (_date != null)
            {
                connection.Open();
                string query2 = "SELECT MSV , Convert(varchar,Date,103) as Date , Time , Activity FROM History where MSV='" + tbox_MSV.Text + "' and Date ='" + _date + "'and  MSV not Like 'admin' order by Date DESC ";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, connection);

                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                dataGridView1.DataSource = dt2;

                connection.Close();
            }
            else
            {
                connection.Open();
                string query2 = "SELECT MSV, Convert(varchar, Date, 103) as Date , Time , Activity FROM History where MSV='" + tbox_MSV.Text + "'and  MSV not Like 'admin' order by Date DESC ";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, connection);

                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                dataGridView1.DataSource = dt2;

                connection.Close();
            }
        }
    }
}
