using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_list_PDF : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

        public static string INDEX_;

        public static string _timecountdown;
        public Form_list_PDF()
        {
            InitializeComponent();
        }

      
        string fileName;

        void load()
        {
            string sql = "Select ID,FileName,FileExcelName,Time from List_PDF";

            connection.Open();
            SqlCommand cmd2 = new SqlCommand(sql, connection);
            SqlDataReader Reader = cmd2.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {

                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetTimeSpan(3).ToString());
                listView1.Items.Add(lv);


            }

            Reader.Close();
            connection.Close();
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF|*.pdf", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    lbl_filename.Text = Path.GetFileName(fileName);
                    //     pictureBox1.Image = Image.FromFile(fileName);



                    string filePath = fileName;

                    string FileName = Path.GetFileName(fileName);

                    string FileExcelName = "Empty";

                    using (SqlConnection sqlconnection = new SqlConnection(@"Data Source=.; Initial Catalog=quiz; Integrated Security=true;"))
                    {
                        sqlconnection.Open();

                        // create table if not exists 

                        // Converts text file(.txt) into byte[]
                        byte[] fileData = File.ReadAllBytes(filePath);

                        string insertQuery = @"Insert Into [List_PDF] ([FileData],[FileName],[FileExcelName],[Time]) Values(@FileData,@FileName,@FileExcelName,@Time)";

                        // Insert text file Value into Sql Table by SqlParameter
                        SqlCommand insertCommand = new SqlCommand(insertQuery, sqlconnection);
                        SqlParameter sqlParam = insertCommand.Parameters.AddWithValue("@FileData", fileData);
                        SqlParameter sqlParam2 = insertCommand.Parameters.AddWithValue("@FileName", FileName);
                        SqlParameter sqlParam3 = insertCommand.Parameters.AddWithValue("@FileExcelName",FileExcelName);
                        SqlParameter sqlParam4 = insertCommand.Parameters.AddWithValue("@Time","01:00:00");


                        sqlParam.DbType = DbType.Binary;
                        insertCommand.ExecuteNonQuery();

                        //  listView1.Items.Add(label1.Text);
                    }
                }
               

                MessageBox.Show("Upload Suceessful !");
            }

       //     btn_import_Click(sender, e);

            load();

            MessageBox.Show("Import File Result Of Your File !");
        }

        public string _index;
       public string _path;



        public string message = "You want to choose this file ?";
        public string caption = "Confirm";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result;


        public static bool status = false;
    private void btn_load_Click(object sender, EventArgs e)
        {
            status = true;
            try
            {

                connection.Open();
                SqlCommand sql = new SqlCommand("SELECT Name from login where MSV = '" + Form_Begin.usernamestatic + "'", connection);
                string in4_check = sql.ExecuteScalar().ToString();

                connection.Close();
                if (in4_check == "")
                {

                    //    countpdf = 1;
                    MessageBox.Show("Please update your information to use this function ", "Notification ");

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("You want to update your information ?", "Notification", buttons, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        //  this.SendToBack();
                        //   MSVstatic = txt_username.Text;
                        Form_update_Information n_update = new Form_update_Information();
                        n_update.disablebtn_start();
                        n_update.ShowDialog();
                    }
                    if (result == DialogResult.No)
                    {


                    }
                }
                else
                {
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();

                        try
                        {
                            connection.Open();

                            string sqlquery2 = ("SELECT Time  FROM List_PDF where ID='" + _index + "' ");
                            SqlCommand command2 = new SqlCommand(sqlquery2, connection);
                            _timecountdown = command2.ExecuteScalar().ToString();
                            _index = null;

                            connection.Close();
                        }
                        catch
                        {
                            _timecountdown = "01:00:59";
                        }


                        Form_Test n = new Form_Test();
                        n.Show();
                        n.sharepdf();

                        Form_import_Answer n2 = new Form_import_Answer();
                        n2.Ena();
                        n2.ShowDialog();

                    }

                    if (result == DialogResult.No)
                    {

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("List_btnText " + ex.Message);
            }
         
          

         
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            axAcroPDF1.src = _path;
          
        }


        public static byte[] _temp;
     
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (this.listView1.SelectedItems.Count == 0)
                return;

            _index = this.listView1.SelectedItems[0].Text;
           
            listView1.FullRowSelect = true;

            INDEX_ = _index;

        

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Select FileData From List_PDF WHERE (ID = @id)";
            cmd.Parameters.AddWithValue("@id", _index);
            byte[] _binaryData = (byte[])cmd.ExecuteScalar();


            _path = "D:\\ProjectMH/DONE/thuctap/TRACNGHIEMBYWINFORM/ANOTHERFILEINPUT/DETHI/FILEDETHIOUTPUT/Output.pdf";

            //_temp = _binaryData; // comment string 
            _temp = _binaryData;
          
         

            File.WriteAllBytes(_path, _temp);
            string s = Encoding.UTF8.GetString(_binaryData);
            connection.Close();


            connection.Open();
            SqlCommand _cmd2 = connection.CreateCommand();
            _cmd2.CommandText = "Select FileName From List_PDF WHERE (ID = @id) ";
            _cmd2.Parameters.AddWithValue("@id", _index);
            lbl_filename.Text = _cmd2.ExecuteScalar().ToString();
            connection.Close();
        }

        private void Form_List_PDF_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu n = new MainMenu();
            n.Show();
        }

        private void lbl_filename_Click(object sender, EventArgs e)
        {
         /*   System.IO.File.ReadAllText(lbl_filename.Text);*/
        }

        private void Form_List_PDF_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            load();

            // load color 

            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_import.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_upload.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B)); 
            btn_load.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B)); 
            btn_close.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));

            //#6
            connection.Open();
            string query_delete = "SELECT Allow_delete from login where MSV='" + Form_Begin.usernamestatic + "'";

            SqlCommand cmd_query_delete = new SqlCommand(query_delete, connection); ;
            bool _delete = Convert.ToBoolean(cmd_query_delete.ExecuteScalar());
            connection.Close();
         

            // #7
            connection.Open();
            string query_upload = "SELECT Allow_upload from login where MSV='" + Form_Begin.usernamestatic + "'";

            SqlCommand cmd_query_upload = new SqlCommand(query_upload, connection); ;
            bool _upload = Convert.ToBoolean(cmd_query_upload.ExecuteScalar());
            connection.Close();


            // #8
            connection.Open();
            string query_import = "SELECT Allow_import from login where MSV='" + Form_Begin.usernamestatic + "'";

            SqlCommand cmd_query_import = new SqlCommand(query_import, connection); ;
            bool _import = Convert.ToBoolean(cmd_query_import.ExecuteScalar());
            connection.Close();

            if (_upload == false)
            {
                btn_upload.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/padlock.png");
                btn_upload.Enabled = false;
            }
            if (_import == false)
            {
                btn_import.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/padlock.png");
                btn_import.Enabled = false;
            }
            if (_delete==false)
            {
                btn_xoa.Enabled = false;
            }
              
              
           //   btn_xoa.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/padlock.png");
              
              
            
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            axAcroPDF1.src = _path;
            LeftMouseClick(800,500);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            
        }

        string file_excel_path;
        private void btn_import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xlsx|Excel Workbook|*.xls", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    file_excel_path = ofd.FileName;
                  

                    string _FilePath =  Path.GetFullPath(file_excel_path) ;
                    string _FileName = Path.GetFileName(file_excel_path);
                    connection.Open(); 
                    string query = "UPDATE List_PDF SET PathExcel='"+_FilePath+"' , FileExcelName ='"+_FileName+"' where ID ='"+_index+"'";
                    SqlCommand _sql = new SqlCommand(query, connection);
                    _sql.ExecuteNonQuery();
                    connection.Close();

                 //   file_excel_path = _FilePath;
                    Form_set_Time n = new Form_set_Time();
                    n.ShowDialog();

                    MessageBox.Show("Import Success !");
                    load();
                }
            }
             
            
        }
       
        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        private static void LeftMouseClick(int Xposition, int Yposition)
        {
            SetCursorPos(Xposition, Yposition);
            mouse_event(MOUSEEVENTF_LEFTDOWN, Xposition, Yposition, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Xposition, Yposition, 0, 0);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_index != null)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Delete from List_PDF WHERE ID=@ID", connection);
                cmd.Parameters.AddWithValue("@ID", _index);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deleted");

             
              
            }
            else
            {
                MessageBox.Show("The file is deleted or does not exist !", "Notification");
            }
            load();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form_list_PDF_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
