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
    public partial class Form_set_Time : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
        public Form_set_Time()
        {
            InitializeComponent();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_fulltime.Text = tbox_h.Text + ":" + tbox_m.Text + ":" + tbox_s.Text;

                connection.Open();
                string insertQuery = @" UPDATE [List_PDF] SET Time=@Time WHERE ID=@ID ";

                SqlCommand command2 = new SqlCommand(insertQuery, connection);
                command2.Parameters.AddWithValue("@Time", lbl_fulltime.Text);
                command2.Parameters.AddWithValue("@ID", Form_list_PDF.INDEX_);

                command2.ExecuteScalar();


                connection.Close();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Error Form_setTime");
            }
        }

        private void Form_setTime_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

        }
    }
}
