using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_update_Information : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
        //  public static string container_MSV;
        public Form_update_Information()
        {
            InitializeComponent();
        }
        private void START_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            textbox_MSV.Text = form_DangKy.MSVstatic;
            //     container_MSV = textbox_MSV.Text;
        }
        //    public static string MSV;


        public void disablebtn_update()
        {
            btn_update.Visible = false;

        }
        public void disablebtn_start()
        {
            btn_start.Visible = false;

        }
      
        private void btn_start_Click_1(object sender, EventArgs e)
        {
            if (tbox_ten.Text != "" && tbox_sdt.Text != "" || tbox_ngaysinh.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(" UPDATE login SET Name ='" + tbox_ten.Text + "', phone = '" + tbox_sdt.Text + "', dayofbirth = '" + tbox_ngaysinh.Text + "' where MSV ='" + form_DangKy.MSVstatic + "'", con);
                    sqlCommand.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Update Succesful");
                    this.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Update Failed"+ex.Message);
                }

            }
            else
                MessageBox.Show(" Fill the blank ! ", "Notification");
        }

        private void START_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
        //    textbox_MSV.Text = Menu.textbox_MSV;
            if (tbox_ten.Text != "" && tbox_sdt.Text != "" || tbox_ngaysinh.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(" UPDATE login SET Name ='" + tbox_ten.Text + "', phone = '" + tbox_sdt.Text + "', dayofbirth = '" + tbox_ngaysinh.Text + "' where MSV ='" + Form_Begin.usernamestatic + "'", con);
                    sqlCommand.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Update Succesful");
                    this.Close();


                    if (Form_list_PDF.status == true)
                    {

                    }
                    else
                    {
                        Form_Test n = new Form_Test();
                        n.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Update Failed");
                }
                   

            }
            else
                MessageBox.Show("Fill the blank ! ", "Notification");
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required ", lbl_hover_name);
        }

        private void lbl_hover_dof_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_hover_dof);
        }

        private void lbl_hover_phone_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_hover_phone);
        }
    }
}
