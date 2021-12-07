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

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_Begin : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
        public static string usernamestatic;
        public static string date = DateTime.UtcNow.ToString("M/d/yyyy");

        public Form_Begin()
        {
            InitializeComponent();
          
        }

      


        public void openCauHoi()
        {
          
            MainMenu menu = new MainMenu();
            usernamestatic = tbox_user.Text;
         

            menu.Show();
           


        }
        public void normal()
        {
            MainMenu menu = new MainMenu();
         
            usernamestatic = tbox_user.Text;
     

            menu.Show();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM login WHERE MSV= @MSV COLLATE Latin1_General_CS_AS   AND password=@password";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@MSV", tbox_user.Text);
                da.SelectCommand.Parameters.AddWithValue("@password", tbox_password.Text);

                DataTable dt = new DataTable();


                da.Fill(dt);

                if (tbox_user.Text != "" || tbox_password.Text != "")
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (tbox_user.Text == "admin")
                        {

                            openCauHoi();
                            this.Hide();
                        }
                        else
                        {
                            // openCauHoi();
                            normal();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu bạn vừa nhập chưa đúng ! Vui lòng nhập lại sau", "Thông Báo");
                    }






                    con.Open();
                    SqlDataAdapter _sqlda = new SqlDataAdapter(" DELETE FROM Check_DapAn ", con);
                    _sqlda.SelectCommand.ExecuteNonQuery();
                    con.Close();


                    con.Open();
                    string sqlquery7 = ("DBCC CHECKIDENT ('[Check_DapAn]', RESEED, 0)");
                    SqlCommand command7 = new SqlCommand(sqlquery7, con);
                    command7.ExecuteNonQuery();


                    con.Close();


                    try
                    {

                        string _time = DateTime.Now.ToLongTimeString();


                        con.Open();
                        SqlCommand da1 = new SqlCommand("INSERT INTO History(MSV,Date,Time,Activity) VALUES(@MSV,@Date,@Time,@Activity)", con);
                        da1.Parameters.AddWithValue("@MSV", tbox_user.Text);
                        da1.Parameters.AddWithValue("@Date", date);
                        da1.Parameters.AddWithValue("@Time", _time);
                        da1.Parameters.AddWithValue("@Activity", "Đăng Nhập ");
                        da1.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect Account Or Password,Please Check Again!", "Notification");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(" dangnhap_Click "+ ex.Message  );
            }

        }
            
        

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            form_DangKy n = new form_DangKy();
            n.ShowDialog();


        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            this.Icon = Properties.Resources.laptop1;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
          
        }

       

        private void btn_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Send_email uc_Email = new UC_Send_email();

          //  this.Controls.Clear();
            Controls.Add(uc_Email);

            uc_Email.BringToFront();
        }

        private void tbox_user_MouseEnter(object sender, EventArgs e)
        {
            tbox_user.Focus();
        }

        private void tbox_password_MouseEnter(object sender, EventArgs e)
        {
         //   tbox_password.Focus();
        }
    }
}
