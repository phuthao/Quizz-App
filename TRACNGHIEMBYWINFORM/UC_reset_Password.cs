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

    public partial class UC_reset_Password : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

        private static UC_reset_Password _instance;
        public static UC_reset_Password Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_reset_Password();
                }                
                    return _instance;
            }
            

          

        }
        public UC_reset_Password()
        {
            InitializeComponent();
        }
        public void reset()
        {
            _instance = null;
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select password from login where MSV='" + Form_Begin.usernamestatic + "'and password='"+tbox_currentpassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    if (tbox_newpass.Text == tbox_confirm.Text)
                    {
                        SqlDataAdapter sda2 = new SqlDataAdapter(" UPDATE  login SET password='"+ tbox_newpass.Text+"' where MSV='"+ Form_Begin.usernamestatic+"'", con);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        if (dt2.Rows.Count <=1)
                        {
                            MessageBox.Show("Successfully changed !");
                            tbox_confirm.Enabled = false;
                            tbox_currentpassword.Enabled = false;
                            tbox_newpass.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Password Incorrect !");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Password Incorrect !");
                }
            }
           
           // dt.Rows.Count() > 1
          catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_hover_currentpass_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_hover_currentpass);
        }

        private void lbl_hover_newpass_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_hover_newpass);
        }

        private void lbl_recheck_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_recheck);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
