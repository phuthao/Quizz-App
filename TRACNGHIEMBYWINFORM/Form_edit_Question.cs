using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_edit_Question : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        public Form_edit_Question()
        {
            InitializeComponent();
            loadtable();
        }
        public void loadtable()
        {
            this.WindowState = FormWindowState.Maximized;
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM new", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


                con.Close();
            }
        }
        private string DapAn = "";
        private void radA_CheckedChanged_1(object sender, EventArgs e)
        {
            DapAn = "A";
        }

        private void radB_CheckedChanged(object sender, EventArgs e)
        {
            DapAn = "B";
        }

        private void radC_CheckedChanged(object sender, EventArgs e)
        {
            DapAn = "C";
        }

        private void radD_CheckedChanged(object sender, EventArgs e)
        {
            DapAn = "D";
        }

        private void rabtn_Easy_CheckedChanged(object sender, EventArgs e)
        {
            if (rabtn_Easy.Checked)
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
        public void fresh()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtmade.Text = "";
            txtGhiChu.Text = "";
            txtchude.Text = "";
            rtxtNoiDung.Text = "";

            groupBox2.Text = "Level";
            rabtn_Hard.Checked = false;
            rabtn_Medium.Checked = false;
            rabtn_Easy.Checked = false;
        }
        void sua()
        {
            if (groupBox2.Text == "Level")
            {
                groupBox2.Text = "M";
            }

            if (rtxtNoiDung.Text != "" || txtchude.Text != "" || txtA.Text != "" || txtB.Text != "" || txtC.Text != "" || txtD.Text != "" || txtGhiChu.Text != "" || txtmade.Text != "")
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(" Update new set noidung='" + rtxtNoiDung.Text + "',chude='" + txtchude.Text + "',dapanA='" + txtA.Text + "',dapanB='" + txtB.Text + "',dapanC='" + txtC.Text + "',dapanD='" + txtD.Text + "',DapAn='" + DapAn + "', _Level='"+groupBox2.Text+"' where madt='" + txtmade.Text + "' and cau='" + txtGhiChu.Text + "'", con);
                //   SqlDataAdapter da1 = new SqlDataAdapter(" Update new set noidung='" + rtxtNoiDung.Text + "',madt='" + txtmade.Text + "',cau='"+txtGhiChu.Text+"',dapanA='" + txtA.Text + "',dapanB='" + txtB.Text + "',dapanC='" + txtC.Text + "',dapanD='" + txtD.Text + "',DapAn='" + DapAn + "'where chude='" + txtchude.Text +"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //    da1.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Changed");
                fresh();
                con.Close();
                loadtable();
            }
            else

                MessageBox.Show(" Choose a question !", "Notification");

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmade.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtchude.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            rtxtNoiDung.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            txtA.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtC.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtD.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            groupBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            groupBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();



            if(groupBox1.Text=="A")
            {
                radA.Checked = true;
            }
                if (groupBox1.Text == "B")
            {
                radB.Checked = true;
            }
            if (groupBox1.Text == "C")
            {
                radC.Checked = true;
            }
            if (groupBox1.Text == "D")
            {
                radD.Checked = true;
            }






            if (groupBox2.Text=="E")
            {
                rabtn_Easy.Checked = true;
            }
            if(groupBox2.Text=="H")
            {
                rabtn_Hard.Checked = true;
            }
            if(groupBox2.Text=="M")
            {
                rabtn_Medium.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_edit_Question_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            btnHuy.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btnLuu.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
        }
    }
}

