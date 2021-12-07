using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TRACNGHIEMBYWINFORM
{
    public partial class UC_Profile : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

        public UserControl ParentControl { get; set; }

        private static UC_Profile _instance;
        public static UC_Profile Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = new UC_Profile();
                  
                }
                
                return _instance;
             
            }
           
        }
        public UC_Profile()
        {
            InitializeComponent();
            
        }
        public static void collapse()
        {
            _instance.splitContainer1.Panel1Collapsed = true;

            _instance.splitContainer1.Panel2Collapsed = false;
            _instance.splitContainer1.Panel2.Location = _instance.splitContainer1.Panel1.Location;
        }
        public static void expand()
        {
            _instance.splitContainer1.Panel1Collapsed = false;

            _instance.splitContainer1.Panel2Collapsed = true;
        }
        public  void disable_Filed()
        {
            tbox_Email.Enabled = false;
            tbox_MSV.Enabled = false;
            tbox_Name.Enabled = false;
            tbox_ns.Enabled = false;
            tbox_phone.Enabled = false;
        }
        public void enable_Filed()
        {
            tbox_Email.Enabled = true;
            tbox_MSV.Enabled = true;
            tbox_Name.Enabled = true;
            tbox_ns.Enabled = true;
            tbox_phone.Enabled = true;
        }
     
        private void splitContainer1_Panel2_Click(object sender, EventArgs e)
        {
         
        }

    
       public void reset()
        {
            _instance = null;
        }
        public void fetchdata()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True"))
                {

                    //// Email
                    connection.Open();
                    string sqlquery3 = ("SELECT Email  FROM login where  MSV='" + Form_Begin.usernamestatic + "' ");
                    SqlCommand command3 = new SqlCommand(sqlquery3, connection);
                    tbox_Email.Text = command3.ExecuteScalar().ToString();
                    connection.Close();

                    //// 
                    connection.Open();
                    string sqlquery4 = ("SELECT  Name  FROM login where  MSV='" + Form_Begin.usernamestatic + "' ");
                    SqlCommand command4 = new SqlCommand(sqlquery4, connection);
                    tbox_Name.Text = command4.ExecuteScalar().ToString();
                    connection.Close();
                    ////////
                    connection.Open();
                    string sqlquery5 = ("SELECT MSV  FROM login where  MSV='" + Form_Begin.usernamestatic + "'");
                    SqlCommand command5 = new SqlCommand(sqlquery5, connection);
                    tbox_MSV.Text = command5.ExecuteScalar().ToString();
                    connection.Close();
                    ///////////
                    connection.Open();
                    string sqlquery6 = ("SELECT phone  FROM login where  MSV='" + Form_Begin.usernamestatic + "' ");
                    SqlCommand command6 = new SqlCommand(sqlquery6, connection);
                    tbox_phone.Text = "0" + command6.ExecuteScalar().ToString();
                    connection.Close();
                    ///////////
                    ///


                    connection.Open();
                    string sqlquery7 = ("SELECT  Convert(varchar,dayofbirth,103)  FROM login where  MSV='" + Form_Begin.usernamestatic + "' ");
                    SqlCommand command7 = new SqlCommand(sqlquery7, connection);


                    tbox_ns.Text = command7.ExecuteScalar().ToString();



                    connection.Close();

                    // Connection is closed when leaving the using block
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("fetchdata " + ex.Message);
            }
        }
      
        private void UC_Detail_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            chart1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            lbl_avatar.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            lbl_doimk.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            lbl_suathongtin.BackColor= Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            label1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            label2.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            label3.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            label4.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            label5.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            label6.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            label7.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));


            try
            { 
            // LOAD IMAGE 
          
            if (picbox_user.Image == null)
            {
                string query_Image = "SELECT Image from Login where MSV='admin'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query_Image, connection); ;
                byte[] image = (byte[])cmd.ExecuteScalar();
                Image newImage = ConvertBinaryToImage(image);

                picbox_user.Image = newImage;
                connection.Close();

            }
            else
            {
                string query_Image = "SELECT Image from Login where MSV='" + Form_Begin.usernamestatic + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query_Image, connection); ;
                byte[] image = (byte[])cmd.ExecuteScalar();
                Image newImage = ConvertBinaryToImage(image);

                picbox_user.Image = newImage;
                connection.Close();

            }

            fetchdata();
            disable_Filed();
         
            tbox_MSV.Enabled = false;
            btn_change.Enabled = false;



            ////////
            ///LOAD DATA GRID 
            gridview_Edit();
            // chart
            try
            {
                // fetchdata();


             /*   //Fetch the Statistical data from database.
                string query = "SELECT Solanthi, socaudung [Total]";
                query += " FROM PHIEUKETQUA WHERE MSV = '" + Form_Begin.usernamestatic +"'";

                //  query += " GROUP BY Solanthi";
                DataTable dt = GetData(query);

                //Get the names of Cities.
                int[] x = (from p in dt.AsEnumerable()
                           orderby p.Field<int>("Solanthi") ascending
                           select p.Field<int>("Solanthi")).ToArray();

                //Get the Total of Orders for each City.
                int[] y = (from p in dt.AsEnumerable()
                           orderby p.Field<int>("Solanthi") ascending
                           select p.Field<int>("Total")).ToArray();

                chart1.Series[0].LegendText = "Correct Question";

                chart1.Series[0].ChartType = SeriesChartType.Column;
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].Points.DataBindXY(x, y);*/

            }
            catch
            {
                MessageBox.Show("WRONG CODE ! ");

            }

            //binddata_cbox
            Binddata_monHoc();

            }
            catch (Exception ex)
            {
                MessageBox.Show("UC_Detail_Load " + ex.Message);
            }
        }

        public void DrawChart()
        {
            try
            {
                // fetchdata();


                //Fetch the Statistical data from database.
                string query = "SELECT Solanthi, socaudung [Total]";
                query += " FROM PHIEUKETQUA WHERE MSV = '" + Form_Begin.usernamestatic + "' and MonTHI ='"+cbox_monthi.Text+"'and MaDT='"+cbox_made.Text+"' ";
                //  query += " GROUP BY Solanthi";
                DataTable dt = GetData(query);

                //Get the names of Cities.
                int[] x = (from p in dt.AsEnumerable()
                           orderby p.Field<int>("Solanthi") ascending
                           select p.Field<int>("Solanthi")).ToArray();

                //Get the Total of Orders for each City.
                int[] y = (from p in dt.AsEnumerable()
                           orderby p.Field<int>("Solanthi") ascending
                           select p.Field<int>("Total")).ToArray();

                chart1.Series[0].LegendText = "Correct Question";

                chart1.Series[0].ChartType = SeriesChartType.Column;
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].Points.DataBindXY(x, y);

            }
            catch
            {
                MessageBox.Show("WRONG CODE ! ");

            }
        }
        public void gridview_Edit()
        {
            try
            {
                string query = "SELECT DATE , MonTHI , MaDT , socaudung , socausai FROM PHIEUKETQUA where MSV='" + Form_Begin.usernamestatic + "'";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, connection);
                DataTable dttb = new DataTable();
                sqlDa.Fill(dttb);
                dataGridView1.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.DataSource = dttb;
            }
            catch(Exception ex)
            {
                MessageBox.Show("gridview_Edit " + ex.Message);

            }


        }


        
       
     
        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
          
          
        
           
        }
        private static DataTable GetData(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
        void Binddata_MaDT()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select distinct MaDT FROM PHIEUKETQUA where MSV='" + Form_Begin.usernamestatic + "'and MonTHI=N'" + cbox_monthi.Text + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbox_made.DisplayMember = "MaDT";
            cbox_made.DataSource = dt;

            //  connection.Close();


        }

        void Binddata_monHoc()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select distinct MonTHI FROM PHIEUKETQUA  where MSV = '" + Form_Begin.usernamestatic + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbox_monthi.DisplayMember = "MonTHI";
            cbox_monthi.DataSource = dt;


            //  connection.Close();
        }

        private void cbox_monthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Binddata_MaDT();
            }
            catch(Exception ex)
            {
                MessageBox.Show("cbox_monthi_SelectedIndexChanged " + ex.Message);
            }
        }

        private void cbox_made_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void cbox_monthi_TextChanged(object sender, EventArgs e)
        {
            if (cbox_monthi.Items.Count > 0)
                cbox_monthi.Text = "-Subjects-";
        }

        int count_click_2 = 1;
        private void lbl_doimk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            disable_Filed();
            btn_change.Enabled = false;
            if (count_click_2 % 2 != 0)
            {
                UC_reset_Password.Instance.Visible = true;
                if (!splitContainer1.Panel2.Controls.Contains(UC_reset_Password.Instance))
                {
                    splitContainer1.Panel2.Controls.Add(UC_reset_Password.Instance);
                    UC_reset_Password.Instance.Dock = DockStyle.Fill;
                    UC_reset_Password.Instance.BringToFront();

                }
                else
                    UC_reset_Password.Instance.BringToFront();
            }

            if (count_click_2 % 2 == 0)
            {
                enable_Filed();
                UC_reset_Password.Instance.Visible = false;
            }
            count_click_2++;
        }

        string fileName;

     //   List<login> list;

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private  void lbl_avatar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Files|*.jpg;*.jpeg;*.png;", ValidateNames = true, Multiselect = false })
            {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        fileName = ofd.FileName;
                  //      label2.Text = fileName;
                        picbox_user.Image = Image.FromFile(fileName);
                    }
               

            }
            if (fileName == null)
            {

            }
            else
            {
                DialogResult result = MessageBox.Show("Save ", "Change avatar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new quizEntities2())
                        {
                            var new_result = db.logins.SingleOrDefault(b => b.MSV == Form_Begin.usernamestatic);
                            if (new_result != null)
                            {

                                new_result.Image = ConvertImageToBinary(picbox_user.Image);
                                db.SaveChanges();
                            }
                        }
                        MessageBox.Show("Updated");

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("lbl_avatar_LinkClicked "+ ex.Message);
                    }
                }
                if (result == DialogResult.No)
                {

                }
            }
        }
        int count_click = 1;
        private void lbl_suathongtin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (count_click % 2 != 0)
            {         
                enable_Filed();
                btn_change.Enabled = true;
            }
            if (count_click % 2 == 0)
            {
                disable_Filed();          
                btn_change.Enabled = false;
            }
            count_click++;
        }

        private void btn_change_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "UPDATE login SET Name='" + tbox_Name.Text + "', dayofbirth='" + tbox_ns.Text + "',phone='" + tbox_phone.Text + "',Email='" + tbox_Email.Text + "' where MSV='" + tbox_MSV.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Saved");
                fetchdata();
                disable_Filed();
                btn_change.Enabled = false;
                //  toggleButton1.IsOn = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("btn_change_Click_1 "+ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            //  DEMO_UC_Detail.Instance.Visible = false;

            ((Form)this.TopLevelControl).Close();
            MainMenu n = new MainMenu();
                n.Show();
            _instance = null;


          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
