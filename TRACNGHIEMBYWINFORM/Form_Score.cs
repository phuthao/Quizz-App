using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;



namespace TRACNGHIEMBYWINFORM
{
    public partial class Form_Score : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
     

        public Form_Score()
        {

            InitializeComponent();



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static string dob_Note;
        public static string _date_Note;
        public static string _Monthi_Note;
        private void KETQUA_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            btn_home.BackColor= Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            bnt_checkDA.BackColor= Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            button1.BackColor= Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            panel3.BackColor= Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            panel_check.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            MainMenu n = new MainMenu();
            n.Hide();
            try
            {


              
               
                tbox_date.Text = DateTime.UtcNow.ToString("dd-MM-yyyy");
                _date_Note = tbox_date.Text;
                tbox_totalsocau.Text = Form_Test.TOTAL;

                using (SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True"))
                {
                    connection.Open();
                    // Perform the operations here
                    string sqlquery = ("SELECT TOP 1 socaudung  FROM PHIEUKETQUA where MSV='" + Form_Begin.usernamestatic + "' order by STT DESC ");
                    SqlCommand command = new SqlCommand(sqlquery, connection);
                    socaudung.Text = command.ExecuteScalar().ToString();
                    connection.Close();
                    //// so cau sai 
                    ///
                    connection.Open();
                    string sqlquery2 = ("SELECT TOP 1 socausai  FROM PHIEUKETQUA where  MSV='" + Form_Begin.usernamestatic + "' order by STT DESC ");
                    SqlCommand command2 = new SqlCommand(sqlquery2, connection);
                    socausai.Text = command2.ExecuteScalar().ToString();
                    connection.Close();


                    //// time to complete
                    connection.Open();
                    string sqlquery3 = ("SELECT TOP 1 timetocomplete  FROM PHIEUKETQUA where  MSV='" + Form_Begin.usernamestatic + "' order by STT DESC ");
                    SqlCommand command3 = new SqlCommand(sqlquery3, connection);
                    tbox_time.Text = command3.ExecuteScalar().ToString();
                    dob_Note = tbox_time.Text;
                    connection.Close();

                    //// 
                    connection.Open();
                    string sqlquery4 = ("SELECT TOP 1 Name  FROM PHIEUKETQUA where  MSV='" + Form_Begin.usernamestatic + "' ORDER BY NAME DESC ");
                    SqlCommand command4 = new SqlCommand(sqlquery4, connection);
                    tbox_name.Text = command4.ExecuteScalar().ToString();
                    connection.Close();
                    ////////
                    connection.Open();
                    string sqlquery5 = ("SELECT MSV  FROM PHIEUKETQUA where  MSV='" + Form_Begin.usernamestatic + "'");
                    SqlCommand command5 = new SqlCommand(sqlquery5, connection);
                    tbox_msv.Text = command5.ExecuteScalar().ToString();
                    connection.Close();
                    ///////////
                    connection.Open();
                    string sqlquery6 = ("SELECT TOP 1 phone  FROM PHIEUKETQUA where  MSV='" + Form_Begin.usernamestatic + "' ORDER BY STT DESC ");
                    SqlCommand command6 = new SqlCommand(sqlquery6, connection);
                    tbox_phone.Text = "0"+command6.ExecuteScalar().ToString();
                    connection.Close();
                    ///////////
                    connection.Open();
                    string sqlquery7 = ("SELECT Convert(varchar,dayofbirth,103)  FROM PHIEUKETQUA where  MSV='" + Form_Begin.usernamestatic + "' ORDER BY STT DESC ");
                    SqlCommand command7 = new SqlCommand(sqlquery7, connection);
                    tbox_dob.Text = command7.ExecuteScalar().ToString();
              

                    connection.Close();

                    connection.Open();
                    string sqlquery8 = ("SELECT distinct CODE from DETHI ");
                    SqlCommand command8 = new SqlCommand(sqlquery8, connection);
                    tbox_made.Text = command8.ExecuteScalar().ToString();

                    connection.Close();


                    connection.Open();
                    string sqlquery9 = ("SELECT distinct TOPIC from DETHI ");
                    SqlCommand command9 = new SqlCommand(sqlquery9, connection);
                    tbox_monthi.Text = command9.ExecuteScalar().ToString();
                     _Monthi_Note = tbox_monthi.Text;
                    connection.Close();

                    connection.Open();
                    string sqlquery10 = ("SELECT Email from login where MSV='"+Form_Begin.usernamestatic+"'");
                    SqlCommand command10 = new SqlCommand(sqlquery10, connection);
                    tbox_email.Text = command10.ExecuteScalar().ToString();

                    connection.Close();


                    // Connection is closed when leaving the using block


                    try
                    {

                        Image ConvertBinaryToImage(byte[] data)
                        {
                            using (MemoryStream ms = new MemoryStream(data))
                            {
                                return Image.FromStream(ms);
                            }
                        }
                        string query_Image = "SELECT Image from login where MSV='" + Form_Begin.usernamestatic + "'";
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query_Image, connection); ;
                        byte[] image = (byte[])cmd.ExecuteScalar();
                        Image newImage = ConvertBinaryToImage(image);

                        pic1.Image = newImage;
                        connection.Close();
                    }
                    catch
                    {
                        pic1.Image =  Image.FromFile("D:/ProjectMH/DONE/thuctap/TRACNGHIEMBYWINFORM/ANOTHERFILEINPUT/avatar.bmp");
                    }

               
                }




          //      _Monthi_Note = tbox_monthi.Text;

                /// sum cau 
                int x = Convert.ToInt32(socaudung.Text);
                int y = Convert.ToInt32(socausai.Text);
                int sum = x + y;

                tbox_sum.Text = sum.ToString();



              
                deleteDAPAN();
             
            }
            catch
            {
                MessageBox.Show("Please check again your file ! ");
            }

            double score = (10.0)/(Convert.ToDouble(Form_Test.TOTAL)) * (Convert.ToInt32(socaudung.Text));

          

            tbox_score.Text = Convert.ToString(Math.Round(score, 2));


        }
        public void deleteDAPAN()
        {
            SqlDataAdapter da = new SqlDataAdapter(" DELETE FROM DETHI ", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);



            connection.Open();
            string sqlquery7 = ("DBCC CHECKIDENT ('[DETHI]', RESEED, 0)");
            SqlCommand command7 = new SqlCommand(sqlquery7, connection);
            command7.ExecuteNonQuery();


            connection.Close();
        }
        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void delete_checkDapAn()
        {
            SqlDataAdapter da = new SqlDataAdapter(" DELETE FROM Check_DapAn ", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);



            connection.Open();
            string sqlquery7 = ("DBCC CHECKIDENT ('[Check_DapAn]', RESEED, 0)");
            SqlCommand command7 = new SqlCommand(sqlquery7, connection);
            command7.ExecuteNonQuery();


            connection.Close();
        }
        int count_click_checkDa = 0;
        private void bnt_checkDA_Click(object sender, EventArgs e)
        {
            
            this.Size = new Size(1308, 727);
            panel3.Size = new Size(1308, 38);
            if (count_click_checkDa == 0)
            {
                if (!panel_check.Controls.Contains(UC_checkDapan.Instance))
                {
                //    bnt_checkDA.Text = "Check";
                    panel_check.Controls.Add(UC_checkDapan.Instance);

                    UC_checkDapan.Instance.Dock = DockStyle.Fill;
                    UC_checkDapan.Instance.BringToFront();



                }
                else
                    UC_checkDapan.Instance.BringToFront();

               

            }

            count_click_checkDa++;

            if (count_click_checkDa % 2 != 0 )
            {
                bnt_checkDA.Text = "Check";
                panel_check.Controls.Clear();
            }

            if (count_click_checkDa % 2 == 0)
            {
                bnt_checkDA.Text = "UnCheck";
                panel_check.Controls.Add(UC_checkDapan.Instance);

            }


         //   UC_checkDapan n = new UC_checkDapan();
       //     n._reset();

         
        //    

          //  

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    SendKeys.Send("%({PRTSC})");
            try
            {
              
          

                Image myImage = Clipboard.GetImage();



                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Images|*.png;*.bmp;*.jpg";
                saveDialog.FileName = "result.png";
                DialogResult result = saveDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String fileName = saveDialog.FileName;
                    //your code to save the file;
                    myImage.Save(fileName);
                  //myImage.Save("C:\\Users/super/Desktop/output.png");
                 }



                MessageBox.Show("Saved");
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete_checkDapAn();
            this.Hide(); 
            this.Close();

            MainMenu n = new MainMenu();
            n.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        //    System.Threading.Thread.Sleep(1000);
            SendKeys.Send("%({PRTSC})");
        }

        private void Form_ketQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            delete_checkDapAn();
            UC_checkDapan _n = new UC_checkDapan();
            _n._reset();
            //  this.Hide();
            this.Parent = null;
            e.Cancel = true;

            MainMenu n = new MainMenu();
            n.BringToFront();
          
        }

        private void btn_note_Click(object sender, EventArgs e)
        {

        }
    }
}
