using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_add_Fromfile : MetroFramework.Forms.MetroForm
    {

        public Form_add_Fromfile()
        {
            InitializeComponent();
        }
        DataSet dsTest = new DataSet();
        private void btn_excel_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection olecon = new OleDbConnection();
                string strCon = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:/ProjectMH/DONE/thuctap/file_in/finalcauhoi.xls; Extended Properties=Excel 8.0";
                olecon.ConnectionString = strCon;
                olecon.Open();
                string strSQL = "SELECT * FROM [Finalcauhoi$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsTest);
                olecon.Close();
                dsTest.Tables[0].TableName = "new";  //Tên này phải giống với tên của Table trên SQL
                dataGridView1.DataSource = dsTest.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Form_add_Fromfile " + ex.Message);
            }
        }
        public bool ExecBulkCopy(DataTable pDt, string pDesTableName ="")
        {
            try
            {
                if (pDesTableName.Length == 0) pDesTableName = pDt.TableName;
                using (SqlConnection sqlCon = new SqlConnection("Data Source =.; Initial Catalog = quiz; Integrated Security = True"))
                {
                    sqlCon.Open();
                    using (SqlBulkCopy sbc = new SqlBulkCopy(sqlCon))
                    {
                        sbc.DestinationTableName = pDesTableName;
                        sbc.WriteToServer(pDt);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btn_SQL_Click(object sender, EventArgs e)
        {
            if (!ExecBulkCopy(dsTest.Tables[0], "new"))
                MessageBox.Show("Error!", "Notification");
            else
                MessageBox.Show("Success!", "Notification");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           
            Form_add_Single n = new Form_add_Single();
            n.Show();
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            Form_add_Single n = new Form_add_Single();
            n.Show();
            this.Close();
        }

        private void Form_add_Fromfile_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_excel.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_SQL.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
        }
    }
}
