using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TRACNGHIEMBYWINFORM
{
    public partial class form_DangKy : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

        // message 
        public string message = "You want to update your information ?";
        public string caption = "Notification";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result;

        public static string MSVstatic;
        public form_DangKy()
        {
            InitializeComponent();
        }
        private void form_DangKy_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            disable();
            MSVstatic = txt_username.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void Enable_BackLogin()
        {
            button1.Enabled = false;

        }
        public void clear()
        {
            //    txt_username.Text = ("");
            txt_pw.Text = ("");
            txt_xacnhanpw.Text = ("");
        }
        void dangky()
        {
            int count = 1;
            if (txt_username.Text != "" && txt_pw.Text != "" || txt_xacnhanpw.Text != "")
            {
                if (txt_pw.Text == txt_xacnhanpw.Text)
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("INSERT INTO login(MSV,password,Email,Allow_document,Allow_history,Allow_accountcontrol,Allow_add,Allow_edit,Allow_delete,Allow_upload,Allow_import) VALUES(N'" + txt_username.Text + "' , '" + txt_pw.Text + "','"+tbox_email.Text+ "','0','0','0','0','0','0','0','0')", con);
                    DataTable dt = new DataTable();

                    try
                    {
                        da.Fill(dt);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" Account already exists ", " Notification ");
                      
                        clear();
                        count = 0;
                        message = "Check your password";
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Register Successfully ", "Notification");

                        clear();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show(" Password Incorrect ! Please Check Again ", "Notification");
                    message = "Password Incorrect";
                    caption = "Notification";

                }
                con.Close();

            }
            else
                MessageBox.Show(" Please fill the blank ! ", "Notification");

        }

        private void btn_dangky_dangky_Click(object sender, EventArgs e)
        {
            dangky();

            if (message == " Password Incorrect ! Please Check Again !")
            {

            }
            else
            {
                message = "You want to update your information ?";
                caption = "Notification";
                /* MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                 DialogResult result;*/


                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    MSVstatic = txt_username.Text;
                    Form_update_Information n = new Form_update_Information();
                    n.disablebtn_update();
                    n.ShowDialog();
                }
                if (result == DialogResult.No)
                {
                    // Closes the parent form.
                    this.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   this.Hide();
          /*  Form_DangNhap n = new Form_DangNhap();
            n.ShowDialog();*/
            this.Close();

        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        void disable()
        {
            tbox_email.Enabled = false;
            txt_pw.Enabled = false;
            txt_xacnhanpw.Enabled = false;
        }
        void enable()
        {
            tbox_email.Enabled = true;
            txt_pw.Enabled = true;
            txt_xacnhanpw.Enabled = true;
        }

        private void btn_checkuser_Click(object sender, EventArgs e)
        {
          //  con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MSV from login where MSV='"+txt_username.Text+ "' COLLATE Latin1_General_CS_AS ", con);
            DataTable dt = new DataTable();         
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                MessageBox.Show(" Account already exists ", " Notification");
                disable();
            }
            else
            {
                MessageBox.Show(" You can use this username ", " Notification ");
                enable();
            }
           
        }

        private void btn_checkuser_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Check your username ", btn_checkuser);
        }

        private void lbl_hover_email_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required ", lbl_hover_email);
        }

        private void lbl_hover_pass_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_hover_pass);
        }

        private void lbl_hover_re_pass_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This field is required", lbl_hover_re_pass);
        }
    }
}
