using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_get_Answer : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        public static DataGridView Dgv_GETDAPAN { get; set; }
        public Form_get_Answer()
        {
            InitializeComponent();
        }

        private void btn_ExportDA_Click(object sender, EventArgs e)
        {
            DATAGRIDDAPAN.Columns["noidung"].Visible = false;
            DATAGRIDDAPAN.Columns["dapanA"].Visible = false;
            DATAGRIDDAPAN.Columns["dapanB"].Visible = false;
            DATAGRIDDAPAN.Columns["dapanC"].Visible = false;
            DATAGRIDDAPAN.Columns["dapanD"].Visible = false;
            DATAGRIDDAPAN.Columns["cau"].Visible = false;
            /*  DATAGRIDDAPAN.Columns["DapAn"].Visible = true;
              DATAGRIDDAPAN.Columns["STT"].Visible = true;*/



            ///////// EXPORT EXCEL

            {
                for (int i = 1; i <= 10; i++)
                {
                    DataGridViewRow row =
                        (DataGridViewRow)DATAGRIDDAPAN.RowTemplate.Clone();

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
                foreach (DataGridViewColumn col in DATAGRIDDAPAN.Columns)
                {
                    if (col.Visible)
                        listVisible.Add(col);
                }


                for (int i = 0; i < listVisible.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = listVisible[i].HeaderText;
                }

                for (int i = 0; i < DATAGRIDDAPAN.Rows.Count; i++)
                {
                    for (int j = 0; j < listVisible.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DATAGRIDDAPAN.Rows[i].Cells[listVisible[j].Name].Value.ToString();
                    }
                }
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("File Export Succesful !");
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
        }

        private void GETDAPAN_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            btn_Export.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            Dgv_GETDAPAN = DATAGRIDDAPAN;
      
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DATAGRIDDAPAN.Columns["noidung"].Visible = false;
            DATAGRIDDAPAN.Columns["dapanA"].Visible = false;
            DATAGRIDDAPAN.Columns["dapanB"].Visible = false;
            DATAGRIDDAPAN.Columns["dapanC"].Visible = false;
            DATAGRIDDAPAN.Columns["dapanD"].Visible = false;
            DATAGRIDDAPAN.Columns["cau"].Visible = false;
            /*  DATAGRIDDAPAN.Columns["DapAn"].Visible = true;
              DATAGRIDDAPAN.Columns["STT"].Visible = true;*/



            ///////// EXPORT EXCEL

            {
                for (int i = 1; i <= 10; i++)
                {
                    DataGridViewRow row =
                        (DataGridViewRow)DATAGRIDDAPAN.RowTemplate.Clone();

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
                foreach (DataGridViewColumn col in DATAGRIDDAPAN.Columns)
                {
                    if (col.Visible)
                        listVisible.Add(col);
                }


                for (int i = 0; i < listVisible.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = listVisible[i].HeaderText;
                }

                for (int i = 0; i < DATAGRIDDAPAN.Rows.Count; i++)
                {
                    for (int j = 0; j < listVisible.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DATAGRIDDAPAN.Rows[i].Cells[listVisible[j].Name].Value.ToString();
                    }
                }
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("File Export Successful !");
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
        }
    }
}

