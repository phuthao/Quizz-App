using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;




namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_add_Single : MetroFramework.Forms.MetroForm
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");



        public Form_add_Single()
        {
            InitializeComponent();

        }

      

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Question n = new Form_Question();
            n.Show();
        }

     
       

        public string DapAn = "";
        private void radA_CheckedChanged(object sender, EventArgs e)
        {
            DapAn = "A";

        }
        private void radB_CheckedChanged_1(object sender, EventArgs e)
        {
            DapAn = "B";
        }
        private void radC_CheckedChanged_1(object sender, EventArgs e)
        {
            DapAn = "C";
        }
        private void radD_CheckedChanged_1(object sender, EventArgs e)
        {
            DapAn = "D";
        }

        private void fresh()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtmade.Text = "";
            txtGhiChu.Text = "";
            txtchude.Text = "";
            rtxtNoiDung.Text = "";
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;
            rabtn_Easy.Checked = false;
            rabtn_Hard.Checked = false;
            rabtn_Medium.Checked = false;
            groupBox2.Text = "Level";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (txtGhiChu.Text == "" || txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "" || txtchude.Text == "" || txtmade.Text == "")
            {
                MessageBox.Show("The question is incomplete ,Please check again! ");
                count = 1;
            }

            if(groupBox2.Text=="Level")
            {
                groupBox2.Text = "M";
            }

            if (count == 0)
            {
                try
                {
                    con.Open();


                    SqlDataAdapter da = new SqlDataAdapter("INSERT INTO new VALUES('" + txtmade.Text + " ' , N'" + txtchude.Text + "', N'" + txtGhiChu.Text + "' , N'" + rtxtNoiDung.Text + "','" + txtA.Text + "' , '" + txtB.Text + "','" + txtC.Text + "' , '" + txtD.Text + "','" + DapAn + "','" + groupBox2.Text + "' )", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Added");
                    fresh();
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("btnLuu_Click " + ex.Message);
                }
            }



        }

        private void btn_themtheofile_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_add_Fromfile n = new Form_add_Fromfile();
            n.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fresh();
        }

    

        private void rabtn_Easy_CheckedChanged(object sender, EventArgs e)
        {
            if(rabtn_Easy.Checked)
            {
                groupBox2.Text = "E";
            }
        }

        private void rabtn_Medium_CheckedChanged(object sender, EventArgs e)
        {
            if (rabtn_Medium.Checked)
            {
                groupBox2.Text = "M";
            }
        }

        private void rabtn_Hard_CheckedChanged(object sender, EventArgs e)
        {
            if (rabtn_Hard.Checked)
            {
                groupBox2.Text = "H";
            }
        }

        private void Form_add_Single_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            btnLuu.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_reload.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btnHuy.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_themtheofile.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
        }
    }
}

