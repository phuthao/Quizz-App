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

namespace TRACNGHIEMBYWINFORM
{
    public partial class UC_Note : UserControl
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        public static DataGridView gridView { get; set; }
        private static UC_Note _instance;
        public static UC_Note Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Note();

                    //     _instance.splitContainer1.Panel2.Width = 100;
                }

                return _instance;

            }

        }
        public UC_Note()
        {
            InitializeComponent();
        }

        void Binddata()
        {
              // cbox_selection_comment.Text = "---";
       //     con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Label_Comment FROM Comment where MSV='"+Form_Begin.usernamestatic+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbox_selection_comment.DisplayMember = "Label_Comment";
            cbox_selection_comment.DataSource = dt;

            //  connection.Close();
           // con.Close();
        }
        private void UC_Note_Load(object sender, EventArgs e)
        {
            Binddata();
            axAcroPDF1.Focus();
         
            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            panel4.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
         //   panel6.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            panel7.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));

            btn_lamlai.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            panel3.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_close.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
           
        }


        DataTable dt2 = new DataTable();
       
        private void button1_Click(object sender, EventArgs e)
        {

          /*  EXPORT rpt = new EXPORT();
          
         
            rpt.SetDataSource(dt2);

            crystalReportViewer1.ReportSource = rpt;*/


        }
        public void _reset()
        {
            _instance = null;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
         //   _reset();
           ((Form)this.TopLevelControl).Close();
            MainMenu n = new MainMenu();
            n.Show();
       //     _instance = new UC_Note();

          //  n.BringToFront();
              _reset();
        }

        int _count_click_btnedit=0;
        private void btn_expand_Click(object sender, EventArgs e)
        {
          /*  tbox_note.ReadOnly = false;
            //    btn_pin.BringToFront();

            if (_count_click_btnedit % 2 == 0)
            {
                panel_tools.Visible = true;
                tbox_note.Enabled = true;
                btn_pin.BringToFront();

            }
            else
            {
                panel_tools.Visible = false;
                tbox_note.Enabled = false;
            }
            _count_click_btnedit++;*/
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
          /*  try
            {
                con.Open();
                SqlCommand sqlDa = new SqlCommand("Update Comment SET Comment_String = '" + tbox_note.Text + "' ", con);
                sqlDa.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Đã lưu");
                tbox_note.ReadOnly = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btn_expand.BringToFront();

            tbox_note.Enabled = false;
            if (tbox_note.Enabled == false)
            {
                panel_tools.Visible = false;
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        string _path;

        public static string RtfFileAsPlainText(string rtfPathName)
{
    using (var rtf = new RichTextBox())
    {
        rtf.Rtf = File.ReadAllText(rtfPathName);
        return rtf.Text;
    }
}
        
        private void cbox_selection_comment_SelectedIndexChanged(object sender, EventArgs e)
        {
             con.Open();
           
            SqlCommand sqlDa2 = new SqlCommand("SELECT Comment_String FROM Comment where MSV='" + Form_Begin.usernamestatic + "' and Label_Comment= '" + cbox_selection_comment.Text + "'", con);
            tbox_note.Rtf = sqlDa2.ExecuteScalar().ToString();
          
            using (File.Create(@"C:\Users\super\Desktop\DETHI\fileoutput.rtf")) ;
            tbox_note.SaveFile(@"C:\Users\super\Desktop\DETHI\fileoutput.rtf", RichTextBoxStreamType.RichText);
            tbox_note.LoadFile(@"C:\Users\super\Desktop\DETHI\fileoutput.rtf");

            string fileName = @"C:\Users\super\Desktop\DETHI\fileoutput.rtf";
            FileInfo filetodelete = new FileInfo(fileName);
            try
            {
                filetodelete.Delete();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();


            fectch_data_panel();
                _Refresh();


            con.Open();
            string sqlquery2 = ("SELECT FilePathPDF  FROM Comment where  MSV='" + Form_Begin.usernamestatic + "' and Label_Comment= N'" + cbox_selection_comment.Text + "'");
            SqlCommand command2 = new SqlCommand(sqlquery2, con);
            string _PATH = command2.ExecuteScalar().ToString();
            con.Close();
            if (_PATH=="")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select FileData From Comment WHERE (Label_Comment = @Label_Comment)";
                cmd.Parameters.AddWithValue("@Label_Comment", cbox_selection_comment.Text);
                byte[] _binaryData = (byte[])cmd.ExecuteScalar();


                _path = "D:\\ProjectMH/DONE/thuctap/TRACNGHIEMBYWINFORM/ANOTHERFILEINPUT/DETHI/FILEDETHIOUTPUT/Output.pdf";

                File.WriteAllBytes(_path, _binaryData);
                string s = Encoding.UTF8.GetString(_binaryData);

                con.Close();
            }
           else
            {
                _path = _PATH;
            }

          
            axAcroPDF1.src = _path;


        

        }
        void _Refresh()
        {
        //    con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Note where  MSV='" + Form_Begin.usernamestatic + "' and Label_Comment= N'" + cbox_selection_comment.Text + "' and Checked='true'  ORDER BY  LEN(Cau) , Cau ASC ", con);
            DataTable dtbl = new DataTable();

          

            sqlDa.Fill(dtbl);
       
            dataGridView1.DataSource = dtbl;
        
      

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Checked"].Visible = false;
            dataGridView1.Columns["Label_Comment"].Visible = false;
            dataGridView1.Columns["MSV"].Visible = false;
            dataGridView1.Columns["_Day"].Visible = false;
            dataGridView1.Columns["Date"].Visible = false;
            dataGridView1.Columns["MonThi"].Visible = false;
            dataGridView1.Columns["_Count"].Visible = false;

          
        }

        void fectch_data_panel()
        {
            try
            {
                con.Open();
                string sqlquery2 = ("SELECT TOP 1 Date  FROM Note where  MSV='" + Form_Begin.usernamestatic + "' and Label_Comment= N'" + cbox_selection_comment.Text + "'");
                SqlCommand command2 = new SqlCommand(sqlquery2, con);
                tbox_date.Text = command2.ExecuteScalar().ToString();
                con.Close();

                con.Open();
                string sqlquery3 = ("SELECT TOP 1 MonThi  FROM Note where  MSV='" + Form_Begin.usernamestatic + "'and Label_Comment= N'" + cbox_selection_comment.Text + "'");
                SqlCommand command3 = new SqlCommand(sqlquery3, con);
                tbox_monthi.Text = command3.ExecuteScalar().ToString();
                con.Close();

                con.Open();
                string sqlquery4 = ("SELECT TOP 1 MaDT  FROM Note where  MSV='" + Form_Begin.usernamestatic + "' and Label_Comment= N'" + cbox_selection_comment.Text + "'");
                SqlCommand command4 = new SqlCommand(sqlquery4, con);
                tbox_made.Text = command4.ExecuteScalar().ToString();
                con.Close();
            }
            catch
            {
                tbox_date.Text = DateTime.UtcNow.ToString();
                tbox_monthi.Text = "";
                tbox_made.Text = "";
            }
        }

        public static string transpath="";
        public static string transpathexcel = "";
        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            transpathexcel="";
            /* Form_retest_Exporting n = new Form_retest_Exporting();
             n.Show();*/

           

            con.Open();
            string sqlquery4 = ("SELECT FilePathPDF   FROM Comment where  MSV='" + Form_Begin.usernamestatic + "' and Label_Comment= N'" + cbox_selection_comment.Text + "'");
            SqlCommand command4 = new SqlCommand(sqlquery4, con);
            transpath = command4.ExecuteScalar().ToString();
            con.Close();


            con.Open();
            string sqlquery5 = ("SELECT FileExcel  FROM Comment where  MSV='" + Form_Begin.usernamestatic + "' and Label_Comment= N'" + cbox_selection_comment.Text + "'");
            SqlCommand command5 = new SqlCommand(sqlquery5, con);
            transpathexcel = command5.ExecuteScalar().ToString();
            con.Close();

            if (transpath =="")
            {
                MessageBox.Show("File does not exist ");
            }
            else
            {
                Form_Test n = new Form_Test();
                n.Show();
                n.sharepdf();

            

                Form_import_Answer n2 = new Form_import_Answer();
                n2.Ena();
                n2.ShowDialog();
            }


              ((Form)this.TopLevelControl).Close();
          
            _instance = new UC_Note();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (cbox_selection_comment.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand sqlDa2 = new SqlCommand("DELETE FROM Comment where Label_Comment= '" + cbox_selection_comment.Text + "'", con);
                    sqlDa2.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    SqlCommand sqlDa3 = new SqlCommand("DELETE FROM Note where Label_Comment= '" + cbox_selection_comment.Text + "'", con);
                    sqlDa3.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Deleted");

                    tbox_note.Clear();

                    UC_Note_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Choose comment you want to delete !");
                }
            }
            else
                MessageBox.Show("Choose comment you want to delete !");

        }

        private void btn_fresh_Click(object sender, EventArgs e)
        {
            Binddata();
        }

        public static void Find(RichTextBox rtb, String word, Color color)
        {
            if (word == "")
            {
                return;
            }
            int s_start = rtb.SelectionStart, startIndex = 0, index;
            while ((index = rtb.Text.IndexOf(word, startIndex)) != -1)
            {
                rtb.Select(index, word.Length);
                rtb.SelectionColor = color;
                startIndex = index + word.Length;
            }
            rtb.SelectionStart = 0;
            rtb.SelectionLength = rtb.TextLength;
            rtb.SelectionColor = Color.Black;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

              string _question = dataGridView1.CurrentRow.Cells[3].Value.ToString() ;
            axAcroPDF1.Focus();

            SendKeys.Send("^f");

      
            SendKeys.Send(_question+ ":");
            SendKeys.Send("^G");
           
        }

        private void rtb_content_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
          

        }

        private void lbl_cau_Click(object sender, EventArgs e)
        {

        
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
          
        }

        private void axAcroPDF1_Enter_1(object sender, EventArgs e)
        {
           /// axAcroPDF1.LoadFile(@"C:\Users\super\Desktop\THPTQUOCGIA2020_401.pdf");
        }

        private void axAcroPDF1_Enter_2(object sender, EventArgs e)
        {
            //   axAcroPDF1.src = @"C:\Users\super\Desktop\THPTQUOCGIA2020_401.pdf";

         

        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel4.Size = new Size(273, 510);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
        //    panel4.Size = new Size(10, 510);
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroToggle1.Checked==true)
            {
                panel4.Visible = true;
                panel4.Size = new Size(250, 510);
                metroToggle2.Checked = true;
              
            }
            else
            {
              
            }
            metroToggle1.Checked = false;
        //    btn_lamlai.Visible = false;
        //    btn_close.Visible = false;
        }

        private void metroToggle2_CheckedChanged(object sender, EventArgs e)
        {
          
            if (metroToggle2.Checked == true)
            {
            
            }
            if (metroToggle2.Checked == false)
            {
                panel4.Visible = false;
                panel4.Size = new Size(10, 510);

               
                //panel_tools.Visible = false;
          //      btn_lamlai.Visible = true;
             //   btn_close.Visible = true;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbox_note_MouseHover(object sender, EventArgs e)
        {
            tbox_note.ReadOnly = true;
        }
    }
}
