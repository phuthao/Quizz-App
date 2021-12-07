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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class UC_control_Account : UserControl
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

        public UC_control_Account()
        {
            InitializeComponent();
        }

        private static UC_control_Account _instance;
        public static UC_control_Account Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new UC_control_Account();
                }
                return _instance;
            }
          
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            form_DangKy n = new form_DangKy();
            n.Show();

            update();
            
        }
        public void reset()
        {
            _instance = null;
        }
      
        private void UC_ControlAccont_Load(object sender, EventArgs e)
        {        
                groupbox_allow.Visible = false;                   
                groupbox_allow.Enabled = false;

            try
            {

                if (pic_avatar.Image == null)
                {
                    string query_Image = "SELECT Image from Login where MSV='admin'";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query_Image, connection); ;
                    byte[] image = (byte[])cmd.ExecuteScalar();
                    Image newImage = ConvertBinaryToImage(image);

                    pic_avatar.Image = newImage;
                    connection.Close();

                }
                else
                {
                    string query_Image = "SELECT Image from Login where MSV='" + Form_Begin.usernamestatic + "'";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query_Image, connection); ;
                    byte[] image = (byte[])cmd.ExecuteScalar();
                    Image newImage = ConvertBinaryToImage(image);

                    pic_avatar.Image = newImage;
                    connection.Close();

                }
                update();


            }
            catch (Exception ex)
            {
                MessageBox.Show("UC_ControlAccont_Load " + ex.Message);
            }

          
        }

        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        static string MSV;


        public static string cellValue;



      
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                string query = "DELETE FROM login where MSV = @MSV ";
                SqlCommand sqlDa = new SqlCommand(query, connection);
                sqlDa.Parameters.AddWithValue("@MSV", MSV);
                sqlDa.ExecuteNonQuery();
                connection.Close();
             
                MessageBox.Show("Account Has Deleted From List");
                tbox_dob.Text = "";
                tbox_email.Text = "";
                tbox_msv.Text = "";
                tbox_phone.Text = "";
                tbox_name.Text = "";
                 
            }
            catch(Exception ex)
            {
                MessageBox.Show("btn_xoa_Click "+ ex.Message);
            }
            update();
        }
       public async void update()
        {
            await Task.Delay(1000);
            try
            {
                
                string query = "SELECT MSV,Name,phone,Convert(varchar,dayofbirth,103) as dayofbirth , Email , Image FROM login ";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, connection);

                DataTable dttb = new DataTable();
                sqlDa.Fill(dttb);


                dataGridView1.DataSource = dttb;
            }
            catch(Exception ex)
            {
                MessageBox.Show("update " + ex.Message);
            }
           
        }

       
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " Update login set  dayofbirth = @dayofbirth , Name=@Name, Phone=@Phone , Email=@Email where MSV = @MSV  ";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                da.SelectCommand.Parameters.AddWithValue("@dayofbirth", tbox_dob.Text);
                da.SelectCommand.Parameters.AddWithValue("@Name", tbox_name.Text);
                da.SelectCommand.Parameters.AddWithValue("@Phone", tbox_phone.Text);
                da.SelectCommand.Parameters.AddWithValue("@Email", tbox_email.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Success to change value ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("update click " + ex.Message);
            }
            update();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                tbox_msv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbox_phone.Text = "0" + dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tbox_dob.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                tbox_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();




                //
                connection.Open();
                string query_Image = "SELECT Image from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd = new SqlCommand(query_Image, connection); ;
                string check_image = cmd.ExecuteScalar().ToString();
                connection.Close();

                if (check_image == "")
                {
                    query_Image = "SELECT Image from login where MSV='Local'";
                    SqlCommand cmd1 = new SqlCommand(query_Image, connection); ;
                    connection.Open();
                    byte[] image = (byte[])cmd1.ExecuteScalar();


                    Image newImage = ConvertBinaryToImage(image);

                    pic_avatar.Image = newImage;
                    connection.Close();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand(query_Image, connection); ;
                    connection.Open();
                    byte[] image = (byte[])cmd2.ExecuteScalar();


                    Image newImage = ConvertBinaryToImage(image);

                    pic_avatar.Image = newImage;
                    connection.Close();
                }


                if (tbox_msv.Text == "admin")
                {
                    groupbox_allow.Visible = false;
                }
                else
                {
                    groupbox_allow.Visible = true;
                    groupbox_allow.Enabled = true;
                }
                // get allow 
                connection.Open();
                string query_document = "SELECT Allow_document from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd_document = new SqlCommand(query_document, connection); ;
                bool document = Convert.ToBoolean(cmd_document.ExecuteScalar());


                connection.Close();
                cbox_allow_document.Checked = document;




                //#2
                connection.Open();
                string query_history = "SELECT Allow_history from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd_history = new SqlCommand(query_history, connection); ;
                bool history = Convert.ToBoolean(cmd_history.ExecuteScalar());
                connection.Close();
                cbox_allow_history.Checked = history;


                // #3
                connection.Open();
                string query_acc = "SELECT Allow_accountcontrol from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd_account = new SqlCommand(query_acc, connection); ;
                bool _account = Convert.ToBoolean(cmd_account.ExecuteScalar());
                connection.Close();
                cbox_allow_account.Checked = _account;

                // #4
                connection.Open();
                string query_add = "SELECT Allow_add from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd_query_add = new SqlCommand(query_add, connection); ;
                bool _add = Convert.ToBoolean(cmd_query_add.ExecuteScalar());
                connection.Close();
                cbox_add.Checked = _add;

                // #5
                connection.Open();
                string query_edit = "SELECT Allow_edit from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd_query_edit = new SqlCommand(query_edit, connection); ;
                bool _edit = Convert.ToBoolean(cmd_query_edit.ExecuteScalar());
                connection.Close();
                cbox_edit.Checked = _edit;

                // #6
                connection.Open();
                string query_delete = "SELECT Allow_delete from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd_query_delete = new SqlCommand(query_delete, connection); ;
                bool _delete = Convert.ToBoolean(cmd_query_delete.ExecuteScalar());
                connection.Close();
                cbox_delete.Checked = _delete;

                // #7
                connection.Open();
                string query_upload = "SELECT Allow_upload from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd_query_upload = new SqlCommand(query_upload, connection); ;
                bool _upload = Convert.ToBoolean(cmd_query_upload.ExecuteScalar());
                connection.Close();
                cbox_upload.Checked = _upload;

                // #8
                connection.Open();
                string query_import = "SELECT Allow_import from login where MSV='" + tbox_msv.Text + "'";

                SqlCommand cmd_query_import = new SqlCommand(query_import, connection); ;
                bool _import = Convert.ToBoolean(cmd_query_import.ExecuteScalar());
                connection.Close();
                cbox_import.Checked = _import;

                
                if (cbox_add.Checked == true || cbox_edit.Checked == true||cbox_delete.Checked==true||cbox_import.Checked==true||cbox_upload.Checked==true)
                {
                    cbox_questionfunction.Checked = true;
                }
               
                else
                {
                    cbox_questionfunction.Checked = false;
                }

                if (tbox_msv.Text == "admin")
                {
                    cbox_questionfunction.Checked = false;
                    groupbox_question.Visible = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("dataGridView1_CellContentClick "+ex.Message);
            }

            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            MainMenu n = new MainMenu();
            n.Show();
            _instance = new UC_control_Account(); ;
        }

        


        string fileName;
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
       
        private void pic_avatar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Files|*.jpg;*.jpeg;*.png;", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        fileName = ofd.FileName;
                        //      label2.Text = fileName;
                        pic_avatar.Image = Image.FromFile(fileName);
                    }

                }
                DialogResult result = MessageBox.Show("Save", "Change avatar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    using (var db = new quizEntities2())
                    {
                        var new_result = db.logins.SingleOrDefault(b => b.MSV == tbox_msv.Text);
                        if (new_result != null)
                        {

                            new_result.Image = ConvertImageToBinary(pic_avatar.Image);
                            db.SaveChanges();
                        }
                    }
                    MessageBox.Show("Updated");
                    update();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("pic_avatar_Click " + ex.Message);
            }
        }

        private void pic_avatar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Click to change your avatar !",pic_avatar);
        }

        private void cbox_allow_document_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_allow_document.Checked == true)
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_document = @Allow_document where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_document", 1);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_document = @Allow_document where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_document", 0);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("cbox_allow_document_CheckedChanged " + ex.Message);
            }
        }

        private void cbox_allow_history_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_allow_history.Checked == true)
            {
                connection.Open();
                string query = "UPDATE login SET Allow_history = @Allow_history where MSV = @MSV ";
                SqlCommand _sqlA = new SqlCommand(query, connection);

                _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                _sqlA.Parameters.AddWithValue("@Allow_history",1);
                _sqlA.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                connection.Open();
                string query = "UPDATE login SET Allow_history = @Allow_history where MSV = @MSV ";
                SqlCommand _sqlA = new SqlCommand(query, connection);

                _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                _sqlA.Parameters.AddWithValue("@Allow_history",0);
                _sqlA.ExecuteNonQuery();
                connection.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("cbox_allow_history_CheckedChanged " + ex.Message);
            }
        }

        private void cbox_allow_account_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_allow_account.Checked == true)
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_accountcontrol = @Allow_accountcontrol where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_accountcontrol", 1);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_accountcontrol = @Allow_accountcontrol where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_accountcontrol", 0);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("cbox_allow_account_CheckedChanged " + ex.Message);
            }
        }

        private void cbox_questionfunction_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_questionfunction.Checked == true)
            {
                groupbox_question.Visible = true;
            }
            else
            {
                groupbox_question.Visible = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        
          

        }

        private void cbox_add_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_add.Checked == true)
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_add = @Allow_add where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_add", 1);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_add = @Allow_add where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_add", 0);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allow_add " + ex.Message);
            }
        }

        private void cbox_edit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_edit.Checked == true)
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_edit = @Allow_edit where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_edit", 1);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_edit = @Allow_edit where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_edit", 0);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allow_edit " + ex.Message);
            }


        }

        private void cbox_delete_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_delete.Checked == true)
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_delete = @Allow_delete where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_delete", 1);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_delete = @Allow_delete where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_delete", 0);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allow_delete " + ex.Message);
            }
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void UC_control_Account_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
         /*   if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }*/
        }

        private void cbox_upload_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_upload.Checked == true)
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_upload = @Allow_upload where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_upload", 1);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_upload = @Allow_upload where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_upload", 0);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allow_upload " + ex.Message);
            }
        }

        private void cbox_import_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_import.Checked == true)
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_import = @Allow_import where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_import", 1);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE login SET Allow_import = @Allow_import where MSV = @MSV ";
                    SqlCommand _sqlA = new SqlCommand(query, connection);

                    _sqlA.Parameters.AddWithValue("@MSV", tbox_msv.Text);
                    _sqlA.Parameters.AddWithValue("@Allow_import", 0);
                    _sqlA.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allow_import " + ex.Message);
            }
        }
    }
}
