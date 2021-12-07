using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{

    public partial class Form_Question : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        public Form_Question()
        {
            InitializeComponent();

        }
        private void FormCauHoi_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            // #4
            con.Open();
            string query_add = "SELECT Allow_add from login where MSV='" + Form_Begin.usernamestatic + "'";

            SqlCommand cmd_query_add = new SqlCommand(query_add, con); ;
            bool _add = Convert.ToBoolean(cmd_query_add.ExecuteScalar());
            con.Close();
          

            // #5
            con.Open();
            string query_edit = "SELECT Allow_edit from login where MSV='" + Form_Begin.usernamestatic + "'";

            SqlCommand cmd_query_edit = new SqlCommand(query_edit, con); ;
            bool _edit = Convert.ToBoolean(cmd_query_edit.ExecuteScalar());
            con.Close();
          

            // #6
            con.Open();
            string query_delete = "SELECT Allow_delete from login where MSV='" + Form_Begin.usernamestatic + "'";

            SqlCommand cmd_query_delete = new SqlCommand(query_delete, con); ;
            bool _delete = Convert.ToBoolean(cmd_query_delete.ExecuteScalar());
            con.Close();
           
            if(_add==false)
            {
                btn_them.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/padlock.png");
                btn_them.Enabled = false;
            }
            if(_edit== false)
            {
                btn_Sua.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/padlock.png");
                btn_Sua.Enabled = false;
            }
            if(_delete== false)
            {
                btn_xoa.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/padlock.png");
                btn_xoa.Enabled = false;
            }


           

            loadtable();
            dataGridView1.Columns["STT"].Visible = false;
        }
        public void loadtable()
        {
            {
               
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM new", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;


            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadtable();
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            Form_add_Single n = new Form_add_Single();
            n.Show();
            this.Hide();
        }
        private void fresh()
        {
            txtcau.Text = "";
            txt_made.Text = "";
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (txt_made.Text != "" || txtcau.Text != "")
            {
              
                SqlDataAdapter da = new SqlDataAdapter("Delete from new WHERE cau='" + txtcau.Text + "'AND madt='" + txt_made.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Deleted");
                fresh();
                loadtable();
             
            }
            else
            {
                MessageBox.Show("The file is deleted or doesn't exist !", "Notification");
            }



        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            Form_edit_Question n = new Form_edit_Question();
            n.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_made.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcau.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void txt_made_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcau_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            UC_delete_Profile df = new UC_delete_Profile();
            UC_Rank bxh = new UC_Rank();
            UC_Profile detail = new UC_Profile();
            detail.reset();
            df.reset();
            bxh.reset();

            this.Hide();
            this.Close();

            MainMenu n = new MainMenu();
            n.Show();
          //  openCauHoi();






            //Login.normal();


        }
    }
}

