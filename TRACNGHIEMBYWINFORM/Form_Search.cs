using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_Search :  MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");

        public static string MSVSTATIC_THONGKE;

        public static string MADETHISTATIC_THONGKE;

   


       
        public Form_Search()
        {

            InitializeComponent();
        }
        public int count_click;
        // get_MSV = txt_msv.Text;
        private void Form_TraCuu_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            // load color 
            panel2.BackColor =   Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            /// delete button 
            panel_blank.Visible = false;

            foreach (Control ctrl in panel_blank.Controls)
            {
                if (ctrl.GetType().Name == "delete_Profile")
                {
                    UC_delete_Profile obj = ctrl as UC_delete_Profile;

                    obj.ResetControl();
                }
            }

            ///

            lbl_MSVstatic.Text = Form_Begin.usernamestatic;

            dataGridView1.Columns["STT"].Visible = false;
            


            //  readdatagridview();



            if (lbl_MSVstatic.Text == "admin")
            {
                txt_msv.Enabled = true;
            }
            else
            {
                txt_msv.Text = lbl_MSVstatic.Text;
                txt_msv.Enabled = false;
            }
            /*   Binddata();*/
        }
        /*   void Binddata()
           {

               SqlDataAdapter da = new SqlDataAdapter("Select distinct MaDT FROM PHIEUKETQUA", con);
               DataTable dt = new DataTable();
               da.Fill(dt);
               comboBox1.DisplayMember = "MaDT";
               comboBox1.DataSource = dt;
               //  connection.Close();
           }*/
        private void btn_tim_Click(object sender, EventArgs e)
        {

            MSVSTATIC_THONGKE = txt_msv.Text;


            // con.Open();
            string query = "SELECT *  FROM PHIEUKETQUA where MSV=@MSV ";
            SqlDataAdapter sqlDa = new SqlDataAdapter(query,con);
            sqlDa.SelectCommand.Parameters.AddWithValue("@MSV", txt_msv.Text);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;




            //   txt_msv.Text = "";

        }
        private void bnt_thongke_DoubleClick(Object sender, EventArgs e)
        {
          
            count_click++;
            if (count_click % 2 == 0)
            {
                UC_Rank n = new UC_Rank();

                //  n.clean_user();
                panel_blank.Controls.Remove(UC_Rank._Instance);
                panel_blank.Visible = false;

            }
         



        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel_blank.Visible = false;
            UC_delete_Profile df = new UC_delete_Profile();
            UC_Rank bxh = new UC_Rank();
            UC_Profile detail = new UC_Profile();
            detail.reset();
            df.reset();
            bxh.reset();
            MainMenu n = new MainMenu();
            if (lbl_MSVstatic.Text == "admin")
            {

                //openCauHoi();
                this.Close();
                n.Show();
               

            }
            else
            {

                //Login.normal();

                //      n.hideonbush();
                this.Close();
                n.Show();
              
            }
            this.Close();
        }

        private void bnt_thongke_Click(object sender, EventArgs e)
        {
         

        }

        private void btn_xoalichsu_Click(object sender, EventArgs e)
        {
            panel_blank.Visible = true;


            if (!panel_blank.Controls.Contains(UC_delete_Profile.Instance))
            {
                panel_blank.Controls.Add(UC_delete_Profile.Instance);
                UC_delete_Profile.Instance.Dock = DockStyle.Fill;
                UC_delete_Profile.Instance.BringToFront();
            }
            else
                UC_checkDapan.Instance.BringToFront();

          
        }
        private void btn_xoalichsu_DoubleClick(Object sender, EventArgs e)
        {
            //    MessageBox.Show("You are in the Button.DoubleClick event.");
          
            count_click++;
            if(count_click%2==0)
            {
                UC_delete_Profile n = new UC_delete_Profile();

                n.clean_user();

                panel_blank.Controls.Remove(UC_delete_Profile.Instance);
                panel_blank.Visible = false;
            }

          
            //  panel_blank.Visible = false;
            /*  count_click = 1;
              count_click++;
              //  Form_xoalichsu n = new Form_xoalichsu();
              if (count_click % 2 == 0)
                  panel_blank.Visible = true;
              else*/



        }

        Point pt;
        private void panel_blank_MouseDown(object sender, MouseEventArgs e)
        {
            pt = Cursor.Position;
        }
        private void panel_blank_MouseUp(object sender, MouseEventArgs e)
        {
            pt = Cursor.Position;
        }
      
       
        private void panel_blank_MouseHover(object sender, MouseEventArgs e)
        {

            pt = Cursor.Position;
        }
        private void panel_blank_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int px = Cursor.Position.X - pt.X;
                int py = Cursor.Position.Y - pt.Y;
                panel_blank.Location = new Point(panel_blank.Location.X + px, panel_blank.Location.Y + py);
                pt = Cursor.Position;
            }
        }

        private void lbl_MSVstatic_Click(object sender, EventArgs e)
        {

        }

        private void panel_blank_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_blank_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel_blank_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
