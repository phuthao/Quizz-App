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

namespace TRACNGHIEMBYWINFORM
{
    public partial class UC_delete_Profile : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");

        private static UC_delete_Profile _instance;
        public static UC_delete_Profile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_delete_Profile();
                }
                return _instance;
            }

        }

        public void reset()
        {
           
                _instance = null;
           
        }
        public UC_delete_Profile()
        {
            InitializeComponent();

        }

        private void cbox_monHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Binddata_MaDT();
        }

        internal void ResetControl()
        {
            throw new NotImplementedException();
        }

        private void delete_Profile_Load(object sender, EventArgs e)
        {
            
         
          //  Binddata_MaDT();
            
            if (Form_Begin.usernamestatic == "admin")
            {
                tbox_user.Text = "admin";
                tbox_user.Enabled = true;
            }
            else
            {
                tbox_user.Text = Form_Begin.usernamestatic;
                tbox_user.Enabled = false;
              
            }
            Binddata_monHoc();
        }

       public void clean_user()
        {
            tbox_user.Text = "";
        }
    
        void Binddata_MaDT()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select distinct MaDT FROM PHIEUKETQUA where MSV='" + tbox_user.Text + "'and MonTHI=N'"+cbox_monHoc.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbox_maDe.DisplayMember = "MaDT";
            cbox_maDe.DataSource = dt;

            //  connection.Close();

           
        }
       
        void Binddata_monHoc()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select distinct MonTHI FROM PHIEUKETQUA  where MSV = '" + tbox_user.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbox_monHoc.DisplayMember = "MonTHI";
            cbox_monHoc.DataSource = dt;

          
            //  connection.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from PHIEUKETQUA where MSV = '" + tbox_user.Text + "'and MonTHI=N'" + cbox_monHoc.Text + "'and MaDT='" + cbox_maDe.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted !");
                Binddata_MaDT();
                Binddata_monHoc();
                cbox_monHoc.Text="";
                cbox_maDe.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbox_monHoc_TextUpdate(object sender, EventArgs e)
        {

        }

        private void btn_xoaall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from PHIEUKETQUA where MSV = '" + tbox_user.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted !");
                Binddata_MaDT();
                Binddata_monHoc();
                cbox_monHoc.Text = "";
                cbox_maDe.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_hover_user_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_hover_user);
        }

        private void lbl_hovoer_subject_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_hovoer_subject);
        }

        private void lbl_codex_hover_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_codex_hover);
        }

/*
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();*/

     
        private void UC_delete_Profile_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void UC_delete_Profile_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void UC_delete_Profile_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void UC_delete_Profile_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }*/
        }

        /*  private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
          {
              SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT madt , chude , cau , noidung , dapanA , dapanB , dapanC , dapanD , DapAn , STT FROM new where chude=N'" + txt_timkiem.Text + "'and madt='" + comboBox1.Text + "' Order by cau ASC ", con);
              //   SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * INTO TEMP FROM new where chude=N'" + txt_timkiem.Text + "' and  madt='" + comboBox1.Text + "'  Order by cau ASC  ALTER TABLE TEMP DROP  COLUMN DapAN SELECT * FROM  TEMP DROP TABLE TEMP  ", con);
              DataTable dtbl = new DataTable();

              sqlDa.Fill(dtbl);

              dataGridView1.DataSource = dtbl;
              GETDAPAN.Dgv_GETDAPAN.DataSource = dtbl;

          }
  */




    }
}
