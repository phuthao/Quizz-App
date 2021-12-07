using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_Random : MetroFramework.Forms.MetroForm
    {
        public static DataGridView gridView { get; set; }

        public static string getsocau;
        public static string getchude;




        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");

       

        public Form_Random()
        {
            InitializeComponent();
        }
        /* public Effort err = new Effort();*/
        public Export_Random_Exporting ranEx = new Export_Random_Exporting();

        int count_load = 0;
        private void RANDOM_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            {
                btn_tao.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_home.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_exportDA.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_xuat.BackColor= Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            }
            gridView = datagridviewrandom;

            tbox_socau.Text = "---";

            comboBox1_chude.Enabled = false;

            Binddata();



            ranEx.Show();
            ranEx.Hide();

            //     ranEx.Close();



            // count_load++;


            count_load=1;


        }

        void Binddata()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select distinct chude FROM new", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1_chude.DisplayMember = "chude";
            comboBox1_chude.DataSource = dt;


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            datagridviewrandom.Columns["noidung"].Visible = false;
            datagridviewrandom.Columns["dapanA"].Visible = false;
            datagridviewrandom.Columns["dapanB"].Visible = false;
            datagridviewrandom.Columns["dapanC"].Visible = false;
            datagridviewrandom.Columns["dapanD"].Visible = false;

            datagridviewrandom.Columns["cau"].Visible = false;
            /*  datagridviewrandom.Columns["DapAn"].Visible = true;
              datagridviewrandom.Columns["STT"].Visible = true;
              datagridviewrandom.Columns["madt"].Visible = true;*/
            {
                for (int i = 1; i <= 10; i++)
                {
                    DataGridViewRow row =
                        (DataGridViewRow)datagridviewrandom.RowTemplate.Clone();

                }
            }


            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "DapAn";
                worksheet.Cells[1, 1].EntireColumn.NumberFormat = "000";

                List<DataGridViewColumn> listVisible = new List<DataGridViewColumn>();
                foreach (DataGridViewColumn col in datagridviewrandom.Columns)
                {
                    if (col.Visible)
                        listVisible.Add(col);
                }


                for (int i = 0; i < listVisible.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = listVisible[i].HeaderText;
                }

                for (int i = 0; i < datagridviewrandom.Rows.Count; i++)
                {
                    for (int j = 0; j < listVisible.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = datagridviewrandom.Rows[i].Cells[listVisible[j].Name].Value.ToString();
                    }
                }
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("File export successful !");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;

            }
            btn_test.Enabled = true;
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                btn_xuat.Enabled = true;
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT TOP " + tbox_socau.Text + " * FROM (SELECT DISTINCT madt , chude , cau , noidung , dapanA , dapanB , dapanC , dapanD , DapAn , STT FROM new WHERE chude=N'" + comboBox1_chude.Text + "' ) AS d ORDER BY NEWID()", con);

                DataTable dtbl = new DataTable();
              

                sqlDa.Fill(dtbl);

                datagridviewrandom.Columns["DapAn"].Visible = true;
             



                datagridviewrandom.DataSource = dtbl;


                
           
                Form_Document.Dgv.Columns["DapAn"].Visible = false;
               Form_Document.Dgv.DataSource = dtbl;

                Export_Random_Exporting.DGV.DataSource = dtbl;
                Form_get_Answer.Dgv_GETDAPAN.DataSource = dtbl;
           

            }
            catch (IOException ex)
            {
                MessageBox.Show("Fill all the blank !", ex.Message);
            }
            //  con.Close();

           
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
          
        }
      
        public void start_random()
        {
            getchude = comboBox1_chude.Text;
            getsocau = tbox_socau.Text;


            Export_Random_Exporting n = new Export_Random_Exporting();

            n.Show();
        }
        
           
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            //   


            try
            {

                ranEx.Show();

                btn_exportDA.Enabled = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void comboBox1_chude_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1_chude.Items.Count > 0)
                comboBox1_chude.Text = "--Choose Topic--";
        }

        private void tbox_socau_MouseHover(object sender, EventArgs e)
        {
           
                tbox_socau.Text ="";
                comboBox1_chude.Enabled = true;
                tbox_socau.Focus();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Document n = new Form_Document();
            n.Show();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Form_Test n1 = new Form_Test();
            string message = "You want to use this file ?";
            string caption = "Notification";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               



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
    }

}

