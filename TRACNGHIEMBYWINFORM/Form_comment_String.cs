using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_comment_String : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");

        public Form_comment_String()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

         /*   try
            {*/
                con.Open();
            string query = "INSERT INTO Comment(Label_Comment,Comment_String,MSV,_Day,FileData,FilePathPDF,FileExcel) Values(@Label_Comment,@Comment_String,@MSV,@_Day,@FileData,@FilePathPDF,@FileExcel) ";
            SqlCommand _sqlA = new SqlCommand(query, con);
            _sqlA.Parameters.AddWithValue("@Label_Comment", tbox_label.Text);
            _sqlA.Parameters.AddWithValue("@Comment_String", richTextBox1.Rtf);

            _sqlA.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);
            _sqlA.Parameters.AddWithValue("@_Day", Form_Score.dob_Note);


                byte[] fileData = File.ReadAllBytes(@"D:\ProjectMH\DONE\thuctap\TRACNGHIEMBYWINFORM\ANOTHERFILEINPUT\DETHI\FILEDETHIOUTPUT\Output.pdf");

                _sqlA.Parameters.AddWithValue("@FileData", fileData);

                _sqlA.Parameters.AddWithValue("@FilePathPDF", "empty");
                _sqlA.Parameters.AddWithValue("@FileExcel","empty");

                _sqlA.ExecuteNonQuery();
                con.Close();



                //    _sqlA.Parameters.AddWithValue("@FileExcel", Form_import_Answer._getdirection);



                //   var binary1 = insertCMD.Parameters.Add("@ErrorScreenshot", SqlDbType.VarBinary, -1);









                con.Open();
            string query2 = "UPDATE Note SET Label_Comment = @Label_Comment  where _Day=@_Day and MSV=@MSV and MaDT = @MaDT and _Count=@_Count ";
            SqlCommand _sqlA2 = new SqlCommand(query2, con);

            _sqlA2.Parameters.AddWithValue("@Label_Comment", tbox_label.Text);
            _sqlA2.Parameters.AddWithValue("@_Day", Form_Score.dob_Note);
            _sqlA2.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);
            _sqlA2.Parameters.AddWithValue("@MaDT", UC_checkDapan.Numrd);
            _sqlA2.Parameters.AddWithValue("@_Count", UC_checkDapan._rs);
            //     _sqlA2.Parameters.AddWithValue("@_Count", _count++);
            _sqlA2.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Saved");



            /// load PDF binary 
            /// 
            if (Form_Test._pathh == "")
            {

                con.Open();
                string query3 = "UPDATE Comment SET FileData = @FileData  where Label_Comment=@Label_Comment and MSV=@MSV ";
                SqlCommand _sqlA3 = new SqlCommand(query3, con);

                _sqlA3.Parameters.Add("@FileData", SqlDbType.VarBinary).Value = Form_list_PDF._temp;
                //    p.DbType = DbType.Binary;
                _sqlA3.Parameters.AddWithValue("@Label_Comment", tbox_label.Text);
                _sqlA3.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);

                //     _sqlA2.Parameters.AddWithValue("@_Count", _count++);

                _sqlA3.ExecuteNonQuery();
                con.Close();
            }
          else
            { 

   
                con.Open();
                string query4 = "UPDATE Comment SET FilePathPDF = @FilePathPDF  where Label_Comment=@Label_Comment and MSV=@MSV ";
                SqlCommand _sqlA4 = new SqlCommand(query4, con);

                _sqlA4.Parameters.AddWithValue("@FilePathPDF", Form_Test._pathh);
                //    p.DbType = DbType.Binary;
                _sqlA4.Parameters.AddWithValue("@Label_Comment", tbox_label.Text);
                _sqlA4.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);

                //     _sqlA2.Parameters.AddWithValue("@_Count", _count++);

                _sqlA4.ExecuteNonQuery();
                con.Close();
            }

                //      EXCELPATH
                con.Open();
                string query5 = "UPDATE Comment SET FileExcel = @FileExcel  where Label_Comment=@Label_Comment and MSV=@MSV ";
                SqlCommand _sqlA5 = new SqlCommand(query5, con);

                _sqlA5.Parameters.AddWithValue("@FileExcel", Form_import_Answer._getdirection);

                _sqlA5.Parameters.AddWithValue("@Label_Comment", tbox_label.Text);
                _sqlA5.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);



                _sqlA5.ExecuteNonQuery();
                con.Close();


                this.Close();




        }

       
     

        private void btn_save_label_Click(object sender, EventArgs e)
        {
            //richTextBox1.Clear();
         

        }



        int count_click_bold = 0;
        private void btn_bold_Click(object sender, EventArgs e)
        {
            if (count_click_bold % 2 == 0)
            {
                btn_bold.BackColor = Color.LightYellow;
                
            }
            else
            {
                btn_bold.BackColor = Color.FromArgb(41, 128, 185);
            }


            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Bold)
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();

            count_click_bold++;
        }


        int count_click_italic = 0;
        private void btn_italic_Click(object sender, EventArgs e)
        {
            if (count_click_italic % 2 == 0)
            {
                btn_italic.BackColor = Color.LightYellow;

            }
            else
            {
                btn_italic.BackColor = Color.FromArgb(41, 128, 185);
            }

            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Italic)
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Italic);

            richTextBox1.SelectionFont = new1;

            richTextBox1.Focus();

            count_click_italic++;

        }




        int count_click_underline = 0;
        private void btn_underline_Click(object sender, EventArgs e)
        {
            if (count_click_underline % 2 == 0)
            {
                btn_underline.BackColor = Color.LightYellow;

            }
            else
            {
                btn_underline.BackColor = Color.FromArgb(41, 128, 185);
            }

            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Underline)
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Underline);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();

            count_click_underline++;
        }

       

        private void btn_togglebullet_Click(object sender, EventArgs e)
        {
          //  richTextBox1.Text +=  Environment.NewLine+ "+ " ;
        }

        private void Form_Comment_String_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            panel3.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_bold.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_italic.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_underline.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_delete.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_save.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));

        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }

        private void tbox_label_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void tbox_label_MouseHover(object sender, EventArgs e)
        {
            tbox_label.Focus();
            tbox_label.Enabled = true;
        //    tbox_label.BackColor =colorDialog1.Color;
            tbox_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            tbox_label.CharacterCasing = CharacterCasing.Upper;
        }

        private void tbox_label_MouseLeave(object sender, EventArgs e)
        {
         //   tbox_label.BackColor = colorDialog1.Color;
            tbox_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void tbox_label_TextChanged(object sender, EventArgs e)
        {

        }


     
       
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_bold_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
