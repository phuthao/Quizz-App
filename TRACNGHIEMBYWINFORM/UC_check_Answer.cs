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

namespace TRACNGHIEMBYWINFORM
{
    public partial class UC_checkDapan : UserControl
    {
        public static int _rs;

        public bool _status = false;

        public static string madt;

        public static string Numrd;

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        private static UC_checkDapan _instance;
        public static UC_checkDapan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_checkDapan();
                return _instance;

             
            }
        }
      
      
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (datagirdview_checkDapAn.Rows[e.RowIndex].Cells[4].Value.ToString() != datagirdview_checkDapAn.Rows[e.RowIndex].Cells[5].Value.ToString())
            {
                datagirdview_checkDapAn.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

          
        }

       public void _reset()
        {
            _instance = null;
        }
        public UC_checkDapan()
        {
          
            InitializeComponent();

            datagirdview_checkDapAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Check_DapAn", con);
            DataTable dtbl = new DataTable();

           /* datagirdview_checkDapAn.Columns["MonThi"].Visible = false;
            datagirdview_checkDapAn.Columns["Date"].Visible = false;
            datagirdview_checkDapAn.Columns["STT"].Visible = false;*/
       //     datagirdview_checkDapAn.Columns["MaDT"].Visible = false;


            sqlDa.Fill(dtbl);

            datagirdview_checkDapAn.DataSource = dtbl;
          
         //   datagirdview_checkDapAn.DataSource = UC_Note.gridView;


            this.datagirdview_checkDapAn.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
          

            con.Close();

            do
            {
                Random rd = new Random();
                Numrd = "RE" + rd.Next(1000, 9999).ToString();//biến Numrd sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100
                                                              //    Numrd_str = rd.Next(1, 100).ToString();//Chuyển giá trị ramdon về kiểu string
            }
            while (count < -15);


        }

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
           
        }

        private void dataGridView1_BackgroundColorChanged(object sender, EventArgs e)
        {
            
        }

        public static string value= "bandau";


     //   public static string value;
        private void btn_note_Click(object sender, EventArgs e)
        {
       //     check_box.FalseValue = true ;

            Form_comment_String n = new Form_comment_String();
            n.Show();

         
        }

        public static string cellValue;

       
        public static int _index;
        public static bool state =true;
        public static int count = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)datagirdview_checkDapAn.Rows[e.RowIndex].Cells[0];

            cellValue = datagirdview_checkDapAn.Rows[e.RowIndex].Cells[1].Value.ToString();
            _index = Convert.ToInt32(cellValue);

            if (state==false)
            {
                chk.Value = chk.TrueValue;

                con.Open();
                string query = "UPDATE Note SET Checked = @Checked where ID = @ID ";
                SqlCommand _sqlA = new SqlCommand(query, con);

                _sqlA.Parameters.AddWithValue("@ID", _index);
                _sqlA.Parameters.AddWithValue("@Checked", 1);
                _sqlA.ExecuteNonQuery();
                con.Close();

                state = true;
            }
        }
            private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            /*if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["STT"].Value);
               




            }
        }*/
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  try
            {*/
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)datagirdview_checkDapAn.Rows[e.RowIndex].Cells[0];

                    cellValue = datagirdview_checkDapAn.Rows[e.RowIndex].Cells[1].Value.ToString();
                    _index = Convert.ToInt32(cellValue);


                    if (chk.Value == chk.TrueValue)
                    {

                        count = 1;
                        /*
                                            try
                                            {*/
                        SqlDataAdapter sqlA = new SqlDataAdapter("SELECT * from Note where ID=@ID", con);
                        sqlA.SelectCommand.Parameters.AddWithValue("@ID", _index);
                        DataTable dt = new DataTable();
                        sqlA.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {




                            //
                            con.Open();
                            SqlCommand cmd = new SqlCommand("SELECT MaDT from Check_DapAn where STT= '" + _index + "' ", con);

                             madt = cmd.ExecuteScalar().ToString();
                            con.Close();



                            //
                            con.Open();
                            SqlCommand cmd2 = new SqlCommand("SELECT Cau from Check_DapAn where STT= '" + _index + "' ", con);

                            string cau = cmd2.ExecuteScalar().ToString();
                            con.Close();


                            ///
                            con.Open();
                            SqlCommand cmd3 = new SqlCommand("SELECT DapAn from Check_DapAn where STT= '" + _index + "' ", con);

                            string dapan = cmd3.ExecuteScalar().ToString();
                            con.Close();


                            con.Open();
                            SqlCommand cmd4 = new SqlCommand("SELECT Your_DapAn from Check_DapAn where STT= '" + _index + "'", con);

                            string yourdapan = cmd4.ExecuteScalar().ToString();
                            con.Close();


                        con.Open();
                        SqlCommand cmd5 = new SqlCommand("SELECT _INDEX from Check_DapAn where STT= '" + _index + "'", con);

                        string sid = cmd5.ExecuteScalar().ToString();
                        con.Close();



                        if (_status == false)
                        {
                          
                            con.Open();
                            SqlCommand _Countcmd = new SqlCommand("SELECT TOP 1 _Count FROM Note WHERE MSV = '" + Form_Begin.usernamestatic + "' and MaDT='" + madt + "' order by _Count DESC ", con);

                            var _count = _Countcmd.ExecuteScalar();
                            con.Close();
                           

                            string xc = Convert.ToString(_count);

                          





                            if (xc == "" || xc == null)
                            {

                                xc = "0";
                                _rs = Convert.ToInt32(xc);


                            }
                            else
                            {
                                _rs = Convert.ToInt32(xc);
                                _rs++;
                            }

                            _status = true;
                        }


                        //   hàm random

                      


                         con.Open();
                            string query = "INSERT INTO Note(ID,Checked,MaDT,Cau,DapAn,Your_DapAn,MSV,_Day,MonThi,Date,_Count) Values(@ID,@Checked,@MaDT,@Cau,@DapAn,@Your_DapAn,@MSV,@_Day,@MonThi,@Date,@_Count)";
                            SqlCommand _sqlA = new SqlCommand(query, con);
                            _sqlA.Parameters.AddWithValue("@ID", sid);
                            _sqlA.Parameters.AddWithValue("@Checked", 1);
                            _sqlA.Parameters.AddWithValue("@MaDT", Numrd);
                            _sqlA.Parameters.AddWithValue("@Cau", cau);
                            _sqlA.Parameters.AddWithValue("@DapAn", dapan);
                            _sqlA.Parameters.AddWithValue("@Your_DapAn", yourdapan);
                            _sqlA.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);
                            _sqlA.Parameters.AddWithValue("@_Day", Form_Score.dob_Note);
                            _sqlA.Parameters.AddWithValue("@MonThi", Form_Score._Monthi_Note);
                            _sqlA.Parameters.AddWithValue("@Date", Form_Score._date_Note);
                            _sqlA.Parameters.AddWithValue("@_Count",_rs);

                        /// 
                        /*    _sqlA.Parameters.AddWithValue("@noidung",noidung);*/
                        /*     _sqlA.Parameters.AddWithValue("@A",A);
                             _sqlA.Parameters.AddWithValue("@B",B);
                             _sqlA.Parameters.AddWithValue("@C",C);
                             _sqlA.Parameters.AddWithValue("@D",D);
     */
                        _sqlA.ExecuteNonQuery();
                            con.Close();

                        }
                        else
                        {
                            /* con.Open();
                             SqlCommand cmd = new SqlCommand("SELECT Checked from Note where ID=@ID ", con);
                             cmd.Parameters.AddWithValue("@ID", _index);
                             string result = cmd.ExecuteScalar().ToString();
                             con.Close();
                             //      DataTable dt2 = new DataTable();
                             // sqlA.Fill(dt2);

                             if (result == "0")
                             {
                                 con.Open();
                                 string query = "UPDATE Note SET Checked = @Checked where ID = @ID ";
                                 SqlCommand _sqlA = new SqlCommand(query, con);

                                 _sqlA.Parameters.AddWithValue("@ID", _index);
                                 _sqlA.Parameters.AddWithValue("@Checked", 1);
                                 _sqlA.ExecuteNonQuery();
                                 con.Close();*/


                            /*  }
  */
                        }
                        /*  }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }    */





                    }

                    if (chk.Value != chk.TrueValue)
                    {

                        count = 2;


                        con.Open();
                        string query = "UPDATE Note SET Checked = @Checked where ID = @ID ";
                        SqlCommand _sqlA = new SqlCommand(query, con);

                        _sqlA.Parameters.AddWithValue("@ID", _index);
                        _sqlA.Parameters.AddWithValue("@Checked", 0);
                        _sqlA.ExecuteNonQuery();
                        con.Close();

                        state = false;

                    }

                    //    chk.Value = chk.TrueValue;
                }
          /*  }
            catch
            {
                MessageBox.Show("this");
            }*/
                    
               
            }

        private void datagirdview_checkDapAn_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_allwrong_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_checkDapan_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            btn_note.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
        }
    }
    }

