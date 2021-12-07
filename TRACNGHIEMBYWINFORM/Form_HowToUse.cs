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
    public partial class Form_HowToUse : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
        public Form_HowToUse()
        {
            InitializeComponent();
        }

        List<Panel> _panels = new List<Panel>();
        int index;

       
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(index < _panels.Count-1)
            {
                index++;
            }
            _panels[index].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                _panels[index].BringToFront();
            }
        }

        private void cbox_not_repeat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand _sqlcommand1 = new SqlCommand("SELECT Checked_Howtouse from login where MSV='" + Form_Begin.usernamestatic + "' ", con);

                string result = _sqlcommand1.ExecuteScalar().ToString();


                con.Close();

                if (result != "1")
                {
                    con.Open();
                    string query = "UPDATE login SET Checked_Howtouse = @Checked_Howtouse where MSV = @MSV ";
                    SqlCommand _sqlcommand2 = new SqlCommand(query, con);

                    _sqlcommand2.Parameters.AddWithValue("@Checked_Howtouse", 1);
                    _sqlcommand2.Parameters.AddWithValue("@MSV", Form_Begin.usernamestatic);
                    _sqlcommand2.ExecuteNonQuery();
                    con.Close();

                    
                }
            }
            catch(Exception)
            {
                string error = "Form_HowToUse";
                MessageBox.Show(error);
            }
        }

        private void Form_HowToUse_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.laptop1;

            {
                panel1.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                panel2.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                panel3.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
             cbox_not_repeat.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_next.BackColor =Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_pre.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                btn_exit.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
                panel_noidung.BackColor = Color.FromArgb(Convert.ToInt32(MainMenu.R), Convert.ToInt32(MainMenu.G), Convert.ToInt32(MainMenu.B));
            }

            _panels.Add(panel1);
            _panels.Add(panel2);
            _panels.Add(panel3);
            _panels[index].BringToFront();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
