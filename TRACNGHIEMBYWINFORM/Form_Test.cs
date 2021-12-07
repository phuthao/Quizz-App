
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Threading;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_Test : MetroFramework.Forms.MetroForm
    {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
       

        public string luachon;
        private int socaudung;
        public int soCauDung { get { return socaudung; } }
        public int socausai;

        public static string time;
        /// // time countdown
        System.Timers.Timer t;
        int h, m, s;
        public bool status_time;
        /// <summary>

        public static string pdfoutput;
        public static int countpdf;

        /// <summary>
        ///  ĐẾM SỐ LẦN THI
        /// </summary>
        public static string MASINHVIEN_formtest;


        /// <summary>
        /// / so cau 
        /// </summary>
        public static string TOTAL;
        public Form_Test()
        {
            InitializeComponent();
        }
        // list cau 
        List<Panel> ts = new List<Panel>();
        void Addpanel_tolist()
        {
           
            ts.Add(panel_cau1);
            ts.Add(panel_cau2);
            ts.Add(panel_cau3);
            ts.Add(panel_cau4);
            ts.Add(panel_cau5);
            ts.Add(panel_cau6);
            ts.Add(panel_cau7);
            ts.Add(panel_cau8);
            ts.Add(panel_cau9);
            ts.Add(panel_cau10);
            ts.Add(panel_cau11);
            ts.Add(panel_cau12);
            ts.Add(panel_cau13);
            ts.Add(panel_cau14);
            ts.Add(panel_cau15);
            ts.Add(panel_cau16);
            ts.Add(panel_cau17);
            ts.Add(panel_cau18);
            ts.Add(panel_cau19);
            ts.Add(panel_cau20);
            ts.Add(panel_cau21);
            ts.Add(panel_cau22);
            ts.Add(panel_cau23);
            ts.Add(panel_cau24);
            ts.Add(panel_cau25);
            ts.Add(panel_cau26);
            ts.Add(panel_cau27);
            ts.Add(panel_cau28);
            ts.Add(panel_cau29);
            ts.Add(panel_cau30);
            ts.Add(panel_cau31);
            ts.Add(panel_cau32);
            ts.Add(panel_cau33);
            ts.Add(panel_cau34);
            ts.Add(panel_cau35);
            ts.Add(panel_cau36);
            ts.Add(panel_cau37);
            ts.Add(panel_cau38);
            ts.Add(panel_cau39);
            ts.Add(panel_cau40);
            ts.Add(panel_cau41);
            ts.Add(panel_cau42);
            ts.Add(panel_cau43);
            ts.Add(panel_cau44);
            ts.Add(panel_cau45);
            ts.Add(panel_cau46);
            ts.Add(panel_cau47);
            ts.Add(panel_cau48);
            ts.Add(panel_cau49);
            ts.Add(panel_cau50);
            ts.Add(panel_cau51);
            ts.Add(panel_cau52);
            ts.Add(panel_cau53);
            ts.Add(panel_cau54);
            ts.Add(panel_cau55);
            ts.Add(panel_cau56);
            ts.Add(panel_cau57);
            ts.Add(panel_cau58);
            ts.Add(panel_cau59);
            ts.Add(panel_cau60);
        }
        //
        string number_Count;
        public void Limit_socau()
        {
            Addpanel_tolist();

            con.Open();

            string sqlquery2 = ("SELECT COUNT(*)  FROM DETHI ");
            SqlCommand command2 = new SqlCommand(sqlquery2, con);
              number_Count = command2.ExecuteScalar().ToString();

            for(int i=0;i<Convert.ToInt32(number_Count);i++)
            {
                
                ts[i].Enabled = true;
            }
            con.Close();
        }

       



        private void formtest_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            this.WindowState = FormWindowState.Maximized;
            //   tbox_MSVSTATIC.Text = START.MSV;
            tbox_MSVSTATIC.Text = Form_Begin.usernamestatic;
            MASINHVIEN_formtest = tbox_MSVSTATIC.Text;
            //  featchdata();
            //    resetPanel1();
            expandPanel1();
            resetPanel2();
            resetPanel3();

            // load color 
            {
                tbox_time.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_start.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                 btn_stop.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                 btn_help.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_dethi.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
               btn_import.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
               btn_nopbai.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_close.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            }

            try
            {
                tbox_time.Text = Form_list_PDF._timecountdown;
                h = Convert.ToInt32(Form_list_PDF._timecountdown.Substring(0, 2));
                m = Convert.ToInt32(Form_list_PDF._timecountdown.Substring(3, 2));
                s = Convert.ToInt32(Form_list_PDF._timecountdown.Substring(6, 2));

                /// timme load 
                t = new System.Timers.Timer();
                t.Interval = 1000;//1s

                t.Elapsed += OnTimeEvent;
                t.Start();
                status_time = true;
            }
            catch
            {
                t = new System.Timers.Timer();
                t.Interval = 1000;
                t.Elapsed += OnTimeEvent_default;
                t.Start();
                status_time = false;
            }

            lbl_time_countdown.Text = tbox_time.Text;


            con.Open();
            string query_hts = "SELECT Checked_Howtouse from login where MSV=@MSV";
            SqlCommand _sql_howtouse = new SqlCommand(query_hts, con);
            _sql_howtouse.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);
            string result_hts = _sql_howtouse.ExecuteScalar().ToString();
            con.Close();


            if (result_hts=="")
            {
                Form_HowToUse n = new Form_HowToUse();
                n.ShowDialog();
            }
            else
            {
                Form_HowToUse n = new Form_HowToUse();
              //  n.Close();
            }

            ///
         





        }
        public void DemLT()
        {
            try
            {
                //   demsolanthi++;
                con.Open();

                string sqlquery2 = ("SELECT TOP 1 STT FROM PHIEUKETQUA order by STT DESC");
                SqlCommand command2 = new SqlCommand(sqlquery2, con);
                lbl_stt.Text = command2.ExecuteScalar().ToString();
                con.Close();



                con.Open();
                string sqlquery3 = ("SELECT TOP 1 Solanthi FROM PHIEUKETQUA where  MSV='" + Form_Begin.usernamestatic + "' and MaDT='"+lbl_madt.Text+"'  order by Solanthi DESC");
                SqlCommand command3 = new SqlCommand(sqlquery3, con);
              //  lbl_slanthi.Text = command3.ExecuteScalar().ToString();
               

                

                int   a = Convert.ToInt32(command3.ExecuteScalar());
                  int  resultadd = a + 1;
               

                

                SqlDataAdapter da = new SqlDataAdapter(" UPDATE PHIEUKETQUA SET Solanthi='" + resultadd + "' where MSV ='" + Form_Begin.usernamestatic + "' and STT='" + lbl_stt.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*if (dt.Rows.Count >= 0)
            {


                KETQUA kq = new KETQUA();
                kq.Show();
            }*/
        }
        private void OnTimeEvent_default(object sender, System.Timers.ElapsedEventArgs e)
        {

            Invoke(new Action(() =>
                {
                  
                    s += 1;

                    if (s == 60)
                    {

                        s = 0;
                        m += 1;

                    }

                    if (m == 60)
                    {
                        //  m=0;


                        h += 1;
                        m = 0;


                    }
                    //Update textbox
                    tbox_time.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                }));
        }
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
            
              s -= 1;
             if (s < 0)
              {
                    s = 59;
              }
                if (s == 00)
            {
                if (m > 0)
                {
                    s = 60;
                    m -= 1;
                }
                else
                {
                    t.Stop();
                }
            }
           
                if (m == 00)
                {
                    //  m=0;

                    if (h > 0)
                    {
                        h -= 1;
                        m = 59;
                    }
                    if (h == 0 && m == 0 && s == 0)
                    {
                        btn_nopbai_Click(sender, e);
                    }
                }
                //Update textbox
                tbox_time.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop timer
            t.Stop();
            Application.DoEvents();
        }
        private void expandPanel1()
        {
            panel1.Height = 615;
            panel1.Width = 351;

          //  Limit_socau();

        }
        private void expandPanel2()
        {
            /* panel1.Height = 0;
             panel1.Width = 0;*/

            panel28.Height = 615;
            panel28.Width = 351;
            Limit_socau();
        }

        private void expandPanel3()
        {

            panel55.Height = 615;
            panel55.Width = 351;
            Limit_socau();
        }
        private void resetPanel1()
        {
            panel1.Height = 0;
            panel1.Width = 0;
        }
        private void resetPanel2()
        {
            panel28.Height = 0;
            panel28.Width = 0;
        }
        private void resetPanel3()
        {
            panel55.Height = 0;
            panel55.Width = 0;
        }

        public static string _retestPDF;
        public void sharepdf()
        {
            countpdf = 1;
            if (UC_Note.transpath !="")
            {
                _retestPDF = UC_Note.transpath;
                axAcroPDF1.src = _retestPDF;
               
            }
            else
            {
                _retestPDF = "D:/ProjectMH/DONE/thuctap/TRACNGHIEMBYWINFORM/ANOTHERFILEINPUT/DETHI/FILEDETHIOUTPUT/Output.pdf";
                axAcroPDF1.src = _retestPDF;
            }
            //   pdfoutput = axAcroPDF1.src;
        }

       public string _getpath= "D:/ProjectMH/DONE/thuctap/TRACNGHIEMBYWINFORM/ANOTHERFILEINPUT/DETHI/FILEDETHIOUTPUT/Output.pdf";
        public void openPDFfile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.src = ofd.FileName;
                    _getpath = ofd.FileName;
                    t.Start();
                  
                }
            }
        }
        /// DE THI BUTTON START 
        /// 
        /// CONVERT IMAGE 
        public void ConvertImageToPdf(string srcFilename, string dstFilename)
        {
            iTextSharp.text.Rectangle pageSize = null;

            using (var srcImage = new Bitmap(srcFilename))
            {
                pageSize = new iTextSharp.text.Rectangle(0, 0, srcImage.Width, srcImage.Height);
            }
            using (var ms = new MemoryStream())
            {
                var document = new iTextSharp.text.Document(pageSize, 0, 0, 0, 0);
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, ms).SetFullCompression();
                document.Open();
                var image = iTextSharp.text.Image.GetInstance(srcFilename);
                document.Add(image);
                document.Close();

                File.WriteAllBytes(dstFilename, ms.ToArray());
            }
        }
        void ConvertImage()
        {
            // delete file 
     
            int countconvert = 0;
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                ConvertImageToPdf(openFileDialog1.FileName, @"D:\ProjectMH\DONE\thuctap\TRACNGHIEMBYWINFORM\ANOTHERFILEINPUT\DETHI\FILEDETHI_IMAGE\fileconvert\outputimage.pdf");
                countconvert = 1;
                string path = @"D:\ProjectMH\DONE\thuctap\TRACNGHIEMBYWINFORM\ANOTHERFILEINPUT\DETHI\FILEDETHI_IMAGE\fileconvert\outputimage.pdf";

                if (countconvert == 1)
                {
                    axAcroPDF1.LoadFile(path);
                    _getpath = path;
                }

                else
                {
                    MessageBox.Show("Convert hasn't complete !!!");
                }
                //LoadDocument();
            }
            else
            {
             //   this.Close();
            }
        }

        /// CONVERT IMAGE END 
        /// CONVERT WORD START
        ///    public void openPDFfile()
     

        public void ConvertWord()
        {
            /* axAcroPDF1.LoadFile("");*/
     //        int count = 0;
             
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.docx)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
         
            string PATH_APP_PDF = @"D:\ProjectMH\DONE\thuctap\TRACNGHIEMBYWINFORM\ANOTHERFILEINPUT\DETHI\FILEDETHI_WORD\output.pdf";

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                /*     string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true       */


                object misValue = System.Reflection.Missing.Value;
              

                var WORD = new Word.Application();



                Word.Document doc = WORD.Documents.Open(sFileName);
                /*     WORD.Documents.Open(@"D:\ProjectMH\DONE\thuctap\TRACNGHIEMBYWINFORM\ANOTHERFILEINPUT\DETHI\FILEDETHI_WORD");*/
                /* count = 1;*/
                doc.Activate();
                 
                doc.SaveAs2(@PATH_APP_PDF, Word.WdSaveFormat.wdFormatPDF, misValue, misValue, misValue,
                misValue, misValue, misValue, misValue, misValue, misValue, misValue);
      //          count++;

                doc.Close();
                WORD.Quit();

            }
          

                {
                axAcroPDF1.src = PATH_APP_PDF;
                _getpath = PATH_APP_PDF;
                }


            


       
        }

        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();



        private void button2_Click(object sender, EventArgs e)
        {
            //      axAcroPDF1.src = FileName("");
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add("PDF");
            contextMenuStrip1.Items.Add("WORD");
            contextMenuStrip1.Items.Add("IMAGE");

            contextMenuStrip1.Show(btn_dethi, new Point(0, btn_dethi.Height));

            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip1_ItemClicked);
        }
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Text == "PDF")
                {
                    //   contextMenuStrip1.Visible = false;
                    openPDFfile();
                }
         
            if (e.ClickedItem.Text =="IMAGE")
            {
                ConvertImage();
                   
            }
            if(e.ClickedItem.Text=="WORD")
            {
                //Load Document  
                ConvertWord();
            }
            }

            catch
            {
                MessageBox.Show("Please choose the correct format ");
            }
        }

        /// DE THI BUTTON END 
        private void panel1_Click(object sender, PaintEventArgs e)
        {

        }



        private void label27_Click(object sender, EventArgs e)
        {
            resetPanel2();
            resetPanel3();
            expandPanel1();
        }

        private void label27_DoubleClick(object sender, EventArgs e)
        {
            resetPanel1();
        }



        private void panel28_Click(object sender, EventArgs e)
        {

        }

        private void panel28_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {
            resetPanel1();
            resetPanel3();
            expandPanel2();
        }
        private void label56_DoubleClick(object sender, EventArgs e)
        {
            resetPanel2();
        }

        private void panel55_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {
            resetPanel1();
            resetPanel2();
            ///
            expandPanel3();
        }
        private void label57_DoubleClick(object sender, EventArgs e)
        {
            resetPanel3();
        }

        private void clear()
        {
          
        }
        void addMSVnew()
        {
            int solanthi = 0;
            SqlDataAdapter da1 = new SqlDataAdapter("INSERT INTO PHIEUKETQUA(MSV,Solanthi) VALUES('" + Form_Begin.usernamestatic + "','"+solanthi+"')", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
        }

        public static string _pathh="";

        private void btn_nopbai_Click(object sender, EventArgs e)
        {

            try
            {
                addMSVnew();

                t.Stop();

                featchdata();

                _pathh = Path.GetFullPath(_getpath);




                if (rbtn_1A.Checked || rbtn_1B.Checked || rbtn_1C.Checked || rbtn_1D.Checked)
                {
                    if (rbtn_1A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_1B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_1C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_1D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                       

                   

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=1 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                   
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;
                       
                        //connection.Close();
                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    //get DapAn

                    //  con.Open();
                    check_DapAn_1();
                  

                }
                ///// cau 2
                if (rbtn_2A.Checked || rbtn_2B.Checked || rbtn_2C.Checked || rbtn_2D.Checked)
                {
                    if (rbtn_2A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_2B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_2C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_2D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //   con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=2 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_2();
                }
                //// cau3
                if (rbtn_3A.Checked || rbtn_3B.Checked || rbtn_3C.Checked || rbtn_3D.Checked)
                {
                    if (rbtn_3A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_3B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_3C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_3D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //       con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=3 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_3();

                }
                ////// cau4
                if (rbtn_4A.Checked || rbtn_4B.Checked || rbtn_4C.Checked || rbtn_4D.Checked)
                {
                    if (rbtn_4A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_4B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_4C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_4D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=4 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_4();

                }
                ///// cau5
                if (rbtn_5A.Checked || rbtn_5B.Checked || rbtn_5C.Checked || rbtn_5D.Checked)
                {
                    if (rbtn_5A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_5B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_5C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_5D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //       con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=5 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    ///////// cau6
                    check_DapAn_5();

                }
                if (rbtn_6A.Checked || rbtn_6B.Checked || rbtn_6C.Checked || rbtn_6D.Checked)
                {
                    if (rbtn_6A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_6B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_6C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_6D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //  con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=6 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_6();
                    //////// cau7

                }
                if (rbtn_7A.Checked || rbtn_7B.Checked || rbtn_7C.Checked || rbtn_7D.Checked)
                {
                    if (rbtn_7A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_7B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_7C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_7D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //      con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=7 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_7();
                    //////// cau8
                }
                if (rbtn_8A.Checked || rbtn_8B.Checked || rbtn_8C.Checked || rbtn_8D.Checked)
                {
                    if (rbtn_8A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_8B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_8C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_8D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //      con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=8 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_8();
                    /////// cau9
                }
                if (rbtn_9A.Checked || rbtn_9B.Checked || rbtn_9C.Checked || rbtn_9D.Checked)
                {
                    if (rbtn_9A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_9B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_9C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_9D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //        con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=9 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_9();

                }
                if (rbtn_10A.Checked || rbtn_10B.Checked || rbtn_10C.Checked || rbtn_10D.Checked)
                {
                    if (rbtn_10A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_10B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_10C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_10D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=10 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_10();

                    //11



                }
                if (rbtn_11A.Checked || rbtn_11B.Checked || rbtn_11C.Checked || rbtn_11D.Checked)
                {
                    if (rbtn_11A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_11B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_11C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_11D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=11 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_11();
                }
                // 12 
                if (rbtn_12A.Checked || rbtn_12B.Checked || rbtn_12C.Checked || rbtn_12D.Checked)
                {
                    if (rbtn_12A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_12B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_12C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_12D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=12 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_12();

                    ////////// 11 - 20



                }
                //13
                if (rbtn_13A.Checked || rbtn_13B.Checked || rbtn_13C.Checked || rbtn_13D.Checked)
                {
                    if (rbtn_13A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_13B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_13C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_13D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=13 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_13();

                    ////////// 11 - 20



                }
                // 14
                if (rbtn_14A.Checked || rbtn_14B.Checked || rbtn_14C.Checked || rbtn_14D.Checked)
                {
                    if (rbtn_14A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_14B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_14C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_14D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=14 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_14();

                    ////////// 11 - 20



                }
                //15
                if (rbtn_15A.Checked || rbtn_15B.Checked || rbtn_15C.Checked || rbtn_15D.Checked)
                {
                    if (rbtn_15A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_15B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_15C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_15D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=15 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_15();

                    ////////// 11 - 20



                }
                //16
                if (rbtn_16A.Checked || rbtn_16B.Checked || rbtn_16C.Checked || rbtn_16D.Checked)
                {
                    if (rbtn_16A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_16B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_16C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_16D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=16 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_16();

                    ////////// 11 - 20



                }
                //17
                if (rbtn_17A.Checked || rbtn_17B.Checked || rbtn_17C.Checked || rbtn_17D.Checked)
                {
                    if (rbtn_17A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_17B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_17C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_17D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=17 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_17();


                    ////////// 11 - 20



                }
                //18
                if (rbtn_18A.Checked || rbtn_18B.Checked || rbtn_18C.Checked || rbtn_18D.Checked)
                {
                    if (rbtn_18A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_18B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_18C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_18D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=18 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }


                    check_DapAn_18();
                    ////////// 11 - 20



                }
                //19
                if (rbtn_19A.Checked || rbtn_19B.Checked || rbtn_19C.Checked || rbtn_19D.Checked)
                {
                    if (rbtn_19A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_19B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_19C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_19D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=19 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_19();

                    ////////// 11 - 20



                }
                //20
                if (rbtn_20A.Checked || rbtn_20B.Checked || rbtn_20C.Checked || rbtn_20D.Checked)
                {
                    if (rbtn_20A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_20B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_20C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_20D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=20 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_20();


                    ////////// 11 - 20

                    //21

                }
                if (rbtn_21A.Checked || rbnt_21B.Checked || rbnt_21C.Checked || rbnt_21D.Checked)
                {
                    if (rbtn_21A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_21B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_21C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_21D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=21 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_21();
                }
                ///// cau 22
                if (rbnt_22A.Checked || rbnt_22B.Checked || rbnt_22C.Checked || rbnt_22D.Checked)
                {
                    if (rbnt_22A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_22B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_22C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_22D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //   con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=22 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_22();
                }
                //// cau23
                if (rbnt_23A.Checked || rbnt_23B.Checked || rbnt_23C.Checked || rbnt_23D.Checked)
                {
                    if (rbnt_23A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_23B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_23C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_23D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //       con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=23 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_23();

                }
                ////// cau24
                if (rbnt_24A.Checked || rbnt_24B.Checked || rbnt_24C.Checked || rbnt_24D.Checked)
                {
                    if (rbnt_24A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_24B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_24C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_24D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=24 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_24();
                }
                ///// cau25
                if (rbnt_25A.Checked || rbnt_25B.Checked || rbnt_25C.Checked || rbnt_25D.Checked)
                {
                    if (rbnt_25A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_25B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_25C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_25D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //       con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=25 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_25();
                    ///////// cau26

                }
                if (rbnt_26A.Checked || rbnt_26B.Checked || rbnt_26C.Checked || rbnt_26D.Checked)
                {
                    if (rbnt_26A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_26B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_26C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_26D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //  con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=26 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_26();
                    //////// cau27

                }
                if (rbnt_27A.Checked || rbnt_27B.Checked || rbnt_27C.Checked || rbnt_27D.Checked)
                {
                    if (rbnt_27A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_27B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_27C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_27D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //      con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=27 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_27();
                    //////// cau28
                }
                if (rbnt_28A.Checked || rbnt_28B.Checked || rbnt_28C.Checked || rbnt_28D.Checked)
                {
                    if (rbnt_28A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_28B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_28C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_28D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //      con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=28 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_28();
                    /////// cau29
                }
                if (rbnt_29A.Checked || rbnt_29B.Checked || rbnt_29C.Checked || rbnt_29D.Checked)
                {
                    if (rbnt_29A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_29B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_29C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_29D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //        con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=29 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_29();
                    // 30
                }
                if (rbnt_30A.Checked || rbnt_30B.Checked || rbnt_30C.Checked || rbnt_30C.Checked)
                {
                    if (rbnt_30A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_30B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_30C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_30D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=30 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_30();

                    //31



                }
                if (rbnt_31A.Checked || rbnt_31B.Checked || rbnt_31C.Checked || rbnt_31D.Checked)
                {
                    if (rbnt_31A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_31B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_31C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_31D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=31 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_31();
                }
                // 12 
                if (rbnt_32A.Checked || rbnt_32B.Checked || rbnt_32C.Checked || rbnt_32D.Checked)
                {
                    if (rbnt_32A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_32B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_32C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_32D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=32 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_32();


                    ////////// 11 - 20



                }
                //33
                if (rbnt_33A.Checked || rbnt_33B.Checked || rbnt_33C.Checked || rbnt_33D.Checked)
                {
                    if (rbnt_33A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_33B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_33C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_33D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=33 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_33();

                    ////////// 11 - 20



                }
                // 14
                if (rbnt_34A.Checked || rbnt_34B.Checked || rbnt_34C.Checked || rbnt_34D.Checked)
                {
                    if (rbnt_34A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_34B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_34C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_34D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=34 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_34();

                    ////////// 11 - 20



                }
                //35
                if (rbnt_35A.Checked || rbnt_35B.Checked || rbnt_35C.Checked || rbnt_35D.Checked)
                {
                    if (rbnt_35A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_35B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_35C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_35D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=35 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_35();


                    ////////// 11 - 20



                }
                //36
                if (rbnt_36A.Checked || rbnt_36B.Checked || rbnt_36C.Checked || rbnt_36D.Checked)
                {
                    if (rbnt_36A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_36B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_36C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_36D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=36 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_36();

                    ////////// 11 - 20



                }
                //17
                if (rbnt_37A.Checked || rbnt_37B.Checked || rbnt_37C.Checked || rbnt_37D.Checked)
                {
                    if (rbnt_37A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_37B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_37C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_37D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=37 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }


                    check_DapAn_37();
                    ////////// 11 - 20



                }
                //18
                if (rbnt_38A.Checked || rbnt_38B.Checked || rbnt_38C.Checked || rbnt_38D.Checked)
                {
                    if (rbnt_38A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_38B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_38C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_38D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=38 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }



                    ////////// 11 - 20

                    check_DapAn_38();

                }
                //39
                if (rbnt_39A.Checked || rbnt_39B.Checked || rbnt_39C.Checked || rbnt_39D.Checked)
                {
                    if (rbnt_39A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_39B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_39C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_39D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=39 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }


                    check_DapAn_39();
                    ////////// 11 - 20



                }
                //40
                if (rbnt_40A.Checked || rbnt_40B.Checked || rbnt_40C.Checked || rbnt_40D.Checked)
                {
                    if (rbnt_40A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbnt_40B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbnt_40C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbnt_40D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=40 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_40();
                }
                // 41 - 60

                if (rbtn_41A.Checked || rbtn_41B.Checked || rbtn_41C.Checked || rbtn_41D.Checked)
                {
                    if (rbtn_41A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_41B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_41C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_41D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=41 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_41();

                }
                ///// cau 2
                if (rbtn_42A.Checked || rbtn_42B.Checked || rbtn_42C.Checked || rbtn_42D.Checked)
                {
                    if (rbtn_42A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_42B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_42C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_42D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //   con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=42 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_42();

                }
                //// cau3
                if (rbtn_43A.Checked || rbtn_43B.Checked || rbtn_43C.Checked || rbtn_43D.Checked)
                {
                    if (rbtn_43A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_43B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_43C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_43D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //       con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=43 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_43();

                }
                ////// cau4
                if (rbtn_44A.Checked || rbtn_44B.Checked || rbtn_44C.Checked || rbtn_44D.Checked)
                {
                    if (rbtn_44A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_44B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_44C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_44D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=44 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_44();

                }
                ///// cau5
                if (rbtn_45A.Checked || rbtn_45B.Checked || rbtn_45C.Checked || rbtn_45D.Checked)
                {
                    if (rbtn_45A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_45B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_45C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_45D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //       con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=45 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_45();
                    ///////// cau6

                }
                if (rbtn_46A.Checked || rbtn_46B.Checked || rbtn_46C.Checked || rbtn_46D.Checked)
                {
                    if (rbtn_46A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_46B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_46C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_46D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //  con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=46 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_46();
                    //////// cau7

                }
                if (rbtn_47A.Checked || rbtn_47B.Checked || rbtn_47C.Checked || rbtn_47D.Checked)
                {
                    if (rbtn_47A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_47B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_47C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_47D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //      con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=47 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_47();
                    //////// cau8
                }
                if (rbtn_48A.Checked || rbtn_48B.Checked || rbtn_48C.Checked || rbtn_48D.Checked)
                {
                    if (rbtn_48A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_48B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_48C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_48D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //      con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=48 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_48();

                    /////// cau9
                }
                if (rbtn_49A.Checked || rbtn_49B.Checked || rbtn_49C.Checked || rbtn_49D.Checked)
                {
                    if (rbtn_49A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_49B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_49C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_49D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //        con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=49 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_49();

                }
                if (rbtn_50A.Checked || rbtn_50B.Checked || rbtn_50C.Checked || rbtn_50D.Checked)
                {
                    if (rbtn_50A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_50B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_50C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_50D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=50 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }



                    //11
                    check_DapAn_50();


                }
                if (rbtn_51A.Checked || rbtn_51B.Checked || rbtn_51C.Checked || rbtn_51D.Checked)
                {
                    if (rbtn_51A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_51B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_51C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_51D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=51 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_51();
                }
                // 12 
                if (rbtn_52A.Checked || rbtn_52B.Checked || rbtn_52C.Checked || rbtn_52D.Checked)
                {
                    if (rbtn_52A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_52B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_52C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_52D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=52 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_52();


                    ////////// 11 - 20



                }
                //13
                if (rbtn_53A.Checked || rbtn_53B.Checked || rbtn_53C.Checked || rbtn_53D.Checked)
                {
                    if (rbtn_53A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_53B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_53C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_53D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=53 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_53();

                    ////////// 11 - 20



                }
                // 14
                if (rbtn_54A.Checked || rbtn_54B.Checked || rbtn_54C.Checked || rbtn_54D.Checked)
                {
                    if (rbtn_54A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_54B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_54C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_54D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=54 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_54();


                    ////////// 11 - 20



                }
                //15
                if (rbtn_55A.Checked || rbtn_55B.Checked || rbtn_55C.Checked || rbtn_55D.Checked)
                {
                    if (rbtn_55A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_55B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_55C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_55D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=55 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_55();

                    ////////// 11 - 20



                }
                //16
                if (rbtn_56A.Checked || rbtn_56B.Checked || rbtn_56C.Checked || rbtn_56D.Checked)
                {
                    if (rbtn_56A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_56B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_56C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_56D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=56 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_56();

                    ////////// 11 - 20



                }
                //17
                if (rbtn_57A.Checked || rbtn_57B.Checked || rbtn_57C.Checked || rbtn_57D.Checked)
                {
                    if (rbtn_57A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_57B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_57C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_57D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=57 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_57();


                    ////////// 11 - 20



                }
                //18
                if (rbtn_58A.Checked || rbtn_58B.Checked || rbtn_58C.Checked || rbtn_58D.Checked)
                {
                    if (rbtn_58A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_58B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_58C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_58D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=58 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }


                    check_DapAn_58();
                    ////////// 11 - 20



                }
                //19
                if (rbtn_59A.Checked || rbtn_59B.Checked || rbtn_59C.Checked || rbtn_59D.Checked)
                {
                    if (rbtn_59A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_59B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_59C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_59D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=59 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }

                    check_DapAn_59();

                    ////////// 11 - 20



                }
                //20
                if (rbtn_60A.Checked || rbtn_60B.Checked || rbtn_60C.Checked || rbtn_60D.Checked)
                {
                    if (rbtn_60A.Checked)
                    {
                        luachon = "A";
                        clear();
                    }
                    if (rbtn_60B.Checked)
                    {
                        luachon = "B";
                        clear();
                    }
                    if (rbtn_60C.Checked)
                    {
                        luachon = "C";
                        clear();
                    }
                    if (rbtn_60D.Checked)
                    {
                        luachon = "D";
                        clear();
                    }
                    //    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ANSWER from DETHI where NUMBER=60 and ANSWER ='" + luachon + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        socaudung++;

                    }
                    if (dt.Rows.Count == 0)
                    {

                        socausai++;

                    }
                    check_DapAn_60();
                }

                if (status_time == true)
                {
                    time = lbl_time_countdown.Text;
                    lbl_timecomplete.Text = lbl_time_countdown.Text;
                }
                if (status_time == false)
                {
                    time = tbox_time.Text;
                    lbl_timecomplete.Text = tbox_time.Text;
                }



                addthongtinconlai();

                this.Close();



                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please import your answer file .xlsx ! "+ ex.Message);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_import_Answer n = new Form_import_Answer();
        
            n.Show();
           
            
            
        
        }
        public static string date = DateTime.UtcNow.ToString("M/d/yyyy");
        void addthongtinconlai()
        {
            SqlDataAdapter da = new SqlDataAdapter(" UPDATE PHIEUKETQUA SET Date ='" + date + "', socaudung = '" + socaudung + "', socausai = '" + socausai + "', timetocomplete = '" + time + "',Name='" + lbl_NAME.Text + "',phone='" + lbl_phone.Text + "',dayofbirth='" + lbl_dob.Text + "',MonTHI=N'" + lbl_monthi.Text + "',MaDT='" + lbl_madt.Text + "' where MSV ='" + Form_Begin.usernamestatic + "'and STT ='" + lbl_stt.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 0)
            {


                Form_Score kq = new Form_Score();
                kq.Show();



            }

        }

        private void pdf_Click(object sender, EventArgs e)
        {
            openPDFfile();
        }

        /// convert IMAGE TO PDF 
        /// 
      
    private void image_Click(object sender, EventArgs e)
        {
          
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        void featchdata()
        {
            using (SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True"))
            {
                connection.Open();
                // Perform the operations here
                string sqlquery = ("SELECT Name  FROM login where MSV='" + tbox_MSVSTATIC.Text + "'");
                SqlCommand command = new SqlCommand(sqlquery, connection);
                lbl_NAME.Text = command.ExecuteScalar().ToString();
                connection.Close();
                //// so cau sai 
                ///
                connection.Open();
                string sqlquery2 = ("SELECT phone  FROM login where  MSV='" + tbox_MSVSTATIC.Text + "'");
                SqlCommand command2 = new SqlCommand(sqlquery2, connection);
                lbl_phone.Text = command2.ExecuteScalar().ToString();
                connection.Close();


                //// time to complete
                connection.Open();
                string sqlquery3 = ("SELECT dayofbirth  FROM login where  MSV='" + tbox_MSVSTATIC.Text + "'");
                SqlCommand command3 = new SqlCommand(sqlquery3, connection);
                lbl_dob.Text = command3.ExecuteScalar().ToString();
                connection.Close();

                connection.Open();
                string sqlquery4 = ("SELECT distinct CODE  FROM DETHI ");
                SqlCommand command4 = new SqlCommand(sqlquery4, connection);
                lbl_madt.Text = command4.ExecuteScalar().ToString();
                connection.Close();

                connection.Open();
                string sqlquery5 = ("SELECT distinct TOPIC  FROM DETHI ");
                SqlCommand command5 = new SqlCommand(sqlquery5, connection);
                lbl_monthi.Text = command5.ExecuteScalar().ToString();
                connection.Close();


                connection.Open();
                string sqlquery6 = ("SELECT Count(NUMBER) FROM DETHI ");
                SqlCommand command6 = new SqlCommand(sqlquery6, connection);
                TOTAL = command6.ExecuteScalar().ToString();
                connection.Close();


                DemLT();


                // Connection is closed when leaving the using block
            }
        }

        void check_DapAn_1()
        {
            
            string dap_An;
            string sqlquery4 = ("SELECT ANSWER from DETHI where NUMBER=1 ");
            SqlCommand command4 = new SqlCommand(sqlquery4, con);
            dap_An = command4.ExecuteScalar().ToString();

            // get MADT
            string ma_DT;
            string ma_DT_check = ("SELECT ANSWER from DETHI where NUMBER=1 ");
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);
            ma_DT = command_maDT.ExecuteScalar().ToString();


            // insert to checkDapAn_table
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 1','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
        }
        void check_DapAn_2()
        {
            string dap_An;
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=2 ");
            SqlCommand command4 = new SqlCommand(sqlquery4, con);
            dap_An = command4.ExecuteScalar().ToString();

            // get MADT
            string ma_DT;
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=2 ");
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);
            ma_DT = command_maDT.ExecuteScalar().ToString();


            // insert to checkDapAn_table
            SqlDataAdapter da2 = new SqlDataAdapter("  INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 2','" + dap_An + "','" + luachon + "',N'" + lbl_monthi.Text + "','" + date + "')", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
        }
        void check_DapAn_3()
        {
            string dap_An;
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=3 ");
            SqlCommand command4 = new SqlCommand(sqlquery4, con);
            dap_An = command4.ExecuteScalar().ToString();

            // get MADT
            string ma_DT;
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=3 ");
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);
            ma_DT = command_maDT.ExecuteScalar().ToString();


            // insert to checkDapAn_table
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 3','" + dap_An + "','" + luachon + "',N'" + lbl_monthi.Text + "','" + date + "')", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
        }
        void check_DapAn_4()
        {
            string dap_An;
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=4 ");
            SqlCommand command4 = new SqlCommand(sqlquery4, con);
            dap_An = command4.ExecuteScalar().ToString();

            // get MADT
            string ma_DT;
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=4 ");
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);
            ma_DT = command_maDT.ExecuteScalar().ToString();


            // insert to checkDapAn_table
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 4','" + dap_An + "','" +  luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_5()                                                                                                                                  
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=5 ");                                                                                      
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=5 ");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 5','" + dap_An + "','" +  luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_6()                                                                                                                                  
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=6 ");                                                                                      
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=6 ");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 6','" + dap_An + "','" +  luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                   
            da2.Fill(dt2);                                                                                                                                     
        }                                                                                                                                                      
        void check_DapAn_7()                                                                                                                                   
        {                                                                                                                                                      
            string dap_An;                                                                                                                                     
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=7 ");                                                                                       
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                              
            dap_An = command4.ExecuteScalar().ToString();                                                                                                      
                                                                                                                                                               
            // get MADT                                                                                                                                        
            string ma_DT;                                                                                                                                      
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=7 ");                                                                                      
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                        
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                   
                                                                                                                                                               
                                                                                                                                                               
            // insert to checkDapAn_table                                                                                                                      
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 7','" + dap_An + "','" +  luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_8()                                                                                                                                  
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=8 ");                                                                                      
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=8 ");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 8','" + dap_An + "','" +  luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_9()                                                                                                                                 
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=9 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=9 ");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 9','" + dap_An + "','" +  luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_10()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=10 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=10 ");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 10','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_11()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=11 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=11 ");                                                                                   
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 11','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_12()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=12 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=12 ");                                                                                   
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 12','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_13()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=13 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=13 ");                                                                                   
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 13','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                               
            da2.Fill(dt2);                                                                                                                                 
        }                                                                                                                                                  
        void check_DapAn_14()                                                                                                                              
        {                                                                                                                                                  
            string dap_An;                                                                                                                                 
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=14 ");                                                                                  
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                          
            dap_An = command4.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                           
            // get MADT                                                                                                                                    
            string ma_DT;                                                                                                                                  
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=14 ");                                                                                 
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                    
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                               
                                                                                                                                                           
                                                                                                                                                           
            // insert to checkDapAn_table                                                                                                                  
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 14','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_15()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=15 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=15 ");                                                                                   
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 15','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_16()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=16 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=16 ");                                                                                   
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 16','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_17()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=17 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=17 ");                                                                                   
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 17','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                
            da2.Fill(dt2);                                                                                                                                  
        }                                                                                                                                                   
        void check_DapAn_18()                                                                                                                               
        {                                                                                                                                                   
            string dap_An;                                                                                                                                  
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=18 ");                                                                                   
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                           
            dap_An = command4.ExecuteScalar().ToString();                                                                                                   
                                                                                                                                                            
            // get MADT                                                                                                                                     
            string ma_DT;                                                                                                                                   
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=18 ");                                                                                  
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                     
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                
                                                                                                                                                            
                                                                                                                                                            
            // insert to checkDapAn_table                                                                                                                   
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 18','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                   
            da2.Fill(dt2);                                                                                                                                     
        }                                                                                                                                                      
        void check_DapAn_19()                                                                                                                                  
        {                                                                                                                                                      
            string dap_An;                                                                                                                                     
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=19");                                                                                       
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                              
            dap_An = command4.ExecuteScalar().ToString();                                                                                                      
                                                                                                                                                               
            // get MADT                                                                                                                                        
            string ma_DT;                                                                                                                                      
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=19 ");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                        
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                   
                                                                                                                                                               
                                                                                                                                                               
            // insert to checkDapAn_table                                                                                                                      
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 19','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_20()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=20 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=20");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 20','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_21()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=21 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=21");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 21','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                   
            da2.Fill(dt2);                                                                                                                                     
        }                                                                                                                                                      
        void check_DapAn_22()                                                                                                                                  
        {                                                                                                                                                      
            string dap_An;                                                                                                                                     
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=22 ");                                                                                      
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                              
            dap_An = command4.ExecuteScalar().ToString();                                                                                                      
                                                                                                                                                               
            // get MADT                                                                                                                                        
            string ma_DT;                                                                                                                                      
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=22");                                                                                      
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                        
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                   
                                                                                                                                                               
                                                                                                                                                               
            // insert to checkDapAn_table                                                                                                                      
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 22','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_23()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=23 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=23");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 23','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_24()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=24 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=24");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 24','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_25()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=25 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=25");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 25','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_26()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=26 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=26");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 26','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_27()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=27 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=27");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 27','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_28()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=28 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=28");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 28','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_29()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=29 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=29");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 29','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                
            da2.Fill(dt2);                                                                                                                                  
        }                                                                                                                                                   
        void check_DapAn_30()                                                                                                                               
        {                                                                                                                                                   
            string dap_An;                                                                                                                                  
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=30 ");                                                                                   
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                           
            dap_An = command4.ExecuteScalar().ToString();                                                                                                   
                                                                                                                                                            
            // get MADT                                                                                                                                     
            string ma_DT;                                                                                                                                   
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=30");                                                                                   
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                     
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                
                                                                                                                                                            
                                                                                                                                                            
            // insert to checkDapAn_table                                                                                                                   
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 30','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_31()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=31 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=31");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 31','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_32()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=32 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=32");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 32','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_33()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=33 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=33");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 33','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_34()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=34 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=34");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 34','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_35()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=35 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=35");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 35','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_36()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=36 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=36");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 36','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_37()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=37 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=37");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 37','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_38()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=38 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=38");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 38','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_39()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=39 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=39");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 39','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_40()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=40 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=40");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 40','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_41()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=41 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=41");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 41','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_42()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=42 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=42");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 42','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_43()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=43 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=43");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 43','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_44()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=44 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=44");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 44','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_45()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=45 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=45");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 45','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_46()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=46 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=46");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 46','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_47()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=47 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=47");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 47','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_48()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=48 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=48");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 48','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_49()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=49 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=49");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 49','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                 
            da2.Fill(dt2);                                                                                                                                   
        }                                                                                                                                                    
        void check_DapAn_50()                                                                                                                                
        {                                                                                                                                                    
            string dap_An;                                                                                                                                   
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=50 ");                                                                                    
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                            
            dap_An = command4.ExecuteScalar().ToString();                                                                                                    
                                                                                                                                                             
            // get MADT                                                                                                                                      
            string ma_DT;                                                                                                                                    
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=50");                                                                                    
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                      
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                 
                                                                                                                                                             
                                                                                                                                                             
            // insert to checkDapAn_table                                                                                                                    
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 50','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_51()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=51 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=51");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 51','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_52()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=52 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=52");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 52','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_53()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=53 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=53");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 53','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_54()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=54 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=54");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 54','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                   
            da2.Fill(dt2);                                                                                                                                     
        }                                                                                                                                                      
        void check_DapAn_55()                                                                                                                                  
        {                                                                                                                                                      
            string dap_An;                                                                                                                                     
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=55 ");                                                                                      
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                              
            dap_An = command4.ExecuteScalar().ToString();                                                                                                      
                                                                                                                                                               
            // get MADT                                                                                                                                        
            string ma_DT;                                                                                                                                      
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=55");                                                                                      
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                        
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                   
                                                                                                                                                               
                                                                                                                                                               
            // insert to checkDapAn_table                                                                                                                      
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 55','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                   
            da2.Fill(dt2);                                                                                                                                     
        }                                                                                                                                                      
        void check_DapAn_56()                                                                                                                                  
        {                                                                                                                                                      
            string dap_An;                                                                                                                                     
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=56 ");                                                                                      
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                              
            dap_An = command4.ExecuteScalar().ToString();                                                                                                      
                                                                                                                                                               
            // get MADT                                                                                                                                        
            string ma_DT;                                                                                                                                      
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=56");                                                                                      
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                        
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                   
                                                                                                                                                               
                                                                                                                                                               
            // insert to checkDapAn_table                                                                                                                      
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 56','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_57()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=57 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=57");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 57','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_58()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=58 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=58");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 58','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }                                                                                                                                                     
        void check_DapAn_59()                                                                                                                                 
        {                                                                                                                                                     
            string dap_An;                                                                                                                                    
            string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=59 ");                                                                                     
            SqlCommand command4 = new SqlCommand(sqlquery4, con);                                                                                             
            dap_An = command4.ExecuteScalar().ToString();                                                                                                     
                                                                                                                                                              
            // get MADT                                                                                                                                       
            string ma_DT;                                                                                                                                     
            string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=59");                                                                                     
            SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);                                                                                       
            ma_DT = command_maDT.ExecuteScalar().ToString();                                                                                                  
                                                                                                                                                              
                                                                                                                                                              
            // insert to checkDapAn_table                                                                                                                     
            SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 59','" + dap_An + "','" + luachon + "',N'"+lbl_monthi.Text+"','"+date+"')", con);
            DataTable dt2 = new DataTable();                                                                                                                  
            da2.Fill(dt2);                                                                                                                                    
        }

void check_DapAn_60()
{
    string dap_An;
    string sqlquery4 = ("SELECT ANSWER from DETHI WHERE NUMBER=60 ");
    SqlCommand command4 = new SqlCommand(sqlquery4, con);
    dap_An = command4.ExecuteScalar().ToString();

    // get MADT                                                                                                                                       
    string ma_DT;
    string ma_DT_check = ("SELECT CODE from DETHI where NUMBER=60");
    SqlCommand command_maDT = new SqlCommand(ma_DT_check, con);
    ma_DT = command_maDT.ExecuteScalar().ToString();


    // insert to checkDapAn_table                                                                                                                     
    SqlDataAdapter da2 = new SqlDataAdapter(" INSERT INTO Check_DapAn(MaDT,Cau,DapAn,Your_DapAn,MonThi,Date) VALUES('" + ma_DT + "','Câu 60','" + dap_An + "','" + luachon + "',N'" + lbl_monthi.Text + "','" + date + "')", con);
    DataTable dt2 = new DataTable();
    da2.Fill(dt2);
}

private void label27_MouseHover(object sender, EventArgs e)                                                                                           
        {                                                                                                                                                     
            Limit_socau();                                                                                                                                    
            if (axAcroPDF1.src != null)                                                                                                                       
            {                                                                                                                                                 
                try                                                                                                                                           
                {                                                                                                                                             
                    if (Convert.ToInt32(number_Count) > 0)                                                                                                    
                    {                                                                                                                                         
                        btn_import.BackgroundImage = new Bitmap(@"C:\Users\super\Desktop\icon\menu\Add_Question\checked.png");                                
                        btn_dethi.BackgroundImage = new Bitmap(@"C:\Users\super\Desktop\icon\menu\Add_Question\checked.png");                                 
                        t.Start();                                                                                                                            
                    }                                                                                                                                         
                }                                                                                                                                             
                catch                                                                                                                                         
                {                                                                                                                                             
                    MessageBox.Show("Please import your answer file .xlsx !");                                                                                           
                }                                                                                                                                             
            }                                                                                                                                                 
            else                                                                                                                                              
            {                                                                                                                                                 
                MessageBox.Show("Please import your exam file (.pdf,.docx,.png,.jpg)!");                                                                                                   
            }                                                                                                                                                 
                                                                                                                                                              
        }                                                                                                                                                     
                                                                                                                                                              
                                                                                                                                                  
                                                                                                                                                               
        private void Form_test_FormClosing(object sender, FormClosingEventArgs e)                                                                              
        {                                                                                                                                                      
            /*//   this.Hide();                                                                                                                                
               this.Parent = null;                                                                                                                             
               e.Cancel = true;*/                                                                                                                              
         /*   MainMenu n = new MainMenu();                                                                                                                     
            n.Show();*/                                                                                                                                        
        }                                                                                                                                                      
                                                                                                                                                               
        private void axAcroPDF1_Enter(object sender, EventArgs e)                                                                                              
        {                                                                                                                                                      
                                                                                                                                                               
        }                                                                                                                                                      
                                                                                                                                                               
        private void btn_import_MouseHover(object sender, EventArgs e)                                                                                         
        {                                                                                                                                                      
            if (axAcroPDF1.src != null)                                                                                                                        
            {                                                                                                                                                  
                check_Completed();                                                                                                                             
            }                                                                                                                                                  
            else                                                                                                                                               
            {                                                                                                                                                  
                MessageBox.Show("Import your exam file (.pdf,.docx,.png,jpg)");                                                                                                           
            }                                                                                                                                                  
        }                                                                                                                                                      
                                                                                                                                                               
        private void btn_close_Click(object sender, EventArgs e)                                                                                               
        {                                                                                                                                                      
            this.Hide();                                                                                                                                       
                                                                                                                                                               
            try                                                                                                                                                
            {                                                                                                                                                  
                SqlDataAdapter da = new SqlDataAdapter(" DELETE FROM DETHI ", con);                                                                            
                                                                                                                                                               
                                                                                                                                                               
                                                                                                                                                               
                                                                                                                                                               
                con.Open();                                                                                                                                    
                string sqlquery7 = ("DBCC CHECKIDENT ('[DETHI]', RESEED, 0)");                                                                                 
                SqlCommand command7 = new SqlCommand(sqlquery7, con);                                                                                          
                command7.ExecuteNonQuery();                                                                                                                    
                                                                                                                                                               
                                                                                                                                                               
                con.Close();                                                                                                                                   
            }                                                                                                                                                  
            catch(Exception ex)                                                                                                                                
            {                                                                                                                                                  
                MessageBox.Show(ex.Message);                                                                                                                   
            }                                                                                                                                                  
            MainMenu n = new MainMenu();                                                                                                                       
            n.Show();                                                                                                                                          
            this.Close();                                                                                                                                      
        }                                                                                                                                                      
                                                                                                                                                               
        private void btn_help_Click(object sender, EventArgs e)                                                                                                
        {                                                                                                                                                      
            Form_HowToUse n = new Form_HowToUse();                                                                                                             
            n.Show();                                                                                                                                          
       //     n.BringToFront();                                                                                                                                
        }                                                                                                                                                      
      
        public void enable_nopbai()
        {
            btn_nopbai.Enabled = true;
        }


        void check_Completed()
        {
            if(axAcroPDF1.src!=null)
            {
                btn_dethi.BackgroundImage = new Bitmap(@"C:\Users\super\Desktop\icon\menu\Add_Question\checked.png");
               
            }
        }
    }
  

    ////////////// CHECK DAP AN 
    ///

    

}

