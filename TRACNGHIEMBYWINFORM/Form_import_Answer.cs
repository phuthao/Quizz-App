using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_import_Answer : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
        public Form_import_Answer()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = dataTableCollection[cbox_Sheet.SelectedItem.ToString()];

               dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<DeThi> list = new List<DeThi>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DeThi obj = new DeThi();
                    obj.NUMBER = dt.Rows[i]["NUMBER"].ToString();
                    obj.TOPIC = dt.Rows[i]["TOPIC"].ToString();
                    obj.ANSWER = dt.Rows[i]["ANSWER"].ToString();
                    obj.CODE = dt.Rows[i]["CODE"].ToString();


                    list.Add(obj);
                }

                dataGridView1.DataSource = list;
                //      dETHIBindingSource.DataSource = list;

            }
        }
        DataTableCollection dataTableCollection;

        public static string _getdirection ;
       private void button1_Click(object sender, EventArgs e)
        {
           
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xlsx|Excel Workbook|*.xls" })
                {
                try
                {
                    if (Form_list_PDF.INDEX_ != null)
                    {
                        connection.Open();
                        string _query = "SELECT PathExcel From List_PDF where ID='" + Form_list_PDF.INDEX_ + "'";
                        SqlCommand _sql = new SqlCommand(_query, connection);
                        // _sql.Parameters.AddWithValue("@ID",Form_List_PDF.INDEX_);
                        string check_rs = _sql.ExecuteScalar().ToString();
                        _getdirection = check_rs;

                        Form_list_PDF.INDEX_ = null;
                        connection.Close();


                     
                                if (check_rs != "")
                                {
                                    openFileDialog.FileName = check_rs;
                                }

                               

                                else
                                {
                                    //   MessageBox.Show("Error !");
                                    openFileDialog.FileName = openFileDialog.FileName;
                                }
                              
                             /*   else
                                {
                                    openFileDialog.FileName = openFileDialog.FileName;
                                }*/
                          
                        
                        }
                    else
                    {
                        if (UC_Note.transpathexcel == "")
                        {
                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {

                                openFileDialog.FileName = openFileDialog.FileName;
                                _getdirection = openFileDialog.FileName;
                            }
                          

                        }
                        else
                        {
                            openFileDialog.FileName = UC_Note.transpathexcel;
                            _getdirection = openFileDialog.FileName;
                            UC_Note.transpathexcel = "";
                        }

                    }

                    // openFileDialog.FileName = 
                    txt_File.Text = openFileDialog.FileName;

                
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {

                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                    {
                                        UseHeaderRow = true
                                    }
                                });
                                dataTableCollection = result.Tables;
                                cbox_Sheet.Items.Clear();
                                foreach (DataTable table in dataTableCollection)
                                    cbox_Sheet.Items.Add(table.TableName);
                            }
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MainMenu n = new MainMenu();
                n.BringToFront();
            }
           
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            // TODO: This line of code loads data into the 'quizDataSet.DETHI' table. You can move, or remove it, as needed.
            //   this.dETHITableAdapter.Fill(this.quizDataSet.DETHI);

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT NUMBER , CODE , TOPIC , ANSWER FROM DETHI Order by NUMBER ASC  ", connection);
            //   SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * INTO TEMP FROM new where chude=N'" + txt_timkiem.Text + "' and  madt='" + comboBox1.Text + "'  Order by cau ASC  ALTER TABLE TEMP DROP  COLUMN DapAN SELECT * FROM  TEMP DROP TABLE TEMP  ", con);
            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);
          //  sqlDa.Fill(this.quizDataSet.DeTHI);
            dataGridView1.DataSource = dtbl;


            connection.Open();
            string sqlquery7 = ("DBCC CHECKIDENT ('[DETHI]', RESEED, 0)");
            SqlCommand command7 = new SqlCommand(sqlquery7, connection);
            command7.ExecuteNonQuery();


            connection.Close();



          

        }

        private void btn_import_Click(object sender, EventArgs e)
        {

            connection.Open();
            string sqlquery7 = ("DBCC CHECKIDENT ('[DETHI]', RESEED, 0)");
            SqlCommand command7 = new SqlCommand(sqlquery7, connection);
            command7.ExecuteNonQuery();


            connection.Close();

            try
            {
                string connectString = "Data Source =.; Initial Catalog = quiz; Integrated Security = True";
                DapperPlusManager.Entity<DeThi>().Table("DETHI");

                List<DeThi> deThi = dataGridView1.DataSource as List<DeThi>;
                if (deThi != null)
                {
                    using (IDbConnection db = new SqlConnection(connectString))
                    {
                        db.BulkInsert(deThi);
                    }
                    //   Insert(dETHIBindingSource.DataSource as List<DeThi>);
               

           
                    MessageBox.Show("Finished !");

                 


                    this.Close();
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();


        }

        private void ImportForm_Load_1(object sender, EventArgs e)
        {
          this.Enabled = true;
            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            //   button1_Click(sender, e);
        }

        public void Ena()
        {
            this.Enabled = true;
        }

        private void Form_import_Dapan_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
