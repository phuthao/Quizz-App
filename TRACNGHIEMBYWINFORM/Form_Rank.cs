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
    public partial class Form_Rank : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

       
        public Form_Rank()
        {
            InitializeComponent();
        }

        private void Form_Rank_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            panel_chart.Visible = true;


            if (!panel_chart.Controls.Contains(UC_Rank._Instance))
            {
                panel_chart.Controls.Add(UC_Rank._Instance);
                UC_Rank._Instance.Dock = DockStyle.Fill;
                UC_Rank._Instance.BringToFront();
            }
            else
                UC_Rank._Instance.BringToFront();


            string query = "   SELECT distinct MSV , MAX(socaudung) FROM PHIEUKETQUA WHERE MonTHI='"+UC_Rank._MONTHI+"'AND MaDT='"+UC_Rank._MADT+"'GROUP BY MSV ";
          

          

            connection.Open();
            SqlCommand cmd2 = new SqlCommand(query, connection);
            SqlDataReader Reader = cmd2.ExecuteReader();

            listview_RANK.Items.Clear();

            while (Reader.Read())
            {

                ListViewItem lv = new ListViewItem(Reader.GetString(0));
             //   lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetInt32(1).ToString());
                listview_RANK.Items.Add(lv);


            }

            Reader.Close();
            connection.Close();




        }
      
        private void btn_load_Click(object sender, EventArgs e)
        {
            string query = " SELECT distinct MSV,  MAX(socaudung) ,MIN(timetocomplete) , MAX(Solanthi) FROM PHIEUKETQUA WHERE MonTHI ='" + UC_Rank._MONTHI + "'AND MaDT='" + UC_Rank._MADT + "'GROUP BY MSV  ORDER BY MAX(socaudung) DESC";




            connection.Open();
            SqlCommand cmd2 = new SqlCommand(query, connection);
            SqlDataReader Reader = cmd2.ExecuteReader();

            listview_RANK.Items.Clear();

            int counter = 1;
            while (Reader.Read())
            {
             


                ListViewItem lv = new ListViewItem(Reader.GetString(0));
               
                lv.SubItems.Add(Reader.GetInt32(1).ToString());
                lv.SubItems.Add(Reader.GetTimeSpan(2).ToString());
              lv.SubItems.Add(Reader.GetInt32(3).ToString());
                
                lv.SubItems.Add((counter++).ToString());

               
                listview_RANK.Items.Add(lv);

                  
               



            }

            Reader.Close();
            connection.Close();

           
        }

        private void listview_RANK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Rank_FormClosing(object sender, FormClosingEventArgs e)
        {
        

            UC_Rank n = new UC_Rank();
            n._reset();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MainMenu n = new MainMenu();
            n.Show();
        }
    }
}
