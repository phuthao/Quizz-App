using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class MainMenu :MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
        public static string activity;

        public MainMenu()
        {      
                InitializeComponent();
           
            panel_Nav.Height = btn_dashboard.Height;
            panel_Nav.Top = btn_dashboard.Top;
            panel_Nav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

      




        ///
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        // circle
        public Image ClipToCircle(Image srcImage, PointF center, float radius, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);

            using (Graphics g = Graphics.FromImage(dstImage))
            {
                RectangleF r = new RectangleF(center.X - radius, center.Y - radius,
                                                         radius * 2, radius * 2);

                // enables smoothing of the edge of the circle (less pixelated)
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // fills background color
                using (Brush br = new SolidBrush(backGround))
                {
                    g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
                }

                // adds the new ellipse & draws the image again 
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(r);
                g.SetClip(path);
                g.DrawImage(srcImage, 0, 0);

                return dstImage;
            }
        }

        ///splash form
        ///    
        void Loading()
        {
            try
            {
                Form_splashScreen n = new Form_splashScreen();

                Application.Run(n);
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();

            }


        }


        public int _time = 2000;
        private  void DEMO_MENU_2_Load(object sender, EventArgs e)
        {
         //   await Task.Delay(1000);

          
            this.Icon = Properties.Resources.laptop1;


            Choose_Color();
          

            try
            {
                Thread t = new Thread(new ThreadStart(Loading));
                t.Start();  
                     Thread.Sleep(_time); 
                
                 t.Abort();
                 
            }
            catch (ThreadAbortException ex)
            {
              
                Thread.ResetAbort();
                MessageBox.Show(ex.Message);
            }
            /// admin permission
            /// 

            try

            {
                connection.Open();
                SqlCommand _cmd_checkallow1 = new SqlCommand("SELECT Allow_document FROM login WHERE MSV='" + Form_Begin.usernamestatic + "'", connection);
                string _document = _cmd_checkallow1.ExecuteScalar().ToString();

                connection.Close();
                //2
                connection.Open();
                SqlCommand _cmd_checkallow2 = new SqlCommand("SELECT Allow_history FROM login WHERE MSV='" + Form_Begin.usernamestatic + "'", connection);
                string _history = _cmd_checkallow2.ExecuteScalar().ToString();
                connection.Close();
                //3
                connection.Open();
                SqlCommand _cmd_checkallow3 = new SqlCommand("SELECT Allow_accountcontrol FROM login WHERE MSV='" + Form_Begin.usernamestatic + "'", connection);
                string _allowaccount = _cmd_checkallow3.ExecuteScalar().ToString();
                connection.Close();

                if (_document == "True")
                {
                    btn_Dethi.Enabled = true;
                }
                else
                {
                    btn_Dethi.Enabled = false;
                    btn_Dethi.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/lockk.png");
                }
                if (_history == "True")
                {
                    btn_history.Enabled = true;
                }
                else
                {
                    btn_history.Enabled = false;
                    btn_history.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/padlock.png");
                }
                if (_allowaccount == "True")
                {
                    btn_manager.Enabled = true;
                }
                else
                {
                    btn_manager.Enabled = false;
                    btn_manager.BackgroundImage = new Bitmap("C:\\Users/super/Desktop/icon/padlock.png");
                }

                ///



                lbl_username.Text = Form_Begin.usernamestatic;

                try
                {
                    connection.Open();
                    SqlCommand _cmd = new SqlCommand("SELECT Image FROM login WHERE MSV='" + Form_Begin.usernamestatic + "'", connection);
                    string _length = _cmd.ExecuteScalar().ToString();
                    connection.Close();
                    if (_length != "")
                    {



                        string query_Image = "SELECT Image from login where MSV='" + Form_Begin.usernamestatic + "'";
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(query_Image, connection); ;
                        byte[] image = (byte[])cmd.ExecuteScalar();
                        Image newImage = ConvertBinaryToImage(image);
                        Image circle_img = ClipToCircle(newImage, new PointF(newImage.Width / 2, newImage.Height / 2), newImage.Width / 2, Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B)));
                        picturebox_Avatar.Image = circle_img;
                        connection.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Form_Score _fkq = new Form_Score();
                _fkq.deleteDAPAN();

            }
            catch(Exception ex)
            {
                MessageBox.Show("DEMO_LOAD" + ex.Message);
            }

            this.MaximizeBox = false;
        }


        // expend
      public  static  string R = "";
        public static string G = "";
        public static string B = "";
    public void Choose_Color()
        {
            connection.Open();
            string query_color1 = "SELECT R from login where MSV='"+Form_Begin.usernamestatic+"'";
            SqlCommand query_color_R = new SqlCommand(query_color1, connection);           
              R  = query_color_R.ExecuteScalar().ToString(); 
            connection.Close();

            connection.Open();
            string query_color2 = "SELECT G from login where MSV='" + Form_Begin.usernamestatic + "'";
            SqlCommand query_color_G = new SqlCommand(query_color2, connection);
             G = query_color_G.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            string query_color3 = "SELECT B from login where MSV='" + Form_Begin.usernamestatic + "'";
            SqlCommand query_color_B = new SqlCommand(query_color3, connection);
             B = query_color_B.ExecuteScalar().ToString();
            connection.Close();


            if(R==""||G==""||B=="")
            {
              
                R = "41";
                G = "128";
                B = "185";
            }


             panel1.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
            panel2.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B)); 
            picturebox_Avatar.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
            btn_Tracuu.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
            btn_manager.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B)); 
            btn_history.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B)); 
            btn_list.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B)); 
            btn_note.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B)); 
            btn_rank.BackColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));

           

        }
    
       
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            panel_Nav.Height = btn_dashboard.Height;
            panel_Nav.Top = btn_dashboard.Top;
            panel_Nav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);



            activity = "Profile";
            Update_Activity();
           

            UC_Profile.Instance.Visible = true;

                if (!panel_noidung.Controls.Contains(UC_Profile.Instance))
                {
                    panel_noidung.Controls.Add(UC_Profile.Instance);
                    UC_Profile.Instance.Dock = DockStyle.Fill;
                 UC_Profile.Instance.BringToFront();
             

                   
                }
                UC_Profile.Instance.BringToFront();


            // collaspe
            panel1.Size = new Size(5, 626);
            panel_noidung.Size = new Size(993, 622);
            // panel_noidung.Dock = DockStyle.Left;
            panel_noidung.Location = new Point(0,3);


        }

        public void Update_Activity()
        {
            try
            {

                connection.Open();
                string query_activity = " SELECT Activity from History where MSV='" + Form_Begin.usernamestatic + "' and STT in ( SELECT MAX(STT) FROM History GROUP BY MSV) ";
                SqlCommand cmd2 = new SqlCommand(query_activity, connection);
                string acti = cmd2.ExecuteScalar().ToString();
                connection.Close();

                connection.Open();
                string query = "UPDATE History SET Activity= N'" + acti + "' + ' -> ' + N'" + activity + "' where MSV='" + Form_Begin.usernamestatic + "' and STT in ( SELECT MAX(STT) FROM History GROUP BY MSV)   ";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Update_Activity " + ex.Message);
            }
        }


        private void btn_Cauhoi_Click(object sender, EventArgs e)
        {
            panel_Nav.Height = btn_Cauhoi.Height;
            panel_Nav.Top = btn_Cauhoi.Top;
            btn_Cauhoi.BackColor = Color.FromArgb(46, 51, 73);

            ///////////
            ///
            activity = "Question";
            Update_Activity();
            Form_Question n = new Form_Question();
            this.Close();
            n.Show();
        }

        private void btn_Tracuu_Click(object sender, EventArgs e)
        {
            panel_Nav.Height = btn_Tracuu.Height;
            panel_Nav.Top = btn_Tracuu.Top;
            btn_Tracuu.BackColor = Color.FromArgb(46, 51, 73);

            ///////////// source BE
            activity = "Search";
            Update_Activity();
            Form_Search n = new Form_Search();
            n.Show();
            this.Close();
        }
      
        private void btn_Dethi_Click(object sender, EventArgs e)
        {
            panel_Nav.Height = btn_Dethi.Height;
            panel_Nav.Top = btn_Dethi.Top;
            btn_Dethi.BackColor = Color.FromArgb(46, 51, 73);

            //////////////
            ///
            activity = "Document";
            Update_Activity();
            Form_Document n = new Form_Document();
            n.Show();

            this.Close();
        }

        private void btn_Lambai_Click(object sender, EventArgs e)
        {
           


            this.Hide();
            panel_Nav.Height = btn_Lambai.Height;
            panel_Nav.Top = btn_Lambai.Top;
            btn_Lambai.BackColor = Color.FromArgb(46, 51, 73);


            ///// SOURCE BE 
            ///
            activity = "Test";
            Update_Activity();


/*
            try
            {*/

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
                    MainMenu n = new MainMenu();
                    n.ShowDialog();

                    }
                }
                else
                {
                    this.Hide();
                    Form_Test n = new Form_Test();
                    n.Show();
                }
           /* }*/
         /*   catch (Exception ex)
            {
                MessageBox.Show("btn_Lambai_Click "+ex.Message);
            }*/

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
       
            Form_splashScreen fps = new Form_splashScreen();
            fps.Close();


            Form_Begin n = new Form_Begin();
            UC_Profile _dt = new UC_Profile();
            UC_reset_Password _rs = new UC_reset_Password();
            UC_control_Account _ca = new UC_control_Account();
            UC_Note _note = new UC_Note();
            UC_Activity _activity = new UC_Activity();
            UC_checkDapan _checkdapan = new UC_checkDapan();
            UC_delete_Profile _deleteProfile = new UC_delete_Profile();
            this.Hide();
            _deleteProfile.reset();
            _checkdapan._reset();
            _activity.reset();
            _dt.reset();
            _rs.reset();
            _ca.reset();
            _note._reset();
            n.ShowDialog();
            this.Close();

            activity = "Sign Out";
            Update_Activity();
        }

        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btn_Cauhoi_Leave(object sender, EventArgs e)
        {
            btn_Cauhoi.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btn_Tracuu_Leave(object sender, EventArgs e)
        {
            btn_Tracuu.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btn_Dethi_Leave(object sender, EventArgs e)
        {
            btn_Dethi.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btn_Lambai_Leave(object sender, EventArgs e)
        {
            btn_Lambai.BackColor = Color.FromArgb(41, 128, 185);
        }


        ///////////MENU
        ///
        public void hideonbush()
        {

            btn_Dethi.Visible = false;
        }

      

        private void btn_thoat_Click(object sender, EventArgs e)
        {
      
            Environment.Exit(1);
        }


      

      

        public string fileName;
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        Image circle_img;
        Image store_picfromfile ;
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Files|*.jpg;*.jpeg;*.png;", ValidateNames = true, Multiselect = false })
                {

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        fileName = ofd.FileName;
                        //      label2.Text = fileName;


                        store_picfromfile = Image.FromFile(fileName);

                        circle_img = ClipToCircle(store_picfromfile, new PointF(store_picfromfile.Width / 2, store_picfromfile.Height / 2), store_picfromfile.Width / 2, Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B)));


                    }
                }

                if (fileName != null)
                {
                    DialogResult result = MessageBox.Show("Save", "Change avatar", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (var db = new quizEntities2())
                            {
                                var new_result = db.logins.SingleOrDefault(b => b.MSV == Form_Begin.usernamestatic);
                                if (new_result != null)
                                {

                                    new_result.Image = ConvertImageToBinary(store_picfromfile);
                                    db.SaveChanges();
                                }
                            }
                            MessageBox.Show("Saved");
                            picturebox_Avatar.Image = circle_img;

                            fileName = null;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (result == DialogResult.No)
                    {
                        picturebox_Avatar.Image = this.picturebox_Avatar.Image;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("pictureBox1_Click " + ex.Message);
            }
            
        }

        private void btn_dashboard_MouseClick(object sender, MouseEventArgs e)
        {
          
            //  DEMO_UC_Detail.Instance.Visible = false;
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_xoalichsu_Click(object sender, EventArgs e)
        {
            panel_noidung.Visible = true;


            if (!panel_noidung.Controls.Contains(UC_delete_Profile.Instance))
            {
                panel_noidung.Controls.Add(UC_delete_Profile.Instance);
                UC_delete_Profile.Instance.Dock = DockStyle.Fill;
                UC_delete_Profile.Instance.BringToFront();
            }
            else
                UC_checkDapan.Instance.BringToFront();

        }

        private void btn_rank_Click(object sender, EventArgs e)
        {
            activity = "Rank";
            Update_Activity();
            Form_Rank n = new Form_Rank();
            n.Show();
            this.Hide();
        }

       

       
        private void btn_manager_Click(object sender, EventArgs e)
        {

            panel1.Size = new Size(5, 626);
            panel_noidung.Size = new Size(999, 622);
       
            panel_noidung.Location = new Point(0, 3);

         
            if (Form_Begin.usernamestatic == "admin")
            {
           //     UC_control_Account.Instance.Visible = true;

                if (!panel_noidung.Controls.Contains(UC_control_Account.Instance))
                {
                    panel_noidung.Controls.Add(UC_control_Account.Instance);
                    UC_control_Account.Instance.Dock = DockStyle.Fill;
                    UC_control_Account.Instance.BringToFront();
          //          count_click2 = 1;
                }
                UC_control_Account.Instance.BringToFront();

         //       count_click2 = 1;
            }
            else
            {

            }
        /*    UC_Rank._Instance.Visible = false;
         *//*   UC_control_Account n = new UC_control_Account();
            n.active_btn();*//*
            UC_control_Account.Instance.Visible = true;*/


            activity = "Account Control";
            Update_Activity();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            if (!panel_noidung.Controls.Contains(UC_Activity._Instance))
            {
                panel_noidung.Controls.Add(UC_Activity._Instance);
                UC_Activity._Instance.Dock = DockStyle.Fill;
                UC_Activity._Instance.BringToFront();
            }
            else
                UC_Activity._Instance.BringToFront();
        }

      

        private void btn_list_Click(object sender, EventArgs e)
        {
            activity = "Exam Question";
            Update_Activity();

            Form_list_PDF n = new Form_list_PDF();
            n.Show();

            this.Hide();
          
        }

       

      

        private void btn_note_Click(object sender, EventArgs e)
        {
           // this.Hide();
            //panel_hidecontrolbox.Visible = true;
         



            if (!panel_noidung.Controls.Contains(UC_Note.Instance))
            {
               
                panel_noidung.Controls.Add(UC_Note.Instance);
                UC_Note.Instance.Dock = DockStyle.Fill;
                UC_Note.Instance.BringToFront();
            }
            else
                UC_Note.Instance.BringToFront();

            activity = "Note";
            Update_Activity();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel_noidung_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void _fetchdatacolor()
        {
            connection.Open();
            string query5 = "UPDATE login SET R=@R , G=@G , B=@B where MSV=@MSV ";
            SqlCommand _sqlA5 = new SqlCommand(query5, connection);

            _sqlA5.Parameters.AddWithValue("@R", _colorDialog.Color.R);
            _sqlA5.Parameters.AddWithValue("@G", _colorDialog.Color.G);
            _sqlA5.Parameters.AddWithValue("@B", _colorDialog.Color.B);

            _sqlA5.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);

            _sqlA5.ExecuteNonQuery();
            connection.Close();

        }
        private void btn_color_Click(object sender, EventArgs e)
        {
            
            if(_colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = _colorDialog.Color;
                panel2.BackColor = _colorDialog.Color;
              
                btn_Tracuu.BackColor = _colorDialog.Color;
                btn_manager.BackColor = _colorDialog.Color;
                btn_history.BackColor = _colorDialog.Color;
                btn_list.BackColor = _colorDialog.Color;
                btn_note.BackColor = _colorDialog.Color;
                btn_rank.BackColor = _colorDialog.Color;

                picturebox_Avatar.BackColor = _colorDialog.Color;

                string query_Image = "SELECT Image from login where MSV='" + Form_Begin.usernamestatic + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query_Image, connection); ;
                byte[] image = (byte[])cmd.ExecuteScalar();
               Image newImage = ConvertBinaryToImage(image);
               Image circle_img = ClipToCircle(newImage, new PointF(newImage.Width / 2, newImage.Height / 2), newImage.Width / 2, _colorDialog.Color);
                picturebox_Avatar.Image = circle_img;
                connection.Close();

                // update color 
                _fetchdatacolor();
            }

           


            

        }
    }
}
