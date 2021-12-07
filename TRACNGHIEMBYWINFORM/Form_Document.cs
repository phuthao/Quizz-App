using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;
//using MultiFaceRec;

namespace TRACNGHIEMBYWINFORM
{

    public partial class Form_Document : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        public static DataGridView Dgv { get; set; }


        public static string get_txttiemkiem;
        public static string get_made;
        



        public Form_get_Answer nfinal = new Form_get_Answer();
      

        public Form_Document()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void show_GETDAPAN()
        {

         
            nfinal.Show();



        }
       
        void show_GETDAPAN2()
        {
         
            nfinal.Show();
        }
        public virtual void Remove()
        {
            dataGridView1.Columns.Remove("STT");
            dataGridView1.Columns.Remove("DapAn");
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            get_txttiemkiem = txt_timkiem.Text;
            get_made = comboBox1.Text;
            Binddata();
            try
            {
              
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT madt , chude , cau , noidung , dapanA , dapanB , dapanC , dapanD , DapAn , STT FROM new where chude=N'" + txt_timkiem.Text + "' Order by cau ASC  ", con);

                DataTable dtbl = new DataTable();
                dataGridView1.Columns["DapAn"].Visible = false;

                dataGridView1.Columns["STT"].Visible = false;


                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                Form_get_Answer.Dgv_GETDAPAN.DataSource = dtbl;
               

             
            }
            catch
            {
                MessageBox.Show("Fill the blank !");
            }
        }


        /// //////////////////////////////////////////////////////////////////////////
        private void FormDeThi_Load(object sender, EventArgs e)
        {

            this.Icon = Properties.Resources.laptop1;


            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_export.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_import.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_trondethi.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_lamde.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            show_GETDAPAN();
            nfinal.Hide();

           
            // databind
            // 


            Dgv = dataGridView1;


            btn_lamde.Enabled = false;



            cbox_advanced.Visible= false;
            rabtn_easy.Visible = false;
            rabtn_hard.Visible = false;
          rabtn_medium.Visible = false;



        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            btn_import.Enabled = true;
            Export_File_Exporting n = new Export_File_Exporting();
           
            n.ShowDialog();
                      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();


            UC_delete_Profile df = new UC_delete_Profile();
            UC_Rank bxh = new UC_Rank();
            UC_Profile detail = new UC_Profile();
            detail.reset();
            df.reset();
            bxh.reset();


            /* Menu n = new Menu();
             n.ShowDialog();
             this.Close();*/
            MainMenu n = new MainMenu();
            if (Form_Begin.usernamestatic == "admin")
            {

                //openCauHoi();

                   n.Show();
                this.Close();

            }
            else
            {

                //Login.normal();

                n.hideonbush();
                        n.Show();
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Test n1 = new Form_Test();
            string message = "You want to use this file ?";
            string caption = "Notification";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                /* MSVstatic = txt_username.Text;
                 START n = new START();
                 n.Show();*/
                n1.sharepdf();
                n1.Show();
            }
            if (result == DialogResult.No)
            {
                // Closes the parent form.
                n1.Show();
                this.Close();


            }
            this.Close();
        }
        void Binddata()
        {
            comboBox1.Text = "---";
            SqlDataAdapter da = new SqlDataAdapter("Select distinct madt FROM new where chude=N'"+txt_timkiem.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DisplayMember = "madt";
            comboBox1.DataSource = dt;

            //  connection.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            get_made = comboBox1.Text;
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT madt , chude , cau , noidung , dapanA , dapanB , dapanC , dapanD , DapAn , STT FROM new where chude=N'" + txt_timkiem.Text + "'and madt='" + comboBox1.Text + "' Order by cau ASC ", con);
            //   SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * INTO TEMP FROM new where chude=N'" + txt_timkiem.Text + "' and  madt='" + comboBox1.Text + "'  Order by cau ASC  ALTER TABLE TEMP DROP  COLUMN DapAN SELECT * FROM  TEMP DROP TABLE TEMP  ", con);
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            Form_get_Answer.Dgv_GETDAPAN.DataSource = dtbl;

            cbox_advanced.Visible = true;
        }

        private void btn_trondethi_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_Random n = new Form_Random();
            
            n.Show();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            btn_lamde.Enabled = true;
            show_GETDAPAN2();
            /*    GETDAPAN n = new GETDAPAN();
                n.Show();*/

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();


            UC_delete_Profile df = new UC_delete_Profile();
            UC_Rank bxh = new UC_Rank();
            UC_Profile detail = new UC_Profile();
            detail.reset();
            df.reset();
            bxh.reset();


            /* Menu n = new Menu();
             n.ShowDialog();
             this.Close();*/
            MainMenu n = new MainMenu();
           /* if (Form_Begin.usernamestatic == "admin")
            {*/

                //openCauHoi();

                n.Show();
                this.Close();

          /*  }
            else
            {

                //Login.normal();

                n.hideonbush();
                n.Show();
                this.Close();
            }*/
        }

        private void cbox_advanced_CheckedChanged(object sender, EventArgs e)
        {

            if(cbox_advanced.Checked==true)
            {
               
                rabtn_easy.Visible = true;
                rabtn_hard.Visible = true;
                rabtn_medium.Visible = true;
            }
            if(cbox_advanced.Checked==false)
            {
                rabtn_easy.Visible = false;
                rabtn_hard.Visible = false;
                rabtn_medium.Visible = false;
            }
        }

        private void rabtn_easy_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT madt , chude , cau , noidung , dapanA , dapanB , dapanC , dapanD , DapAn , STT FROM new where chude=N'" + txt_timkiem.Text + "' AND madt='" + comboBox1.Text + "' AND _Level='Easy' Order by cau ASC  ", con);

            DataTable dtbl = new DataTable();
            dataGridView1.Columns["DapAn"].Visible = false;

            dataGridView1.Columns["STT"].Visible = false;


            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            Form_get_Answer.Dgv_GETDAPAN.DataSource = dtbl;
        }

        private void rabtn_medium_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT madt , chude , cau , noidung , dapanA , dapanB , dapanC , dapanD , DapAn , STT FROM new where chude=N'" + txt_timkiem.Text + "' AND madt='" + comboBox1.Text + "' AND _Level='Medium' Order by cau ASC  ", con);

            DataTable dtbl = new DataTable();
            dataGridView1.Columns["DapAn"].Visible = false;

            dataGridView1.Columns["STT"].Visible = false;


            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            Form_get_Answer.Dgv_GETDAPAN.DataSource = dtbl;
        }

        private void rabtn_hard_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT madt , chude , cau , noidung , dapanA , dapanB , dapanC , dapanD , DapAn , STT FROM new where chude=N'" + txt_timkiem.Text + "' AND madt='" + comboBox1.Text + "' AND _Level='Hard' Order by cau ASC  ", con);

            DataTable dtbl = new DataTable();
            dataGridView1.Columns["DapAn"].Visible = false;

            dataGridView1.Columns["STT"].Visible = false;


            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            Form_get_Answer.Dgv_GETDAPAN.DataSource = dtbl;
        }

        private void btn_export_MouseHover(object sender, EventArgs e)
        {
            lbl_1.Visible = true;
            lbl_2.Visible = true;
            lbl_3.Visible = true;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_lamde_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
