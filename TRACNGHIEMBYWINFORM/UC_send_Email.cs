using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class UC_Send_email : UserControl
    {

        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");


        private static UC_Send_email _instance;
        public static UC_Send_email Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Send_email();
                }
                return _instance;
            }
        }

        
        private void btnTest_Click(object sender, RoutedEventArgs e)
        {

        }

        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        {
            string Text = "";
            SmtpClient mailClient = new SmtpClient("gmail.com");
            MailMessage msgMail;
            Text = "Stuff";
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
            foreach (MailAddress addr in _cc)
            {
                msgMail.CC.Add(addr);
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }
        public UC_Send_email()
        {
            InitializeComponent();

        }


        public string rs;
        public string rs_password;

        private void button1_Click(object sender, EventArgs e)
        {

            // get MSV 
        
            con.Open();
            string query = "SELECT Email from login where MSV='" + tbox_username.Text + "'";

            // Perform the operations here
         
                SqlCommand command = new SqlCommand(query, con);
            
              
         
            // count 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            if(dt.Rows.Count<1)
            {
                MessageBox.Show("Your account is not registered for email !");
            }
            else
            {
                //// get PASSWORD BODY 
             //   con.Open();
                string query_getPassword = "SELECT password from login where MSV='" + tbox_username.Text + "'";

                // Perform the operations here

                SqlCommand cmd_getPassword = new SqlCommand(query_getPassword, con);
                rs_password = cmd_getPassword.ExecuteScalar().ToString();
              //  con.Close();
                ///  MAIL WORKING PROCESS
                rs = command.ExecuteScalar().ToString();
                string username = "robinle1902";
                string password = "01202112615";
                NetworkCredential login = new NetworkCredential(username, password);
                string Smtp = "smtp.gmail.com";
                SmtpClient client = new SmtpClient(Smtp);
                client.Port = Convert.ToInt32("587");
                client.EnableSsl = true;
                client.Credentials = login;
                try
                {
                    MailMessage msg = new MailMessage { From = new MailAddress(username + Smtp.Replace("smtp.", "@"), "Quiz App", Encoding.UTF8) };

                    msg.To.Add(new MailAddress(rs));
                    if (!string.IsNullOrEmpty(""))
                        msg.To.Add(new MailAddress(""));
                    msg.Subject = "Reset Your Password";
                    msg.Body = "Your password of " +tbox_username.Text;
                    msg.Body += ": ("+rs_password+")";
                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.Priority = MailPriority.Normal;
                    msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                    string userstate = "Sending...";
                    //Send email async
                    client.SendAsync(msg, userstate);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            con.Close();
          

            //login to your mail server

            // ensure you are turn on secure app on google

        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
             
             MessageBox.Show("Sent, Check your email ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
               
        }

     
        private void btn_backhome_Click(object sender, EventArgs e)
        {


            this.SendToBack();

        //    Instance.SendToBack();

            
        
        }
       
        private void send_email_Load(object sender, EventArgs e)
        {
          
        }
    }
    }
        
             
            
       



        

    

